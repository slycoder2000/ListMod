Imports System.Text

Public Class frm_MainForm

    Dim Process As New ProcessSource()

    Private Sub btn_Process_Click(sender As Object, e As EventArgs) Handles btn_Process.Click
        Dim MyProcess As New ProcessSource()
        MyProcess.Process(Me)


    End Sub

    Private Sub chkBx_StringDelim_CheckedChanged(sender As Object, e As EventArgs) Handles chkBx_StringDelim.CheckedChanged
        txtBx_StringDelim.Enabled = chkBx_StringDelim.Checked
    End Sub

    Private Sub chkBx_LineDelim_CheckedChanged(sender As Object, e As EventArgs) Handles chkBx_LineDelim.CheckedChanged
        txtBx_LineDelim.Enabled = chkBx_LineDelim.Checked
    End Sub

    Private Sub frm_MainForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If (Me.Width < 488) Then Me.Width = 488
        If (Me.Height < 355) Then Me.Height = 355

        '// determine position of checkbox less 10px And subtract left position of textbox
        txtBx_Source.Width = chkBx_SeparateLines.Location.X - 10 - txtBx_Source.Location.X
        '// determine window width less 50px And subtract left position of textbox
        txtBx_Result.Width = Me.Width - 50 - txtBx_Result.Location.X
    End Sub

    Private Sub chkBx_ReplaceCustomLineNum_CheckedChanged(sender As Object, e As EventArgs) Handles chkBx_ReplaceCustomLineNum.CheckedChanged
        txtBx_ReplaceCustomLineNum.Enabled = chkBx_ReplaceCustomLineNum.Checked
    End Sub
End Class


Public Class ProcessSource
    Public Sub Process(ByRef frmObj As frm_MainForm)

        '// Instatiate And clear StringBuilder
        Dim ResultText As New StringBuilder()

        ResultText.Clear()

        '// Parse Source into an array
        Dim lines As String() = frmObj.txtBx_Source.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        Dim cntr As Integer = 0
        For Each l As String In lines

            cntr += 1

            '// Add Prefix to Line
            CheckPrefix(frmObj, ResultText)

            '// Check String Delimiter
            CheckStrDelim(frmObj, ResultText)

            '// append line to StringBuilder
            ResultText.Append(l)

            '// Check String Delimiter
            CheckStrDelim(frmObj, ResultText)

            '// Check Suffix
            CheckSuffix(frmObj, ResultText)

            '// Check Replace Custom
            CheckReplaceCustom(frmObj, ResultText, cntr)

            CheckLnDelim(frmObj, ResultText, If(cntr = lines.Count(), vbTrue, vbFalse))

            CheckSeparateLines(frmObj, ResultText)


        Next

        AppendCount(frmObj, ResultText)

        frmObj.txtBx_Result.Text = ResultText.ToString()
    End Sub

    Private Sub CheckStrDelim(frmObj As frm_MainForm, ResultText As StringBuilder)

        If frmObj.chkBx_StringDelim.Checked Then
            ResultText.Append(frmObj.txtBx_StringDelim.Text)
        End If

    End Sub

    Private Sub AppendCount(frmObj As frm_MainForm, ResultText As StringBuilder)

        '// Append line count if desired

        If frmObj.chkBx_AppendCount.Checked Then
            ResultText.Append(frmObj.txtBx_Source.Lines.Count())
        End If

    End Sub

    Private Sub CheckLnDelim(frmObj As frm_MainForm, ResultText As StringBuilder, IsLastLine As Boolean)

        If frmObj.chkBx_LineDelim.Checked Then
            If frmObj.chkBx_LnDelimLastLine.Checked Then
                ResultText.Append(frmObj.txtBx_LineDelim.Text)
            Else
                If Not IsLastLine Then
                    ResultText.Append(frmObj.txtBx_LineDelim.Text)
                End If
            End If
        End If

    End Sub

    Private Sub CheckSeparateLines(ByRef frmObj As frm_MainForm, ByRef ResultText As StringBuilder)
        If frmObj.chkBx_SeparateLines.Checked Then
            ResultText.AppendLine()
        End If
    End Sub

    Private Sub CheckPrefix(ByRef frmObj As frm_MainForm, ByRef ResultText As StringBuilder)
        If Not frmObj.txtBx_Prefix.Text = "" Then
            ResultText.Append(frmObj.txtBx_Prefix.Text)
        End If
    End Sub

    Private Sub CheckSuffix(ByRef frmObj As frm_MainForm, ByRef ResultText As StringBuilder)
        If Not frmObj.txtBx_Suffix.Text = "" Then
            ResultText.Append(frmObj.txtBx_Suffix.Text)
        End If

    End Sub

    Private Sub CheckReplaceCustom(ByRef frmObj As frm_MainForm, ByRef ResultText As StringBuilder, ByVal LineNum As Integer)
        If frmObj.chkBx_ReplaceCustomLineNum.Checked Then
            ResultText.Replace(frmObj.txtBx_ReplaceCustomLineNum.Text, LineNum.ToString())
        End If
    End Sub

End Class