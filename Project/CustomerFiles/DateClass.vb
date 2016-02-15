'DateClas.vb
'Created by Evgeniya O'Regan Pevchikh, 27/8/2013
Option Strict On
Option Explicit On

Public Class DateClass
    'variables for day, month and year
    Private m_day, m_month, m_year As Integer

    ''' <summary>
    ''' Default constructor - calls another constructor in this class
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.New(0, 0, 0)
    End Sub

    ''' <summary>
    ''' Constructor with 3 parameters. This is  constructor that has most
    ''' number of parameters. It is in this constructor that all coding 
    ''' should be done.
    ''' </summary>
    ''' <param name="day"></param>
    ''' <param name="month"></param>
    ''' <param name="year"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal day As Integer, ByVal month As Integer, ByVal year As Integer)
        m_day = day
        m_month = month
        m_year = year
    End Sub

    ''' <summary>
    ''' Property related to the field m_day
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Day() As Integer
        Get
            Return m_day
        End Get
        Set(ByVal value As Integer)
            m_day = value
        End Set
    End Property

    ''' <summary>
    ''' Property related to the field m_month
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Month() As Integer
        Get
            Return m_month
        End Get
        Set(ByVal value As Integer)
            m_month = value
        End Set
    End Property
    ''' <summary>
    ''' Property related to the field m_year
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Year() As Integer
        Get
            Return m_year
        End Get
        Set(ByVal value As Integer)
            m_year = value
        End Set
    End Property

    ''' <summary>
    ''' returns a formatted string containing all the object's data
    ''' </summary>
    ''' <returns>formatted string</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return string.Format("{0,3} {1, 9} {2, 4}", m_day,GetMonth(m_month),m_year)
    End Function

    ''' <summary>
    ''' converts month number into text
    ''' </summary>
    ''' <param name="month">month in numeric form</param>
    ''' <returns>month as string</returns>
    ''' <remarks></remarks>
    Private Function GetMonth(ByVal month As Integer) As String
        Dim monthString = String.Empty
        Select Case (month)
            Case 1
                monthString = "January"
            Case 2
                monthString = "February"
            Case 3
                monthString = "March"
            Case 4
                monthString = "April"
            Case 5
                monthString = "May"
            Case 6
                monthString = "June"
            Case 7
                monthString = "July"
            Case 8
                monthString = "August"
            Case 9
                monthString = "September"
            Case 10
                monthString = "October"
            Case 11
                monthString = "November"
            Case 12
                monthString = "December"
        End Select
        Return monthString
    End Function
End Class
