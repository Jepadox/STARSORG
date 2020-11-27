Public Class frmLogin
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim blnErrors As Boolean
        If Not ValidateTextBoxLength(txtUser, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtPass, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
    End Sub
End Class