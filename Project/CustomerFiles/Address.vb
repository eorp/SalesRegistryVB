'Address.vb
'Created by Evgeniya O'Regan Pevchikh, 10/8/2013
Option Strict On
Option Explicit On
Public Class Address
    'city
    Private m_city As String
    'country
    Private m_country As Countries
    'street
    Private m_street As String
    'zip code
    Private m_zipCode As String
    'the string will contain an error message for missing fields
    Private m_strErrMsg As String
    'state
    Private m_state As String

    'Constructors are overloaded and called in a chain

    ''' <summary>
    ''' Default constructor - calls another constructor in this class
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.New("Cork", "Main Street", String.Empty)
    End Sub


    ''' <summary>
    ''' Constructor with three parameters - calls the constructor with 
    ''' four parameters, using a default value as the last argument.
    ''' </summary>
    ''' <param name="city"></param>
    ''' <param name="street"></param>
    ''' <param name="state"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal city As String, ByVal street As String, ByVal state As String)
        Me.New(city, street, state, String.Empty)
    End Sub

    ''' <summary>
    ''' Constructor with 4 parameters - calls the constructor with 
    ''' four parameters, using a default value as the last argument.
    ''' </summary>
    ''' <param name="city"></param>
    ''' <param name="street"></param>
    ''' <param name="state"></param>
    ''' <param name="zip"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal city As String, ByVal street As String, ByVal state As String, ByVal zip As String)
        Me.New(city, street, state, zip, Countries.Ireland)
    End Sub
    ''' <summary>
    ''' Constructor with 5 parameters. This is  constructor that has most
    ''' number of parameters. It is in tis constructor that all coding 
    ''' should be done.
    ''' </summary>
    ''' <param name="street"></param>
    ''' <param name="city"></param>
    ''' <param name="zip"></param>
    ''' <param name="country"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal city As String, ByVal street As String, ByVal state As String, ByVal zip As String, ByVal country As Countries)
        m_street = street
        m_city = city
        m_zipCode = zip
        m_country = country
        m_state = state
    End Sub
    ''' <summary>
    ''' Copy constructor: Use this when you are copying
    ''' from one object to another object of this class
    ''' </summary>
    ''' <param name="theOther"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal theOther As Address)
        m_street = theOther.m_street
        m_zipCode = theOther.m_zipCode
        m_city = theOther.m_city
    End Sub
    'properties for all variables in the class

    ''' <summary>
    ''' Property related to the field m_street
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Street() As String
        Get
            Return m_street
        End Get

        Set(ByVal value As String)
            m_street = value
        End Set
    End Property
    ''' <summary>
    ''' Property related to the field m_state
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property State() As String
        Get
            Return m_state
        End Get

        Set(ByVal value As String)
            m_state = value
        End Set
    End Property

    ''' <summary>
    ''' Property related to the field m_city
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property City() As String
        Get
            Return m_city
        End Get

        Set(ByVal value As String)
            m_city = value
        End Set
    End Property
    ''' <summary>
    ''' Property related to the field m_country
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Country() As Countries
        Get
            Return m_country
        End Get

        Set(ByVal value As Countries)
            m_country = value
        End Set
    End Property
    ''' <summary>
    ''' Property related to the field m_zipCode
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ZipCode() As String
        Get
            Return m_zipCode
        End Get

        Set(ByVal value As String)
            m_zipCode = value
        End Set
    End Property
    ''' <summary>
    ''' Property related to the field m_strErrMsg
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ErrorMessage() As String
        Get
            Return m_strErrMsg
        End Get

        Set(ByVal value As String)
            m_strErrMsg = value
        End Set
    End Property

    ''' <summary>
    ''' Delivers a formatted string with data stored in the object. The values will
    ''' appear as columns.  
    ''' </summary>
    ''' <returns>formatted string</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Dim strOut As String = String.Format("{0,-14}", GetCountryString())
        'strOut = strOut.ToUpper()
        Return strOut.ToUpper()
    End Function

    ''' <summary>
    ''' replace underscores in country's name by spaces
    ''' </summary>
    ''' <returns>the country name without underscores</returns>
    ''' <remarks></remarks>
    Public Function GetCountryString() As String
        Dim countryStr = m_country.ToString()
        'countryStr = countryStr.Replace("_", " ")
        Return countryStr.Replace("_", " ")
    End Function

    ''' <summary>
    ''' checks that required address fields (street and city)
    ''' are entered
    ''' </summary>
    ''' <returns>true if required fields are provided and false+error message otherwise</returns>
    ''' <remarks></remarks>
    Public Function CheckData() As Boolean
        If ((Not String.IsNullOrEmpty(m_city)) And (Not String.IsNullOrEmpty(m_street))) Then
            Return True
        Else
            m_strErrMsg = "Street and city are required fields"
        End If
        Return False
    End Function
End Class
