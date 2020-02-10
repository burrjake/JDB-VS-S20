'Jake Burrell
'RCET0265
'Spring 2020
'Better Calculator
'https://github.com/burrjake/JDB-VS-S20

Option Strict On
Option Explicit On
Option Compare Text
Module BetterCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userMessage As String
        Dim quitProgram As Boolean
        Dim promptUser As Boolean
        Dim userInput As String

        promptUser = True
        quitProgram = False
        Do While quitProgram = False
            Console.WriteLine("Please enter two numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit.")

            Console.WriteLine("Choose a number")
                While promptUser = True
                    Try
                    promptUser = False
                    userInput = Console.ReadLine()
                    firstNumber = CInt(userInput)
                    Console.WriteLine("You entered " & Chr(34) & firstNumber & Chr(34))
                Catch ex As Exception
                    Console.WriteLine("You entered " & Chr(34) & userInput & Chr(34) & ", please enter a whole number.")
                    promptUser = True
                    End Try
            End While
            promptUser = True

            Console.WriteLine("Choose a number")
                promptUser = True
                While promptUser = True
                    Try
                    promptUser = False
                    userInput = Console.ReadLine()
                    secondNumber = CInt(userInput)
                    Console.WriteLine("You entered " & Chr(34) & firstNumber & Chr(34))
                    Catch ex As Exception
                    Console.WriteLine("You entered " & Chr(34) & userInput & Chr(34) & ", please enter a whole number.")
                    promptUser = True
                    End Try
                End While
            promptUser = True

            Console.WriteLine("Choose one Of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                userMessage = Console.ReadLine()

                If userMessage = "1" Then
                Console.WriteLine(firstNumber & "+" & secondNumber & "=" & (firstNumber) + (secondNumber))
            ElseIf userMessage = "2" Then
                Console.WriteLine(firstNumber & "-" & secondNumber & "=" & (firstNumber) - (secondNumber))
            ElseIf userMessage = "3" Then
                Console.WriteLine(firstNumber & "*" & secondNumber & "=" & (firstNumber) * (secondNumber))
            ElseIf userMessage = "4" Then
                Console.WriteLine(firstNumber & "/" & secondNumber & "=" & (firstNumber) / (secondNumber))
            Else
                    Console.WriteLine("You entered" & Chr(34) & userMessage & Chr(34))
                End If
            Loop


    End Sub

End Module
