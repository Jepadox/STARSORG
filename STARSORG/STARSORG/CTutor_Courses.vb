Imports System.Data.SqlClient
Public Class CTutor_Courses
    'Represents the Tutor Course Table and its associated business rules!
    Private _TutorCourse As CTutor_Course
    'constructor
    Public Sub New()
        'instantiate the CTutorCourse Object
        _TutorCourse = New CTutor_Course
    End Sub

    Public ReadOnly Property CurrentObject() As CTutor_Course
        Get
            Return _TutorCourse
        End Get
    End Property
    Public Sub Clear()
        _TutorCourse = New CTutor_Course
    End Sub

    Public Sub CreateNewTutorCourse()
        'call this when clearing the edit portion of the screen to add a new Tutor Course
        Clear()
        _TutorCourse.IsNewTutorCourse = True

    End Sub

    Public Sub CreateRemoveTutorCourse()

        Clear()
        _TutorCourse.IsRemoveTutorCourse = True

    End Sub

    Public Function Save() As Integer
        Return _TutorCourse.Save()
    End Function

    Public Function Remove() As Integer
        Return _TutorCourse.Remove()
    End Function







    Public Function GetTutorCourseByMemberPIDAndSemesterID(PID As String, semesterID As String) As SqlDataReader
        Dim objDR As SqlDataReader
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", PID))
        params.Add(New SqlParameter("SemesterID", semesterID))
        objDR = myDB.GetDataReaderBySP("sp_getTutorCourseByMemberPIDAndSemesterID", params)
        Return objDR


    End Function



End Class
