# C# DivideByZeroException Example

This repository demonstrates a simple example of a `DivideByZeroException` in C#.  The `bug.cs` file contains code that can throw this exception, while `bugSolution.cs` provides a corrected version.

## Bug Description

The `MyMethod()` function in `bug.cs` attempts to divide 10 by the value of `MyProperty`. If `MyProperty` is 0, this will result in a `DivideByZeroException`. 

## Solution

The `bugSolution.cs` file shows how to avoid this error using a simple check before performing the division.