'RecordForm.vb
'Created by Evgeniya O'Regan Pevchikh, 27/8/2013
Option Strict On
Option Explicit On


Public Class RecordForm
    'instance of customer class
    Private cust As New Customer()
    'variable to handle closing the form
    Private m_closeForm As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitialiseGUI()

    End Sub
    ''' <summary>
    ''' initialise components with data
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitialiseGUI()
        txtFirstName.Focus()
        'fill in countries list
        FillCountryComboBox()
        'fill in product names list
        FillProductNameComboBox()
        'set initial product price
        txtPrice.Text = "2.99"
        'disable editing of price field (will be assigned automatically depending on chosen product)
        txtPrice.Enabled = False
        'fill in renewed combobox with data
        FillRenewedComboBox()
        'set expiry date to be a year ahead of payment date
        SetExpiry()

        m_closeForm = True
    End Sub

    ''' <summary>
    ''' replacing underscores in countries' names with a blank space
    ''' and adding countries list to the combobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FillCountryComboBox()
        Dim countryString() As String = [Enum].GetNames(GetType(Countries))

        For i As Integer = 0 To countryString.Length - 1
            countryString(i) = countryString(i).Replace("_", " ")
        Next

        cmbCountry.Items.Clear()
        cmbCountry.Items.AddRange(countryString)
        'default country selected in the combobox
        cmbCountry.SelectedIndex = Countries.Ireland

    End Sub

    ''' <summary>
    ''' replacing underscores in product names with a blank space
    ''' and adding countries list to the combobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FillProductNameComboBox()
        Dim productString() As String = [Enum].GetNames(GetType(ProductNames))

        For i As Integer = 0 To productString.Length - 1
            productString(i) = productString(i).Replace("_", " ")
        Next

        cmbProductName.Items.Clear()
        cmbProductName.Items.AddRange(productString)
        'default product name selected in the combobox
        cmbProductName.SelectedIndex = ProductNames._only_one_domain

    End Sub
    ''' <summary>
    ''' data to fill renewed combobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FillRenewedComboBox()
        cmbRenewed.Items.Clear()

        cmbRenewed.Items.Add("yes")
        cmbRenewed.Items.Add("no")
        'set selected value to "no"
        cmbRenewed.SelectedIndex = 1
    End Sub
    ''' <summary>
    ''' set expiry date to be one year ahead from payment date
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetExpiry()
        'get payment date value
        Dim payment As DateTime = dtPayment.Value
        'add one year to it
        payment = payment.AddYears(1)
        'assign this date to expiry date
        dtExpiry.Value = payment
    End Sub

    ''' <summary>
    ''' read and write access to customer data
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CustomerData() As Customer
        Get
            Return cust
        End Get
        Set(ByVal value As Customer)
            If cust IsNot Nothing Then
                cust = value
                UpdateGUI()
            End If
        End Set
    End Property

    ''' <summary>
    ''' assign values from selected record to the form's fields for editing
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateGUI()
        txtFirstName.Text = cust.FirstName
        txtSurname.Text = cust.LastName

        txtEmail.Text = cust.EmailData

        txtCity.Text = cust.AddressData.City
        txtStreet.Text = cust.AddressData.Street
        txtZip.Text = cust.AddressData.ZipCode
        cmbCountry.SelectedIndex = cust.AddressData.Country

        cmbProductName.SelectedItem = cust.ProductData.ProductName
        txtPrice.Text = cust.ProductData.ProductPrice.ToString()

        dtPayment.Value = New DateTime(cust.ProductData.PaymentDate.Year, cust.ProductData.PaymentDate.Month, cust.ProductData.PaymentDate.Day)
        dtExpiry.Value = New DateTime(cust.ProductData.ExpiryDate.Year, cust.ProductData.ExpiryDate.Month, cust.ProductData.ExpiryDate.Day)

        cmbRenewed.SelectedValue = cust.ProductData.ProductRenewed
        txtDomains.Text = cust.ProductData.DomainNames

    End Sub

    ''' <summary>
    ''' instatiates address class with data provided
    ''' </summary>
    ''' <returns>address object</returns>
    ''' <remarks></remarks>
    Private Function ReadAddress() As Address
        Dim addr As Address = New Address(txtCity.Text, txtStreet.Text, txtState.Text, txtZip.Text, CType(cmbCountry.SelectedIndex, Countries))
        Return addr
    End Function

    ''' <summary>
    ''' create person object with data provided
    ''' </summary>
    ''' <returns>person object</returns>
    ''' <remarks></remarks>
    Private Function ReadPerson() As Person
        Return New Person(txtFirstName.Text, txtSurname.Text, ReadAddress(), txtEmail.Text)
    End Function
    ''' <summary>
    ''' create dateclass object with data provided
    ''' </summary>
    ''' <param name="day"></param>
    ''' <param name="month"></param>
    ''' <param name="year"></param>
    ''' <returns>dateclass object</returns>
    ''' <remarks></remarks>
    Private Function ReadDate(ByVal day As Integer, ByVal month As Integer, ByVal year As Integer) As DateClass
        Return New DateClass(day, month, year)
    End Function
    ''' <summary>
    ''' create product object with data provided
    ''' </summary>
    ''' <returns>product object</returns>
    ''' <remarks></remarks>
    Private Function ReadProduct() As Product
        Return New Product(cmbProductName.SelectedItem.ToString(), Double.Parse(txtPrice.Text), ReadDate(dtPayment.Value.Day, dtPayment.Value.Month, dtPayment.Value.Year), ReadDate(dtExpiry.Value.Day, dtExpiry.Value.Month, dtExpiry.Value.Year), cmbRenewed.SelectedItem.ToString(), txtDomains.Text)
    End Function

    ''' <summary>
    ''' check if all required fields are filled
    ''' </summary>
    ''' <returns>true or false depending on the result</returns>
    ''' <remarks></remarks>
    Private Function ReadInput() As Boolean
        Dim productIn As Product = ReadProduct()
        Dim addr As Address = ReadAddress()
        'create new customer object with data provided
        cust = New Customer(txtFirstName.Text, txtSurname.Text, addr, txtEmail.Text, productIn, 1)
        Return ReadAndValidateName() And ReadAndValidateEmail()
    End Function

    ''' <summary>
    ''' make sure that full name is entered
    ''' </summary>
    ''' <returns>true if the name is filled in, false otherwise</returns>
    ''' <remarks></remarks>
    Private Function ReadAndValidateName() As Boolean
        Dim fName As String = txtFirstName.Text
        Dim lName As String = txtSurname.Text
        'if first name is not entered - show warning
        If InputUtility.IsInvalidString(fName) Then
            MessageBox.Show("Invalid input in the first name field! Please enter a valid name (at least one character is required)", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'put focus on requred field
            txtFirstName.Focus()
            txtFirstName.Text = " "
            txtFirstName.SelectAll()
            'if last name is not entered - show warning
        ElseIf InputUtility.IsInvalidString(lName) Then
            MessageBox.Show("Invalid input in the last name field! Please enter a valid name (at least one character is required)", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'put focus on requred field
            txtSurname.Focus()
            txtSurname.Text = " "
            txtSurname.SelectAll()
        Else
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' ensure that a proper email address is entered
    ''' </summary>
    ''' <returns>true or false depending on the result</returns>
    ''' <remarks></remarks>
    Private Function ReadAndValidateEmail() As Boolean
        Dim email As String = txtEmail.Text
        'if email is not valid -show warning
        If Not InputUtility.IsValidEmail(email) Then
            MessageBox.Show("Invalid email address!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'put focus on requred field
            txtEmail.Focus()
            txtEmail.Text = " "
            txtEmail.SelectAll()
        Else
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' handles form closing event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RecordForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If m_closeForm Then
            e.Cancel = False        'close the form
        Else
            e.Cancel = True         'leave the form open
        End If
    End Sub

    ''' <summary>
    ''' handle cancelling adding and editing the record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If (MessageBox.Show("Are you sure you want to cancel this action?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            m_closeForm = True
            Me.Close()
        Else
            m_closeForm = False
        End If

    End Sub

    ''' <summary>
    ''' handle adding new record or editing existing one
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'if all required fields are filled in - save info
        'otherwise leave the form open
        If Not ReadInput() Then
            m_closeForm = False
        Else
            m_closeForm = True
            'MessageBox.Show(cust.ToString(), "message", MessageBoxButtons.OK)
        End If
    End Sub

    ''' <summary>
    ''' change expiry date when payment date is changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtPayment_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtPayment.ValueChanged
        SetExpiry()
    End Sub

    ''' <summary>
    ''' set product price according to product chosen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged
        Select Case (cmbProductName.SelectedIndex)
            Case 0
                txtPrice.Text = "2.99"
            Case 1
                txtPrice.Text = "9.99"
            Case 2
                txtPrice.Text = "15.99"
            Case 3
                txtPrice.Text = "24.99"
        End Select
    End Sub
End Class