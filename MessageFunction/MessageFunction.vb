Module MessageFunction

    Sub Main()
        UserMessages(True, "Hello 1", False)
        UserMessages(True, "Hello 2", False)
        UserMessages(True, "Hello 3", False)
        MsgBox(UserMessages(True, "", False))

    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String '= " "

        formattedMessages &= message & vbNewLine

        Return formattedMessages

    End Function

End Module
