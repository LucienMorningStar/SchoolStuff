Imports System

Module VBModule

    Sub Main()


        Dim Computer As Integer
        Dim Answer As String
        Dim MyValue As Integer
        Dim Grid(9) As String


        For y = 0 To 9
            Grid(y) = "-"
        Next



        While True
            DisplayGrid(Grid)
            MakeMove(Grid, "x")

            DisplayGrid(Grid)
            MakeMove(Grid, "o")
        End While

        DisplayGrid(Grid)






    End Sub

    Sub DisplayGrid(Grid As String())

        Console.WriteLine("       |     |       ")
        Console.WriteLine("    " & Grid(0) & "  |  " & Grid(1) & "  |  " & Grid(2) & "    ")
        Console.WriteLine("  _____|_____|_____  ")
        Console.WriteLine("       |     |       ")
        Console.WriteLine("    " & Grid(3) & "  |  " & Grid(4) & "  |  " & Grid(5) & "    ")
        Console.WriteLine("  _____|_____|_____  ")
        Console.WriteLine("       |     |       ")
        Console.WriteLine("    " & Grid(6) & "  |  " & Grid(7) & "  |   " & Grid(8) & "   ")
        Console.WriteLine("       |     |       ")





    End Sub

    Sub MakeMove(Grid As String(), Player As String)



        Console.WriteLine("What Index do you want your O to be place?")


        Dim Index As Integer = Console.ReadLine()
        If Index > 9 Then
            Console.WriteLine("Enter a valid Index")
        End If



        Grid(Index - 1) = Player


    End Sub


End Module