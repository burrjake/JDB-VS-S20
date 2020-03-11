
Module RollOfTheDice
    Sub Main()

        Dim firstRoll As Integer
        Dim secondRoll As Integer
        Dim rollSum As Integer
        Dim diceArray(12, 2) As Integer
        For i = 1 To 1000

            'Roll dice
            Randomize()
            firstRoll = Int((Rnd() * 6) + 1)
            Randomize()
            secondRoll = Int((Rnd() * 6) + 1)
            'Add dice
            rollSum = firstRoll + secondRoll

            'Times rolled
            diceArray(rollSum, 2) += 1

            'Number between 2 and 12 rolled
            For j = 2 To 12
                diceArray(j, 1) = j
            Next

        Next

        'Write array
        Console.WriteLine("   Number Rolled    Times Rolled")
        For i = 2 To 12
            For j = 1 To 2
                Console.Write(diceArray(i, j).ToString().PadLeft(15) & "|")
            Next
            Console.WriteLine()
        Next

    End Sub
End Module
