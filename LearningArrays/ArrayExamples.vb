Imports System

Module ArrayExamples
    Sub Main()
        Dim simpleArray(4) As String

        simpleArray(0) = "Tim"
        simpleArray(1) = "Chris"
        simpleArray(2) = "Josh"
        simpleArray(3) = "Baden"
        simpleArray(4) = "Isabella"

        For i = LBound(simpleArray) To UBound(simpleArray)
            Console.WriteLine(simpleArray(i))
        Next
        Console.WriteLine("

")
        Bounds()
        Console.WriteLine("

")
        DeclareWithData()
    End Sub

    Sub Bounds()
        Dim fruits(5) As String

        fruits(0) = "Apple"
        fruits(1) = "Banana"
        fruits(2) = "Orange"
        fruits(3) = "Plum"
        fruits(4) = "Strawberry"
        fruits(5) = "Tomato"

        For i = LBound(fruits) To UBound(fruits)
            Console.WriteLine(fruits(i))
        Next
    End Sub

    Sub DeclareWithData()
        Dim tracker(9) As Boolean
        tracker(3) = True

        Dim values() = New Integer() {5, 6, 7, 8, 9, 2, 4, 7, 2, 3, 6, 1, 6}

        Dim grid(4, 4) As Boolean
        grid(2, 4) = True

        Dim square = New Integer(,) {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        ReDim square(4, 4)

        For i = LBound(tracker) To UBound(tracker)
            Console.WriteLine(tracker(i))
        Next
        Console.WriteLine("

")
        For i = LBound(grid) To UBound(grid)
            For x = LBound(grid) To UBound(grid)
                Console.WriteLine(grid(i, x))
            Next
        Next
        Console.WriteLine("

")
        For i = LBound(square) To UBound(square)
            For x = LBound(square) To UBound(square)
                Console.WriteLine(square(i, x))
            Next
        Next
    End Sub

End Module
