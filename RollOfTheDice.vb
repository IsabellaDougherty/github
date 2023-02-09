'Isabella Dougherty
'RCET0265
'Spring 2023
'Roll of the Dice
'https://github.com/IsabellaDougherty/github/tree/master


Imports System

Module RollOfTheDice
    Sub Main()
        Dim count(1000, 1000) As Integer
        Dim proxyCount As Integer
        Dim proxyRolls As Integer
        Dim random As New Random()
        Dim roll As Integer

        For i = 0 To 999
            proxyCount += 1
            count(i, 0) = proxyCount
            roll = random.Next(1, 6)
            proxyRolls += roll
            roll = random.Next(1, 6)
            proxyRolls += roll
            count(i, 1) = proxyRolls
        Next

        Console.WriteLine("~Random Rolls~")
        For i = 0 To 999
            For j = 0 To 1
                Console.Write(count(i, j) & " | ")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
