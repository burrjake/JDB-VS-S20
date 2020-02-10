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

        'greet user and tell user how to quit
        promptUser = True
        quitProgram = False
        Do While quitProgram = False
            Console.WriteLine("Please enter two numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit.")

            'prompt user to select two numbers
            Console.WriteLine("Choose a number")
            promptUser = True
            While promptUser = True
                userInput = Console.ReadLine()
                If userInput = "q" Then
                    promptUser = False
                    quitProgram = True
                    Console.WriteLine("You entered " & Chr(34) & "q" & Chr(34))
                    Console.WriteLine("Have a nice day")
                    Console.WriteLine("Press enter to close this window")
                    Console.ReadLine()
                    End

                    'display first number or prompt to enter a whole number
                Else
                    Try
                        promptUser = False
                        firstNumber = CInt(userInput)
                        Console.WriteLine("You entered " & Chr(34) & firstNumber & Chr(34))
                    Catch ex As Exception
                        Console.WriteLine("You entered " & Chr(34) & userInput & Chr(34) & ", please enter a whole number.")
                        promptUser = True
                    End Try
                End If
            End While
            promptUser = True

            '
            Console.WriteLine("Choose a number")
            promptUser = True
            While promptUser = True
                userInput = Console.ReadLine()

                'perform quit
                If userInput = "q" Then
                    quitProgram = True
                    Console.WriteLine("You entered " & Chr(34) & "q" & Chr(34))
                    Console.WriteLine("Have a nice day")
                    Console.WriteLine("Press enter to close this window")
                    Console.ReadLine()
                    End

                    'display second number or prompt to enter a whole number
                Else
                    Try
                        promptUser = False
                        secondNumber = CInt(userInput)
                        Console.WriteLine("You entered " & Chr(34) & secondNumber & Chr(34))
                    Catch ex As Exception
                        Console.WriteLine("You entered " & Chr(34) & userInput & Chr(34) & ", please enter a whole number.")
                        promptUser = True
                    End Try
                End If
            End While
            promptUser = True

            'promp user to select what math function is wanted
retryOptions:
            Console.WriteLine("Choose one Of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                userMessage = Console.ReadLine()

            'perform quit
            If userMessage = "q" Then
                quitProgram = True
                Console.WriteLine("You entered " & Chr(34) & "q" & Chr(34))
                Console.WriteLine("Have a nice day")
                Console.WriteLine("Press enter to close this window")
                Console.ReadLine()
                End

                'perform proper operation
            ElseIf userMessage = "1" Then
                Console.WriteLine(firstNumber & "+" & secondNumber & "=" & (firstNumber) + (secondNumber))
            ElseIf userMessage = "2" Then
                Console.WriteLine(firstNumber & "-" & secondNumber & "=" & (firstNumber) - (secondNumber))
            ElseIf userMessage = "3" Then
                Console.WriteLine(firstNumber & "*" & secondNumber & "=" & (firstNumber) * (secondNumber))
            ElseIf userMessage = "4" Then
                Console.WriteLine(firstNumber & "/" & secondNumber & "=" & (firstNumber) / (secondNumber))
            Else
                Console.WriteLine("You entered " & Chr(34) & userMessage & Chr(34))
                GoTo retryOptions
            End If
        Loop


    End Sub

End Module
