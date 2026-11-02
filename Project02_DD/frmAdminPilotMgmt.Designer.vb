<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminPilotMgmt
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDeletePilot = New System.Windows.Forms.Button()
        Me.btnAssignFlight = New System.Windows.Forms.Button()
        Me.btnAddPilot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 36)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "FlyMe2theMoon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(447, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 39)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(317, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 85)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Pilot Menu"
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(783, 16)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(234, 50)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDeletePilot
        '
        Me.btnDeletePilot.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDeletePilot.BackgroundImage = Global.Project02_DD.My.Resources.Resources.DeleteIcon
        Me.btnDeletePilot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeletePilot.FlatAppearance.BorderSize = 0
        Me.btnDeletePilot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnDeletePilot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeletePilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePilot.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePilot.Location = New System.Drawing.Point(697, 245)
        Me.btnDeletePilot.Name = "btnDeletePilot"
        Me.btnDeletePilot.Padding = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.btnDeletePilot.Size = New System.Drawing.Size(320, 288)
        Me.btnDeletePilot.TabIndex = 19
        Me.btnDeletePilot.Text = "Delete Pilot"
        Me.btnDeletePilot.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeletePilot.UseVisualStyleBackColor = False
        '
        'btnAssignFlight
        '
        Me.btnAssignFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAssignFlight.BackgroundImage = Global.Project02_DD.My.Resources.Resources.BookFlightIcon
        Me.btnAssignFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAssignFlight.FlatAppearance.BorderSize = 0
        Me.btnAssignFlight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAssignFlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAssignFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignFlight.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignFlight.Location = New System.Drawing.Point(361, 245)
        Me.btnAssignFlight.Name = "btnAssignFlight"
        Me.btnAssignFlight.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.btnAssignFlight.Size = New System.Drawing.Size(320, 288)
        Me.btnAssignFlight.TabIndex = 14
        Me.btnAssignFlight.Text = "Assign Pilot to Flight"
        Me.btnAssignFlight.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAssignFlight.UseVisualStyleBackColor = False
        '
        'btnAddPilot
        '
        Me.btnAddPilot.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAddPilot.BackgroundImage = Global.Project02_DD.My.Resources.Resources.UpdateProfileIcon
        Me.btnAddPilot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddPilot.FlatAppearance.BorderSize = 0
        Me.btnAddPilot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAddPilot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddPilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPilot.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPilot.Location = New System.Drawing.Point(22, 245)
        Me.btnAddPilot.Name = "btnAddPilot"
        Me.btnAddPilot.Padding = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.btnAddPilot.Size = New System.Drawing.Size(320, 288)
        Me.btnAddPilot.TabIndex = 13
        Me.btnAddPilot.Text = "Add Pilot"
        Me.btnAddPilot.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddPilot.UseVisualStyleBackColor = False
        '
        'frmAdminPilotMgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1044, 554)
        Me.Controls.Add(Me.btnDeletePilot)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAssignFlight)
        Me.Controls.Add(Me.btnAddPilot)
        Me.MaximumSize = New System.Drawing.Size(1070, 625)
        Me.MinimumSize = New System.Drawing.Size(1070, 625)
        Me.Name = "frmAdminPilotMgmt"
        Me.Text = "Admin - Pilot Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddPilot As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAssignFlight As Button
    Friend WithEvents btnDeletePilot As Button
End Class
