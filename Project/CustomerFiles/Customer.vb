'Customer.vb
'Created by Evgeniya O'Regan Pevchikh, 27/8/2013
Option Strict On
Option Explicit On

''' <summary>
''' this class inherits from Person class
''' </summary>
''' <remarks></remarks>
Public Class Customer
    Inherits Person
    'customer id
    Private m_id As Integer
    'instance of product class
    Private m_product As Product

    ''' <summary>
    ''' Default constructor - calls another constructor in this class
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.New(String.Empty, String.Empty, New Address(), String.Empty, New Product(), 0)
    End Sub

    ''' <summary>
    ''' Constructor with 6 parameters. This is  constructor that has most
    ''' number of parameters. It is in this constructor that all coding 
    ''' should be done.
    ''' </summary>
    ''' <param name="fname">first name</param>
    ''' <param name="lname">surname</param>
    ''' <param name="addr">address</param>
    ''' <param name="email">email</param>
    ''' <param name="productObj">product data</param>
    ''' <param name="id">customer id</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal fname As String, ByVal lname As String, ByVal addr As Address, ByVal email As String, ByVal productObj As Product, ByVal id As Integer)
        MyBase.New(fname, lname, addr, email)
        m_product = productObj
        m_id = id
    End Sub

    ''' <summary>
    ''' read and write access to m_id
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CustomerId() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property

    ''' <summary>
    ''' read and write access to product data
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ProductData() As Product
        Get
            Return m_product
        End Get
        Set(ByVal value As Product)
            m_product = value
        End Set
    End Property

    ''' <summary>
    ''' returns a formatted string containing all the object's data
    ''' </summary>
    ''' <returns>formatted string</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return String.Format("{0,-4} {1, -40} {2, 30}", m_id, MyBase.ToString(), m_product.ToString())
    End Function
End Class
