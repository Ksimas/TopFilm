namespace TopFilm
{
    partial class TopFilm
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.textBoxSearchEngine = new System.Windows.Forms.TextBox();
            this.label_logged_in = new System.Windows.Forms.Label();
            this.listViewMovies = new System.Windows.Forms.ListView();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegister.Location = new System.Drawing.Point(589, 12);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(118, 38);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "Załóż konto";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.Button_register_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLog.Location = new System.Drawing.Point(715, 11);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(118, 39);
            this.buttonLog.TabIndex = 2;
            this.buttonLog.Text = "Zaloguj się";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.Button_zaloguj);
            // 
            // textBoxSearchEngine
            // 
            this.textBoxSearchEngine.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxSearchEngine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchEngine.Location = new System.Drawing.Point(205, 137);
            this.textBoxSearchEngine.Name = "textBoxSearchEngine";
            this.textBoxSearchEngine.Size = new System.Drawing.Size(372, 26);
            this.textBoxSearchEngine.TabIndex = 3;
            this.textBoxSearchEngine.TextChanged += new System.EventHandler(this.search_engine_TextChanged);
            // 
            // label_logged_in
            // 
            this.label_logged_in.AutoSize = true;
            this.label_logged_in.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_logged_in.Location = new System.Drawing.Point(12, 20);
            this.label_logged_in.Name = "label_logged_in";
            this.label_logged_in.Size = new System.Drawing.Size(0, 21);
            this.label_logged_in.TabIndex = 4;
            this.label_logged_in.Visible = false;
            // 
            // listViewMovies
            // 
            this.listViewMovies.BackColor = System.Drawing.Color.Cornsilk;
            this.listViewMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewMovies.Location = new System.Drawing.Point(12, 169);
            this.listViewMovies.Name = "listViewMovies";
            this.listViewMovies.Size = new System.Drawing.Size(821, 580);
            this.listViewMovies.TabIndex = 5;
            this.listViewMovies.UseCompatibleStateImageBehavior = false;
            this.listViewMovies.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.Location = new System.Drawing.Point(715, 20);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(118, 38);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSearch.Location = new System.Drawing.Point(28, 140);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(152, 19);
            this.labelSearch.TabIndex = 7;
            this.labelSearch.Text = "Wyszukaj film po tytule:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.Location = new System.Drawing.Point(715, 120);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(118, 39);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(222, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 102);
            this.label1.TabIndex = 9;
            this.label1.Text = "Top Film";
            // 
            // TopFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(845, 761);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.listViewMovies);
            this.Controls.Add(this.label_logged_in);
            this.Controls.Add(this.textBoxSearchEngine);
            this.Controls.Add(this.buttonLog);
            this.MaximumSize = new System.Drawing.Size(911, 800);
            this.MinimumSize = new System.Drawing.Size(861, 768);
            this.Name = "TopFilm";
            this.Text = "TopFilm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopFilm_FormClosing);
            this.Load += new System.EventHandler(this.TopFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.TextBox textBoxSearchEngine;
        private System.Windows.Forms.Label label_logged_in;
        private System.Windows.Forms.ListView listViewMovies;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label1;
    }
}

