<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperar_Cuenta
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
        Me.lblCorreo = New MaterialSkin.Controls.MaterialLabel()
        Me.txbCorreo = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txbNombre_Completo = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblNombre_Completo = New MaterialSkin.Controls.MaterialLabel()
        Me.rdbNombre_Usuario = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdbCotraseña = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lblRecordar = New MaterialSkin.Controls.MaterialLabel()
        Me.btnRestaurar_Cuenta = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Depth = 0
        Me.lblCorreo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCorreo.Location = New System.Drawing.Point(36, 100)
        Me.lblCorreo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(125, 19)
        Me.lblCorreo.TabIndex = 0
        Me.lblCorreo.Text = "Ingresa tu Correo"
        '
        'txbCorreo
        '
        Me.txbCorreo.Depth = 0
        Me.txbCorreo.Hint = ""
        Me.txbCorreo.Location = New System.Drawing.Point(40, 142)
        Me.txbCorreo.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbCorreo.Name = "txbCorreo"
        Me.txbCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCorreo.SelectedText = ""
        Me.txbCorreo.SelectionLength = 0
        Me.txbCorreo.SelectionStart = 0
        Me.txbCorreo.Size = New System.Drawing.Size(302, 23)
        Me.txbCorreo.TabIndex = 1
        Me.txbCorreo.UseSystemPasswordChar = False
        '
        'txbNombre_Completo
        '
        Me.txbNombre_Completo.Depth = 0
        Me.txbNombre_Completo.Hint = ""
        Me.txbNombre_Completo.Location = New System.Drawing.Point(40, 219)
        Me.txbNombre_Completo.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbNombre_Completo.Name = "txbNombre_Completo"
        Me.txbNombre_Completo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbNombre_Completo.SelectedText = ""
        Me.txbNombre_Completo.SelectionLength = 0
        Me.txbNombre_Completo.SelectionStart = 0
        Me.txbNombre_Completo.Size = New System.Drawing.Size(302, 23)
        Me.txbNombre_Completo.TabIndex = 3
        Me.txbNombre_Completo.UseSystemPasswordChar = False
        '
        'lblNombre_Completo
        '
        Me.lblNombre_Completo.AutoSize = True
        Me.lblNombre_Completo.Depth = 0
        Me.lblNombre_Completo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblNombre_Completo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNombre_Completo.Location = New System.Drawing.Point(36, 177)
        Me.lblNombre_Completo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNombre_Completo.Name = "lblNombre_Completo"
        Me.lblNombre_Completo.Size = New System.Drawing.Size(198, 19)
        Me.lblNombre_Completo.TabIndex = 2
        Me.lblNombre_Completo.Text = "Ingresa tu nombre completo"
        '
        'rdbNombre_Usuario
        '
        Me.rdbNombre_Usuario.AutoSize = True
        Me.rdbNombre_Usuario.Depth = 0
        Me.rdbNombre_Usuario.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbNombre_Usuario.Location = New System.Drawing.Point(55, 297)
        Me.rdbNombre_Usuario.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbNombre_Usuario.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbNombre_Usuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbNombre_Usuario.Name = "rdbNombre_Usuario"
        Me.rdbNombre_Usuario.Ripple = True
        Me.rdbNombre_Usuario.Size = New System.Drawing.Size(129, 30)
        Me.rdbNombre_Usuario.TabIndex = 4
        Me.rdbNombre_Usuario.TabStop = True
        Me.rdbNombre_Usuario.Text = "Nombre Usuario"
        Me.rdbNombre_Usuario.UseVisualStyleBackColor = True
        '
        'rdbCotraseña
        '
        Me.rdbCotraseña.AutoSize = True
        Me.rdbCotraseña.Depth = 0
        Me.rdbCotraseña.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbCotraseña.Location = New System.Drawing.Point(233, 297)
        Me.rdbCotraseña.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbCotraseña.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbCotraseña.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbCotraseña.Name = "rdbCotraseña"
        Me.rdbCotraseña.Ripple = True
        Me.rdbCotraseña.Size = New System.Drawing.Size(100, 30)
        Me.rdbCotraseña.TabIndex = 5
        Me.rdbCotraseña.TabStop = True
        Me.rdbCotraseña.Text = "Contraseña"
        Me.rdbCotraseña.UseVisualStyleBackColor = True
        '
        'lblRecordar
        '
        Me.lblRecordar.AutoSize = True
        Me.lblRecordar.Depth = 0
        Me.lblRecordar.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblRecordar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRecordar.Location = New System.Drawing.Point(107, 256)
        Me.lblRecordar.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblRecordar.Name = "lblRecordar"
        Me.lblRecordar.Size = New System.Drawing.Size(191, 19)
        Me.lblRecordar.TabIndex = 6
        Me.lblRecordar.Text = "El que no puedes recordar?"
        '
        'btnRestaurar_Cuenta
        '
        Me.btnRestaurar_Cuenta.AutoSize = True
        Me.btnRestaurar_Cuenta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRestaurar_Cuenta.Depth = 0
        Me.btnRestaurar_Cuenta.Location = New System.Drawing.Point(131, 345)
        Me.btnRestaurar_Cuenta.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRestaurar_Cuenta.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRestaurar_Cuenta.Name = "btnRestaurar_Cuenta"
        Me.btnRestaurar_Cuenta.Primary = False
        Me.btnRestaurar_Cuenta.Size = New System.Drawing.Size(146, 36)
        Me.btnRestaurar_Cuenta.TabIndex = 7
        Me.btnRestaurar_Cuenta.Text = "Restaurar Cuenta"
        Me.btnRestaurar_Cuenta.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(288, 388)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 53
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frmRecuperar_Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 427)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnRestaurar_Cuenta)
        Me.Controls.Add(Me.lblRecordar)
        Me.Controls.Add(Me.rdbCotraseña)
        Me.Controls.Add(Me.rdbNombre_Usuario)
        Me.Controls.Add(Me.txbNombre_Completo)
        Me.Controls.Add(Me.lblNombre_Completo)
        Me.Controls.Add(Me.txbCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Name = "frmRecuperar_Cuenta"
        Me.Text = "Recupera tu cuenta                                    Rent-a-Car"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCorreo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbCorreo As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txbNombre_Completo As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblNombre_Completo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents rdbNombre_Usuario As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbCotraseña As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents lblRecordar As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnRestaurar_Cuenta As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
End Class
