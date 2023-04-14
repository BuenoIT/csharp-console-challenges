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



## Challenge #2

Title: String Analysis with CountOccurrences Method

Description:

In this C# challenge, you will create a StringAnalyzer class with a CountOccurrences method that takes two string parameters: text and substring. The method will count the number of times the substring appears in the text. You will then use a for loop to iterate through a list of strings, call the CountOccurrences method for each string in the list, and print out a message to the console indicating the original string and the number of times the substring was found.

This challenge will test your ability to use a for loop to iterate through a list of strings, create a class, and manipulate strings using C# string manipulation methods. This challenge will also help you to understand how to use class methods to perform specific tasks on given input.


## Challenge #3

Title: Password Strength Checker with String Manipulation

Description: 

Write a C# program that implements a PasswordStrengthChecker class to check the strength of a password. The PasswordStrengthChecker class should have the following features:

1. Ability to set and get the password as a string.
2. Check the length of the password to ensure it is at least 8 characters long.
3. Check if the password contains at least one uppercase letter.
4. Check if the password contains at least one lowercase letter.
5. Check if the password contains at least one digit.
6. Check if the password contains at least one special character from the set: !@#$%^&*(),.?":{}|<>.
7. Provide a method to generate a random password of a given length.
8. Ability to determine if the password is strong, which requires meeting all the above criteria (length, uppercase, lowercase, digit, and special character).

The PasswordStrengthChecker class should have the following methods:

- public void SetPassword(string password): sets the password for the instance of PasswordStrengthChecker.
- public string GetPassword(): gets the password of the instance of PasswordStrengthChecker.
- public bool CheckLength(): checks if the password meets the minimum length requirement.
- public bool CheckUppercase(): checks if the password contains at least one uppercase letter.
- public bool CheckLowercase(): checks if the password contains at least one lowercase letter.
- public bool CheckDigits(): checks if the password contains at least one digit.
- public bool CheckSpecialChars(): checks if the password contains at least one special character.
- public bool IsStrongPassword(): checks if the password meets all the strength criteria (length, uppercase, lowercase, digit, and special character).
- public static string GenerateRandomPassword(int length): generates a random password of the given length, containing a mix of uppercase letters, lowercase letters, digits, and special characters.

You should demonstrate the usage of the PasswordStrengthChecker class in your program by creating an instance, setting a password, and checking its strength using the provided methods. Additionally, generate a random password using the GenerateRandomPassword method and set it as the password for another instance of PasswordStrengthChecker, then check its strength.



