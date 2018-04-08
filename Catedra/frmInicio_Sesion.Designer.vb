<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio_Sesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio_Sesion))
        Me.btnIniciar_sesion = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txbNombre_Usuario = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblNombre_Usuario = New MaterialSkin.Controls.MaterialLabel()
        Me.txbContraseña = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblContraseña = New MaterialSkin.Controls.MaterialLabel()
        Me.pcbIcono = New System.Windows.Forms.PictureBox()
        Me.btnRecuperar_Contraseña = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.pcbIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIniciar_sesion
        '
        Me.btnIniciar_sesion.AutoSize = True
        Me.btnIniciar_sesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnIniciar_sesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciar_sesion.Depth = 0
        Me.btnIniciar_sesion.Location = New System.Drawing.Point(144, 324)
        Me.btnIniciar_sesion.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnIniciar_sesion.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnIniciar_sesion.Name = "btnIniciar_sesion"
        Me.btnIniciar_sesion.Primary = False
        Me.btnIniciar_sesion.Size = New System.Drawing.Size(111, 36)
        Me.btnIniciar_sesion.TabIndex = 2
        Me.btnIniciar_sesion.Text = "Iniciar Sesión"
        Me.btnIniciar_sesion.UseVisualStyleBackColor = True
        '
        'txbNombre_Usuario
        '
        Me.txbNombre_Usuario.Depth = 0
        Me.txbNombre_Usuario.Hint = ""
        Me.txbNombre_Usuario.Location = New System.Drawing.Point(161, 212)
        Me.txbNombre_Usuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbNombre_Usuario.Name = "txbNombre_Usuario"
        Me.txbNombre_Usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbNombre_Usuario.SelectedText = ""
        Me.txbNombre_Usuario.SelectionLength = 0
        Me.txbNombre_Usuario.SelectionStart = 0
        Me.txbNombre_Usuario.Size = New System.Drawing.Size(204, 23)
        Me.txbNombre_Usuario.TabIndex = 0
        Me.txbNombre_Usuario.UseSystemPasswordChar = False
        '
        'lblNombre_Usuario
        '
        Me.lblNombre_Usuario.AutoSize = True
        Me.lblNombre_Usuario.Depth = 0
        Me.lblNombre_Usuario.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblNombre_Usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNombre_Usuario.Location = New System.Drawing.Point(27, 216)
        Me.lblNombre_Usuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNombre_Usuario.Name = "lblNombre_Usuario"
        Me.lblNombre_Usuario.Size = New System.Drawing.Size(119, 19)
        Me.lblNombre_Usuario.TabIndex = 57
        Me.lblNombre_Usuario.Text = "Nombre Usuario"
        '
        'txbContraseña
        '
        Me.txbContraseña.Depth = 0
        Me.txbContraseña.Hint = ""
        Me.txbContraseña.Location = New System.Drawing.Point(161, 266)
        Me.txbContraseña.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbContraseña.Name = "txbContraseña"
        Me.txbContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbContraseña.SelectedText = ""
        Me.txbContraseña.SelectionLength = 0
        Me.txbContraseña.SelectionStart = 0
        Me.txbContraseña.Size = New System.Drawing.Size(204, 23)
        Me.txbContraseña.TabIndex = 1
        Me.txbContraseña.UseSystemPasswordChar = True
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Depth = 0
        Me.lblContraseña.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblContraseña.Location = New System.Drawing.Point(27, 266)
        Me.lblContraseña.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(86, 19)
        Me.lblContraseña.TabIndex = 60
        Me.lblContraseña.Text = "Contraseña"
        '
        'pcbIcono
        '
        Me.pcbIcono.BackColor = System.Drawing.Color.White
        Me.pcbIcono.BackgroundImage = CType(resources.GetObject("pcbIcono.BackgroundImage"), System.Drawing.Image)
        Me.pcbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbIcono.Location = New System.Drawing.Point(132, 80)
        Me.pcbIcono.Name = "pcbIcono"
        Me.pcbIcono.Size = New System.Drawing.Size(140, 110)
        Me.pcbIcono.TabIndex = 62
        Me.pcbIcono.TabStop = False
        '
        'btnRecuperar_Contraseña
        '
        Me.btnRecuperar_Contraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecuperar_Contraseña.Depth = 0
        Me.btnRecuperar_Contraseña.Location = New System.Drawing.Point(210, 378)
        Me.btnRecuperar_Contraseña.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRecuperar_Contraseña.Name = "btnRecuperar_Contraseña"
        Me.btnRecuperar_Contraseña.Primary = True
        Me.btnRecuperar_Contraseña.Size = New System.Drawing.Size(180, 29)
        Me.btnRecuperar_Contraseña.TabIndex = 3
        Me.btnRecuperar_Contraseña.Text = "Recuperar contraseña"
        Me.btnRecuperar_Contraseña.UseVisualStyleBackColor = True
        '
        'frmInicio_Sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 419)
        Me.Controls.Add(Me.btnRecuperar_Contraseña)
        Me.Controls.Add(Me.pcbIcono)
        Me.Controls.Add(Me.txbContraseña)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.btnIniciar_sesion)
        Me.Controls.Add(Me.txbNombre_Usuario)
        Me.Controls.Add(Me.lblNombre_Usuario)
        Me.Name = "frmInicio_Sesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio Sesión                                                Rent-a-Car"
        CType(Me.pcbIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIniciar_sesion As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txbNombre_Usuario As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblNombre_Usuario As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbContraseña As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblContraseña As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pcbIcono As PictureBox
    Friend WithEvents btnRecuperar_Contraseña As MaterialSkin.Controls.MaterialRaisedButton
End Class
