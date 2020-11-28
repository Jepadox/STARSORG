Imports System.Data.SqlClient
Public Class CMembers
    Private _Member As CMember

    Public Sub New()
        _Member = New CMember
    End Sub
    Public ReadOnly Property CurrentObject() As CMember
        Get
            Return _Member
        End Get
    End Property
    Public Sub Clear()
        _Member = New CMember
    End Sub
    Public Sub CreateNewMember()
        Clear()
        _Member.IsNewMember = True
    End Sub
    Public Function Save() As Integer
        Return _Member.Save()
    End Function
    Public Function GetAllMembers() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("sp_getAllMembers", Nothing)
        Return objDR
    End Function
    Public Function GetMemberByPID(strID As String) As CMember
        Dim params As New ArrayList
        params.Add(New SqlParameter("pID", strID))
        FillObject(myDB.GetDataReaderBySP("sp_getMemberByPID", params))
        Return _Member
    End Function
    Public Function SearchMembersByLName(strID As String) As SqlDataReader
        Dim objDR As SqlDataReader
        Dim params As New ArrayList
        params.Add(New SqlParameter("lName", strID))
        objDR = myDB.GetDataReaderBySP("sp_searchMembersByLName", params)
        Return objDR
    End Function
    Public Function GetMemberByLName(strID As String) As CMember
        Dim params As New ArrayList
        params.Add(New SqlParameter("lName", strID))
        FillObject(myDB.GetDataReaderBySP("sp_getMemberByLName", params))
        Return _Member
    End Function

    Private Function FillObject(objDR As SqlDataReader) As CMember
        If objDR.Read Then
            With _Member
                .PID = objDR.Item("PID")
                .FName = objDR.Item("FName")
                .LName = objDR.Item("LName")
                .MI = objDR.Item("MI")
                .Email = objDR.Item("Email")
                .Phone = objDR.Item("Phone")
                .PhotoPath = objDR.Item("PhotoPath")
            End With
        Else
            'no record was returned, so nothing to do here
        End If
        objDR.Close()
        Return _Member
    End Function
End Class
