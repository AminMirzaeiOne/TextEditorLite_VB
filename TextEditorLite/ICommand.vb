Public Interface ICommand
    Function TextToExecute(TextExecute As String) As String

    Function TextToUndo(TextUndo As String) As String
End Interface
