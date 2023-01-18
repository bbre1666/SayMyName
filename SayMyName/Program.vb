Imports System
Imports System.Net.Security
'Baden Brenner
'RCET0265
'Spring 2023
'Say My Name
'https://github.com/bbre1666/SayMyName.git

Module Program
    Sub Main(args As String())

        Console.WriteLine("Hello What Is your Name")

        Dim name As String

        name = Console.ReadLine()

        Console.WriteLine("hello" & " " & name)

    End Sub
End Module
