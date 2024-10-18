<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        nameLabel = New Label()
        ageLabel = New Label()
        resultLabel = New Label()
        SuspendLayout()
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Location = New Point(45, 54)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(41, 21)
        nameLabel.TabIndex = 0
        nameLabel.Text = "Label1"
        nameLabel.UseCompatibleTextRendering = True
        ' 
        ' ageLabel
        ' 
        ageLabel.AutoSize = True
        ageLabel.Location = New Point(105, 54)
        ageLabel.Name = "ageLabel"
        ageLabel.Size = New Size(41, 21)
        ageLabel.TabIndex = 1
        ageLabel.Text = "Label1"
        ageLabel.UseCompatibleTextRendering = True
        ' 
        ' resultLabel
        ' 
        resultLabel.AutoSize = True
        resultLabel.Location = New Point(163, 54)
        resultLabel.Name = "resultLabel"
        resultLabel.Size = New Size(41, 21)
        resultLabel.TabIndex = 2
        resultLabel.Text = "Label1"
        resultLabel.UseCompatibleTextRendering = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(resultLabel)
        Controls.Add(ageLabel)
        Controls.Add(nameLabel)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents resultLabel As Label
End Class
