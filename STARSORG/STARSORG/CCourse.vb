Imports System.Data.SqlClient
Public Class CCourse

    Private _mstrCourseID As String
    Private _mstrCourseName As String


    'constructor
    Public Sub New()
        _mstrCourseID = ""
        _mstrCourseName = ""
    End Sub



    Public Property CourseName As String
        Get
            Return _mstrCourseName
        End Get
        Set(strVal As String)
            _mstrCourseName = strVal
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
    Public Function GetReportData() As SqlDataAdapter
        Return myDB.GetDataAdapterBySP("dbo.sp_getAllCourses", Nothing)
    End Function

End Class