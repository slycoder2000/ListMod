using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_ListMod
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            ProcessSource MyProcess = new ProcessSource();
            MyProcess.Process(this);
        }

        private void chkBx_LnDelim_CheckedChanged(object sender, EventArgs e)
        {

            txtBx_LnDelim.Enabled = chkBx_LnDelim.Checked;
            chkBx_LnDelimLastLine.Enabled = chkBx_LnDelim.Checked;

        }

        private void chkBx_ReplaceCustomLineNum_CheckedChanged(object sender, EventArgs e)
        {
            txtBx_ReplaceCustomLineNum.Enabled = chkBx_ReplaceCustomLineNum.Checked;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width < 488) this.Width = 488;
            if (this.Height < 355) this.Height = 355;

            // determine position of checkbox less 10px and subtract left position of textbox
            txtbx_Source.Width = chkBx_SeparateLines.Location.X - 10 - txtbx_Source.Location.X;
            // determine window width less 50px and subtract left position of textbox
            txtbx_Result.Width = this.Width-50 - txtbx_Result.Location.X;
        }
    }

    public class ProcessSource
    {

        public void Process(FrmMain frmObj)
        {
            // Instatiate and clear StringBuilder

            StringBuilder ResultText = new StringBuilder();
            ResultText.Clear();

            // Parse Source into an array
            String[] lines = frmObj.txtbx_Source.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var cntr = 0;
            foreach (string l in lines)
            {
                cntr++;

                // Add Prefix to Line
                CheckPrefix(frmObj, ResultText);

                // Check String Delimiter
                CheckStrDelim(frmObj, ResultText);

                // append line to StringBuilder
                ResultText.Append(l);

                // Check String Delimiter
                CheckStrDelim(frmObj, ResultText);

                // Check Suffix
                CheckSuffix(frmObj, ResultText);

                // Check Replace Custom
                CheckReplaceCustom(frmObj, ResultText, cntr);

                CheckLnDelim(frmObj, ResultText, cntr == lines.Count());

                CheckSeparateLines(frmObj, ResultText);

            }

            AppendCount(frmObj, ResultText);

            // show StringBuilder in TextBox
            frmObj.txtbx_Result.Text = ResultText.ToString();

        }

        private void CheckStrDelim(FrmMain frmObj, StringBuilder ResultText)
        {
            if (frmObj.chkBx_StrDelim.Checked)
                ResultText.Append(frmObj.txtBx_StrDelim.Text);

        }

        private void AppendCount(FrmMain frmObj, StringBuilder ResultText)
        {
            // Append line count if desired
            if (frmObj.chkBx_AppendCount.Checked)
                ResultText.Append(frmObj.txtbx_Source.Lines.Count());

        }

        private void CheckLnDelim(FrmMain frmObj, StringBuilder ResultText, bool IsLastLine)
        {

            if (frmObj.chkBx_LnDelim.Checked)
                if (frmObj.chkBx_LnDelimLastLine.Checked)
                {
                    ResultText.Append(frmObj.txtBx_LnDelim.Text);
                
                }
                else
                {
                    if (!IsLastLine)
                        ResultText.Append(frmObj.txtBx_LnDelim.Text);
                }

        }

        private void CheckSeparateLines(FrmMain frmObj, StringBuilder ResultText)
        {
            if(frmObj.chkBx_SeparateLines.Checked)
                ResultText.AppendLine();

        }

        private void CheckPrefix(FrmMain frmObj, StringBuilder ResultText)
        {
            if(frmObj.txtBx_Prefix.Text!="")
            {
                ResultText.Append(frmObj.txtBx_Prefix.Text);
            }
        }
        private void CheckSuffix(FrmMain frmObj, StringBuilder ResultText)
        {
            if (frmObj.txtBx_Suffix.Text != "")
            {
                ResultText.Append(frmObj.txtBx_Suffix.Text);
            }
        }

        private void CheckReplaceCustom(FrmMain frmObj, StringBuilder ResultText, int LineNum)
        {
            if(frmObj.chkBx_ReplaceCustomLineNum.Checked)
            {
                ResultText.Replace(frmObj.txtBx_ReplaceCustomLineNum.Text, LineNum.ToString());
            }
        }
    }

}
