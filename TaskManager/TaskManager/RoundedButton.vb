Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        ' Define rounded rectangle path
        Dim radius As Integer = 20 ' Corner roundness
        Dim path As New GraphicsPath()

        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(Me.Width - radius, 0, radius, radius), -90, 90)
        path.AddArc(New Rectangle(Me.Width - radius, Me.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, Me.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()

        ' Apply region to make button rounded
        Me.Region = New Region(path)

        ' Optional: draw border
        Using pen As New Pen(Color.DarkBlue, 2)
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            pevent.Graphics.DrawPath(pen, path)
        End Using
    End Sub
End Class

