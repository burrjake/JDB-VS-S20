﻿'Jake Burrell
'RCET0265
'Spring 2020
'Simple Calculator
'https://github.com/burrjake/JDB-VS-S20

Option Strict On
Option Explicit On
Option Compare Text
Module SimpleCalculator

    Sub Main()
        Console.WriteLine("Welcome to the simple calculator.")
        Console.WriteLine("Press enter when you are ready to start.")
        Console.ReadLine()

        'prompt user for two numbers
        Console.WriteLine("Enter the first number.")

        Dim firstNumber As String
        Dim secondNumber As String

        firstNumber = Console.ReadLine()

        Console.WriteLine("Enter the second number.")
        secondNumber = Console.ReadLine()

        'prompt user to add or multiply
        Console.WriteLine("Do you want to add or multiply?")
        Dim userMessage As String
        userMessage = Console.ReadLine()

        'perform proper operation
        If userMessage = "add" Then
            Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))
        ElseIf userMessage = "+" Then
            Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))
        ElseIf userMessage = "multiply" Then
            Console.WriteLine(CInt(firstNumber) * CInt(secondNumber))
        ElseIf userMessage = "x" Then
            Console.WriteLine(CInt(firstNumber) * CInt(secondNumber))
        ElseIf userMessage = "*" Then
            Console.WriteLine(CInt(firstNumber) * CInt(secondNumber))
        Else
            Console.WriteLine("Sorry that is not a valid option.")
        End If
        'display answer

        Console.WriteLine("Press enter when finished.")
        Console.ReadLine()
    End Sub

End Module
