
Imports System.IO.Compression
Imports System.IO.Compression.ZipFile
Imports System.IO.FileStream

Public Class FormMain
    Public wordsfeedback As Boolean
    Public onlyatend As Boolean
    Public countamountofword As Integer
    Public testforonlymarks As Boolean
    Public relationshipevaluation As Integer
    Public onlyaudiofeedback As Boolean
    Public finalpercentagepublic As Double
    Public wordstextfilelocation, wordsfileslocation As String
    Public MAXVAR1, MAXVAR2, MAXVAR3, MAXVAR4
    Public tempfilelocationwords As String

    Public projectnamepublic, studentenommer As String

    Public yourmark, maxmark As Integer
    Public publicstep3finishedfile, publicstep3finishedfolder As String
    Public checkstep3feedback As Boolean
    Public counterclicksrecord, counterclicksplayback As Integer
    Public step2reflectfinish, step2evalvinish As Boolean
    Public PublicAssignmentnametxt As String
    Public textfilelocation As String
    Public stopallaudioteach As Boolean
    Public lbcountstudent, startcounter, startcounterwords As Integer
    Public assignmentexist As Integer
    Public publicassignmentname, publicassignmentlocation As String
    Public opdragnaampublic As String
    Public testfinish As Boolean
    Public pubstrfilename, pubstudentenommer, homeworktext, homeworkassignmentname As String
    Public Studenteopdragennaam, studentenommervirhuiswerk As String
    Public finalwrite, publicstep2studentfilelocation As String
    Private mCurrentZip As String = String.Empty
    Dim counterrecord, counterplayback As Integer



    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstyCommand As String, ByVal lpstrreturnstring As String, ByVal uretrunlength As Integer, ByVal hwndcallback As Integer) As Integer
    Private Declare Function mciSendString2 Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstyCommand2 As String, ByVal lpstrreturnstring2 As String, ByVal uretrunlength2 As Integer, ByVal hwndcallback2 As Integer) As Integer
    Private Declare Function mciSendString3 Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstyCommand3 As String, ByVal lpstrreturnstring3 As String, ByVal uretrunlength3 As Integer, ByVal hwndcallback3 As Integer) As Integer
    Public testevallisten, testevalreplies, testevalformulation, testevalpronounce As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Size(0, 0)

        Dim tempdirectory As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Needed"
        If My.Computer.FileSystem.DirectoryExists(tempdirectory) Then
            Dim dirinfo As IO.DirectoryInfo = New IO.DirectoryInfo(tempdirectory)
            dirinfo.Attributes = IO.FileAttributes.Hidden ' HideMain()
        End If
        onlyatend = False
        wordsfeedback = False
        '  FormMarkingSetup.Show()

        studentenommer = ""

        '' Hierdie moet wel run as die form weer actually show.


        ButtonStep3Step1.BackColor = SystemColors.Control
        ButtonStep3Stoprecordingfeedback.BackColor = SystemColors.Control
        ButtonStep3Step2.BackColor = SystemColors.Control
        ButtonStep3Step3.BackColor = SystemColors.Control

        testforonlymarks = False

        Dim feedbacktostudents As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\"
        If My.Computer.FileSystem.DirectoryExists(feedbacktostudents) Then

            My.Computer.FileSystem.CreateDirectory(feedbacktostudents)
        Else
            My.Computer.FileSystem.CreateDirectory(feedbacktostudents)
        End If





        publicassignmentlocation = ""
        publicassignmentname = ""
        counterplayback = 0
        counterrecord = 0
        startcounterwords = 0
        '   Me.Location = New Size(0, 0)


        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp") Then
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If

        'MessageBox.Show("completed")


    End Sub



    Private Function Join(ByVal wavBytes As List(Of Byte), ByVal wav2 As List(Of Byte)) As List(Of Byte)

        '   add on the second file excluding its header bytes
        wavBytes.AddRange(wav2.Skip(44).Take(wav2.Count - 44))


        '   rewrite the ChunkSize and Subchunk2Size fields of the Header
        Dim chunkSize As Integer = wavBytes.Count - 8
        Dim subChunk2Size As Integer = wavBytes.Count - 44

        Dim chunkSizeBytes() As Byte = BitConverter.GetBytes(chunkSize)
        Dim subChunk2SizeBytes() As Byte = BitConverter.GetBytes(subChunk2Size)
        For i = 0 To 3
            wavBytes(4 + i) = chunkSizeBytes(i)
            wavBytes(40 + i) = subChunk2SizeBytes(i)
        Next

        Return wavBytes
    End Function



    Private Sub ButtonStep3OpenStudentWork_Click(sender As Object, e As EventArgs) Handles ButtonStep3OpenStudentWork.Click
        'rename hierdie as variables
        NUDS3Listen.Value = 0
        NUDS3Pron.Value = 0
        NUDS3Replies.Value = 0
        NUDFormulation.Value = 0
        startcounter = 0
        '   maxmark = 5
        '   yourmark = 0
        checkstep3feedback = False
        Dim strFileNameS = ""
        Dim fileDialogBoxS As New OpenFileDialog()
        fileDialogBoxS.Filter = "Papotons! Marking Files (*.papotm)|*.papotm"
        'Check to see if the user clicked the open button
        If (fileDialogBoxS.ShowDialog() = DialogResult.OK) Then
            strFileNameS = fileDialogBoxS.FileName
            Dim positions As Integer = 0
            '  Dim stringlenghts As Integer = 0
            positions = strFileNameS.LastIndexOf("\")
            'Studenteopdragennaam = strFileNameS
            ' publicstep3finishedfile = strFileNameS
            publicstep3finishedfolder = strFileNameS.Remove(positions)
            ' Studenteopdragennaam = Studenteopdragennaam.Remove(0, positions + 1)
            '  publicstep2studentfilelocation = strFileNameS.Remove(positions + 1)
            ' Studenteopdragennaam = Studenteopdragennaam.Replace(".papot", "")

            Dim tempdirectory As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp"
            If My.Computer.FileSystem.DirectoryExists(tempdirectory) Then
                My.Computer.FileSystem.DeleteDirectory(tempdirectory, FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory(tempdirectory)
            Else
                My.Computer.FileSystem.CreateDirectory(tempdirectory)
            End If

            If My.Computer.FileSystem.FileExists(strFileNameS.Replace(".papotm", ".zip")) Then
                ' ????dalk onnodig
            Else
                My.Computer.FileSystem.CopyFile(strFileNameS, strFileNameS.Replace(".papotm", ".zip"))
            End If


            ZipFile.ExtractToDirectory(strFileNameS.Replace(".papotm", ".zip"), tempdirectory)
            My.Computer.FileSystem.DeleteFile(strFileNameS.Replace(".papotm", ".zip"))


            'Dim studentnumber As String = ""
            'For Each foundFileStudent As String In My.Computer.FileSystem.GetFiles(tempdirectory)
            '    If foundFileStudent.Contains("studentnumber") Then
            '        studentnumber = foundFileStudent.ToString
            '        studentnumber = studentnumber.Replace(".studentnumber", "")
            '        studentnumber = studentnumber.Remove(0, (studentnumber.LastIndexOf("\") + 1))
            '        '     Studenteopdragennaam = studentnumber
            '    End If
            'Next

            ' Die deel kan jy vervang as jy naam van projek stuur as deel van papotm file
            Dim projectname As String = ""
            For Each foundFileProject As String In My.Computer.FileSystem.GetFiles(tempdirectory)
                If foundFileProject.Contains("Time.time") Then
                    projectname = foundFileProject.ToString
                    'tydelik uitgehaal vir ou fout    projectname = projectname.Replace("PackageName.txt", "")
                    'projectname = projectname.Remove(0, (projectname.LastIndexOf("\") + 1))
                    projectnamepublic = projectname
                    Studenteopdragennaam = projectname.Remove((projectname.LastIndexOf("_")))
                    Studenteopdragennaam = Studenteopdragennaam.Remove(0, (Studenteopdragennaam.LastIndexOf("\") + 1))
                    '  MessageBox.Show(projectnamepublic + "dit is projectname pubclic")
                    '  projectnamepublic = projectname.Replace(Studenteopdragennaam, "")
                    ' MessageBox.Show(Studenteopdragennaam)
                End If
            Next
            Dim snumber As String = ""
            For Each foundFileProject As String In My.Computer.FileSystem.GetFiles(tempdirectory)
                If foundFileProject.Contains(".studentnumber") Then
                    snumber = foundFileProject.ToString
                    snumber = snumber.Replace(".studentnumber", "")
                    'projectname = projectname.Remove(0, (projectname.LastIndexOf("\") + 1))
                    '   projectnamepublic = projectname
                    studentenommer = snumber.Remove(0, (snumber.LastIndexOf("\") + 1))
                    '  MessageBox.Show(studentenommer)
                End If
            Next

            If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + Studenteopdragennaam + "\Reflect") Then

            Else
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + Studenteopdragennaam + "\Reflect")
            End If



            Dim reflection As String = ""
            For Each foundFilereflection As String In My.Computer.FileSystem.GetFiles(tempdirectory)
                If foundFilereflection.Contains("reflectionanswer.wav") Then
                    reflection = foundFilereflection.ToString
                    '  reflection = projectname.Replace("PackageName.txt", "")
                    ' projectname = projectname.Remove(0, (projectname.LastIndexOf("\") + 1))
                    '    projectnamepublic = projectname
                    ' MessageBox.Show(projectnamepublic)
                    '  projectnamepublic = projectname.Replace(Studenteopdragennaam, "")
                    ' MessageBox.Show(projectnamepublic)
                    My.Computer.FileSystem.CopyFile(reflection, My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + Studenteopdragennaam + "\Reflect\" + Studenteopdragennaam + "_" + studentenommer + ".wav", True)

                Else

                End If
            Next



            'studentenommervirhuiswerk = tempdirectory +
            'studentenommervirhuiswerk = Studenteopdragennaam + "x" + TextBoxStep2Studentnumber.Text
            '???Wkyk wat jy hier gedoen het dit maak nie sin nie
            ' MessageBox.Show(Studenteopdragennaam + "    " + studentenommervirhuiswerk)
            ' MessageBox.Show(Studenteopdragennaam.Remove(Studenteopdragennaam.LastIndexOf("x")) + "\" + Studenteopdragennaam.Remove(0, Studenteopdragennaam.LastIndexOf("x") + 1))
            Dim direxist As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + Studenteopdragennaam + "\" + studentenommer
            If My.Computer.FileSystem.DirectoryExists(direxist) = True Then
                Dim result As Integer = MessageBox.Show("Feedback has already been given to this student: " + studentenommer + ". Data will be backed up and overwritten", "Overwrite", MessageBoxButtons.OK)
                If result = MessageBoxButtons.OK Then
                    My.Computer.FileSystem.CopyDirectory(direxist, direxist + "\Backup\" + studentenommer, True)
                    My.Computer.FileSystem.DeleteDirectory(direxist, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Feedbacktostudents\" + Studenteopdragennaam + "\" + studentenommer)

                End If
            Else
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Feedbacktostudents\" + Studenteopdragennaam + "\" + studentenommer)

            End If

            '   Dispose(direxist)
            '    MessageBox.Show(direxist)
            ' If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Feedbacktostudents\" + projectname + "\" + studentnumber) Then
            ' dalk onnodig
            'Else
            '  End If

            '' overwrite feedback deel eers uithhal
            'If My.Computer.FileSystem.FileExists(direxist + Studenteopdragennaam.Remove(Studenteopdragennaam.LastIndexOf("x")) + "\" + Studenteopdragennaam + ".zip") Then
            '    Dim resultprev As Integer = MessageBox.Show("Do you want To overwrite previous feedback?", "", MessageBoxButtons.YesNo)
            '    If resultprev = DialogResult.Yes Then
            '        My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Feedbacktostudents\" + Studenteopdragennaam.Remove(Studenteopdragennaam.LastIndexOf("x")) + "\" + Studenteopdragennaam + ".zip")
            '        My.Computer.FileSystem.CopyFile(strFileNameS, My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Feedbacktostudents\" + Studenteopdragennaam.Remove(Studenteopdragennaam.LastIndexOf("x")) + "\" + Studenteopdragennaam + ".zip")

            '    Else
            '        MessageBox.Show("Currently there Is no Option To Not overwrite files program will now quit, contact Juan.Steyn@nwu.ac.za")
            '        Me.Close()

            '    End If
            '   MessageBox.Show("Plek waar finish Is  " + publicstep2studentfilelocation + "Finished")
            If My.Computer.FileSystem.DirectoryExists(publicstep3finishedfolder + "\" + "Finished") Then
            Else
                My.Computer.FileSystem.CreateDirectory(publicstep3finishedfolder + "\" + "Finished")
            End If
            '     MessageBox.Show(strFileNameS.Remove(0, positions + 1) + "Dit is die naam van die file wat na finish toe skuif, maak seker of papotm daar is")
            My.Computer.FileSystem.CopyFile(strFileNameS, publicstep3finishedfolder + "\" + "Finished" + "\" + strFileNameS.Remove(0, positions + 1))
            My.Computer.FileSystem.DeleteFile(strFileNameS)
            '  My.Computer.FileSystem.DeleteFile(strFileNameS.Replace(".papot", ".zip"))
            ' textfilelocation = ""
            Dim fileslocationconversation As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\StudentResponse.txt"
            'For Each foundFile As String In My.Computer.FileSystem.GetFiles(tempdirectory)
            '    If foundFile.Contains("StudentResponse") Then
            '        fileslocation = foundFile.ToString
            '        fileslocation = fileslocation.Remove(fileslocation.LastIndexOf("\"))
            '        '  MessageBox.Show(textfilelocation + "   " + fileslocation)
            '    End If
            'Next


            ''Weet wat is die fout
            ''''''????? Hier kort n if as die daar nie word by dei hele proses gecopy is nie..
            If My.Computer.FileSystem.DirectoryExists(tempdirectory + "\words") = True Then
                '  MessageBox.Show("words found")
                'For Each foundFilewords As String In My.Computer.FileSystem.GetFiles(tempdirectory + "\words\")
                '    If foundFilewords.Contains("Studentresponsewords") Then
                '        MessageBox.Show("studentrespnsewords found")
                '        wordstextfilelocation = foundFilewords.ToString
                '        wordsfileslocation = wordstextfilelocation
                '        wordsfileslocation = wordsfileslocation.Remove(wordsfileslocation.LastIndexOf("\"))
                '    End If
                'Next
                wordsfileslocation = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\words\Studentresponsewords.txt"
                wordsfeedback = True

            End If
            'die deel lees die stuf in die listbox in
            Dim fileReader As System.IO.StreamReader
            fileReader = New System.IO.StreamReader(fileslocationconversation)
            Dim testfin As Boolean = False
            Dim stringreader As String
            Do While testfin = False
                stringreader = fileReader.ReadLine()
                '   MessageBox.Show(stringreader + "afvoer van resonses nie words")
                If (stringreader = "End") Or (stringreader = "endwords") Or (stringreader = "") Then
                    testfin = True
                    ' MessageBox.Show(ListBoxStep3StudentHomework.Items(ListBoxStep3StudentHomework.Items.Count - 1).ToString)
                    ListBoxStep3StudentHomework.Items.RemoveAt(ListBoxStep3StudentHomework.Items.Count - 1)

                    fileReader.Close()
                Else
                    ListBoxStep3StudentHomework.Items.Add(tempdirectory + "\" + stringreader)
                    '      MessageBox.Show(stringreader)
                    '   ListBoxStep3StudentHomework.Items.Add(fileslocation + "\" + stringreader)
                End If
            Loop

            If My.Computer.FileSystem.DirectoryExists(tempdirectory + "\words") = True Then
                Dim fileReaderwords As System.IO.StreamReader
                fileReaderwords = New System.IO.StreamReader(wordsfileslocation)
                Dim testfinwords As Boolean = False
                Dim stringreaderwords As String
                countamountofword = -1
                Do While testfinwords = False
                    countamountofword = countamountofword + 1
                    stringreaderwords = fileReaderwords.ReadLine()
                    If stringreaderwords = "endwords" Then
                        testfinwords = True
                        fileReaderwords.Close()
                    Else
                        ListBoxWords.Items.Add(tempdirectory + "\words\" + stringreaderwords)
                        ' hierdie word ingesit sodat word sommer as deel van die hele storie gebeur
                        ListBoxStep3StudentHomework.Items.Add(tempdirectory + "\words\" + stringreaderwords)

                        '  MessageBox.Show(stringreaderwords)
                    End If
                Loop
                ' ListBoxStep3StudentHomework.SelectedIndex = 'startcounterwords
            End If
            '???
            ListBoxStep3StudentHomework.SelectedIndex = 0 ' startcounter
            ButtonStep3OpenStudentWork.Visible = False
            ButtonStep3Step1.Visible = True
        Else
            MessageBox.Show("No homework file selected")
        End If


    End Sub

    Private Sub ButtonStep3Step1_Click(sender As Object, e As EventArgs) Handles ButtonStep3Step1.Click

        If CheckBoxMSaudiofeedback.Checked = False Then
        Else




        End If



        ButtonStep3Step1.Enabled = False

        ButtonStep3Step3.Visible = False
        ButtonStep3Step2.Visible = False
        PanelStep3Feedback.Visible = False
        ButtonStep3Stoprecordingfeedback.Visible = False


        ButtonStep3Step1.BackColor = Color.Red
        ButtonStep3Stoprecordingfeedback.BackColor = SystemColors.Control
        ButtonStep3Step2.BackColor = SystemColors.Control
        ButtonStep3Step3.BackColor = SystemColors.Control


        checkstep3feedback = False
        mciSendString("Stop recsound", "", 0, 0)
        mciSendString("close recsound", "", 0, 0)
        My.Computer.Audio.Play(ListBoxStep3StudentHomework.Items(startcounter), AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play((My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Needed\beep.wav"), AudioPlayMode.WaitToComplete)
        Dim mssg As String = ""
        My.Computer.Audio.Stop()
        mciSendString("open New Type waveaudio Alias recsound", "", 0, 0)
        mciSendString("Set recsound alignment 4 bitspersample 16 samplespersec 44100 channels 2 bytespersec 176400", "", 0, 0)
        mciSendString("record recsound", "", 0, 0)

        If (startcounter + 1) = ListBoxStep3StudentHomework.Items.Count Then
            ' MessageBox.Show("Laaste item")
            Labels3p1.Visible = True
            LabelsVar4.Visible = True
            NUDS3Pron.Visible = True

        End If


        '  If onlyaudiofeedback = True Then
        PanelStep3Feedback.Visible = False
        ' Else
        '  PanelStep3Feedback.Visible = True


        ' End If


        NUDS3Listen.Focus()
        If CheckBoxMSaudiofeedback.Checked = False Then
            ButtonStep3Step3.Visible = True

        Else
            ButtonStep3Stoprecordingfeedback.Visible = True

        End If

    End Sub

    Private Sub ButtonStep3Step2_Click(sender As Object, e As EventArgs) Handles ButtonStep3Step2.Click
        ButtonStep3Step1.BackColor = SystemColors.Control
        ButtonStep3Stoprecordingfeedback.BackColor = SystemColors.Control
        ButtonStep3Step2.BackColor = Color.LimeGreen
        ButtonStep3Step3.BackColor = SystemColors.Control

        mciSendString("Stop recsound", "", 0, 0)



        My.Computer.Audio.Stop()

        mciSendString("play recsound from 0", 0&, 0, 0)

        If (startcounter + 1) = ListBoxStep3StudentHomework.Items.Count Then
            Labels3p1.Visible = True
            LabelsVar4.Visible = True
            NUDS3Pron.Visible = True

        End If



        If onlyaudiofeedback = True Then
            PanelStep3Feedback.Visible = False
        Else
            If startcounter < (ListBoxStep3StudentHomework.Items.Count) - countamountofword Then
                PanelStep3Feedback.Visible = True
            End If


        End If
        NUDS3Listen.Focus()


    End Sub

    Private Sub ButtonStep3Step3_Click(sender As Object, e As EventArgs) Handles ButtonStep3Step3.Click

        ButtonStep3Step1.BackColor = SystemColors.Control
        ButtonStep3Stoprecordingfeedback.BackColor = SystemColors.Control
        ButtonStep3Step2.BackColor = SystemColors.Control
        ButtonStep3Step3.BackColor = Color.CornflowerBlue
        'MessageBox.Show(startcounter.ToString + "First  " + ListBoxStep3StudentHomework.Items.Count.ToString)

        mciSendString("Stop recsound", "", 0, 0)
        Dim filewritten As String
        filewritten = ""
        If CheckBoxMSaudiofeedback.Checked = False Then
            ButtonStep3Step1.Enabled = True
        Else


        End If
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final") Then
        Else
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final")
        End If

        'My.Computer.FileSystem.CreateDirectory("C\Papotons\Temp\ResponsesTeach")
        Dim input As String = ""

        input = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\" + studentenommer + ".wav"

        mciSendString("save recsound " + input, "", 0, 0)
        mciSendString("close recsound", "", 0, 0)
        '    MessageBox.Show(ListBoxStep3StudentHomework.Items(startcounter) + " Listboxdetail where response is saved")

        Dim wav1 As List(Of Byte) = IO.File.ReadAllBytes(ListBoxStep3StudentHomework.Items(startcounter)).ToList
        Dim wav2 As List(Of Byte) = IO.File.ReadAllBytes(input).ToList

        wav1 = Join(wav1, wav2)

        My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final\" + startcounter.ToString + studentenommer + ".wav", wav1.ToArray, True)

        '  MessageBox.Show(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final\" + startcounter.ToString + studentenommervirhuiswerk + ".wav" + " Where combined file  is saved")

        ListBoxStep3Final.Items.Add(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final\" + startcounter.ToString + studentenommer + ".wav")
        '  MessageBox.Show(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final\" + startcounter.ToString + studentenommervirhuiswerk + ".wav" + " Where combined file  is saved in listbox")


        If onlyaudiofeedback = True Then

        Else
            '' hierdie deel is eers vir as jy wil punte gee!!
            If onlyatend = True Then
            Else
                Dim objWriterEval As New System.IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final\Feedback_" + Studenteopdragennaam + "_" + studentenommer + ".txt", True)
                '    MessageBox.Show("Locaiton of feedback writeline " + My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final\Feedback_" + projectnamepublic + ".txt")
                If startcounter = 0 Then
                    objWriterEval.WriteLine("Questions, " + LabelVar1.Text + "(_/" + MAXVAR1.ToString + ")" + ", " + LabelVar2.Text + "(_/" + MAXVAR2.ToString + "), " + Labelvar3.Text + "(_/" + MAXVAR3.ToString + "), Your mark, Max Mark")
                    maxmark = 0
                    yourmark = 0

                End If

                Dim yourmarkline As Integer = (NUDFormulation.Value + NUDS3Listen.Value + NUDS3Replies.Value)

                If startcounter < (ListBoxStep3StudentHomework.Items.Count) - countamountofword Then
                    maxmark = maxmark + (NUDFormulation.Maximum + NUDS3Listen.Maximum + NUDS3Replies.Maximum)
                    yourmark = yourmark + yourmarkline
                    objWriterEval.WriteLine("Question " + startcounter.ToString + ", " + NUDS3Listen.Value.ToString + ", " + NUDS3Replies.Value.ToString + ", " + NUDFormulation.Value.ToString + ", " + yourmarkline.ToString + ", " + (NUDFormulation.Maximum + NUDS3Listen.Maximum + NUDS3Replies.Maximum).ToString)
                    objWriterEval.Close()
                End If
                ''???

                objWriterEval.Close()
            End If


        End If


        startcounter = startcounter + 1
        If startcounter = (ListBoxStep3StudentHomework.Items.Count) - countamountofword Then

            If onlyaudiofeedback = False Then
                ' hierdie is ook deel van werk vir merk
                If onlyatend = True Then
                    FormOnlyatend.Show()
                    FormOnlyatend.NUDFormulation.Value = 0
                    FormOnlyatend.NUDS3Listen.Value = 0
                    FormOnlyatend.NUDS3Pron.Value = 0
                    FormOnlyatend.NUDS3Replies.Value = 0
                    'FormOnlyatend.Location = (0, 0)
                Else
                    Dim objWriterEval As New System.IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final\Feedback_" + Studenteopdragennaam + "_" + studentenommer + ".txt", True)

                    objWriterEval.WriteLine("Sub-total For questions,,, " + (100 - relationshipevaluation).ToString + "%, " + yourmark.ToString + ", " + maxmark.ToString)
                    objWriterEval.WriteLine("Overall pronunciation,,, " + relationshipevaluation.ToString + "%, " + NUDS3Pron.Value.ToString + ", " + "4")
                    Dim finalpersentage As Double = ((yourmark / maxmark) * (100 - relationshipevaluation) / 100) + ((NUDS3Pron.Value / MAXVAR4) * relationshipevaluation / 100)
                    finalpercentagepublic = Math.Round(finalpersentage, 3) * 100
                    objWriterEval.WriteLine("Final %,,,,, " + finalpercentagepublic.ToString)
                    objWriterEval.Close()
                    My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Classlists\")
                    '      MessageBox.Show("Place where directory is stored"(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Classlists\"))

                    Dim objWriterclasslist As New System.IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Classlists\" + Studenteopdragennaam + ".txt", True)

                    objWriterclasslist.WriteLine(Studenteopdragennaam + ", " + studentenommer + ", " + finalpercentagepublic.ToString)

                    objWriterclasslist.Close()
                End If




            Else




            End If




        End If



        '   MessageBox.Show(startcounter.ToString + "A listbox" + ListBoxStep3StudentHomework.Items.Count)
        If startcounter = ListBoxStep3StudentHomework.Items.Count Then
            Dim result As Integer = MessageBox.Show("You have completed giving feedback for this particular student. Open New homework.", "", MessageBoxButtons.OK)

            If result = DialogResult.OK Then
                wordsfeedback = False
                LabelWordsFeedback.Visible = False
                Labels3p1.Visible = False
                LabelsVar4.Visible = False
                NUDS3Pron.Visible = False

                ListBoxStep3StudentHomework.Items.Clear()
                Dim counter As Integer
                counter = 0
                'ListBoxStep3Final.Refresh()
                'MessageBox.Show(ListBoxStep3Final.Items.Count.ToString() + " how many items   " + ListBoxStep3StudentHomework.Items(0).ToString)
                Dim wavconcat1 As List(Of Byte) = IO.File.ReadAllBytes(ListBoxStep3Final.Items(0)).ToList
                Dim wavconcat2 As List(Of Byte)
                '  MessageBox.Show(ListBoxStep3Final.Items(0).ToString())

                Do While counter < ListBoxStep3Final.Items.Count
                    '' hier doen hy die final merge

                    counter = counter + 1
                    If counter = ListBoxStep3Final.Items.Count Then
                        '  MessageBox.Show(Studenteopdragennaam + "studentopdragennaam")
                        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + Studenteopdragennaam + "\" + studentenommer)
                        '  MessageBox.Show(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + projectnamepublic + "\" + Studenteopdragennaam + "  waar goed gestroot moet word van n opdrag")
                        '''??????????????????????
                        My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + Studenteopdragennaam + "\" + studentenommer + "\Feedback_" + Studenteopdragennaam + "_" + studentenommer + ".wav", wavconcat1.ToArray, True)
                        '  MessageBox.Show("Waar die feedback gestoor word   " + My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + projectnamepublic + "\" + Studenteopdragennaam + "\Feedback_testtest.wav")
                    Else
                        '   MessageBox.Show(counter.ToString)
                        wavconcat2 = IO.File.ReadAllBytes(ListBoxStep3Final.Items(counter)).ToList
                        wavconcat1 = Join(wavconcat1, wavconcat2) '   wavconcat1 = IO.File.ReadAllBytes(ListBoxStep3Final.Items(counter)).ToList
                    End If

                Loop

                ListBoxStep3Final.Items.Clear()

                '     My.Computer.FileSystem.CopyFile("C: \Papotons\Temp\ResponsesTeach\Final\" + Studenteopdragennaam + "feedback" + studentenommervirhuiswerk + ".txt", "C:\Papotons\Temp\ResponsesTeach\Final\" + Studenteopdragennaam + "feedback" + studentenommervirhuiswerk + ".csv")
                'My.Computer.FileSystem.DeleteFile("C:\Papotons\Temp\ResponsesTeach\Final\" + Studenteopdragennaam + "feedback" + studentenommervirhuiswerk + ".txt")
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\Backup\" + Studenteopdragennaam + "\" + studentenommer)

                '  MessageBox.Show("concat nou hier die wav files")
                My.Computer.FileSystem.CopyDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final", My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\Backup\" + Studenteopdragennaam + "\" + studentenommer, True)
                If onlyaudiofeedback = True Then
                Else
                    ' vir merk feedback??????????? moet CSV uitskryf
                    '  My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\Temp\ResponsesTeach\Final\Feedback_" + projectnamepublic + ".txt", (My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + projectnamepublic + "\" + Studenteopdragennaam + "\Feedback_.csv"))

                End If


                If testforonlymarks = True Then


                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Papotons\FeedbackToStudents\" + Studenteopdragennaam + "\" + studentenommer + "\Feedback_" + Studenteopdragennaam + "_" + studentenommer + ".wav")



                End If
                '  ??? 'C:\Users\20095066\Documents\Papotons\Temp\ResponsesTeach\Fina

                startcounter = 0


                ButtonStep3OpenStudentWork.Visible = True
                ButtonStep3Step3.Visible = False
                ButtonStep3Step2.Visible = False
                ButtonStep3Step1.Visible = False
                ButtonStep3Stoprecordingfeedback.Visible = False



            End If
        Else
            ListBoxStep3StudentHomework.SelectedIndex = startcounter
        End If
        '    If onlyaudiofeedback = True Then
        PanelStep3Feedback.Visible = False
        '   Else
        '   PanelStep3Feedback.Visible = Fa


        '   End If

        '   End If
        NUDS3Listen.Value = 0
        NUDS3Pron.Value = 0
        NUDS3Replies.Value = 0
        NUDFormulation.Value = 0

        ButtonStep3Step3.BackColor = SystemColors.Control

        ButtonStep3Step3.Visible = False
        ButtonStep3Stoprecordingfeedback.Visible = False
        ButtonStep3Step2.Visible = False

    End Sub







    Private Sub ListBoxStep1TeachSnippets_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        ' My.Computer.Audio.Play(ListBoxStep1TeachSnippets.SelectedItem.ToString)
    End Sub

    Private Sub ListBoxStep2StudentHomework_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxStep2StudentHomework.MouseDoubleClick
        My.Computer.Audio.Play(ListBoxStep2StudentHomework.SelectedItem.ToString)
    End Sub

    Private Sub ListBoxStep3StudentHomework_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxStep3StudentHomework.MouseDoubleClick
        My.Computer.Audio.Play(ListBoxStep3StudentHomework.SelectedItem.ToString)
    End Sub









    Private Sub ButtonStep3Stoprecordingfeedback_Click(sender As Object, e As EventArgs) Handles ButtonStep3Stoprecordingfeedback.Click
        ButtonStep3Step1.Enabled = True


        ButtonStep3Step1.BackColor = SystemColors.Control
        ButtonStep3Stoprecordingfeedback.BackColor = Color.CornflowerBlue
        ButtonStep3Step2.BackColor = SystemColors.Control
        ButtonStep3Step3.BackColor = SystemColors.Control

        mciSendString("stop recsound", "", 0, 0)

        'My.Computer.Audio.Stop()
        ' My.Computer.Audio.Play(ListBoxStep3StudentHomework.Items(startcounter), AudioPlayMode.WaitToComplete)


        ' My.Computer.Audio.Stop()

        '     mciSendString("play recsound from 0", 0&, 0, 0)

        If (startcounter + 1) = (ListBoxStep3StudentHomework.Items.Count - countamountofword) Then
            '    MessageBox.Show("Laaste item")
            Labels3p1.Visible = True
            LabelsVar4.Visible = True
            NUDS3Pron.Visible = True

        End If


        If onlyaudiofeedback = True Then
            PanelStep3Feedback.Visible = False
        Else
            If onlyatend = True Then
            Else
                If startcounter < (ListBoxStep3StudentHomework.Items.Count - countamountofword) Then
                    PanelStep3Feedback.Visible = True
                End If
            End If




        End If

        NUDS3Listen.Focus()



        ButtonStep3Step3.Visible = True
        If CheckBoxMSaudiofeedback.Checked = True Then
            ButtonStep3Step2.Visible = True
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ButtonMSNext_Click(sender As Object, e As EventArgs) Handles ButtonMSNext.Click
        If CheckBoxMSaudiofeedback.Checked = False And CheckBoxMSMarks.Checked = False Then
            MessageBox.Show("Please choose at least one form of feedback")

        Else



            If CheckBoxMSMarks.Checked = True Then

                FormMSMarkingGrid.Show()
                FormMSMarkingGrid.Location = New Size(0, 0)
                Me.Hide()
                PanelChooseMS.Visible = False
                LabelMarkingmode.Text = "Currently only giving audio feedback And marks. Restart program to choose new feedback mode."
                If CheckBoxMSaudiofeedback.Checked = False Then
                    testforonlymarks = True
                    LabelMarkingmode.Text = "Currently only giving marks. No audio feedback will be given. Restart program to choose new feedback mode."
                End If
                LabelMarkingmode.Visible = True

            Else

                ButtonStep3OpenStudentWork.Visible = True

                onlyaudiofeedback = True
                testforonlymarks = False
                PanelChooseMS.Visible = False
                LabelMarkingmode.Text = "Currently only giving audio feedback. Restart program to choose New feedback mode."
                LabelMarkingmode.Visible = True

            End If
        End If
      
    End Sub

    Private Sub Label18_Click_1(sender As Object, e As EventArgs) Handles LabelMarkingmode.Click

    End Sub
End Class