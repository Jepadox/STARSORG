Imports System.Data.SqlClient
Public Class CSemester
    'Represents a single record in the SEMESTER table
    Private _mstrSemesterID As String
    Private _mstrSemesterDescription As String
    Private _isNewSemester As Boolean
    'Constructor
    Public Sub New()
        _mstrSemesterID = ""
        _mstrSemesterDescription = ""
    End Sub
#Region "Exposed Properties"
    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(strVal As String)
            _mstrSemesterID = strVal
        End Set
    End Property
    Public Property SemesterDescription As String
        Get
            Return _mstrSemesterDescription
        End Get
        Set(strVal As String)
            _mstrSemesterDescription = strVal
        End Set
    End Property
    Public Property IsNewSemester As Boolean
        Get
            Return _isNewSemester
        End Get
        Set(blnVal As Boolean)
            _isNewSemester = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        'This properties code will create the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("semesterID", _mstrSemesterID))
            params.Add(New SqlParameter("semesterDescription", _mstrSemesterDescription))
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        'Return -1 if the ID already exists (and we cannot create a new record with duplicate ID)
        If IsNewSemester Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("semesterID", _mstrSemesterID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckSemesterIDExists", params)
            If Not strResult = 0 Then
                Return -1 'not unique
            End If
        End If
        'if not a new role, or it is new and has unique ID, then do the save(update or insert)
        Return myDB.ExecSP("sp_saveSemester", GetSaveParameters)
    End Function
End Class
