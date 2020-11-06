Imports System.Data.SqlClient
Public Class CRole
    'Represents a single record in the ROLE table
    Private _mstrRoleID As String
    Private _mstrRoleDescription
    Private _isNewRole As Boolean
    ' constructor
    Public Sub New()
        _mstrRoleID = ""
        _mstrRoleDescription = ""
    End Sub
#Region "Exposed Properties"
    Public Property RoleID As String
        Get
            Return _mstrRoleID
        End Get
        Set(strVal As String)
            _mstrRoleID = strVal
        End Set
    End Property
    Public Property RoleDescription As String
        Get
            Return _mstrRoleDescription
        End Get
        Set(strVal As String)
            _mstrRoleDescription = strVal
        End Set
    End Property
    Public Property IsNewRole As Boolean
        Get
            Return IsNewRole
        End Get
        Set(blnVal As Boolean)
            _isNewRole = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParamaters() As ArrayList
        'this property crates the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("roleID", _mstrRoleID))
            params.Add(New SqlParameter("roleDescription", _mstrRoleDescription))
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        'return -1 if the ID already exosts (can not create a new record with duplicate ID)
        If IsNewRole Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("roleID", _mstrRoleID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckRoleIDExists", params)
            If Not strResult = 0 Then
                Return -1 'not unique
            End If
        End If
        'if not new or is new with unique ID, do the save (update or insert)
        Return myDB.ExecSP("sp_saveRole", GetSaveParamaters())
    End Function
End Class
