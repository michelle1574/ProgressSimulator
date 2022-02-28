<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buttonadditionalactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.resetstops = New System.Windows.Forms.CheckBox()
        Me.stopresets = New System.Windows.Forms.CheckBox()
        Me.startbuttonresets = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'resetstops
        '
        Me.resetstops.AutoSize = True
        Me.resetstops.Location = New System.Drawing.Point(12, 58)
        Me.resetstops.Name = "resetstops"
        Me.resetstops.Size = New System.Drawing.Size(221, 17)
        Me.resetstops.TabIndex = 13
        Me.resetstops.Text = "Przycisk Reset zatrzymuje pasek postępu"
        Me.resetstops.UseVisualStyleBackColor = True
        '
        'stopresets
        '
        Me.stopresets.AutoSize = True
        Me.stopresets.Location = New System.Drawing.Point(12, 35)
        Me.stopresets.Name = "stopresets"
        Me.stopresets.Size = New System.Drawing.Size(203, 17)
        Me.stopresets.TabIndex = 12
        Me.stopresets.Text = "Przycisk Stop resetuje pasek postępu"
        Me.stopresets.UseVisualStyleBackColor = True
        '
        'startbuttonresets
        '
        Me.startbuttonresets.AutoSize = True
        Me.startbuttonresets.Location = New System.Drawing.Point(12, 12)
        Me.startbuttonresets.Name = "startbuttonresets"
        Me.startbuttonresets.Size = New System.Drawing.Size(203, 17)
        Me.startbuttonresets.TabIndex = 11
        Me.startbuttonresets.Text = "Przycisk Start resetuje pasek postępu"
        Me.startbuttonresets.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Anuluj"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(151, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'buttonadditionalactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 114)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.resetstops)
        Me.Controls.Add(Me.stopresets)
        Me.Controls.Add(Me.startbuttonresets)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "buttonadditionalactions"
        Me.Text = "Dodatkowe akcje przycisków"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents resetstops As System.Windows.Forms.CheckBox
    Friend WithEvents stopresets As System.Windows.Forms.CheckBox
    Friend WithEvents startbuttonresets As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
