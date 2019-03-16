namespace TopFilm
{
    partial class FormRating
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
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelRating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Location = new System.Drawing.Point(126, 25);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(121, 27);
            this.comboBoxRate.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConfirm.Location = new System.Drawing.Point(126, 101);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(121, 31);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Zatwierdź ocenę";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRating.Location = new System.Drawing.Point(12, 28);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(102, 19);
            this.labelRating.TabIndex = 2;
            this.labelRating.Text = "Wybierz ocenę:";
            // 
            // FormRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(356, 161);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.comboBoxRate);
            this.MaximumSize = new System.Drawing.Size(372, 200);
            this.MinimumSize = new System.Drawing.Size(372, 200);
            this.Name = "FormRating";
            this.Text = "Oceń film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelRating;
    }
}