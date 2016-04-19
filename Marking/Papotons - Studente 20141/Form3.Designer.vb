<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMSMarkingGrid
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
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonMSMGContinue = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonPronIndividual = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPronOverall = New System.Windows.Forms.RadioButton()
        Me.TextBoxMSC1 = New System.Windows.Forms.TextBox()
        Me.TextBoxMSC1Max = New System.Windows.Forms.TextBox()
        Me.TextBoxMSC1Per = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxMSC2Per = New System.Windows.Forms.TextBox()
        Me.TextBoxMSC2Max = New System.Windows.Forms.TextBox()
        Me.TextBoxMSC2 = New System.Windows.Forms.TextBox()
        Me.TextBoxMSC3Per = New System.Windows.Forms.TextBox()
        Me.TextBoxMSC3Max = New System.Windows.Forms.TextBox()
        Me.TextBoxMSC3 = New System.Windows.Forms.TextBox()
        Me.TextBoxMSC4Per = New System.Windows.Forms.TextBox()
        Me.TextBoxMSC4Max = New System.Windows.Forms.TextBox()
        Me.TextBoxMSC4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDownMSCMax1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMSCMax2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMSCMax3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMSCMax4 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMSCMax4Per = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMSCMax3Per = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMSCMax2Per = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMSCMax1Per = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownMSCMax1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMSCMax2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMSCMax3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMSCMax4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMSCMax4Per, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMSCMax3Per, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMSCMax2Per, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMSCMax1Per, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(70, 308)
        Me.ButtonReset.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(168, 35)
        Me.ButtonReset.TabIndex = 14
        Me.ButtonReset.Text = "Reset marking grid"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Currently 4 Criteria must be used"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "A default marking grid has been loaded. You can change it."
        '
        'ButtonMSMGContinue
        '
        Me.ButtonMSMGContinue.Location = New System.Drawing.Point(268, 308)
        Me.ButtonMSMGContinue.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMSMGContinue.Name = "ButtonMSMGContinue"
        Me.ButtonMSMGContinue.Size = New System.Drawing.Size(169, 35)
        Me.ButtonMSMGContinue.TabIndex = 15
        Me.ButtonMSMGContinue.Text = "Save grid and continue"
        Me.ButtonMSMGContinue.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonPronIndividual)
        Me.GroupBox1.Controls.Add(Me.RadioButtonPronOverall)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(382, 81)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose feedback mode"
        '
        'RadioButtonPronIndividual
        '
        Me.RadioButtonPronIndividual.AutoSize = True
        Me.RadioButtonPronIndividual.Location = New System.Drawing.Point(12, 47)
        Me.RadioButtonPronIndividual.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonPronIndividual.Name = "RadioButtonPronIndividual"
        Me.RadioButtonPronIndividual.Size = New System.Drawing.Size(346, 17)
        Me.RadioButtonPronIndividual.TabIndex = 18
        Me.RadioButtonPronIndividual.TabStop = True
        Me.RadioButtonPronIndividual.Text = "Evaluate each question individually and overall pronunciation at end"
        Me.RadioButtonPronIndividual.UseVisualStyleBackColor = True
        Me.RadioButtonPronIndividual.Visible = False
        '
        'RadioButtonPronOverall
        '
        Me.RadioButtonPronOverall.AutoSize = True
        Me.RadioButtonPronOverall.Checked = True
        Me.RadioButtonPronOverall.Location = New System.Drawing.Point(12, 17)
        Me.RadioButtonPronOverall.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonPronOverall.Name = "RadioButtonPronOverall"
        Me.RadioButtonPronOverall.Size = New System.Drawing.Size(176, 17)
        Me.RadioButtonPronOverall.TabIndex = 17
        Me.RadioButtonPronOverall.TabStop = True
        Me.RadioButtonPronOverall.Text = "Do overall evaluation at the end"
        Me.RadioButtonPronOverall.UseVisualStyleBackColor = True
        '
        'TextBoxMSC1
        '
        Me.TextBoxMSC1.Location = New System.Drawing.Point(75, 160)
        Me.TextBoxMSC1.Name = "TextBoxMSC1"
        Me.TextBoxMSC1.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxMSC1.TabIndex = 2
        Me.TextBoxMSC1.Text = "Listening"
        '
        'TextBoxMSC1Max
        '
        Me.TextBoxMSC1Max.Location = New System.Drawing.Point(150, 348)
        Me.TextBoxMSC1Max.Name = "TextBoxMSC1Max"
        Me.TextBoxMSC1Max.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMSC1Max.TabIndex = 9
        Me.TextBoxMSC1Max.Text = "5"
        Me.TextBoxMSC1Max.Visible = False
        '
        'TextBoxMSC1Per
        '
        Me.TextBoxMSC1Per.Location = New System.Drawing.Point(256, 348)
        Me.TextBoxMSC1Per.Name = "TextBoxMSC1Per"
        Me.TextBoxMSC1Per.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMSC1Per.TabIndex = 10
        Me.TextBoxMSC1Per.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Marking criteria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Maximum mark"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(327, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "% of total marks"
        '
        'TextBoxMSC2Per
        '
        Me.TextBoxMSC2Per.Location = New System.Drawing.Point(256, 379)
        Me.TextBoxMSC2Per.Name = "TextBoxMSC2Per"
        Me.TextBoxMSC2Per.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMSC2Per.TabIndex = 16
        Me.TextBoxMSC2Per.Visible = False
        '
        'TextBoxMSC2Max
        '
        Me.TextBoxMSC2Max.Location = New System.Drawing.Point(150, 379)
        Me.TextBoxMSC2Max.Name = "TextBoxMSC2Max"
        Me.TextBoxMSC2Max.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMSC2Max.TabIndex = 15
        Me.TextBoxMSC2Max.Text = "5"
        Me.TextBoxMSC2Max.Visible = False
        '
        'TextBoxMSC2
        '
        Me.TextBoxMSC2.Location = New System.Drawing.Point(75, 191)
        Me.TextBoxMSC2.Name = "TextBoxMSC2"
        Me.TextBoxMSC2.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxMSC2.TabIndex = 5
        Me.TextBoxMSC2.Text = "Replies"
        '
        'TextBoxMSC3Per
        '
        Me.TextBoxMSC3Per.Location = New System.Drawing.Point(256, 410)
        Me.TextBoxMSC3Per.Name = "TextBoxMSC3Per"
        Me.TextBoxMSC3Per.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMSC3Per.TabIndex = 19
        Me.TextBoxMSC3Per.Visible = False
        '
        'TextBoxMSC3Max
        '
        Me.TextBoxMSC3Max.Location = New System.Drawing.Point(150, 410)
        Me.TextBoxMSC3Max.Name = "TextBoxMSC3Max"
        Me.TextBoxMSC3Max.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMSC3Max.TabIndex = 18
        Me.TextBoxMSC3Max.Text = "5"
        Me.TextBoxMSC3Max.Visible = False
        '
        'TextBoxMSC3
        '
        Me.TextBoxMSC3.Location = New System.Drawing.Point(75, 222)
        Me.TextBoxMSC3.Name = "TextBoxMSC3"
        Me.TextBoxMSC3.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxMSC3.TabIndex = 8
        Me.TextBoxMSC3.Text = "Formulation"
        '
        'TextBoxMSC4Per
        '
        Me.TextBoxMSC4Per.Location = New System.Drawing.Point(256, 441)
        Me.TextBoxMSC4Per.Name = "TextBoxMSC4Per"
        Me.TextBoxMSC4Per.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMSC4Per.TabIndex = 22
        Me.TextBoxMSC4Per.Text = "20"
        Me.TextBoxMSC4Per.Visible = False
        '
        'TextBoxMSC4Max
        '
        Me.TextBoxMSC4Max.Location = New System.Drawing.Point(150, 441)
        Me.TextBoxMSC4Max.Name = "TextBoxMSC4Max"
        Me.TextBoxMSC4Max.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMSC4Max.TabIndex = 21
        Me.TextBoxMSC4Max.Text = "5"
        Me.TextBoxMSC4Max.Visible = False
        '
        'TextBoxMSC4
        '
        Me.TextBoxMSC4.Location = New System.Drawing.Point(75, 253)
        Me.TextBoxMSC4.Name = "TextBoxMSC4"
        Me.TextBoxMSC4.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxMSC4.TabIndex = 11
        Me.TextBoxMSC4.Text = "Pronuncation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 285)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(375, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Pronunciation evaluation takes place only once all items have been assessed."
        '
        'NumericUpDownMSCMax1
        '
        Me.NumericUpDownMSCMax1.Location = New System.Drawing.Point(235, 160)
        Me.NumericUpDownMSCMax1.Name = "NumericUpDownMSCMax1"
        Me.NumericUpDownMSCMax1.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDownMSCMax1.TabIndex = 3
        Me.NumericUpDownMSCMax1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NumericUpDownMSCMax2
        '
        Me.NumericUpDownMSCMax2.Location = New System.Drawing.Point(235, 191)
        Me.NumericUpDownMSCMax2.Name = "NumericUpDownMSCMax2"
        Me.NumericUpDownMSCMax2.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDownMSCMax2.TabIndex = 6
        Me.NumericUpDownMSCMax2.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NumericUpDownMSCMax3
        '
        Me.NumericUpDownMSCMax3.Location = New System.Drawing.Point(235, 222)
        Me.NumericUpDownMSCMax3.Name = "NumericUpDownMSCMax3"
        Me.NumericUpDownMSCMax3.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDownMSCMax3.TabIndex = 9
        Me.NumericUpDownMSCMax3.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NumericUpDownMSCMax4
        '
        Me.NumericUpDownMSCMax4.Location = New System.Drawing.Point(235, 253)
        Me.NumericUpDownMSCMax4.Name = "NumericUpDownMSCMax4"
        Me.NumericUpDownMSCMax4.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDownMSCMax4.TabIndex = 12
        Me.NumericUpDownMSCMax4.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NumericUpDownMSCMax4Per
        '
        Me.NumericUpDownMSCMax4Per.Location = New System.Drawing.Point(330, 253)
        Me.NumericUpDownMSCMax4Per.Name = "NumericUpDownMSCMax4Per"
        Me.NumericUpDownMSCMax4Per.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDownMSCMax4Per.TabIndex = 13
        Me.NumericUpDownMSCMax4Per.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'NumericUpDownMSCMax3Per
        '
        Me.NumericUpDownMSCMax3Per.Location = New System.Drawing.Point(330, 222)
        Me.NumericUpDownMSCMax3Per.Name = "NumericUpDownMSCMax3Per"
        Me.NumericUpDownMSCMax3Per.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDownMSCMax3Per.TabIndex = 10
        Me.NumericUpDownMSCMax3Per.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'NumericUpDownMSCMax2Per
        '
        Me.NumericUpDownMSCMax2Per.Location = New System.Drawing.Point(330, 191)
        Me.NumericUpDownMSCMax2Per.Name = "NumericUpDownMSCMax2Per"
        Me.NumericUpDownMSCMax2Per.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDownMSCMax2Per.TabIndex = 7
        Me.NumericUpDownMSCMax2Per.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'NumericUpDownMSCMax1Per
        '
        Me.NumericUpDownMSCMax1Per.Location = New System.Drawing.Point(330, 160)
        Me.NumericUpDownMSCMax1Per.Name = "NumericUpDownMSCMax1Per"
        Me.NumericUpDownMSCMax1Per.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDownMSCMax1Per.TabIndex = 4
        Me.NumericUpDownMSCMax1Per.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'FormMSMarkingGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 362)
        Me.Controls.Add(Me.NumericUpDownMSCMax1Per)
        Me.Controls.Add(Me.NumericUpDownMSCMax2Per)
        Me.Controls.Add(Me.NumericUpDownMSCMax3Per)
        Me.Controls.Add(Me.NumericUpDownMSCMax4Per)
        Me.Controls.Add(Me.NumericUpDownMSCMax4)
        Me.Controls.Add(Me.NumericUpDownMSCMax3)
        Me.Controls.Add(Me.NumericUpDownMSCMax2)
        Me.Controls.Add(Me.NumericUpDownMSCMax1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxMSC4Per)
        Me.Controls.Add(Me.TextBoxMSC4Max)
        Me.Controls.Add(Me.TextBoxMSC4)
        Me.Controls.Add(Me.TextBoxMSC3Per)
        Me.Controls.Add(Me.TextBoxMSC3Max)
        Me.Controls.Add(Me.TextBoxMSC3)
        Me.Controls.Add(Me.TextBoxMSC2Per)
        Me.Controls.Add(Me.TextBoxMSC2Max)
        Me.Controls.Add(Me.TextBoxMSC2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxMSC1Per)
        Me.Controls.Add(Me.TextBoxMSC1Max)
        Me.Controls.Add(Me.TextBoxMSC1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonMSMGContinue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonReset)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(523, 400)
        Me.MinimumSize = New System.Drawing.Size(523, 400)
        Me.Name = "FormMSMarkingGrid"
        Me.Text = "Marking setup - Marking Grid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownMSCMax1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMSCMax2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMSCMax3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMSCMax4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMSCMax4Per, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMSCMax3Per, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMSCMax2Per, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMSCMax1Per, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonMSMGContinue As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonPronIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPronOverall As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxMSC1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMSC1Max As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMSC1Per As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMSC2Per As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMSC2Max As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMSC2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMSC3Per As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMSC3Max As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMSC3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMSC4Per As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMSC4Max As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMSC4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownMSCMax1 As NumericUpDown
    Friend WithEvents NumericUpDownMSCMax2 As NumericUpDown
    Friend WithEvents NumericUpDownMSCMax3 As NumericUpDown
    Friend WithEvents NumericUpDownMSCMax4 As NumericUpDown
    Friend WithEvents NumericUpDownMSCMax4Per As NumericUpDown
    Friend WithEvents NumericUpDownMSCMax3Per As NumericUpDown
    Friend WithEvents NumericUpDownMSCMax2Per As NumericUpDown
    Friend WithEvents NumericUpDownMSCMax1Per As NumericUpDown
End Class
