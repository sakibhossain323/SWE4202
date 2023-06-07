
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.acButton = new System.Windows.Forms.Button();
            this.negateButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.dig9Button = new System.Windows.Forms.Button();
            this.dig8Button = new System.Windows.Forms.Button();
            this.dig7Button = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.dig6Button = new System.Windows.Forms.Button();
            this.dig5Button = new System.Windows.Forms.Button();
            this.dig4Button = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dig3Button = new System.Windows.Forms.Button();
            this.dig2Button = new System.Windows.Forms.Button();
            this.dig1Button = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.dig0Button = new System.Windows.Forms.Button();
            this.prevResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(12, 41);
            this.resultLabel.MinimumSize = new System.Drawing.Size(360, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(360, 55);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // acButton
            // 
            this.acButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acButton.Location = new System.Drawing.Point(12, 111);
            this.acButton.Name = "acButton";
            this.acButton.Size = new System.Drawing.Size(86, 60);
            this.acButton.TabIndex = 1;
            this.acButton.Text = "AC";
            this.acButton.UseVisualStyleBackColor = true;
            this.acButton.Click += new System.EventHandler(this.acButton_Click);
            // 
            // negateButton
            // 
            this.negateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negateButton.Location = new System.Drawing.Point(104, 111);
            this.negateButton.Name = "negateButton";
            this.negateButton.Size = new System.Drawing.Size(86, 60);
            this.negateButton.TabIndex = 2;
            this.negateButton.Text = "+/-";
            this.negateButton.UseVisualStyleBackColor = true;
            this.negateButton.Click += new System.EventHandler(this.negateButton_Click);
            // 
            // percentButton
            // 
            this.percentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentButton.Location = new System.Drawing.Point(196, 111);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(86, 60);
            this.percentButton.TabIndex = 3;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = true;
            this.percentButton.Click += new System.EventHandler(this.percentButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(288, 111);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(86, 60);
            this.divideButton.TabIndex = 4;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(288, 177);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(86, 56);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // dig9Button
            // 
            this.dig9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig9Button.Location = new System.Drawing.Point(196, 177);
            this.dig9Button.Name = "dig9Button";
            this.dig9Button.Size = new System.Drawing.Size(86, 56);
            this.dig9Button.TabIndex = 7;
            this.dig9Button.Text = "9";
            this.dig9Button.UseVisualStyleBackColor = true;
            this.dig9Button.Click += new System.EventHandler(this.dig9Button_Click);
            // 
            // dig8Button
            // 
            this.dig8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig8Button.Location = new System.Drawing.Point(104, 177);
            this.dig8Button.Name = "dig8Button";
            this.dig8Button.Size = new System.Drawing.Size(86, 56);
            this.dig8Button.TabIndex = 6;
            this.dig8Button.Text = "8";
            this.dig8Button.UseVisualStyleBackColor = true;
            this.dig8Button.Click += new System.EventHandler(this.dig8Button_Click);
            // 
            // dig7Button
            // 
            this.dig7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig7Button.Location = new System.Drawing.Point(12, 177);
            this.dig7Button.Name = "dig7Button";
            this.dig7Button.Size = new System.Drawing.Size(86, 56);
            this.dig7Button.TabIndex = 5;
            this.dig7Button.Text = "7";
            this.dig7Button.UseVisualStyleBackColor = true;
            this.dig7Button.Click += new System.EventHandler(this.dig7Button_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(288, 239);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(86, 56);
            this.minusButton.TabIndex = 12;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // dig6Button
            // 
            this.dig6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig6Button.Location = new System.Drawing.Point(196, 239);
            this.dig6Button.Name = "dig6Button";
            this.dig6Button.Size = new System.Drawing.Size(86, 56);
            this.dig6Button.TabIndex = 11;
            this.dig6Button.Text = "6";
            this.dig6Button.UseVisualStyleBackColor = true;
            this.dig6Button.Click += new System.EventHandler(this.dig6Button_Click);
            // 
            // dig5Button
            // 
            this.dig5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig5Button.Location = new System.Drawing.Point(104, 239);
            this.dig5Button.Name = "dig5Button";
            this.dig5Button.Size = new System.Drawing.Size(86, 56);
            this.dig5Button.TabIndex = 10;
            this.dig5Button.Text = "5";
            this.dig5Button.UseVisualStyleBackColor = true;
            this.dig5Button.Click += new System.EventHandler(this.dig5Button_Click);
            // 
            // dig4Button
            // 
            this.dig4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig4Button.Location = new System.Drawing.Point(12, 239);
            this.dig4Button.Name = "dig4Button";
            this.dig4Button.Size = new System.Drawing.Size(86, 56);
            this.dig4Button.TabIndex = 9;
            this.dig4Button.Text = "4";
            this.dig4Button.UseVisualStyleBackColor = true;
            this.dig4Button.Click += new System.EventHandler(this.dig4Button_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(288, 301);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 63);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dig3Button
            // 
            this.dig3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig3Button.Location = new System.Drawing.Point(196, 301);
            this.dig3Button.Name = "dig3Button";
            this.dig3Button.Size = new System.Drawing.Size(86, 63);
            this.dig3Button.TabIndex = 15;
            this.dig3Button.Text = "3";
            this.dig3Button.UseVisualStyleBackColor = true;
            this.dig3Button.Click += new System.EventHandler(this.dig3Button_Click);
            // 
            // dig2Button
            // 
            this.dig2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig2Button.Location = new System.Drawing.Point(104, 301);
            this.dig2Button.Name = "dig2Button";
            this.dig2Button.Size = new System.Drawing.Size(86, 63);
            this.dig2Button.TabIndex = 14;
            this.dig2Button.Text = "2";
            this.dig2Button.UseVisualStyleBackColor = true;
            this.dig2Button.Click += new System.EventHandler(this.dig2Button_Click);
            // 
            // dig1Button
            // 
            this.dig1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig1Button.Location = new System.Drawing.Point(12, 301);
            this.dig1Button.Name = "dig1Button";
            this.dig1Button.Size = new System.Drawing.Size(86, 63);
            this.dig1Button.TabIndex = 13;
            this.dig1Button.Text = "1";
            this.dig1Button.UseVisualStyleBackColor = true;
            this.dig1Button.Click += new System.EventHandler(this.dig1Button_Click);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(288, 370);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(86, 64);
            this.equalButton.TabIndex = 20;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointButton.Location = new System.Drawing.Point(196, 370);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(86, 64);
            this.pointButton.TabIndex = 19;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.pointButton_Click);
            // 
            // dig0Button
            // 
            this.dig0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dig0Button.Location = new System.Drawing.Point(12, 370);
            this.dig0Button.Name = "dig0Button";
            this.dig0Button.Size = new System.Drawing.Size(178, 64);
            this.dig0Button.TabIndex = 18;
            this.dig0Button.Text = "0";
            this.dig0Button.UseVisualStyleBackColor = true;
            this.dig0Button.Click += new System.EventHandler(this.dig0Button_Click);
            // 
            // prevResultLabel
            // 
            this.prevResultLabel.AutoSize = true;
            this.prevResultLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prevResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevResultLabel.Location = new System.Drawing.Point(12, 12);
            this.prevResultLabel.MinimumSize = new System.Drawing.Size(360, 0);
            this.prevResultLabel.Name = "prevResultLabel";
            this.prevResultLabel.Size = new System.Drawing.Size(360, 29);
            this.prevResultLabel.TabIndex = 21;
            this.prevResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 470);
            this.Controls.Add(this.prevResultLabel);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.dig0Button);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dig3Button);
            this.Controls.Add(this.dig2Button);
            this.Controls.Add(this.dig1Button);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.dig6Button);
            this.Controls.Add(this.dig5Button);
            this.Controls.Add(this.dig4Button);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.dig9Button);
            this.Controls.Add(this.dig8Button);
            this.Controls.Add(this.dig7Button);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.negateButton);
            this.Controls.Add(this.acButton);
            this.Controls.Add(this.resultLabel);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button acButton;
        private System.Windows.Forms.Button negateButton;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button dig9Button;
        private System.Windows.Forms.Button dig8Button;
        private System.Windows.Forms.Button dig7Button;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button dig6Button;
        private System.Windows.Forms.Button dig5Button;
        private System.Windows.Forms.Button dig4Button;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button dig3Button;
        private System.Windows.Forms.Button dig2Button;
        private System.Windows.Forms.Button dig1Button;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button dig0Button;
        private System.Windows.Forms.Label prevResultLabel;
    }
}

