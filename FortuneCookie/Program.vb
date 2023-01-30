Imports System
Imports System.Security.Cryptography

Module Program
    Sub Main()
        Dim fortune As String
        Dim userInput As String
        userInput = 1
        While userInput = 1
            Select Case Int((4 * Rnd()) + 1)
                Case "1"
                    fortune = "Keep your head high and your spirit as well, good things are coming."
                Case "2"
                    fortune = "Your wealth is going to take a drastic turn."
                Case "3"
                    fortune = "Random third thing."
                Case "4"
                    fortune = "Love and loss will forever find you"
                Case Else
                    Console.WriteLine("It's generating outside of random range")
            End Select

            Console.WriteLine($"{fortune}")
            Console.WriteLine("
")
            userInput = Console.ReadLine()
        End While
    End Sub

    Sub GeneratingRandomNumber(generated As Integer)

    End Sub

End Module
