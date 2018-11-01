Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.SetFlowBreak(Button1, True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FlowLayoutPanel1.GetFlowBreak(sender) Then
            MessageBox.Show("Flowbreak is set")
        Else
            MessageBox.Show("Flowbreak is NOT set")
        End If

    End Sub
End Class
