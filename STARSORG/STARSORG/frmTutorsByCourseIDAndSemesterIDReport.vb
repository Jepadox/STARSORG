Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmTutorsByCourseIDAndSemesterIDReport

    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Tutor As CTutor_Course

    Private Sub frmTutorsByCourseIDAndSemesterIDReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpvTutorsByCourseIDAndSemesterIDReport.RefreshReport()
    End Sub

    Public Sub Display()
        Tutor = New CTutor_Course
        rpvTutorsByCourseIDAndSemesterIDReport.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory & "Reports\rptTutorsByCourseIDAndSemesterID.rdlc"
        ds = New DataSet
        da = Tutor.GetReportData
        da.Fill(ds)
        rpvTutorsByCourseIDAndSemesterIDReport.LocalReport.DataSources.Add(New ReportDataSource("dsTutorsByCourseIDAndSemesterID", ds.Tables(0)))
        rpvTutorsByCourseIDAndSemesterIDReport.SetDisplayMode(DisplayMode.PrintLayout)
        rpvTutorsByCourseIDAndSemesterIDReport.RefreshReport()
        Me.Cursor = Cursors.Default
        Me.ShowDialog()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class