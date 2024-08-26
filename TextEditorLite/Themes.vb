Module Themes
    Public foreColor As ConsoleColor = ConsoleColor.White
    Public backColor As ConsoleColor = ConsoleColor.Black
    Public menuColor As ConsoleColor = ConsoleColor.DarkCyan
    Public titleColor As ConsoleColor = ConsoleColor.Red

    Public Sub QuestionForeColor()
startFore:

        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Write foreground color(Black - White - Red - Blue - Magenta - Green - Yellow) : ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim fore As String = Console.ReadLine().ToLower()
        System.Console.ResetColor()
        Select Case fore
            Case "black"
                foreColor = ConsoleColor.Black
            Case "white"
                foreColor = ConsoleColor.White
            Case "red"
                foreColor = ConsoleColor.Red
            Case "blue"
                foreColor = ConsoleColor.DarkCyan
            Case "magenta"
                foreColor = ConsoleColor.Magenta
            Case "green"
                foreColor = ConsoleColor.Green
            Case "yellow"
                foreColor = ConsoleColor.Yellow

            Case Else
                System.Console.ForegroundColor = ConsoleColor.White
                System.Console.BackgroundColor = ConsoleColor.Red
                System.Console.WriteLine("It is invalid")
                System.Console.ResetColor()
                System.Console.ReadKey()
                GoTo startFore
        End Select
    End Sub

    Public Sub QuestionBackColor()
startBack:

        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Write background color(Black - White - Red - Blue - Magenta - Green - Yellow) : ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim back As String = Console.ReadLine().ToLower()
        System.Console.ResetColor()
        Select Case back
            Case "black"
                backColor = ConsoleColor.Black
            Case "white"
                backColor = ConsoleColor.White
            Case "red"
                backColor = ConsoleColor.Red
            Case "blue"
                backColor = ConsoleColor.DarkCyan
            Case "magenta"
                backColor = ConsoleColor.Magenta
            Case "green"
                backColor = ConsoleColor.Green
            Case "yellow"
                backColor = ConsoleColor.Yellow

            Case Else
                System.Console.ForegroundColor = ConsoleColor.White
                System.Console.BackgroundColor = ConsoleColor.Red
                System.Console.WriteLine("It is invalid")
                System.Console.ResetColor()
                System.Console.ReadKey()
                GoTo startBack
        End Select
    End Sub

    Public Sub QuestionMenuColor()
startMenu:

        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Write menu color(Black - White - Red - Blue - Magenta - Green - Yellow) : ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim menu As String = Console.ReadLine().ToLower()
        System.Console.ResetColor()
        Select Case menu
            Case "black"
                menuColor = ConsoleColor.Black
            Case "white"
                menuColor = ConsoleColor.White
            Case "red"
                menuColor = ConsoleColor.Red
            Case "blue"
                menuColor = ConsoleColor.DarkCyan
            Case "magenta"
                menuColor = ConsoleColor.Magenta
            Case "green"
                menuColor = ConsoleColor.Green
            Case "yellow"
                menuColor = ConsoleColor.Yellow

            Case Else
                System.Console.ForegroundColor = ConsoleColor.White
                System.Console.BackgroundColor = ConsoleColor.Red
                System.Console.WriteLine("It is invalid")
                System.Console.ResetColor()
                System.Console.ReadKey()
                GoTo startMenu
        End Select
    End Sub

    Public Sub QuestionTitleColor()
startTitle:

        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Write title color(Black - White - Red - Blue - Magenta - Green - Yellow) : ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim title As String = Console.ReadLine().ToLower()
        System.Console.ResetColor()
        Select Case title
            Case "black"
                titleColor = ConsoleColor.Black
            Case "white"
                titleColor = ConsoleColor.White
            Case "red"
                titleColor = ConsoleColor.Red
            Case "blue"
                titleColor = ConsoleColor.DarkCyan
            Case "magenta"
                titleColor = ConsoleColor.Magenta
            Case "green"
                titleColor = ConsoleColor.Green
            Case "yellow"
                titleColor = ConsoleColor.Yellow

            Case Else
                System.Console.ForegroundColor = ConsoleColor.White
                System.Console.BackgroundColor = ConsoleColor.Red
                System.Console.WriteLine("It is invalid")
                System.Console.ResetColor()
                System.Console.ReadKey()
                GoTo startTitle
        End Select
    End Sub


End Module
