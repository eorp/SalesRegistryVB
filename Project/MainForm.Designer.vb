<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.invoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectedMonthlySalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectedYearlySalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.invoiceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectedMonthlySalesReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectedYearlySalesReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.customizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.countryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.emalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fullNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.paymentDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.priceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.restoreRecordsToOriginalStateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtSalesYear = New System.Windows.Forms.DateTimePicker()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dtSalesRange = New System.Windows.Forms.DateTimePicker()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPreviewYearlyReport = New System.Windows.Forms.Button()
        Me.btnPrintYearlyReport = New System.Windows.Forms.Button()
        Me.btnPreviewReport = New System.Windows.Forms.Button()
        Me.btnPrintReport = New System.Windows.Forms.Button()
        Me.btnPreviewInvoice = New System.Windows.Forms.Button()
        Me.btnPrintInvoice = New System.Windows.Forms.Button()
        Me.toolTipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnReset2 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSortPaymentDate = New System.Windows.Forms.Button()
        Me.btnSortEmail = New System.Windows.Forms.Button()
        Me.btnSortPrice = New System.Windows.Forms.Button()
        Me.btnSortCountry = New System.Windows.Forms.Button()
        Me.btnSortFullName = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.printDialogReport = New System.Windows.Forms.PrintDialog()
        Me.printDialogReportYear = New System.Windows.Forms.PrintDialog()
        Me.printPreviewDialogReportYear = New System.Windows.Forms.PrintPreviewDialog()
        Me.printDocumentReportYear = New System.Drawing.Printing.PrintDocument()
        Me.lstRecords = New System.Windows.Forms.ListBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lbTotalCustomers = New System.Windows.Forms.Label()
        Me.lbTotalSales = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.printDocumentReport = New System.Drawing.Printing.PrintDocument()
        Me.printDialog1 = New System.Windows.Forms.PrintDialog()
        Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.printPreviewDialogReport = New System.Windows.Forms.PrintPreviewDialog()
        Me.menuStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.toolsToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(1028, 27)
        Me.menuStrip1.TabIndex = 21
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.printToolStripMenuItem, Me.printPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(46, 23)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'printToolStripMenuItem
        '
        Me.printToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.invoiceToolStripMenuItem, Me.selectedMonthlySalesReportToolStripMenuItem, Me.selectedYearlySalesReportToolStripMenuItem})
        Me.printToolStripMenuItem.Image = CType(resources.GetObject("printToolStripMenuItem.Image"), System.Drawing.Image)
        Me.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
        Me.printToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.printToolStripMenuItem.ShowShortcutKeys = False
        Me.printToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.printToolStripMenuItem.Text = "&Print"
        '
        'invoiceToolStripMenuItem
        '
        Me.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem"
        Me.invoiceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.invoiceToolStripMenuItem.Size = New System.Drawing.Size(347, 24)
        Me.invoiceToolStripMenuItem.Text = "Invoice"
        '
        'selectedMonthlySalesReportToolStripMenuItem
        '
        Me.selectedMonthlySalesReportToolStripMenuItem.Name = "selectedMonthlySalesReportToolStripMenuItem"
        Me.selectedMonthlySalesReportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.selectedMonthlySalesReportToolStripMenuItem.Size = New System.Drawing.Size(347, 24)
        Me.selectedMonthlySalesReportToolStripMenuItem.Text = "Selected Monthly Sales Report"
        '
        'selectedYearlySalesReportToolStripMenuItem
        '
        Me.selectedYearlySalesReportToolStripMenuItem.Name = "selectedYearlySalesReportToolStripMenuItem"
        Me.selectedYearlySalesReportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.selectedYearlySalesReportToolStripMenuItem.Size = New System.Drawing.Size(347, 24)
        Me.selectedYearlySalesReportToolStripMenuItem.Text = "Selected Yearly Sales Report"
        '
        'printPreviewToolStripMenuItem
        '
        Me.printPreviewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.invoiceToolStripMenuItem1, Me.selectedMonthlySalesReportToolStripMenuItem1, Me.selectedYearlySalesReportToolStripMenuItem1})
        Me.printPreviewToolStripMenuItem.Image = CType(resources.GetObject("printPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
        Me.printPreviewToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.printPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'invoiceToolStripMenuItem1
        '
        Me.invoiceToolStripMenuItem1.Name = "invoiceToolStripMenuItem1"
        Me.invoiceToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.invoiceToolStripMenuItem1.Size = New System.Drawing.Size(387, 24)
        Me.invoiceToolStripMenuItem1.Text = "Invoice"
        '
        'selectedMonthlySalesReportToolStripMenuItem1
        '
        Me.selectedMonthlySalesReportToolStripMenuItem1.Name = "selectedMonthlySalesReportToolStripMenuItem1"
        Me.selectedMonthlySalesReportToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.selectedMonthlySalesReportToolStripMenuItem1.Size = New System.Drawing.Size(387, 24)
        Me.selectedMonthlySalesReportToolStripMenuItem1.Text = "Selected Monthly Sales Report"
        '
        'selectedYearlySalesReportToolStripMenuItem1
        '
        Me.selectedYearlySalesReportToolStripMenuItem1.Name = "selectedYearlySalesReportToolStripMenuItem1"
        Me.selectedYearlySalesReportToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.selectedYearlySalesReportToolStripMenuItem1.Size = New System.Drawing.Size(387, 24)
        Me.selectedYearlySalesReportToolStripMenuItem1.Text = "Selected Yearly Sales Report"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(173, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'toolsToolStripMenuItem
        '
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.customizeToolStripMenuItem, Me.restoreRecordsToOriginalStateToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.toolsToolStripMenuItem.Text = "&Tools"
        '
        'customizeToolStripMenuItem
        '
        Me.customizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.countryToolStripMenuItem, Me.emalToolStripMenuItem, Me.fullNameToolStripMenuItem, Me.paymentDateToolStripMenuItem, Me.priceToolStripMenuItem})
        Me.customizeToolStripMenuItem.Image = Global.Project.My.Resources.Resources.a_sort2
        Me.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem"
        Me.customizeToolStripMenuItem.Size = New System.Drawing.Size(364, 24)
        Me.customizeToolStripMenuItem.Text = "&Sort By"
        '
        'countryToolStripMenuItem
        '
        Me.countryToolStripMenuItem.Name = "countryToolStripMenuItem"
        Me.countryToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.countryToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.countryToolStripMenuItem.Text = "Country"
        '
        'emalToolStripMenuItem
        '
        Me.emalToolStripMenuItem.Name = "emalToolStripMenuItem"
        Me.emalToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.emalToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.emalToolStripMenuItem.Text = "&Emal"
        '
        'fullNameToolStripMenuItem
        '
        Me.fullNameToolStripMenuItem.Name = "fullNameToolStripMenuItem"
        Me.fullNameToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.fullNameToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.fullNameToolStripMenuItem.Text = "Full &Name"
        '
        'paymentDateToolStripMenuItem
        '
        Me.paymentDateToolStripMenuItem.Name = "paymentDateToolStripMenuItem"
        Me.paymentDateToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.paymentDateToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.paymentDateToolStripMenuItem.Text = "Payment Date"
        '
        'priceToolStripMenuItem
        '
        Me.priceToolStripMenuItem.Name = "priceToolStripMenuItem"
        Me.priceToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.priceToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.priceToolStripMenuItem.Text = "Price"
        '
        'restoreRecordsToOriginalStateToolStripMenuItem
        '
        Me.restoreRecordsToOriginalStateToolStripMenuItem.Image = Global.Project.My.Resources.Resources.a_refresh2
        Me.restoreRecordsToOriginalStateToolStripMenuItem.Name = "restoreRecordsToOriginalStateToolStripMenuItem"
        Me.restoreRecordsToOriginalStateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.restoreRecordsToOriginalStateToolStripMenuItem.Size = New System.Drawing.Size(364, 24)
        Me.restoreRecordsToOriginalStateToolStripMenuItem.Text = "Restore Records to Original State"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(63, 23)
        Me.helpToolStripMenuItem.Text = "&About"
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.aboutToolStripMenuItem.Text = "&About..."
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.dtSalesYear)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.dtSalesRange)
        Me.groupBox1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 31)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(363, 145)
        Me.groupBox1.TabIndex = 22
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Display Options"
        '
        'dtSalesYear
        '
        Me.dtSalesYear.Location = New System.Drawing.Point(207, 92)
        Me.dtSalesYear.Name = "dtSalesYear"
        Me.dtSalesYear.ShowUpDown = True
        Me.dtSalesYear.Size = New System.Drawing.Size(144, 25)
        Me.dtSalesYear.TabIndex = 16
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label5.Location = New System.Drawing.Point(11, 97)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(176, 19)
        Me.label5.TabIndex = 15
        Me.label5.Text = "Show Sales for the year:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label2.Location = New System.Drawing.Point(11, 46)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(190, 19)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Show Sales for the month:"
        '
        'dtSalesRange
        '
        Me.dtSalesRange.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtSalesRange.Location = New System.Drawing.Point(206, 43)
        Me.dtSalesRange.Name = "dtSalesRange"
        Me.dtSalesRange.Size = New System.Drawing.Size(144, 25)
        Me.dtSalesRange.TabIndex = 14
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btnPreviewYearlyReport)
        Me.groupBox2.Controls.Add(Me.btnPrintYearlyReport)
        Me.groupBox2.Controls.Add(Me.btnPreviewReport)
        Me.groupBox2.Controls.Add(Me.btnPrintReport)
        Me.groupBox2.Controls.Add(Me.btnPreviewInvoice)
        Me.groupBox2.Controls.Add(Me.btnPrintInvoice)
        Me.groupBox2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(381, 31)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(632, 145)
        Me.groupBox2.TabIndex = 23
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Printing Options"
        '
        'btnPreviewYearlyReport
        '
        Me.btnPreviewYearlyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPreviewYearlyReport.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewYearlyReport.Image = Global.Project.My.Resources.Resources.a_preview
        Me.btnPreviewYearlyReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreviewYearlyReport.Location = New System.Drawing.Point(269, 85)
        Me.btnPreviewYearlyReport.Name = "btnPreviewYearlyReport"
        Me.btnPreviewYearlyReport.Size = New System.Drawing.Size(169, 45)
        Me.btnPreviewYearlyReport.TabIndex = 23
        Me.btnPreviewYearlyReport.Text = "Preview Selected Yearly Sales Report"
        Me.btnPreviewYearlyReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreviewYearlyReport.UseVisualStyleBackColor = True
        '
        'btnPrintYearlyReport
        '
        Me.btnPrintYearlyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintYearlyReport.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintYearlyReport.Image = Global.Project.My.Resources.Resources.a_print
        Me.btnPrintYearlyReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintYearlyReport.Location = New System.Drawing.Point(269, 28)
        Me.btnPrintYearlyReport.Name = "btnPrintYearlyReport"
        Me.btnPrintYearlyReport.Size = New System.Drawing.Size(169, 45)
        Me.btnPrintYearlyReport.TabIndex = 22
        Me.btnPrintYearlyReport.Text = "Print Selected Yearly Sales Report"
        Me.btnPrintYearlyReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintYearlyReport.UseVisualStyleBackColor = True
        '
        'btnPreviewReport
        '
        Me.btnPreviewReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPreviewReport.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewReport.Image = Global.Project.My.Resources.Resources.a_preview
        Me.btnPreviewReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreviewReport.Location = New System.Drawing.Point(14, 85)
        Me.btnPreviewReport.Name = "btnPreviewReport"
        Me.btnPreviewReport.Size = New System.Drawing.Size(190, 45)
        Me.btnPreviewReport.TabIndex = 21
        Me.btnPreviewReport.Text = "Preview Selected Monthly Sales Report"
        Me.btnPreviewReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreviewReport.UseVisualStyleBackColor = True
        '
        'btnPrintReport
        '
        Me.btnPrintReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintReport.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReport.Image = Global.Project.My.Resources.Resources.a_print
        Me.btnPrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintReport.Location = New System.Drawing.Point(14, 28)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(190, 45)
        Me.btnPrintReport.TabIndex = 20
        Me.btnPrintReport.Text = "Print Selected Monthly Sales Report"
        Me.btnPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintReport.UseVisualStyleBackColor = True
        '
        'btnPreviewInvoice
        '
        Me.btnPreviewInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPreviewInvoice.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewInvoice.Image = Global.Project.My.Resources.Resources.a_preview
        Me.btnPreviewInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreviewInvoice.Location = New System.Drawing.Point(505, 85)
        Me.btnPreviewInvoice.Name = "btnPreviewInvoice"
        Me.btnPreviewInvoice.Size = New System.Drawing.Size(112, 45)
        Me.btnPreviewInvoice.TabIndex = 19
        Me.btnPreviewInvoice.Text = "Preview Invoice"
        Me.btnPreviewInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreviewInvoice.UseVisualStyleBackColor = True
        '
        'btnPrintInvoice
        '
        Me.btnPrintInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintInvoice.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintInvoice.Image = Global.Project.My.Resources.Resources.a_print
        Me.btnPrintInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintInvoice.Location = New System.Drawing.Point(505, 28)
        Me.btnPrintInvoice.Name = "btnPrintInvoice"
        Me.btnPrintInvoice.Size = New System.Drawing.Size(112, 45)
        Me.btnPrintInvoice.TabIndex = 7
        Me.btnPrintInvoice.Text = "Print Invoice"
        Me.btnPrintInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintInvoice.UseVisualStyleBackColor = True
        '
        'btnReset2
        '
        Me.btnReset2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset2.Image = Global.Project.My.Resources.Resources.a_refresh_a
        Me.btnReset2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset2.Location = New System.Drawing.Point(945, 5)
        Me.btnReset2.Name = "btnReset2"
        Me.btnReset2.Size = New System.Drawing.Size(40, 40)
        Me.btnReset2.TabIndex = 13
        Me.btnReset2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTipHelp.SetToolTip(Me.btnReset2, "Restore original order of records")
        Me.btnReset2.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = Global.Project.My.Resources.Resources.a_refresh
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(3, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(40, 40)
        Me.btnReset.TabIndex = 7
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTipHelp.SetToolTip(Me.btnReset, "Restore original order of ALL records")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSortPaymentDate
        '
        Me.btnSortPaymentDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSortPaymentDate.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortPaymentDate.Image = Global.Project.My.Resources.Resources.a_sort
        Me.btnSortPaymentDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSortPaymentDate.Location = New System.Drawing.Point(605, 9)
        Me.btnSortPaymentDate.Name = "btnSortPaymentDate"
        Me.btnSortPaymentDate.Size = New System.Drawing.Size(40, 40)
        Me.btnSortPaymentDate.TabIndex = 9
        Me.toolTipHelp.SetToolTip(Me.btnSortPaymentDate, "Sort by Payment Date")
        Me.btnSortPaymentDate.UseVisualStyleBackColor = True
        '
        'btnSortEmail
        '
        Me.btnSortEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSortEmail.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortEmail.Image = Global.Project.My.Resources.Resources.a_sort
        Me.btnSortEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSortEmail.Location = New System.Drawing.Point(390, 8)
        Me.btnSortEmail.Name = "btnSortEmail"
        Me.btnSortEmail.Size = New System.Drawing.Size(40, 40)
        Me.btnSortEmail.TabIndex = 11
        Me.toolTipHelp.SetToolTip(Me.btnSortEmail, "Sort by Email")
        Me.btnSortEmail.UseVisualStyleBackColor = True
        '
        'btnSortPrice
        '
        Me.btnSortPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSortPrice.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortPrice.Image = Global.Project.My.Resources.Resources.a_sort
        Me.btnSortPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSortPrice.Location = New System.Drawing.Point(511, 9)
        Me.btnSortPrice.Name = "btnSortPrice"
        Me.btnSortPrice.Size = New System.Drawing.Size(40, 40)
        Me.btnSortPrice.TabIndex = 6
        Me.toolTipHelp.SetToolTip(Me.btnSortPrice, "Sor by Price")
        Me.btnSortPrice.UseVisualStyleBackColor = True
        '
        'btnSortCountry
        '
        Me.btnSortCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSortCountry.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortCountry.Image = Global.Project.My.Resources.Resources.a_sort
        Me.btnSortCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSortCountry.Location = New System.Drawing.Point(201, 7)
        Me.btnSortCountry.Name = "btnSortCountry"
        Me.btnSortCountry.Size = New System.Drawing.Size(40, 40)
        Me.btnSortCountry.TabIndex = 12
        Me.toolTipHelp.SetToolTip(Me.btnSortCountry, "Sort by Country")
        Me.btnSortCountry.UseVisualStyleBackColor = True
        '
        'btnSortFullName
        '
        Me.btnSortFullName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSortFullName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortFullName.Image = Global.Project.My.Resources.Resources.a_sort
        Me.btnSortFullName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSortFullName.Location = New System.Drawing.Point(73, 5)
        Me.btnSortFullName.Name = "btnSortFullName"
        Me.btnSortFullName.Size = New System.Drawing.Size(40, 40)
        Me.btnSortFullName.TabIndex = 10
        Me.toolTipHelp.SetToolTip(Me.btnSortFullName, "Sort by Full Name")
        Me.btnSortFullName.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.btnReset2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.btnReset)
        Me.panel1.Controls.Add(Me.btnSortPaymentDate)
        Me.panel1.Controls.Add(Me.btnSortEmail)
        Me.panel1.Controls.Add(Me.btnSortPrice)
        Me.panel1.Controls.Add(Me.btnSortCountry)
        Me.panel1.Controls.Add(Me.btnSortFullName)
        Me.panel1.Location = New System.Drawing.Point(13, 181)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1001, 70)
        Me.panel1.TabIndex = 24
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label1.Location = New System.Drawing.Point(3, 49)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(994, 19)
        Me.label1.TabIndex = 8
        Me.label1.Text = "ID        Full Name                Country                                    Ema" & _
            "il                     Price       Payment Date     Expiry Date        Renewed  " & _
            "   Domain Names"
        '
        'printDialogReport
        '
        Me.printDialogReport.UseEXDialog = True
        '
        'printDialogReportYear
        '
        Me.printDialogReportYear.UseEXDialog = True
        '
        'printPreviewDialogReportYear
        '
        Me.printPreviewDialogReportYear.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDialogReportYear.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDialogReportYear.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDialogReportYear.Enabled = True
        Me.printPreviewDialogReportYear.Icon = CType(resources.GetObject("printPreviewDialogReportYear.Icon"), System.Drawing.Icon)
        Me.printPreviewDialogReportYear.Name = "printPreviewDialogReportYear"
        Me.printPreviewDialogReportYear.Visible = False
        '
        'printDocumentReportYear
        '
        '
        'lstRecords
        '
        Me.lstRecords.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecords.FormattingEnabled = True
        Me.lstRecords.ItemHeight = 14
        Me.lstRecords.Location = New System.Drawing.Point(12, 249)
        Me.lstRecords.Name = "lstRecords"
        Me.lstRecords.Size = New System.Drawing.Size(997, 130)
        Me.lstRecords.TabIndex = 25
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.lbTotalCustomers)
        Me.panel2.Controls.Add(Me.lbTotalSales)
        Me.panel2.Controls.Add(Me.label4)
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Location = New System.Drawing.Point(12, 381)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(997, 34)
        Me.panel2.TabIndex = 26
        '
        'lbTotalCustomers
        '
        Me.lbTotalCustomers.AutoEllipsis = True
        Me.lbTotalCustomers.AutoSize = True
        Me.lbTotalCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbTotalCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTotalCustomers.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalCustomers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTotalCustomers.Location = New System.Drawing.Point(212, 8)
        Me.lbTotalCustomers.MinimumSize = New System.Drawing.Size(60, 0)
        Me.lbTotalCustomers.Name = "lbTotalCustomers"
        Me.lbTotalCustomers.Size = New System.Drawing.Size(60, 21)
        Me.lbTotalCustomers.TabIndex = 18
        Me.lbTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalSales
        '
        Me.lbTotalSales.AutoEllipsis = True
        Me.lbTotalSales.AutoSize = True
        Me.lbTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbTotalSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTotalSales.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalSales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTotalSales.Location = New System.Drawing.Point(524, 8)
        Me.lbTotalSales.MinimumSize = New System.Drawing.Size(60, 0)
        Me.lbTotalSales.Name = "lbTotalSales"
        Me.lbTotalSales.Size = New System.Drawing.Size(60, 21)
        Me.lbTotalSales.TabIndex = 17
        Me.lbTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label4.Location = New System.Drawing.Point(355, 8)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(164, 19)
        Me.label4.TabIndex = 16
        Me.label4.Text = "Total Amount of Sales:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label3.Location = New System.Drawing.Point(3, 9)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(205, 19)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Total Number of Customers:"
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.btnAdd)
        Me.panel3.Controls.Add(Me.btnEdit)
        Me.panel3.Controls.Add(Me.btnDelete)
        Me.panel3.Location = New System.Drawing.Point(209, 421)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(542, 81)
        Me.panel3.TabIndex = 27
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.Project.My.Resources.Resources.a_add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(15, 9)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 65)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = Global.Project.My.Resources.Resources.a_edit
        Me.btnEdit.Location = New System.Drawing.Point(200, 9)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(135, 65)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit Record"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.Project.My.Resources.Resources.a_delete
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(379, 9)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(149, 65)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'printDocumentReport
        '
        '
        'printDialog1
        '
        Me.printDialog1.UseEXDialog = True
        '
        'printDocument1
        '
        '
        'printPreviewDialog1
        '
        Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDialog1.Enabled = True
        Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.printPreviewDialog1.Name = "printPreviewDialog1"
        Me.printPreviewDialog1.Visible = False
        '
        'printPreviewDialogReport
        '
        Me.printPreviewDialogReport.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDialogReport.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDialogReport.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDialogReport.Enabled = True
        Me.printPreviewDialogReport.Icon = CType(resources.GetObject("printPreviewDialogReport.Icon"), System.Drawing.Icon)
        Me.printPreviewDialogReport.Name = "printPreviewDialogReport"
        Me.printPreviewDialogReport.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 518)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.lstRecords)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Sales Records"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents printToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents invoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents selectedMonthlySalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents selectedYearlySalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents printPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents invoiceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents selectedMonthlySalesReportToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents selectedYearlySalesReportToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents customizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents countryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents emalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents fullNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents paymentDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents priceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents restoreRecordsToOriginalStateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents dtSalesYear As System.Windows.Forms.DateTimePicker
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents dtSalesRange As System.Windows.Forms.DateTimePicker
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btnPreviewYearlyReport As System.Windows.Forms.Button
    Private WithEvents btnPrintYearlyReport As System.Windows.Forms.Button
    Private WithEvents btnPreviewReport As System.Windows.Forms.Button
    Private WithEvents btnPrintReport As System.Windows.Forms.Button
    Private WithEvents btnPreviewInvoice As System.Windows.Forms.Button
    Private WithEvents btnPrintInvoice As System.Windows.Forms.Button
    Private WithEvents toolTipHelp As System.Windows.Forms.ToolTip
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents btnReset2 As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnReset As System.Windows.Forms.Button
    Private WithEvents btnSortPaymentDate As System.Windows.Forms.Button
    Private WithEvents btnSortEmail As System.Windows.Forms.Button
    Private WithEvents btnSortPrice As System.Windows.Forms.Button
    Private WithEvents btnSortCountry As System.Windows.Forms.Button
    Private WithEvents btnSortFullName As System.Windows.Forms.Button
    Private WithEvents printDialogReport As System.Windows.Forms.PrintDialog
    Private WithEvents printDialogReportYear As System.Windows.Forms.PrintDialog
    Private WithEvents printPreviewDialogReportYear As System.Windows.Forms.PrintPreviewDialog
    Private WithEvents printDocumentReportYear As System.Drawing.Printing.PrintDocument
    Private WithEvents lstRecords As System.Windows.Forms.ListBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents lbTotalCustomers As System.Windows.Forms.Label
    Private WithEvents lbTotalSales As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents printDocumentReport As System.Drawing.Printing.PrintDocument
    Private WithEvents printDialog1 As System.Windows.Forms.PrintDialog
    Private WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
    Private WithEvents printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Private WithEvents printPreviewDialogReport As System.Windows.Forms.PrintPreviewDialog

End Class
