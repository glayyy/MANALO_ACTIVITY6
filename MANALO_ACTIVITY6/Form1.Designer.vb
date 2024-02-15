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
        Label1 = New Label()
        txt1stNum = New TextBox()
        Label2 = New Label()
        txt2ndNum = New TextBox()
        btndivide = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 0
        Label1.Text = "1st NUMBER:"
        ' 
        ' txt1stNum
        ' 
        txt1stNum.BackColor = SystemColors.GradientInactiveCaption
        txt1stNum.Location = New Point(112, 12)
        txt1stNum.Name = "txt1stNum"
        txt1stNum.Size = New Size(131, 23)
        txt1stNum.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 0
        Label2.Text = "2nd NUMBER:"
        ' 
        ' txt2ndNum
        ' 
        txt2ndNum.BackColor = SystemColors.GradientInactiveCaption
        txt2ndNum.Location = New Point(112, 54)
        txt2ndNum.Name = "txt2ndNum"
        txt2ndNum.Size = New Size(131, 23)
        txt2ndNum.TabIndex = 2
        ' 
        ' btndivide
        ' 
        btndivide.BackColor = SystemColors.MenuHighlight
        btndivide.Location = New Point(27, 95)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(75, 23)
        btndivide.TabIndex = 3
        btndivide.Text = "DIVIDE"
        btndivide.UseVisualStyleBackColor = False
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.BackColor = SystemColors.ButtonHighlight
        lblResult.Location = New Point(150, 99)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(54, 15)
        lblResult.TabIndex = 3
        lblResult.Text = "ANSWER"
        ' 
        ' Form1
        ' 
        AcceptButton = btndivide
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(btndivide)
        Controls.Add(txt2ndNum)
        Controls.Add(Label2)
        Controls.Add(txt1stNum)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt1stNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt2ndNum As TextBox
    Friend WithEvents btndivide As Button
    Friend WithEvents lblResult As Label
End Class
