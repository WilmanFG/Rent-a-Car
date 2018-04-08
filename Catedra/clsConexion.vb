Imports MySql.Data.MySqlClient
Public Class clsConexion
    '____________________________
    '|   Atributos de la clase   |
    '|___________________________|
    Private _cmd As MySqlCommand
    Private _mysqlAdapter As MySqlDataAdapter
    Private _tabla As DataTable
    Private _aceptarConexion As Boolean
    Private Encriptacion As clsEncriptacion = New clsEncriptacion()
    Private _conn As MySqlConnection = New MySqlConnection("server = 127.0.0.1; database = rent_a_car; user = root; port = 3306; Convert Zero Datetime=True")
    '_____________________________
    '|   Constructor de la clase  |
    '|____________________________|
    Public Sub New()
        Try
            _conn.Open()
            _aceptarConexion = True
            _conn.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error en la conexión", MsgBoxStyle.Critical)
            _aceptarConexion = False
        End Try
    End Sub
    '___________________________________
    '|   Metodos generales de la clase  |
    '|__________________________________|
    Public Function modificarDatos(ByVal consulta As String, Optional ByRef idInsertado As Integer = -1) As Boolean
        Dim result As Boolean
        'Aqui se realizan operaciones como: UPDATE, DELETE, INSERT

        _conn.Close() 'Se cierra la conexión previa

        If _aceptarConexion Then
            _conn.Open() 'Se abre la conexión
            _cmd = New MySqlCommand(consulta, _conn) 'Se ejecuta la consulta

            If idInsertado = -1 Then
                result = _cmd.ExecuteNonQuery 'Se ejecuta la consulta en modo NonQuery
            Else
                idInsertado = CInt(_cmd.ExecuteScalar())
                If Not IsNothing(idInsertado) Then result = True Else result = False
            End If

            Return result
        End If

        Return False
    End Function
    Public Function existenciaUsuario(ByVal consulta As String, ByVal contrasenna As String) As Boolean 'Función dirigida hacia el login
        _conn.Close() 'Se cierra la conexión a la BDD
        _conn.Open() 'Se abre la conexion
        _cmd = New MySqlCommand(consulta, _conn) 'Se ejecuta la consulta
        Dim reader As MySqlDataReader = _cmd.ExecuteReader() 'Se ejecuta la consulta en modo lectura

        If reader.HasRows Then
            reader.Read()
            If Encriptacion.DesarmarEncriptacion(reader(4)) = contrasenna Then
                reader.Close()
                Return 1 'Contraseñas coinciden
            Else
                reader.Close()
                Return 0 'Contraseñas no coinciden
            End If
        End If
        reader.Close()
        Return 0 'No hay usuario con dicho nombre de usuario
    End Function

    Public Sub obtenerDatos(ByVal consulta As String, ByRef reader As MySqlDataReader)
        _conn.Close() 'Se cierra la conexión a la BDD
        _conn.Open() 'Se abre la conexion
        _cmd = New MySqlCommand(consulta, _conn) 'Se ejecuta la consulta
        reader = _cmd.ExecuteReader() 'Se ejecuta la consulta en modo lectura
    End Sub

    Public Sub llenarCombo(ByRef cmb As ComboBox, ByVal consulta As String, ByVal campoLlave As Integer, ByVal campoTexto As Integer)
        Dim dataReader As MySqlDataReader
        Dim dataset As New Dictionary(Of String, String)()
        dataset.Add(0, "Selecciona una opción")

        MyClass.obtenerDatos(consulta, dataReader)
        If dataReader.HasRows Then
            Do While dataReader.Read()
                dataset.Add(dataReader.GetString(campoLlave), dataReader.GetString(campoTexto))
            Loop
        End If

        cmb.DataSource = New BindingSource(dataset, Nothing)
        cmb.DisplayMember = "Value"
        cmb.ValueMember = "Key"
    End Sub

    Public Function contarFilas(ByVal consulta As String) As Integer
        _conn.Close()
        _conn.Open()
        _cmd = New MySqlCommand(consulta, _conn) 'Se ejecuta la consulta
        Dim reader As MySqlDataReader = _cmd.ExecuteReader() 'Se ejecuta la consulta en modo lectura
        Dim i As Integer = 0
        If reader.HasRows Then
            While reader.Read()
                i += 1
            End While
        End If
        reader.Close()
        Return i
    End Function
End Class
