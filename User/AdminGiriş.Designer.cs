namespace User
{
    partial class AdminGiriş
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_admingiris = new System.Windows.Forms.Button();
            this.txt_adminsifre = new System.Windows.Forms.TextBox();
            this.txt_adminad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_admingiris);
            this.groupBox1.Controls.Add(this.txt_adminsifre);
            this.groupBox1.Controls.Add(this.txt_adminad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_admingiris
            // 
            this.btn_admingiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_admingiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admingiris.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_admingiris.Location = new System.Drawing.Point(215, 140);
            this.btn_admingiris.Name = "btn_admingiris";
            this.btn_admingiris.Size = new System.Drawing.Size(75, 25);
            this.btn_admingiris.TabIndex = 1;
            this.btn_admingiris.Text = "Giriş";
            this.btn_admingiris.UseVisualStyleBackColor = false;
            this.btn_admingiris.Click += new System.EventHandler(this.btn_admingiris_Click);
            // 
            // txt_adminsifre
            // 
            this.txt_adminsifre.Location = new System.Drawing.Point(126, 91);
            this.txt_adminsifre.Name = "txt_adminsifre";
            this.txt_adminsifre.PasswordChar = '*';
            this.txt_adminsifre.Size = new System.Drawing.Size(164, 20);
            this.txt_adminsifre.TabIndex = 3;
            // 
            // txt_adminad
            // 
            this.txt_adminad.Location = new System.Drawing.Point(126, 59);
            this.txt_adminad.Name = "txt_adminad";
            this.txt_adminad.Size = new System.Drawing.Size(164, 20);
            this.txt_adminad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // AdminGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 254);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminGiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGiriş";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_admingiris;
        private System.Windows.Forms.TextBox txt_adminsifre;
        private System.Windows.Forms.TextBox txt_adminad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}