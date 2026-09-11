# C# Class and Method Assignment

## Description

This project is a C# console application created as part of a programming assignment. The purpose of the assignment is to demonstrate how to create a class, create and use a method with parameters, instantiate a class, and pass parameters to a method both normally and by name.

## Requirements

The application demonstrates the following:

1. Creates a class named `MathOperations`.
2. Creates a `void` method named `Calculate()` that accepts two integers as parameters.
3. Performs a mathematical operation on the first integer.
4. Displays the second integer to the console.
5. Instantiates the `MathOperations` class in the `Main()` method.
6. Calls the `Calculate()` method by passing two numbers normally.
7. Calls the `Calculate()` method again using named parameters.
8. Includes comments throughout the code to explain what each line or block does.

# Please Find Method class inside of Program.cs/ Main Class ! 

## Technologies Used

* C#
* .NET
* Visual Studio
* Console Application

## How the Program Works

The program contains a `MathOperations` class with a `Calculate()` method.

The method accepts two integer parameters:


public void Calculate(int number1, int number2)

The result is then displayed along with the second number.

In the `Main()` method, an object of the `MathOperations` class is created:


MathOperations math = new MathOperations();


The method is first called using regular parameters:


math.Calculate(10, 5);


The method is then called using named parameters:


