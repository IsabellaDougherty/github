'Isabella Dougherty
'RCET0265
'Spring 2023
'Say My Name
'https://github.com/IsabellaDougherty/SayMyName.git

Imports System

Module Operators
    Sub Main()
        Dim name As String
        Console.WriteLine("What is your name?")
        name = Console.ReadLine()
        Console.WriteLine($"Hello {name}! Welcome to this program! I hope you have a wonderful day!
                                    Press Enter to close this window.")
        Console.ReadLine()
    End Sub
End Module