'Jake Burrell
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/burrjake/JDB-VS-S20

Option Strict On
Option Explicit On
Option Compare Text
Module Module1

    Sub Main()
        'ask user "What's your name?"
        'then display the message for the appropriate user 

        Dim userMessage As String

        Console.WriteLine("What's your name?")
        userMessage = Console.ReadLine()
        If userMessage = "Jake" Then
            Console.WriteLine("Welcome back, creator.")
        ElseIf userMessage = "Emily" Then
            Console.WriteLine("Hello, Emily when you are done press enter.")
        ElseIf userMessage = "Joe" Then
            Console.WriteLine("Hello, Joe when you are done press enter.")
        Else
            Console.WriteLine("Sorry, I do not recognize you. Press enter when you are done.")
        End If

        Console.ReadLine()
    End Sub

End Module
