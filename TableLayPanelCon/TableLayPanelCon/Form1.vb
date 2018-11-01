Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abutton As New Button
        abutton.Text = "New Button 1"
        abutton.Width = 150
        TableLayoutPanel1.Controls.Add(abutton)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim abutton As New Button
        abutton.Text = "New Button 2"
        abutton.Width = 150
        'to specify which cell
        TableLayoutPanel1.Controls.Add(abutton, 2, 1)
    End Sub
End Class
