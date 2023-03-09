namespace User
{
    partial class AdminGecis
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
            this.btn_kitap = new System.Windows.Forms.Button();
            this.btn_üye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kitap
            // 
            this.btn_kitap.Location = new System.Drawing.Point(66, 33);
            this.btn_kitap.Name = "btn_kitap";
            this.btn_kitap.Size = new System.Drawing.Size(191, 69);
            this.btn_kitap.TabIndex = 0;
            this.btn_kitap.Text = "Kitap İşlemleri";
            this.btn_kitap.UseVisualStyleBackColor = true;
            this.btn_kitap.Click += new System.EventHandler(this.btn_kitap_Click);
            // 
            // btn_üye
            // 
            this.btn_üye.Location = new System.Drawing.Point(66, 122);
            this.btn_üye.Name = "btn_üye";
            this.btn_üye.Size = new System.Drawing.Size(191, 69);
            this.btn_üye.TabIndex = 1;
            this.btn_üye.Text = "Üye İşlemleri";
            this.btn_üye.UseVisualStyleBackColor = true;
            this.btn_üye.Click += new System.EventHandler(this.btn_üye_Click);
            // 
            // AdminGecis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(339, 213);
            this.Controls.Add(this.btn_üye);
            this.Controls.Add(this.btn_kitap);
            this.Name = "AdminGecis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGecis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kitap;
        private System.Windows.Forms.Button btn_üye;
    }
}