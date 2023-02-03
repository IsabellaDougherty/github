'Isabella Dougherty
'RCET0265
'Fall 2023
'Say My Name

Imports System

Module Program
    Sub Main()

        Console.WriteLine("Hello. What is your name?")
        Dim name As String = Console.ReadLine()

        If name = "Emily" Or name = "Joe" Then
            Console.WriteLine($"Welcome {name}! I hope you have a wonderful day!")
        ElseIf name = "Isabella" Or name = "Isabella Dougherty" Then
            Console.WriteLine("My creator has arrived. Please, fix me.")
        Else
            Console.WriteLine($"You are not welcome here {name}. Begone with you!")
            End Ifsd
    End Sub
End Module