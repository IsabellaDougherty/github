Imports System
Imports System.Linq.Expressions

Module Operators
    Sub Main()
        'Writes a string that says 5+5=
        Console.Write("5 + 5 = ")
        'Use the console to add 5 + 5
        Console.WriteLine(5 + 5)
        'Adds a blank line
        Console.WriteLine()
        'Example of muliplication
        Console.Write("5 * 5 = ")
        Console.WriteLine(5 * 5)
        Console.WriteLine()
        'Example of exponent use
        Console.Write("5 to the power of 2 = ")
        Console.WriteLine(5 ^ 2)
        Console.WriteLine()
        'Two examples of division, can use a forward or backwards slash
        Console.Write("5 / 2 = ")
        Console.WriteLine(5 / 2)
        Console.WriteLine()
        Console.Write("5 \ 2 = ")
        Console.WriteLine(5 \ 2)
        Console.WriteLine()
        'example of a Mod operator
        Console.Write("5 Mod 2 = ")
        Console.WriteLine(5 Mod 2)
        Console.WriteLine()

        'String concationation
        Console.WriteLine("apple" & " " & "banana")
        Console.WriteLine()

        'Comparison Operators
        'Returns a boolean for whether values are true or false
        Console.Write("Is 5 Greater Than 6? ")
        Console.WriteLine(5 > 6)
        Console.WriteLine()
        Console.Write("Is 5 Less Than 6? ")
        Console.WriteLine(5 < 6)
        Console.WriteLine()
        Console.Write("Is 5 equal to 6? ")
        Console.WriteLine(5 = 6)
        Console.WriteLine()
        'First value is not equal to the second value
        Console.Write("Is 5 not 6? ")
        Console.WriteLine(5 <> 6)
        Console.WriteLine()

        'Assignment Operators
        Dim num As Integer
        Dim fruit As String
        num = 5
        If (num = 5) Then fruit = "apple"
        Console.WriteLine("You have selected " & fruit & " which corrolates to the number " & Str(num))
        'Number sign indicates the string will have variables inside it
        Console.WriteLine($"You have {num} {fruit}(s)")
        Console.WriteLine()
        Console.WriteLine("What is your favorite Fruit? Hit 'enter' when complete! ")
        fruit = Console.ReadLine() 'Wait for user response here
        Console.WriteLine($"You have entered your favorite fruit as {fruit}!")
    End Sub

End Module
