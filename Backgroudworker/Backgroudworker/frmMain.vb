Public Class frmMain

    Dim WithEvents BGW As New System.ComponentModel.BackgroundWorker With {.WorkerReportsProgress = True, .WorkerSupportsCancellation = True}

    Private Sub Start() Handles cmdStart.Click
        If Not BGW.IsBusy Then
            Me.lblResult.Text = "Bitte warten..."
            Me.cmdStart.Enabled = False
            Me.cmdAbbrechen.Enabled = True
            Me.ProgressBar.Maximum = CInt(nudCount.Value)
            Me.ProgressBar.Value = 0
            BGW.RunWorkerAsync(CInt(nudCount.Value))
        End If
    End Sub

    Private Sub Cancel() Handles cmdAbbrechen.Click
        BGW.CancelAsync()
    End Sub

    Private Sub BGW_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGW.DoWork
        For i As Integer = 0 To CInt(e.Argument) - 1
            System.Threading.Thread.Sleep(10)
            BGW.ReportProgress(i)
            If BGW.CancellationPending Then
                Exit For
            End If
        Next
    End Sub

    Private Sub BGW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BGW.ProgressChanged
        ProgressBar.Value = e.ProgressPercentage + 1
    End Sub

    Private Sub BGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW.RunWorkerCompleted
        If e.Cancelled Then
            Me.lblResult.Text = "Vorgang abgebrochen"
        Else
            Me.lblResult.Text = "Vorgang abgeschlossen"
        End If
        Me.cmdAbbrechen.Enabled = False
        Me.cmdStart.Enabled = True
        Me.ProgressBar.Value = 0
    End Sub

    Private Sub Start(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click, cmdAbbrechen.Click

    End Sub
End Class
