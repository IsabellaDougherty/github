Option Strict On
Option Explicit On
Option Compare Text

Imports System

Module Program
    Sub Main(args As String())
        DoWhileExample()
    End Sub

    'Sub TryCatchExample()
    'Dim userNumber As Integer
    'Dim userInput As String
    '
    'Console.WriteLine("Enter a number between 1 and 10.")
    '    userInput = Console.ReadLine()
    '   Console.WriteLine($"You entered {userInput}!")
    'Try
    '       userNumber = CInt(userInput)
    'Catch ex As Exception
    '       Console.WriteLine($"You have entered {userInput}. This is not a number. Please input a number")
    'End Try
    '
    'Console.WriteLine(5 + userNumber)
    '
    '   End Sub

    Sub DoWhileExample()
        Dim runAgain As Boolean = True
        Dim userResponse As String
        Dim message As String = "Loop did not run"
        'evaluate expression prior to loop content
        While runAgain = True
            Console.WriteLine("Do you want to try agian? (Y/N)")
            userResponse = Console.ReadLine()
            Select Case userResponse
                Case "Y"
                    runAgain = True
                Case "N"
                    Console.WriteLine("Have a nice day!")
                    runAgain = False
                Case Else
                    Console.WriteLine("I'll take that as a no...")
                    runAgain = False
            End Select
        End While
    End Sub
End Module
