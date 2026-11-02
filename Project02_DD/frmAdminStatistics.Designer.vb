<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminStatistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New Project02_DD.DisplayCustomizations()
        Me.btnBack = New Project02_DD.DisplayCustomizations()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblAverageMiles = New System.Windows.Forms.Label()
        Me.lblTotalFlights = New System.Windows.Forms.Label()
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstPilotMiles = New System.Windows.Forms.ListBox()
        Me.lstAttMiles = New System.Windows.Forms.ListBox()
        Me.DisplayCustomizations1 = New Project02_DD.DisplayCustomizations()
        Me.DisplayCustomizations4 = New Project02_DD.DisplayCustomizations()
        Me.DisplayCustomizations3 = New Project02_DD.DisplayCustomizations()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DisplayCustomizations2 = New Project02_DD.DisplayCustomizations()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(397, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1021, 103)
        Me.Panel2.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(100, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 36)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "FlyMe2theMoon"
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
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(65, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 85)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Statistics"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DisplayCustomizations1)
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 936)
        Me.Panel1.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SlateGray
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblAverageMiles)
        Me.Panel3.Controls.Add(Me.lblTotalFlights)
        Me.Panel3.Controls.Add(Me.lblTotalCustomers)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.DisplayCustomizations2)
        Me.Panel3.ForeColor = System.Drawing.Color.SlateGray
        Me.Panel3.Location = New System.Drawing.Point(440, 94)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(983, 248)
        Me.Panel3.TabIndex = 29
        '
        'lblAverageMiles
        '
        Me.lblAverageMiles.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageMiles.ForeColor = System.Drawing.Color.White
        Me.lblAverageMiles.Location = New System.Drawing.Point(716, 150)
        Me.lblAverageMiles.Name = "lblAverageMiles"
        Me.lblAverageMiles.Size = New System.Drawing.Size(230, 48)
        Me.lblAverageMiles.TabIndex = 39
        '
        'lblTotalFlights
        '
        Me.lblTotalFlights.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFlights.ForeColor = System.Drawing.Color.White
        Me.lblTotalFlights.Location = New System.Drawing.Point(716, 90)
        Me.lblTotalFlights.Name = "lblTotalFlights"
        Me.lblTotalFlights.Size = New System.Drawing.Size(230, 48)
        Me.lblTotalFlights.TabIndex = 38
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCustomers.ForeColor = System.Drawing.Color.White
        Me.lblTotalCustomers.Location = New System.Drawing.Point(716, 30)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(230, 48)
        Me.lblTotalCustomers.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(365, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(345, 38)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Average Miles Flown:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(337, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(373, 38)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Total Number of Flights:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(270, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 38)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Total Number of Customers:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.DisplayCustomizations4)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.ForeColor = System.Drawing.Color.SlateGray
        Me.Panel4.Location = New System.Drawing.Point(440, 325)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(978, 605)
        Me.Panel4.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(35, 511)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 44)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "ATTENDANTS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(372, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 52)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "M I L A G E"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.DisplayCustomizations3)
        Me.Panel5.Controls.Add(Me.lstPilotMiles)
        Me.Panel5.Controls.Add(Me.lstAttMiles)
        Me.Panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(3, 96)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1013, 515)
        Me.Panel5.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(83, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 44)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "PILOTS"
        '
        'lstPilotMiles
        '
        Me.lstPilotMiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lstPilotMiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstPilotMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPilotMiles.ForeColor = System.Drawing.Color.White
        Me.lstPilotMiles.FormattingEnabled = True
        Me.lstPilotMiles.ItemHeight = 37
        Me.lstPilotMiles.Location = New System.Drawing.Point(288, 29)
        Me.lstPilotMiles.Name = "lstPilotMiles"
        Me.lstPilotMiles.Size = New System.Drawing.Size(725, 185)
        Me.lstPilotMiles.TabIndex = 39
        '
        'lstAttMiles
        '
        Me.lstAttMiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lstAttMiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstAttMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAttMiles.ForeColor = System.Drawing.Color.White
        Me.lstAttMiles.FormattingEnabled = True
        Me.lstAttMiles.ItemHeight = 37
        Me.lstAttMiles.Location = New System.Drawing.Point(288, 274)
        Me.lstAttMiles.Name = "lstAttMiles"
        Me.lstAttMiles.Size = New System.Drawing.Size(737, 185)
        Me.lstAttMiles.TabIndex = 40
        '
        'DisplayCustomizations1
        '
        Me.DisplayCustomizations1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DisplayCustomizations1.BackgroundImage = Global.Project02_DD.My.Resources.Resources.StatisticsIconINVERTED
        Me.DisplayCustomizations1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DisplayCustomizations1.CornerRadius = 300
        Me.DisplayCustomizations1.Enabled = False
        Me.DisplayCustomizations1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations1.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.DisplayCustomizations1.Location = New System.Drawing.Point(75, 137)
        Me.DisplayCustomizations1.Name = "DisplayCustomizations1"
        Me.DisplayCustomizations1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.DisplayCustomizations1.Size = New System.Drawing.Size(300, 300)
        Me.DisplayCustomizations1.TabIndex = 23
        Me.DisplayCustomizations1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DisplayCustomizations1.UseVisualStyleBackColor = False
        '
        'DisplayCustomizations4
        '
        Me.DisplayCustomizations4.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DisplayCustomizations4.BackgroundImage = Global.Project02_DD.My.Resources.Resources.AttendantIcon2INVERTED
        Me.DisplayCustomizations4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DisplayCustomizations4.CornerRadius = 50
        Me.DisplayCustomizations4.Enabled = False
        Me.DisplayCustomizations4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DisplayCustomizations4.Location = New System.Drawing.Point(16, 342)
        Me.DisplayCustomizations4.Name = "DisplayCustomizations4"
        Me.DisplayCustomizations4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.DisplayCustomizations4.Size = New System.Drawing.Size(269, 250)
        Me.DisplayCustomizations4.TabIndex = 42
        Me.DisplayCustomizations4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DisplayCustomizations4.UseVisualStyleBackColor = False
        '
        'DisplayCustomizations3
        '
        Me.DisplayCustomizations3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DisplayCustomizations3.BackgroundImage = Global.Project02_DD.My.Resources.Resources.PilotIcon2INVERTED
        Me.DisplayCustomizations3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DisplayCustomizations3.CornerRadius = 50
        Me.DisplayCustomizations3.Enabled = False
        Me.DisplayCustomizations3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DisplayCustomizations3.Location = New System.Drawing.Point(13, 3)
        Me.DisplayCustomizations3.Name = "DisplayCustomizations3"
        Me.DisplayCustomizations3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.DisplayCustomizations3.Size = New System.Drawing.Size(269, 258)
        Me.DisplayCustomizations3.TabIndex = 37
        Me.DisplayCustomizations3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DisplayCustomizations3.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(38, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(231, 44)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "CUSTOMERS"
        '
        'DisplayCustomizations2
        '
        Me.DisplayCustomizations2.BackColor = System.Drawing.Color.SlateGray
        Me.DisplayCustomizations2.BackgroundImage = Global.Project02_DD.My.Resources.Resources.UserIconINVERTED
        Me.DisplayCustomizations2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DisplayCustomizations2.CornerRadius = 50
        Me.DisplayCustomizations2.Enabled = False
        Me.DisplayCustomizations2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations2.ForeColor = System.Drawing.Color.SlateGray
        Me.DisplayCustomizations2.Location = New System.Drawing.Point(32, 3)
        Me.DisplayCustomizations2.Name = "DisplayCustomizations2"
        Me.DisplayCustomizations2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.DisplayCustomizations2.Size = New System.Drawing.Size(237, 222)
        Me.DisplayCustomizations2.TabIndex = 42
        Me.DisplayCustomizations2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DisplayCustomizations2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(387, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(284, 52)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "G E N E R A L"
        '
        'frmAdminStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1411, 929)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.MaximumSize = New System.Drawing.Size(1437, 1000)
        Me.MinimumSize = New System.Drawing.Size(1437, 1000)
        Me.Name = "frmAdminStatistics"
        Me.Text = "Admin - Statistics"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As DisplayCustomizations
    Friend WithEvents btnBack As DisplayCustomizations
    Friend WithEvents Label2 As Label
    Friend WithEvents DisplayCustomizations1 As DisplayCustomizations
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DisplayCustomizations3 As DisplayCustomizations
    Friend WithEvents Label7 As Label
    Friend WithEvents lstAttMiles As ListBox
    Friend WithEvents lstPilotMiles As ListBox
    Friend WithEvents lblAverageMiles As Label
    Friend WithEvents lblTotalFlights As Label
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DisplayCustomizations4 As DisplayCustomizations
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DisplayCustomizations2 As DisplayCustomizations
    Friend WithEvents Label10 As Label
End Class
