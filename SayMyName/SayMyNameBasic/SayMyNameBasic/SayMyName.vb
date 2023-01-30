'Isabella Dougherty
'RCET0265
'Spring 2023
'Say My Name
'https://github.com/IsabellaDougherty/SayMyName.git

'Makes it so string inputs will compare capital and lower case letters
Option Compare Text
Option Explicit On
Option Strict On

Imports System
'Initiates the program
Module SayMyName
    'Initiates the Sub Main
    Sub Main()
        'Initiate variable for the person's name
        Dim name As String
        'Asks what the user's name is
        Console.WriteLine("What is you rname?")
        'Sets the user's input to the name variable
        name = Console.ReadLine()
        'Greets the user to the program
        Console.WriteLine($"Hello {name} welcome to this program. Have a wonderful day!")
        'Ends the sub main
    End Sub
    'Ends the module/program
End Module
