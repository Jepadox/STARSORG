Imports System.Data.SqlClient
Public Class FrmTutor
    Private objTutorCourses As CTutor_Courses
    '----------------------------------------
    'objects for CSemesters, CMembers, CCourses class. this should be good when all the classes are put together
    Private objSemesters As CSemesters
    Private objMembers As CMembers
    Private objCourses As CCourses
    '----------------------------------------
    Private blnClearing As Boolean
    Private blnreloading As Boolean
#Region "ToolBar stuff"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter, tsbAdmin.MouseEnter
        'we need to do this only because we are not putting out images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave, tsbAdmin.MouseLeave
        'we need to do this only because we are not putting out images in the image property of the toolbar buttons
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
        'no action needed already on the Tutor form
    End Sub
    Private Sub tsbAdmin_Click(sender As Object, e As EventArgs) Handles tsbAdmin.Click
        intNextAction = ACTION_ADMIN
        Me.Hide()
    End Sub
#End Region

    Private Sub LoadAvailiableTutorCourses()
        Dim objDR As SqlDataReader
        lstAvailableTutoringCourses.Items.Clear()
        Try
            'getting course table information using CCourses class 
            objDR = objCourses.GetAllCourses 'change "GetAllCourses" to the correct stored procedure name that gets all course ID's from the course table
            Do While objDR.Read
                lstAvailableTutoringCourses.Items.Add(objDR.Item("CourseID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have CDB throw the error and trap it here
        End Try
        If objCourses.CurrentObject.CourseID <> "" Then
            lstAvailableTutoringCourses.SelectedIndex = lstAvailableTutoringCourses.FindStringExact(objCourses.CurrentObject.CourseID)

        End If
        blnreloading = False
    End Sub
    Private Sub LoadCurrentTutorCourses()
        Dim objDR As SqlDataReader
        lstCurrentTutorCourses.Items.Clear()
        Try
            objDR = objTutorCourses.GetTutorCourseByMemberPIDAndSemesterID(pantherID, cboSemester.SelectedIndex) 'add current logged in memberID inside of "MemberID"
            Do While objDR.Read
                lstCurrentTutorCourses.Items.Add(objDR.Item("CourseID"))
            Loop
            objDR.Close()
        Catch ex As Exception

        End Try
        blnreloading = False

    End Sub
    Private Sub LoadSemesters()
        Dim objDR As SqlDataReader
        cboSemester.Items.Clear()

        Try
            'get all semester ID's using the CSemesters class

            objDR = objSemesters.GetAllSemesters 'change GetAllSemesters to the correct stored procedure name that gets all the semester ID's
            Do While objDR.Read
                cboSemester.Items.Add(objDR.Item("SemesterID"))
            Loop
            objDR.Close()

        Catch ex As Exception

        End Try
        blnreloading = False


    End Sub

    Private Sub FrmTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objTutorCourses = New CTutor_Courses
        objSemesters = New CSemesters
        objCourses = New CCourses
        objMembers = New CMembers
    End Sub

    Private Sub FrmTutor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If secRole = "ADMIN" Then
            tsbAdmin.Visible = True
            tsbAdminSeparator.Visible = True
        End If
        ClearScreenControls(Me)
        LoadSemesters()

    End Sub

    Private Sub cboSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSemester.SelectedIndexChanged

        If blnClearing Then
            Exit Sub
        End If
        If blnreloading Then
            tslStatus.Text = ""
            Exit Sub
        End If
        If cboSemester.SelectedIndex = -1 Then
            Exit Sub
        End If

        LoadAvailiableTutorCourses()
        LoadCurrentTutorCourses()

    End Sub

    Private Sub radAddNewTutoringCourse_CheckedChanged(sender As Object, e As EventArgs) Handles radAddNewTutoringCourse.CheckedChanged
        If radAddNewTutoringCourse.Checked Then
            lstCurrentTutorCourses.Enabled = False
            lstAvailableTutoringCourses.Enabled = True
            objTutorCourses.CreateNewTutorCourse()
        Else
            lstCurrentTutorCourses.Enabled = True
            objTutorCourses.CurrentObject.IsNewTutorCourse = False


        End If
    End Sub

    Private Sub radRemoveTutoringCourse_CheckedChanged(sender As Object, e As EventArgs) Handles radRemoveTutoringCourse.CheckedChanged
        If radRemoveTutoringCourse.Checked Then
            lstCurrentTutorCourses.Enabled = True
            lstAvailableTutoringCourses.Enabled = False
            objTutorCourses.CreateRemoveTutorCourse()


        Else
            lstAvailableTutoringCourses.Enabled = True
            objTutorCourses.CurrentObject.IsRemoveTutorCourse = False
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        errP.Clear()
        tslStatus.Text = ""
        '--------add your validation code here-------'
        If cboSemester.SelectedIndex = -1 Then 'no semester as selected
            errP.SetError(cboSemester, "You must select a semester")
            tslStatus.Text = "Error"
            blnErrors = True
        End If
        If radAddNewTutoringCourse.Checked = False And radRemoveTutoringCourse.Checked = False Then ' no action selected
            errP.SetError(grpTutoringCourses, "You must select an action")
            tslStatus.Text = "Error"
            blnErrors = True
        End If
        If radAddNewTutoringCourse.Checked = True And lstAvailableTutoringCourses.SelectedIndex = -1 Then 'add new course is selected but no course is selected
            errP.SetError(grpAvailableTutoringCourses, "You must select a course")
            tslStatus.Text = "Error"
            blnErrors = True
        End If
        If radRemoveTutoringCourse.Checked = True And lstCurrentTutorCourses.SelectedIndex = -1 Then ' remove course is selected but no course is selected
            errP.SetError(grpCurrentTutoringCourses, "You must select a course")
            tslStatus.Text = "Error"
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If

        If radRemoveTutoringCourse.Checked Then

            Try
                Me.Cursor = Cursors.WaitCursor
                intResult = objTutorCourses.Remove
                If intResult = -1 Then
                    tslStatus.Text = "Tutor Course Removed"
                End If
                If intResult = 1 Then 'Record did not exist 
                    MessageBox.Show("Unable to remove tutor course, member not currently tutoring selected course", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tslStatus.Text = "Error"
                End If

            Catch ex As Exception
                MessageBox.Show("Unable to remove tutor course  " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tslStatus.Text = "Error"
            End Try


        End If
        If radAddNewTutoringCourse.Checked Then

            Try
                Me.Cursor = Cursors.WaitCursor
                intResult = objTutorCourses.Save
                If intResult = 1 Then
                    tslStatus.Text = "Tutor Course Saved"
                End If
                If intResult = -1 Then 'role ID was not unique when adding a new record
                    MessageBox.Show("Unable to save tutor course, member already tutoring this course", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tslStatus.Text = "Error"
                End If

            Catch ex As Exception
                MessageBox.Show("Unable to save tutor course  " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tslStatus.Text = "Error"
            End Try




        End If
        'update and refresh form info
        Me.Cursor = Cursors.Default
        blnreloading = True
        LoadAvailiableTutorCourses()
        LoadCurrentTutorCourses()
        radAddNewTutoringCourse.Checked = False
        radRemoveTutoringCourse.Checked = False
        grpAvailableTutoringCourses.Enabled = True 'in case it was disabled for a new record
        grpCurrentTutoringCourses.Enabled = True

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        tslStatus.Text = ""
        radAddNewTutoringCourse.Checked = False
        radRemoveTutoringCourse.Checked = False
        cboSemester.SelectedIndex = -1
        errP.Clear()


        blnClearing = False
        objTutorCourses.CurrentObject.IsNewTutorCourse = False
        objTutorCourses.CurrentObject.IsRemoveTutorCourse = False
        grpAvailableTutoringCourses.Enabled = True
        grpCurrentTutoringCourses.Enabled = True
        'also clear report radio buttons
        radListTutorsForCourses.Checked = False
        radListTutorsForSemester.Checked = False

    End Sub
    'COMMENTING OUT REPORT CLICK UNTIL REPORT IS FULLY IMPLEMENTED

    'Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
    '    Dim TutorsBySemesterReport As New frmTutorsBySemesterReport
    '    Dim TutorsByCourseIDAndSemesterIDReport As New frmTutorsByCourseIDAndSemesterIDReport
    '    If radListTutorsForCourses.Checked = False And radListTutorsForSemester.Checked = False Then
    '        MessageBox.Show("Please select a report type")
    '        Exit Sub
    '    End If
    '    If radListTutorsForSemester.Checked = True Then
    '        Me.Cursor = Cursors.WaitCursor
    '        TutorsBySemesterReport.Display()
    '        Me.Cursor = Cursors.Default
    '    End If
    '    If radListTutorsForCourses.Checked = True Then
    '        Me.Cursor = Cursors.WaitCursor
    '        TutorsByCourseIDAndSemesterIDReport.Display()
    '        Me.Cursor = Cursors.Default
    '    End If
    '
    'End Sub
End Class