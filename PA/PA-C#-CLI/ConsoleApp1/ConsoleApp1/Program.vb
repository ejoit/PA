Imports System

Module Program
    Sub Main()

        'Input X
        Console.Write("Enter value for X: ")
        Dim x As Double = Convert.ToDouble(Console.ReadLine())

        'Input Y
        Console.Write("Enter value for Y: ")
        Dim y As Double = Convert.ToDouble(Console.ReadLine())

        'Input Z
        Console.Write("Enter value for Z: ")
        Dim z As Double = Convert.ToDouble(Console.ReadLine())

        'Process
        Dim sum As Double = x + y + z

        'Output
        Console.WriteLine("The sum is: " & sum)

        'Keep the console window open
        Console.ReadLine()

    End Sub

End Module
