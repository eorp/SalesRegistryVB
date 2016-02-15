'Product.vb
'Created by Evgeniya O'Regan Pevchikh, 27/8/2013
Option Strict On
Option Explicit On

Public Class Product
    'product name, is product renewed and domain names
    Private m_name, m_renewed, m_domains As String
    'date of payment and expiry date
    Private m_paymentDate, m_expiryDate As DateClass
    'product price
    Private m_price As Double

    ''' <summary>
    ''' Default constructor - calls another constructor in this class
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.New(String.Empty, 0.0, New DateClass(), New DateClass(), String.Empty, String.Empty)
    End Sub

    ''' <summary>
    ''' Constructor with 6 parameters. This is  constructor that has most
    ''' number of parameters. It is in this constructor that all coding 
    ''' should be done.
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="price"></param>
    ''' <param name="payment"></param>
    ''' <param name="expiry"></param>
    ''' <param name="renewed"></param>
    ''' <param name="domains"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal name As String, ByVal price As Double, ByVal payment As DateClass, ByVal expiry As DateClass, ByVal renewed As String, ByVal domains As String)
        m_name = name
        m_price = price
        m_paymentDate = payment
        m_expiryDate = expiry
        m_renewed = renewed
        m_domains = domains
    End Sub

    ''' <summary>
    ''' read and write access to product name
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ProductName() As String
        Get
            Return m_name
        End Get
        Set(ByVal value As String)
            m_name = value
        End Set
    End Property

    ''' <summary>
    ''' read and write access to product price
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ProductPrice() As Double
        Get
            Return m_price
        End Get
        Set(ByVal value As Double)
            m_price = value
        End Set
    End Property

    ''' <summary>
    ''' read and write access to payment date
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PaymentDate() As DateClass
        Get
            Return m_paymentDate
        End Get
        Set(ByVal value As DateClass)
            m_paymentDate = value
        End Set
    End Property

    ''' <summary>
    ''' read and write access to expiry date value
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ExpiryDate() As DateClass
        Get
            Return m_expiryDate
        End Get
        Set(ByVal value As DateClass)
            m_expiryDate = value
        End Set
    End Property
    ''' <summary>
    ''' read and write access to m_renewed value
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ProductRenewed() As String
        Get
            Return m_renewed
        End Get
        Set(ByVal value As String)
            m_renewed = value
        End Set
    End Property
    ''' <summary>
    ''' read and write access to domain names value
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DomainNames() As String
        Get
            Return m_domains
        End Get
        Set(ByVal value As String)
            m_domains = value
        End Set
    End Property

    ''' <summary>
    ''' returns a formatted string containing all the object's data
    ''' </summary>
    ''' <returns>formatted string</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return String.Format("{0, 5} {1, 16} {2,16} {3,3} {4,-20}", m_price, PaymentDate.ToString(), ExpiryDate.ToString(), m_renewed, m_domains)
    End Function
End Class
