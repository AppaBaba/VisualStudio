<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.FNum = New System.Windows.Forms.TextBox
        Me.SNum = New System.Windows.Forms.TextBox
        Me.ANum = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.AddButton = New System.Windows.Forms.Button
        Me.SubButton = New System.Windows.Forms.Button
        Me.MulButton = New System.Windows.Forms.Button
        Me.DivButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'FNum
        '
        Me.FNum.Location = New System.Drawing.Point(12, 69)
        Me.FNum.Name = "FNum"
        Me.FNum.Size = New System.Drawing.Size(100, 20)
        Me.FNum.TabIndex = 0
        '
        'SNum
        '
        Me.SNum.Location = New System.Drawing.Point(12, 106)
        Me.SNum.Name = "SNum"
        Me.SNum.Size = New System.Drawing.Size(100, 20)
        Me.SNum.TabIndex = 1
        '
        'ANum
        '
        Me.ANum.Location = New System.Drawing.Point(12, 143)
        Me.ANum.Name = "ANum"
        Me.ANum.Size = New System.Drawing.Size(100, 20)
        Me.ANum.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Answer"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(3, 202)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "Addition"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'SubButton
        '
        Me.SubButton.Location = New System.Drawing.Point(84, 202)
        Me.SubButton.Name = "SubButton"
        Me.SubButton.Size = New System.Drawing.Size(75, 23)
        Me.SubButton.TabIndex = 7
        Me.SubButton.Text = "Subtraction"
        Me.SubButton.UseVisualStyleBackColor = True
        '
        'MulButton
        '
        Me.MulButton.Location = New System.Drawing.Point(165, 202)
        Me.MulButton.Name = "MulButton"
        Me.MulButton.Size = New System.Drawing.Size(75, 23)
        Me.MulButton.TabIndex = 8
        Me.MulButton.Text = "Multiplication"
        Me.MulButton.UseVisualStyleBackColor = True
        '
        'DivButton
        '
        Me.DivButton.Location = New System.Drawing.Point(247, 201)
        Me.DivButton.Name = "DivButton"
        Me.DivButton.Size = New System.Drawing.Size(75, 23)
        Me.DivButton.TabIndex = 9
        Me.DivButton.Text = "Division"
        Me.DivButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 264)
        Me.Controls.Add(Me.DivButton)
        Me.Controls.Add(Me.MulButton)
        Me.Controls.Add(Me.SubButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ANum)
        Me.Controls.Add(Me.SNum)
        Me.Controls.Add(Me.FNum)
        Me.Name = "Form1"
        Me.Text = "Calculate Two Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FNum As System.Windows.Forms.TextBox
    Friend WithEvents SNum As System.Windows.Forms.TextBox
    Friend WithEvents ANum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents SubButton As System.Windows.Forms.Button
    Friend WithEvents MulButton As System.Windows.Forms.Button
    Friend WithEvents DivButton As System.Windows.Forms.Button

End Class
