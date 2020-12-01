Imports System.Data.SqlClient
Public Class CSecurity
    'Represents a single record in the ROLE table
    Private _mstrUserID As String
    Private _mstrPassword As String
    Private _mstrSecRole As String
    Private _mstrPID As String
    Private _isNewSecurity As Boolean
    ' constructor
    Public Sub New()
        _mstrUserID = ""
        _mstrPassword = ""
        _mstrSecRole = ""
        _mstrPID = ""
    End Sub
#Region "Exposed Properties"
    Public Property UserID As String
        Get
            Return _mstrUserID
        End Get
        Set(strVal As String)
            _mstrUserID = strVal
        End Set
    End Property
    Public Property Password As String
        Get
            Return _mstrPassword
        End Get
        Set(strVal As String)
            _mstrPassword = strVal
        End Set
    End Property
    Public Property SecRole As String
        Get
            Return _mstrSecRole
        End Get
        Set(strVal As String)
            _mstrSecRole = strVal
        End Set
    End Property
    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(strVal As String)
            _mstrPID = strVal
        End Set
    End Property
    Public Property IsNewSecurity As Boolean
        Get
            Return IsNewSecurity
        End Get
        Set(blnVal As Boolean)
            _isNewSecurity = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParamaters() As ArrayList
        'this property crates the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("UserID", _mstrUserID))
            params.Add(New SqlParameter("Password", _mstrPassword))
            params.Add(New SqlParameter("SecRole", _mstrSecRole))
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        'return -1 if the ID already exosts (can not create a new record with duplicate ID)
        If IsNewSecurity Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckUserIDExists", params)
            If Not strResult = 0 Then
                Return -1 'not unique
            End If
        End If
        'if not new or is new with unique ID, do the save (update or insert)
        Return myDB.ExecSP("sp_saveSecurityPID", GetSaveParamaters())
    End Function
    Public Function GetReportData() As SqlDataAdapter
        Return myDB.GetDataAdapterBySP("dbo.sp_getAllUserIDs", Nothing)
    End Function
End Class
