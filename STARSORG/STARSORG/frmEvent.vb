Imports System.Data.SqlClient
Public Class frmEvent
    Private objEvents As CEvents
    Private objSemesters As CSemesters
    Private blnClearing As Boolean
    Private blnReloading As Boolean
#Region "Toolbar Stuff"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogout.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter, tsbAdmin.MouseEnter
        'We need to do this only because we are not putting our images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogout.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave, tsbAdmin.MouseLeave
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
        'Already in Events so do nothing
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbLogout_Click(sender As Object, e As EventArgs) Handles tsbLogout.Click
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
        intNextAction = ACTION_ADMIN
        Me.Hide()
    End Sub
#End Region
#Region "TextBoxes"
    Private Sub txtBoxes_GotFocus(sender As Object, e As EventArgs) Handles txtEventID.GotFocus, txtDesc.GotFocus, txtLocation.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.SelectAll()
    End Sub
    Private Sub txtBoxes_LostFocus(sender As Object, e As EventArgs) Handles txtEventID.GotFocus, txtDesc.GotFocus, txtLocation.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.DeselectAll()
    End Sub
#End Region
    Private Sub LoadEvents()
        Dim objDR As SqlDataReader
        lstEvents.Items.Clear()
        Try
            objDR = objEvents.getAllEvents
            Do While objDR.Read
                lstEvents.Items.Add(objDR.Item("EventID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have CDB throw the error and trap it here
        End Try
        If objEvents.CurrentObject.EventID <> "" Then
            lstEvents.SelectedIndex = lstEvents.FindStringExact(objEvents.CurrentObject.EventID)
        End If
        blnReloading = False
    End Sub
    Private Sub LoadEventTypes()
        Dim objDR As SqlDataReader
        cboType.Items.Clear()
        Try
            objDR = objEvents.getAllEventTypes
            Do While objDR.Read
                cboType.Items.Add(objDR.Item("EventTypeID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have CDB throw the error and trap it here
        End Try
        If objEvents.CurrentObject.EventTypeID <> "" Then
            cboType.SelectedIndex = cboType.FindStringExact(objEvents.CurrentObject.EventTypeID)
        End If
        blnReloading = False
    End Sub
    Private Sub LoadSemesters()
        Dim objDR As SqlDataReader
        cboSemester.Items.Clear()
        Try
            objDR = objSemesters.getAllSemesters
            Do While objDR.Read
                cboSemester.Items.Add(objDR.Item("SemesterID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have CDB throw the error and trap it here
        End Try
        If objSemesters.CurrentObject.SemesterID <> "" Then
            cboSemester.SelectedIndex = cboSemester.FindStringExact(objSemesters.CurrentObject.SemesterID)
        End If
        blnReloading = False
    End Sub
    Private Sub frmEvent_Load(sender As Object, e As EventArgs) Handles Me.Load
        objEvents = New CEvents
        objSemesters = New CSemesters
    End Sub

    Private Sub frmEvent_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If secRole = "ADMIN" Then
            tsbAdmin.Visible = True
            tsbAdminSeparator.Visible = True
        End If
        ClearScreenControls(Me)
        LoadEvents()
        LoadEventTypes()
        LoadSemesters()
        grpEdit.Enabled = False
    End Sub

    Private Sub lstEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEvents.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            tslStatus.Text = ""
            Exit Sub
        End If
        If lstEvents.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNew.Checked = False
        LoadSelectedRecord()
        grpEdit.Enabled = True
    End Sub
    Private Sub LoadSelectedRecord()
        Try
            objEvents.GetEventByEventID(lstEvents.SelectedItem.ToString)
            With objEvents.CurrentObject
                txtEventID.Text = .EventID
                txtDesc.Text = .EventDescription
                cboType.SelectedItem = .EventTypeID
                cboSemester.SelectedItem = .SemesterID
                dtmStart.Value = .StartDate
                dtmEnd.Value = .EndDate
                txtLocation.Text = .Location
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Event values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNew.Checked Then
            tslStatus.Text = ""
            txtEventID.Clear()
            txtDesc.Clear()
            cboType.SelectedIndex = -1
            cboSemester.SelectedIndex = -1
            dtmStart.Value = Today.Date
            dtmEnd.Value = Today.Date
            txtLocation.Clear()
            lstEvents.SelectedIndex = -1
            grpEvents.Enabled = False
            grpEdit.Enabled = True
            txtEventID.Focus()
            objEvents.CreateNewEvent()
        Else
            grpEvents.Enabled = True
            grpEdit.Enabled = False
            objEvents.CurrentObject.IsNewEvent = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        tslStatus.Text = ""
        '--------- add your validation code here ---------
        If Not ValidateTextBoxLength(txtEventID, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtDesc, errP) Then
            blnErrors = True
        End If
        If Not ValidateCombo(cboType, errP) Then
            blnErrors = True
        End If
        If Not ValidateCombo(cboSemester, errP) Then
            blnErrors = True
        End If
        If Not ValidateDateTimePicker(dtmStart, errP) Then
            blnErrors = True
        End If
        If Not ValidateDateTimePicker(dtmEnd, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtLocation, errP) Then
            blnErrors = True
        End If
        If objEvents.CheckDate Then
            txtEventID.Enabled = False
            txtDesc.Enabled = False
            txtLocation.Enabled = False
            cboSemester.Enabled = False
            dtmStart.Enabled = False
            dtmEnd.Enabled = False
            errP.SetError(dtmEnd, "Event has ended, Can only change the Type Field")
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objEvents.CurrentObject
            .EventID = txtEventID.Text
            .EventDescription = txtDesc.Text
            .EventTypeID = cboType.SelectedItem.ToString
            .SemesterID = cboSemester.SelectedItem.ToString
            .StartDate = dtmStart.Value
            .EndDate = dtmEnd.Value
            .Location = txtLocation.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objEvents.Save
            If intResult = 1 Then
                tslStatus.Text = "Event record saved"
            End If
            If intResult = -1 Then 'EventID was not unique when adding a new record
                MessageBox.Show("EventID must be unique. Unable to save Event record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Event record: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadEvents() 'reload so that a newly saved record will appear in the list
        chkNew.Checked = False
        grpEvents.Enabled = True 'in case it was disabled for a new record
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        tslStatus.Text = ""
        chkNew.Checked = False
        errP.Clear()
        If lstEvents.SelectedIndex <> -1 Then
            LoadSelectedRecord() 'reload what was selected in case user had messed up the form
        Else
            grpEdit.Enabled = False
        End If
        blnClearing = False
        objEvents.CurrentObject.IsNewEvent = False
        grpEvents.Enabled = True
        txtEventID.Enabled = True
        txtDesc.Enabled = True
        txtLocation.Enabled = True
        cboSemester.Enabled = True
        dtmStart.Enabled = True
        dtmEnd.Enabled = True
    End Sub
End Class