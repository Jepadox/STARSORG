Imports System.Data.SqlClient
Public Class CAudit
    'Represents a single record in the ROLE table
    Private _mstrPID As String
    Private _mstrAccessTimeStamp
    Private _mstrSuccess As Boolean
    ' constructor
    Public Sub New()
        _mstrPID = ""
        _mstrAccessTimeStamp = ""
    End Sub
#Region "Exposed Properties"
    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(strVal As String)
            _mstrPID = strVal
        End Set
    End Property
    Public Property AccessTimeStamp As String
        Get
            Return _mstrAccessTimeStamp
        End Get
        Set(strVal As String)
            _mstrAccessTimeStamp = strVal
        End Set
    End Property
    Public Property Success As String
        Get
            Return _mstrSuccess
        End Get
        Set(strVal As String)
            _mstrSuccess = strVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParamaters() As ArrayList
        'this property crates the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("pID", _mstrPID))
            params.Add(New SqlParameter("accessTimeStamp", _mstrAccessTimeStamp))
            params.Add(New SqlParameter("success", _mstrSuccess))
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer

        Dim params As New ArrayList
        params.Add(New SqlParameter("pID", _mstrPID))
        Return myDB.ExecSP("sp_saveAuditLog", GetSaveParamaters())
    End Function
End Class