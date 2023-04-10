# Week 13

Final Review

## Challenge #1

Title: Restaurant Table and Seats Management

Description: 

You have been tasked with developing a console application for a restaurant that allows the management of tables and seats. The application should have the following features:

Create Tables: The user should be able to create a new table by providing the table number and the number of seats for that table. The tables should be stored in an array.

Assign Customers: The user should be able to assign customers to a table. The user should be able to see a list of available tables and the number of seats available at each table. Once the user selects a table, they should be prompted to enter the number of customers. If the table has enough seats, the customers should be assigned to the table. If the table does not have enough seats, the user should be prompted to select another table.

Release Table: Once the customers have finished their meal, the user should be able to release the table. The table should be marked as available and the number of seats should be reset to the original value.

List Tables: The user should be able to see a list of all the tables, including the table number, number of seats, and whether the table is available or not.

Exit: The user should be able to exit the application.

Instructions:

Create a Table class that has the following properties: table number, number of seats, and availability status.

Create a TablesManager class that has an array of Table objects and the following methods: CreateTable, AssignCustomers, ReleaseTable, and ListTables.

Implement the CreateTable method that adds a new table to the array.

Implement the AssignCustomers method that allows the user to assign customers to a table. Use a loop to prompt the user to select a table until a table with enough seats is found.

Implement the ReleaseTable method that marks the table as available and resets the number of seats.

Implement the ListTables method that displays the list of tables.

Implement the Main method that allows the user to interact with the application.

Use exception handling to handle any errors that may occur during the execution of the program.