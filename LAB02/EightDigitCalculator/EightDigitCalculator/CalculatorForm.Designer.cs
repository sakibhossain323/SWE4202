
namespace EightDigitCalculator
{
    partial class CalculatorForm
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
            this.LabelResult = new System.Windows.Forms.Label();
            this.ButtonAC = new System.Windows.Forms.Button();
            this.ButtonNegate = new System.Windows.Forms.Button();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonDig9 = new System.Windows.Forms.Button();
            this.ButtonDig8 = new System.Windows.Forms.Button();
            this.ButtonDig7 = new System.Windows.Forms.Button();
            this.ButtonSubstract = new System.Windows.Forms.Button();
            this.ButtonDig6 = new System.Windows.Forms.Button();
            this.ButtonDig5 = new System.Windows.Forms.Button();
            this.ButtonDig4 = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDig3 = new System.Windows.Forms.Button();
            this.ButtonDig2 = new System.Windows.Forms.Button();
            this.ButtonDig1 = new System.Windows.Forms.Button();
            this.ButtonEqual = new System.Windows.Forms.Button();
            this.ButtonDecPoint = new System.Windows.Forms.Button();
            this.ButtonDig0 = new System.Windows.Forms.Button();
            this.LabelPrevResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.Location = new System.Drawing.Point(12, 41);
            this.LabelResult.MinimumSize = new System.Drawing.Size(360, 0);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(360, 55);
            this.LabelResult.TabIndex = 0;
            this.LabelResult.Text = "0";
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonAC
            // 
            this.ButtonAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAC.Location = new System.Drawing.Point(12, 111);
            this.ButtonAC.Name = "ButtonAC";
            this.ButtonAC.Size = new System.Drawing.Size(86, 60);
            this.ButtonAC.TabIndex = 1;
            this.ButtonAC.Text = "AC";
            this.ButtonAC.UseVisualStyleBackColor = true;
            this.ButtonAC.Click += new System.EventHandler(this.ButtonAC_Click);
            // 
            // ButtonNegate
            // 
            this.ButtonNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNegate.Location = new System.Drawing.Point(104, 111);
            this.ButtonNegate.Name = "ButtonNegate";
            this.ButtonNegate.Size = new System.Drawing.Size(86, 60);
            this.ButtonNegate.TabIndex = 2;
            this.ButtonNegate.Text = "+/-";
            this.ButtonNegate.UseVisualStyleBackColor = true;
            this.ButtonNegate.Click += new System.EventHandler(this.ButtonNegate_Click);
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPercent.Location = new System.Drawing.Point(196, 111);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(86, 60);
            this.ButtonPercent.TabIndex = 3;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = true;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDivide.Location = new System.Drawing.Point(288, 111);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(86, 60);
            this.ButtonDivide.TabIndex = 4;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMultiply.Location = new System.Drawing.Point(288, 177);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(86, 56);
            this.ButtonMultiply.TabIndex = 8;
            this.ButtonMultiply.Text = "x";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonDig9
            // 
            this.ButtonDig9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDig9.Location = new System.Drawing.Point(196, 177);
            this.ButtonDig9.Name = "ButtonDig9";
            this.ButtonDig9.Size = new System.Drawing.Size(86, 56);
            this.ButtonDig9.TabIndex = 7;
            this.ButtonDig9.Text = "9";
            this.ButtonDig9.UseVisualStyleBackColor = true;
            this.ButtonDig9.Click += new System.EventHandler(this.ButtonDig9_Click);
            // 
            // ButtonDig8
            // 
            this.ButtonDig8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDig8.Location = new System.Drawing.Point(104, 177);
            this.ButtonDig8.Name = "ButtonDig8";
            this.ButtonDig8.Size = new System.Drawing.Size(86, 56);
            this.ButtonDig8.TabIndex = 6;
            this.ButtonDig8.Text = "8";
            this.ButtonDig8.UseVisualStyleBackColor = true;
            this.ButtonDig8.Click += new System.EventHandler(this.ButtonDig8_Click);
            // 
            // ButtonDig7
            // 
            this.ButtonDig7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDig7.Location = new System.Drawing.Point(12, 177);
            this.ButtonDig7.Name = "ButtonDig7";
            this.ButtonDig7.Size = new System.Drawing.Size(86, 56);
            this.ButtonDig7.TabIndex = 5;
            this.ButtonDig7.Text = "7";
            this.ButtonDig7.UseVisualStyleBackColor = true;
            this.ButtonDig7.Click += new System.EventHandler(this.ButtonDig7_Click);
            // 
            // ButtonSubstract
            // 
            this.ButtonSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubstract.Location = new System.Drawing.Point(288, 239);
            this.ButtonSubstract.Name = "ButtonSubstract";
            this.ButtonSubstract.Size = new System.Drawing.Size(86, 56);
            this.ButtonSubstract.TabIndex = 12;
            this.ButtonSubstract.Text = "-";
            this.ButtonSubstract.UseVisualStyleBackColor = true;
            this.ButtonSubstract.Click += new System.EventHandler(this.ButtonSubstract_Click);
            // 
            // ButtonDig6
            // 
            this.ButtonDig6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDig6.Location = new System.Drawing.Point(196, 239);
            this.ButtonDig6.Name = "ButtonDig6";
            this.ButtonDig6.Size = new System.Drawing.Size(86, 56);
            this.ButtonDig6.TabIndex = 11;
            this.ButtonDig6.Text = "6";
            this.ButtonDig6.UseVisualStyleBackColor = true;
            this.ButtonDig6.Click += new System.EventHandler(this.ButtonDig6_Click);
            // 
            // ButtonDig5
            // 
            this.ButtonDig5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDig5.Location = new System.Drawing.Point(104, 239);
            this.ButtonDig5.Name = "ButtonDig5";
            this.ButtonDig5.Size = new System.Drawing.Size(86, 56);
            this.ButtonDig5.TabIndex = 10;
            this.ButtonDig5.Text = "5";
            this.ButtonDig5.UseVisualStyleBackColor = true;
            this.ButtonDig5.Click += new System.EventHandler(this.ButtonDig5_Click);
            // 
            // ButtonDig4
            // 
            this.ButtonDig4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDig4.Location = new System.Drawing.Point(12, 239);
            this.ButtonDig4.Name = "ButtonDig4";
            this.ButtonDig4.Size = new System.Drawing.Size(86, 56);
            this.ButtonDig4.TabIndex = 9;
            this.ButtonDig4.Text = "4";
            this.ButtonDig4.UseVisualStyleBackColor = true;
            this.ButtonDig4.Click += new System.EventHandler(this.ButtonDig4_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Location = new System.Drawing.Point(288, 301);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(86, 63);
            this.ButtonAdd.TabIndex = 16;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDig3
            // 
            this.ButtonDig3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDig3.Location = new System.Drawing.Point(196, 301);
            this.ButtonDig3.Name = "ButtonDig3";
            this.ButtonDig3.Size = new System.Drawing.Size(86, 63);
            this.ButtonDig3.TabIndex = 15;
            this.ButtonDig3.Text = "3";
            this.ButtonDig3.UseVisualStyleBackColor = true;
            this.ButtonDig3.Click += new System.EventHandler(this.ButtonDig3_Click);
            // 
            // ButtonDig2
            // 
            this.ButtonDig2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDig2.Location = new System.Drawing.Point(104, 301);
            this.ButtonDig2.Name = "ButtonDig2";
            this.ButtonDig2.Size = new System.Drawing.Size(86, 63);
            this.ButtonDig2.TabIndex = 14;
            this.ButtonDig2.Text = "2";
            this.ButtonDig2.UseVisualStyleBackColor = true;
            this.ButtonDig2.Click += new System.EventHandler(this.ButtonDig2_Click);
            // 
            // ButtonDig1
            // 
            this.ButtonDig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDig1.Location = new System.Drawing.Point(12, 301);
            this.ButtonDig1.Name = "ButtonDig1";
            this.ButtonDig1.Size = new System.Drawing.Size(86, 63);
            this.ButtonDig1.TabIndex = 13;
            this.ButtonDig1.Text = "1";
            this.ButtonDig1.UseVisualStyleBackColor = true;
            this.ButtonDig1.Click += new System.EventHandler(this.ButtonDig1_Click);
            // 
            // ButtonEqual
            // 
            this.ButtonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEqual.Location = new System.Drawing.Point(288, 370);
            this.ButtonEqual.Name = "ButtonEqual";
            this.ButtonEqual.Size = new System.Drawing.Size(86, 64);
            this.ButtonEqual.TabIndex = 20;
            this.ButtonEqual.Text = "=";
            this.ButtonEqual.UseVisualStyleBackColor = true;
            this.ButtonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // ButtonDecPoint
            // 
            this.ButtonDecPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDecPoint.Location = new System.Drawing.Point(196, 370);
            this.ButtonDecPoint.Name = "ButtonDecPoint";
            this.ButtonDecPoint.Size = new System.Drawing.Size(86, 64);
            this.ButtonDecPoint.TabIndex = 19;
            this.ButtonDecPoint.Text = ".";
            this.ButtonDecPoint.UseVisualStyleBackColor = true;
            this.ButtonDecPoint.Click += new System.EventHandler(this.ButtonDecPoint_Click);
            // 
            // ButtonDig0
            // 
            this.ButtonDig0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDig0.Location = new System.Drawing.Point(12, 370);
            this.ButtonDig0.Name = "ButtonDig0";
            this.ButtonDig0.Size = new System.Drawing.Size(178, 64);
            this.ButtonDig0.TabIndex = 18;
            this.ButtonDig0.Text = "0";
            this.ButtonDig0.UseVisualStyleBackColor = true;
            this.ButtonDig0.Click += new System.EventHandler(this.ButtonDig0_Click);
            // 
            // LabelPrevResult
            // 
            this.LabelPrevResult.AutoSize = true;
            this.LabelPrevResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabelPrevResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrevResult.Location = new System.Drawing.Point(12, 12);
            this.LabelPrevResult.MinimumSize = new System.Drawing.Size(360, 0);
            this.LabelPrevResult.Name = "LabelPrevResult";
            this.LabelPrevResult.Size = new System.Drawing.Size(360, 29);
            this.LabelPrevResult.TabIndex = 21;
            this.LabelPrevResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 470);
            this.Controls.Add(this.LabelPrevResult);
            this.Controls.Add(this.ButtonEqual);
            this.Controls.Add(this.ButtonDecPoint);
            this.Controls.Add(this.ButtonDig0);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonDig3);
            this.Controls.Add(this.ButtonDig2);
            this.Controls.Add(this.ButtonDig1);
            this.Controls.Add(this.ButtonSubstract);
            this.Controls.Add(this.ButtonDig6);
            this.Controls.Add(this.ButtonDig5);
            this.Controls.Add(this.ButtonDig4);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonDig9);
            this.Controls.Add(this.ButtonDig8);
            this.Controls.Add(this.ButtonDig7);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonPercent);
            this.Controls.Add(this.ButtonNegate);
            this.Controls.Add(this.ButtonAC);
            this.Controls.Add(this.LabelResult);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Button ButtonAC;
        private System.Windows.Forms.Button ButtonNegate;
        private System.Windows.Forms.Button ButtonPercent;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonDig9;
        private System.Windows.Forms.Button ButtonDig8;
        private System.Windows.Forms.Button ButtonDig7;
        private System.Windows.Forms.Button ButtonSubstract;
        private System.Windows.Forms.Button ButtonDig6;
        private System.Windows.Forms.Button ButtonDig5;
        private System.Windows.Forms.Button ButtonDig4;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDig3;
        private System.Windows.Forms.Button ButtonDig2;
        private System.Windows.Forms.Button ButtonDig1;
        private System.Windows.Forms.Button ButtonEqual;
        private System.Windows.Forms.Button ButtonDecPoint;
        private System.Windows.Forms.Button ButtonDig0;
        private System.Windows.Forms.Label LabelPrevResult;
    }
}

