Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim choice As Char

        choice = LCase(TextBox1.Text)
        Select Case choice
            Case "r"
                Label2.Text = "Red"
            Case "b"
                Label2.Text = "Blue"
            Case "y"
                Label2.Text = "Yellow"
            Case "g"
                Label2.Text = "SENIOR"
            Case Else
                Label2.Text = "OUT OF RANGE"
        End Select
    End Sub
End Class
