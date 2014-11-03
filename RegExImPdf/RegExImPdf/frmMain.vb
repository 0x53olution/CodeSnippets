Option Explicit On
Option Strict On

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PDF Dokumenetenpfad
        Dim pdfDocumentPath As String = IO.Path.GetFullPath(Application.StartupPath) & "\Testdokument.pdf"

        'Per PDFBox das PDF Dokument einlesen
        Dim ReadPdf As New PdfBox
        Dim pdfString = ReadPdf.ParseMyPdf(pdfDocumentPath)

        'String aus PDF Parsen
        Dim MyParser As New Parser
        Dim ausgabe = MyParser.ParseMyString(pdfString)

        'Ausgabe der gelesenen Strings
        For i = 0 To ausgabe.Length - 1
            lblResult.Text = lblResult.Text & " " & ausgabe(i)
        Next

    End Sub
End Class
