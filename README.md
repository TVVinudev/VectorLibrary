# VectorMathLibrary

A lightweight C# library for performing vector arithmetic calculations in **2D, 3D, and 4D**, supporting both floating-point and integer types using **generic structs**.

## Features
✔ Supports **2D, 3D, and 4D vectors**  
✔ Works with **integers and floating-point numbers**  
✔ Implements **arithmetic operations** (`+`, `-`, `*`, `/`)  
✔ **Dot product & cross product** support  
✔ Generic design using `INumber<T>` (Requires .NET 7+)

---

## Installation
### **1. Using NuGet Package Manager** (Visual Studio)
1. Open **NuGet Package Manager**
2. Search for `VectorMath`
3. Click **Install**

### **2. Using .NET CLI** (Recommended)
Run the following command in your terminal:
```sh
dotnet add package VectorMath --version X.Y.Z
```
*(Replace `X.Y.Z` with the latest version of the package.)*

### **3. Manual Installation**
If you have the `.nupkg` file:
- Add it to a local NuGet feed.
- Use the **Manage NuGet Packages** option in Visual Studio to install it.

---

## Usage
Import the `VectorMath` namespace and use it in your project:

```csharp
using System;
using VectorMath;

class Program
{
    static void Main()
    {
        // 2D Vectors
        var v2a = new Vector<int>(3, 4);
        var v2b = new Vector<int>(1, 2);
        Console.WriteLine($"2D Addition: {v2a + v2b}");

        // 3D Vectors
        var v3a = new Vector<float>(1.0f, 2.0f, 3.0f);
        var v3b = new Vector<float>(4.0f, 5.0f, 6.0f);
        Console.WriteLine($"3D Dot Product: {Vector<float>.Dot(v3a, v3b)}");
        Console.WriteLine($"3D Cross Product: {Vector<float>.Cross(v3a, v3b)}");
    }
}
```

### **Supported Operations**
| Operation      | Example                          |
|--------------|--------------------------------|
| Addition      | `v1 + v2`                      |
| Subtraction   | `v1 - v2`                      |
| Scalar Multiplication | `v * scalar`         |
| Dot Product   | `Vector<T>.Dot(v1, v2)`        |
| Cross Product (3D) | `Vector<T>.Cross(v1, v2)` |

---

## Requirements
- **.NET 7 or later** (Uses `INumber<T>` from `System.Numerics`)

## Contributing
1. Fork the repository.
2. Create a new branch (`feature-xyz`).
3. Commit your changes.
4. Open a Pull Request.

## License
This project is licensed under the **MIT License**.

## Author
Developed by **[Your Name]**. Feel free to reach out for suggestions or contributions!

