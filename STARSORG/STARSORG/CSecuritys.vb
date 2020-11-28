Imports System.Data.SqlClient
Public Class CSecuritys
    'Represents the ROLE table and its associated business rules
    Private _Security As CSecurity
    'constructor
    Public Sub New()
        'instantiate the CSecurity object
        _Security = New CSecurity
    End Sub

    Public ReadOnly Property CurrentObject() As CSecurity
        Get
            Return _Security
        End Get
    End Property
    Public Sub Clear()
        _Security = New CSecurity
    End Sub
    Public Sub CreateNewSecurity()
        'call this when clearing edit portion of screen to add a new Security
        Clear()
        _Security.IsNewSecurity = True
    End Sub
    Public Function Save() As Integer
        Return _Security.Save
    End Function
    Public Function GetAllUserIDs() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("sp_getAllUserIDs", Nothing)
        Return objDR
    End Function
    Public Function GetPasswordByUserID(strID As String) As CSecurity
        Dim params As New ArrayList
        'Dim objDR As SqlDataReader
        params.Add(New SqlParameter("userID", strID))
        FillObject(myDB.GetDataReaderBySP("sp_getUserByUserID", params))
        Return _Security
    End Function
    Private Function FillObject(objDR As SqlDataReader) As CSecurity
        If objDR.Read Then
            With _Security
                .UserID = objDR.Item("UserID")
                .Password = objDR.Item("Password")
                .SecRole = objDR.Item("SecRole")
            End With
        Else 'no record was returned
            'nothing to do here
        End If
        objDR.Close()
        Return _Security
    End Function
End Class
