# Week 9

Exceptions and Errors

## Concepts

- What is an exception in C#?

An exception is an event that occurs during the execution of a program that disrupts the normal flow of instructions.

- How are exceptions handled in C#?

Exceptions can be handled using try-catch-finally blocks. The try block contains the code that might generate an exception, and the catch block handles the exception if it occurs. The finally block is used to clean up resources regardless of whether an exception occurred or not.

- What is the difference between an exception and an error in C#?

In C#, an exception is a type of error that occurs during the execution of a program, while an error can refer to any problem that prevents a program from running correctly, including syntax errors, runtime errors, and logical errors.

- What is the purpose of throwing an exception in C#?

Throwing an exception allows a program to handle errors and unexpected events in a more controlled and organized way. By throwing an exception, the program can transfer control to an appropriate catch block and provide information about the error that occurred.

-  Can you give an example of a built-in exception in C#?

One example of a built-in exception in C# is the DivideByZeroException, which is thrown when attempting to divide a number by zero.



## Challenge #1

Title: Calculator V3

Description: Modify the code from the provided link to handle all possible errors that may arise in the calculator program. This can be achieved by implementing catch blocks that correspond to each type of exception that the program can generate. By doing so, the program can handle errors more gracefully and prevent unexpected crashes or erroneous output.
[Calculator_V2](https://github.com/BuenoIT/csharp-console-challenges/tree/main/Week_5/Calculator_V2)

