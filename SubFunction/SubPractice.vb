Option Strict On
Option Explicit On

Module SubPractice

    Sub Main()
        Dim number As Integer
        number = 7
        number += 2
        Console.WriteLine("In Sub Main")
        MySub()
        MyFunc()
    End Sub

    Sub MySub()
        Console.WriteLine("In Sub Main")
    End Sub

    Function MyFunc() As Integer
        Console.WriteLine("In My Fun")
    End Function
End Module
