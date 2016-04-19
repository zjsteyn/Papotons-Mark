<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ListBoxStep2StudentHomework = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonStep3Step3 = New System.Windows.Forms.Button()
        Me.ListBoxStep3StudentHomework = New System.Windows.Forms.ListBox()
        Me.ButtonStep3Step2 = New System.Windows.Forms.Button()
        Me.ButtonStep3Step1 = New System.Windows.Forms.Button()
        Me.ButtonStep3OpenStudentWork = New System.Windows.Forms.Button()
        Me.ListBoxStep3Final = New System.Windows.Forms.ListBox()
        Me.LabelVar1 = New System.Windows.Forms.Label()
        Me.LabelsVar4 = New System.Windows.Forms.Label()
        Me.Labelvar3 = New System.Windows.Forms.Label()
        Me.LabelVar2 = New System.Windows.Forms.Label()
        Me.PanelStep3Feedback = New System.Windows.Forms.Panel()
        Me.NUDS3Pron = New System.Windows.Forms.NumericUpDown()
        Me.NUDS3Replies = New System.Windows.Forms.NumericUpDown()
        Me.NUDFormulation = New System.Windows.Forms.NumericUpDown()
        Me.NUDS3Listen = New System.Windows.Forms.NumericUpDown()
        Me.Labels3p1 = New System.Windows.Forms.Label()
        Me.ButtonStep3Stoprecordingfeedback = New System.Windows.Forms.Button()
        Me.ListBoxWords = New System.Windows.Forms.ListBox()
        Me.PanelChooseMS = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonMSNext = New System.Windows.Forms.Button()
        Me.CheckBoxMSaudiofeedback = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMSMarks = New System.Windows.Forms.CheckBox()
        Me.LabelMarkingmode = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelWordsFeedback = New System.Windows.Forms.Label()
        Me.PanelStep3Feedback.SuspendLayout()
        CType(Me.NUDS3Pron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDS3Replies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDFormulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDS3Listen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChooseMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxStep2StudentHomework
        '
        Me.ListBoxStep2StudentHomework.FormattingEnabled = True
        Me.ListBoxStep2StudentHomework.Location = New System.Drawing.Point(593, 388)
        Me.ListBoxStep2StudentHomework.Name = "ListBoxStep2StudentHomework"
        Me.ListBoxStep2StudentHomework.Size = New System.Drawing.Size(92, 95)
        Me.ListBoxStep2StudentHomework.TabIndex = 11
        Me.ListBoxStep2StudentHomework.TabStop = False
        Me.ListBoxStep2StudentHomework.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(284, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 42)
        Me.Button1.TabIndex = 22
        Me.Button1.TabStop = False
        Me.Button1.Text = "Maak n reset vir dosent maak txt vir dit wat gemerk is"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ButtonStep3Step3
        '
        Me.ButtonStep3Step3.Location = New System.Drawing.Point(12, 228)
        Me.ButtonStep3Step3.Name = "ButtonStep3Step3"
        Me.ButtonStep3Step3.Size = New System.Drawing.Size(267, 42)
        Me.ButtonStep3Step3.TabIndex = 5
        Me.ButtonStep3Step3.Text = "STEP 3: Save your feedback from STEP 1 and continue"
        Me.ButtonStep3Step3.UseVisualStyleBackColor = True
        Me.ButtonStep3Step3.Visible = False
        '
        'ListBoxStep3StudentHomework
        '
        Me.ListBoxStep3StudentHomework.FormattingEnabled = True
        Me.ListBoxStep3StudentHomework.Location = New System.Drawing.Point(103, 327)
        Me.ListBoxStep3StudentHomework.Name = "ListBoxStep3StudentHomework"
        Me.ListBoxStep3StudentHomework.Size = New System.Drawing.Size(647, 264)
        Me.ListBoxStep3StudentHomework.TabIndex = 20
        Me.ListBoxStep3StudentHomework.TabStop = False
        Me.ListBoxStep3StudentHomework.Visible = False
        '
        'ButtonStep3Step2
        '
        Me.ButtonStep3Step2.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonStep3Step2.Location = New System.Drawing.Point(12, 175)
        Me.ButtonStep3Step2.Name = "ButtonStep3Step2"
        Me.ButtonStep3Step2.Size = New System.Drawing.Size(267, 39)
        Me.ButtonStep3Step2.TabIndex = 18
        Me.ButtonStep3Step2.Text = "STEP 2: Review your feedback in STEP 1"
        Me.ButtonStep3Step2.UseVisualStyleBackColor = False
        Me.ButtonStep3Step2.Visible = False
        '
        'ButtonStep3Step1
        '
        Me.ButtonStep3Step1.Location = New System.Drawing.Point(12, 70)
        Me.ButtonStep3Step1.Name = "ButtonStep3Step1"
        Me.ButtonStep3Step1.Size = New System.Drawing.Size(267, 38)
        Me.ButtonStep3Step1.TabIndex = 17
        Me.ButtonStep3Step1.Text = "STEP 1: Listen to student answer and record your feedback after the beep"
        Me.ButtonStep3Step1.UseVisualStyleBackColor = True
        Me.ButtonStep3Step1.Visible = False
        '
        'ButtonStep3OpenStudentWork
        '
        Me.ButtonStep3OpenStudentWork.Location = New System.Drawing.Point(12, 33)
        Me.ButtonStep3OpenStudentWork.Name = "ButtonStep3OpenStudentWork"
        Me.ButtonStep3OpenStudentWork.Size = New System.Drawing.Size(267, 23)
        Me.ButtonStep3OpenStudentWork.TabIndex = 16
        Me.ButtonStep3OpenStudentWork.Text = "Open Student Work"
        Me.ButtonStep3OpenStudentWork.UseVisualStyleBackColor = True
        Me.ButtonStep3OpenStudentWork.Visible = False
        '
        'ListBoxStep3Final
        '
        Me.ListBoxStep3Final.FormattingEnabled = True
        Me.ListBoxStep3Final.Location = New System.Drawing.Point(565, 51)
        Me.ListBoxStep3Final.Name = "ListBoxStep3Final"
        Me.ListBoxStep3Final.Size = New System.Drawing.Size(202, 95)
        Me.ListBoxStep3Final.TabIndex = 25
        Me.ListBoxStep3Final.TabStop = False
        Me.ListBoxStep3Final.Visible = False
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
        'LabelsVar4
        '
        Me.LabelsVar4.AutoSize = True
        Me.LabelsVar4.Location = New System.Drawing.Point(46, 210)
        Me.LabelsVar4.Name = "LabelsVar4"
        Me.LabelsVar4.Size = New System.Drawing.Size(105, 13)
        Me.LabelsVar4.TabIndex = 45
        Me.LabelsVar4.Text = "overall pronunciation"
        Me.LabelsVar4.Visible = False
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
        'LabelVar2
        '
        Me.LabelVar2.AutoSize = True
        Me.LabelVar2.Location = New System.Drawing.Point(65, 62)
        Me.LabelVar2.Name = "LabelVar2"
        Me.LabelVar2.Size = New System.Drawing.Size(68, 13)
        Me.LabelVar2.TabIndex = 47
        Me.LabelVar2.Text = "Replies (_/2)"
        '
        'PanelStep3Feedback
        '
        Me.PanelStep3Feedback.Controls.Add(Me.NUDS3Pron)
        Me.PanelStep3Feedback.Controls.Add(Me.NUDS3Replies)
        Me.PanelStep3Feedback.Controls.Add(Me.NUDFormulation)
        Me.PanelStep3Feedback.Controls.Add(Me.NUDS3Listen)
        Me.PanelStep3Feedback.Controls.Add(Me.Labels3p1)
        Me.PanelStep3Feedback.Controls.Add(Me.LabelVar1)
        Me.PanelStep3Feedback.Controls.Add(Me.LabelVar2)
        Me.PanelStep3Feedback.Controls.Add(Me.Labelvar3)
        Me.PanelStep3Feedback.Controls.Add(Me.LabelsVar4)
        Me.PanelStep3Feedback.Location = New System.Drawing.Point(294, 33)
        Me.PanelStep3Feedback.Name = "PanelStep3Feedback"
        Me.PanelStep3Feedback.Size = New System.Drawing.Size(200, 258)
        Me.PanelStep3Feedback.TabIndex = 48
        Me.PanelStep3Feedback.Visible = False
        '
        'NUDS3Pron
        '
        Me.NUDS3Pron.Location = New System.Drawing.Point(49, 226)
        Me.NUDS3Pron.Name = "NUDS3Pron"
        Me.NUDS3Pron.Size = New System.Drawing.Size(106, 20)
        Me.NUDS3Pron.TabIndex = 4
        Me.NUDS3Pron.Visible = False
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
        'Labels3p1
        '
        Me.Labels3p1.AutoSize = True
        Me.Labels3p1.Location = New System.Drawing.Point(40, 194)
        Me.Labels3p1.Name = "Labels3p1"
        Me.Labels3p1.Size = New System.Drawing.Size(115, 13)
        Me.Labels3p1.TabIndex = 48
        Me.Labels3p1.Text = "Now give feedback on"
        Me.Labels3p1.Visible = False
        '
        'ButtonStep3Stoprecordingfeedback
        '
        Me.ButtonStep3Stoprecordingfeedback.Location = New System.Drawing.Point(12, 122)
        Me.ButtonStep3Stoprecordingfeedback.Name = "ButtonStep3Stoprecordingfeedback"
        Me.ButtonStep3Stoprecordingfeedback.Size = New System.Drawing.Size(267, 39)
        Me.ButtonStep3Stoprecordingfeedback.TabIndex = 49
        Me.ButtonStep3Stoprecordingfeedback.Text = "Stop recording feedback"
        Me.ButtonStep3Stoprecordingfeedback.UseVisualStyleBackColor = True
        Me.ButtonStep3Stoprecordingfeedback.Visible = False
        '
        'ListBoxWords
        '
        Me.ListBoxWords.FormattingEnabled = True
        Me.ListBoxWords.Location = New System.Drawing.Point(565, 156)
        Me.ListBoxWords.Name = "ListBoxWords"
        Me.ListBoxWords.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxWords.TabIndex = 50
        Me.ListBoxWords.Visible = False
        '
        'PanelChooseMS
        '
        Me.PanelChooseMS.Controls.Add(Me.Label1)
        Me.PanelChooseMS.Controls.Add(Me.ButtonMSNext)
        Me.PanelChooseMS.Controls.Add(Me.CheckBoxMSaudiofeedback)
        Me.PanelChooseMS.Controls.Add(Me.CheckBoxMSMarks)
        Me.PanelChooseMS.Location = New System.Drawing.Point(148, 51)
        Me.PanelChooseMS.Name = "PanelChooseMS"
        Me.PanelChooseMS.Size = New System.Drawing.Size(215, 193)
        Me.PanelChooseMS.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Choose at least one feedback option"
        '
        'ButtonMSNext
        '
        Me.ButtonMSNext.Location = New System.Drawing.Point(31, 135)
        Me.ButtonMSNext.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMSNext.Name = "ButtonMSNext"
        Me.ButtonMSNext.Size = New System.Drawing.Size(147, 43)
        Me.ButtonMSNext.TabIndex = 6
        Me.ButtonMSNext.Text = "Next"
        Me.ButtonMSNext.UseVisualStyleBackColor = True
        '
        'CheckBoxMSaudiofeedback
        '
        Me.CheckBoxMSaudiofeedback.AutoSize = True
        Me.CheckBoxMSaudiofeedback.Location = New System.Drawing.Point(31, 93)
        Me.CheckBoxMSaudiofeedback.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxMSaudiofeedback.Name = "CheckBoxMSaudiofeedback"
        Me.CheckBoxMSaudiofeedback.Size = New System.Drawing.Size(125, 17)
        Me.CheckBoxMSaudiofeedback.TabIndex = 5
        Me.CheckBoxMSaudiofeedback.Text = "Give audio feedback"
        Me.CheckBoxMSaudiofeedback.UseVisualStyleBackColor = True
        Me.CheckBoxMSaudiofeedback.Visible = False
        '
        'CheckBoxMSMarks
        '
        Me.CheckBoxMSMarks.AutoSize = True
        Me.CheckBoxMSMarks.Location = New System.Drawing.Point(31, 59)
        Me.CheckBoxMSMarks.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxMSMarks.Name = "CheckBoxMSMarks"
        Me.CheckBoxMSMarks.Size = New System.Drawing.Size(106, 17)
        Me.CheckBoxMSMarks.TabIndex = 4
        Me.CheckBoxMSMarks.Text = "Grade responses"
        Me.CheckBoxMSMarks.UseVisualStyleBackColor = True
        '
        'LabelMarkingmode
        '
        Me.LabelMarkingmode.AutoSize = True
        Me.LabelMarkingmode.Location = New System.Drawing.Point(12, 9)
        Me.LabelMarkingmode.Name = "LabelMarkingmode"
        Me.LabelMarkingmode.Size = New System.Drawing.Size(45, 13)
        Me.LabelMarkingmode.TabIndex = 52
        Me.LabelMarkingmode.Text = "Label18"
        Me.LabelMarkingmode.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(264, 36)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Record concluding remarks?"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'LabelWordsFeedback
        '
        Me.LabelWordsFeedback.AutoSize = True
        Me.LabelWordsFeedback.Location = New System.Drawing.Point(291, 9)
        Me.LabelWordsFeedback.Name = "LabelWordsFeedback"
        Me.LabelWordsFeedback.Size = New System.Drawing.Size(49, 13)
        Me.LabelWordsFeedback.TabIndex = 54
        Me.LabelWordsFeedback.Text = "WORDS"
        Me.LabelWordsFeedback.Visible = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 423)
        Me.Controls.Add(Me.LabelWordsFeedback)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LabelMarkingmode)
        Me.Controls.Add(Me.PanelChooseMS)
        Me.Controls.Add(Me.ListBoxWords)
        Me.Controls.Add(Me.ButtonStep3Stoprecordingfeedback)
        Me.Controls.Add(Me.PanelStep3Feedback)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBoxStep3Final)
        Me.Controls.Add(Me.ButtonStep3Step3)
        Me.Controls.Add(Me.ListBoxStep3StudentHomework)
        Me.Controls.Add(Me.ButtonStep3Step2)
        Me.Controls.Add(Me.ButtonStep3Step1)
        Me.Controls.Add(Me.ButtonStep3OpenStudentWork)
        Me.Controls.Add(Me.ListBoxStep2StudentHomework)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 800)
        Me.MinimumSize = New System.Drawing.Size(523, 334)
        Me.Name = "FormMain"
        Me.Text = "Papotons!  Feedback 20160304"
        Me.PanelStep3Feedback.ResumeLayout(False)
        Me.PanelStep3Feedback.PerformLayout()
        CType(Me.NUDS3Pron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDS3Replies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDFormulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDS3Listen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChooseMS.ResumeLayout(False)
        Me.PanelChooseMS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxStep2StudentHomework As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonStep3Step3 As System.Windows.Forms.Button
    Friend WithEvents ListBoxStep3StudentHomework As System.Windows.Forms.ListBox
    Friend WithEvents ButtonStep3Step2 As System.Windows.Forms.Button
    Friend WithEvents ButtonStep3Step1 As System.Windows.Forms.Button
    Friend WithEvents ButtonStep3OpenStudentWork As System.Windows.Forms.Button
    Friend WithEvents ListBoxStep3Final As System.Windows.Forms.ListBox
    Friend WithEvents LabelVar1 As System.Windows.Forms.Label
    Friend WithEvents LabelsVar4 As System.Windows.Forms.Label
    Friend WithEvents Labelvar3 As System.Windows.Forms.Label
    Friend WithEvents LabelVar2 As System.Windows.Forms.Label
    Friend WithEvents PanelStep3Feedback As System.Windows.Forms.Panel
    Friend WithEvents Labels3p1 As System.Windows.Forms.Label
    Friend WithEvents NUDS3Pron As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUDS3Replies As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUDFormulation As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUDS3Listen As System.Windows.Forms.NumericUpDown
    Friend WithEvents ButtonStep3Stoprecordingfeedback As System.Windows.Forms.Button
    Friend WithEvents ListBoxWords As System.Windows.Forms.ListBox
    Friend WithEvents PanelChooseMS As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonMSNext As System.Windows.Forms.Button
    Friend WithEvents CheckBoxMSaudiofeedback As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMSMarks As System.Windows.Forms.CheckBox
    Friend WithEvents LabelMarkingmode As System.Windows.Forms.Label
    Friend WithEvents Button2 As Button
    Friend WithEvents LabelWordsFeedback As Label
End Class
