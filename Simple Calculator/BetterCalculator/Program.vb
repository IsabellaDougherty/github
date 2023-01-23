

Imports System

Module Program
    Sub Main()
        Dim userInput As String
        Dim quit As Boolean = False

        Console.WriteLine("Please enter two numbers. Press 'Q' any time to quit.")
        While quit = False
            Dim first As Decimal
            Dim second As Decimal
            Dim answer As Decimal

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

            Dim validAnswer As Boolean = False

            While validAnswer = False
                Console.WriteLine("Plese choose one of the following:
1 Add
2 Subtract
3 Multiply
4 Divide")
            userInput = Console.ReadLine()

            Select Case userInput
                Case "Q"
                        quit = True
                        validAnswer = True
                    Case "1"
                    answer = first + second
                    Console.WriteLine($"You have chosen to add the two numbers {first} and {second}")
                        Console.WriteLine("The answer is " + answer)
                        validAnswer = True
                    Case "2"
                    answer = first - second
                    Console.WriteLine($"You have chosen to subtract {first} from {second}")
                        Console.WriteLine("The answer is " + answer)
                        validAnswer = True
                    Case "3"
                    answer = first * second
                    Console.WriteLine($"You have chosen to multiply {first} and {second}")
                        Console.WriteLine("The answer is " + answer)
                        validAnswer = True
                    Case "4"
                    answer = first / second
                    Console.WriteLine($"You have chosen to divide {first} from {second}")
                        Console.WriteLine("The answer is " + answer)
                        validAnswer = True
                    Case Else
                    Console.WriteLine($"You have entered {userInput}.")
            End Select
            End While
        End While
        Console.WriteLine("Have a great day!")
    End Sub
End Module
