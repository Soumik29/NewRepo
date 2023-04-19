<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.WelcomeMsg = New System.Windows.Forms.Label()
        Me.btnCreateQuiz = New System.Windows.Forms.Button()
        Me.btnTryQuiz = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WelcomeMsg
        '
        Me.WelcomeMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeMsg.ForeColor = System.Drawing.Color.SpringGreen
        Me.WelcomeMsg.Location = New System.Drawing.Point(113, 55)
        Me.WelcomeMsg.Name = "WelcomeMsg"
        Me.WelcomeMsg.Size = New System.Drawing.Size(547, 78)
        Me.WelcomeMsg.TabIndex = 0
        Me.WelcomeMsg.Text = "Welcome to the quiz application program, what would you like to do?"
        Me.WelcomeMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCreateQuiz
        '
        Me.btnCreateQuiz.BackColor = System.Drawing.Color.Yellow
        Me.btnCreateQuiz.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateQuiz.ForeColor = System.Drawing.Color.Green
        Me.btnCreateQuiz.Location = New System.Drawing.Point(91, 234)
        Me.btnCreateQuiz.Name = "btnCreateQuiz"
        Me.btnCreateQuiz.Size = New System.Drawing.Size(165, 102)
        Me.btnCreateQuiz.TabIndex = 1
        Me.btnCreateQuiz.Text = "Create Quiz"
        Me.btnCreateQuiz.UseVisualStyleBackColor = False
        '
        'btnTryQuiz
        '
        Me.btnTryQuiz.BackColor = System.Drawing.Color.Yellow
        Me.btnTryQuiz.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTryQuiz.ForeColor = System.Drawing.Color.Green
        Me.btnTryQuiz.Location = New System.Drawing.Point(316, 234)
        Me.btnTryQuiz.Name = "btnTryQuiz"
        Me.btnTryQuiz.Size = New System.Drawing.Size(165, 102)
        Me.btnTryQuiz.TabIndex = 2
        Me.btnTryQuiz.Text = "Try Quiz"
        Me.btnTryQuiz.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnExit.Location = New System.Drawing.Point(555, 234)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(165, 102)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTryQuiz)
        Me.Controls.Add(Me.btnCreateQuiz)
        Me.Controls.Add(Me.WelcomeMsg)
        Me.Name = "MainForm"
        Me.Text = "Quiz Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WelcomeMsg As Label
    Friend WithEvents btnCreateQuiz As Button
    Friend WithEvents btnTryQuiz As Button
    Friend WithEvents btnExit As Button
End Class
