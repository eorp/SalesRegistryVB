# SalesRegistryVB
Final project for Visual Basic course

This project demonstrates a practical application of knowledge gained in programming using Visual Basic during the course including the basics of OOP, in particular encapsulation and inheritance.  The application is designed to help a small business to manage their customer records. The following features are present:
- adding, editing and deleting records; 
- sorting records by different parameters; 
- displaying records for certain time periods; 
- generating and printing sales reports for chosen time period; 
- generating and printing invoices to customers

## Class Diagram

![classdiagram](https://cloud.githubusercontent.com/assets/14193564/13039813/f79b732a-d39b-11e5-8a5d-9f35ed4cc502.png)

# Project Overview


![1](https://cloud.githubusercontent.com/assets/14193564/13062085/d692df36-d433-11e5-8c9c-f568a9360a2a.png)

Figure 1 Application Interface

# Usage Instructions

## Add Record

Pressing "Add Record" button will bring up a form where the information can be entered 

![2](https://cloud.githubusercontent.com/assets/14193564/13062086/d69dd968-d433-11e5-9a66-7289cb040de6.png)

Figure 2 Adding a New Record

First name, surname and email address are required fields and if those are not entered a corresponding warning message will be displayed.

![3](https://cloud.githubusercontent.com/assets/14193564/13062087/d69f8f1a-d433-11e5-9881-c49bdafc3716.png)
![4](https://cloud.githubusercontent.com/assets/14193564/13062089/d6af89ce-d433-11e5-8cf9-f6b00d0c6eda.png)

Figure 3 Warning Message Examples

A product price is set according to the product name automatically thus the price field editing is disabled.

Expiry date is set automatically to be one year ahead of the payment date.

After all information had been filled and after pressing "OK" button the main window will be displayed again and the list of records will be updated to include the new record. The total number of customers and the total amount of sales will also be updated to reflect the changes made.

## Edit Record

In order to edit an existing record that record will need to be selected from the list first. If no record is being selected a warning message will appear.

![5](https://cloud.githubusercontent.com/assets/14193564/13062088/d6aef9d2-d433-11e5-86c6-a440b0812344.png)

Figure 4 Warning Message: Record needs to be selected

After selecting a record and pressing "Edit Record" button a form will be shown containing all the information for the selected record and any required editing can be performed.

Pressing "Cancel" button will discard any changes made. In order to save changes the user needs to press "OK" button. The main window will be displayed and the changes will be reflected in the records list.

## Delete Record

In order to delete a record that record needs to be selected first otherwise a warning message will be shown. After choosing a record to be deleted a confirmation message will be shown to ensure that the record is not being deleted by accident.

![6](https://cloud.githubusercontent.com/assets/14193564/13062090/d6b99c52-d433-11e5-8035-507feb9773ec.png)

Figure 5 Confirmation Message Upon Record Deletion

All changes including adding, editing and deleting records are saved in an XML file enabling to continue working with the list of records the next time the application is started and ensuring that the information is not lost. On application start up any records stored in the XML file are retrieved and displayed.

## Sort Records

The records can be sorted by customer’s full name, country, email, product price and payment date by pressing buttons located above the aforementioned fields or from the menu Tools->Sort by.

![7](https://cloud.githubusercontent.com/assets/14193564/13062091/d6bc0578-d433-11e5-91d6-6fcf31f4d2c7.png)

Figure 6 Sorting Records

Records can also be sorted by certain month of a certain year by selecting the time period in the first date box located in the “Display Options” section. The month can be selected either by pressing left and right arrows or by clicking the month being displayed and selecting required month from the drop down list.

![8](https://cloud.githubusercontent.com/assets/14193564/13062092/d6c85bf2-d433-11e5-81c4-ef04fbb12522.png)

Figure 7 Selecting the Month

The year can be selected by clicking on the year field and pressing up and down arrows.
![9](https://cloud.githubusercontent.com/assets/14193564/13062079/d659672e-d433-11e5-9f4e-ec420e3626ed.png)

Figure 8 Selecting Year of the Month

It is also possible to display the records for the whole year by selecting the year from the second date box located in the “Display Options” section. The year can be chosen by pressing up and down arrows or by highlighting the year in the box and pressing up and down arrow buttons on the keyboard.

![10](https://cloud.githubusercontent.com/assets/14193564/13062081/d65fa512-d433-11e5-8c1c-a78fd3e40233.png)

Figure 9 Selecting the Year

The records for a selected time period can also be sorted by customer’s name, country, email, product price and payment date the same way as mentioned earlier. Once the records for selected time period had been sorted by some value, a blue refresh button will appear. Clicking this button will restore unsorted order of the records for the currently selected time period. In order to display all the records (unsorted) contained in the list a green refresh button can be pressed. Alternatively this action can be performed from the menu Tools->Restore Records To Original State.

![11](https://cloud.githubusercontent.com/assets/14193564/13062080/d65e4140-d433-11e5-8bc3-3c7800633a74.png)

Figure 10 Restore Original Order of Records



## Printing

The sales reports for the selected time periods and the invoices for a selected record can be printed from the application by pressing the corresponding buttons located in the “Printing Options” section or from the menu File->Print.

![12](https://cloud.githubusercontent.com/assets/14193564/13062082/d661d9cc-d433-11e5-8925-1eb249fe27ba.png)

Figure 11 Printing and Pint Preview Options

The sales reports and the invoices for selected records can also be previewed before printing by pressing the corresponding buttons or from the menu File->Print Preview.

![13](https://cloud.githubusercontent.com/assets/14193564/13062083/d664f7d8-d433-11e5-9b2b-f7f27632cedb.png)
![14](https://cloud.githubusercontent.com/assets/14193564/13062084/d66f4f8a-d433-11e5-8939-31788a85a5fa.png)

Figure 12 Menu: Print and Print Preview

