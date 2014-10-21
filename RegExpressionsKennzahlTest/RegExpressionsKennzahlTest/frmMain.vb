'Microsoft.VisualBasic auskommentiert
Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

Public Class frmMain
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        Dim Kennzahl = txtEingabe.Text
        KennzahlTest(Kennzahl)
    End Sub

    Private Sub KennzahlTest(ByVal kennzahl As String)
        Dim KennzahlString As String = String.Empty
        If String.IsNullOrEmpty(kennzahl) Then
            KennzahlString = String.Empty
        ElseIf Regex.IsMatch(kennzahl, "[%]") Then
            If String.IsNullOrEmpty(Regex.Match(kennzahl, "(\d+(\.|\,)\d+)|\d+", RegexOptions.Compiled).ToString) Then : KennzahlString = "?%"
            Else : KennzahlString = Regex.Match(kennzahl, "(\d+(\.|\,)\d+)|\d+", RegexOptions.Compiled).ToString & "%"
            End If
        ElseIf Regex.IsMatch(kennzahl, "[-]{2}|[!]{2}") Then
            KennzahlString = Regex.Match(kennzahl, "[-]{2}|[!]{2}").ToString
        ElseIf Regex.IsMatch(kennzahl, "(\d+(\.|\,)\d+)|\d+", RegexOptions.Compiled) Then
            KennzahlString = Regex.Match(kennzahl, "(\d+(\.|\,)\d+)|\d+", RegexOptions.Compiled).ToString
        Else
            KennzahlString = "??"
        End If

        lblResult.Text = KennzahlString & " Zeichenanzahl: " & KennzahlString.Length

        '### Beschreibung ###
        'Mögliche Ausgaben:
        ' -- bedeutet: Dokument kann nicht gefunden werden
        ' !! bedeutet: Tabellenblatt kann nicht gefunden werden
        ' ?? bedeutet: Keine Gültige Eingabe
        ' ?% bedeutet: Keine Kennzahl vor dem %-Zeichen
        ' 90,00%
        ' 90%
        ' 90,00
        ' 90

    End Sub
End Class
