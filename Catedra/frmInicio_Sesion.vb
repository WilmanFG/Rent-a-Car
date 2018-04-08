Imports MaterialSkin
Public Class frmInicio_Sesion
    Private Sub frmInicio_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Usuarios = New clsUsuarios 'Instacia de la clase para usuarios
    End Sub

    Private Sub btnIniciar_sesion_Click(sender As Object, e As EventArgs) Handles btnIniciar_sesion.Click
        If Usuarios.IniciarSesion(txbNombre_Usuario.Text, txbContraseña.Text) Then 'Inicio de sesión
            Me.Close()
        End If
    End Sub

    Private Sub btnRecuperar_Contraseña_Click(sender As Object, e As EventArgs) Handles btnRecuperar_Contraseña.Click
        'Proceso de recuperación de contraseña
        Dim correoElectronico As String = ""
        correoElectronico = InputBox("Ingrese su nombre de usuario") 'Inputbox para ingresar el código de usuario
        If Usuarios.recuperarContrasenna(correoElectronico) Then 'Proceso para recupear contraseña
            MsgBox("Contraseña enviada a su correo electrónico", MsgBoxStyle.Information)
        End If
    End Sub
End Class