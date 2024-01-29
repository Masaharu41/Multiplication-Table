'Owen Fujii
'RCET 2265
'Spring 2024
'Multiplication Table
'https://github.com/Masaharu41/Multiplication-Table.git

Option Explicit On
Option Strict On

Module MultiplicationTable

    Sub Main()
        Dim currentValue As Integer
        Dim currentString As String
        Dim userInput As String
        Dim arraySpecs As Integer
        Console.Writeline("Input what number you would like for your multiplication table")
        userInput = Console.Readline()
        Try
            arraySpecs = CInt(userInput)
        Catch ex As Exception
            Console.Writeline("Please input an Integer")
        End Try
        currentValue = Console.Read()
        For row = 0 To arraySpecs
            currentValue = row * arraySpecs
            For column = 0 To arraySpecs
                currentValue = row + column
                currentString = CStr(currentValue) & "|"
                currentString = currentString.Padleft(6)
                Console.write(currentString)
            Next
            Console.Writeline()
            Console.Writeline(StrDup(66, "-"))
        Next
        Console.read()
    End Sub

End Module
