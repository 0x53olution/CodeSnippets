Public Class frmMain

    Private _cancel As Boolean

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click

        chkIsActive.Checked = True
        _cancel = False

        PowerManager.PowerSaveOff()

        Do Until _cancel = True
            My.Application.DoEvents()
        Loop

        PowerManager.PowerSaveOn()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        chkIsActive.Checked = False
        _cancel = True
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _cancel = True
        chkIsActive.Checked = False
    End Sub
End Class