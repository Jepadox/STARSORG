Imports System.Data.SqlClient
Public Class CEvents
    'Represents the EVENT table and its associated business rules
    Private _Event As CEvent
    'Constructor
    Public Sub New()
        _Event = New CEvent
    End Sub
    Public ReadOnly Property CurrentObject() As CEvent
        Get
            Return _Event
        End Get
    End Property
    Public Sub Clear()
        _Event = New CEvent
    End Sub
    Public Sub CreateNewEvent()
        'call this when clearing the edit portion of the screen to add a new role
        Clear()
        _Event.IsNewEvent = True
    End Sub
    Public Function Save() As Integer
        Return _Event.Save()
    End Function
    Public Function getAllEvents() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("sp_getAllEvents", Nothing)
        Return objDR
    End Function
    Public Function getAllEventTypes() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("sp_getAllEventTypes", Nothing)
        Return objDR
    End Function
    Public Function GetEventByEventID(strID As String) As CEvent
        Dim params As New ArrayList
        'Dim objDR As SqlDataReader
        params.Add(New SqlParameter("eventID", strID))
        FillObject(myDB.GetDataReaderBySP("sp_getEventByEventID", params))
        Return _Event
    End Function
    Private Function FillObject(objDR As SqlDataReader) As CEvent
        If objDR.Read Then
            With _Event
                .EventID = objDR.Item("EventID")
                .EventDescription = objDR.Item("EventDescription")
                .EventTypeID = objDR.Item("EventTypeID")
                .SemesterID = objDR.Item("SemesterID")
                .StartDate = objDR.Item("StartDate")
                .EndDate = objDR.Item("EndDate")
                .Location = objDR.Item("Location")
            End With
        Else 'no record was returned
            'nothing to do here
        End If
        objDR.Close()
        Return _Event
    End Function
    Public Function CheckDate() As Boolean
        If _Event.EndDate <= Today.Date Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
