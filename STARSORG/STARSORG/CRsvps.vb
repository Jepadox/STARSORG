Imports System.Data.SqlClient
Public Class CRsvps
    'Represents the RSVP table and its associated business rules
    Private _Rsvp As CRsvp
    'Constructor
    Public Sub New()
        _Rsvp = New CRsvp
    End Sub
    Public ReadOnly Property CurrentObject() As CRsvp
        Get
            Return _Rsvp
        End Get
    End Property
    Public Sub Clear()
        _Rsvp = New CRsvp
    End Sub
    Public Sub CreateNewRsvp()
        'call this when clearing the edit portion of the screen to add a new rsvp
        Clear()
        _Rsvp.IsNewRsvp = True
    End Sub
    Public Function Save() As Integer
        Return _Rsvp.Save()
    End Function
    Public Function getAllRsvps() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("sp_getAllRsvps", Nothing)
        Return objDR
    End Function
End Class
