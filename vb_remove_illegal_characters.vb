Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox.TextChanged

        Dim bad As String = "/\#%&*:<>?|{}~!""" ' Illegal characters for a file name: ~ " # % & * : < > ? / \ { | }
        Dim index As Integer = TextBox.Text.LastIndexOfAny(bad)
        Dim cPos As Integer = TextBox.SelectionStart

        If index > -1 Then
            TextBox.Text = TextBox.Text.Remove(index, 1)
            TextBox.SelectionStart = index
        End If

End Sub
