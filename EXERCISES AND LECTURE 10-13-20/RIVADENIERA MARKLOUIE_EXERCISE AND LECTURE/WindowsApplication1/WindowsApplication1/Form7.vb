Public Class Form7

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sum, n As Integer
        ListBox1.Items.Add("Number" & vbTab & " Sum")
        ListBox1.Items.Add("======================")
        Do
            n += 1
            sum += n
            ListBox1.Items.Add(n & vbTab & vbTab & sum)
            If n = 10 Then
                Exit Do
            End If
        Loop
    End Sub
End Class