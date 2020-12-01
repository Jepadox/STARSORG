Imports System.Data.SqlClient
Public Class CAudits
    'Represents the ROLE table and its associated business rules
    Private _Audit As CAudit
    'constructor
    Public Sub New()
        'instantiate the CRole object
        _Audit = New CAudit
    End Sub

    Public ReadOnly Property CurrentObject() As CAudit
        Get
            Return _Audit
        End Get
    End Property
    Public Sub Clear()
        _Audit = New CAudit
    End Sub
    Public Function Save() As Integer
        Return _Audit.Save
    End Function

    Private Function FillObject(objDR As SqlDataReader) As CAudit
        If objDR.Read Then
            With _Audit
                .PID = objDR.Item("PID")
                .AccessTimeStamp = objDR.Item("AccessTimeStamp")
                .Success = objDR.Item("Success")
            End With
        Else 'no record was returned
            'nothing to do here
        End If
        objDR.Close()
        Return _Audit
    End Function
End Class
