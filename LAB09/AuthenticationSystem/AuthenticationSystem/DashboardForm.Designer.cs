namespace AuthenticationSystem
{
    partial class DashboardForm
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
            this.ButtonLogOut = new System.Windows.Forms.Button();
            this.LabelWlc = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonLogOut
            // 
            this.ButtonLogOut.Location = new System.Drawing.Point(157, 210);
            this.ButtonLogOut.Name = "ButtonLogOut";
            this.ButtonLogOut.Size = new System.Drawing.Size(91, 35);
            this.ButtonLogOut.TabIndex = 0;
            this.ButtonLogOut.Text = "Log Out";
            this.ButtonLogOut.UseVisualStyleBackColor = true;
            // 
            // LabelWlc
            // 
            this.LabelWlc.AutoSize = true;
            this.LabelWlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWlc.Location = new System.Drawing.Point(67, 120);
            this.LabelWlc.Name = "LabelWlc";
            this.LabelWlc.Size = new System.Drawing.Size(101, 24);
            this.LabelWlc.TabIndex = 1;
            this.LabelWlc.Text = "Welcome, ";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.Location = new System.Drawing.Point(174, 120);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(114, 24);
            this.LabelUserName.TabIndex = 2;
            this.LabelUserName.Text = "\"UserName\"";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.LabelWlc);
            this.Controls.Add(this.ButtonLogOut);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogOut;
        private System.Windows.Forms.Label LabelWlc;
        private System.Windows.Forms.Label LabelUserName;
    }
}