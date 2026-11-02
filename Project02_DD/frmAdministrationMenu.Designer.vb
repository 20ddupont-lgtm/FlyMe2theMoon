<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrationMenu
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
        Me.btnClose = New Project02_DD.DisplayCustomizations()
        Me.btnBack = New Project02_DD.DisplayCustomizations()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DisplayCustomizations1 = New Project02_DD.DisplayCustomizations()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFlightMgmt = New System.Windows.Forms.Button()
        Me.btnAttendantMgmt = New System.Windows.Forms.Button()
        Me.btnPilotMgmt = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.CornerRadius = 44
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(80, 626)
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
        Me.btnBack.Location = New System.Drawing.Point(80, 501)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(300, 88)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Logoff"
        Me.btnBack.UseVisualStyleBackColor = True
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
        'DisplayCustomizations1
        '
        Me.DisplayCustomizations1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DisplayCustomizations1.BackgroundImage = Global.Project02_DD.My.Resources.Resources.AdminIcon
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
        Me.DisplayCustomizations1.Text = "ADMIN"
        Me.DisplayCustomizations1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DisplayCustomizations1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(329, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 36)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "FlyMe2theMoon"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DisplayCustomizations1)
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 786)
        Me.Panel1.TabIndex = 29
        '
        'btnFlightMgmt
        '
        Me.btnFlightMgmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFlightMgmt.BackgroundImage = Global.Project02_DD.My.Resources.Resources.BookFlightIcon
        Me.btnFlightMgmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFlightMgmt.FlatAppearance.BorderSize = 0
        Me.btnFlightMgmt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnFlightMgmt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFlightMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFlightMgmt.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlightMgmt.Location = New System.Drawing.Point(473, 455)
        Me.btnFlightMgmt.Name = "btnFlightMgmt"
        Me.btnFlightMgmt.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnFlightMgmt.Size = New System.Drawing.Size(354, 302)
        Me.btnFlightMgmt.TabIndex = 28
        Me.btnFlightMgmt.Text = "Flight Management"
        Me.btnFlightMgmt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFlightMgmt.UseVisualStyleBackColor = False
        '
        'btnAttendantMgmt
        '
        Me.btnAttendantMgmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAttendantMgmt.BackgroundImage = Global.Project02_DD.My.Resources.Resources.AttendantIcon2
        Me.btnAttendantMgmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAttendantMgmt.FlatAppearance.BorderSize = 0
        Me.btnAttendantMgmt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAttendantMgmt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAttendantMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttendantMgmt.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendantMgmt.Location = New System.Drawing.Point(848, 133)
        Me.btnAttendantMgmt.Name = "btnAttendantMgmt"
        Me.btnAttendantMgmt.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnAttendantMgmt.Size = New System.Drawing.Size(354, 302)
        Me.btnAttendantMgmt.TabIndex = 27
        Me.btnAttendantMgmt.Text = "Attendant Management"
        Me.btnAttendantMgmt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAttendantMgmt.UseVisualStyleBackColor = False
        '
        'btnPilotMgmt
        '
        Me.btnPilotMgmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPilotMgmt.BackgroundImage = Global.Project02_DD.My.Resources.Resources.PilotIcon2
        Me.btnPilotMgmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPilotMgmt.FlatAppearance.BorderSize = 0
        Me.btnPilotMgmt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnPilotMgmt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPilotMgmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPilotMgmt.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilotMgmt.Location = New System.Drawing.Point(473, 133)
        Me.btnPilotMgmt.Name = "btnPilotMgmt"
        Me.btnPilotMgmt.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnPilotMgmt.Size = New System.Drawing.Size(354, 302)
        Me.btnPilotMgmt.TabIndex = 26
        Me.btnPilotMgmt.Text = "Pilot Management"
        Me.btnPilotMgmt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPilotMgmt.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(399, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(831, 114)
        Me.Panel2.TabIndex = 30
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnStatistics.BackgroundImage = Global.Project02_DD.My.Resources.Resources.StatisticsIcon
        Me.btnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStatistics.FlatAppearance.BorderSize = 0
        Me.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatistics.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.Location = New System.Drawing.Point(848, 455)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Padding = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.btnStatistics.Size = New System.Drawing.Size(354, 302)
        Me.btnStatistics.TabIndex = 31
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'frmAdministrationMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 779)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnFlightMgmt)
        Me.Controls.Add(Me.btnAttendantMgmt)
        Me.Controls.Add(Me.btnPilotMgmt)
        Me.Controls.Add(Me.Panel2)
        Me.MaximumSize = New System.Drawing.Size(1250, 850)
        Me.MinimumSize = New System.Drawing.Size(1250, 850)
        Me.Name = "frmAdministrationMenu"
        Me.Text = "Administrator Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As DisplayCustomizations
    Friend WithEvents btnBack As DisplayCustomizations
    Friend WithEvents Label2 As Label
    Friend WithEvents DisplayCustomizations1 As DisplayCustomizations
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFlightMgmt As Button
    Friend WithEvents btnAttendantMgmt As Button
    Friend WithEvents btnPilotMgmt As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnStatistics As Button
End Class
