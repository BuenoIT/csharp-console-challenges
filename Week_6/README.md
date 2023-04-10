# Week 6

Iteration

## Concepts

- What is iteration in C#?

Iteration is the process of repeatedly executing a block of code until a certain condition is met. In C#, this can be achieved through various looping constructs such as for, while, do-while, and foreach.

- What are the different types of iteration in programming?

Count-controlled iteration: where the number of iterations is known before the loop starts.
Condition-controlled iteration: where the loop continues until a certain condition is met.
Collection-controlled iteration: where the loop iterates over the elements of a collection.
Sentinel-controlled iteration: where the loop continues until a specific value is encountered.
Nested iteration: where one or more loops are nested within another loop.

- What is the syntax for a for loop in C#?

for (initialization; condition; increment)
{
    // code to be executed
}

- How does a while loop work in C#?

A while loop in C# repeatedly executes a block of code as long as a certain condition is true. The syntax for a while loop is as follows:

while (condition)
{
    // code to be executed
}

- What is the difference between a while loop and a do-while loop in C#?

The main difference between a while loop and a do-while loop in C# is that a while loop evaluates its condition before executing the loop body, while a do-while loop evaluates its condition after executing the loop body at least once. The syntax for a do-while loop is as follows:

do
{
    // code to be executed
} while (condition);

- How can you break out of a loop in C#?

To break out of a loop in C#, you can use the break keyword. When the break keyword is encountered inside a loop, the loop is terminated and control is transferred to the statement immediately following the loop.

- How can you skip an iteration of a loop in C#?

To skip an iteration of a loop in C#, you can use the continue keyword. When the continue keyword is encountered inside a loop, the current iteration is terminated and control is transferred to the next iteration.

## Challenge #1

Title: Vowel Count Challenge

Description: In this challenge, you are given a string, and your task is to count the number of vowels (a, e, i, o, u) in the string. To solve this challenge, you can use iteration to iterate through each character in the string and check if it is a vowel.
