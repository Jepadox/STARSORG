Imports System.Data.SqlClient
Public Class CTutor_Course

    Private _mstrPID As String
    Private _mstrCourseID As String
    Private _mstrSemesterID As String
    Private _isNewTutorCourse As Boolean
    Private _isRemoveTutorCourse As Boolean

    'constructor
    Public Sub New()
        _mstrCourseID = ""
        _mstrSemesterID = ""
        _mstrPID = ""
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
    Public Property CourseID As String
        Get
            Return _mstrCourseID
        End Get
        Set(strVal As String)
            _mstrCourseID = strVal
        End Set
    End Property
    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(strVal As String)
            _mstrSemesterID = strVal
        End Set
    End Property
    Public Property IsNewTutorCourse As Boolean
        Get
            Return _isNewTutorCourse
        End Get
        Set(blnVal As Boolean)
            _isNewTutorCourse = blnVal
        End Set
    End Property
    Public Property IsRemoveTutorCourse As Boolean
        Get
            Return _isRemoveTutorCourse
        End Get
        Set(blnVal As Boolean)
            _isRemoveTutorCourse = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("CourseID", _mstrCourseID))
            params.Add(New SqlParameter("SemesterID", _mstrSemesterID))

            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        'return -1 if the ID already exists (and we cannot create a new record with duplicate ID)
        If IsNewTutorCourse Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("CourseID", _mstrCourseID))
            params.Add(New SqlParameter("SemesterID", _mstrSemesterID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckTutorCourseExists", params)
            If Not strResult = 0 Then
                Return -1
            End If
        End If
        'if not a new role, or it is new and has a unique ID, then do the save (update or insert)
        Return myDB.ExecSP("sp_saveTutorCourse", GetSaveParameters())
    End Function

    Public Function Remove() As Integer
        If IsRemoveTutorCourse Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("CourseID", _mstrCourseID))
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("SemesterID", _mstrSemesterID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckTutorCourseExists", params)
            If Not strResult = 0 Then
                Return myDB.ExecSP("sp_removeTutorCourse", GetSaveParameters()) 'if the record exists already, remove it
            End If
        End If
        Return -1 'if the record does not exist return -1
    End Function

    Public Function GetReportData() As SqlDataAdapter
        Dim params As New ArrayList
        params.Add(New SqlParameter("SemesterID", _mstrSemesterID))
        Return myDB.GetDataAdapterBySP("sp_getAllTutorsBySemesterID", params)
    End Function

    Public Function GetReportData2() As SqlDataAdapter
        Dim params As New ArrayList
        params.Add(New SqlParameter("SemesterID", _mstrSemesterID))
        params.Add(New SqlParameter("CourseID", _mstrCourseID))
        Return myDB.GetDataAdapterBySP("sp_getAllTutorsByCourseIDAndSemesterID", params)
    End Function
End Class
