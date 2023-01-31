'Isabella Dougherty
'RCET0265
'Spring 2023
'Fortune Cookie
'https://github.com/IsabellaDougherty/github.git


Option Explicit On


Imports System

Module FortuneCookie
    Sub Main()
        Dim random As Integer
        Randomize()
            random = CInt(Math.Round(Rnd() * 10))
        Select Case random
            Case 0
                Console.WriteLine("Good things come to those who wait.")
            Case 1
                Console.WriteLine("Your future is full of possibilities.")
            Case 2
                Console.WriteLine("Your good deeds will be rewarded with success and happiness.")
            Case 3
                Console.WriteLine("Believe in yourself and all that you are. Know that there is something inside you that is greater than any obstacle.")
            Case 4
                Console.WriteLine("Happiness is a warm smile and a kind heart.")
            Case 5
                Console.WriteLine("You will find success in unexpected places.")
            Case 6
                Console.WriteLine("Stay focused and never give up on your dreams.")
            Case 7
                Console.WriteLine("Your hard work and determination will pay off.")
            Case 8
                Console.WriteLine("The path to success is always under construction.")
            Case 9
                Console.WriteLine("Trust in the journey, not just the destination.")
            Case 10
                Console.WriteLine("The greatest reward for a person's toil is not what they get for it, but what they become by it.")
            Case Else
                Console.WriteLine("A value outside of 0 through 10 was called")
        End Select
    End Sub
End Module
