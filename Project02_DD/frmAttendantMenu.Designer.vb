<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantMenu
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New Project02_DD.DisplayCustomizations()
        Me.btnBack = New Project02_DD.DisplayCustomizations()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.DisplayCustomizations1 = New Project02_DD.DisplayCustomizations()
        Me.btnFutureFlights = New System.Windows.Forms.Button()
        Me.btnPastFlights = New System.Windows.Forms.Button()
        Me.btnUpdateProfile = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(135, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 36)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "FlyMe2theMoon"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(394, -7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(458, 114)
        Me.Panel2.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 85)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Main Menu"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.lblLastName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DisplayCustomizations1)
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(-5, -7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 1119)
        Me.Panel1.TabIndex = 29
        '
        'btnClose
        '
        Me.btnClose.CornerRadius = 44
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(80, 897)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(300, 88)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.CornerRadius = 44
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(80, 780)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(300, 88)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Logoff"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblLastName
        '
        Me.lblLastName.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblLastName.Location = New System.Drawing.Point(35, 610)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(386, 78)
        Me.lblLastName.TabIndex = 26
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 470)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 39)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "USER:"
        '
        'lblFirstName
        '
        Me.lblFirstName.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblFirstName.Location = New System.Drawing.Point(35, 535)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(386, 78)
        Me.lblFirstName.TabIndex = 24
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisplayCustomizations1
        '
        Me.DisplayCustomizations1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DisplayCustomizations1.BackgroundImage = Global.Project02_DD.My.Resources.Resources.AttendantIcon2
        Me.DisplayCustomizations1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DisplayCustomizations1.CornerRadius = 300
        Me.DisplayCustomizations1.Enabled = False
        Me.DisplayCustomizations1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations1.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations1.ForeColor = System.Drawing.Color.Black
        Me.DisplayCustomizations1.Location = New System.Drawing.Point(80, 145)
        Me.DisplayCustomizations1.Name = "DisplayCustomizations1"
        Me.DisplayCustomizations1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.DisplayCustomizations1.Size = New System.Drawing.Size(300, 300)
        Me.DisplayCustomizations1.TabIndex = 23
        Me.DisplayCustomizations1.Text = "ATTENDANT"
        Me.DisplayCustomizations1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DisplayCustomizations1.UseVisualStyleBackColor = False
        '
        'btnFutureFlights
        '
        Me.btnFutureFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFutureFlights.BackgroundImage = Global.Project02_DD.My.Resources.Resources.FutureIcon
        Me.btnFutureFlights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFutureFlights.FlatAppearance.BorderSize = 0
        Me.btnFutureFlights.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnFutureFlights.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnFutureFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFutureFlights.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFutureFlights.Location = New System.Drawing.Point(468, 773)
        Me.btnFutureFlights.Name = "btnFutureFlights"
        Me.btnFutureFlights.Padding = New System.Windows.Forms.Padding(0, 0, 0, 60)
        Me.btnFutureFlights.Size = New System.Drawing.Size(354, 302)
        Me.btnFutureFlights.TabIndex = 28
        Me.btnFutureFlights.Text = "Future Flights"
        Me.btnFutureFlights.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFutureFlights.UseVisualStyleBackColor = False
        '
        'btnPastFlights
        '
        Me.btnPastFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPastFlights.BackgroundImage = Global.Project02_DD.My.Resources.Resources.PastIcon
        Me.btnPastFlights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPastFlights.FlatAppearance.BorderSize = 0
        Me.btnPastFlights.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnPastFlights.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPastFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPastFlights.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastFlights.Location = New System.Drawing.Point(468, 448)
        Me.btnPastFlights.Name = "btnPastFlights"
        Me.btnPastFlights.Padding = New System.Windows.Forms.Padding(0, 0, 0, 60)
        Me.btnPastFlights.Size = New System.Drawing.Size(354, 302)
        Me.btnPastFlights.TabIndex = 27
        Me.btnPastFlights.Text = "Past Flights"
        Me.btnPastFlights.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPastFlights.UseVisualStyleBackColor = False
        '
        'btnUpdateProfile
        '
        Me.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnUpdateProfile.BackgroundImage = Global.Project02_DD.My.Resources.Resources.UpdateProfileIcon
        Me.btnUpdateProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUpdateProfile.FlatAppearance.BorderSize = 0
        Me.btnUpdateProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnUpdateProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateProfile.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateProfile.Location = New System.Drawing.Point(468, 126)
        Me.btnUpdateProfile.Name = "btnUpdateProfile"
        Me.btnUpdateProfile.Padding = New System.Windows.Forms.Padding(0, 0, 0, 60)
        Me.btnUpdateProfile.Size = New System.Drawing.Size(354, 302)
        Me.btnUpdateProfile.TabIndex = 26
        Me.btnUpdateProfile.Text = "Update Profile"
        Me.btnUpdateProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdateProfile.UseVisualStyleBackColor = False
        '
        'frmAttendantMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 1105)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnFutureFlights)
        Me.Controls.Add(Me.btnPastFlights)
        Me.Controls.Add(Me.btnUpdateProfile)
        Me.Controls.Add(Me.Panel2)
        Me.MaximumSize = New System.Drawing.Size(873, 1176)
        Me.MinimumSize = New System.Drawing.Size(873, 1176)
        Me.Name = "frmAttendantMenu"
        Me.Text = "Attendant Menu"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As DisplayCustomizations
    Friend WithEvents btnBack As DisplayCustomizations
    Friend WithEvents lblLastName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents DisplayCustomizations1 As DisplayCustomizations
    Friend WithEvents btnFutureFlights As Button
    Friend WithEvents btnPastFlights As Button
    Friend WithEvents btnUpdateProfile As Button
End Class
