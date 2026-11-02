<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerBookFlight
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFutureFlights = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.radReservedSeat = New System.Windows.Forms.RadioButton()
        Me.radDesignatedSeat = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblFlightAmount = New System.Windows.Forms.Label()
        Me.lblReservedCount = New System.Windows.Forms.Label()
        Me.btnBack = New Project02_DD.DisplayCustomizations()
        Me.DisplayCustomizations3 = New Project02_DD.DisplayCustomizations()
        Me.btnSubmit = New Project02_DD.DisplayCustomizations()
        Me.DisplayCustomizations1 = New Project02_DD.DisplayCustomizations()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(342, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 52)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Book Flight"
        '
        'cboFutureFlights
        '
        Me.cboFutureFlights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFutureFlights.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFutureFlights.FormattingEnabled = True
        Me.cboFutureFlights.Location = New System.Drawing.Point(60, 144)
        Me.cboFutureFlights.Name = "cboFutureFlights"
        Me.cboFutureFlights.Size = New System.Drawing.Size(851, 50)
        Me.cboFutureFlights.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(30, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 33)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "FlyMe2theMoon"
        '
        'radReservedSeat
        '
        Me.radReservedSeat.AutoSize = True
        Me.radReservedSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radReservedSeat.Location = New System.Drawing.Point(90, 276)
        Me.radReservedSeat.Name = "radReservedSeat"
        Me.radReservedSeat.Size = New System.Drawing.Size(225, 35)
        Me.radReservedSeat.TabIndex = 49
        Me.radReservedSeat.Text = "Reserved Seat"
        Me.radReservedSeat.UseVisualStyleBackColor = True
        '
        'radDesignatedSeat
        '
        Me.radDesignatedSeat.AutoSize = True
        Me.radDesignatedSeat.Checked = True
        Me.radDesignatedSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDesignatedSeat.Location = New System.Drawing.Point(90, 368)
        Me.radDesignatedSeat.Name = "radDesignatedSeat"
        Me.radDesignatedSeat.Size = New System.Drawing.Size(393, 35)
        Me.radDesignatedSeat.TabIndex = 50
        Me.radDesignatedSeat.TabStop = True
        Me.radDesignatedSeat.Text = "Designated Seat at Check-In"
        Me.radDesignatedSeat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(650, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 39)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Total Cost:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalCost.Location = New System.Drawing.Point(625, 321)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(236, 82)
        Me.lblTotalCost.TabIndex = 52
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.ForeColor = System.Drawing.SystemColors.Control
        Me.lblState.Location = New System.Drawing.Point(697, 29)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(0, 25)
        Me.lblState.TabIndex = 58
        Me.lblState.Visible = False
        '
        'lblFlightAmount
        '
        Me.lblFlightAmount.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFlightAmount.Location = New System.Drawing.Point(624, 35)
        Me.lblFlightAmount.Name = "lblFlightAmount"
        Me.lblFlightAmount.Size = New System.Drawing.Size(94, 44)
        Me.lblFlightAmount.TabIndex = 59
        Me.lblFlightAmount.Visible = False
        '
        'lblReservedCount
        '
        Me.lblReservedCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblReservedCount.Location = New System.Drawing.Point(846, 19)
        Me.lblReservedCount.Name = "lblReservedCount"
        Me.lblReservedCount.Size = New System.Drawing.Size(94, 44)
        Me.lblReservedCount.TabIndex = 60
        Me.lblReservedCount.Visible = False
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
        Me.btnBack.Location = New System.Drawing.Point(547, 555)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(386, 110)
        Me.btnBack.TabIndex = 46
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
        Me.DisplayCustomizations3.Location = New System.Drawing.Point(540, 550)
        Me.DisplayCustomizations3.Name = "DisplayCustomizations3"
        Me.DisplayCustomizations3.Size = New System.Drawing.Size(400, 121)
        Me.DisplayCustomizations3.TabIndex = 47
        Me.DisplayCustomizations3.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSubmit.CornerRadius = 55
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(40, 555)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(386, 110)
        Me.btnSubmit.TabIndex = 44
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
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
        Me.DisplayCustomizations1.Location = New System.Drawing.Point(33, 550)
        Me.DisplayCustomizations1.Name = "DisplayCustomizations1"
        Me.DisplayCustomizations1.Size = New System.Drawing.Size(400, 121)
        Me.DisplayCustomizations1.TabIndex = 45
        Me.DisplayCustomizations1.UseVisualStyleBackColor = False
        '
        'frmCustomerBookFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 729)
        Me.Controls.Add(Me.lblReservedCount)
        Me.Controls.Add(Me.lblFlightAmount)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radDesignatedSeat)
        Me.Controls.Add(Me.radReservedSeat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DisplayCustomizations3)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.DisplayCustomizations1)
        Me.Controls.Add(Me.cboFutureFlights)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1000, 800)
        Me.MinimumSize = New System.Drawing.Size(1000, 800)
        Me.Name = "frmCustomerBookFlight"
        Me.Text = "Customer Book Flight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboFutureFlights As ComboBox
    Friend WithEvents btnBack As DisplayCustomizations
    Friend WithEvents DisplayCustomizations3 As DisplayCustomizations
    Friend WithEvents btnSubmit As DisplayCustomizations
    Friend WithEvents DisplayCustomizations1 As DisplayCustomizations
    Friend WithEvents Label10 As Label
    Friend WithEvents radReservedSeat As RadioButton
    Friend WithEvents radDesignatedSeat As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblFlightAmount As Label
    Friend WithEvents lblReservedCount As Label
End Class
