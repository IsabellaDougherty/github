Option Explicit On
'Option Strict On

Imports System

Module RandomNumber
    Sub Main()
        Dim _randomNumber As Integer
        Dim temp As Single

        Randomize() 'generates new randomization seed

        temp = Rnd()
        temp *= 6
        _randomNumber = Int(temp)
        Console.WriteLine(temp)
        Console.WriteLine(_randomNumber)
        For i = 0 To 10
            Console.WriteLine(RandomValue())
        Next
    End Sub

    Function RandomValue() As Integer
        Dim _randomNumber As Integer
        Dim rangeMax As Integer = 10

        Randomize()
        _randomNumber = Int(Rnd() * rangeMax)
        Return _randomNumber
    End Function

    Function RandomNumber() As Integer
        'Makes a variable equivalent to a random number (that appears as a decimal) multiplied by 100 and then with 1 add to give a range of random numbers
        'from 1 to 100
        Dim number As Integer = CInt(100 * Rnd() + 1)
        Return number
    End Function
End Module
