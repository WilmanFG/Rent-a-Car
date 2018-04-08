Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class clsUsuarios
    'Atributos de clase
    Friend Nombres As String
    Friend Apellidos As String
    Friend Contrasenna As String
    Friend tipoUsuario As String
    Friend NombreUsuario As String
    Private Conexion As clsConexion = New clsConexion() 'Tipo de atributo para la conexión a la BDD
    Private Encriptacion As clsEncriptacion = New clsEncriptacion() 'Tipo de atributo para encriptar
    Private Email As clsEmail = New clsEmail
    Private alfabeto = New String(63) {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    '________________________________________________
    '|      Propiedades de lectura de la clase       |
    '|_______________________________________________|
    Public ReadOnly Property ObtenerNombre() As String
        Get
            Return Nombres
        End Get
    End Property
    Public ReadOnly Property ObtenerApellidos() As String
        Get
            Return Apellidos
        End Get
    End Property
    Public ReadOnly Property ObtenerContrasenna() As String
        Get
            Return Encriptacion.DesarmarEncriptacion(Contrasenna)
        End Get
    End Property
    Public ReadOnly Property ObtenerTipoUsuario() As String
        Get
            Return tipoUsuario
        End Get
    End Property
    Public ReadOnly Property ObtenerNombreUsuario() As String
        Get
            Return NombreUsuario
        End Get
    End Property
    '_________________________________
    '| Constructor de la clase       |
    '|_______________________________|
    Public Sub New()
        Nombres = ""
        Apellidos = ""
        Contrasenna = ""
        NombreUsuario = ""
    End Sub
    '_________________________________
    '|    Metodos de la clase        |
    '|_______________________________|
    Public Function IniciarSesion(ByVal _nombreUsuario As String, ByVal _contrasenna As String) As Boolean
        _nombreUsuario = _nombreUsuario.Trim
        Dim rgx_usuarios = New Regex("^(A{1}|G{1}|C{1})\d{5}$") 'Regex de validacion de usuario

        If _nombreUsuario.Length = 0 Or Not rgx_usuarios.IsMatch(_nombreUsuario.ToUpper) Then 'Se verifica la regex y validación
            MsgBox("Error: Ingrese un nombre de usuario válido", MsgBoxStyle.Critical)
            Return False
        End If

        _contrasenna = _contrasenna.Trim
        NombreUsuario = _nombreUsuario.ToUpper
        Contrasenna = _contrasenna
        'Se verifica la existencia del usuario en la BDD
        If Conexion.existenciaUsuario("SELECT * FROM usuarios WHERE nombre_usuario = '" & NombreUsuario & "'", Contrasenna) Then
            Session.IniciarSesion(NombreUsuario) 'Se inicia la sesión de la estructura
            Return True
        Else
            MsgBox("Error: El usuario ingresado es incorrecto", MsgBoxStyle.Critical)
            Return False
        End If
    End Function

    Friend Function Registrar(ByVal _nombres As String, ByVal _apellidos As String, ByVal _tipoUsuario As String, ByVal _correo As String) As Boolean
        'Tipos de usuarios: Administrador(A00000), Gerente(G0000), Contador(C0000)
        MyClass.CrearCodigo(_tipoUsuario) 'Se crea el código de usuario
        MyClass.CrearContrasenna() 'Se crea la contraseña de usuario
        If verificarCorreoElectronico(_correo) = 0 Then 'Se verifica que no haya un correo electrónico igual en la BDD
            If Conexion.modificarDatos("INSERT INTO usuarios(nombre, apellido, nombre_usuario, contraseña, perfil, correo_electronico) VALUES('" & _nombres & "', '" & _apellidos & "', '" & NombreUsuario & "', '" & Contrasenna & "' , '" & _tipoUsuario & "', '" & _correo & "')") Then
                Email.Registro(_correo, NombreUsuario, Encriptacion.DesarmarEncriptacion(Contrasenna))
                Return True
            End If
        Else
            MsgBox("Error: El email ingresado ya existe como usuario", MsgBoxStyle.Exclamation)
        End If
        Return False
    End Function
    Public Sub CrearCodigo(ByVal _tipousuario As String)
        Dim _nombreUsuario As String
        Dim rnd As New Random()
        Dim repetir As Boolean = True

        While repetir 'Se repite mientras el código de usuario exista en la BDD
            _nombreUsuario = ""
            If _tipousuario = "Administrador" Then 'Se guarda el carcater identificador
                _nombreUsuario += "A"
            ElseIf _tipousuario = "Contador" Then
                _nombreUsuario += "C"
            ElseIf _tipousuario = "Gerente" Then
                _nombreUsuario += "G"
            Else
                Exit Sub
            End If

            For i As Byte = 0 To 4 'Se crean los digitos aleatorios
                _nombreUsuario += CStr(rnd.Next(0, 9)) 'Rand para números aleatorios para el nombre de usuario
            Next

            If Not MyClass.VerificarCodigoUsuario(_nombreUsuario) Then 'Se verifica la existencia de un nombre de usuario formulado en la BDD
                NombreUsuario = _nombreUsuario 'Se guarda en el atributo
                repetir = False
            End If
        End While
    End Sub
    Public Sub CrearContrasenna() 'Función para crear la contraseña
        Dim rnd As New Random
        For i As Byte = 0 To 7
            Contrasenna += alfabeto(rnd.Next(0, 63))
        Next
        MyClass.ArmarEncriptacion()
    End Sub
    Private Sub ArmarEncriptacion()  'Se encripta la contraseña
        Contrasenna = Encriptacion.ArmarEncriptacion(Contrasenna)
    End Sub
    Public Function DesarmarEncriptacion(ByVal _contrasenna As String) As String 'Se desencripta la contraseña
        Return Encriptacion.DesarmarEncriptacion(_contrasenna)
    End Function
    Private Function VerificarCodigoUsuario(ByVal _nombreUsuario As String) As Boolean 'Verifica la existencia del codigo de usuario en la BDD
        If Conexion.contarFilas("SELECT * FROM usuarios WHERE nombre_usuario = '" & _nombreUsuario & "'") = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function verificarCorreoElectronico(ByVal _correo As String) As Integer 'Verifica la existencia de un correo electronico en la BD
        Return Conexion.contarFilas("SELECT * FROM usuarios WHERE correo_electronico = '" & _correo & "'")
    End Function
    Public Function recuperarContrasenna(ByVal NUsuario As String) As Boolean 'Proceso para recuparar contraseña
        If Not _noCoincide("^C{1}|A{1}|C{1}\d{5}$", NUsuario.ToUpper) Then
            If Conexion.contarFilas("SELECT * FROM usuarios WHERE nombre_usuario = '" & NUsuario.ToUpper & "'") > 0 Then 'Se verifica que el nombre de usuario exista en la BD
                Dim reader As MySqlDataReader

                'Se obtienen los datos según el nombre de usuario
                Conexion.obtenerDatos("SELECT correo_electronico ,contraseña FROM usuarios WHERE nombre_usuario = '" & NUsuario.ToUpper & "'", reader)
                reader.Read() 'Se abre la variable de lectura
                If Email.RecuperarContrasenna(CStr(reader(0)), Encriptacion.DesarmarEncriptacion(CStr(reader(1)))) Then 'Se manda la contraseña al correo
                    reader.Close() 'Se cierra la variable de lectura
                    Return True
                End If
                Return False
            Else
                MsgBox("Error: Usuario no encontrado", MsgBoxStyle.Critical)
                Return False
            End If
        Else
            MsgBox("Erro: Ingrese un código de usuario válido", MsgBoxStyle.Critical)
            Return False
        End If
    End Function
End Class
