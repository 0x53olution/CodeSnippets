'System.VisualBasic auskommentiert
Option Strict On
Option Explicit On

Public Class Singleton
    Private mstrTestStringOne As String = "nichts"

    Property PmstrTestStringOne As String
        Get
            Return mstrTestStringOne
        End Get
        Set(value As String)
            If value.Length > 5 Then
                value = "war zu groß"
                mstrTestStringOne = value
            Else
                mstrTestStringOne = value
            End If
        End Set
    End Property

    Public Sub StringErweitern(ByVal wert As String)
        PmstrTestStringOne = wert & " geht doch!"
    End Sub

    Private Shared mobjSingletonObject As Singleton

    Public Shared ReadOnly Property Instance() As Singleton
        Get
            If mobjSingletonObject Is Nothing Then
                mobjSingletonObject = New Singleton
            End If
            Return mobjSingletonObject
        End Get
    End Property

End Class
