'MainForm.vb
'Created by Evgeniya O'Regan Pevchikh, 27/8/2013
Option Strict On
Option Explicit On

Imports System.Drawing.Printing

Public Class MainForm
    'instance of customermanager object
    Private manager As New CustomerManager()
    'variable to keep track whether records were sorted by certain time period to enable further sorting by other parameters
    '0-not sorted by time, 1- sorted by month,year, 2-sorted by year
    Private sortedByTimePeriod As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitialiseGUI()
    End Sub

    ''' <summary>
    ''' setup form components with data
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitialiseGUI()
        'update the data to be displayed
        UpdateList()

        'display month and year
        dtSalesRange.Format = DateTimePickerFormat.Custom
        dtSalesRange.CustomFormat = "  MMMM yyyy"

        'display year only
        dtSalesYear.Format = DateTimePickerFormat.Custom
        dtSalesYear.CustomFormat = "      yyyy"
        'display totals for number of custmores and sales
        RefreshTotals()

        sortedByTimePeriod = 0

        btnReset2.Visible = False
    End Sub

    ''' <summary>
    ''' displays all added customers' info in the listbox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateList()
        'save records to xml file
        manager.SaveToFile()
        'refresh records list
        lstRecords.Items.Clear()
        lstRecords.Items.AddRange(manager.GetCustomerInfo())

        'get totals for original records list
        manager.GetTotalsOriginal()
        'update totals
        RefreshTotals()
    End Sub

    ''' <summary>
    ''' checks whether a record is selected in the listbox
    ''' </summary>
    ''' <returns>true if record is selected and false otherwise</returns>
    ''' <remarks></remarks>
    Private Function IsSelected() As Boolean
        If lstRecords.SelectedIndex <> -1 Then
            Return True
        Else
            MessageBox.Show("Please select a record first before performing this operation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

    End Function

    ''' <summary>
    ''' update totals for customer count and sales revenue for an updated records list
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RefreshTotals()
        lbTotalCustomers.Text = manager.TotalCustomersData.ToString()

        lbTotalSales.Text = manager.TotalSalesData.ToString()
    End Sub

    ''' <summary>
    ''' generic method for displaying records sorted by selected value
    ''' </summary>
    ''' <param name="sortedBy">value to be sorted by</param>
    Private Sub ShowSortedRecords(ByVal sortedBy As String)
        
        'display updated list
        lstRecords.Items.Clear()
        lstRecords.Items.AddRange(manager.SortedBy(sortedBy, sortedByTimePeriod))
        'update totals
        RefreshTotals()

    End Sub
    ''' <summary>
    ''' check whether the refresh button used to restore
    ''' the original order of records for selected month of the year or for
    ''' selected year
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CheckRefreshButtonVisibility()
        'if all records are shown - hide the button
        If sortedByTimePeriod = 0 Then
            btnReset2.Visible = False
        Else
            'if records are sorted by selected month or year - show the button
            btnReset2.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' generic method for printing a document
    ''' </summary>
    ''' <param name="pd">printdialog object</param>
    ''' <param name="doc">printdocument object</param>
    ''' <remarks></remarks>
    Private Sub Printing(ByVal pd As PrintDialog, ByVal doc As PrintDocument)
        pd.Document = doc

        If pd.ShowDialog = DialogResult.OK Then
            doc.Print()
        End If
    End Sub

    ''' <summary>
    ''' generic method for print preview
    ''' </summary>
    ''' <param name="ppd">PrintPreviewDialog object</param>
    ''' <param name="doc">printdocument object</param>
    ''' <remarks></remarks>
    Private Sub PrintPreview(ByVal ppd As PrintPreviewDialog, ByVal doc As PrintDocument)
        ppd.Document = doc
        ppd.ShowDialog()
    End Sub

    ''' <summary>
    ''' add new record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim recForm As New RecordForm()
        'when user enters all data in contact form and clicks ok
        If recForm.ShowDialog() = DialogResult.OK Then
            Dim cust As New Customer(recForm.CustomerData.FirstName, recForm.CustomerData.LastName, recForm.CustomerData.AddressData, recForm.CustomerData.EmailData, recForm.CustomerData.ProductData, manager.GetNewId)
            manager.AddCustomer(cust)   'add new record to customers list
            UpdateList()                    'display updated info in the listbox
        End If

    End Sub

    ''' <summary>
    ''' delete selected record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'provided the record is selected in the listbox
        If IsSelected() Then
            If manager.CheckIndex(lstRecords.SelectedIndex) Then
                'if user chooses to proceed with record deletion
                If MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    manager.DeleteCustomer(lstRecords.SelectedIndex)    'delete the record from the list
                    UpdateList()                                            'and update display info
                End If

            End If
        End If

    End Sub
    ''' <summary>
    ''' edit selected record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'if a record is not selected - show warning
        If IsSelected() Then
            Dim recForm As New RecordForm()     'create an instance of recordform
            'provided the record is selected from the listbox
            If manager.GetCustomer(lstRecords.SelectedIndex) IsNot Nothing Then
                'get selected record's ino and display it on contact form
                recForm.CustomerData = manager.GetCustomer(lstRecords.SelectedIndex)
                'when user chooses to update corrected info and click ok button
                If recForm.ShowDialog() = DialogResult.OK Then
                    'save updated info
                    manager.EditCustomer(recForm.CustomerData, lstRecords.SelectedIndex, recForm.CustomerData.CustomerId)
                    'update data in the listbox
                    UpdateList()

                End If

            End If
        End If

    End Sub

    '-----------------sorting

    ''' <summary>
    ''' sort records by full  name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSortFullName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortFullName.Click
        ShowSortedRecords("name")
        CheckRefreshButtonVisibility()
    End Sub

    ''' <summary>
    ''' sort records by country
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSortCountry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortCountry.Click
        ShowSortedRecords("country")
        CheckRefreshButtonVisibility()
    End Sub
    ''' <summary>
    ''' sort records by email
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSortEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortEmail.Click
        ShowSortedRecords("email")
        CheckRefreshButtonVisibility()
    End Sub
    ''' <summary>
    ''' sort records by price
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSortPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortPrice.Click
        ShowSortedRecords("price")
        CheckRefreshButtonVisibility()
    End Sub

    ''' <summary>
    ''' sort records by payment date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSortPaymentDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortPaymentDate.Click
        ShowSortedRecords("date")
        CheckRefreshButtonVisibility()
    End Sub

    ''' <summary>
    ''' reset records list to original unsorted state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'refresh records list
        UpdateList()
        sortedByTimePeriod = 0
        CheckRefreshButtonVisibility()
    End Sub
    ''' <summary>
    ''' restore the records for selected month/year from being
    ''' sorted by some other value to their original state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset2.Click
        'clear the listbox
        lstRecords.Items.Clear()
        'show records sorted by selected month/year or year only (undo any other sorting perormed on the records)
        If sortedByTimePeriod = 1 Then
            lstRecords.Items.AddRange(manager.ShowSelectedSales(dtSalesRange.Value.Month, dtSalesRange.Value.Year, 0))
        ElseIf sortedByTimePeriod = 2 Then
            lstRecords.Items.AddRange(manager.ShowSelectedSalesYear(dtSalesYear.Value.Year, 0))
        End If

        RefreshTotals()
    End Sub

    ''' <summary>
    ''' show records for a selected month/year
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtSalesRange_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtSalesRange.ValueChanged
        'sorted by mm/yy
        sortedByTimePeriod = 1

        lstRecords.Items.Clear()
        lstRecords.Items.AddRange(manager.ShowSelectedSales(dtSalesRange.Value.Month, dtSalesRange.Value.Year, 0))
        RefreshTotals()
    End Sub

    ''' <summary>
    ''' show records for a selected year
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dtSalesYear_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtSalesYear.ValueChanged
        'sorted by year
        sortedByTimePeriod = 2

        'MessageBox.Show(dtSalesYear.Value.Year.ToString())
        lstRecords.Items.Clear()
        lstRecords.Items.AddRange(manager.ShowSelectedSalesYear(dtSalesYear.Value.Year, 0))
        RefreshTotals()
    End Sub

    '---------------------------Printing
    ''' <summary>
    ''' print monthly sales report
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReport.Click
        Printing(printDialogReport, printDocumentReport)
    End Sub

    ''' <summary>
    ''' print yearly sales report
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintYearlyReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintYearlyReport.Click
        Printing(printDialogReportYear, printDocumentReportYear)
    End Sub

    ''' <summary>
    ''' print invoice doe a selected record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrintInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintInvoice.Click
        'make sure the record is selected
        If (IsSelected()) Then
            Printing(printDialog1, printDocument1)
        End If
    End Sub

    ''' <summary>
    ''' setup document to be printed (invoice)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub printDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        Dim brush As New SolidBrush(Color.Black)

        'get information for selected record for the invoice
        Dim print As String = manager.GetInvoice(lstRecords.SelectedIndex)

        g.DrawString(print, New Font("Cambria", 12), brush, 10, 10)
    End Sub
    ''' <summary>
    ''' setup document to be printed - month of the year
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub printDocumentReport_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocumentReport.PrintPage
        Dim g As Graphics = e.Graphics
        Dim brush As New SolidBrush(Color.Black)

        'get info for selected month and year
        Dim print As String() = manager.ShowSelectedSales(dtSalesRange.Value.Month, dtSalesRange.Value.Year, 1)

        'setup document layout
        Dim x As Integer = 20, y As Integer = 20

        g.DrawString(("Sales Report for " & dtSalesRange.Value.Month.ToString() & "/") & dtSalesRange.Value.Year, New Font("Cambria", 14), brush, x, 40)
        y += 50

        For Each line As String In print

            g.DrawString(line, New Font("Cambria", 12), brush, x, y)
            y += 20
        Next
        Dim total As String = "Total:" & vbTab & vbTab & manager.TotalSalesData.ToString()
        g.DrawString(vbLf & total, New Font("Cambria", 14), brush, x, (y + 17))
        '  e.HasMorePages = true;
    End Sub
    ''' <summary>
    ''' setup document to be printed - by year
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub printDocumentReportYear_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocumentReportYear.PrintPage
        Dim g As Graphics = e.Graphics
        Dim brush As New SolidBrush(Color.Black)

        'get inforamtion for selected year
        Dim print As String() = manager.ShowSelectedSalesYear(dtSalesYear.Value.Year, 1)

        'set document layout
        Dim x As Integer = 20, y As Integer = 20

        g.DrawString("Sales Report for the year " & dtSalesYear.Value.Year, New Font("Cambria", 14), brush, x, 40)
        y += 50

        For Each line As String In print

            g.DrawString(line, New Font("Cambria", 12), brush, x, y)
            y += 20
        Next
        Dim total As String = "Total:" & vbTab & vbTab & manager.TotalSalesData.ToString()
        g.DrawString(vbLf & total, New Font("Cambria", 14), brush, x, (y + 17))
    End Sub

    '-----------------------Preview documents before printing

    ''' <summary>
    ''' preview monthly sales report
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPreviewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewReport.Click
        PrintPreview(printPreviewDialogReport, printDocumentReport)
    End Sub
    ''' <summary>
    ''' preview yearly sales report
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPreviewYearlyReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewYearlyReport.Click
        PrintPreview(printPreviewDialogReportYear, printDocumentReportYear)
    End Sub
    ''' <summary>
    ''' preview invoice for selected record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPreviewInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewInvoice.Click
        'if a record is chosen from the list
        If IsSelected() Then
            PrintPreview(printPreviewDialog1, printDocument1)
        End If
    End Sub
    '----------------------MENU events

    '-----------Printing from menu
    ''' <summary>
    ''' print invoice
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub invoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invoiceToolStripMenuItem.Click
        'make sure the record is selected
        If (IsSelected()) Then
            Printing(printDialog1, printDocument1)
        End If
    End Sub

    ''' <summary>
    ''' print montly sales report
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub selectedMonthlySalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectedMonthlySalesReportToolStripMenuItem.Click
        Printing(printDialogReport, printDocumentReport)
    End Sub
    ''' <summary>
    ''' print yearly sales report
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub selectedYearlySalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectedYearlySalesReportToolStripMenuItem.Click
        Printing(printDialogReportYear, printDocumentReportYear)
    End Sub
    '------------------print preview from menu

    ''' <summary>
    ''' invoice preview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub invoiceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invoiceToolStripMenuItem1.Click
        ' if a record is chosen from the list
        If (IsSelected()) Then
            PrintPreview(printPreviewDialog1, printDocument1)
        End If
    End Sub

    ''' <summary>
    ''' montly sales preview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub selectedMonthlySalesReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectedMonthlySalesReportToolStripMenuItem1.Click
        PrintPreview(printPreviewDialogReport, printDocumentReport)
    End Sub
    ''' <summary>
    ''' yearly sales preview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub selectedYearlySalesReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectedYearlySalesReportToolStripMenuItem1.Click
        PrintPreview(printPreviewDialogReportYear, printDocumentReportYear)
    End Sub

    '------------sorting from menu

    ''' <summary>
    ''' sort by country
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub countryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countryToolStripMenuItem.Click
        ShowSortedRecords("country")
    End Sub

    ''' <summary>
    ''' sort by email
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub emalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emalToolStripMenuItem.Click
        ShowSortedRecords("email")
    End Sub
    ''' <summary>
    ''' sort by full name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub fullNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fullNameToolStripMenuItem.Click
        ShowSortedRecords("name")
    End Sub
    ''' <summary>
    ''' sort by payment date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub paymentDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paymentDateToolStripMenuItem.Click
        ShowSortedRecords("date")
    End Sub
    ''' <summary>
    ''' sort by price
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub priceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles priceToolStripMenuItem.Click
        ShowSortedRecords("price")
    End Sub

    '-----exit the application from menu
    ''' <summary>
    ''' exit the program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        If (MessageBox.Show("Are you sure you want to exit this application?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' restore original records order
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub restoreRecordsToOriginalStateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restoreRecordsToOriginalStateToolStripMenuItem.Click
        UpdateList()
        CheckRefreshButtonVisibility()
    End Sub

    ''' <summary>
    ''' show about the program app
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub aboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutToolStripMenuItem.Click
        Dim about As New AboutBoxApp()
        about.Show()
    End Sub
End Class
