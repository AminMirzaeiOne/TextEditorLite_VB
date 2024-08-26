Public Class Clear
    Implements ICommand

    Private previousText As String

    Public Sub New(value As String)
        Me.previousText = value
    End Sub

    Public Function TextToExecute(execute As String) As String Implements ICommand.TextToExecute
        previousText = execute
        Return ""
    End Function

    Public Function TextToUndo(undo As String) As String Implements ICommand.TextToUndo
        Return previousText
    End Function
End Class
