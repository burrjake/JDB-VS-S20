'Jake Burrell
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

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userMessage As String
        Dim quitProgram As Boolean
        Dim promptUser As Boolean

        promptUser = True
        quitProgram = False

        Do While quitProgram = False

            'prompt user for two numbers
            Console.WriteLine("Enter the first number.")

            While promptUser = True
                Try
                    promptUser = False
                    firstNumber = CInt(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Please, enter a whole number.")
                    promptUser = True
                End Try
            End While

            Console.WriteLine("Enter the second number.")
            promptUser = True
            While promptUser = True
                Try
                    promptUser = False
                    secondNumber = CInt(Console.ReadLine())
                Catch ex As Exception
                    Console.WriteLine("Please, enter a whole number.")
                    promptUser = True
                End Try
            End While

            'prompt user to add or multiply
            Console.WriteLine("Do you want to add or multiply?")
            userMessage = Console.ReadLine()

            'perform proper operation
            If userMessage = "add" Then
                Console.WriteLine((firstNumber) + (secondNumber))
            ElseIf userMessage = "+" Then
                Console.WriteLine((firstNumber) + (secondNumber))
            ElseIf userMessage = "plus" Then
                Console.WriteLine(firstNumber + secondNumber)
            ElseIf userMessage = "multiply" Then
                Console.WriteLine((firstNumber) * (secondNumber))
            ElseIf userMessage = "x" Then
                Console.WriteLine((firstNumber) * (secondNumber))
            ElseIf userMessage = "times" Then
                Console.WriteLine((firstNumber) * (secondNumber))
            ElseIf userMessage = "*" Then
                Console.WriteLine((firstNumber) * (secondNumber))
            Else
                Console.WriteLine("Sorry that is not a valid option.")
            End If
            'display answer

            Console.WriteLine("Press Enter to run, again. Enter Q to quit")
            If Console.ReadLine() = "q" Then
                quitProgram = True
            Else
                quitProgram = False
            End If
            Console.Clear()
        Loop
    End Sub

End Module
