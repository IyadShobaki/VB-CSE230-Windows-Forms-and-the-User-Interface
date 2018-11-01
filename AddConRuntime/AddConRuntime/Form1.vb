Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abutton As New Button()
        abutton.Location = New Point(20, 20)
        abutton.Text = "Test Button"
        Me.Controls.Add(abutton)
    End Sub
End Class
