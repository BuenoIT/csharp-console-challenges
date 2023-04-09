# Week 5

Methods

## Concepts

- What is a method in C#?

A method in C# is a block of code that performs a specific task or set of tasks. Methods can be called from other parts of the program to execute their functionality.

- What is the syntax for declaring a method in C#?

[access modifier] [return type] [method name]([parameter list]) {
    // Method body
    return [return value];
}


- What is an access modifier in C#?

An access modifier in C# is a keyword that determines the level of access that other parts of the program have to a method. The access modifiers in C# include public, private, protected, and internal.


-  What is a return type in C#?

A return type in C# is the data type of the value that a method returns to the caller. It can be any of the built-in data types in C#, or a user-defined data type.


-  What is a parameter list in C#?

A parameter list in C# is a comma-separated list of input parameters that a method takes as arguments. Each parameter has a data type and a name, and is enclosed in parentheses after the method name.

-  How do you call a method in C#?

To call a method in C#, you use the method name followed by a set of parentheses containing any required arguments. For example:
int result = MyMethod(arg1, arg2);

- What is method overloading in C#?

Method overloading in C# is the ability to define multiple methods with the same name but different parameter lists. This allows a method to have different behaviors depending on the arguments passed to it.

- What is a static method in C#?

A static method in C# is a method that belongs to the class itself, rather than an instance of the class. This means that it can be called without first creating an instance of the class, and it can only access static members of the class.

- What is a constructor in C#?

A constructor in C# is a special type of method that is used to initialize objects of a class. It is called automatically when an object is created, and is used to set the initial values of the object's data members.


## Challenge #1

Title: Calculator App V2

Description: Write a C# program that implements a basic calculator using methods. The program should prompt the user to enter two numbers and an operator (+, -, *, /). It should then call a method to perform the appropriate calculation and display the result.
