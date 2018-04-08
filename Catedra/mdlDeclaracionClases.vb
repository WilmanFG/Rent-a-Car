Imports MySql.Data.MySqlClient
Module mdlDeclaracionClases
    Public Usuarios As clsUsuarios 'Variable para el tipo de clase clsUsuarios
    Public Administradores As clsAdministradores 'Variable para el tipo de clase clsAdministradores
    Public Gerente As clsGerentes 'Variable para el tipo de clase clsGerente
    Public Contador As clsContadores 'Variable para el tipo de clase clsContadores
    Public Agencia As clsAgencias 'Variable para el tipo de clase clsAgencia
    Public Clientes As clsClientes 'Variable para el tipo de clase clsClientes
    Public Coches As clsCoches 'Variable para el tipo de clase clsCoches
    Public Reservas As clsReservas 'Variable para el tipo de clase clsReservas
    Public Rentas As clsRentas 'Variable para el tipo de clase clsRentas
    Public paises As clsPaises 'Variable para el tipo de clase clsPaises
    Public email As clsEmail ''Variable para el tipo de clase clsEmail
    Public Session As EstructuraSession = New EstructuraSession(Nothing, Nothing) 'Estructura creada con el fin de manejo de sesiones
    Structure EstructuraSession 'Estrcutra para el control de sesiones
        '________________________________
        '| Atributos de la estructura    |
        '|_______________________________|
        Private _tipoUsuario As String
        Private _idUsuario As String
        Private _codigoUsuario As String
        '_____________________________________________________
        '|      Propiedades de escritura de la estructura    |
        '|___________________________________________________|
        Public ReadOnly Property ObtenerTipoUsuario() As String
            Get
                Return _tipoUsuario
            End Get
        End Property
        Private ReadOnly Property ObtenerNombreUsuario() As String
            Get
                Return _codigoUsuario
            End Get
        End Property
        Public ReadOnly Property ObtenerIdUsuario() As String
            Get
                Return _idUsuario
            End Get
        End Property
        '_____________________________________________________
        '|      Propiedades de lectura de la estructura      |
        '|___________________________________________________|
        Public WriteOnly Property EstablecerTipoUsuario() As String
            Set(ByVal value As String)
                _tipoUsuario = value
            End Set
        End Property
        Private WriteOnly Property EstablecerNombreUsuario() As String
            Set(ByVal value As String)
                _codigoUsuario = value
            End Set
        End Property
        Public WriteOnly Property EstablecerIdUsuario() As String
            Set(ByVal value As String)
                _idUsuario = value
            End Set
        End Property
        '_____________________________________________________
        '|             Constructor de la estructura          |
        '|___________________________________________________|
        Public Sub New(ByVal _tipo As String, ByVal _id As String)
            _tipoUsuario = _tipo
            _idUsuario = _id
        End Sub
        '_____________________________________________________
        '|               Metodos de la estructura            |
        '|___________________________________________________|
        Public Sub CerrarSession() 'Funcion que estara en todo los eventos click de 'Cerrar Sesión'
            If _tipoUsuario <> Nothing And _idUsuario <> Nothing Then
                'For Each e As Form In Application.OpenForms 'Se cierran los forms abiertos
                'e.Hide()
                'e.Close()
                'Next
                frmInicio_Sesion.Show()
                _tipoUsuario = Nothing
                _idUsuario = Nothing
            End If
        End Sub

        Public Sub ControlarSession() 'Función que estará en todo evento load de cada form
            If _tipoUsuario = Nothing And _idUsuario = Nothing Then
                'For Each f As Form In Application.OpenForms 'Se cierran los forms abiertos
                'f.Close()
                'Next
                frmInicio_Sesion.Show()
            End If
        End Sub

        Public Sub IniciarSesion(ByVal idUsuario As String) 'Define los atributos de la estructura cuando se inicia sesión
            EstablecerNombreUsuario = idUsuario.ToUpper
            Dim reader As MySqlDataReader
            Dim Conexion As New clsConexion()

            If ObtenerNombreUsuario.Substring(0, 1).ToUpper = "A" Then
                EstablecerTipoUsuario = "A"
                Conexion.obtenerDatos("SELECT * FROM usuarios WHERE nombre_usuario = '" & ObtenerNombreUsuario & "'", reader)
                reader.Read()
                EstablecerIdUsuario = CStr(reader(0))
                reader.Close()
            ElseIf ObtenerNombreUsuario.Substring(0, 1).ToUpper = "G" Then
                EstablecerTipoUsuario = "G"
                Conexion.obtenerDatos("SELECT * FROM usuarios WHERE nombre_usuario = '" & ObtenerNombreUsuario & "'", reader)
                reader.Read()
                EstablecerIdUsuario = CStr(reader(0))
                reader.Close()
            ElseIf ObtenerNombreUsuario.Substring(0, 1).ToUpper = "C" Then
                EstablecerTipoUsuario = "C"
                Conexion.obtenerDatos("SELECT * FROM usuarios WHERE nombre_usuario = '" & ObtenerNombreUsuario & "'", reader)
                reader.Read()
                EstablecerIdUsuario = CStr(reader(0))
                reader.Close()
            End If
            frmMenu_Admin.Show()
        End Sub
    End Structure
End Module
