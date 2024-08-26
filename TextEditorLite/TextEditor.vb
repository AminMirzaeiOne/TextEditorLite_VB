Public Class TextEditor
    Public currentText As String = ""

    ' To Store Undo Vars
    Private _pastText As String

    Private _usedCommands As List(Of ICommand) = New List(Of ICommand)()

    Public Sub New(currentText As String)
        Me.currentText = currentText
    End Sub

    Public Sub Undo()
        If _usedCommands.Count >= 1 Then
            currentText = _usedCommands(_usedCommands.Count - 1).TextToUndo(currentText)
            _usedCommands.RemoveAt(_usedCommands.Count - 1)
        Else
            Console.WriteLine("No more actions exist!! " & vbLf)
        End If
    End Sub

    Public Sub DisplayCurrentText()
        Console.WriteLine($"Current text is >> {currentText}")
    End Sub

    Public Sub ExecuteICommand(textAction As ICommand)
        _pastText = currentText
        currentText = textAction.TextToExecute(currentText)
        _usedCommands.Add(textAction)
    End Sub

    Public Sub DisplayProcessed()
        Console.WriteLine($"Processed Text >>{currentText}")
    End Sub


End Class
