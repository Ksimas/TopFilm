namespace TopFilm
{
    partial class FormLog
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
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.labelAskAboutAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNick
            // 
            this.textBoxNick.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxNick.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNick.Location = new System.Drawing.Point(411, 306);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(186, 29);
            this.textBoxNick.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Location = new System.Drawing.Point(411, 411);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(186, 72);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Zaloguj się";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNick.Location = new System.Drawing.Point(310, 312);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(65, 23);
            this.labelNick.TabIndex = 3;
            this.labelNick.Text = "Login:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(310, 354);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(65, 23);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Hasło:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(340, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(329, 102);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "TopFilm";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCopyright.Location = new System.Drawing.Point(385, 690);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(206, 14);
            this.labelCopyright.TabIndex = 7;
            this.labelCopyright.Text = "Copyright © 2018-2018 Topfilm sp. z o.o.";
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.BackColor = System.Drawing.Color.AliceBlue;
            this.maskedTextBoxPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(411, 348);
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(186, 29);
            this.maskedTextBoxPassword.TabIndex = 8;
            this.maskedTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.AliceBlue;
            this.button_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_login.Location = new System.Drawing.Point(472, 508);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(124, 39);
            this.button_login.TabIndex = 22;
            this.button_login.Text = "Zarejestruj się";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click_1);
            // 
            // labelAskAboutAccount
            // 
            this.labelAskAboutAccount.AutoSize = true;
            this.labelAskAboutAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAskAboutAccount.Location = new System.Drawing.Point(265, 517);
            this.labelAskAboutAccount.Name = "labelAskAboutAccount";
            this.labelAskAboutAccount.Size = new System.Drawing.Size(190, 21);
            this.labelAskAboutAccount.TabIndex = 21;
            this.labelAskAboutAccount.Text = "Nie masz jeszcze konta?";
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.labelAskAboutAccount);
            this.Controls.Add(this.maskedTextBoxPassword);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxNick);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FormLog";
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassword;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label labelAskAboutAccount;
    }
}