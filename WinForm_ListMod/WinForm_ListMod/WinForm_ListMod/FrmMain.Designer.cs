namespace WinForm_ListMod
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbx_Source = new System.Windows.Forms.TextBox();
            this.txtbx_Result = new System.Windows.Forms.TextBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.chkBx_StrDelim = new System.Windows.Forms.CheckBox();
            this.txtBx_StrDelim = new System.Windows.Forms.TextBox();
            this.chkBx_LnDelim = new System.Windows.Forms.CheckBox();
            this.txtBx_LnDelim = new System.Windows.Forms.TextBox();
            this.chkBx_SeparateLines = new System.Windows.Forms.CheckBox();
            this.chkBx_AppendCount = new System.Windows.Forms.CheckBox();
            this.chkBx_LnDelimLastLine = new System.Windows.Forms.CheckBox();
            this.chkBx_ReplaceCustomLineNum = new System.Windows.Forms.CheckBox();
            this.txtBx_ReplaceCustomLineNum = new System.Windows.Forms.TextBox();
            this.txtBx_Prefix = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_Source
            // 
            this.txtbx_Source.Location = new System.Drawing.Point(12, 35);
            this.txtbx_Source.Multiline = true;
            this.txtbx_Source.Name = "txtbx_Source";
            this.txtbx_Source.Size = new System.Drawing.Size(132, 196);
            this.txtbx_Source.TabIndex = 0;
            this.txtbx_Source.Text = "text\r\ntext\r\ntext\r\ntext";
            // 
            // txtbx_Result
            // 
            this.txtbx_Result.Location = new System.Drawing.Point(313, 35);
            this.txtbx_Result.Multiline = true;
            this.txtbx_Result.Name = "txtbx_Result";
            this.txtbx_Result.Size = new System.Drawing.Size(147, 233);
            this.txtbx_Result.TabIndex = 1;
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(313, 274);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(91, 22);
            this.btn_result.TabIndex = 2;
            this.btn_result.Text = "Process Result";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // chkBx_StrDelim
            // 
            this.chkBx_StrDelim.AutoSize = true;
            this.chkBx_StrDelim.Location = new System.Drawing.Point(150, 60);
            this.chkBx_StrDelim.Name = "chkBx_StrDelim";
            this.chkBx_StrDelim.Size = new System.Drawing.Size(96, 17);
            this.chkBx_StrDelim.TabIndex = 3;
            this.chkBx_StrDelim.Text = "String Delimiter";
            this.chkBx_StrDelim.UseVisualStyleBackColor = true;
            // 
            // txtBx_StrDelim
            // 
            this.txtBx_StrDelim.Location = new System.Drawing.Point(252, 60);
            this.txtBx_StrDelim.Name = "txtBx_StrDelim";
            this.txtBx_StrDelim.Size = new System.Drawing.Size(22, 20);
            this.txtBx_StrDelim.TabIndex = 4;
            this.txtBx_StrDelim.Text = "\"";
            // 
            // chkBx_LnDelim
            // 
            this.chkBx_LnDelim.AutoSize = true;
            this.chkBx_LnDelim.Location = new System.Drawing.Point(150, 83);
            this.chkBx_LnDelim.Name = "chkBx_LnDelim";
            this.chkBx_LnDelim.Size = new System.Drawing.Size(89, 17);
            this.chkBx_LnDelim.TabIndex = 5;
            this.chkBx_LnDelim.Text = "Line Delimiter";
            this.chkBx_LnDelim.UseVisualStyleBackColor = true;
            this.chkBx_LnDelim.CheckedChanged += new System.EventHandler(this.chkBx_LnDelim_CheckedChanged);
            // 
            // txtBx_LnDelim
            // 
            this.txtBx_LnDelim.Enabled = false;
            this.txtBx_LnDelim.Location = new System.Drawing.Point(252, 86);
            this.txtBx_LnDelim.Name = "txtBx_LnDelim";
            this.txtBx_LnDelim.Size = new System.Drawing.Size(22, 20);
            this.txtBx_LnDelim.TabIndex = 6;
            this.txtBx_LnDelim.Text = ",";
            // 
            // chkBx_SeparateLines
            // 
            this.chkBx_SeparateLines.AutoSize = true;
            this.chkBx_SeparateLines.Checked = true;
            this.chkBx_SeparateLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBx_SeparateLines.Location = new System.Drawing.Point(150, 37);
            this.chkBx_SeparateLines.Name = "chkBx_SeparateLines";
            this.chkBx_SeparateLines.Size = new System.Drawing.Size(97, 17);
            this.chkBx_SeparateLines.TabIndex = 7;
            this.chkBx_SeparateLines.Text = "Separate Lines";
            this.chkBx_SeparateLines.UseVisualStyleBackColor = true;
            // 
            // chkBx_AppendCount
            // 
            this.chkBx_AppendCount.AutoSize = true;
            this.chkBx_AppendCount.Location = new System.Drawing.Point(150, 129);
            this.chkBx_AppendCount.Name = "chkBx_AppendCount";
            this.chkBx_AppendCount.Size = new System.Drawing.Size(117, 17);
            this.chkBx_AppendCount.TabIndex = 8;
            this.chkBx_AppendCount.Text = "Append Line Count";
            this.chkBx_AppendCount.UseVisualStyleBackColor = true;
            // 
            // chkBx_LnDelimLastLine
            // 
            this.chkBx_LnDelimLastLine.AutoSize = true;
            this.chkBx_LnDelimLastLine.Checked = true;
            this.chkBx_LnDelimLastLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBx_LnDelimLastLine.Enabled = false;
            this.chkBx_LnDelimLastLine.Location = new System.Drawing.Point(167, 106);
            this.chkBx_LnDelimLastLine.Name = "chkBx_LnDelimLastLine";
            this.chkBx_LnDelimLastLine.Size = new System.Drawing.Size(122, 17);
            this.chkBx_LnDelimLastLine.TabIndex = 9;
            this.chkBx_LnDelimLastLine.Text = "Include on Last Line";
            this.chkBx_LnDelimLastLine.UseVisualStyleBackColor = true;
            // 
            // chkBx_ReplaceCustomLineNum
            // 
            this.chkBx_ReplaceCustomLineNum.AutoSize = true;
            this.chkBx_ReplaceCustomLineNum.Location = new System.Drawing.Point(150, 188);
            this.chkBx_ReplaceCustomLineNum.Name = "chkBx_ReplaceCustomLineNum";
            this.chkBx_ReplaceCustomLineNum.Size = new System.Drawing.Size(158, 17);
            this.chkBx_ReplaceCustomLineNum.TabIndex = 10;
            this.chkBx_ReplaceCustomLineNum.Text = "Replace custom with Line #";
            this.chkBx_ReplaceCustomLineNum.UseVisualStyleBackColor = true;
            this.chkBx_ReplaceCustomLineNum.CheckedChanged += new System.EventHandler(this.chkBx_ReplaceCustomLineNum_CheckedChanged);
            // 
            // txtBx_ReplaceCustomLineNum
            // 
            this.txtBx_ReplaceCustomLineNum.Enabled = false;
            this.txtBx_ReplaceCustomLineNum.Location = new System.Drawing.Point(207, 211);
            this.txtBx_ReplaceCustomLineNum.Name = "txtBx_ReplaceCustomLineNum";
            this.txtBx_ReplaceCustomLineNum.Size = new System.Drawing.Size(100, 20);
            this.txtBx_ReplaceCustomLineNum.TabIndex = 11;
            this.txtBx_ReplaceCustomLineNum.Text = "{#}";
            // 
            // txtBx_Prefix
            // 
            this.txtBx_Prefix.Location = new System.Drawing.Point(44, 237);
            this.txtBx_Prefix.Name = "txtBx_Prefix";
            this.txtBx_Prefix.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Prefix.TabIndex = 12;
            this.txtBx_Prefix.Text = "Line{#}: ";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(44, 263);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(100, 20);
            this.txtSuffix.TabIndex = 13;
            this.txtSuffix.Text = "{#}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Prefix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Suffix";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.txtBx_Prefix);
            this.Controls.Add(this.txtBx_ReplaceCustomLineNum);
            this.Controls.Add(this.chkBx_ReplaceCustomLineNum);
            this.Controls.Add(this.chkBx_LnDelimLastLine);
            this.Controls.Add(this.chkBx_AppendCount);
            this.Controls.Add(this.chkBx_SeparateLines);
            this.Controls.Add(this.txtBx_LnDelim);
            this.Controls.Add(this.chkBx_LnDelim);
            this.Controls.Add(this.txtBx_StrDelim);
            this.Controls.Add(this.chkBx_StrDelim);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.txtbx_Result);
            this.Controls.Add(this.txtbx_Source);
            this.Name = "FrmMain";
            this.Text = "List Modifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_result;
        public System.Windows.Forms.TextBox txtbx_Source;
        public System.Windows.Forms.TextBox txtbx_Result;
        public System.Windows.Forms.CheckBox chkBx_StrDelim;
        public System.Windows.Forms.TextBox txtBx_StrDelim;
        public System.Windows.Forms.CheckBox chkBx_LnDelim;
        public System.Windows.Forms.TextBox txtBx_LnDelim;
        public System.Windows.Forms.CheckBox chkBx_SeparateLines;
        public System.Windows.Forms.CheckBox chkBx_AppendCount;
        public System.Windows.Forms.CheckBox chkBx_LnDelimLastLine;
        public System.Windows.Forms.CheckBox chkBx_ReplaceCustomLineNum;
        public System.Windows.Forms.TextBox txtBx_ReplaceCustomLineNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtBx_Prefix;
        public System.Windows.Forms.TextBox txtSuffix;
    }
}

