'Jake Burrell
'RCET0265
'Spring 2020
'Accumulate Messages Function
'https://github.com/burrjake/JDB-VS-S20

Module MessageFunction

    Sub Main()
        ' UserMessages(True, "Hello 1", False)
        'UserMessages(True, "Hello 2", False)
        'UserMessages(True, "Hello 3", False)
        'MsgBox(UserMessages(True, "", False))
        TestUserMessages()
        Console.ReadLine()


    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String

        formattedMessages &= message & vbNewLine

        Return formattedMessages

    End Function

    Sub TestUserMessages()
        Dim evaluate As String
        Dim control As String
        Dim testString As String
        Dim testCounter As Integer

        For i = 1 To 5
            testString = "Test " & Str(i)

            control = testString & vbNewLine

        evaluate = UserMessages(True, testString, False)

        If evaluate = control Then
            Console.WriteLine("Test 1 Pass")
        Else
            Console.WriteLine("Test 1 FAIL")
            Console.WriteLine("Expected:" & vbNewLine & control)
            Console.WriteLine("Actual:" & vbNewLine & evaluate)
        End If

    End Sub
End Module
