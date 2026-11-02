<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFutureFlights = New System.Windows.Forms.Button()
        Me.btnPastFlights = New System.Windows.Forms.Button()
        Me.btnBookFlight = New System.Windows.Forms.Button()
        Me.btnUpdateProfile = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(287, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 85)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Main Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(394, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 39)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CUSTOMER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 36)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "FlyMe2theMoon"
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(29, 48)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(234, 50)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Logoff"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnFutureFlights
        '
        Me.btnFutureFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFutureFlights.BackgroundImage = Global.Project02_DD.My.Resources.Resources.FutureIcon
        Me.btnFutureFlights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFutureFlights.FlatAppearance.BorderSize = 0
        Me.btnFutureFlights.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnFutureFlights.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnFutureFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFutureFlights.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFutureFlights.Location = New System.Drawing.Point(499, 656)
        Me.btnFutureFlights.Name = "btnFutureFlights"
        Me.btnFutureFlights.Padding = New System.Windows.Forms.Padding(0, 0, 0, 80)
        Me.btnFutureFlights.Size = New System.Drawing.Size(449, 397)
        Me.btnFutureFlights.TabIndex = 9
        Me.btnFutureFlights.Text = "Show Future Flights"
        Me.btnFutureFlights.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFutureFlights.UseVisualStyleBackColor = False
        '
        'btnPastFlights
        '
        Me.btnPastFlights.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPastFlights.BackgroundImage = Global.Project02_DD.My.Resources.Resources.PastIcon
        Me.btnPastFlights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPastFlights.FlatAppearance.BorderSize = 0
        Me.btnPastFlights.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnPastFlights.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnPastFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPastFlights.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastFlights.Location = New System.Drawing.Point(29, 656)
        Me.btnPastFlights.Name = "btnPastFlights"
        Me.btnPastFlights.Padding = New System.Windows.Forms.Padding(0, 0, 0, 80)
        Me.btnPastFlights.Size = New System.Drawing.Size(449, 397)
        Me.btnPastFlights.TabIndex = 8
        Me.btnPastFlights.Text = "Show Past Flights"
        Me.btnPastFlights.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPastFlights.UseVisualStyleBackColor = False
        '
        'btnBookFlight
        '
        Me.btnBookFlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBookFlight.BackgroundImage = Global.Project02_DD.My.Resources.Resources.BookFlightIcon
        Me.btnBookFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBookFlight.FlatAppearance.BorderSize = 0
        Me.btnBookFlight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnBookFlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnBookFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookFlight.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookFlight.Location = New System.Drawing.Point(499, 240)
        Me.btnBookFlight.Name = "btnBookFlight"
        Me.btnBookFlight.Padding = New System.Windows.Forms.Padding(0, 0, 0, 80)
        Me.btnBookFlight.Size = New System.Drawing.Size(449, 397)
        Me.btnBookFlight.TabIndex = 7
        Me.btnBookFlight.Text = "Book Flight"
        Me.btnBookFlight.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBookFlight.UseVisualStyleBackColor = False
        '
        'btnUpdateProfile
        '
        Me.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnUpdateProfile.BackgroundImage = Global.Project02_DD.My.Resources.Resources.UpdateProfileIcon
        Me.btnUpdateProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUpdateProfile.FlatAppearance.BorderSize = 0
        Me.btnUpdateProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnUpdateProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateProfile.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateProfile.Location = New System.Drawing.Point(29, 240)
        Me.btnUpdateProfile.Name = "btnUpdateProfile"
        Me.btnUpdateProfile.Padding = New System.Windows.Forms.Padding(0, 0, 0, 80)
        Me.btnUpdateProfile.Size = New System.Drawing.Size(449, 397)
        Me.btnUpdateProfile.TabIndex = 6
        Me.btnUpdateProfile.Text = "Update Profile"
        Me.btnUpdateProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdateProfile.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(714, 48)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(234, 50)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmCustomerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 1079)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFutureFlights)
        Me.Controls.Add(Me.btnPastFlights)
        Me.Controls.Add(Me.btnBookFlight)
        Me.Controls.Add(Me.btnUpdateProfile)
        Me.MaximumSize = New System.Drawing.Size(1000, 1150)
        Me.MinimumSize = New System.Drawing.Size(1000, 1150)
        Me.Name = "frmCustomerMenu"
        Me.Text = "Customer Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFutureFlights As Button
    Friend WithEvents btnPastFlights As Button
    Friend WithEvents btnBookFlight As Button
    Friend WithEvents btnUpdateProfile As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClose As Button
End Class
