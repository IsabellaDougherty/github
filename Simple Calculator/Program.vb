Imports System

'Isabella Dougherty
'RCET0265
'Spring 2023
'Simple Calculator
Module Operations
    Sub Main()
        Dim first As Decimal
        Dim second As Decimal
        Dim answer As Decimal
        Dim action As String
        Console.WriteLine("Enter your first number: ")
        first = Console.ReadLine()
        Console.WriteLine("Enter your second number: ")
        second = Console.ReadLine()
        Console.WriteLine("Do you want a sum, difference, product, or quotient? ")
        action = Console.ReadLine()
        If action = "sum" Then answer = first + second
        If action = "product" Then answer = first * second
        If action = "difference" Then answer = first - second
        If action = "quotient" Then answer = first / second
        Console.WriteLine($"The solution is {answer}")
    End Sub
End Module
