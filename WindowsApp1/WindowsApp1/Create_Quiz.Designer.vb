<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Quiz
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
        Me.lblCreateQuizMsg = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtQuizName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCreateQuizMsg
        '
        Me.lblCreateQuizMsg.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateQuizMsg.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCreateQuizMsg.Location = New System.Drawing.Point(170, 9)
        Me.lblCreateQuizMsg.Name = "lblCreateQuizMsg"
        Me.lblCreateQuizMsg.Size = New System.Drawing.Size(410, 86)
        Me.lblCreateQuizMsg.TabIndex = 0
        Me.lblCreateQuizMsg.Text = "Name the Quiz"
        Me.lblCreateQuizMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(34, 205)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(299, 170)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(460, 205)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(299, 170)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtQuizName
        '
        Me.txtQuizName.Location = New System.Drawing.Point(179, 98)
        Me.txtQuizName.Multiline = True
        Me.txtQuizName.Name = "txtQuizName"
        Me.txtQuizName.Size = New System.Drawing.Size(401, 92)
        Me.txtQuizName.TabIndex = 3
        '
        'Create_Quiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtQuizName)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblCreateQuizMsg)
        Me.Name = "Create_Quiz"
        Me.Text = "Name the Quiz"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCreateQuizMsg As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtQuizName As TextBox
End Class
