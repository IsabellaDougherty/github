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
    End Sub

    Function RandomNumber() As Integer
        'Makes a variable equivalent to a random number (that appears as a decimal) multiplied by 100 and then with 1 add to give a range of random numbers
        'from 1 to 100
        Dim number As Integer = CInt(100 * Rnd() + 1)
    End Function
End Module
