<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblNewCustomer = New System.Windows.Forms.Label()
        Me.DisplayCustomizations3 = New Project02_DD.DisplayCustomizations()
        Me.DisplayCustomizations2 = New Project02_DD.DisplayCustomizations()
        Me.btnLogin = New Project02_DD.DisplayCustomizations()
        Me.DisplayCustomizations1 = New Project02_DD.DisplayCustomizations()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(213, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(569, 85)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "FlyMe2theMoon"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(329, 189)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(533, 37)
        Me.txtUsername.TabIndex = 16
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(329, 299)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(533, 37)
        Me.txtPassword.TabIndex = 18
        '
        'lblNewCustomer
        '
        Me.lblNewCustomer.AutoSize = True
        Me.lblNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewCustomer.ForeColor = System.Drawing.Color.Black
        Me.lblNewCustomer.Location = New System.Drawing.Point(283, 542)
        Me.lblNewCustomer.Name = "lblNewCustomer"
        Me.lblNewCustomer.Size = New System.Drawing.Size(449, 37)
        Me.lblNewCustomer.TabIndex = 19
        Me.lblNewCustomer.Text = "New Customer? Create Profile"
        '
        'DisplayCustomizations3
        '
        Me.DisplayCustomizations3.BackColor = System.Drawing.SystemColors.Window
        Me.DisplayCustomizations3.CornerRadius = 32
        Me.DisplayCustomizations3.Enabled = False
        Me.DisplayCustomizations3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.DisplayCustomizations3.FlatAppearance.BorderSize = 0
        Me.DisplayCustomizations3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations3.Location = New System.Drawing.Point(86, 282)
        Me.DisplayCustomizations3.Name = "DisplayCustomizations3"
        Me.DisplayCustomizations3.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.DisplayCustomizations3.Size = New System.Drawing.Size(805, 64)
        Me.DisplayCustomizations3.TabIndex = 17
        Me.DisplayCustomizations3.Text = "Password:"
        Me.DisplayCustomizations3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DisplayCustomizations3.UseVisualStyleBackColor = False
        '
        'DisplayCustomizations2
        '
        Me.DisplayCustomizations2.BackColor = System.Drawing.SystemColors.Window
        Me.DisplayCustomizations2.CornerRadius = 32
        Me.DisplayCustomizations2.Enabled = False
        Me.DisplayCustomizations2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.DisplayCustomizations2.FlatAppearance.BorderSize = 0
        Me.DisplayCustomizations2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations2.Location = New System.Drawing.Point(86, 172)
        Me.DisplayCustomizations2.Name = "DisplayCustomizations2"
        Me.DisplayCustomizations2.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.DisplayCustomizations2.Size = New System.Drawing.Size(805, 64)
        Me.DisplayCustomizations2.TabIndex = 15
        Me.DisplayCustomizations2.Text = "Username:"
        Me.DisplayCustomizations2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DisplayCustomizations2.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLogin.CornerRadius = 55
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(318, 389)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(386, 110)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'DisplayCustomizations1
        '
        Me.DisplayCustomizations1.BackColor = System.Drawing.Color.SteelBlue
        Me.DisplayCustomizations1.CornerRadius = 60
        Me.DisplayCustomizations1.Enabled = False
        Me.DisplayCustomizations1.FlatAppearance.BorderSize = 0
        Me.DisplayCustomizations1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.DisplayCustomizations1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.DisplayCustomizations1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations1.ForeColor = System.Drawing.Color.Transparent
        Me.DisplayCustomizations1.Location = New System.Drawing.Point(311, 384)
        Me.DisplayCustomizations1.Name = "DisplayCustomizations1"
        Me.DisplayCustomizations1.Size = New System.Drawing.Size(400, 121)
        Me.DisplayCustomizations1.TabIndex = 13
        Me.DisplayCustomizations1.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 629)
        Me.Controls.Add(Me.lblNewCustomer)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.DisplayCustomizations3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.DisplayCustomizations2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DisplayCustomizations1)
        Me.MaximumSize = New System.Drawing.Size(1034, 700)
        Me.MinimumSize = New System.Drawing.Size(1034, 700)
        Me.Name = "frmMain"
        Me.Text = "FlyMe2theMoon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As DisplayCustomizations
    Friend WithEvents DisplayCustomizations1 As DisplayCustomizations
    Friend WithEvents DisplayCustomizations2 As DisplayCustomizations
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents DisplayCustomizations3 As DisplayCustomizations
    Friend WithEvents lblNewCustomer As Label
End Class
