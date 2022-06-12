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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.F_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.F_Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.F_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.F_PageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.F_Print = New System.Windows.Forms.ToolStripMenuItem()
        Me.F_PrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.F_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_Undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_Redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.E_Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_ClearAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.E_Find = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_FindNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_Replace = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_GoTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.E_SelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_DateTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_Date = New System.Windows.Forms.ToolStripMenuItem()
        Me.E_DeselectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_Font = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_WordWrap = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_Bold = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_Italic = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_Underline = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_Strikethrough = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_Alignment = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_Left = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_Right = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_Center = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Fo_BackgroundColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_FontColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_PageColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fo_TextHighlightColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.V_StatusBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.V_Zoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.Z_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Z_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Z_8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Z_12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Z_16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Z_20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_ViewHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_AboutNotepad = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Con_Undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Con_Redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Con_Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Con_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.Con_Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.Con_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Con_SelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Con_RightToLeftReadingOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(774, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F_New, Me.F_Open, Me.F_Save, Me.F_SaveAs, Me.ToolStripSeparator1, Me.F_PageSetup, Me.F_Print, Me.F_PrintPreview, Me.ToolStripSeparator2, Me.F_Exit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'F_New
        '
        Me.F_New.Image = Global.Notepad.My.Resources.Resources.Capture18
        Me.F_New.Name = "F_New"
        Me.F_New.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.F_New.Size = New System.Drawing.Size(180, 22)
        Me.F_New.Text = "New"
        '
        'F_Open
        '
        Me.F_Open.Image = Global.Notepad.My.Resources.Resources.Capture19
        Me.F_Open.Name = "F_Open"
        Me.F_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.F_Open.Size = New System.Drawing.Size(180, 22)
        Me.F_Open.Text = "Open"
        '
        'F_Save
        '
        Me.F_Save.Image = Global.Notepad.My.Resources.Resources.Capture20
        Me.F_Save.Name = "F_Save"
        Me.F_Save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.F_Save.Size = New System.Drawing.Size(180, 22)
        Me.F_Save.Text = "Save"
        '
        'F_SaveAs
        '
        Me.F_SaveAs.Name = "F_SaveAs"
        Me.F_SaveAs.Size = New System.Drawing.Size(180, 22)
        Me.F_SaveAs.Text = "Save As"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'F_PageSetup
        '
        Me.F_PageSetup.Name = "F_PageSetup"
        Me.F_PageSetup.Size = New System.Drawing.Size(180, 22)
        Me.F_PageSetup.Text = "Page Setup"
        '
        'F_Print
        '
        Me.F_Print.Name = "F_Print"
        Me.F_Print.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.F_Print.Size = New System.Drawing.Size(180, 22)
        Me.F_Print.Text = "Print"
        '
        'F_PrintPreview
        '
        Me.F_PrintPreview.Name = "F_PrintPreview"
        Me.F_PrintPreview.Size = New System.Drawing.Size(180, 22)
        Me.F_PrintPreview.Text = "Print Preview"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'F_Exit
        '
        Me.F_Exit.Name = "F_Exit"
        Me.F_Exit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.F_Exit.Size = New System.Drawing.Size(180, 22)
        Me.F_Exit.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.E_Undo, Me.E_Redo, Me.CutToolStripMenuItem, Me.E_Cut, Me.E_Copy, Me.E_Paste, Me.E_ClearAll, Me.E_Delete, Me.ToolStripSeparator3, Me.E_Find, Me.E_FindNext, Me.E_Replace, Me.E_GoTo, Me.ToolStripSeparator4, Me.E_SelectAll, Me.E_DateTime, Me.E_Date, Me.E_DeselectAll})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'E_Undo
        '
        Me.E_Undo.Image = Global.Notepad.My.Resources.Resources.Capture13
        Me.E_Undo.Name = "E_Undo"
        Me.E_Undo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.E_Undo.Size = New System.Drawing.Size(180, 22)
        Me.E_Undo.Text = "Undo"
        '
        'E_Redo
        '
        Me.E_Redo.Image = Global.Notepad.My.Resources.Resources.Capture14
        Me.E_Redo.Name = "E_Redo"
        Me.E_Redo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.E_Redo.Size = New System.Drawing.Size(180, 22)
        Me.E_Redo.Text = "Redo"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(177, 6)
        '
        'E_Cut
        '
        Me.E_Cut.Image = Global.Notepad.My.Resources.Resources.Capture7
        Me.E_Cut.Name = "E_Cut"
        Me.E_Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.E_Cut.Size = New System.Drawing.Size(180, 22)
        Me.E_Cut.Text = "Cut"
        '
        'E_Copy
        '
        Me.E_Copy.Image = Global.Notepad.My.Resources.Resources.Capture8
        Me.E_Copy.Name = "E_Copy"
        Me.E_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.E_Copy.Size = New System.Drawing.Size(180, 22)
        Me.E_Copy.Text = "Copy"
        '
        'E_Paste
        '
        Me.E_Paste.Image = Global.Notepad.My.Resources.Resources.Capture6
        Me.E_Paste.Name = "E_Paste"
        Me.E_Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.E_Paste.Size = New System.Drawing.Size(180, 22)
        Me.E_Paste.Text = "Paste"
        '
        'E_ClearAll
        '
        Me.E_ClearAll.Name = "E_ClearAll"
        Me.E_ClearAll.ShowShortcutKeys = False
        Me.E_ClearAll.Size = New System.Drawing.Size(180, 22)
        Me.E_ClearAll.Text = "Clear All"
        '
        'E_Delete
        '
        Me.E_Delete.Name = "E_Delete"
        Me.E_Delete.ShowShortcutKeys = False
        Me.E_Delete.Size = New System.Drawing.Size(180, 22)
        Me.E_Delete.Text = "Delete"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'E_Find
        '
        Me.E_Find.Image = Global.Notepad.My.Resources.Resources.Capture151
        Me.E_Find.Name = "E_Find"
        Me.E_Find.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.E_Find.Size = New System.Drawing.Size(180, 22)
        Me.E_Find.Text = "Find"
        '
        'E_FindNext
        '
        Me.E_FindNext.Image = Global.Notepad.My.Resources.Resources.Capture16
        Me.E_FindNext.Name = "E_FindNext"
        Me.E_FindNext.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.E_FindNext.Size = New System.Drawing.Size(180, 22)
        Me.E_FindNext.Text = "Find Next"
        '
        'E_Replace
        '
        Me.E_Replace.Name = "E_Replace"
        Me.E_Replace.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.E_Replace.Size = New System.Drawing.Size(180, 22)
        Me.E_Replace.Text = "Replace"
        '
        'E_GoTo
        '
        Me.E_GoTo.Name = "E_GoTo"
        Me.E_GoTo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.E_GoTo.Size = New System.Drawing.Size(180, 22)
        Me.E_GoTo.Text = "Go To"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'E_SelectAll
        '
        Me.E_SelectAll.Image = Global.Notepad.My.Resources.Resources.Capture17
        Me.E_SelectAll.Name = "E_SelectAll"
        Me.E_SelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.E_SelectAll.Size = New System.Drawing.Size(180, 22)
        Me.E_SelectAll.Text = "Select All"
        '
        'E_DateTime
        '
        Me.E_DateTime.Name = "E_DateTime"
        Me.E_DateTime.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.E_DateTime.Size = New System.Drawing.Size(180, 22)
        Me.E_DateTime.Text = "Date/Time"
        '
        'E_Date
        '
        Me.E_Date.Name = "E_Date"
        Me.E_Date.Size = New System.Drawing.Size(180, 22)
        Me.E_Date.Text = "Date"
        '
        'E_DeselectAll
        '
        Me.E_DeselectAll.Name = "E_DeselectAll"
        Me.E_DeselectAll.Size = New System.Drawing.Size(180, 22)
        Me.E_DeselectAll.Text = "Deselect All"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Fo_Font, Me.Fo_WordWrap, Me.Fo_Bold, Me.Fo_Italic, Me.Fo_Underline, Me.Fo_Strikethrough, Me.Fo_Alignment, Me.ToolStripSeparator5, Me.Fo_BackgroundColor, Me.Fo_FontColor, Me.Fo_PageColor, Me.Fo_TextHighlightColor})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'Fo_Font
        '
        Me.Fo_Font.Image = Global.Notepad.My.Resources.Resources.Capture12
        Me.Fo_Font.Name = "Fo_Font"
        Me.Fo_Font.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.Fo_Font.Size = New System.Drawing.Size(189, 22)
        Me.Fo_Font.Text = "Font"
        '
        'Fo_WordWrap
        '
        Me.Fo_WordWrap.CheckOnClick = True
        Me.Fo_WordWrap.Image = Global.Notepad.My.Resources.Resources.icons8_word_wrap_24
        Me.Fo_WordWrap.Name = "Fo_WordWrap"
        Me.Fo_WordWrap.Size = New System.Drawing.Size(189, 22)
        Me.Fo_WordWrap.Text = "Word Wrap"
        '
        'Fo_Bold
        '
        Me.Fo_Bold.Image = Global.Notepad.My.Resources.Resources.Capture3
        Me.Fo_Bold.Name = "Fo_Bold"
        Me.Fo_Bold.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.Fo_Bold.Size = New System.Drawing.Size(189, 22)
        Me.Fo_Bold.Text = "Bold"
        '
        'Fo_Italic
        '
        Me.Fo_Italic.Image = Global.Notepad.My.Resources.Resources.Capture4
        Me.Fo_Italic.Name = "Fo_Italic"
        Me.Fo_Italic.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.Fo_Italic.Size = New System.Drawing.Size(189, 22)
        Me.Fo_Italic.Text = "Italic"
        '
        'Fo_Underline
        '
        Me.Fo_Underline.Image = Global.Notepad.My.Resources.Resources.Capture5
        Me.Fo_Underline.Name = "Fo_Underline"
        Me.Fo_Underline.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.Fo_Underline.Size = New System.Drawing.Size(189, 22)
        Me.Fo_Underline.Text = "Underline"
        '
        'Fo_Strikethrough
        '
        Me.Fo_Strikethrough.Image = Global.Notepad.My.Resources.Resources.Capture11
        Me.Fo_Strikethrough.Name = "Fo_Strikethrough"
        Me.Fo_Strikethrough.Size = New System.Drawing.Size(189, 22)
        Me.Fo_Strikethrough.Text = "Strikethrough"
        '
        'Fo_Alignment
        '
        Me.Fo_Alignment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Fo_Left, Me.Fo_Right, Me.Fo_Center})
        Me.Fo_Alignment.Image = Global.Notepad.My.Resources.Resources.Capture10
        Me.Fo_Alignment.Name = "Fo_Alignment"
        Me.Fo_Alignment.Size = New System.Drawing.Size(189, 22)
        Me.Fo_Alignment.Text = "Alignment"
        '
        'Fo_Left
        '
        Me.Fo_Left.Image = Global.Notepad.My.Resources.Resources.icons8_align_text_right_50
        Me.Fo_Left.Name = "Fo_Left"
        Me.Fo_Left.Size = New System.Drawing.Size(114, 22)
        Me.Fo_Left.Text = "Left"
        '
        'Fo_Right
        '
        Me.Fo_Right.Image = Global.Notepad.My.Resources.Resources.icons8_align_text_left_50
        Me.Fo_Right.Name = "Fo_Right"
        Me.Fo_Right.Size = New System.Drawing.Size(114, 22)
        Me.Fo_Right.Text = "Right"
        '
        'Fo_Center
        '
        Me.Fo_Center.Image = Global.Notepad.My.Resources.Resources.icons8_align_text_center_50
        Me.Fo_Center.Name = "Fo_Center"
        Me.Fo_Center.Size = New System.Drawing.Size(114, 22)
        Me.Fo_Center.Text = "Center"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(186, 6)
        '
        'Fo_BackgroundColor
        '
        Me.Fo_BackgroundColor.Image = Global.Notepad.My.Resources.Resources.Capture
        Me.Fo_BackgroundColor.Name = "Fo_BackgroundColor"
        Me.Fo_BackgroundColor.Size = New System.Drawing.Size(189, 22)
        Me.Fo_BackgroundColor.Text = "Background Color"
        '
        'Fo_FontColor
        '
        Me.Fo_FontColor.Image = Global.Notepad.My.Resources.Resources.Capture9
        Me.Fo_FontColor.Name = "Fo_FontColor"
        Me.Fo_FontColor.Size = New System.Drawing.Size(189, 22)
        Me.Fo_FontColor.Text = "Font Color"
        '
        'Fo_PageColor
        '
        Me.Fo_PageColor.Image = Global.Notepad.My.Resources.Resources.Capture1
        Me.Fo_PageColor.Name = "Fo_PageColor"
        Me.Fo_PageColor.Size = New System.Drawing.Size(189, 22)
        Me.Fo_PageColor.Text = "Page Color"
        '
        'Fo_TextHighlightColor
        '
        Me.Fo_TextHighlightColor.Image = Global.Notepad.My.Resources.Resources.Capture2
        Me.Fo_TextHighlightColor.Name = "Fo_TextHighlightColor"
        Me.Fo_TextHighlightColor.Size = New System.Drawing.Size(189, 22)
        Me.Fo_TextHighlightColor.Text = "Text Highlight color"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Checked = True
        Me.ViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.V_StatusBar, Me.V_Zoom})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'V_StatusBar
        '
        Me.V_StatusBar.Name = "V_StatusBar"
        Me.V_StatusBar.Size = New System.Drawing.Size(180, 22)
        Me.V_StatusBar.Text = "Status Bar"
        '
        'V_Zoom
        '
        Me.V_Zoom.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Z_2, Me.Z_4, Me.Z_8, Me.Z_12, Me.Z_16, Me.Z_20})
        Me.V_Zoom.Name = "V_Zoom"
        Me.V_Zoom.Size = New System.Drawing.Size(180, 22)
        Me.V_Zoom.Text = "Zoom"
        '
        'Z_2
        '
        Me.Z_2.Name = "Z_2"
        Me.Z_2.Size = New System.Drawing.Size(180, 22)
        Me.Z_2.Text = "2"
        '
        'Z_4
        '
        Me.Z_4.Name = "Z_4"
        Me.Z_4.Size = New System.Drawing.Size(180, 22)
        Me.Z_4.Text = "4"
        '
        'Z_8
        '
        Me.Z_8.Name = "Z_8"
        Me.Z_8.Size = New System.Drawing.Size(180, 22)
        Me.Z_8.Text = "8"
        '
        'Z_12
        '
        Me.Z_12.Name = "Z_12"
        Me.Z_12.Size = New System.Drawing.Size(180, 22)
        Me.Z_12.Text = "12"
        '
        'Z_16
        '
        Me.Z_16.Name = "Z_16"
        Me.Z_16.Size = New System.Drawing.Size(180, 22)
        Me.Z_16.Text = "16"
        '
        'Z_20
        '
        Me.Z_20.Name = "Z_20"
        Me.Z_20.Size = New System.Drawing.Size(180, 22)
        Me.Z_20.Text = "20"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.H_ViewHelp, Me.H_AboutNotepad})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'H_ViewHelp
        '
        Me.H_ViewHelp.Name = "H_ViewHelp"
        Me.H_ViewHelp.Size = New System.Drawing.Size(180, 22)
        Me.H_ViewHelp.Text = "View Help"
        '
        'H_AboutNotepad
        '
        Me.H_AboutNotepad.Name = "H_AboutNotepad"
        Me.H_AboutNotepad.Size = New System.Drawing.Size(180, 22)
        Me.H_AboutNotepad.Text = "About Notepad"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Con_Undo, Me.Con_Redo, Me.ToolStripSeparator7, Me.Con_Cut, Me.Con_Copy, Me.Con_Paste, Me.Con_Delete, Me.ToolStripSeparator6, Me.Con_SelectAll, Me.ToolStripSeparator8, Me.Con_RightToLeftReadingOrder})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(234, 198)
        '
        'Con_Undo
        '
        Me.Con_Undo.Name = "Con_Undo"
        Me.Con_Undo.Size = New System.Drawing.Size(233, 22)
        Me.Con_Undo.Text = "Undo"
        '
        'Con_Redo
        '
        Me.Con_Redo.Name = "Con_Redo"
        Me.Con_Redo.Size = New System.Drawing.Size(233, 22)
        Me.Con_Redo.Text = "Redo"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.BackColor = System.Drawing.Color.Red
        Me.ToolStripSeparator7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(230, 6)
        '
        'Con_Cut
        '
        Me.Con_Cut.Name = "Con_Cut"
        Me.Con_Cut.Size = New System.Drawing.Size(233, 22)
        Me.Con_Cut.Text = "Cut"
        '
        'Con_Copy
        '
        Me.Con_Copy.Name = "Con_Copy"
        Me.Con_Copy.Size = New System.Drawing.Size(233, 22)
        Me.Con_Copy.Text = "Copy"
        '
        'Con_Paste
        '
        Me.Con_Paste.Name = "Con_Paste"
        Me.Con_Paste.Size = New System.Drawing.Size(233, 22)
        Me.Con_Paste.Text = "Paste"
        '
        'Con_Delete
        '
        Me.Con_Delete.Name = "Con_Delete"
        Me.Con_Delete.Size = New System.Drawing.Size(233, 22)
        Me.Con_Delete.Text = "Delete"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(230, 6)
        '
        'Con_SelectAll
        '
        Me.Con_SelectAll.Name = "Con_SelectAll"
        Me.Con_SelectAll.Size = New System.Drawing.Size(233, 22)
        Me.Con_SelectAll.Text = "Select All"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(230, 6)
        '
        'Con_RightToLeftReadingOrder
        '
        Me.Con_RightToLeftReadingOrder.Name = "Con_RightToLeftReadingOrder"
        Me.Con_RightToLeftReadingOrder.Size = New System.Drawing.Size(233, 22)
        Me.Con_RightToLeftReadingOrder.Text = "Right to left Reading order"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckPathExists = False
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Filter = resources.GetString("SaveFileDialog1.Filter")
        '
        'RichTextBox1
        '
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 25)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(774, 347)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 350)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(774, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 372)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Notepad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F_New As ToolStripMenuItem
    Friend WithEvents F_Open As ToolStripMenuItem
    Friend WithEvents F_Save As ToolStripMenuItem
    Friend WithEvents F_SaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents F_PageSetup As ToolStripMenuItem
    Friend WithEvents F_Print As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents F_Exit As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents E_Undo As ToolStripMenuItem
    Friend WithEvents E_Redo As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripSeparator
    Friend WithEvents E_Copy As ToolStripMenuItem
    Friend WithEvents E_Paste As ToolStripMenuItem
    Friend WithEvents E_ClearAll As ToolStripMenuItem
    Friend WithEvents E_Delete As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents E_Find As ToolStripMenuItem
    Friend WithEvents E_FindNext As ToolStripMenuItem
    Friend WithEvents E_Replace As ToolStripMenuItem
    Friend WithEvents E_GoTo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents E_SelectAll As ToolStripMenuItem
    Friend WithEvents E_DateTime As ToolStripMenuItem
    Friend WithEvents E_DeselectAll As ToolStripMenuItem
    Friend WithEvents E_Cut As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Fo_Font As ToolStripMenuItem
    Friend WithEvents Fo_WordWrap As ToolStripMenuItem
    Friend WithEvents Fo_Bold As ToolStripMenuItem
    Friend WithEvents Fo_Italic As ToolStripMenuItem
    Friend WithEvents Fo_Underline As ToolStripMenuItem
    Friend WithEvents Fo_Strikethrough As ToolStripMenuItem
    Friend WithEvents Fo_Alignment As ToolStripMenuItem
    Friend WithEvents Fo_Left As ToolStripMenuItem
    Friend WithEvents Fo_Right As ToolStripMenuItem
    Friend WithEvents Fo_Center As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents Fo_BackgroundColor As ToolStripMenuItem
    Friend WithEvents Fo_FontColor As ToolStripMenuItem
    Friend WithEvents Fo_PageColor As ToolStripMenuItem
    Friend WithEvents Fo_TextHighlightColor As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents V_StatusBar As ToolStripMenuItem
    Friend WithEvents V_Zoom As ToolStripMenuItem
    Friend WithEvents Z_2 As ToolStripMenuItem
    Friend WithEvents Z_4 As ToolStripMenuItem
    Friend WithEvents Z_8 As ToolStripMenuItem
    Friend WithEvents Z_12 As ToolStripMenuItem
    Friend WithEvents Z_16 As ToolStripMenuItem
    Friend WithEvents Z_20 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents H_ViewHelp As ToolStripMenuItem
    Friend WithEvents H_AboutNotepad As ToolStripMenuItem
    Friend WithEvents E_Date As ToolStripMenuItem
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents F_PrintPreview As ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Con_Undo As ToolStripMenuItem
    Friend WithEvents Con_Redo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents Con_Cut As ToolStripMenuItem
    Friend WithEvents Con_Copy As ToolStripMenuItem
    Friend WithEvents Con_Paste As ToolStripMenuItem
    Friend WithEvents Con_Delete As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents Con_SelectAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents Con_RightToLeftReadingOrder As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
End Class
