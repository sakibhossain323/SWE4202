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
            this.LabelGreetUser = new System.Windows.Forms.Label();
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
            this.ButtonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            // 
            // LabelGreetUser
            // 
            this.LabelGreetUser.AutoSize = true;
            this.LabelGreetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGreetUser.Location = new System.Drawing.Point(107, 124);
            this.LabelGreetUser.Name = "LabelGreetUser";
            this.LabelGreetUser.Size = new System.Drawing.Size(210, 24);
            this.LabelGreetUser.TabIndex = 2;
            this.LabelGreetUser.Text = "Welcome, \"UserName\"!";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.LabelGreetUser);
            this.Controls.Add(this.ButtonLogOut);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogOut;
        private System.Windows.Forms.Label LabelGreetUser;
    }
}