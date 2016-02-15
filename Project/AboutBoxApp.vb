Public NotInheritable Class AboutBoxApp

    Private Sub AboutBoxApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Dim description As String = "This project demonstrates a practical application of knowledge gained in programming using Visual Basic during the course"
        description += " including the basics of OOP, in particular encapsulation and inheritance."
        description += "  The application is designed to help a small business to manage their customer records. "
        description += "The following features are present: adding, editing and deleting records; sorting records by different parameters; "
        description += "displaying records for certain time periods; printing sales reports for chosen time period; "
        description += "generating and printing invoices to customers"

        Me.Text = String.Format("About {0}", ApplicationTitle + " Customer Registry")
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName + " Customer Registry"
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright + " by Evgeniya O'Regan Pevchikh"
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description + description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    
End Class
