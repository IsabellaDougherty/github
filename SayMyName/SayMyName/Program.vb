Imports System

'Isabella Dougherty
'RCET0265
'Spring 2023
'Say My Name
'https://github.com/IsabellaDougherty/SayMyName.git


Module Operators
    Sub Main()
        Dim name As String
        Console.WriteLine("What is your name?")
        name = Console.ReadLine()
        If name = "Emily" Then Console.WriteLine("Hello Emily! Welcome to this program! I hope you have a wonderful day!")
        If name = "Joe" Then Console.WriteLine("Hello Jow! Welcome to this program! I hope you have a wonderful day!")
        If name = "Isabella" Then Console.WriteLine("My creator has appeared. Please fix me") Else Console.WriteLine("You are not allowed here")
        Console.WriteLine("Press Enter to exit the menu.")
        Console.ReadLine()
    End Sub
End Module