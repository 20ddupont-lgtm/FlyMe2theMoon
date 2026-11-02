<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminAttendantMgmt
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeleteAttendant = New System.Windows.Forms.Button()
        Me.btnAssignFlight = New System.Windows.Forms.Button()
        Me.btnAddAttendant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(787, 19)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(234, 50)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 36)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "FlyMe2theMoon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 39)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(219, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(576, 85)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Attendant Menu"
        '
        'btnDeleteAttendant
        '
        Me.btnDeleteAttendant.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDeleteAttendant.BackgroundImage = Global.Project02_DD.My.Resources.Resources.DeleteIcon
        Me.btnDeleteAttendant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDeleteAttendant.FlatAppearance.BorderSize = 0
        Me.btnDeleteAttendant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnDeleteAttendant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteAttendant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAttendant.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAttendant.Location = New System.Drawing.Point(701, 248)
        Me.btnDeleteAttendant.Name = "btnDeleteAttendant"
        Me.btnDeleteAttendant.Padding = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.btnDeleteAttendant.Size = New System.Drawing.Size(320, 288)
        Me.btnDeleteAttendant.TabIndex = 26
        Me.btnDeleteAttendant.Text = "Delete Attendant"
        Me.btnDeleteAttendant.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeleteAttendant.UseVisualStyleBackColor = False
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
        Me.btnAssignFlight.Location = New System.Drawing.Point(365, 248)
        Me.btnAssignFlight.Name = "btnAssignFlight"
        Me.btnAssignFlight.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.btnAssignFlight.Size = New System.Drawing.Size(320, 288)
        Me.btnAssignFlight.TabIndex = 21
        Me.btnAssignFlight.Text = "Assign Attendant to Flight"
        Me.btnAssignFlight.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAssignFlight.UseVisualStyleBackColor = False
        '
        'btnAddAttendant
        '
        Me.btnAddAttendant.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAddAttendant.BackgroundImage = Global.Project02_DD.My.Resources.Resources.UpdateProfileIcon
        Me.btnAddAttendant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddAttendant.FlatAppearance.BorderSize = 0
        Me.btnAddAttendant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAddAttendant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddAttendant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAttendant.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAttendant.Location = New System.Drawing.Point(26, 248)
        Me.btnAddAttendant.Name = "btnAddAttendant"
        Me.btnAddAttendant.Padding = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.btnAddAttendant.Size = New System.Drawing.Size(320, 288)
        Me.btnAddAttendant.TabIndex = 20
        Me.btnAddAttendant.Text = "Add Attendant"
        Me.btnAddAttendant.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddAttendant.UseVisualStyleBackColor = False
        '
        'frmAdminAttendantMgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 554)
        Me.Controls.Add(Me.btnDeleteAttendant)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAssignFlight)
        Me.Controls.Add(Me.btnAddAttendant)
        Me.MaximumSize = New System.Drawing.Size(1070, 625)
        Me.MinimumSize = New System.Drawing.Size(1070, 625)
        Me.Name = "frmAdminAttendantMgmt"
        Me.Text = "Admin - Attendant Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeleteAttendant As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAssignFlight As Button
    Friend WithEvents btnAddAttendant As Button
End Class
