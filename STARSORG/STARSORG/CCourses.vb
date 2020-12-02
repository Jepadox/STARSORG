Imports System.Data.SqlClient
Public Class CCourses
    'Represents the Tutor Course Table and its associated business rules!
    Private _Course As CCourse
    'constructor
    Public Sub New()
        'instantiate the CTutorCourse Object
        _Course = New CCourse
    End Sub
    Public Function GetAllCourses() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("sp_getAllCourses", Nothing)
        Return objDR
    End Function
    Public ReadOnly Property CurrentObject() As CCourse
        Get
            Return _Course
        End Get
    End Property
    Public Sub Clear()
        _Course = New CCourse
    End Sub

End Class