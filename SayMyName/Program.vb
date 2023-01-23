Imports System
Imports System.ComponentModel.Design
Imports System.Net.Security
Imports System.Reflection
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
        If name = "Emily" Then
            Console.WriteLine("Hello" & " " & name)
        ElseIf name = "Joe" Then
            Console.WriteLine("Hello" & " " & name)
        ElseIf name = "Baden" Then
            Console.WriteLine("you think you are really clever HUH")
        Else
            Console.WriteLine("mwahahaha, muwhahaha, muahahaha, bwahahaha")
        End If

    End Sub
End Module
