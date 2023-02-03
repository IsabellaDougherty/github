'Isabella Dougherty
'RCET0265
'Spring 2023 
'Multiplication Tables
'https://github.com/IsabellaDougherty/github.git

Option Explicit On

Imports System
Module MultiplicationTables

    Sub Main()
        ' Get user input for number
        Console.Write("Enter a number: ")
        Dim num As Integer = Console.ReadLine()

        ' Display multiplication table
        Console.WriteLine("Multiplication Table:")
        For i As Integer = 1 To num
            For j As Integer = 1 To num
                Console.Write(String.Format("{0, 4}", i * j))
            Next
            Console.WriteLine()
        Next
    End Sub

End Module



