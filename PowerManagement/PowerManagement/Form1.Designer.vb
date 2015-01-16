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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.chkIsActive = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(12, 50)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(93, 50)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'chkIsActive
        '
        Me.chkIsActive.AutoCheck = False
        Me.chkIsActive.AutoSize = True
        Me.chkIsActive.Location = New System.Drawing.Point(12, 27)
        Me.chkIsActive.Name = "chkIsActive"
        Me.chkIsActive.Size = New System.Drawing.Size(56, 17)
        Me.chkIsActive.TabIndex = 2
        Me.chkIsActive.Text = "Aktive"
        Me.chkIsActive.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(311, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 90)
        Me.Controls.Add(Me.chkIsActive)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(327, 128)
        Me.MinimumSize = New System.Drawing.Size(327, 128)
        Me.Name = "frmMain"
        Me.Text = "Power Management Hold"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents chkIsActive As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
