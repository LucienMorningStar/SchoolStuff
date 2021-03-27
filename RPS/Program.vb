Imports System

Module VBModule
    Sub Main()


        Dim Computer As String
        Dim Answer As String
        Dim MyValue As Integer


        Console.WriteLine("Choose either rock, paper or scissors")

        Answer = Console.ReadLine()

        MyValue = Int((3 * Rnd()) + 1)
        Console.WriteLine(MyValue)



            If MyValue = 1 Then
            Computer = "Rock"
        End If
        If MyValue = 2 Then
            Computer = "Scissors"
        End If
        If MyValue = 3 Then
            Computer = "Paper"
        End If

        If Answer = "Rock" And Computer = "Paper" Then
            Console.WriteLine("Paper Covers Rock: Computer Wins")

        ElseIf Answer = "Paper" And Computer = "Scissors" Then
            Console.WriteLine("Scissors Cuts Paper: Computer Wins")

        ElseIf Answer = "Scissors" And Computer = "Rock" Then
            Console.WriteLine("Rock Breaks Scissors: Computer Wins")

        ElseIf Computer = "Rock" And Answer = "Paper" Then
            Console.WriteLine("Paper Covers Rock: You Win ")

        ElseIf Computer = "Paper" And Answer = "Scissors" Then
            Console.WriteLine("Scissors Cuts Paper: You Win ")

        ElseIf Computer = "Scissors" And Answer = "Rock" Then
            Console.WriteLine("Rock Breaks Scissors: You Win ")

        ElseIf Computer = "Rock" And Answer = "Rock" Then
            Console.WriteLine(" TIE ")

        ElseIf Computer = "Paper" And Answer = "Paper" Then
            Console.WriteLine(" TIE ")

        ElseIf Computer = "Scissor" And Answer = "Scissor" Then
            Console.WriteLine(" TIE ")

        End If

    End Sub
End Module

