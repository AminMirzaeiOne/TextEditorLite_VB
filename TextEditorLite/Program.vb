Module Program

    Sub Main()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Black
        Console.BackgroundColor = ConsoleColor.DarkCyan
        Dim logo = "Text Editor | v1.0 - AminMirzaeiOne"
        Console.SetCursorPosition((Console.WindowWidth - logo.Length) / 2, Console.CursorTop)
        Console.WriteLine(logo)


        Console.WriteLine("   Enter Your Current Text   " & vbLf)
        Console.Write(">>:")
        Dim initialUserInput As String = Console.ReadLine()
        Dim myTextEditor As TextEditor = New TextEditor(initialUserInput)


        While True
            Console.SetCursorPosition((Console.WindowWidth - logo.Length) / 2, Console.CursorTop)
            Console.WriteLine(logo)
            Console.WriteLine(vbLf & "Enter your preference" & vbLf)
            Console.WriteLine("[1] Add " & vbLf & "[2] Clear " & vbLf & "[3] Remove " & vbLf & "[4] Undo" & vbLf & "[5] Exit" & vbLf & vbLf)
            Console.Write(">>:")

            Dim userOption As String = Console.ReadLine()


            If Equals("1", userOption) Then
#Region "Single Operation"

                Console.Clear()

                ' Getting User Input to Add and Constructing Append Class Instance
                Console.WriteLine("You Selected to Add String to Current Text" & vbLf & "Please Enter the Text" & vbLf)
                Dim textToAdd As String = Console.ReadLine()
                Dim onGoingAppend As Append = New Append(textToAdd)

                ' Calling Methods from TextEditor Class
                myTextEditor.ExecuteICommand(onGoingAppend)
                myTextEditor.DisplayProcessed()
                Console.WriteLine(vbLf & "Please Press Any key to Continue....")
                Console.ReadKey()
                Console.Clear()

#End Region
                myTextEditor.DisplayCurrentText()

            ElseIf Equals("2", userOption) Then
#Region "Single Operation"

                Console.Clear()

                ' Getting User Input to Add and Constructing Append Class Instance
                Console.WriteLine("You Selected to Add String to Current Text" & vbLf & "Please Enter the Text" & vbLf)
                Dim clear As Clear = New Clear(myTextEditor.currentText)

                ' Calling Methods from TextEditor Class
                myTextEditor.ExecuteICommand(clear)
                myTextEditor.DisplayProcessed()
                Console.WriteLine(vbLf & "Please Press Any key to Continue....")
                Console.ReadKey()
                Console.Clear()

#End Region
                myTextEditor.DisplayCurrentText()
            ElseIf Equals("3", userOption) Then
#Region "Single Operation"

                Console.Clear()

                ' Getting User Input to Add and Constructing Append Class Instance
                Console.WriteLine("You Selected to Remove String to Current Text" & vbLf & "Please Enter the number of text to remove" & vbLf)
                Dim indexToRemove As String = Console.ReadLine()
                Dim toRemove As BackSpace = New BackSpace(Integer.Parse(indexToRemove), myTextEditor.currentText)

                ' Calling Methods from TextEditor Class
                myTextEditor.ExecuteICommand(toRemove)
                myTextEditor.DisplayProcessed()
                Console.WriteLine(vbLf & "Please Press Any key to Continue....")
                Console.ReadKey()
                Console.Clear()

#End Region
                myTextEditor.DisplayCurrentText()

            ElseIf Equals("4", userOption) Then
                Console.Clear()
                myTextEditor.Undo()
                Console.WriteLine(vbLf & "Please Press Any key to Continue....")
                Console.ReadKey()
                Console.Clear()
                myTextEditor.DisplayCurrentText()

            ElseIf Equals("5", userOption) Then
                Console.ReadKey()
                Environment.Exit(0)
            End If
        End While
    End Sub

End Module
