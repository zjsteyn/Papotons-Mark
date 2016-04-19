<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOnlyatend
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
        Me.CheckBoxMSMarks = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMSaudiofeedback = New System.Windows.Forms.CheckBox()
        Me.ButtonMSNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelStep3Feedback = New System.Windows.Forms.Panel()
        Me.LabelVar4 = New System.Windows.Forms.Label()
        Me.NUDS3Pron = New System.Windows.Forms.NumericUpDown()
        Me.NUDS3Replies = New System.Windows.Forms.NumericUpDown()
        Me.NUDFormulation = New System.Windows.Forms.NumericUpDown()
        Me.NUDS3Listen = New System.Windows.Forms.NumericUpDown()
        Me.LabelVar1 = New System.Windows.Forms.Label()
        Me.LabelVar2 = New System.Windows.Forms.Label()
        Me.Labelvar3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelStep3Feedback.SuspendLayout()
        CType(Me.NUDS3Pron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDS3Replies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDFormulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDS3Listen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBoxMSMarks
        '
        Me.CheckBoxMSMarks.AutoSize = True
        Me.CheckBoxMSMarks.Location = New System.Drawing.Point(107, 308)
        Me.CheckBoxMSMarks.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxMSMarks.Name = "CheckBoxMSMarks"
        Me.CheckBoxMSMarks.Size = New System.Drawing.Size(106, 17)
        Me.CheckBoxMSMarks.TabIndex = 0
        Me.CheckBoxMSMarks.Text = "Grade responses"
        Me.CheckBoxMSMarks.UseVisualStyleBackColor = True
        Me.CheckBoxMSMarks.Visible = False
        '
        'CheckBoxMSaudiofeedback
        '
        Me.CheckBoxMSaudiofeedback.AutoSize = True
        Me.CheckBoxMSaudiofeedback.Location = New System.Drawing.Point(107, 342)
        Me.CheckBoxMSaudiofeedback.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxMSaudiofeedback.Name = "CheckBoxMSaudiofeedback"
        Me.CheckBoxMSaudiofeedback.Size = New System.Drawing.Size(125, 17)
        Me.CheckBoxMSaudiofeedback.TabIndex = 1
        Me.CheckBoxMSaudiofeedback.Text = "Give audio feedback"
        Me.CheckBoxMSaudiofeedback.UseVisualStyleBackColor = True
        Me.CheckBoxMSaudiofeedback.Visible = False
        '
        'ButtonMSNext
        '
        Me.ButtonMSNext.Location = New System.Drawing.Point(374, 121)
        Me.ButtonMSNext.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMSNext.Name = "ButtonMSNext"
        Me.ButtonMSNext.Size = New System.Drawing.Size(147, 43)
        Me.ButtonMSNext.TabIndex = 2
        Me.ButtonMSNext.Text = "Next"
        Me.ButtonMSNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 272)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose at least one feedback option"
        Me.Label1.Visible = False
        '
        'PanelStep3Feedback
        '
        Me.PanelStep3Feedback.Controls.Add(Me.LabelVar4)
        Me.PanelStep3Feedback.Controls.Add(Me.NUDS3Pron)
        Me.PanelStep3Feedback.Controls.Add(Me.NUDS3Replies)
        Me.PanelStep3Feedback.Controls.Add(Me.NUDFormulation)
        Me.PanelStep3Feedback.Controls.Add(Me.NUDS3Listen)
        Me.PanelStep3Feedback.Controls.Add(Me.LabelVar1)
        Me.PanelStep3Feedback.Controls.Add(Me.LabelVar2)
        Me.PanelStep3Feedback.Controls.Add(Me.Labelvar3)
        Me.PanelStep3Feedback.Location = New System.Drawing.Point(127, 43)
        Me.PanelStep3Feedback.Name = "PanelStep3Feedback"
        Me.PanelStep3Feedback.Size = New System.Drawing.Size(198, 212)
        Me.PanelStep3Feedback.TabIndex = 49
        '
        'LabelVar4
        '
        Me.LabelVar4.AutoSize = True
        Me.LabelVar4.Location = New System.Drawing.Point(56, 151)
        Me.LabelVar4.Name = "LabelVar4"
        Me.LabelVar4.Size = New System.Drawing.Size(98, 13)
        Me.LabelVar4.TabIndex = 48
        Me.LabelVar4.Text = "Pronunciation (_/2)"
        '
        'NUDS3Pron
        '
        Me.NUDS3Pron.Location = New System.Drawing.Point(49, 167)
        Me.NUDS3Pron.Name = "NUDS3Pron"
        Me.NUDS3Pron.Size = New System.Drawing.Size(106, 20)
        Me.NUDS3Pron.TabIndex = 4
        '
        'NUDS3Replies
        '
        Me.NUDS3Replies.Location = New System.Drawing.Point(49, 78)
        Me.NUDS3Replies.Name = "NUDS3Replies"
        Me.NUDS3Replies.Size = New System.Drawing.Size(106, 20)
        Me.NUDS3Replies.TabIndex = 2
        '
        'NUDFormulation
        '
        Me.NUDFormulation.Location = New System.Drawing.Point(49, 123)
        Me.NUDFormulation.Name = "NUDFormulation"
        Me.NUDFormulation.Size = New System.Drawing.Size(106, 20)
        Me.NUDFormulation.TabIndex = 3
        '
        'NUDS3Listen
        '
        Me.NUDS3Listen.Location = New System.Drawing.Point(49, 37)
        Me.NUDS3Listen.Name = "NUDS3Listen"
        Me.NUDS3Listen.Size = New System.Drawing.Size(106, 20)
        Me.NUDS3Listen.TabIndex = 1
        '
        'LabelVar1
        '
        Me.LabelVar1.AutoSize = True
        Me.LabelVar1.Location = New System.Drawing.Point(62, 17)
        Me.LabelVar1.Name = "LabelVar1"
        Me.LabelVar1.Size = New System.Drawing.Size(75, 13)
        Me.LabelVar1.TabIndex = 24
        Me.LabelVar1.Text = "Listening (_/1)"
        '
        'LabelVar2
        '
        Me.LabelVar2.AutoSize = True
        Me.LabelVar2.Location = New System.Drawing.Point(65, 62)
        Me.LabelVar2.Name = "LabelVar2"
        Me.LabelVar2.Size = New System.Drawing.Size(68, 13)
        Me.LabelVar2.TabIndex = 47
        Me.LabelVar2.Text = "Replies (_/2)"
        '
        'Labelvar3
        '
        Me.Labelvar3.AutoSize = True
        Me.Labelvar3.Location = New System.Drawing.Point(56, 107)
        Me.Labelvar3.Name = "Labelvar3"
        Me.Labelvar3.Size = New System.Drawing.Size(87, 13)
        Me.Labelvar3.TabIndex = 46
        Me.Labelvar3.Text = "Formulation (_/2)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Please provide overall feedback on question / conerstaion items"
        '
        'FormOnlyatend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 362)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelStep3Feedback)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonMSNext)
        Me.Controls.Add(Me.CheckBoxMSaudiofeedback)
        Me.Controls.Add(Me.CheckBoxMSMarks)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormOnlyatend"
        Me.Text = "Overall Feedbac"
        Me.PanelStep3Feedback.ResumeLayout(False)
        Me.PanelStep3Feedback.PerformLayout()
        CType(Me.NUDS3Pron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDS3Replies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDFormulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDS3Listen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBoxMSMarks As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMSaudiofeedback As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonMSNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelStep3Feedback As Panel
    Friend WithEvents LabelVar4 As Label
    Friend WithEvents NUDS3Pron As NumericUpDown
    Friend WithEvents NUDS3Replies As NumericUpDown
    Friend WithEvents NUDFormulation As NumericUpDown
    Friend WithEvents NUDS3Listen As NumericUpDown
    Friend WithEvents LabelVar1 As Label
    Friend WithEvents LabelVar2 As Label
    Friend WithEvents Labelvar3 As Label
    Friend WithEvents Label2 As Label
End Class
