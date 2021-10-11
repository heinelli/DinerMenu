<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DinerMenuForm
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
        Me.DinerNameLabel.Font = New System.Drawing.Font("Gabriola", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(152, 5)
        Me.DinerNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(269, 88)
        Me.DinerNameLabel.TabIndex = 0
        Me.DinerNameLabel.Text = "Tastes of Lisbon"
        Me.DinerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FishButton
        '
        Me.FishButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.FishButton.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishButton.Location = New System.Drawing.Point(420, 292)
        Me.FishButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(106, 82)
        Me.FishButton.TabIndex = 3
        Me.FishButton.Text = "Daily Fish"
        Me.FishButton.UseVisualStyleBackColor = False
        '
        'SaladButton
        '
        Me.SaladButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.SaladButton.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaladButton.Location = New System.Drawing.Point(236, 292)
        Me.SaladButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(99, 82)
        Me.SaladButton.TabIndex = 2
        Me.SaladButton.Text = "Salad"
        Me.SaladButton.UseVisualStyleBackColor = False
        '
        'SoupButton
        '
        Me.SoupButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.SoupButton.Font = New System.Drawing.Font("Gabriola", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SoupButton.Location = New System.Drawing.Point(39, 292)
        Me.SoupButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(99, 82)
        Me.SoupButton.TabIndex = 1
        Me.SoupButton.Text = "Soup"
        Me.SoupButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(532, 381)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(36, 22)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplaySpecialLabel.BackColor = System.Drawing.Color.Transparent
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Gabriola", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(-5, 102)
        Me.DisplaySpecialLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(572, 113)
        Me.DisplaySpecialLabel.TabIndex = 6
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DinerMenuForm
        '
        Me.AcceptButton = Me.FishButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(564, 402)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "DinerMenuForm"
        Me.Text = "Tastes of Lisbon Special Menu"
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
