Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        Dim name As String
        name = txt_username.Text
        If name = String.Empty Or name.Contains(" ") Or cbo_level.Text = String.Empty Then
            MessageBox.Show("reenter user name")
        Else
            Me.Hide()
            Tutorial.Show()

        End If
    End Sub
End Class