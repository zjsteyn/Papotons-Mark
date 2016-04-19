Public Class FormOnlyatend



    Private Sub ButtonMSNext_Click(sender As Object, e As EventArgs) Handles ButtonMSNext.Click
        If FormMain.wordsfeedback = True Then
            FormMain.LabelWordsFeedback.Visible = True

        End If
        PanelStep3Feedback.Visible = True
        NUDS3Pron.Visible = True





        '    MessageBox.Show(FormMain.Studenteopdragennaam + "     " + FormMain.studentenommer)
        Dim objWriterEval As New System.IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + FormMain.Studenteopdragennaam + "\" + FormMain.studentenommer + "\" + "Grading_" + FormMain.Studenteopdragennaam + "_" + FormMain.studentenommer + ".txt", True)
        objWriterEval.WriteLine("Marking criteria,Your mark,Maximum available mark")
        objWriterEval.WriteLine(FormMSMarkingGrid.TextBoxMSC1.Text + "," + NUDS3Listen.Value.ToString + "," + FormMain.MAXVAR1.ToString)
        objWriterEval.WriteLine(FormMSMarkingGrid.TextBoxMSC2.Text + "," + NUDS3Replies.Value.ToString + "," + FormMain.MAXVAR2.ToString)
        objWriterEval.WriteLine(FormMSMarkingGrid.TextBoxMSC3.Text + "," + NUDFormulation.Value.ToString + "," + FormMain.MAXVAR3.ToString)
        objWriterEval.WriteLine(FormMSMarkingGrid.TextBoxMSC4.Text + "," + NUDS3Pron.Value.ToString + "," + FormMain.MAXVAR4.ToString)
        Dim answer As Double = Convert.ToDouble(NUDS3Listen.Value) / Convert.ToDouble(FormMain.MAXVAR1) * (Convert.ToDouble(FormMSMarkingGrid.NumericUpDownMSCMax1Per.Value) / 100) + Convert.ToDouble(NUDS3Replies.Value) / Convert.ToDouble(FormMain.MAXVAR2) * (Convert.ToDouble(FormMSMarkingGrid.NumericUpDownMSCMax2Per.Value) / 100) + Convert.ToDouble(NUDFormulation.Value) / Convert.ToDouble(FormMain.MAXVAR3) * (Convert.ToDouble(FormMSMarkingGrid.NumericUpDownMSCMax3Per.Value) / 100) + Convert.ToDouble(NUDS3Pron.Value) / Convert.ToDouble(FormMain.MAXVAR4) * (Convert.ToDouble(FormMSMarkingGrid.NumericUpDownMSCMax4Per.Value) / 100)
        answer = Math.Round(answer * 100)
        '  MessageBox.Show(answer.ToString + "     " + NUDFormulation.Value.ToString + "  " + FormMSMarkingGrid.NumericUpDownMSCMax3.Value.ToString)
        objWriterEval.WriteLine("Final % for this excersize is:  " + answer.ToString)

        objWriterEval.Close()
        My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + FormMain.Studenteopdragennaam + "\" + FormMain.studentenommer + "\" + "Grading_" + FormMain.Studenteopdragennaam + "_" + FormMain.studentenommer + ".txt", My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + FormMain.Studenteopdragennaam + "\" + FormMain.studentenommer + "\" + "Grading_" + FormMain.Studenteopdragennaam + "_" + FormMain.studentenommer + ".csv")
        My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + FormMain.Studenteopdragennaam + "\" + FormMain.studentenommer + "\" + "Grading_" + FormMain.Studenteopdragennaam + "_" + FormMain.studentenommer + ".txt")
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Classlists\") Then
        Else
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Classlists\")
        End If

        Dim objWriterclasslist As New System.IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Classlists\" + FormMain.Studenteopdragennaam + ".txt", True)

        objWriterclasslist.WriteLine(FormMain.studentenommer + "," + NUDS3Listen.Value.ToString + "," + NUDS3Replies.Value.ToString + "," + NUDFormulation.Value.ToString + "," + NUDS3Pron.Value.ToString + "," + "Max marks for categories are:" + FormMain.MAXVAR1.ToString + " " + FormMain.MAXVAR2.ToString + " " + FormMain.MAXVAR3.ToString + " " + FormMain.MAXVAR4.ToString) ' projectnamepublic + ", " + Studenteopdragennaam + ", " + finalpercentagepublic.ToString)

        objWriterclasslist.Close()
        FormMain.Show()

        Me.Hide()

        'If CheckBoxMSMarks.Checked = True Then

        '    FormMSMarkingGrid.Show()
        '    Me.Hide()

        'Else
        '    FormMain.Show()
        '    Me.Close()
        '    FormMain.onlyaudiofeedback = True
        '    FormMain.testforonlymarks = False

        'End If

    End Sub

    Private Sub FormMarkingSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FormMain.Hide()
        LabelVar1.Text = FormMSMarkingGrid.TextBoxMSC1.Text + "__/" + FormMain.MAXVAR1.ToString
        LabelVar2.Text = FormMSMarkingGrid.TextBoxMSC2.Text + "__/" + FormMain.MAXVAR2.ToString
        Labelvar3.Text = FormMSMarkingGrid.TextBoxMSC3.Text + "__/" + FormMain.MAXVAR3.ToString
        LabelVar4.Text = FormMSMarkingGrid.TextBoxMSC4.Text + "__/" + FormMain.MAXVAR4.ToString


        NUDFormulation.Value = 0
        NUDS3Listen.Value = 0
        NUDS3Pron.Value = 0
        NUDS3Replies.Value = 0

        NUDS3Listen.Maximum = FormMain.MAXVAR1
        NUDS3Replies.Maximum = FormMain.MAXVAR2
        NUDFormulation.Maximum = FormMain.MAXVAR3

        NUDS3Pron.Maximum = FormMain.MAXVAR4

        'NB sit hier iets in om die goed te reset!!!
    End Sub
End Class