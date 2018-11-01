Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mypath As New System.Drawing.Drawing2D.GraphicsPath
        mypath.AddEllipse(0, 0, Me.Width, Me.Height)
        Dim myregion As New Region(mypath)
        Me.Region = myregion
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.FormBorderStyle = FormBorderStyle.Sizable
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Size = New Size(300, 500)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Opacity = 0.4
    End Sub
End Class
