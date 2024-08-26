Imports System.Windows.Input

Public Class Append
    Implements ICommand

    Private _toAppend As String

    Private tempVar As Integer

    Public Sub New(toStore As String)
        Me._toAppend = toStore
        Me.tempVar = _toAppend.Length
    End Sub

    Public Function TextToExecute(execute As String) As String Implements ICommand.TextToExecute
        Return execute = execute + _toAppend
    End Function

    Public Function TextToUndo(undo As String) As String Implements ICommand.TextToUndo
        Return undo.Remove(undo.Length - tempVar, tempVar)
    End Function
End Class
