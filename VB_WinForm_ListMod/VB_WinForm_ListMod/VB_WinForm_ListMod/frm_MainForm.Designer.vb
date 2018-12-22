<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MainForm
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
        Me.txtBx_Source = New System.Windows.Forms.TextBox()
        Me.txtBx_Result = New System.Windows.Forms.TextBox()
        Me.btn_Process = New System.Windows.Forms.Button()
        Me.chkBx_SeparateLines = New System.Windows.Forms.CheckBox()
        Me.chkBx_StringDelim = New System.Windows.Forms.CheckBox()
        Me.txtBx_StringDelim = New System.Windows.Forms.TextBox()
        Me.chkBx_LineDelim = New System.Windows.Forms.CheckBox()
        Me.txtBx_LineDelim = New System.Windows.Forms.TextBox()
        Me.chkBx_LnDelimLastLine = New System.Windows.Forms.CheckBox()
        Me.chkBx_AppendCount = New System.Windows.Forms.CheckBox()
        Me.chkBx_ReplaceCustomLineNum = New System.Windows.Forms.CheckBox()
        Me.txtBx_ReplaceCustomLineNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBx_Prefix = New System.Windows.Forms.TextBox()
        Me.txtBx_Suffix = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtBx_Source
        '
        Me.txtBx_Source.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBx_Source.Location = New System.Drawing.Point(12, 12)
        Me.txtBx_Source.Multiline = True
        Me.txtBx_Source.Name = "txtBx_Source"
        Me.txtBx_Source.Size = New System.Drawing.Size(139, 230)
        Me.txtBx_Source.TabIndex = 0
        Me.txtBx_Source.Text = "text{#}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text{#}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text{#}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text{#}"
        '
        'txtBx_Result
        '
        Me.txtBx_Result.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtBx_Result.Location = New System.Drawing.Point(321, 12)
        Me.txtBx_Result.Multiline = True
        Me.txtBx_Result.Name = "txtBx_Result"
        Me.txtBx_Result.Size = New System.Drawing.Size(139, 256)
        Me.txtBx_Result.TabIndex = 1
        '
        'btn_Process
        '
        Me.btn_Process.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_Process.Location = New System.Drawing.Point(321, 277)
        Me.btn_Process.Name = "btn_Process"
        Me.btn_Process.Size = New System.Drawing.Size(114, 23)
        Me.btn_Process.TabIndex = 2
        Me.btn_Process.Text = "Process"
        Me.btn_Process.UseVisualStyleBackColor = True
        '
        'chkBx_SeparateLines
        '
        Me.chkBx_SeparateLines.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkBx_SeparateLines.AutoSize = True
        Me.chkBx_SeparateLines.Checked = True
        Me.chkBx_SeparateLines.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBx_SeparateLines.Location = New System.Drawing.Point(157, 14)
        Me.chkBx_SeparateLines.Name = "chkBx_SeparateLines"
        Me.chkBx_SeparateLines.Size = New System.Drawing.Size(97, 17)
        Me.chkBx_SeparateLines.TabIndex = 3
        Me.chkBx_SeparateLines.Text = "Separate Lines"
        Me.chkBx_SeparateLines.UseVisualStyleBackColor = True
        '
        'chkBx_StringDelim
        '
        Me.chkBx_StringDelim.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkBx_StringDelim.AutoSize = True
        Me.chkBx_StringDelim.Location = New System.Drawing.Point(157, 37)
        Me.chkBx_StringDelim.Name = "chkBx_StringDelim"
        Me.chkBx_StringDelim.Size = New System.Drawing.Size(96, 17)
        Me.chkBx_StringDelim.TabIndex = 4
        Me.chkBx_StringDelim.Text = "String Delimiter"
        Me.chkBx_StringDelim.UseVisualStyleBackColor = True
        '
        'txtBx_StringDelim
        '
        Me.txtBx_StringDelim.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBx_StringDelim.Enabled = False
        Me.txtBx_StringDelim.Location = New System.Drawing.Point(270, 35)
        Me.txtBx_StringDelim.Name = "txtBx_StringDelim"
        Me.txtBx_StringDelim.Size = New System.Drawing.Size(29, 20)
        Me.txtBx_StringDelim.TabIndex = 5
        Me.txtBx_StringDelim.Text = """"
        '
        'chkBx_LineDelim
        '
        Me.chkBx_LineDelim.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkBx_LineDelim.AutoSize = True
        Me.chkBx_LineDelim.Location = New System.Drawing.Point(157, 60)
        Me.chkBx_LineDelim.Name = "chkBx_LineDelim"
        Me.chkBx_LineDelim.Size = New System.Drawing.Size(89, 17)
        Me.chkBx_LineDelim.TabIndex = 6
        Me.chkBx_LineDelim.Text = "Line Delimiter"
        Me.chkBx_LineDelim.UseVisualStyleBackColor = True
        '
        'txtBx_LineDelim
        '
        Me.txtBx_LineDelim.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBx_LineDelim.Enabled = False
        Me.txtBx_LineDelim.Location = New System.Drawing.Point(270, 61)
        Me.txtBx_LineDelim.Name = "txtBx_LineDelim"
        Me.txtBx_LineDelim.Size = New System.Drawing.Size(29, 20)
        Me.txtBx_LineDelim.TabIndex = 7
        Me.txtBx_LineDelim.Text = ","
        '
        'chkBx_LnDelimLastLine
        '
        Me.chkBx_LnDelimLastLine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkBx_LnDelimLastLine.AutoSize = True
        Me.chkBx_LnDelimLastLine.Location = New System.Drawing.Point(173, 83)
        Me.chkBx_LnDelimLastLine.Name = "chkBx_LnDelimLastLine"
        Me.chkBx_LnDelimLastLine.Size = New System.Drawing.Size(122, 17)
        Me.chkBx_LnDelimLastLine.TabIndex = 8
        Me.chkBx_LnDelimLastLine.Text = "Include on Last Line"
        Me.chkBx_LnDelimLastLine.UseVisualStyleBackColor = True
        '
        'chkBx_AppendCount
        '
        Me.chkBx_AppendCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkBx_AppendCount.AutoSize = True
        Me.chkBx_AppendCount.Location = New System.Drawing.Point(157, 106)
        Me.chkBx_AppendCount.Name = "chkBx_AppendCount"
        Me.chkBx_AppendCount.Size = New System.Drawing.Size(117, 17)
        Me.chkBx_AppendCount.TabIndex = 9
        Me.chkBx_AppendCount.Text = "Append Line Count"
        Me.chkBx_AppendCount.UseVisualStyleBackColor = True
        '
        'chkBx_ReplaceCustomLineNum
        '
        Me.chkBx_ReplaceCustomLineNum.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkBx_ReplaceCustomLineNum.AutoSize = True
        Me.chkBx_ReplaceCustomLineNum.Location = New System.Drawing.Point(157, 177)
        Me.chkBx_ReplaceCustomLineNum.Name = "chkBx_ReplaceCustomLineNum"
        Me.chkBx_ReplaceCustomLineNum.Size = New System.Drawing.Size(158, 17)
        Me.chkBx_ReplaceCustomLineNum.TabIndex = 10
        Me.chkBx_ReplaceCustomLineNum.Text = "Replace custom with Line #"
        Me.chkBx_ReplaceCustomLineNum.UseVisualStyleBackColor = True
        '
        'txtBx_ReplaceCustomLineNum
        '
        Me.txtBx_ReplaceCustomLineNum.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBx_ReplaceCustomLineNum.Enabled = False
        Me.txtBx_ReplaceCustomLineNum.Location = New System.Drawing.Point(199, 200)
        Me.txtBx_ReplaceCustomLineNum.Name = "txtBx_ReplaceCustomLineNum"
        Me.txtBx_ReplaceCustomLineNum.Size = New System.Drawing.Size(47, 20)
        Me.txtBx_ReplaceCustomLineNum.TabIndex = 11
        Me.txtBx_ReplaceCustomLineNum.Text = "{#}"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Prefix"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Suffix"
        '
        'txtBx_Prefix
        '
        Me.txtBx_Prefix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBx_Prefix.Location = New System.Drawing.Point(51, 252)
        Me.txtBx_Prefix.Name = "txtBx_Prefix"
        Me.txtBx_Prefix.Size = New System.Drawing.Size(100, 20)
        Me.txtBx_Prefix.TabIndex = 14
        Me.txtBx_Prefix.Text = "Line{#}:"
        '
        'txtBx_Suffix
        '
        Me.txtBx_Suffix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBx_Suffix.Location = New System.Drawing.Point(51, 280)
        Me.txtBx_Suffix.Name = "txtBx_Suffix"
        Me.txtBx_Suffix.Size = New System.Drawing.Size(100, 20)
        Me.txtBx_Suffix.TabIndex = 15
        Me.txtBx_Suffix.Text = "{#}"
        '
        'frm_MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 316)
        Me.Controls.Add(Me.txtBx_Suffix)
        Me.Controls.Add(Me.txtBx_Prefix)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBx_ReplaceCustomLineNum)
        Me.Controls.Add(Me.chkBx_ReplaceCustomLineNum)
        Me.Controls.Add(Me.chkBx_AppendCount)
        Me.Controls.Add(Me.chkBx_LnDelimLastLine)
        Me.Controls.Add(Me.txtBx_LineDelim)
        Me.Controls.Add(Me.chkBx_LineDelim)
        Me.Controls.Add(Me.txtBx_StringDelim)
        Me.Controls.Add(Me.chkBx_StringDelim)
        Me.Controls.Add(Me.chkBx_SeparateLines)
        Me.Controls.Add(Me.btn_Process)
        Me.Controls.Add(Me.txtBx_Result)
        Me.Controls.Add(Me.txtBx_Source)
        Me.Name = "frm_MainForm"
        Me.Text = "VB ListMod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBx_Source As TextBox
    Friend WithEvents txtBx_Result As TextBox
    Friend WithEvents btn_Process As Button
    Friend WithEvents chkBx_SeparateLines As CheckBox
    Friend WithEvents chkBx_StringDelim As CheckBox
    Friend WithEvents txtBx_StringDelim As TextBox
    Friend WithEvents chkBx_LineDelim As CheckBox
    Friend WithEvents txtBx_LineDelim As TextBox
    Friend WithEvents chkBx_LnDelimLastLine As CheckBox
    Friend WithEvents chkBx_AppendCount As CheckBox
    Friend WithEvents chkBx_ReplaceCustomLineNum As CheckBox
    Friend WithEvents txtBx_ReplaceCustomLineNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBx_Prefix As TextBox
    Friend WithEvents txtBx_Suffix As TextBox
End Class
