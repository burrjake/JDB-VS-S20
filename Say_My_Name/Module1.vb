'Jake Burrell
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/burrjake/JDB-VS-S20

Option Strict On
Option Explicit On
Module Module1

    Sub Main()
        Dim userMessage As String

        Console.WriteLine("Hello, what is your name?")
        userMessage = Console.ReadLine()
        Console.WriteLine("Hello, " & userMessage & " when you are done press enter.")
        Console.ReadLine()
    End Sub

End Module
