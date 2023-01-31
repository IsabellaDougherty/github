Option Explicit On
Option Infer On
Option Strict Off
Option Compare Text


Imports System
Imports System.Linq.Expressions
Imports System.Reflection.Metadata.Ecma335
Imports System.Transactions

Module Program
    Sub Main()

        'Initiate all variables
        Dim userInput As String 'contains last user input string
        Dim quit As Boolean = False
        Dim isValidNumber = False
        Dim validAnswer As Boolean = False
        Dim first As Integer
        Dim second As Integer
        Dim answer As Decimal

        Console.WriteLine("Please enter two numbers. Press 'Q' any time to quit.")

        'Do until the user quits
        Do Until quit
            Console.WriteLine("Choose a Number: ")
            Do
                userInput = Console.ReadLine()
                isValidNumber = False
                'Compares user's input to the letter Q to check for the user wanting to quit
                If userInput = "Q" And validAnswer = False Then
                    Console.WriteLine($"You have selected 'Q'.")
                    quit = True
                    isValidNumber = True
                    validAnswer = True
                Else
                    Try
                        first = userInput
                        first = CDec(first)
                        isValidNumber = True
                    Catch ex As Exception
                        Console.WriteLine("Please enter a valid number.")
                    End Try


                End If
            Loop Until isValidNumber Or quit

            Do
                isValidNumber = False
                If validAnswer = False Then
                    Console.WriteLine("Choose a Number: ")
                    userInput = Console.ReadLine()
                    If userInput = "Q" And validAnswer = False Then
                        Console.WriteLine($"You have selected 'Q'.")
                        quit = True
                        validAnswer = True
                    Else
                        Try
                            second = userInput
                            second = CDec(second)
                            isValidNumber = True
                        Catch ex As Exception
                            Console.WriteLine("Please enter a valid number.")
                        End Try
                    End If
                End If
            Loop Until isValidNumber



            While validAnswer = False
                Console.WriteLine("Plese choose one of the following:
1 Add
2 Subtract
3 Multiply
4 Divide")
                userInput = Console.ReadLine()
                If quit = False Then
                    Select Case userInput
                        Case "Q"
                            quit = True
                            validAnswer = True
                        Case "1"
                            answer = first + second

                            Console.WriteLine($"You have chosen to add the two numbers {first} and {second}")
                            Console.WriteLine($"The answer is {answer}")
                            validAnswer = True
                        Case "2"
                            answer = first - second
                            Console.WriteLine($"You have chosen to subtract {first} from {second}")
                            Console.WriteLine($"The answer is {answer}")
                            validAnswer = True
                        Case "3"
                            answer = first * second
                            Console.WriteLine($"You have chosen to multiply {first} and {second}")
                            Console.WriteLine($"The answer is {answer}")
                            validAnswer = True
                        Case "4"
                            answer = first / second
                            Console.WriteLine($"You have chosen to divide {first} from {second}")
                            Console.WriteLine($"The answer is {answer}")
                            validAnswer = True
                        Case Else
                            Console.WriteLine($"You have entered {userInput}.")
                    End Select
                ElseIf quit = True Then

                End If
            End While

        Loop
        Console.Clear()
        Console.WriteLine("Have a great day!")
    End Sub
End Module
