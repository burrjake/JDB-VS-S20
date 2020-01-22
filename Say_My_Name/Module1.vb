'Jake Burrell
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/burrjake/JDB-VS-S20

Option Strict On
Option Explicit On
Module Module1

    Sub Main()
        'ask user "What's your name?"
        'then display the message 

        Dim userMessage As String

        Console.WriteLine("What's your name?")
        userMessage = Console.ReadLine()
        Console.WriteLine("Hello, " & userMessage & " when you are done press enter.")
        Console.ReadLine()
    End Sub

End Module
