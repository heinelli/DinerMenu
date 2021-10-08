<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DinerMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Location = New System.Drawing.Point(421, 9)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(171, 25)
        Me.DinerNameLabel.TabIndex = 0
        Me.DinerNameLabel.Text = "Tastes of Lisbon"
        Me.DinerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(911, 599)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(198, 157)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "Daily Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(693, 600)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(198, 157)
        Me.SaladButton.TabIndex = 3
        Me.SaladButton.Text = "Salad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'SoupButton
        '
        Me.SoupButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.SoupButton.Location = New System.Drawing.Point(474, 599)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(198, 157)
        Me.SoupButton.TabIndex = 4
        Me.SoupButton.Text = "Soup"
        Me.SoupButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(29, 726)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(83, 29)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.AutoSize = True
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(162, 108)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(77, 25)
        Me.DisplaySpecialLabel.TabIndex = 6
        Me.DisplaySpecialLabel.Text = "Label1"
        '
        'DinerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 769)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Name = "DinerMenu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents FishButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents SoupButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplaySpecialLabel As Label
End Class
