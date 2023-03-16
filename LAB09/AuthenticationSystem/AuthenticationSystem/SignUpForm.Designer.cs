namespace AuthenticationSystem
{
    partial class SignUpForm
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
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.LabelPass = new System.Windows.Forms.Label();
            this.TextBoxRePass = new System.Windows.Forms.TextBox();
            this.LabelRePass = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(93, 55);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(43, 17);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "name";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(145, 54);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(145, 20);
            this.TextBoxName.TabIndex = 1;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(145, 91);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(145, 20);
            this.TextBoxUserName.TabIndex = 3;
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.Location = new System.Drawing.Point(68, 92);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(71, 17);
            this.LabelUserName.TabIndex = 2;
            this.LabelUserName.Text = "username";
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(145, 130);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(145, 20);
            this.TextBoxPass.TabIndex = 5;
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPass.Location = new System.Drawing.Point(71, 130);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(68, 17);
            this.LabelPass.TabIndex = 4;
            this.LabelPass.Text = "password";
            // 
            // TextBoxRePass
            // 
            this.TextBoxRePass.Location = new System.Drawing.Point(145, 168);
            this.TextBoxRePass.Name = "TextBoxRePass";
            this.TextBoxRePass.Size = new System.Drawing.Size(145, 20);
            this.TextBoxRePass.TabIndex = 7;
            // 
            // LabelRePass
            // 
            this.LabelRePass.AutoSize = true;
            this.LabelRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRePass.Location = new System.Drawing.Point(22, 171);
            this.LabelRePass.Name = "LabelRePass";
            this.LabelRePass.Size = new System.Drawing.Size(117, 17);
            this.LabelRePass.TabIndex = 6;
            this.LabelRePass.Text = "re-type password";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(93, 257);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(132, 13);
            this.LabelLogin.TabIndex = 8;
            this.LabelLogin.Text = "Already have an account?";
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.Location = new System.Drawing.Point(145, 210);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(91, 34);
            this.ButtonSignUp.TabIndex = 9;
            this.ButtonSignUp.Text = "Sign Up";
            this.ButtonSignUp.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.TextBoxRePass);
            this.Controls.Add(this.LabelRePass);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.LabelPass);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.TextBox TextBoxRePass;
        private System.Windows.Forms.Label LabelRePass;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Button ButtonSignUp;
    }
}