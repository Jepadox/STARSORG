<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTutor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAdmin = New System.Windows.Forms.ToolStripButton()
        Me.tsbAdminSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpAvailableTutoringCourses = New System.Windows.Forms.GroupBox()
        Me.lstAvailableTutoringCourses = New System.Windows.Forms.ListBox()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.lstCurrentTutorCourses = New System.Windows.Forms.ListBox()
        Me.grpCurrentTutoringCourses = New System.Windows.Forms.GroupBox()
        Me.grpSemester = New System.Windows.Forms.GroupBox()
        Me.radRemoveTutoringCourse = New System.Windows.Forms.RadioButton()
        Me.radAddNewTutoringCourse = New System.Windows.Forms.RadioButton()
        Me.grpTutoringCourses = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.radListTutorsForCourses = New System.Windows.Forms.RadioButton()
        Me.radListTutorsForSemester = New System.Windows.Forms.RadioButton()
        Me.grpReport = New System.Windows.Forms.GroupBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.grpAvailableTutoringCourses.SuspendLayout()
        Me.grpCurrentTutoringCourses.SuspendLayout()
        Me.grpSemester.SuspendLayout()
        Me.grpTutoringCourses.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.grpReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbHome, Me.ToolStripSeparator9, Me.tsbMember, Me.ToolStripSeparator7, Me.tsbRole, Me.ToolStripSeparator2, Me.tsbEvent, Me.ToolStripSeparator6, Me.tsbRSVP, Me.ToolStripSeparator3, Me.tsbCourse, Me.ToolStripSeparator5, Me.tsbSemester, Me.ToolStripSeparator4, Me.tsbTutor, Me.ToolStripSeparator10, Me.tsbLogOut, Me.ToolStripSeparator11, Me.tsbHelp, Me.ToolStripSeparator8, Me.tsbAdmin, Me.tsbAdminSeparator})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(673, 50)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.STARSORG.My.Resources.Resources.home
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(48, 48)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.STARSORG.My.Resources.Resources.member
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(48, 48)
        Me.tsbMember.Text = "MEM"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRole
        '
        Me.tsbRole.AutoSize = False
        Me.tsbRole.BackgroundImage = Global.STARSORG.My.Resources.Resources.roles
        Me.tsbRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRole.Name = "tsbRole"
        Me.tsbRole.Size = New System.Drawing.Size(48, 48)
        Me.tsbRole.Text = "ROLE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
        '
        'tsbEvent
        '
        Me.tsbEvent.AutoSize = False
        Me.tsbEvent.BackgroundImage = Global.STARSORG.My.Resources.Resources.events
        Me.tsbEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEvent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEvent.Name = "tsbEvent"
        Me.tsbEvent.Size = New System.Drawing.Size(48, 48)
        Me.tsbEvent.Text = "EVENT"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRSVP
        '
        Me.tsbRSVP.AutoSize = False
        Me.tsbRSVP.BackgroundImage = Global.STARSORG.My.Resources.Resources.rsvp
        Me.tsbRSVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRSVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRSVP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSVP.Name = "tsbRSVP"
        Me.tsbRSVP.Size = New System.Drawing.Size(48, 48)
        Me.tsbRSVP.Text = "RSVP"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 50)
        '
        'tsbCourse
        '
        Me.tsbCourse.AutoSize = False
        Me.tsbCourse.BackgroundImage = Global.STARSORG.My.Resources.Resources.courses
        Me.tsbCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCourse.Name = "tsbCourse"
        Me.tsbCourse.Size = New System.Drawing.Size(48, 48)
        Me.tsbCourse.Text = "COURSE"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
        '
        'tsbSemester
        '
        Me.tsbSemester.AutoSize = False
        Me.tsbSemester.BackgroundImage = Global.STARSORG.My.Resources.Resources.semesters
        Me.tsbSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbSemester.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSemester.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSemester.Name = "tsbSemester"
        Me.tsbSemester.Size = New System.Drawing.Size(48, 48)
        Me.tsbSemester.Text = "SEM"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbTutor
        '
        Me.tsbTutor.AutoSize = False
        Me.tsbTutor.BackgroundImage = Global.STARSORG.My.Resources.Resources.tutors
        Me.tsbTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbTutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTutor.Name = "tsbTutor"
        Me.tsbTutor.Size = New System.Drawing.Size(48, 48)
        Me.tsbTutor.Text = "TUTOR"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(10, 50)
        '
        'tsbLogOut
        '
        Me.tsbLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogOut.AutoSize = False
        Me.tsbLogOut.BackgroundImage = Global.STARSORG.My.Resources.Resources.logout
        Me.tsbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogOut.Name = "tsbLogOut"
        Me.tsbLogOut.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogOut.Text = "LOGOUT"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator11.AutoSize = False
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.STARSORG.My.Resources.Resources.help
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(48, 48)
        Me.tsbHelp.Text = "HELP"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
        '
        'tsbAdmin
        '
        Me.tsbAdmin.AutoSize = False
        Me.tsbAdmin.BackgroundImage = Global.STARSORG.My.Resources.Resources.admin
        Me.tsbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdmin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdmin.Name = "tsbAdmin"
        Me.tsbAdmin.Size = New System.Drawing.Size(48, 48)
        Me.tsbAdmin.Text = "ADMIN"
        Me.tsbAdmin.Visible = False
        '
        'tsbAdminSeparator
        '
        Me.tsbAdminSeparator.AutoSize = False
        Me.tsbAdminSeparator.Name = "tsbAdminSeparator"
        Me.tsbAdminSeparator.Size = New System.Drawing.Size(10, 50)
        Me.tsbAdminSeparator.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(649, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TUTORING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpAvailableTutoringCourses
        '
        Me.grpAvailableTutoringCourses.Controls.Add(Me.lstAvailableTutoringCourses)
        Me.grpAvailableTutoringCourses.Location = New System.Drawing.Point(339, 216)
        Me.grpAvailableTutoringCourses.Name = "grpAvailableTutoringCourses"
        Me.grpAvailableTutoringCourses.Size = New System.Drawing.Size(241, 200)
        Me.grpAvailableTutoringCourses.TabIndex = 6
        Me.grpAvailableTutoringCourses.TabStop = False
        Me.grpAvailableTutoringCourses.Text = "Courses Available For Tutoring This Semester"
        '
        'lstAvailableTutoringCourses
        '
        Me.lstAvailableTutoringCourses.FormattingEnabled = True
        Me.lstAvailableTutoringCourses.Location = New System.Drawing.Point(7, 20)
        Me.lstAvailableTutoringCourses.Name = "lstAvailableTutoringCourses"
        Me.lstAvailableTutoringCourses.Size = New System.Drawing.Size(216, 160)
        Me.lstAvailableTutoringCourses.TabIndex = 0
        '
        'cboSemester
        '
        Me.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Location = New System.Drawing.Point(15, 31)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(189, 21)
        Me.cboSemester.TabIndex = 0
        '
        'lstCurrentTutorCourses
        '
        Me.lstCurrentTutorCourses.FormattingEnabled = True
        Me.lstCurrentTutorCourses.Location = New System.Drawing.Point(7, 20)
        Me.lstCurrentTutorCourses.Name = "lstCurrentTutorCourses"
        Me.lstCurrentTutorCourses.Size = New System.Drawing.Size(197, 108)
        Me.lstCurrentTutorCourses.TabIndex = 0
        '
        'grpCurrentTutoringCourses
        '
        Me.grpCurrentTutoringCourses.Controls.Add(Me.lstCurrentTutorCourses)
        Me.grpCurrentTutoringCourses.Location = New System.Drawing.Point(19, 216)
        Me.grpCurrentTutoringCourses.Name = "grpCurrentTutoringCourses"
        Me.grpCurrentTutoringCourses.Size = New System.Drawing.Size(255, 135)
        Me.grpCurrentTutoringCourses.TabIndex = 3
        Me.grpCurrentTutoringCourses.TabStop = False
        Me.grpCurrentTutoringCourses.Text = "Courses Currently Tutoring This Semester"
        '
        'grpSemester
        '
        Me.grpSemester.Controls.Add(Me.cboSemester)
        Me.grpSemester.Location = New System.Drawing.Point(19, 118)
        Me.grpSemester.Name = "grpSemester"
        Me.grpSemester.Size = New System.Drawing.Size(255, 72)
        Me.grpSemester.TabIndex = 2
        Me.grpSemester.TabStop = False
        Me.grpSemester.Text = "Semester"
        '
        'radRemoveTutoringCourse
        '
        Me.radRemoveTutoringCourse.AutoSize = True
        Me.radRemoveTutoringCourse.Location = New System.Drawing.Point(7, 42)
        Me.radRemoveTutoringCourse.Name = "radRemoveTutoringCourse"
        Me.radRemoveTutoringCourse.Size = New System.Drawing.Size(143, 17)
        Me.radRemoveTutoringCourse.TabIndex = 1
        Me.radRemoveTutoringCourse.TabStop = True
        Me.radRemoveTutoringCourse.Text = "Remove Tutoring Course"
        Me.radRemoveTutoringCourse.UseVisualStyleBackColor = True
        '
        'radAddNewTutoringCourse
        '
        Me.radAddNewTutoringCourse.AutoSize = True
        Me.radAddNewTutoringCourse.Location = New System.Drawing.Point(6, 19)
        Me.radAddNewTutoringCourse.Name = "radAddNewTutoringCourse"
        Me.radAddNewTutoringCourse.Size = New System.Drawing.Size(147, 17)
        Me.radAddNewTutoringCourse.TabIndex = 0
        Me.radAddNewTutoringCourse.TabStop = True
        Me.radAddNewTutoringCourse.Text = "Add New Tutoring Course"
        Me.radAddNewTutoringCourse.UseVisualStyleBackColor = True
        '
        'grpTutoringCourses
        '
        Me.grpTutoringCourses.Controls.Add(Me.radRemoveTutoringCourse)
        Me.grpTutoringCourses.Controls.Add(Me.radAddNewTutoringCourse)
        Me.grpTutoringCourses.Location = New System.Drawing.Point(346, 118)
        Me.grpTutoringCourses.Name = "grpTutoringCourses"
        Me.grpTutoringCourses.Size = New System.Drawing.Size(234, 72)
        Me.grpTutoringCourses.TabIndex = 5
        Me.grpTutoringCourses.TabStop = False
        Me.grpTutoringCourses.Text = "Select Action"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(505, 424)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 456)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(673, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslStatus
        '
        Me.tslStatus.AutoSize = False
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Size = New System.Drawing.Size(600, 17)
        Me.tslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(421, 424)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'radListTutorsForCourses
        '
        Me.radListTutorsForCourses.AutoSize = True
        Me.radListTutorsForCourses.Location = New System.Drawing.Point(7, 42)
        Me.radListTutorsForCourses.Name = "radListTutorsForCourses"
        Me.radListTutorsForCourses.Size = New System.Drawing.Size(248, 17)
        Me.radListTutorsForCourses.TabIndex = 1
        Me.radListTutorsForCourses.TabStop = True
        Me.radListTutorsForCourses.Text = "List of Tutors for Selected Course this Semester"
        Me.radListTutorsForCourses.UseVisualStyleBackColor = True
        '
        'radListTutorsForSemester
        '
        Me.radListTutorsForSemester.AutoSize = True
        Me.radListTutorsForSemester.Location = New System.Drawing.Point(6, 19)
        Me.radListTutorsForSemester.Name = "radListTutorsForSemester"
        Me.radListTutorsForSemester.Size = New System.Drawing.Size(171, 17)
        Me.radListTutorsForSemester.TabIndex = 0
        Me.radListTutorsForSemester.TabStop = True
        Me.radListTutorsForSemester.Text = "List of Tutors for This Semester"
        Me.radListTutorsForSemester.UseVisualStyleBackColor = True
        '
        'grpReport
        '
        Me.grpReport.Controls.Add(Me.btnReport)
        Me.grpReport.Controls.Add(Me.radListTutorsForCourses)
        Me.grpReport.Controls.Add(Me.radListTutorsForSemester)
        Me.grpReport.Location = New System.Drawing.Point(19, 357)
        Me.grpReport.Name = "grpReport"
        Me.grpReport.Size = New System.Drawing.Size(258, 96)
        Me.grpReport.TabIndex = 4
        Me.grpReport.TabStop = False
        Me.grpReport.Text = "Report Type"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(129, 67)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 2
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'FrmTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(673, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpReport)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.grpTutoringCourses)
        Me.Controls.Add(Me.grpSemester)
        Me.Controls.Add(Me.grpCurrentTutoringCourses)
        Me.Controls.Add(Me.grpAvailableTutoringCourses)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmTutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tutor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpAvailableTutoringCourses.ResumeLayout(False)
        Me.grpCurrentTutoringCourses.ResumeLayout(False)
        Me.grpSemester.ResumeLayout(False)
        Me.grpTutoringCourses.ResumeLayout(False)
        Me.grpTutoringCourses.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpReport.ResumeLayout(False)
        Me.grpReport.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents grpAvailableTutoringCourses As GroupBox
    Friend WithEvents lstAvailableTutoringCourses As ListBox
    Friend WithEvents cboSemester As ComboBox
    Friend WithEvents lstCurrentTutorCourses As ListBox
    Friend WithEvents grpCurrentTutoringCourses As GroupBox
    Friend WithEvents grpSemester As GroupBox
    Friend WithEvents radRemoveTutoringCourse As RadioButton
    Friend WithEvents radAddNewTutoringCourse As RadioButton
    Friend WithEvents grpTutoringCourses As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslStatus As ToolStripStatusLabel
    Friend WithEvents btnApply As Button
    Friend WithEvents grpReport As GroupBox
    Friend WithEvents radListTutorsForCourses As RadioButton
    Friend WithEvents radListTutorsForSemester As RadioButton
    Friend WithEvents btnReport As Button
    Friend WithEvents tsbAdmin As ToolStripButton
    Friend WithEvents tsbAdminSeparator As ToolStripSeparator
End Class
