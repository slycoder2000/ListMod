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
            ProcessSource.Process(this);
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
    }

    public static class ProcessSource
    {

        public static void Process(FrmMain frmObj)
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
                //CheckPrefix(frmObj, ResultText);

                // Check String Delimiter
                CheckStrDelim(frmObj, ResultText);

                // append line to StringBuilder
                ResultText.Append(l);

                // Check String Delimiter
                CheckStrDelim(frmObj, ResultText);

                CheckLnDelim(frmObj, ResultText, cntr == lines.Count());

                CheckSeparateLines(frmObj, ResultText);

                //(frmObj, ResultText);
            }
            AppendCount(frmObj, ResultText);

            // show StringBuilder in TextBox
            frmObj.txtbx_Result.Text = ResultText.ToString();

        }

        private static void CheckStrDelim(FrmMain frmObj, StringBuilder ResultText)
        {
            if (frmObj.chkBx_StrDelim.Checked)
                ResultText.Append(frmObj.txtBx_StrDelim.Text);

        }

        private static void AppendCount(FrmMain frmObj, StringBuilder ResultText)
        {
            // Append line count if desired
            if (frmObj.chkBx_AppendCount.Checked)
                ResultText.Append(frmObj.txtbx_Source.Lines.Count());

        }

        private static void CheckLnDelim(FrmMain frmObj, StringBuilder ResultText, bool IsLastLine)
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

        private static void CheckSeparateLines(FrmMain frmObj, StringBuilder ResultText)
        {
            if(frmObj.chkBx_SeparateLines.Checked)
                ResultText.Append("\r\n");

        }
    }

}
