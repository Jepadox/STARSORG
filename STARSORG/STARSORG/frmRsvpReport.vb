Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmRsvpReport
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Rsvp As CRsvp
    Private Sub frmRsvpReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpvRsvpReport.RefreshReport()
    End Sub
    Public Sub Display()
        Rsvp = New CRsvp
        rpvRsvpReport.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory & "Reports\rptRsvp.rdlc"
        ds = New DataSet
        da = Rsvp.GetReportData
        da.Fill(ds)
        rpvRsvpReport.LocalReport.DataSources.Add(New ReportDataSource("dsRsvp", ds.Tables(0)))
        rpvRsvpReport.SetDisplayMode(DisplayMode.PrintLayout)
        rpvRsvpReport.RefreshReport()
        Me.Cursor = Cursors.Default
        Me.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class