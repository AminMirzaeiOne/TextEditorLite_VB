Public Class BackSpace
    Implements ICommand

    Private toBeRemovedChars As Integer

    Private OriginalString As String

    Public Sub New(toBeRemovedChars As Integer, originalString As String)
        Me.toBeRemovedChars = toBeRemovedChars
        Me.OriginalString = originalString
    End Sub

    Public Function TextToExecute(execute As String) As String Implements ICommand.TextToExecute
        If execute.Length >= toBeRemovedChars Or toBeRemovedChars <> 0 Then
            Return (execute.Remove((execute.Length) - (toBeRemovedChars), toBeRemovedChars))
        Else
            Return ($"Please enter a number below \n>>:{execute.Length}")
        End If
    End Function

    Public Function TextToUndo(undo As String) As String Implements ICommand.TextToUndo
        Return OriginalString.Substring(0, undo.Length + toBeRemovedChars)
    End Function

End Class
