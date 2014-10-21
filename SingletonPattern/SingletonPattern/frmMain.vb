'System.VisualBasic auskommentiert
Option Strict On
Option Explicit On

Public Class frmMain

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        Dim ersterWert = Singleton.Instance.PmstrTestStringOne

        Singleton.Instance.StringErweitern("Hallo Welt")

        Dim zweiterWert = Singleton.Instance.PmstrTestStringOne
    End Sub
End Class
