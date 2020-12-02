<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutorsByCourseIDAndSemesterIDReport
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
        Me.rpvTutorsByCourseIDAndSemesterIDReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rpvTutorsByCourseIDAndSemesterIDReport
        '
        Me.rpvTutorsByCourseIDAndSemesterIDReport.Location = New System.Drawing.Point(12, 12)
        Me.rpvTutorsByCourseIDAndSemesterIDReport.Name = "rpvTutorsByCourseIDAndSemesterIDReport"
        Me.rpvTutorsByCourseIDAndSemesterIDReport.ServerReport.BearerToken = Nothing
        Me.rpvTutorsByCourseIDAndSemesterIDReport.Size = New System.Drawing.Size(742, 369)
        Me.rpvTutorsByCourseIDAndSemesterIDReport.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(638, 398)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 36)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmTutorsByCourseIDAndSemesterIDReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rpvTutorsByCourseIDAndSemesterIDReport)
        Me.Name = "frmTutorsByCourseIDAndSemesterIDReport"
        Me.Text = "Tutors In Selected Course And Semester"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpvTutorsByCourseIDAndSemesterIDReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnClose As Button
End Class
