Imports System.IO
Public Class Form1

    Public fnd As String
    Public pos As Integer

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        RichTextBox1.Height = Me.Height
        RichTextBox1.Width = Me.Width
    End Sub

    Private Sub E_Cut_Click_1(sender As Object, e As EventArgs) Handles E_Cut.Click
        Clipboard.Clear()
        Clipboard.SetText(RichTextBox1.SelectedText)
        RichTextBox1.SelectedText = ""
    End Sub

    Private Sub E_Copy_Click(sender As Object, e As EventArgs) Handles E_Copy.Click
        Clipboard.Clear()
        Clipboard.SetText(RichTextBox1.SelectedText)
    End Sub

    Private Sub E_Paste_Click(sender As Object, e As EventArgs) Handles E_Paste.Click
        RichTextBox1.SelectedText = Clipboard.GetText
    End Sub

    Private Sub F_Font_Click(sender As Object, e As EventArgs) Handles Fo_Font.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub F_BackgroundColor_Click(sender As Object, e As EventArgs) Handles Fo_BackgroundColor.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub F_FontColor_Click(sender As Object, e As EventArgs) Handles Fo_FontColor.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub F_PageColor_Click(sender As Object, e As EventArgs) Handles Fo_PageColor.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub F_Exit_Click(sender As Object, e As EventArgs) Handles F_Exit.Click
        Close()
    End Sub

    Private Sub E_Undo_Click(sender As Object, e As EventArgs) Handles E_Undo.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub E_Redo_Click(sender As Object, e As EventArgs) Handles E_Redo.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub E_SelectAll_Click(sender As Object, e As EventArgs) Handles E_SelectAll.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub E_DateTime_Click(sender As Object, e As EventArgs) Handles E_DateTime.Click
        RichTextBox1.SelectedText = Now()
    End Sub

    Private Sub E_DeselectAll_Click(sender As Object, e As EventArgs) Handles E_DeselectAll.Click
        RichTextBox1.DeselectAll()
    End Sub

    Private Sub E_Date_Click(sender As Object, e As EventArgs) Handles E_Date.Click
        RichTextBox1.SelectedText = Today()
    End Sub

    Private Sub E_ClearAll_Click_1(sender As Object, e As EventArgs) Handles E_ClearAll.Click
        RichTextBox1.SelectionStart = 0
        RichTextBox1.Text = ""
    End Sub

    Private Sub E_Delete_Click(sender As Object, e As EventArgs) Handles E_Delete.Click
        RichTextBox1.SelectedText = ""
    End Sub

    Private Sub F_TextHighlightColor_Click(sender As Object, e As EventArgs) Handles Fo_TextHighlightColor.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionBackColor = ColorDialog1.Color
    End Sub

    Private Sub Z_2_Click_1(sender As Object, e As EventArgs) Handles Z_2.Click
        RichTextBox1.ZoomFactor = 2
    End Sub

    Private Sub Z_4_Click_1(sender As Object, e As EventArgs) Handles Z_4.Click
        RichTextBox1.ZoomFactor = 4
    End Sub

    Private Sub Z_8_Click_1(sender As Object, e As EventArgs) Handles Z_8.Click
        RichTextBox1.ZoomFactor = 8
    End Sub

    Private Sub Z_12_Click_1(sender As Object, e As EventArgs) Handles Z_12.Click
        RichTextBox1.ZoomFactor = 12
    End Sub

    Private Sub Z_16_Click_1(sender As Object, e As EventArgs) Handles Z_16.Click
        RichTextBox1.ZoomFactor = 16
    End Sub

    Private Sub Z_20_Click_1(sender As Object, e As EventArgs) Handles Z_20.Click
        RichTextBox1.ZoomFactor = 20
    End Sub

    Private Sub F_Bold_Click(sender As Object, e As EventArgs) Handles Fo_Bold.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Or FontStyle.Bold)
    End Sub

    Private Sub F_Italic_Click(sender As Object, e As EventArgs) Handles Fo_Italic.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Or FontStyle.Italic)
    End Sub

    Private Sub F_Underline_Click(sender As Object, e As EventArgs) Handles Fo_Underline.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Or FontStyle.Underline)
    End Sub

    Private Sub F_Strikethrough_Click(sender As Object, e As EventArgs) Handles Fo_Strikethrough.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, RichTextBox1.SelectionFont.Style Or FontStyle.Strikeout)
    End Sub

    Private Sub Fo_WordWrap_Click(sender As Object, e As EventArgs) Handles Fo_WordWrap.Click
        If Fo_WordWrap.Checked = False Then
            Fo_WordWrap.Checked = True
            RichTextBox1.WordWrap = True
        ElseIf Fo_WordWrap.Checked = True Then
            Fo_WordWrap.Checked = False
            RichTextBox1.WordWrap = False
        End If
    End Sub

    Private Sub F_Left_Click_1(sender As Object, e As EventArgs) Handles Fo_Left.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub F_Right_Click_1(sender As Object, e As EventArgs) Handles Fo_Right.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub F_Centre_Click_1(sender As Object, e As EventArgs) Handles Fo_Center.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub F_PageSetup_Click(sender As Object, e As EventArgs) Handles F_PageSetup.Click
        PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings
        If PageSetupDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
        End If
    End Sub

    Private Sub F_Print_Click(sender As Object, e As EventArgs) Handles F_Print.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDialog1.PrinterSettings
        PrintDialog1.ShowDialog()
        PrintDocument1.Print()
        ' PrintDialog1.ShowDialog()
    End Sub

    Private Sub F_PrintPreview_Click(sender As Object, e As EventArgs) Handles F_PrintPreview.Click
        If RichTextBox1.Text = "" Then
            MsgBox("Write the content to be printed")
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, font, Brushes.Black, 100, 100)
    End Sub

    Private Sub Con_Cut_Click(sender As Object, e As EventArgs) Handles Con_Cut.Click
        Clipboard.Clear()
        Clipboard.SetText(RichTextBox1.SelectedText)
        RichTextBox1.SelectedText = ""
    End Sub

    Private Sub Con_Copy_Click(sender As Object, e As EventArgs) Handles Con_Copy.Click
        Clipboard.Clear()
        Clipboard.SetText(RichTextBox1.SelectedText)
    End Sub

    Private Sub Con_Paste_Click(sender As Object, e As EventArgs) Handles Con_Paste.Click
        RichTextBox1.SelectedText = Clipboard.GetText
    End Sub

    Private Sub Con_Undo_Click(sender As Object, e As EventArgs) Handles Con_Undo.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub Con_Redo_Click(sender As Object, e As EventArgs) Handles Con_Redo.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub Con_Delete_Click(sender As Object, e As EventArgs) Handles Con_Delete.Click
        RichTextBox1.SelectedText = ""
    End Sub

    Private Sub Con_SelectAll_Click(sender As Object, e As EventArgs) Handles Con_SelectAll.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub Con_RightToLeftReadingOrder_Click(sender As Object, e As EventArgs) Handles Con_RightToLeftReadingOrder.Click
        ' RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
        If Con_RightToLeftReadingOrder.Checked = False Then
            Con_RightToLeftReadingOrder.Checked = True
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
        ElseIf Con_RightToLeftReadingOrder.Checked = True Then
            Con_RightToLeftReadingOrder.Checked = False
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
        End If
    End Sub
    Private Sub E_Find_Click(sender As Object, e As EventArgs) Handles E_Find.Click
        Dim p As Integer

        fnd = InputBox("Find What: ", "Find")
        p = InStr(RichTextBox1.Text, fnd, 0)
        If p = 0 Then
            MsgBox("Not found")
        Else
            RichTextBox1.SelectionStart = p - 1
            RichTextBox1.SelectionLength = Len(fnd)
            pos = p

        End If
    End Sub

    Private Sub E_FindNext_Click(sender As Object, e As EventArgs) Handles E_FindNext.Click
        Dim p As Integer
        MsgBox("Position Number = " & pos, Title:="Find Next")
        MsgBox("Finded What = " & fnd, Title:="Find Next")
        p = InStr(pos + 1, RichTextBox1.Text, fnd, CompareMethod.Text)
        If p = 0 Then
            MsgBox("Not found")
        Else
            RichTextBox1.SelectionStart = p - 1
            RichTextBox1.SelectionLength = Len(fnd)
            pos = p + 1
        End If
    End Sub

    Private Sub E_Replace_Click(sender As Object, e As EventArgs) Handles E_Replace.Click
        Dim fnd, rpl As String
        Dim p As Integer
        fnd = InputBox("Find what: ", "Replace")
        rpl = InputBox("Replace with: ", "Replace")
        p = 1
        While True
            p = InStr(p, RichTextBox1.Text, fnd, CompareMethod.Text)
            If p = 0 Then
                MsgBox("Not found")
                Exit While

            Else
                RichTextBox1.SelectionStart = p - 1
                RichTextBox1.SelectionLength = Len(fnd)
                MsgBox("Replace ?", vbQuestion + vbYesNo, "Replace")
                If MsgBoxResult.Yes Then
                    RichTextBox1.SelectedText = rpl
                    p += 1
                Else
                    p += 1
                End If
            End If
        End While
    End Sub

    Private Sub F_New_Click(sender As Object, e As EventArgs) Handles F_New.Click
        ' RichTextBox1.Text = ""
        ' RichTextBox1.Clear()
        'RichTextBox1.Focus()
        If RichTextBox1.Modified Then
            Dim a As MsgBoxResult
            a = MsgBox("Do you want to save changes to your content...", MsgBoxStyle.YesNoCancel, "New Document")
            If a = MsgBoxResult.No Then
                RichTextBox1.Clear()
            ElseIf a = MsgBoxResult.Cancel Then
            ElseIf a = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                Dim ob As StreamWriter = New StreamWriter(SaveFileDialog1.FileName)
                ob.WriteLine(RichTextBox1.Text)
                ob.Close()
                RichTextBox1.Clear()
            End If
        Else
            RichTextBox1.Clear()
        End If
        RichTextBox1.Focus()
    End Sub

    Private Sub F_Save_Click(sender As Object, e As EventArgs) Handles F_Save.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            MsgBox("Please enter the file name")
        Else
            'SaveFileDialog1.ShowDialog()
            Dim ob As StreamWriter = New StreamWriter(SaveFileDialog1.FileName)
            ob.WriteLine(RichTextBox1.Text)
            ob.Close()
            RichTextBox1.Clear()
            SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*|Pdf files (*.pdf)|*.pdf|Word Document (*.docx) | *.docx| Document (*.doc) | *.doc| Rich Text Format (*.rtf) |*.rtf| Web Page (*.html) |*.html| Excel Workbook (*.xlsx) |*.xlsx"
        End If

    End Sub

    Private Sub F_SaveAs_Click(sender As Object, e As EventArgs) Handles F_SaveAs.Click
        SaveFileDialog1.ShowDialog()
        Dim ob As StreamWriter = New StreamWriter(SaveFileDialog1.FileName)
        ob.WriteLine(RichTextBox1.Text)
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*|Pdf files (*.pdf)|*.pdf|Word Document (*.docx) | *.docx| Document (*.doc) | *.doc| Rich Text Format (*.rtf) |*.rtf| Web Page (*.html) |*.html| Excel Workbook (*.xlsx) |*.xlsx"
        ob.Close()
        RichTextBox1.Clear()
    End Sub

    Private Sub F_Open_Click(sender As Object, e As EventArgs) Handles F_Open.Click
        OpenFileDialog1.ShowDialog()
        Dim x As String
        Dim ob As StreamReader = New StreamReader(OpenFileDialog1.FileName)
        x = ob.ReadToEnd()
        RichTextBox1.Text = x
        RichTextBox1.Focus()
        ob.Close()
    End Sub

    Private Sub E_GoTo_Click(sender As Object, e As EventArgs) Handles E_GoTo.Click
        'Dim a As Integer
        '  n = 0
        '  l = 1
        ' For l = 1 To Len(RichTextBox1.Text)
        '
        '     If Mid(RichTextBox1.Text, l, 1) = vbNewLine Then
        '         n = n + 1
        '     End If
        ' Next
        ' MsgBox(n)
        'vbNewLine.IndexOf(n)
        '  Dim a As MsgBoxResult
        '

        'Line1:
        '
        '        Do
        '            If a =  Then
        '                a = a + 1
        '                GoTo Line1
        '            End If
        '
        '            '  Console.WriteLine("Value of a: {0}", a)
        '            a = a + 1
        '        Loop
        '        Console.ReadLine()

        ' RichTextBox1.Text = LineInput(a)
        'ToolStripStatusLabel3.Text = LineInput(3)

        '  RichTextBox1.Lines.ElementAt(LineInput(n))
        ''RichTextBox1.Lines.ElementAt(n)
        ''Cursor.Position()
        '' n = RichTextBox1.Text.IndexOf(n)
        ''b = RichTextBox1.Lines.ElementAt(n)
        ''RichTextBox1.Text = b.ToString()
        '

        Dim n As Integer

        n = RichTextBox1.SelectionStart
        n = RichTextBox1.GetLineFromCharIndex(n)
        MsgBox("Line number = " & n + 1)

        ' p = InputBox("Goto Position", "Enter Line Number")
        ' p = RichTextBox1.GetFirstCharIndexOfCurrentLine()
        ' Cursor.Position.X(pos)





        '   Dim Position As Integer = Me.RichTextBox1.SelectionStart

        ' Dim LIne As Integer = Me.RichTextBox1.GetLineFromCharIndex(Position)

        ' Dim Col As Integer = Position - Me.RichTextBox1.GetFirstCharIndexOfCurrentLine





    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = DateString
        ToolStripStatusLabel2.Text = TimeString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub V_StatusBar_Click(sender As Object, e As EventArgs) Handles V_StatusBar.Click

        ' MsgBox("Line number = " & n)
        ' c = Len(RichTextBox1.Lines)
        'c = Len(n)
        'RichTextBox1.GetCharIndexFromPosition = c
        'c=Len(LineInput)

        'c = RichTextBox1.GetFirstCharIndexFromLine(n)
        ' c = RichTextBox1.SelectionStart()
        'c = RichTextBox1.SelectionStart - 1
        'RichTextBox1.SelectionStart = c

        Dim n, c, d As Double
        n = RichTextBox1.SelectionStart
        n = RichTextBox1.GetLineFromCharIndex(n)

        d = RichTextBox1.GetFirstCharIndexOfCurrentLine()
        c = RichTextBox1.SelectionStart.ToString()

        ToolStripStatusLabel3.Text = "ln " & n + 1
        ToolStripStatusLabel4.Text = "Col " & c - d


    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        'ToolStripStatusLabel5.Text = "Total Letters : " + RichTextBox1.TextLength.ToString()

    End Sub

    Private Sub H_ViewHelp_Click(sender As Object, e As EventArgs) Handles H_ViewHelp.Click

    End Sub

    Private Sub H_AboutNotepad_Click(sender As Object, e As EventArgs) Handles H_AboutNotepad.Click

    End Sub
End Class



