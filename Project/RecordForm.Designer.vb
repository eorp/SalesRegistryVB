<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordForm))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbRenewed = New System.Windows.Forms.ComboBox()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.txtDomains = New System.Windows.Forms.TextBox()
        Me.dtExpiry = New System.Windows.Forms.DateTimePicker()
        Me.dtPayment = New System.Windows.Forms.DateTimePicker()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtEmail)
        Me.groupBox1.Controls.Add(Me.txtSurname)
        Me.groupBox1.Controls.Add(Me.txtFirstName)
        Me.groupBox1.Controls.Add(Me.groupBox2)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(13, 13)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(447, 348)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Customer Details"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(123, 96)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(287, 26)
        Me.txtEmail.TabIndex = 6
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(123, 63)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(287, 26)
        Me.txtSurname.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(123, 31)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(287, 26)
        Me.txtFirstName.TabIndex = 4
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cmbCountry)
        Me.groupBox2.Controls.Add(Me.txtZip)
        Me.groupBox2.Controls.Add(Me.txtState)
        Me.groupBox2.Controls.Add(Me.txtCity)
        Me.groupBox2.Controls.Add(Me.txtStreet)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Location = New System.Drawing.Point(13, 131)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(420, 202)
        Me.groupBox2.TabIndex = 3
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Address"
        '
        'cmbCountry
        '
        Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Location = New System.Drawing.Point(110, 162)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(287, 27)
        Me.cmbCountry.TabIndex = 11
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(110, 129)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(287, 26)
        Me.txtZip.TabIndex = 10
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(110, 97)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(287, 26)
        Me.txtState.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(110, 65)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(287, 26)
        Me.txtCity.TabIndex = 8
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(110, 32)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(287, 26)
        Me.txtStreet.TabIndex = 7
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(17, 165)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(69, 19)
        Me.label8.TabIndex = 6
        Me.label8.Text = "Country:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(17, 133)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(35, 19)
        Me.label7.TabIndex = 5
        Me.label7.Text = "Zip:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(17, 102)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(47, 19)
        Me.label6.TabIndex = 4
        Me.label6.Text = "State:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(17, 69)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(39, 19)
        Me.label5.TabIndex = 3
        Me.label5.Text = "City:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(17, 37)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(54, 19)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Street:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(17, 101)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(51, 19)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Email:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(17, 68)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(75, 19)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Surname:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(17, 33)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(89, 19)
        Me.label1.TabIndex = 0
        Me.label1.Text = "First Name:"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.cmbRenewed)
        Me.groupBox3.Controls.Add(Me.cmbProductName)
        Me.groupBox3.Controls.Add(Me.txtDomains)
        Me.groupBox3.Controls.Add(Me.dtExpiry)
        Me.groupBox3.Controls.Add(Me.dtPayment)
        Me.groupBox3.Controls.Add(Me.txtPrice)
        Me.groupBox3.Controls.Add(Me.label14)
        Me.groupBox3.Controls.Add(Me.label13)
        Me.groupBox3.Controls.Add(Me.label12)
        Me.groupBox3.Controls.Add(Me.label11)
        Me.groupBox3.Controls.Add(Me.label10)
        Me.groupBox3.Controls.Add(Me.label9)
        Me.groupBox3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(469, 13)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(447, 348)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Product Details"
        '
        'cmbRenewed
        '
        Me.cmbRenewed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRenewed.FormattingEnabled = True
        Me.cmbRenewed.Location = New System.Drawing.Point(133, 177)
        Me.cmbRenewed.Name = "cmbRenewed"
        Me.cmbRenewed.Size = New System.Drawing.Size(287, 27)
        Me.cmbRenewed.TabIndex = 15
        '
        'cmbProductName
        '
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(133, 30)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(287, 27)
        Me.cmbProductName.TabIndex = 14
        '
        'txtDomains
        '
        Me.txtDomains.Location = New System.Drawing.Point(133, 215)
        Me.txtDomains.Multiline = True
        Me.txtDomains.Name = "txtDomains"
        Me.txtDomains.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDomains.Size = New System.Drawing.Size(287, 105)
        Me.txtDomains.TabIndex = 13
        '
        'dtExpiry
        '
        Me.dtExpiry.Location = New System.Drawing.Point(133, 137)
        Me.dtExpiry.Name = "dtExpiry"
        Me.dtExpiry.Size = New System.Drawing.Size(287, 26)
        Me.dtExpiry.TabIndex = 12
        '
        'dtPayment
        '
        Me.dtPayment.Location = New System.Drawing.Point(133, 103)
        Me.dtPayment.Name = "dtPayment"
        Me.dtPayment.Size = New System.Drawing.Size(287, 26)
        Me.dtPayment.TabIndex = 11
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(133, 66)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(287, 26)
        Me.txtPrice.TabIndex = 9
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(17, 178)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(77, 19)
        Me.label14.TabIndex = 7
        Me.label14.Text = "Renewed:"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(17, 215)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(74, 19)
        Me.label13.TabIndex = 6
        Me.label13.Text = "Domains:"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(17, 142)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(94, 19)
        Me.label12.TabIndex = 5
        Me.label12.Text = "Expiry Date:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(17, 108)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(109, 19)
        Me.label11.TabIndex = 4
        Me.label11.Text = "Payment Date:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(17, 70)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(48, 19)
        Me.label10.TabIndex = 3
        Me.label10.Text = "Price:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(17, 33)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(53, 19)
        Me.label9.TabIndex = 2
        Me.label9.Text = "Name:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Location = New System.Drawing.Point(306, 372)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 64)
        Me.Panel1.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Project.My.Resources.Resources.Closeicon
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(180, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 48)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAdd.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.Project.My.Resources.Resources.a_ok
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(21, 9)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 48)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "OK"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'RecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 443)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RecordForm"
        Me.Text = "Sale Details"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtSurname As System.Windows.Forms.TextBox
    Private WithEvents txtFirstName As System.Windows.Forms.TextBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cmbCountry As System.Windows.Forms.ComboBox
    Private WithEvents txtZip As System.Windows.Forms.TextBox
    Private WithEvents txtState As System.Windows.Forms.TextBox
    Private WithEvents txtCity As System.Windows.Forms.TextBox
    Private WithEvents txtStreet As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents cmbRenewed As System.Windows.Forms.ComboBox
    Private WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Private WithEvents txtDomains As System.Windows.Forms.TextBox
    Private WithEvents dtExpiry As System.Windows.Forms.DateTimePicker
    Private WithEvents dtPayment As System.Windows.Forms.DateTimePicker
    Private WithEvents txtPrice As System.Windows.Forms.TextBox
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
End Class
