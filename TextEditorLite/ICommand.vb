Public Interface ICommand
    Function TextToExecute(execute As String) As String

    Function TextToUndo(undo As String) As String
End Interface
