Imports MaterialSkin
Public Class frmClientes
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        InicializarFormulario() 'Se reestablecen los valores por defecto del formulario
        Session.ControlarSession() 'Controla la sesión
    End Sub

    Private Sub btnAgregar_Cliente_Click(sender As Object, e As EventArgs) Handles btnAgregar_Cliente.Click
        Clientes = New clsClientes 'Se inicializa objeto de tipo cliente
        Dim tipoIngreso As Boolean
        'Se lleva a cabo el proceso de registro

        'Se verifica si es extranjero o nacional
        If rbtDui.Checked = True Then
            tipoIngreso = False
        ElseIf rbtPasaporte.Checked = True Then
            tipoIngreso = True
        Else
            MsgBox("Error: Dui(Nacional), Pasaporte(Extranjero)", MsgBoxStyle.Critical)
        End If

        If Clientes.registrarDatos(txbDui.Text, txbPasaporte.Text, txbNombre.Text, txbApellido.Text, txbDireccion.Text, txbCiudad.Text, txbEmail.Text, cmbPaises.SelectedIndex + 1, txbTelefono.Text, tipoIngreso) Then
            InicializarFormulario() 'Reestablecemos el formulario
            MsgBox("Registro Exitoso", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession() 'Cerrar Sesión
        Me.Close()
    End Sub
    Private Sub InicializarFormulario()
        'Se enlistan los paises registrados en la BDD
        paises = New clsPaises()
        paises.Listar(cmbPaises)

        'se limpia campos
        txbNombre.Text = ""
        txbApellido.Text = ""
        rbtDui.Checked = False
        rbtPasaporte.Checked = False
        txbDui.Text = ""
        txbPasaporte.Text = ""
        txbDireccion.Text = ""
        txbEmail.Text = ""
        txbCiudad.Text = ""
        txbTelefono.Text = ""
    End Sub
End Class