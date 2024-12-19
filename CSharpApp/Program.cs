using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Call the C++ function via SWIG-generated bindings
        int result1 = App1.add(3, 4);
        int result2 = App1.multiply(3, 4);

        Console.WriteLine($"Result of addition: {result1}");
        Console.WriteLine($"Result of multiplication: {result2}");
    }
}
