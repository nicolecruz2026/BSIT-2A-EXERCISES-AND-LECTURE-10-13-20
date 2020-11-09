Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1 As Integer = 12
        Do Until num1 = 0
            ListBox1.Text = ListBox1.Items.Add(num1)
            num1 -= 2
        Loop
    End Sub
End Class