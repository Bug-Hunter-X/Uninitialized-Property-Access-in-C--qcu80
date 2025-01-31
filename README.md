# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property before it's been explicitly assigned a value.  While this might appear to work in simple cases, it's crucial to understand the potential for unexpected behavior and maintain code clarity. 

The `bug.cs` file contains the buggy code, while `bugSolution.cs` provides a corrected version.

Uninitialized properties in C# have default values. For example, an integer property defaults to 0, a string to `null`, etc.  However, it is generally considered better practice to initialize properties explicitly. This improves code readability and prevents unexpected values from being used.