<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.btnAgregar_Cliente = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblEmail = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCiudad = New MaterialSkin.Controls.MaterialLabel()
        Me.txbCiudad = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblDireccion = New MaterialSkin.Controls.MaterialLabel()
        Me.txbDireccion = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txbEmail = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblNombre = New MaterialSkin.Controls.MaterialLabel()
        Me.txbNombre = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblDUI = New MaterialSkin.Controls.MaterialLabel()
        Me.txbDui = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblTelefono = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPais = New MaterialSkin.Controls.MaterialLabel()
        Me.txbTelefono = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPasaporte = New MaterialSkin.Controls.MaterialLabel()
        Me.txbPasaporte = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rbtPasaporte = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbtDui = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lblApellido = New MaterialSkin.Controls.MaterialLabel()
        Me.txbApellido = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cmbPaises = New System.Windows.Forms.ComboBox()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregar_Cliente
        '
        Me.btnAgregar_Cliente.AutoSize = True
        Me.btnAgregar_Cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAgregar_Cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar_Cliente.Depth = 0
        Me.btnAgregar_Cliente.Location = New System.Drawing.Point(296, 393)
        Me.btnAgregar_Cliente.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAgregar_Cliente.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar_Cliente.Name = "btnAgregar_Cliente"
        Me.btnAgregar_Cliente.Primary = False
        Me.btnAgregar_Cliente.Size = New System.Drawing.Size(142, 36)
        Me.btnAgregar_Cliente.TabIndex = 11
        Me.btnAgregar_Cliente.Text = "+ Agregar cliente"
        Me.btnAgregar_Cliente.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Depth = 0
        Me.lblEmail.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(390, 305)
        Me.lblEmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(47, 19)
        Me.lblEmail.TabIndex = 35
        Me.lblEmail.Text = "Email"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Depth = 0
        Me.lblCiudad.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCiudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCiudad.Location = New System.Drawing.Point(40, 361)
        Me.lblCiudad.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(55, 19)
        Me.lblCiudad.TabIndex = 34
        Me.lblCiudad.Text = "Ciudad"
        '
        'txbCiudad
        '
        Me.txbCiudad.Depth = 0
        Me.txbCiudad.Hint = ""
        Me.txbCiudad.Location = New System.Drawing.Point(119, 361)
        Me.txbCiudad.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbCiudad.Name = "txbCiudad"
        Me.txbCiudad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCiudad.SelectedText = ""
        Me.txbCiudad.SelectionLength = 0
        Me.txbCiudad.SelectionStart = 0
        Me.txbCiudad.Size = New System.Drawing.Size(255, 23)
        Me.txbCiudad.TabIndex = 9
        Me.txbCiudad.UseSystemPasswordChar = False
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Depth = 0
        Me.lblDireccion.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDireccion.Location = New System.Drawing.Point(31, 257)
        Me.lblDireccion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(73, 19)
        Me.lblDireccion.TabIndex = 32
        Me.lblDireccion.Text = "Dirección"
        '
        'txbDireccion
        '
        Me.txbDireccion.Depth = 0
        Me.txbDireccion.Hint = ""
        Me.txbDireccion.Location = New System.Drawing.Point(118, 253)
        Me.txbDireccion.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbDireccion.Name = "txbDireccion"
        Me.txbDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbDireccion.SelectedText = ""
        Me.txbDireccion.SelectionLength = 0
        Me.txbDireccion.SelectionStart = 0
        Me.txbDireccion.Size = New System.Drawing.Size(580, 23)
        Me.txbDireccion.TabIndex = 6
        Me.txbDireccion.UseSystemPasswordChar = False
        '
        'txbEmail
        '
        Me.txbEmail.Depth = 0
        Me.txbEmail.Hint = ""
        Me.txbEmail.Location = New System.Drawing.Point(462, 305)
        Me.txbEmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbEmail.SelectedText = ""
        Me.txbEmail.SelectionLength = 0
        Me.txbEmail.SelectionStart = 0
        Me.txbEmail.Size = New System.Drawing.Size(237, 23)
        Me.txbEmail.TabIndex = 8
        Me.txbEmail.UseSystemPasswordChar = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Depth = 0
        Me.lblNombre.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(31, 99)
        Me.lblNombre.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 19)
        Me.lblNombre.TabIndex = 24
        Me.lblNombre.Text = "Nombre"
        '
        'txbNombre
        '
        Me.txbNombre.Depth = 0
        Me.txbNombre.Hint = ""
        Me.txbNombre.Location = New System.Drawing.Point(111, 99)
        Me.txbNombre.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbNombre.SelectedText = ""
        Me.txbNombre.SelectionLength = 0
        Me.txbNombre.SelectionStart = 0
        Me.txbNombre.Size = New System.Drawing.Size(263, 23)
        Me.txbNombre.TabIndex = 0
        Me.txbNombre.UseSystemPasswordChar = False
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Depth = 0
        Me.lblDUI.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblDUI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDUI.Location = New System.Drawing.Point(45, 205)
        Me.lblDUI.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(33, 19)
        Me.lblDUI.TabIndex = 22
        Me.lblDUI.Text = "DUI"
        '
        'txbDui
        '
        Me.txbDui.Depth = 0
        Me.txbDui.Hint = ""
        Me.txbDui.Location = New System.Drawing.Point(97, 205)
        Me.txbDui.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbDui.Name = "txbDui"
        Me.txbDui.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbDui.SelectedText = ""
        Me.txbDui.SelectionLength = 0
        Me.txbDui.SelectionStart = 0
        Me.txbDui.Size = New System.Drawing.Size(259, 23)
        Me.txbDui.TabIndex = 4
        Me.txbDui.UseSystemPasswordChar = False
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Depth = 0
        Me.lblTelefono.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTelefono.Location = New System.Drawing.Point(390, 361)
        Me.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(143, 19)
        Me.lblTelefono.TabIndex = 40
        Me.lblTelefono.Text = "Número de telefono"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Depth = 0
        Me.lblPais.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPais.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPais.Location = New System.Drawing.Point(40, 305)
        Me.lblPais.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(38, 19)
        Me.lblPais.TabIndex = 39
        Me.lblPais.Text = "País"
        '
        'txbTelefono
        '
        Me.txbTelefono.Depth = 0
        Me.txbTelefono.Hint = ""
        Me.txbTelefono.Location = New System.Drawing.Point(539, 357)
        Me.txbTelefono.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbTelefono.SelectedText = ""
        Me.txbTelefono.SelectionLength = 0
        Me.txbTelefono.SelectionStart = 0
        Me.txbTelefono.Size = New System.Drawing.Size(159, 23)
        Me.txbTelefono.TabIndex = 10
        Me.txbTelefono.UseSystemPasswordChar = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(592, 418)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 12
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsCerrar_Sesion})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(733, 27)
        Me.mnsMenu.TabIndex = 53
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsCerrar_Sesion
        '
        Me.mnsCerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnsCerrar_Sesion.Name = "mnsCerrar_Sesion"
        Me.mnsCerrar_Sesion.Size = New System.Drawing.Size(102, 23)
        Me.mnsCerrar_Sesion.Text = "Cerrar Sesión"
        '
        'lblPasaporte
        '
        Me.lblPasaporte.AutoSize = True
        Me.lblPasaporte.Depth = 0
        Me.lblPasaporte.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPasaporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPasaporte.Location = New System.Drawing.Point(386, 209)
        Me.lblPasaporte.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPasaporte.Name = "lblPasaporte"
        Me.lblPasaporte.Size = New System.Drawing.Size(77, 19)
        Me.lblPasaporte.TabIndex = 55
        Me.lblPasaporte.Text = "Pasaporte"
        '
        'txbPasaporte
        '
        Me.txbPasaporte.Depth = 0
        Me.txbPasaporte.Hint = ""
        Me.txbPasaporte.Location = New System.Drawing.Point(475, 205)
        Me.txbPasaporte.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbPasaporte.Name = "txbPasaporte"
        Me.txbPasaporte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbPasaporte.SelectedText = ""
        Me.txbPasaporte.SelectionLength = 0
        Me.txbPasaporte.SelectionStart = 0
        Me.txbPasaporte.Size = New System.Drawing.Size(224, 23)
        Me.txbPasaporte.TabIndex = 5
        Me.txbPasaporte.UseSystemPasswordChar = False
        '
        'rbtPasaporte
        '
        Me.rbtPasaporte.AutoSize = True
        Me.rbtPasaporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtPasaporte.Depth = 0
        Me.rbtPasaporte.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbtPasaporte.Location = New System.Drawing.Point(539, 126)
        Me.rbtPasaporte.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtPasaporte.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbtPasaporte.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbtPasaporte.Name = "rbtPasaporte"
        Me.rbtPasaporte.Ripple = True
        Me.rbtPasaporte.Size = New System.Drawing.Size(92, 30)
        Me.rbtPasaporte.TabIndex = 3
        Me.rbtPasaporte.TabStop = True
        Me.rbtPasaporte.Text = "Pasaporte"
        Me.rbtPasaporte.UseVisualStyleBackColor = True
        '
        'rbtDui
        '
        Me.rbtDui.AutoSize = True
        Me.rbtDui.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtDui.Depth = 0
        Me.rbtDui.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbtDui.Location = New System.Drawing.Point(414, 126)
        Me.rbtDui.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtDui.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbtDui.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbtDui.Name = "rbtDui"
        Me.rbtDui.Ripple = True
        Me.rbtDui.Size = New System.Drawing.Size(49, 30)
        Me.rbtDui.TabIndex = 2
        Me.rbtDui.TabStop = True
        Me.rbtDui.Text = "Dui"
        Me.rbtDui.UseVisualStyleBackColor = True
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Depth = 0
        Me.lblApellido.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblApellido.Location = New System.Drawing.Point(31, 146)
        Me.lblApellido.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(64, 19)
        Me.lblApellido.TabIndex = 60
        Me.lblApellido.Text = "Apellido"
        '
        'txbApellido
        '
        Me.txbApellido.Depth = 0
        Me.txbApellido.Hint = ""
        Me.txbApellido.Location = New System.Drawing.Point(111, 146)
        Me.txbApellido.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbApellido.Name = "txbApellido"
        Me.txbApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbApellido.SelectedText = ""
        Me.txbApellido.SelectionLength = 0
        Me.txbApellido.SelectionStart = 0
        Me.txbApellido.Size = New System.Drawing.Size(263, 23)
        Me.txbApellido.TabIndex = 1
        Me.txbApellido.UseSystemPasswordChar = False
        '
        'cmbPaises
        '
        Me.cmbPaises.FormattingEnabled = True
        Me.cmbPaises.Location = New System.Drawing.Point(119, 306)
        Me.cmbPaises.Name = "cmbPaises"
        Me.cmbPaises.Size = New System.Drawing.Size(255, 21)
        Me.cmbPaises.TabIndex = 7
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 457)
        Me.Controls.Add(Me.cmbPaises)
        Me.Controls.Add(Me.txbApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.rbtPasaporte)
        Me.Controls.Add(Me.rbtDui)
        Me.Controls.Add(Me.lblPasaporte)
        Me.Controls.Add(Me.txbPasaporte)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.btnAgregar_Cliente)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblCiudad)
        Me.Controls.Add(Me.txbCiudad)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txbDireccion)
        Me.Controls.Add(Me.txbEmail)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.lblDUI)
        Me.Controls.Add(Me.txbDui)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de usuarios                                                             " &
    "                                                      Rent-a-Car"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregar_Cliente As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblEmail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCiudad As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbCiudad As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblDireccion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbDireccion As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txbEmail As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblNombre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbNombre As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblDUI As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbDui As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblTelefono As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPais As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbTelefono As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
    Friend WithEvents lblPasaporte As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbPasaporte As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rbtPasaporte As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbtDui As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents lblApellido As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbApellido As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cmbPaises As ComboBox
End Class
