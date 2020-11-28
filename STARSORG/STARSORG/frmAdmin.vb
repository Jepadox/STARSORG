Imports System.Data.SqlClient
'Imports System.IO
Public Class frmAdmin
    Private objMembers As CMembers
    Private objSecuritys As CSecuritys
    Private blnClearing As Boolean
    Private blnReloading As Boolean
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

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        objMembers = New CMembers
        objSecuritys = New CSecuritys
    End Sub

    Private Sub frmAdmin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadMembers()
    End Sub
End Class