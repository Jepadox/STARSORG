Imports System.Data.SqlClient
Imports System.IO
Public Class frmMember
    Private objMembers As CMembers
    Private blnClearing As Boolean
    Private blnReloading As Boolean
#Region "ToolBar Stuff"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter, tsbAdmin.MouseEnter
        'We need to do this only because we are not putting our images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text

    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave, tsbAdmin.MouseLeave
        'We need to do this only because we are not putting our images in the image property of the toolbar buttons
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
        ' no actin needed, we are already on the Member form
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
        intNextAction = ACTION_ADMIN
        Me.Hide()
    End Sub
#End Region
#Region "TextBoxes"
    Private Sub txtBoxes_GotFocus(sender As Object, e As EventArgs) Handles txtPID.GotFocus, txtFName.GotFocus, txtLName.GotFocus, txtMiddleName.GotFocus, txtEmail.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.SelectAll()
    End Sub
    Private Sub txtBoxes_LostFocus(sender As Object, e As EventArgs) Handles txtPID.LostFocus, txtPID.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.DeselectAll()
    End Sub

#End Region
    Private Sub LoadMembers()
        Dim objDR As SqlDataReader
        lstMembers.Items.Clear()
        Try
            objDR = objMembers.GetAllMembers()
            Do While objDR.Read
                lstMembers.Items.Add(objDR.Item("PID"))
                'lstMembers.Items.Add(objDR.Item("FName"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have cdb throw the error and trap it here
            MessageBox.Show("Well looks like theres an error", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If objMembers.CurrentObject.PID <> "" Then
            'If objMembers.CurrentObject.FName <> "" Then
            lstMembers.SelectedIndex = lstMembers.FindStringExact(objMembers.CurrentObject.PID)
            'lstMembers.SelectedIndex = lstMembers.FindStringExact(objMembers.CurrentObject.FName)
        End If
        blnReloading = False
    End Sub
    Private Sub frmMember_Load(sender As Object, e As EventArgs) Handles Me.Load
        objMembers = New CMembers
    End Sub

    Private Sub frmMember_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If secRole = "ADMIN" Then
            tsbAdmin.Visible = True
            tsbAdminSeparator.Visible = True
        End If
        ClearScreenControls(Me)
        LoadMembers()
        grpEdit.Enabled = False
        btnBrowse.Enabled = False
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
        chkNew.Checked = False
        LoadSelectedRecord()
        btnBrowse.Enabled = True
        grpEdit.Enabled = True
    End Sub
    Private Sub LoadSelectedRecord()
        Try
            objMembers.GetMemberByPID(lstMembers.SelectedItem.ToString)
            With objMembers.CurrentObject
                txtPID.Text = .PID
                txtFName.Text = .FName
                txtLName.Text = .LName
                txtMiddleName.Text = .MI
                txtEmail.Text = .Email
                txtPhone.Text = .Phone
                picPhoto.ImageLocation = .PhotoPath
            End With
            picPhoto.Refresh()
            picPhoto.Show()
        Catch ex As Exception
            MessageBox.Show("Error loading Member Values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'FOR LASTNAME
        Try
            objMembers.GetMemberByLName(lstMembers.SelectedItem.ToString)
            With objMembers.CurrentObject
                txtPID.Text = .PID
                txtFName.Text = .FName
                txtLName.Text = .LName
                txtMiddleName.Text = .MI
                txtEmail.Text = .Email
                txtPhone.Text = .Phone
                picPhoto.ImageLocation = .PhotoPath
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Member Values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNew.Checked Then
            tslStatus.Text = ""
            txtPID.Clear()
            txtFName.Clear()
            txtLName.Clear()
            txtMiddleName.Clear()
            txtEmail.Clear()
            txtPhone.Clear()
            picPhoto.Hide()
            lstMembers.SelectedIndex = -1
            grpMembers.Enabled = False
            grpEdit.Enabled = True
            txtPID.Focus()
            objMembers.CreateNewMember()
            btnBrowse.Enabled = True
        Else
            grpMembers.Enabled = True
            grpEdit.Enabled = False
            objMembers.CurrentObject.IsNewMember = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        tslStatus.Text = ""
        If Not ValidateTextBoxLength(txtPID, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtFName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtLName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtMiddleName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtEmail, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtPhone, errP) Then
            blnErrors = True
        End If
        If picPhoto.ImageLocation = "" Then
            blnErrors = True
        End If
        With objMembers.CurrentObject
            .PID = txtPID.Text
            .FName = txtFName.Text
            .LName = txtLName.Text
            .MI = txtMiddleName.Text
            .Email = txtEmail.Text
            .Phone = txtPhone.Text
            .PhotoPath = picPhoto.ImageLocation
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objMembers.Save
            If intResult = 1 Then
                tslStatus.Text = "Member record saved"
            End If
            If intResult = -1 Then 'Memeber PID was not unique when adding a new record
                MessageBox.Show("Member PID must be unique. Unable to save Member Record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Member Record: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadMembers()
        chkNew.Checked = False
        grpMembers.Enabled = True
        btnBrowse.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        tslStatus.Text = ""
        chkNew.Checked = False
        errP.Clear()
        If lstMembers.SelectedIndex <> -1 Then
            LoadSelectedRecord()
        Else
            grpEdit.Enabled = False
            btnBrowse.Enabled = False
        End If
        blnClearing = False
        objMembers.CurrentObject.IsNewMember = False
        grpMembers.Enabled = True
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim MemberReport As New frmMemberReport
        If lstMembers.Items.Count = 0 Then
            MessageBox.Show("There are no record to print")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        MemberReport.Display()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        findPicture()
    End Sub
    Private Sub FindPicture()
        Dim intResult As Integer
        ofdOpen.InitialDirectory = Application.StartupPath
        ofdOpen.Filter = "All files (*.*)|*.*|JPG Image Files (*.jpg)|*.jpg|PNG Image Files(*.png)|*.png"
        ofdOpen.FilterIndex = 2
        intResult = ofdOpen.ShowDialog
        If intResult = DialogResult.Cancel Then 'user canceled upon open
            Exit Sub
        End If
        picPhoto.ImageLocation = ofdOpen.FileName
        picPhoto.Refresh()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim objDR As SqlDataReader
        lstMembers.Items.Clear()
        Try
            objDR = objMembers.SearchMembersByLName(txtSearch.Text)
            Do While objDR.Read
                lstMembers.Items.Add(objDR.Item("LName"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have cdb throw the error and trap it here
            MessageBox.Show("Well looks like theres an error", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'If objMembers.CurrentObject.PID <> "" Then
        If objMembers.CurrentObject.FName <> "" Then
            'lstMembers.SelectedIndex = lstMembers.FindStringExact(objMembers.CurrentObject.PID)
            lstMembers.SelectedIndex = lstMembers.FindStringExact(objMembers.CurrentObject.FName)
        End If
        blnReloading = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSearch.Clear()
        LoadMembers()
        tslStatus.Text = ""
        txtPID.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtMiddleName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        picPhoto.Hide()
        lstMembers.SelectedIndex = -1
        grpMembers.Enabled = True
        grpEdit.Enabled = False
        btnBrowse.Enabled = False
        'txtPID.Focus()
        'objMembers.CreateNewMember()
    End Sub
End Class