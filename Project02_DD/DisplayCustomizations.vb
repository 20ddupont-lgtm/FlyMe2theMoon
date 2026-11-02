Imports System.Drawing.Drawing2D

Public Class DisplayCustomizations
    Inherits Button
    Public Property CornerRadius As Integer = 50


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim path As New GraphicsPath()
        path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90)
        path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90)
        path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90)
        path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90)
        path.CloseAllFigures()

        Me.Region = New Region(path)

        ' Draw a border (Optional)
        Using pen As New Pen(Me.ForeColor, 2)
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
