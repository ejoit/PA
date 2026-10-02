using System;
class Program
{
    static void Main()
    {
        // Input X
        Console.Write("Enter value for X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Input Y
        Console.Write("Enter value for Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Input Z
        Console.Write("Enter value for Z: ");
        double z = Convert.ToDouble(Console.ReadLine());

        // Process
        double sum = x + y + z;

        // Output
        Console.WriteLine("The sum is: " + sum);
        // Keep the console window open
        Console.ReadLine();
    }
}
