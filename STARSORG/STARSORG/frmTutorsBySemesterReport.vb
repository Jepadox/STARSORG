Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmTutorsBySemesterReport
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Tutor As CTutor_Course
    Private Sub frmTutorsBySemesterReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpvTutorsBySemesterReport.RefreshReport()
    End Sub
    Public Sub Display()
        Tutor = New CTutor_Course
        rpvTutorsBySemesterReport.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory & "Reports\rptTutorsBySemester.rdlc"
        ds = New DataSet
        da = Tutor.GetReportData
        da.Fill(ds)
        rpvTutorsBySemesterReport.LocalReport.DataSources.Add(New ReportDataSource("dsTutorsBySemester", ds.Tables(0)))
        rpvTutorsBySemesterReport.SetDisplayMode(DisplayMode.PrintLayout)
        rpvTutorsBySemesterReport.RefreshReport()
        Me.Cursor = Cursors.Default
        Me.ShowDialog()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class