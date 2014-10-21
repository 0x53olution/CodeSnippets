<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.nudCount = New System.Windows.Forms.NumericUpDown()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.cmdAbbrechen = New System.Windows.Forms.Button()
        CType(Me.nudCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(138, 69)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'nudCount
        '
        Me.nudCount.Location = New System.Drawing.Point(12, 72)
        Me.nudCount.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudCount.Name = "nudCount"
        Me.nudCount.Size = New System.Drawing.Size(120, 20)
        Me.nudCount.TabIndex = 1
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(282, 23)
        Me.ProgressBar.TabIndex = 2
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(12, 38)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(16, 13)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "..."
        '
        'cmdAbbrechen
        '
        Me.cmdAbbrechen.Location = New System.Drawing.Point(219, 69)
        Me.cmdAbbrechen.Name = "cmdAbbrechen"
        Me.cmdAbbrechen.Size = New System.Drawing.Size(75, 23)
        Me.cmdAbbrechen.TabIndex = 4
        Me.cmdAbbrechen.Text = "Abbrechen"
        Me.cmdAbbrechen.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 114)
        Me.Controls.Add(Me.cmdAbbrechen)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.nudCount)
        Me.Controls.Add(Me.cmdStart)
        Me.Name = "frmMain"
        Me.Text = "Backgroundworker"
        CType(Me.nudCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents nudCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents cmdAbbrechen As System.Windows.Forms.Button

End Class
