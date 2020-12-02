Imports System.Data.SqlClient
Public Class frmRsvp
    Private objRsvps As CRsvps
    Private objEvents As CEvents
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
        'Do nothing, were already here
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
    Private Sub txtBoxes_GotFocus(sender As Object, e As EventArgs) Handles txtFName.GotFocus, txtLName.GotFocus, txtEmail.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.SelectAll()
    End Sub
    Private Sub txtBoxes_LostFocus(sender As Object, e As EventArgs) Handles txtFName.GotFocus, txtLName.GotFocus, txtEmail.GotFocus
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
    Private Sub LoadRsvps()
        Dim objDR As SqlDataReader
        lstRsvps.Items.Clear()
        Try
            objDR = objRsvps.getAllRsvps
            Do While objDR.Read
                lstRsvps.Items.Add(objDR.Item("EventId") & objDR.Item("Email"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have CDB throw the error and trap it here
        End Try
        If objRsvps.CurrentObject.EventID <> "" Then
            lstRsvps.SelectedIndex = lstRsvps.FindStringExact(objRsvps.CurrentObject.EventID & objRsvps.CurrentObject.Email)
        End If
        blnReloading = False
    End Sub
    Private Sub LoadEventInfo()
        Try
            objEvents.GetEventByEventID(lstEvents.SelectedItem.ToString)
            With objEvents.CurrentObject
                lblEventID.Text = .EventID
                lblDesc.Text = .EventDescription
                dtmEnd.Value = .EndDate
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Event values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRsvp_Load(sender As Object, e As EventArgs) Handles Me.Load
        objEvents = New CEvents
        objRsvps = New CRsvps
    End Sub

    Private Sub frmRsvp_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If secRole = "ADMIN" Then
            tsbAdmin.Visible = True
            tsbAdminSeparator.Visible = True
        End If
        ClearScreenControls(Me)
        LoadEvents()
        LoadRsvps()
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
        LoadEventInfo()
        grpEdit.Enabled = True
    End Sub
    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNew.Checked Then
            tslStatus.Text = ""
            txtFName.Clear()
            txtLName.Clear()
            txtEmail.Clear()
            lstEvents.SelectedIndex = -1
            lstRsvps.SelectedIndex = -1
            grpRsvps.Enabled = False
            grpEdit.Enabled = True
            txtFName.Focus()
            objRsvps.CreateNewRsvp()
        Else
            grpRsvps.Enabled = True
            grpEdit.Enabled = False
            objRsvps.CurrentObject.IsNewRsvp = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        tslStatus.Text = ""
        chkNew.Checked = False
        errP.Clear()
        If lstEvents.SelectedIndex And lstRsvps.SelectedIndex <> -1 Then
            LoadEventInfo() 'reload what was selected in case user had messed up the form
        Else
            grpEdit.Enabled = False
        End If
        blnClearing = False
        objRsvps.CurrentObject.IsNewRsvp = False
        grpRsvps.Enabled = True
    End Sub

    Private Sub btnRsvp_Click(sender As Object, e As EventArgs) Handles btnRsvp.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        tslStatus.Text = ""
        '--------- add your validation code here ---------
        If Not ValidateTextBoxLength(txtFName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtLName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtEmail, errP) Then
            blnErrors = True
        End If
        If dtmEnd.Value < Today.Date Then
            errP.SetError(dtmEnd, "Cannot Rsvp because event has already happened!")
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objRsvps.CurrentObject
            .EventID = lblEventID.Text
            .FName = txtFName.Text
            .LName = txtLName.Text
            .Email = txtEmail.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objRsvps.Save
            If intResult = 1 Then
                tslStatus.Text = "Rsvp record saved"
            End If
            If intResult = -1 Then 'RoleID was not unique when adding a new record
                MessageBox.Show("EventID and Email must be unique. Unable to save Rsvp record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Rsvp record: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadRsvps() 'reload so that a newly saved record will appear in the list
        chkNew.Checked = False
        grpRsvps.Enabled = True 'in case it was disabled for a new record
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim RsvpReport As New frmRsvpReport
        If lstEvents.Items.Count = 0 Then
            MessageBox.Show("There are no records to print")
        End If
        Me.Cursor = Cursors.WaitCursor
        RsvpReport.Display()
        Me.Cursor = Cursors.Default
    End Sub
End Class