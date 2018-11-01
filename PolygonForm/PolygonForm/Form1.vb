Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mypath As New System.Drawing.Drawing2D.GraphicsPath()
        mypath.AddPolygon(New Point() {New Point(0, 0), New Point(0, Me.Height), New Point(Me.Width, 0)})
        Dim myregion As New Region(mypath)
        Me.Region = myregion
    End Sub
End Class
