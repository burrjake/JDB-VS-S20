Imports System

Module RollOfTheDice
    Sub Main()

        Dim firstRoll As Integer
        Dim secondRoll As Integer
        Dim rollSum As Integer
        'Dim diceArray(3, 1000) As Integer
        'For i = 1 To 1000

        Randomize()
            firstRoll = ((Rnd() * 6) + 1)
            Console.WriteLine(firstRoll)
            Randomize()
            secondRoll = ((Rnd() * 6) + 1)
        Console.WriteLine(secondRoll)
        rollSum = firstRoll + secondRoll
            Console.WriteLine(rollSum)
            Console.ReadLine()

        'Next
    End Sub
End Module
