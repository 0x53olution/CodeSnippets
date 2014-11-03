Option Strict On
Option Explicit On

Imports org.pdfbox.pdmodel
Imports org.pdfbox.util

Public Class PdfBox

    'Das ist alles was gebraucht wird um mit den PDFBox dlls ein Doukment auszulesen
    Public Function ParseMyPdf(ByVal pdfPath As String) As String
        Dim document As PDDocument = Nothing
        Try
            document = PDDocument.load(pdfPath)
            Dim pdfStripper As New PDFTextStripper()
            Return pdfStripper.getText(document)
        Finally
            If document IsNot Nothing Then
                document.close()
            End If
        End Try
    End Function

End Class