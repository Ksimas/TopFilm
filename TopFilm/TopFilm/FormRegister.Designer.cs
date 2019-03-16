namespace TopFilm
{
    partial class FormRegister
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
            this.label_copyright = new System.Windows.Forms.Label();
            this.label_TopFilm = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.Button_register = new System.Windows.Forms.Button();
            this.textBox_Nick = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_register = new System.Windows.Forms.Label();
            this.label_ask_for_account = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.TextBox_Password = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Location = new System.Drawing.Point(430, 671);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(200, 13);
            this.label_copyright.TabIndex = 14;
            this.label_copyright.Text = "Copyright © 2018-2018 Topfilm sp. z o.o.";
            // 
            // label_TopFilm
            // 
            this.label_TopFilm.AutoSize = true;
            this.label_TopFilm.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TopFilm.Location = new System.Drawing.Point(342, 45);
            this.label_TopFilm.Name = "label_TopFilm";
            this.label_TopFilm.Size = new System.Drawing.Size(329, 102);
            this.label_TopFilm.TabIndex = 12;
            this.label_TopFilm.Text = "TopFilm";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password.Location = new System.Drawing.Point(322, 338);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(57, 21);
            this.label_password.TabIndex = 11;
            this.label_password.Text = "Hasło:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login.Location = new System.Drawing.Point(322, 290);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(49, 21);
            this.label_login.TabIndex = 10;
            this.label_login.Text = "Nick:";
            // 
            // Button_register
            // 
            this.Button_register.BackColor = System.Drawing.Color.AliceBlue;
            this.Button_register.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_register.Location = new System.Drawing.Point(430, 441);
            this.Button_register.Name = "Button_register";
            this.Button_register.Size = new System.Drawing.Size(189, 61);
            this.Button_register.TabIndex = 9;
            this.Button_register.Text = "Załóż konto";
            this.Button_register.UseVisualStyleBackColor = false;
            this.Button_register.Click += new System.EventHandler(this.Button_register_Click);
            // 
            // textBox_Nick
            // 
            this.textBox_Nick.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_Nick.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Nick.Location = new System.Drawing.Point(430, 287);
            this.textBox_Nick.Name = "textBox_Nick";
            this.textBox_Nick.Size = new System.Drawing.Size(189, 29);
            this.textBox_Nick.TabIndex = 8;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_email.Location = new System.Drawing.Point(322, 387);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(61, 21);
            this.label_email.TabIndex = 16;
            this.label_email.Text = "E-mail:";
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_email.Location = new System.Drawing.Point(430, 379);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(189, 29);
            this.textBox_email.TabIndex = 17;
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_register.Location = new System.Drawing.Point(428, 188);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(191, 42);
            this.label_register.TabIndex = 18;
            this.label_register.Text = "Załóż konto";
            // 
            // label_ask_for_account
            // 
            this.label_ask_for_account.AutoSize = true;
            this.label_ask_for_account.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ask_for_account.Location = new System.Drawing.Point(322, 538);
            this.label_ask_for_account.Name = "label_ask_for_account";
            this.label_ask_for_account.Size = new System.Drawing.Size(132, 21);
            this.label_ask_for_account.TabIndex = 19;
            this.label_ask_for_account.Text = "Masz już konto?";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.AliceBlue;
            this.button_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_login.Location = new System.Drawing.Point(495, 530);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(124, 33);
            this.button_login.TabIndex = 20;
            this.button_login.Text = "Zaloguj się";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.AliceBlue;
            this.TextBox_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBox_Password.Location = new System.Drawing.Point(430, 335);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(189, 29);
            this.TextBox_Password.TabIndex = 21;
            this.TextBox_Password.UseSystemPasswordChar = true;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_ask_for_account);
            this.Controls.Add(this.label_register);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_TopFilm);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.Button_register);
            this.Controls.Add(this.textBox_Nick);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FormRegister";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.Label label_TopFilm;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button Button_register;
        private System.Windows.Forms.TextBox textBox_Nick;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_register;
        private System.Windows.Forms.Label label_ask_for_account;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.MaskedTextBox TextBox_Password;
    }
}