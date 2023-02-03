Imports System

Module Program
    Sub Main()
        IfExample()
    End Sub
    Sub IfExample()

        If 5 > 6 Then
            Console.WriteLine("In the first statement") '5 is not greater than 6 and since it's not true it will not run
        ElseIf 5 < 6 Then
            Console.WriteLine("In the second statement") '5 is less then 6 so the program will run this statement
        ElseIf 5 = 5 Then
            Console.WriteLine("If this line is being seen, RUN") 'If anything else in the If statement chain is true it should
            'skip the rest of them
        End If

    End Sub

    Sub ForNextExample()
        For i To 10
            Console.WriteLine(i)
        Next

    End Sub
End Module
