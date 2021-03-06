Public Class frmLogin
    Private objSecuritys As CSecuritys
    Private objAudits As CAudits
    Private changePass As Boolean
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim blnErrors As Boolean
        Dim intResult As Integer
        'do nothing if username or password is left blank
        If Not ValidateTextBoxLength(txtUser, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtPass, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        Try
            objSecuritys.GetUserByUserID(txtUser.Text)
            With objSecuritys.CurrentObject
                If .Password = txtPass.Text Then
                    secRole = .SecRole
                    userID = .UserID
                    pantherID = .PID
                Else
                    MessageBox.Show("Incorrect Username or password!")
                    With objAudits.CurrentObject
                        .PID = "9999999"
                        .AccessTimeStamp = DateTime.Now.ToShortTimeString
                        .Success = False
                    End With
                    objAudits.Save()
                    objAudits = New CAudits
                    Exit Sub
                End If
            End With
            'change password if change is checked
            If changePass Then
                If Not ValidateTextBoxLength(txtNewPassword, errP) Then
                    Exit Sub
                End If
                With objSecuritys.CurrentObject
                    .UserID = txtUser.Text
                    .Password = txtNewPassword.Text
                End With
                Try
                    intResult = objSecuritys.Save
                    If intResult = 1 Then
                        txtNewPassword.Clear()
                        txtPass.Clear()
                        txtUser.Clear()
                        chkChangePassword.Checked = False
                        MessageBox.Show("Password changed")
                        Exit Sub
                    End If
                    If intResult = -1 Then
                        MessageBox.Show("Password could not be saved", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error loading User Values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            'otherwise, login
            objAudits.CurrentObject.PID = objSecuritys.CurrentObject.PID
            objAudits.CurrentObject.AccessTimeStamp = DateTime.Now.ToShortTimeString
            objAudits.CurrentObject.Success = True
            objAudits.Save()
            objAudits = New CAudits
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading User Values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSecuritys = New CSecuritys
        objAudits = New CAudits
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        'logs in with guest account valued at ID 0000001
        secRole = GUEST
        objAudits.CurrentObject.PID = "0000001"
        objAudits.CurrentObject.AccessTimeStamp = DateTime.Now.ToShortTimeString
        objAudits.CurrentObject.Success = True
        objAudits.Save()
        Me.Close()
    End Sub


    'reveals/hides change password controls if checkbox is selected/deselected
    Private Sub chkChangePassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkChangePassword.CheckedChanged
        If chkChangePassword.Checked = True Then
            lblNewPassword.Visible = True
            txtNewPassword.Visible = True
            changePass = True
        End If
        If chkChangePassword.Checked = False Then
            lblNewPassword.Visible = False
            txtNewPassword.Visible = False
            changePass = False
        End If
    End Sub

End Class