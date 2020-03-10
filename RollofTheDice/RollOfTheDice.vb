
Module RollOfTheDice
    Sub Main()

        Dim firstRoll As Integer
        Dim secondRoll As Integer
        Dim rollSum As Integer
        Dim diceArray(12, 2) As Integer
        For i = 1 To 1000

            Randomize()
            firstRoll = Int((Rnd() * 6) + 1)
            If firstRoll = 7 Then
                Console.WriteLine("Error")
                Console.ReadLine()
            End If
            Randomize()
            secondRoll = Int((Rnd() * 6) + 1)
            If secondRoll = 7 Then
                Console.WriteLine("Error")
                Console.ReadLine()
            End If
            rollSum = firstRoll + secondRoll

            diceArray(rollSum, 2) += 1

            For j = 2 To 12
                diceArray(j, 1) = j
            Next

        Next

        For i = 2 To 12
            For j = 1 To 2
                Console.Write(diceArray(i, j).ToString().PadLeft(15) & "|")
            Next
        Next

    End Sub
End Module
