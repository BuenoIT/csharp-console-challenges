# Week 11

Values, References & Strings

## Concepts

- What is a reference type variable in C#?

A reference type variable is a type of variable in C# that holds a reference to an object in memory, rather than the object itself.

- How do reference type variables differ from value type variables in C#?

Reference type variables hold a reference to an object in memory, while value type variables hold the value of the object itself. Reference type variables are stored in the heap, while value type variables are stored on the stack.

- What are some examples of reference type variables in C#?

Examples of reference type variables in C# include classes, arrays, and strings

- How are reference type variables declared in C#?

Reference type variables are declared using the class or interface keyword, followed by the name of the variable and an optional initialization.

- What happens when a reference type variable is set to null in C#?

When a reference type variable is set to null, it means that it no longer points to an object in memory. Any attempt to access the properties or methods of the variable will result in a NullReferenceException.

- Can you create your own reference type variables in C#?

Yes, you can create your own reference type variables by defining your own classes and interfaces.


## Challenge #1

Title: Passing Reference Type Variables Challenge

Description: Write a C# program that demonstrates how to pass a reference type variable as an argument to a method. Your program should define a class called Person with two properties: Name and Age. The program should then declare an instance of the Person class, initialize its properties, and pass it as an argument to a method called DisplayPersonDetails.

The DisplayPersonDetails method should take a Person object as its parameter and use the Console.WriteLine() method to display the person's name and age on the console. To complete this challenge, you must use a reference type variable and pass it as an argument to a method.

