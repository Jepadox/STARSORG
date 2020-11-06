<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRole
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.grpRoles = New System.Windows.Forms.GroupBox()
        Me.lstRoles = New System.Windows.Forms.ListBox()
        Me.grpEdit = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRoleID = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.grpRoles.SuspendLayout()
        Me.grpEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbHome, Me.ToolStripSeparator1, Me.tsbMember, Me.ToolStripSeparator11, Me.tsbRole, Me.ToolStripSeparator8, Me.tsbEvent, Me.ToolStripSeparator7, Me.tsbRSVP, Me.ToolStripSeparator3, Me.tsbCourse, Me.ToolStripSeparator2, Me.tsbSemester, Me.ToolStripSeparator6, Me.tsbTutor, Me.ToolStripSeparator9, Me.tsbLogOut, Me.ToolStripSeparator5, Me.tsbHelp, Me.ToolStripSeparator10, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(688, 50)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
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
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.AutoSize = False
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
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
        Me.tsbSemester.Text = "SEMESTER"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(649, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Roles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.chkNew)
        Me.grpNew.Location = New System.Drawing.Point(12, 147)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Size = New System.Drawing.Size(275, 47)
        Me.grpNew.TabIndex = 4
        Me.grpNew.TabStop = False
        Me.grpNew.Text = "New Role"
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(16, 19)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(95, 17)
        Me.chkNew.TabIndex = 0
        Me.chkNew.Text = "Add New Role"
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'grpRoles
        '
        Me.grpRoles.Controls.Add(Me.lstRoles)
        Me.grpRoles.Location = New System.Drawing.Point(12, 218)
        Me.grpRoles.Name = "grpRoles"
        Me.grpRoles.Size = New System.Drawing.Size(275, 147)
        Me.grpRoles.TabIndex = 5
        Me.grpRoles.TabStop = False
        Me.grpRoles.Text = "ROLES"
        '
        'lstRoles
        '
        Me.lstRoles.FormattingEnabled = True
        Me.lstRoles.Location = New System.Drawing.Point(16, 18)
        Me.lstRoles.Name = "lstRoles"
        Me.lstRoles.Size = New System.Drawing.Size(234, 108)
        Me.lstRoles.TabIndex = 0
        '
        'grpEdit
        '
        Me.grpEdit.Controls.Add(Me.btnCancel)
        Me.grpEdit.Controls.Add(Me.btnSave)
        Me.grpEdit.Controls.Add(Me.txtDesc)
        Me.grpEdit.Controls.Add(Me.txtRoleID)
        Me.grpEdit.Controls.Add(Me.Label3)
        Me.grpEdit.Controls.Add(Me.Label2)
        Me.grpEdit.Location = New System.Drawing.Point(325, 147)
        Me.grpEdit.Name = "grpEdit"
        Me.grpEdit.Size = New System.Drawing.Size(336, 218)
        Me.grpEdit.TabIndex = 6
        Me.grpEdit.TabStop = False
        Me.grpEdit.Text = "Edit Role"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Role ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Description"
        '
        'txtRoleID
        '
        Me.txtRoleID.Location = New System.Drawing.Point(108, 45)
        Me.txtRoleID.MaxLength = 15
        Me.txtRoleID.Name = "txtRoleID"
        Me.txtRoleID.Size = New System.Drawing.Size(183, 20)
        Me.txtRoleID.TabIndex = 2
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(108, 85)
        Me.txtDesc.MaxLength = 100
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(182, 70)
        Me.txtDesc.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(108, 174)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(216, 174)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(688, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpEdit)
        Me.Controls.Add(Me.grpRoles)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmRole"
        Me.Text = "Member Roles"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.grpRoles.ResumeLayout(False)
        Me.grpEdit.ResumeLayout(False)
        Me.grpEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents grpNew As GroupBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents grpRoles As GroupBox
    Friend WithEvents lstRoles As ListBox
    Friend WithEvents grpEdit As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtRoleID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
