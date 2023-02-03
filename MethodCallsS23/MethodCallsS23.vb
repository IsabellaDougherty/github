'Option Strict On
'Option Explicit On

Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main()
        Dim firstMath As Decimal
        Dim secondMath As Decimal
        Console.WriteLine("Please enter your first value (numbers only): ")
        firstMath = Console.ReadLine()
        Console.WriteLine("Please enter your second value (numbers only): ")
        secondMath = Console.ReadLine()

        'Sub runs code and/or performs a task
        Console.WriteLine("These added equals: ")
        AddNumbers(firstMath, secondMath)
        Console.WriteLine("These multiplied equals: ")
        ProductOf(firstMath, secondMath)
        Console.WriteLine("These subtracted equals: ")
        DifferenceOf(firstMath, secondMath)
        Console.WriteLine("These divided equals: ")
        QuotientOf(firstMath, secondMath)


        Console.WriteLine()
        Console.WriteLine("The following is random stuff for notes: ")
        Console.WriteLine(DoMath())
        DoMath()

        'print first CMD line argument
        'Try
        'Console.WriteLine(args(0))
        'Catch ex As Exception
        'Console.WriteLine("Yeah no, you're gonna crash the thing dingus -_- ")
        'End Try
        'Console.ReadLine()


    End Sub
    Sub AddNumbers(first As Decimal, second As Decimal)
        Console.WriteLine(first + second)
    End Sub

    'Function must return something otherwise it will break. 
    Function DoMath() As Integer
        Console.WriteLine(2 + 2)
        Return 3
    End Function

    'numericOne and numericTwo can be used as the name in all of them cause the value in a different
    'sub is a different variable on its own that is localized to that sub
    Sub ProductOf(numericOne As Integer, numericTwo As Integer)
        Console.WriteLine(numericOne * numericTwo)
    End Sub

    Sub DifferenceOf(numericOne As Integer, numericTwo As Integer)
        Console.WriteLine(numericOne - numericTwo)
    End Sub

    Sub QuotientOf(numericOne As Integer, numericTwo As Integer)
        Console.WriteLine(numericOne / numericTwo)
    End Sub

End Module
