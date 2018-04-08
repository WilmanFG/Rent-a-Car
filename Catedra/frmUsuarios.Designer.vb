<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
    Inherits MaterialSkin.Controls.MaterialForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAgregar_Usuario = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblNombre = New MaterialSkin.Controls.MaterialLabel()
        Me.txbNombre = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblApellido = New MaterialSkin.Controls.MaterialLabel()
        Me.txbApellido = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblPerfil = New MaterialSkin.Controls.MaterialLabel()
        Me.rdbAdministrador = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdbContador = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdbAgente = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btn_Regresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCorreo = New MaterialSkin.Controls.MaterialLabel()
        Me.txbCorreo = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregar_Usuario
        '
        Me.btnAgregar_Usuario.AutoSize = True
        Me.btnAgregar_Usuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAgregar_Usuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar_Usuario.Depth = 0
        Me.btnAgregar_Usuario.Location = New System.Drawing.Point(131, 283)
        Me.btnAgregar_Usuario.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAgregar_Usuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar_Usuario.Name = "btnAgregar_Usuario"
        Me.btnAgregar_Usuario.Primary = False
        Me.btnAgregar_Usuario.Size = New System.Drawing.Size(146, 36)
        Me.btnAgregar_Usuario.TabIndex = 6
        Me.btnAgregar_Usuario.Text = "+ Agregar usuario"
        Me.btnAgregar_Usuario.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Depth = 0
        Me.lblNombre.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(34, 143)
        Me.lblNombre.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 19)
        Me.lblNombre.TabIndex = 44
        Me.lblNombre.Text = "Nombre"
        '
        'txbNombre
        '
        Me.txbNombre.Depth = 0
        Me.txbNombre.Hint = ""
        Me.txbNombre.Location = New System.Drawing.Point(113, 139)
        Me.txbNombre.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbNombre.SelectedText = ""
        Me.txbNombre.SelectionLength = 0
        Me.txbNombre.SelectionStart = 0
        Me.txbNombre.Size = New System.Drawing.Size(267, 23)
        Me.txbNombre.TabIndex = 0
        Me.txbNombre.UseSystemPasswordChar = False
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Depth = 0
        Me.lblApellido.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblApellido.Location = New System.Drawing.Point(33, 186)
        Me.lblApellido.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(64, 19)
        Me.lblApellido.TabIndex = 42
        Me.lblApellido.Text = "Apellido"
        '
        'txbApellido
        '
        Me.txbApellido.Depth = 0
        Me.txbApellido.Hint = ""
        Me.txbApellido.Location = New System.Drawing.Point(113, 182)
        Me.txbApellido.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbApellido.Name = "txbApellido"
        Me.txbApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbApellido.SelectedText = ""
        Me.txbApellido.SelectionLength = 0
        Me.txbApellido.SelectionStart = 0
        Me.txbApellido.Size = New System.Drawing.Size(267, 23)
        Me.txbApellido.TabIndex = 1
        Me.txbApellido.UseSystemPasswordChar = False
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.Depth = 0
        Me.lblPerfil.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPerfil.Location = New System.Drawing.Point(33, 88)
        Me.lblPerfil.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(44, 19)
        Me.lblPerfil.TabIndex = 55
        Me.lblPerfil.Text = "Perfil"
        '
        'rdbAdministrador
        '
        Me.rdbAdministrador.AutoSize = True
        Me.rdbAdministrador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbAdministrador.Depth = 0
        Me.rdbAdministrador.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbAdministrador.Location = New System.Drawing.Point(282, 83)
        Me.rdbAdministrador.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbAdministrador.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbAdministrador.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbAdministrador.Name = "rdbAdministrador"
        Me.rdbAdministrador.Ripple = True
        Me.rdbAdministrador.Size = New System.Drawing.Size(117, 30)
        Me.rdbAdministrador.TabIndex = 5
        Me.rdbAdministrador.TabStop = True
        Me.rdbAdministrador.Text = "Administrador"
        Me.rdbAdministrador.UseVisualStyleBackColor = True
        '
        'rdbContador
        '
        Me.rdbContador.AutoSize = True
        Me.rdbContador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbContador.Depth = 0
        Me.rdbContador.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbContador.Location = New System.Drawing.Point(87, 83)
        Me.rdbContador.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbContador.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbContador.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbContador.Name = "rdbContador"
        Me.rdbContador.Ripple = True
        Me.rdbContador.Size = New System.Drawing.Size(86, 30)
        Me.rdbContador.TabIndex = 3
        Me.rdbContador.TabStop = True
        Me.rdbContador.Text = "Contador"
        Me.rdbContador.UseVisualStyleBackColor = True
        '
        'rdbAgente
        '
        Me.rdbAgente.AutoSize = True
        Me.rdbAgente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbAgente.Depth = 0
        Me.rdbAgente.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbAgente.Location = New System.Drawing.Point(188, 83)
        Me.rdbAgente.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbAgente.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbAgente.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbAgente.Name = "rdbAgente"
        Me.rdbAgente.Ripple = True
        Me.rdbAgente.Size = New System.Drawing.Size(73, 30)
        Me.rdbAgente.TabIndex = 4
        Me.rdbAgente.TabStop = True
        Me.rdbAgente.Text = "Agente"
        Me.rdbAgente.UseVisualStyleBackColor = True
        '
        'btn_Regresar
        '
        Me.btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Regresar.Depth = 0
        Me.btn_Regresar.Location = New System.Drawing.Point(298, 329)
        Me.btn_Regresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_Regresar.Name = "btn_Regresar"
        Me.btn_Regresar.Primary = True
        Me.btn_Regresar.Size = New System.Drawing.Size(106, 27)
        Me.btn_Regresar.TabIndex = 7
        Me.btn_Regresar.Text = "Regresar"
        Me.btn_Regresar.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsCerrar_Sesion})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(416, 27)
        Me.mnsMenu.TabIndex = 78
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsCerrar_Sesion
        '
        Me.mnsCerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnsCerrar_Sesion.Name = "mnsCerrar_Sesion"
        Me.mnsCerrar_Sesion.Size = New System.Drawing.Size(102, 23)
        Me.mnsCerrar_Sesion.Text = "Cerrar Sesión"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Depth = 0
        Me.lblCorreo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCorreo.Location = New System.Drawing.Point(33, 229)
        Me.lblCorreo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(140, 19)
        Me.lblCorreo.TabIndex = 79
        Me.lblCorreo.Text = "Correo Electrónico:"
        '
        'txbCorreo
        '
        Me.txbCorreo.Depth = 0
        Me.txbCorreo.Hint = ""
        Me.txbCorreo.Location = New System.Drawing.Point(179, 229)
        Me.txbCorreo.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbCorreo.Name = "txbCorreo"
        Me.txbCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCorreo.SelectedText = ""
        Me.txbCorreo.SelectionLength = 0
        Me.txbCorreo.SelectionStart = 0
        Me.txbCorreo.Size = New System.Drawing.Size(201, 23)
        Me.txbCorreo.TabIndex = 2
        Me.txbCorreo.UseSystemPasswordChar = False
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 388)
        Me.Controls.Add(Me.txbCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.btn_Regresar)
        Me.Controls.Add(Me.rdbAgente)
        Me.Controls.Add(Me.rdbContador)
        Me.Controls.Add(Me.rdbAdministrador)
        Me.Controls.Add(Me.lblPerfil)
        Me.Controls.Add(Me.btnAgregar_Usuario)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txbApellido)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Usuarios                                      Rent-a-Car      "
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar_Usuario As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblNombre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbNombre As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblApellido As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbApellido As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblPerfil As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents rdbAdministrador As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbContador As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbAgente As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btn_Regresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
    Friend WithEvents lblCorreo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbCorreo As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
