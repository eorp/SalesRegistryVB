'Person.vb
'Created by Evgeniya O'Regan Pevchikh, 27/8/2013
Option Strict On
Option Explicit On

Public Class Person
    'first name, surname and email
    Private m_firstName, m_surname, m_email As String
    'instance of address class
    Private m_address As Address

    ''' <summary>
    ''' Default constructor - calls another constructor in this class
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.New(String.Empty, String.Empty, New Address(), String.Empty)
    End Sub
    ''' <summary>
    ''' Constructor with 4 parameters. This is  constructor that has most
    ''' number of parameters. It is in this constructor that all coding 
    ''' should be done.
    ''' </summary>
    ''' <param name="fname"></param>
    ''' <param name="lname"></param>
    ''' <param name="addr"></param>
    ''' <param name="email"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal fname As String, ByVal lname As String, ByVal addr As Address, ByVal email As String)
        m_firstName = fname
        m_surname = lname
        m_address = addr
        m_email = email
    End Sub

    ''' <summary>
    ''' Property related to the field m_firstName
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FirstName() As String
        Get
            Return m_firstName
        End Get

        Set(ByVal value As String)
            m_firstName = value
        End Set
    End Property
    ''' <summary>
    ''' Property related to the field m_lastName
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property LastName() As String
        Get
            Return m_surname
        End Get

        Set(ByVal value As String)
            m_surname = value
        End Set
    End Property
    ''' <summary>
    ''' read-only access to a string containing 
    ''' first and last name
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FullName() As String
        Get
            Return (m_firstName & " " & m_surname).ToUpper()
        End Get
    End Property

    ''' <summary>
    ''' Property related to the field m_address
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AddressData() As Address
        Get
            Return m_address
        End Get

        Set(ByVal value As Address)
            m_address = value
        End Set
    End Property
    ''' <summary>
    ''' Property related to the field m_email
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EmailData() As String
        Get
            Return m_email
        End Get

        Set(ByVal value As String)
            m_email = value
        End Set
    End Property

    ''' <summary>
    ''' returns a formatted string containing all the object's data
    ''' </summary>
    ''' <returns>formatted string</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return String.Format("{0,-20} {1, 1} {2, -30}", FullName, m_address.ToString(), m_email.ToString())
    End Function

End Class
