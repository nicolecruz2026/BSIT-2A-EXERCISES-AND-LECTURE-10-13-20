Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Password" Then
            MessageBox.Show("Access Granted", "Password", MessageBoxButtons.OK,
            MessageBoxIcon.Information)
        Else
            MessageBox.Show("Access Denied", "Password", MessageBoxButtons.OK,
            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class