Option Strict On
Option Explicit On

Imports System.Text.RegularExpressions

Public Class Parser

    Public Function ParseMyString(ByVal input As String) As String()

        'Dim ausgabe(1) As String
        'Das Suchpattern wurde vor der impelemntierung mit RegEx-Lab getestet
        Dim filterPattern As String = "#{2}K((\d*):(\S*))#VF:(\S*)#HF:(\S*)#{2}"

        Dim collectionOfMatches As MatchCollection
        'In der collectionOfMatches werden alle gefunden Matches gespeichert.
        collectionOfMatches = Regex.Matches(input, filterPattern, RegexOptions.IgnoreCase)

        'Ausgabearray passend dimensionieren
        Dim ausgabe(collectionOfMatches.Count - 1) As String

        Dim i As Integer = 0
        For Each Match In collectionOfMatches
            ausgabe(i) = "Kennzahl-Nr.: " & collectionOfMatches(i).Groups(2).ToString & " Kennzahl: " & collectionOfMatches(i).Groups(3).ToString & _
                " Vordergrundfarbe: " & collectionOfMatches(i).Groups(4).ToString & " Hintergrundfarbe: " & collectionOfMatches(i).Groups(5).ToString
            i = i + 1
        Next

        Return ausgabe
    End Function
End Class
