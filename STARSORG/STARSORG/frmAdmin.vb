Imports System.Data.SqlClient
Public Class frmAdmin
    Private objMembers As CMembers
    Private objSecuritys As CSecuritys
    Private blnClearing As Boolean
    Private blnReloading As Boolean
#Region "Toolbar Stuff"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter, tsbLogOut.MouseEnter, tsbAdmin.MouseEnter
        'We need to do this because we are not putting out images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave, tsbLogOut.MouseLeave, tsbAdmin.MouseLeave
        'We need to do this because we are not putting out images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        intNextAction = ACTION_EVENT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        intNextAction = ACTION_ROLE
        Me.Hide()
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
        intNextAction = ACTION_RSVP
        Me.Hide()
    End Sub

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        intNextAction = ACTION_TUTOR
        Me.Hide()
    End Sub
    Private Sub tsbAdmin_Click(sender As Object, e As EventArgs) Handles tsbAdmin.Click
        'Do nothing'
    End Sub
#End Region
    Private Sub LoadUsers()
        Dim objDR As SqlDataReader
        lstMembers.Items.Clear()
        Try
            objDR = objMembers.GetAllMembers()
            Do While objDR.Read
                lstMembers.Items.Add(objDR.Item("PID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have cdb throw the error and trap it here
            MessageBox.Show("Error in LoadMembers", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If objMembers.CurrentObject.PID <> "" Then
            lstMembers.SelectedIndex = lstMembers.FindStringExact(objMembers.CurrentObject.PID)
        End If
        blnReloading = False
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        objMembers = New CMembers
        objSecuritys = New CSecuritys

    End Sub

    Private Sub frmAdmin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If secRole = "ADMIN" Then
            tsbAdmin.Visible = True
            tsbAdminSeparator.Visible = True
        End If
        LoadListBoxChoices()
        ClearScreenControls(Me)
        LoadUsers()
        grpEdit.Enabled = False
    End Sub
    Private Sub LoadListBoxChoices()
        cboSecurity.Items.Clear()
        cboSecurity.Items.Add(ADMIN)
        cboSecurity.Items.Add(OFFICER)
        cboSecurity.Items.Add(MEMBER)
        cboSecurity.Items.Add(GUEST)
    End Sub

    Private Sub lstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            tslStatus.Text = ""
            Exit Sub
        End If
        If lstMembers.SelectedIndex = -1 Then
            Exit Sub
        End If
        txtPassword.Clear()
        txtUserID.Clear()
        cboSecurity.SelectedIndex = -1
        LoadSelectedRecord()
        grpEdit.Enabled = True
    End Sub
    Private Sub LoadSelectedRecord()

        txtPID.Text = lstMembers.SelectedItem.ToString
        Try
            objSecuritys.GetUserByPID(lstMembers.SelectedItem.ToString)
            With objSecuritys.CurrentObject
                txtUserID.Text = .UserID
                txtPassword.Text = .Password
                cboSecurity.SelectedItem = .SecRole
                If .UserID = "" Then
                    .IsNewSecurity = True
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Member Values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        objSecuritys = New CSecuritys
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        tslStatus.Text = ""
        'validation of data being saved
        If Not ValidateTextBoxLength(txtUserID, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtPassword, errP) Then
            blnErrors = True
        End If
        If Not ValidateCombo(cboSecurity, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objSecuritys.CurrentObject
            .PID = txtPID.Text
            .UserID = txtUserID.Text
            .Password = txtPassword.Text
            .SecRole = cboSecurity.SelectedItem.ToString
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objSecuritys.Save
            If intResult = 1 Then
                tslStatus.Text = "Role record saved"
            End If
            If intResult = -1 Then 'role ID was not unique when adding new record
                MessageBox.Show("Error in btnSave_Click frmAdmin", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Error in btnSave_Click: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadUsers() 'reload so a newly saved record will appear in the list
        txtPID.Clear()
        txtPassword.Clear()
        cboSecurity.SelectedIndex = -1
        grpMembers.Enabled = True 'in case it was disabled for a new record
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        tslStatus.Text = ""
        errP.Clear()
        If lstMembers.SelectedIndex <> -1 Then
            LoadSelectedRecord() 'reload what was selected if user messed up form
        Else
            grpEdit.Enabled = False
        End If
        cboSecurity.SelectedIndex = -1
        txtPassword.Clear()
        txtUserID.Clear()
        txtPID.Clear()
        lstMembers.SelectedIndex = -1
        blnClearing = False
        objSecuritys.CurrentObject.IsNewSecurity = False
        grpEdit.Enabled = False

    End Sub
End Class