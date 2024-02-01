'Owen Fujii
'RCET 2265
'Spring 2024
'Multiplication Table
'https://github.com/Masaharu41/Multiplication-Table.git

Option Explicit On
Option Strict On

Module MultiplicationTable

    Sub Main()
        'define variables
        Dim currentValue As Integer
        Dim currentString As String
        Dim userInput As String
        Dim arraySpecs As Integer
        'code for user set table
        Console.WriteLine("Input what number you would like for your multiplication table")
        'trycatch to only allow integer values for array
        Do
            userInput = Console.ReadLine()
            Try
                arraySpecs = CInt(userInput)
                Exit Do
            Catch ex As Exception
                Console.WriteLine("Please input an Integer")
            End Try
        Loop
        Console.WriteLine($"Enjoy your {arraySpecs} x {arraySpecs} Multiplication Table")
        currentValue = arraySpecs
        'builds the array based upon the user set value. array includes dividers for columns and rows
        For row = 0 To arraySpecs
            currentValue = row * arraySpecs
            For column = 0 To arraySpecs
                currentValue = row + column
                currentString = CStr(currentValue) & "|"
                currentString = currentString.PadLeft(6)
                Console.Write(currentString)
            Next
            Console.WriteLine()
            Console.WriteLine(StrDup(arraySpecs * 6 + 6, "-"))
        Next
        Console.Read()
    End Sub

End Module
