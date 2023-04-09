# Week 3

Debugging and Decision Statements


## Concepts

- What symbols are used in decision statements in C#?

The symbols used in decision statements in C# include the if statement (if), the else statement (else), the else if statement (else if), and the switch statement (switch).

- What operators can be used in if statements in C#?

If statements in C# can use various comparison operators, such as == (equal to), != (not equal to), > (greater than), < (less than), >= (greater than or equal to), and <= (less than or equal to), to evaluate a condition.

- What is the syntax for if statements in C#?

if (condition) {
    // Code to be executed if the condition is true
}


-  What is the syntax for else statements in C#?

if (condition) {
    // Code to be executed if the condition is true
}
else {
    // Code to be executed if the condition is false
}


- What is the syntax for switch statements in C#?

switch (expression) {
    case value1:
        // Code to be executed if expression equals value1
        break;
    case value2:
        // Code to be executed if expression equals value2
        break;
    default:
        // Code to be executed if expression does not equal any of the specified values
        break;
}


## Challenge #1

Title: Temperature Converter.

Description: Write a C# program that prompts the user to enter a temperature and a temperature scale (Celsius or Fahrenheit). The program should then convert the temperature to the other scale and display the result. Use decision statements and appropriate operators to accomplish this task.