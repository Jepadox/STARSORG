Imports System.Data.SqlClient
Public Class CRsvp
    'Represents a single record in the RSVP table
    Private _mstrEventID As String
    Private _mstrFName As String
    Private _mstrLName As String
    Private _mstrEmail As String
    Private _isNewRsvp As Boolean
    'Constructor
    Public Sub New()
        _mstrEventID = ""
        _mstrFName = ""
        _mstrLName = ""
        _mstrEmail = ""
    End Sub
#Region "Exposed Properties"
    Public Property EventID As String
        Get
            Return _mstrEventID
        End Get
        Set(strVal As String)
            _mstrEventID = strVal
        End Set
    End Property
    Public Property FName As String
        Get
            Return _mstrFName
        End Get
        Set(strVal As String)
            _mstrFName = strVal
        End Set
    End Property
    Public Property LName As String
        Get
            Return _mstrLName
        End Get
        Set(strVal As String)
            _mstrLName = strVal
        End Set
    End Property
    Public Property Email As String
        Get
            Return _mstrEmail
        End Get
        Set(strVal As String)
            _mstrEmail = strVal
        End Set
    End Property
    Public Property IsNewRsvp As Boolean
        Get
            Return _isNewRsvp
        End Get
        Set(blnVal As Boolean)
            _isNewRsvp = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        'This properties code will create the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("eventID", _mstrEventID))
            params.Add(New SqlParameter("fName", _mstrFName))
            params.Add(New SqlParameter("lName", _mstrLName))
            params.Add(New SqlParameter("email", _mstrEmail))
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        'Return -1 if the ID already exists (and we cannot create a new record with duplicate ID)
        If IsNewRsvp Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("eventID", _mstrEventID))
            params.Add(New SqlParameter("email", _mstrEmail))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckRsvpExists", params)
            If Not strResult = 0 Then
                Return -1 'not unique
            End If
        End If
        'if not a new role, or it is new and has unique ID, then do the save(update or insert)
        Return myDB.ExecSP("sp_saveRsvp", GetSaveParameters)
    End Function
    Public Function GetReportData() As SqlDataAdapter
        Return myDB.GetDataAdapterBySP("sp_getAllRsvps", Nothing)
    End Function
End Class
