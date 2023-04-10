# Week 10

Arrays

## Concepts

- What is an array in C#?

An array is a collection of elements of the same type that are stored in contiguous memory locations and can be accessed using an index or a subscript.

- How do you declare an array in C#?

You can declare an array in C# by specifying the type of the elements, followed by square brackets [] and the name of the array. For example, int[] myArray = new int[5]; declares an integer array of size 5.

- How do you initialize an array in C#?

 You can initialize an array in C# by assigning values to its elements using curly braces {}. For example, int[] myArray = { 1, 2, 3, 4, 5 }; initializes an integer array with the values 1, 2, 3, 4, and 5.

- Can you change the size of an array in C# after it has been declared?

No, you cannot change the size of an array in C# after it has been declared. However, you can create a new array of a different size and copy the elements from the old array to the new array.

- What are jagged arrays in C#?

Jagged arrays in C# are arrays of arrays, where each sub-array can have a different length. For example, int[][] jaggedArray = new int[3][]; jaggedArray[0] = new int[] { 1, 2 }; jaggedArray[1] = new int[] { 3, 4, 5 }; jaggedArray[2] = new int[] { 6 }; declares a jagged array of integers with three sub-arrays of lengths 2, 3, and 1, respectively.

- What are multidimensional arrays in C#?

Multidimensional arrays in C# are arrays that have more than one dimension. For example, int[,] myArray = new int[3,2]; declares a two-dimensional integer array with three rows and two columns. You can access the elements of a multidimensional array using multiple indexes or subscripts.



## Challenge #1

Title: Array Sorting Challenge

Description: Create a program in C# that takes an integer array of any size as input from the user and sorts the elements of the array in ascending order using the bubble sort algorithm. The program should then print the sorted array to the console.

Requirements:

1. The program should prompt the user to input the size of the array and the elements of the array.
2. The program should handle errors gracefully if the user inputs non-numeric values or if the size of the array is less than or equal to zero.
3. The program should sort the array in ascending order using the bubble sort algorithm.
4. The program should print the sorted array to the console.

