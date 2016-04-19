Public Class FormMSMarkingGrid



    Private Sub ButtonMSMGContinue_Click(sender As Object, e As EventArgs) Handles ButtonMSMGContinue.Click
        'Publick variables , clena dalk net as program 
        If FormMain.CheckBoxMSaudiofeedback.Checked = False Then
            FormMain.ButtonStep3Step1.Text = "Click to listen to student answer"
            FormMain.ButtonStep3Step3.Text = "Listen to the next answer"
            FormMain.ButtonStep3Stoprecordingfeedback.Text = "Stop listening"
        End If


        FormMain.NUDS3Listen.Maximum = NumericUpDownMSCMax1.Value
        FormMain.NUDS3Replies.Maximum = NumericUpDownMSCMax2.Value
        FormMain.NUDFormulation.Maximum = NumericUpDownMSCMax3.Value
        FormMain.NUDS3Pron.Maximum = NumericUpDownMSCMax4.Value


        FormMain.MAXVAR1 = FormMain.NUDS3Listen.Maximum
        FormMain.MAXVAR2 = FormMain.NUDS3Replies.Maximum
        FormMain.MAXVAR3 = FormMain.NUDFormulation.Maximum
        '??? Kan moonltik hier n fot he
        FormMain.MAXVAR4 = FormMain.NUDS3Pron.Maximum

        FormMain.LabelVar1.Text = TextBoxMSC1.Text + "\" + FormMain.MAXVAR1.ToString
        FormMain.LabelVar2.Text = TextBoxMSC2.Text + "\" + FormMain.MAXVAR2.ToString
        FormMain.Labelvar3.Text = TextBoxMSC3.Text + "\" + FormMain.MAXVAR3.ToString
        '??? Kan moonltik hier n fot he
        FormMain.LabelsVar4.Text = TextBoxMSC4.Text + "\" + FormMain.MAXVAR4.ToString
        FormMain.relationshipevaluation = Convert.ToInt16(TextBoxMSC4Per.Text)
     
        FormMain.ButtonStep3OpenStudentWork.Visible = True
        FormMain.Show()
        FormMain.Location = New Size(0, 0)

        Me.Hide()



    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxMSC1.Text = "Listen"
        TextBoxMSC2.Text = "Replies"
        TextBoxMSC3.Text = "Formulation"
        TextBoxMSC4.Text = "Pronunciation"
        NumericUpDownMSCMax1.Value = 5
        NumericUpDownMSCMax2.Value = 5
        NumericUpDownMSCMax3.Value = 5
        NumericUpDownMSCMax4.Value = 5
        NumericUpDownMSCMax1Per.Value = 25
        NumericUpDownMSCMax2Per.Value = 25
        NumericUpDownMSCMax3Per.Value = 25
        NumericUpDownMSCMax4Per.Value = 25


    End Sub

    Private Sub RadioButtonPronOverall_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPronOverall.CheckedChanged
        FormMain.onlyatend = True

    End Sub

    Private Sub RadioButtonPronIndividual_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPronIndividual.CheckedChanged
        FormMain.onlyatend = False
    End Sub
End Class