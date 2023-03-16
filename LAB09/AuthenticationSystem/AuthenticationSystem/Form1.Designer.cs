namespace AuthenticationSystem
{
    partial class LoginForm
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
            this.LabelUserName = new System.Windows.Forms.Label();
            this.Labelpass = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.LabelSignUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.Location = new System.Drawing.Point(88, 87);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(71, 17);
            this.LabelUserName.TabIndex = 0;
            this.LabelUserName.Text = "username";
            // 
            // Labelpass
            // 
            this.Labelpass.AutoSize = true;
            this.Labelpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelpass.Location = new System.Drawing.Point(88, 122);
            this.Labelpass.Name = "Labelpass";
            this.Labelpass.Size = new System.Drawing.Size(68, 17);
            this.Labelpass.TabIndex = 1;
            this.Labelpass.Text = "password";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(165, 87);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(126, 20);
            this.TextBoxUserName.TabIndex = 2;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(165, 121);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(126, 20);
            this.TextBoxPass.TabIndex = 3;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(141, 166);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(80, 29);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Log In";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            // 
            // LabelSignUp
            // 
            this.LabelSignUp.AutoSize = true;
            this.LabelSignUp.Location = new System.Drawing.Point(96, 217);
            this.LabelSignUp.Name = "LabelSignUp";
            this.LabelSignUp.Size = new System.Drawing.Size(125, 13);
            this.LabelSignUp.TabIndex = 5;
            this.LabelSignUp.Text = "Don\'t have an account? ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.LabelSignUp);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.Labelpass);
            this.Controls.Add(this.LabelUserName);
            this.Name = "LoginForm";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Label Labelpass;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label LabelSignUp;
    }
}

