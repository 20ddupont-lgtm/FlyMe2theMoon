<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotPastFlights
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBack = New Project02_DD.DisplayCustomizations()
        Me.DisplayCustomizations3 = New Project02_DD.DisplayCustomizations()
        Me.lstPastFlights = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMilesFlown = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(30, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 33)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "FlyMe2theMoon"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBack.CornerRadius = 55
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(300, 772)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(386, 110)
        Me.btnBack.TabIndex = 53
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DisplayCustomizations3
        '
        Me.DisplayCustomizations3.BackColor = System.Drawing.Color.SteelBlue
        Me.DisplayCustomizations3.CornerRadius = 60
        Me.DisplayCustomizations3.Enabled = False
        Me.DisplayCustomizations3.FlatAppearance.BorderSize = 0
        Me.DisplayCustomizations3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.DisplayCustomizations3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.DisplayCustomizations3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations3.ForeColor = System.Drawing.Color.Transparent
        Me.DisplayCustomizations3.Location = New System.Drawing.Point(293, 767)
        Me.DisplayCustomizations3.Name = "DisplayCustomizations3"
        Me.DisplayCustomizations3.Size = New System.Drawing.Size(400, 121)
        Me.DisplayCustomizations3.TabIndex = 54
        Me.DisplayCustomizations3.UseVisualStyleBackColor = False
        '
        'lstPastFlights
        '
        Me.lstPastFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPastFlights.FormattingEnabled = True
        Me.lstPastFlights.ItemHeight = 31
        Me.lstPastFlights.Location = New System.Drawing.Point(71, 246)
        Me.lstPastFlights.Name = "lstPastFlights"
        Me.lstPastFlights.Size = New System.Drawing.Size(842, 500)
        Me.lstPastFlights.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 52)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Past Flights"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 37)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Total Miles Flown:"
        '
        'lblMilesFlown
        '
        Me.lblMilesFlown.AutoSize = True
        Me.lblMilesFlown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilesFlown.Location = New System.Drawing.Point(525, 145)
        Me.lblMilesFlown.Name = "lblMilesFlown"
        Me.lblMilesFlown.Size = New System.Drawing.Size(0, 37)
        Me.lblMilesFlown.TabIndex = 57
        '
        'frmPilotPastFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 929)
        Me.Controls.Add(Me.lblMilesFlown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DisplayCustomizations3)
        Me.Controls.Add(Me.lstPastFlights)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.MinimumSize = New System.Drawing.Size(1000, 1000)
        Me.Name = "frmPilotPastFlights"
        Me.Text = "Pilot Past Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents btnBack As DisplayCustomizations
    Friend WithEvents DisplayCustomizations3 As DisplayCustomizations
    Friend WithEvents lstPastFlights As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMilesFlown As Label
End Class
