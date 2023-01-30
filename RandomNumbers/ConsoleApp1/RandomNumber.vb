Imports System

Module RandomNumber
    Sub Main()
        Dim number As Integer
        Dim userInput As Integer
        While userInput = 1
            number = RandomNumber()
            Console.WriteLine(number)
            userInput = Console.ReadLine()
        End While
    End Sub

    Function RandomNumber() As Integer
        'Makes a variable equivalent to a random number (that appears as a decimal) multiplied by 100 and then with 1 add to give a range of random numbers
        'from 1 to 100
        Dim number As Integer = CInt(100 * Rnd() + 1)
    End Function
End Module
