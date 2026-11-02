<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignAttendantFlight
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFlights = New System.Windows.Forms.ComboBox()
        Me.cboAttendants = New System.Windows.Forms.ComboBox()
        Me.btnBack = New Project02_DD.DisplayCustomizations()
        Me.DisplayCustomizations3 = New Project02_DD.DisplayCustomizations()
        Me.btnSubmit = New Project02_DD.DisplayCustomizations()
        Me.DisplayCustomizations1 = New Project02_DD.DisplayCustomizations()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(693, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 39)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Flight"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 39)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Attendant"
        '
        'cboFlights
        '
        Me.cboFlights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlights.FormattingEnabled = True
        Me.cboFlights.Location = New System.Drawing.Point(538, 222)
        Me.cboFlights.Name = "cboFlights"
        Me.cboFlights.Size = New System.Drawing.Size(400, 50)
        Me.cboFlights.TabIndex = 111
        '
        'cboAttendants
        '
        Me.cboAttendants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAttendants.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAttendants.FormattingEnabled = True
        Me.cboAttendants.Location = New System.Drawing.Point(38, 222)
        Me.cboAttendants.Name = "cboAttendants"
        Me.cboAttendants.Size = New System.Drawing.Size(393, 50)
        Me.cboAttendants.TabIndex = 110
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnBack.CornerRadius = 55
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(545, 560)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(386, 110)
        Me.btnBack.TabIndex = 108
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DisplayCustomizations3
        '
        Me.DisplayCustomizations3.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DisplayCustomizations3.CornerRadius = 60
        Me.DisplayCustomizations3.Enabled = False
        Me.DisplayCustomizations3.FlatAppearance.BorderSize = 0
        Me.DisplayCustomizations3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.DisplayCustomizations3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.DisplayCustomizations3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations3.ForeColor = System.Drawing.Color.Transparent
        Me.DisplayCustomizations3.Location = New System.Drawing.Point(538, 555)
        Me.DisplayCustomizations3.Name = "DisplayCustomizations3"
        Me.DisplayCustomizations3.Size = New System.Drawing.Size(400, 121)
        Me.DisplayCustomizations3.TabIndex = 109
        Me.DisplayCustomizations3.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnSubmit.CornerRadius = 55
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(38, 560)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(386, 110)
        Me.btnSubmit.TabIndex = 106
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'DisplayCustomizations1
        '
        Me.DisplayCustomizations1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DisplayCustomizations1.CornerRadius = 60
        Me.DisplayCustomizations1.Enabled = False
        Me.DisplayCustomizations1.FlatAppearance.BorderSize = 0
        Me.DisplayCustomizations1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.DisplayCustomizations1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.DisplayCustomizations1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplayCustomizations1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayCustomizations1.ForeColor = System.Drawing.Color.Transparent
        Me.DisplayCustomizations1.Location = New System.Drawing.Point(31, 555)
        Me.DisplayCustomizations1.Name = "DisplayCustomizations1"
        Me.DisplayCustomizations1.Size = New System.Drawing.Size(400, 121)
        Me.DisplayCustomizations1.TabIndex = 107
        Me.DisplayCustomizations1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(25, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(221, 33)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "FlyMe2theMoon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 52)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Assign Attendant to Flight"
        '
        'frmAssignAttendantFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 729)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboFlights)
        Me.Controls.Add(Me.cboAttendants)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DisplayCustomizations3)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.DisplayCustomizations1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1000, 800)
        Me.MinimumSize = New System.Drawing.Size(1000, 800)
        Me.Name = "frmAssignAttendantFlight"
        Me.Text = "Admin - Assign Attendant to Flight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboFlights As ComboBox
    Friend WithEvents cboAttendants As ComboBox
    Friend WithEvents btnBack As DisplayCustomizations
    Friend WithEvents DisplayCustomizations3 As DisplayCustomizations
    Friend WithEvents btnSubmit As DisplayCustomizations
    Friend WithEvents DisplayCustomizations1 As DisplayCustomizations
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
End Class
