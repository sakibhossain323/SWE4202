namespace FileManager
{
    partial class Form1
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
            this.labelAddFname = new System.Windows.Forms.Label();
            this.labelAddFtype = new System.Windows.Forms.Label();
            this.labelAddFcont = new System.Windows.Forms.Label();
            this.textBoxAddFname = new System.Windows.Forms.TextBox();
            this.textBoxAddFcont = new System.Windows.Forms.TextBox();
            this.comboBoxFtype = new System.Windows.Forms.ComboBox();
            this.ButtonAddFile = new System.Windows.Forms.Button();
            this.textBoxRemFname = new System.Windows.Forms.TextBox();
            this.labelRemFname = new System.Windows.Forms.Label();
            this.ButtonRemFile = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpFname = new System.Windows.Forms.TextBox();
            this.labelUpFname = new System.Windows.Forms.Label();
            this.textBoxUpContent = new System.Windows.Forms.TextBox();
            this.labelUpCont = new System.Windows.Forms.Label();
            this.textBoxUpNewCont = new System.Windows.Forms.TextBox();
            this.labelUpNewCont = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonView = new System.Windows.Forms.Button();
            this.textBoxViewFname = new System.Windows.Forms.TextBox();
            this.labelViewFname = new System.Windows.Forms.Label();
            this.labelViewFeat = new System.Windows.Forms.Label();
            this.textBoxViewCont = new System.Windows.Forms.TextBox();
            this.labelViewCont = new System.Windows.Forms.Label();
            this.listBoxFeatures = new System.Windows.Forms.ListBox();
            this.ButtonShowSumm = new System.Windows.Forms.Button();
            this.textBoxMem = new System.Windows.Forms.TextBox();
            this.labelMem = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelAddFname
            // 
            this.labelAddFname.AutoSize = true;
            this.labelAddFname.Location = new System.Drawing.Point(8, 9);
            this.labelAddFname.Name = "labelAddFname";
            this.labelAddFname.Size = new System.Drawing.Size(57, 13);
            this.labelAddFname.TabIndex = 0;
            this.labelAddFname.Text = "File Name:";
            // 
            // labelAddFtype
            // 
            this.labelAddFtype.AutoSize = true;
            this.labelAddFtype.Location = new System.Drawing.Point(12, 35);
            this.labelAddFtype.Name = "labelAddFtype";
            this.labelAddFtype.Size = new System.Drawing.Size(53, 13);
            this.labelAddFtype.TabIndex = 1;
            this.labelAddFtype.Text = "File Type:";
            // 
            // labelAddFcont
            // 
            this.labelAddFcont.AutoSize = true;
            this.labelAddFcont.Location = new System.Drawing.Point(2, 65);
            this.labelAddFcont.Name = "labelAddFcont";
            this.labelAddFcont.Size = new System.Drawing.Size(66, 13);
            this.labelAddFcont.TabIndex = 2;
            this.labelAddFcont.Text = "File Content:";
            // 
            // textBoxAddFname
            // 
            this.textBoxAddFname.Location = new System.Drawing.Point(75, 6);
            this.textBoxAddFname.Name = "textBoxAddFname";
            this.textBoxAddFname.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddFname.TabIndex = 3;
            // 
            // textBoxAddFcont
            // 
            this.textBoxAddFcont.Location = new System.Drawing.Point(75, 62);
            this.textBoxAddFcont.Name = "textBoxAddFcont";
            this.textBoxAddFcont.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddFcont.TabIndex = 4;
            // 
            // comboBoxFtype
            // 
            this.comboBoxFtype.FormattingEnabled = true;
            this.comboBoxFtype.Location = new System.Drawing.Point(75, 32);
            this.comboBoxFtype.Name = "comboBoxFtype";
            this.comboBoxFtype.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFtype.TabIndex = 5;
            // 
            // ButtonAddFile
            // 
            this.ButtonAddFile.Location = new System.Drawing.Point(75, 88);
            this.ButtonAddFile.Name = "ButtonAddFile";
            this.ButtonAddFile.Size = new System.Drawing.Size(100, 23);
            this.ButtonAddFile.TabIndex = 6;
            this.ButtonAddFile.Text = "Add File";
            this.ButtonAddFile.UseVisualStyleBackColor = true;
            this.ButtonAddFile.Click += new System.EventHandler(this.ButtonAddFile_Click);
            // 
            // textBoxRemFname
            // 
            this.textBoxRemFname.Location = new System.Drawing.Point(75, 150);
            this.textBoxRemFname.Name = "textBoxRemFname";
            this.textBoxRemFname.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemFname.TabIndex = 8;
            // 
            // labelRemFname
            // 
            this.labelRemFname.AutoSize = true;
            this.labelRemFname.Location = new System.Drawing.Point(8, 153);
            this.labelRemFname.Name = "labelRemFname";
            this.labelRemFname.Size = new System.Drawing.Size(57, 13);
            this.labelRemFname.TabIndex = 7;
            this.labelRemFname.Text = "File Name:";
            // 
            // ButtonRemFile
            // 
            this.ButtonRemFile.Location = new System.Drawing.Point(75, 176);
            this.ButtonRemFile.Name = "ButtonRemFile";
            this.ButtonRemFile.Size = new System.Drawing.Size(100, 23);
            this.ButtonRemFile.TabIndex = 9;
            this.ButtonRemFile.Text = "Remove File";
            this.ButtonRemFile.UseVisualStyleBackColor = true;
            this.ButtonRemFile.Click += new System.EventHandler(this.ButtonRemFile_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(79, 247);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(100, 23);
            this.ButtonUpdate.TabIndex = 12;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // textBoxUpFname
            // 
            this.textBoxUpFname.Location = new System.Drawing.Point(79, 221);
            this.textBoxUpFname.Name = "textBoxUpFname";
            this.textBoxUpFname.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpFname.TabIndex = 11;
            // 
            // labelUpFname
            // 
            this.labelUpFname.AutoSize = true;
            this.labelUpFname.Location = new System.Drawing.Point(12, 224);
            this.labelUpFname.Name = "labelUpFname";
            this.labelUpFname.Size = new System.Drawing.Size(57, 13);
            this.labelUpFname.TabIndex = 10;
            this.labelUpFname.Text = "File Name:";
            // 
            // textBoxUpContent
            // 
            this.textBoxUpContent.Location = new System.Drawing.Point(79, 282);
            this.textBoxUpContent.Name = "textBoxUpContent";
            this.textBoxUpContent.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpContent.TabIndex = 14;
            // 
            // labelUpCont
            // 
            this.labelUpCont.AutoSize = true;
            this.labelUpCont.Location = new System.Drawing.Point(26, 289);
            this.labelUpCont.Name = "labelUpCont";
            this.labelUpCont.Size = new System.Drawing.Size(47, 13);
            this.labelUpCont.TabIndex = 13;
            this.labelUpCont.Text = "Content:";
            // 
            // textBoxUpNewCont
            // 
            this.textBoxUpNewCont.Location = new System.Drawing.Point(79, 310);
            this.textBoxUpNewCont.Name = "textBoxUpNewCont";
            this.textBoxUpNewCont.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpNewCont.TabIndex = 16;
            // 
            // labelUpNewCont
            // 
            this.labelUpNewCont.AutoSize = true;
            this.labelUpNewCont.Location = new System.Drawing.Point(1, 313);
            this.labelUpNewCont.Name = "labelUpNewCont";
            this.labelUpNewCont.Size = new System.Drawing.Size(72, 13);
            this.labelUpNewCont.TabIndex = 15;
            this.labelUpNewCont.Text = "New Content:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(79, 336);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(100, 23);
            this.ButtonSave.TabIndex = 17;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonView
            // 
            this.ButtonView.Location = new System.Drawing.Point(424, 36);
            this.ButtonView.Name = "ButtonView";
            this.ButtonView.Size = new System.Drawing.Size(100, 23);
            this.ButtonView.TabIndex = 20;
            this.ButtonView.Text = "View";
            this.ButtonView.UseVisualStyleBackColor = true;
            this.ButtonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // textBoxViewFname
            // 
            this.textBoxViewFname.Location = new System.Drawing.Point(424, 10);
            this.textBoxViewFname.Name = "textBoxViewFname";
            this.textBoxViewFname.Size = new System.Drawing.Size(100, 20);
            this.textBoxViewFname.TabIndex = 19;
            // 
            // labelViewFname
            // 
            this.labelViewFname.AutoSize = true;
            this.labelViewFname.Location = new System.Drawing.Point(357, 13);
            this.labelViewFname.Name = "labelViewFname";
            this.labelViewFname.Size = new System.Drawing.Size(57, 13);
            this.labelViewFname.TabIndex = 18;
            this.labelViewFname.Text = "File Name:";
            // 
            // labelViewFeat
            // 
            this.labelViewFeat.AutoSize = true;
            this.labelViewFeat.Location = new System.Drawing.Point(328, 98);
            this.labelViewFeat.Name = "labelViewFeat";
            this.labelViewFeat.Size = new System.Drawing.Size(86, 13);
            this.labelViewFeat.TabIndex = 23;
            this.labelViewFeat.Text = "Allowed Feature:";
            // 
            // textBoxViewCont
            // 
            this.textBoxViewCont.Location = new System.Drawing.Point(424, 67);
            this.textBoxViewCont.Name = "textBoxViewCont";
            this.textBoxViewCont.Size = new System.Drawing.Size(100, 20);
            this.textBoxViewCont.TabIndex = 22;
            // 
            // labelViewCont
            // 
            this.labelViewCont.AutoSize = true;
            this.labelViewCont.Location = new System.Drawing.Point(367, 74);
            this.labelViewCont.Name = "labelViewCont";
            this.labelViewCont.Size = new System.Drawing.Size(47, 13);
            this.labelViewCont.TabIndex = 21;
            this.labelViewCont.Text = "Content:";
            // 
            // listBoxFeatures
            // 
            this.listBoxFeatures.FormattingEnabled = true;
            this.listBoxFeatures.Location = new System.Drawing.Point(420, 98);
            this.listBoxFeatures.Name = "listBoxFeatures";
            this.listBoxFeatures.Size = new System.Drawing.Size(104, 56);
            this.listBoxFeatures.TabIndex = 24;
            // 
            // ButtonShowSumm
            // 
            this.ButtonShowSumm.Location = new System.Drawing.Point(408, 176);
            this.ButtonShowSumm.Name = "ButtonShowSumm";
            this.ButtonShowSumm.Size = new System.Drawing.Size(142, 23);
            this.ButtonShowSumm.TabIndex = 25;
            this.ButtonShowSumm.Text = "Show Summary";
            this.ButtonShowSumm.UseVisualStyleBackColor = true;
            this.ButtonShowSumm.Click += new System.EventHandler(this.ButtonShowSumm_Click);
            // 
            // textBoxMem
            // 
            this.textBoxMem.Location = new System.Drawing.Point(571, 217);
            this.textBoxMem.Name = "textBoxMem";
            this.textBoxMem.Size = new System.Drawing.Size(64, 20);
            this.textBoxMem.TabIndex = 29;
            // 
            // labelMem
            // 
            this.labelMem.AutoSize = true;
            this.labelMem.Location = new System.Drawing.Point(442, 221);
            this.labelMem.Name = "labelMem";
            this.labelMem.Size = new System.Drawing.Size(123, 13);
            this.labelMem.TabIndex = 28;
            this.labelMem.Text = "Total Memory Occupied:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(381, 216);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(45, 20);
            this.textBoxTotal.TabIndex = 27;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(322, 219);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(53, 13);
            this.labelTotal.TabIndex = 26;
            this.labelTotal.Text = "Total File:";
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(325, 247);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(310, 108);
            this.listBoxFiles.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.textBoxMem);
            this.Controls.Add(this.labelMem);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.ButtonShowSumm);
            this.Controls.Add(this.listBoxFeatures);
            this.Controls.Add(this.labelViewFeat);
            this.Controls.Add(this.textBoxViewCont);
            this.Controls.Add(this.labelViewCont);
            this.Controls.Add(this.ButtonView);
            this.Controls.Add(this.textBoxViewFname);
            this.Controls.Add(this.labelViewFname);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxUpNewCont);
            this.Controls.Add(this.labelUpNewCont);
            this.Controls.Add(this.textBoxUpContent);
            this.Controls.Add(this.labelUpCont);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.textBoxUpFname);
            this.Controls.Add(this.labelUpFname);
            this.Controls.Add(this.ButtonRemFile);
            this.Controls.Add(this.textBoxRemFname);
            this.Controls.Add(this.labelRemFname);
            this.Controls.Add(this.ButtonAddFile);
            this.Controls.Add(this.comboBoxFtype);
            this.Controls.Add(this.textBoxAddFcont);
            this.Controls.Add(this.textBoxAddFname);
            this.Controls.Add(this.labelAddFcont);
            this.Controls.Add(this.labelAddFtype);
            this.Controls.Add(this.labelAddFname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddFname;
        private System.Windows.Forms.Label labelAddFtype;
        private System.Windows.Forms.Label labelAddFcont;
        private System.Windows.Forms.TextBox textBoxAddFname;
        private System.Windows.Forms.TextBox textBoxAddFcont;
        private System.Windows.Forms.ComboBox comboBoxFtype;
        private System.Windows.Forms.Button ButtonAddFile;
        private System.Windows.Forms.TextBox textBoxRemFname;
        private System.Windows.Forms.Label labelRemFname;
        private System.Windows.Forms.Button ButtonRemFile;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.TextBox textBoxUpFname;
        private System.Windows.Forms.Label labelUpFname;
        private System.Windows.Forms.TextBox textBoxUpContent;
        private System.Windows.Forms.Label labelUpCont;
        private System.Windows.Forms.TextBox textBoxUpNewCont;
        private System.Windows.Forms.Label labelUpNewCont;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonView;
        private System.Windows.Forms.TextBox textBoxViewFname;
        private System.Windows.Forms.Label labelViewFname;
        private System.Windows.Forms.Label labelViewFeat;
        private System.Windows.Forms.TextBox textBoxViewCont;
        private System.Windows.Forms.Label labelViewCont;
        private System.Windows.Forms.ListBox listBoxFeatures;
        private System.Windows.Forms.Button ButtonShowSumm;
        private System.Windows.Forms.TextBox textBoxMem;
        private System.Windows.Forms.Label labelMem;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ListBox listBoxFiles;
    }
}

