'CustomerManager.vb
'Created by Evgeniya O'Regan Pevchikh, 27/8/2013
Option Strict On
Option Explicit On
Imports System.Xml.Serialization
Imports System.Xml.Linq
Imports System.IO
Imports System.Collections.Generic
Imports System.Linq

Public Class CustomerManager
    'list of Customer objects
    Private m_customers As List(Of Customer)
    'copy of records to stored sorted records by year
    Private copySortedByYear As List(Of Customer)
    'copy of records to stored sorted records by month,year
    Private copySortedByTime As List(Of Customer)
    'total value of sales
    Private totalSales As Double = 0.0
    'total number of customers
    Private totalCustomers As Integer = 0
    'path to the file where data is saved/read from
    Private filePath As String = "data.xml"

    Public Sub New()
        'create a new list
        m_customers = New List(Of Customer)()
        'read previously saved data from xml file
        ReadFromFile()
        'calculate total number of customers and total sales from data read
        GetTotals(m_customers)
    End Sub

    ''' <summary>
    ''' add a new record to customer list
    ''' </summary>
    ''' <param name="cust">customer object</param>
    ''' <remarks></remarks>
    Public Sub AddCustomer(ByVal cust As Customer)
        'if customer object is not empty
        If cust IsNot Nothing Then
            'add a new record to the list
            m_customers.Add(cust)
        End If
    End Sub

    ''' <summary>
    ''' delete a selected record from customer list
    ''' </summary>
    ''' <param name="index">selected index of the list</param>
    ''' <remarks></remarks>
    Public Sub DeleteCustomer(ByVal index As Integer)
        'if a record is selected 
        If CheckIndex(index) Then
            'delete the record from the list
            m_customers.RemoveAt(index)
        End If
    End Sub
    ''' <summary>
    ''' check the range of index value,
    ''' valid index range is from zero to total number of customers less than one
    ''' </summary>
    ''' <param name="index">selected index in the list box</param>
    ''' <returns>true if index is within range, false otherwise</returns>
    ''' <remarks></remarks>
    Public Function CheckIndex(ByVal index As Integer) As Boolean
        'ensure the seat is selected (focus is on)
        If index >= 0 And index < m_customers.Count Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' retreive a record from customer list defined by a selected index
    ''' </summary>
    ''' <param name="index">selected index</param>
    ''' <returns>a record from customer list or nothing if no record was selected</returns>
    ''' <remarks></remarks>
    Public Function GetCustomer(ByVal index As Integer) As Customer
        If CheckIndex(index) Then
            Return m_customers(index)
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' edit selected record from the list
    ''' </summary>
    ''' <param name="customerIn">customer object with updated data</param>
    ''' <param name="index">selected index</param>
    ''' <param name="id">customer id</param>
    ''' <remarks></remarks>
    Public Sub EditCustomer(ByVal customerIn As Customer, ByVal index As Integer, ByVal id As Integer)
        'if a record was selected
        If CheckIndex(index) Then
            'assign updated info to a specified record from customer list
            m_customers(index) = customerIn
            m_customers(index).CustomerId = id + 100
        End If
    End Sub

    ''' <summary>
    ''' get all records from customer list in array of strings
    ''' </summary>
    ''' <returns>array of strings or nothing if there is no records</returns>
    ''' <remarks></remarks>
    Public Function GetCustomerInfo() As String()
        'if there are no records - return  nothing
        If m_customers.Count < 0 Then
            Return Nothing
        End If
        'create a new array of strings
        Dim customerStr As String() = New String(m_customers.Count - 1) {}
        Dim i As Integer = 0
        'go through each record in the customer list and add each record as a string to array of strings
        For Each contactObj As Customer In m_customers
            customerStr(i) = contactObj.ToString()
            i += 1
        Next
        Return customerStr
    End Function

    ''' <summary>
    ''' read-only access to the number of records in the customer list
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Count() As Integer
        Get
            Return m_customers.Count
        End Get

    End Property

    ''' <summary>
    ''' read-only access to an id for each customer
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property GetNewId() As Integer
        Get

            Return m_customers.Count + 100
        End Get
    End Property

    ''' <summary>
    ''' save data to xml file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SaveToFile()
        Dim serialiser = New XmlSerializer(GetType(List(Of Customer)))
        Dim writer = New StreamWriter(filePath)

        serialiser.Serialize(writer, m_customers)
        writer.Close()
    End Sub

    ''' <summary>
    ''' read data from xml file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ReadFromFile()
        Dim deserialiser = New XmlSerializer(GetType(List(Of Customer)))
        Dim reader = New StreamReader(filePath)
        m_customers = CType(deserialiser.Deserialize(reader), Global.System.Collections.Generic.List(Of Global.Project.Customer))
        reader.Close()
    End Sub

    ''' <summary>
    ''' generic method for sorting records by provided value
    ''' </summary>
    ''' <param name="sort">value to be sorted by</param>
    ''' <param name="byTime">1-sorted by mm/yy, 2- sorted by yy </param>
    ''' <returns>sorted array of strings</returns>
    ''' <remarks></remarks>
    Public Function SortedBy(ByVal sort As String, ByVal byTime As Integer) As String()
        'create a copy of the list
        Dim copySorted As New List(Of Customer)(m_customers)
        'if list is shown for specific mm/yy
        If byTime = 1 Then
            copySorted = copySortedByTime   'make appropriate copy
            'list for selected year
        ElseIf byTime = 2 Then
            copySorted = copySortedByYear
        End If

        'sort records by value selected
        Select Case sort
            Case "price"
                copySorted = copySorted.OrderBy(Function(customers) customers.ProductData.ProductPrice).ToList()
                Exit Select
            Case "country"
                copySorted = copySorted.OrderBy(Function(customers) customers.AddressData.Country).ToList()
                Exit Select
            Case "name"
                copySorted = copySorted.OrderBy(Function(c) c.FullName).ToList()
                Exit Select
            Case "email"
                copySorted = copySorted.OrderBy(Function(customers) customers.EmailData).ToList()
                Exit Select
            Case "date"
                copySorted = copySorted.OrderBy(Function(c) c.ProductData.PaymentDate.Year).ThenBy(Function(c) c.ProductData.PaymentDate.Month).ThenBy(Function(c) c.ProductData.PaymentDate.Day).ToList()
                Exit Select

        End Select
        'calculate totals for sorted list
        GetTotals(copySorted)

        Return GetSortedCustomerInfo(copySorted, 0)

    End Function

    ''' <summary>
    ''' get a list of records for selected month
    ''' both for displying the records(print=0) and for printing
    ''' those records(print=1)
    ''' </summary>
    ''' <param name="month">month</param>
    ''' <param name="year">year</param>
    ''' <param name="print">1-print, 0- display</param>
    ''' <returns>array of corresponding records</returns>
    ''' <remarks></remarks>
    Public Function ShowSelectedSales(ByVal month As Integer, ByVal year As Integer, ByVal print As Integer) As String()
        'create a copy of the list to keep list of records sorted by month/year
        copySortedByTime = New List(Of Customer)(m_customers)

        'find all records for selected month
        copySortedByTime = copySortedByTime.FindAll(Function(c) c.ProductData.PaymentDate.Month.Equals(month) AndAlso c.ProductData.PaymentDate.Year.Equals(year))
        'calculate totals for the sorted list
        GetTotals(copySortedByTime)

        Return GetSortedCustomerInfo(copySortedByTime, print)
    End Function

    ''' <summary>
    ''' get records for selected year both for displaying(print=0)
    ''' and for printing(print=1)
    ''' </summary>
    ''' <param name="year">selected year</param>
    ''' <param name="print">1-print, 0-display</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ShowSelectedSalesYear(ByVal year As Integer, ByVal print As Integer) As String()
        'create a copy of the list to keep list of records sorted by month/year
        copySortedByYear = New List(Of Customer)(m_customers)

        'find records for the year selected
        copySortedByYear = copySortedByYear.FindAll(Function(c) c.ProductData.PaymentDate.Year.Equals(year))
        'calculate the totals for the new list of records
        GetTotals(copySortedByYear)

        Return GetSortedCustomerInfo(copySortedByYear, print)

    End Function

    ''' <summary>
    ''' get sorted records from customer list in array of strings
    ''' </summary>
    ''' <param name="sorted">list of records</param>
    ''' <param name="print"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetSortedCustomerInfo(ByVal sorted As List(Of Customer), ByVal print As Integer) As String()
        'create a new array of strings
        Dim customerSrt() As String = New String(sorted.Count - 1) {}
        Dim i As Integer = 0
        'go through each record in the customer list and add each record as a string to array of strings
        For Each obj As Customer In sorted
            'for displayng
            If print = 0 Then
                customerSrt(i) = obj.ToString()
                i += 1
                'for printing
            Else
                customerSrt(i) = obj.ProductData.PaymentDate.ToString() & vbTab & vbTab & obj.ProductData.ProductPrice
                i += 1
            End If
        Next
        Return customerSrt
    End Function

    ''' <summary>
    ''' get total number of customer and total sales figure
    ''' </summary>
    ''' <param name="copy">list of records</param>
    ''' <remarks></remarks>
    Private Sub GetTotals(ByVal copy As List(Of Customer))
        Dim price As Double = 0.0
        'get total sales value
        For i As Integer = 0 To copy.Count - 1
            price += copy(i).ProductData.ProductPrice
        Next

        totalSales = price
        'total number of customers
        totalCustomers = copy.Count
    End Sub

    ''' <summary>
    ''' get totals for original unsorted list of records
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GetTotalsOriginal()
        GetTotals(m_customers)
    End Sub

    ''' <summary>
    ''' read access to total sales value
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalSalesData() As Double
        Get
            Return totalSales
        End Get
    End Property

    ''' <summary>
    ''' read only access to total no of customers
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalCustomersData() As Integer
        Get
            Return totalCustomers
        End Get
    End Property

    ''' <summary>
    ''' generate text for invoice for a selected record
    ''' </summary>
    ''' <param name="ind">index of selected record</param>
    ''' <returns>invoice text</returns>
    ''' <remarks></remarks>
    Public Function GetInvoice(ByVal ind As Integer) As String
        Dim text As String = ""
        text = vbLf & vbLf & vbLf & "Company Name" & vbLf & vbLf & "Company Contact Details" & vbLf & vbLf & "______________________________" & vbLf & "Invoice Number: " & (ind + 17253)
        text += (vbLf & vbLf & "To:          " & m_customers(ind).FullName & vbLf & vbLf & "Fees:    ") + m_customers(ind).ProductData.ProductName
        text += vbLf & vbLf & "                                    " & m_customers(ind).ProductData.ProductPrice
        text += vbLf & vbLf & "                  TOTAL:  " & m_customers(ind).ProductData.ProductPrice
        Return text
    End Function


End Class
