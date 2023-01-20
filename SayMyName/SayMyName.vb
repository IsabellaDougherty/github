
Module Program
    Sub Main()

        Console.WriteLine("Hello. What is your name?")
        Dim name As String = Console.ReadLine()

        If name = "Emily" Or "Joe" Then
            Console.WriteLine($"Welcome {name}! I hope you have a wonderful day!")
        ElseIf name = "Isabella" Or "Isabella Dougherty" Then
            Console.WriteLine("My creator has arrived. Please, fix me.")
        Else
            Console.WriteLine($"You are not welcome here {name}. Begone with you!")
        End If

    End Sub

End Module