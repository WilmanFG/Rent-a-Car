Imports MaterialSkin
Public Class frmUsuarios
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession() 'controlador de sesion
    End Sub

    Private Sub btnAgregar_Usuario_Click(sender As Object, e As EventArgs) Handles btnAgregar_Usuario.Click
        'Elegimos que clase instanciar
        If rdbAdministrador.Checked = True Then
            Administradores = New clsAdministradores
            If Administradores.Registrar(txbNombre.Text, txbApellido.Text, txbCorreo.Text) Then
                MsgBox("Registro Exitoso: Se ha enviado los datos al correo", MsgBoxStyle.Information)
                InicializarFormulario()
            End If
        ElseIf rdbAgente.Checked = True Then
            Gerente = New clsGerentes
            If Gerente.Registrar(txbNombre.Text, txbApellido.Text, txbCorreo.Text) Then
                MsgBox("Registro Exitoso: Se ha enviado los datos al correo", MsgBoxStyle.Information)
                InicializarFormulario()
            End If
        ElseIf rdbContador.Checked = True Then
            Contador = New clsContadores
            If Contador.Registrar(txbNombre.Text, txbApellido.Text, txbCorreo.Text) Then
                MsgBox("Registro Exitoso: Se ha enviado los datos al correo", MsgBoxStyle.Information)
                InicializarFormulario()
            End If
        Else
            MsgBox("Error: Seleccione un tipo de usuario", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession() 'Cerrar sesión
        Me.Close()
    End Sub
    Private Sub InicializarFormulario()
        txbNombre.Text = ""
        txbApellido.Text = ""
        txbCorreo.Text = ""
        rdbAdministrador.Checked = False
        rdbAgente.Checked = False
        rdbContador.Checked = False
    End Sub
End Class