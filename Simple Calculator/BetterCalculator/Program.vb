

Imports System

Module Program
    Sub Main()
        Dim userInput As String
        Dim first As Decimal
        Dim second As Decimal
        Dim quit As Boolean = False

        Console.WriteLine("Please enter two numbers. Press 'Q' any time to quit.")
        While quit = False
            Console.WriteLine("Choose a Number: ")
            userInput = Console.ReadLine()
            If userInput = "Q" Then
                quit = True
                Console.WriteLine($"You have selected 'Q'.")
            Else
                first = userInput
            End If

            Console.WriteLine("Choose a Number: ")
            userInput = Console.ReadLine()
            If userInput = "Q" Then
                quit = True
                Console.WriteLine($"You have selected 'Q'.")
            Else
                second = userInput
            End If

            Console.WriteLine("Choose one of the following:
1 Add
2 Subtract
3 Multiply
4 Divide")
            userInput = Console.ReadLine()


        End While
        Console.WriteLine("Have a great day!")
    End Sub
End Module
