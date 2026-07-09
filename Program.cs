using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10, b = 5;

        // Arithmetic Operator
        Console.WriteLine("Addition: " + (a + b));

        // Assignment Operator
        a += 5;
        Console.WriteLine("Assignment (a += 5): " + a);

        // Relational Operator
        Console.WriteLine("a > b: " + (a > b));

        // Logical Operator
        bool x = true, y = false;
        Console.WriteLine("x && y: " + (x && y));

        // Increment Operator
        a++;
        Console.WriteLine("a++: " + a);

        // Decrement Operator
        b--;
        Console.WriteLine("b--: " + b);

        // Conditional (Ternary) Operator
        string result = (a > b) ? "a is greater" : "b is greater";
        Console.WriteLine(result);

        statementandloops f= new statementandloops();
        f.show();
    }
}