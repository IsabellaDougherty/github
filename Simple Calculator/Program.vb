Imports System

'Isabella Dougherty
'RCET0265
'Spring 2023
'Simple Calculator
Module Operations
    Sub Main()
        'Initiating Variables
        Dim first As Decimal
        Dim second As Decimal
        Dim answer As Decimal
        Dim viable As Boolean
        Dim action As String

        'Gathering User Inputs and assigning inputs to variables
        Console.WriteLine("Enter your first number: ")
        first = Console.ReadLine()

        Console.WriteLine("Enter your second number: ")
        second = Console.ReadLine()

        Console.WriteLine("Do you want a sum, difference, product, or quotient?
Please use all lowercase and spell your response")
        action = Console.ReadLine()

        'The following takes the inputs and uses If Then Else statements to determine what function was chosen then calculates
        If action = "sum" Then
            answer = first + second
            viable = True

        ElseIf action = "product" Then
            answer = first * second
            viable = True

        ElseIf action = "difference" Then
            answer = first - second

        ElseIf action = "quotient" Then
            answer = first / second
            viable = True

        Else
            Console.WriteLine("The input value is innaplicable")
            viable = False
        End If

        Console.WriteLine()

        'Checks to see if a calculation was actually made
        'The simplified as will round the decimal value of a quotient to the nearest whole.
        'Outputs the answer
        If viable Then
            Console.WriteLine($"The solution is {answer}, simplified as {CInt(answer)}")
        Else
            Console.WriteLine("You have input an invalid action, make sure you only use lower case letters and spell the
action exactly as shown above")
        End If
    End Sub
End Module
