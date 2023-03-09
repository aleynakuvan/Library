namespace User
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1_userinput = new System.Windows.Forms.Button();
            this.btn2_member = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "KÜTÜPHANEMİZE HOŞGELDİNİZ";
            // 
            // btn1_userinput
            // 
            this.btn1_userinput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn1_userinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1_userinput.Location = new System.Drawing.Point(247, 205);
            this.btn1_userinput.Name = "btn1_userinput";
            this.btn1_userinput.Size = new System.Drawing.Size(174, 47);
            this.btn1_userinput.TabIndex = 2;
            this.btn1_userinput.Text = "Kullanıcı Girişi";
            this.btn1_userinput.UseVisualStyleBackColor = false;
            this.btn1_userinput.Click += new System.EventHandler(this.btn1_userinput_Click);
            // 
            // btn2_member
            // 
            this.btn2_member.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn2_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2_member.Location = new System.Drawing.Point(247, 284);
            this.btn2_member.Name = "btn2_member";
            this.btn2_member.Size = new System.Drawing.Size(174, 47);
            this.btn2_member.TabIndex = 3;
            this.btn2_member.Text = "Üye Ol";
            this.btn2_member.UseVisualStyleBackColor = false;
            this.btn2_member.Click += new System.EventHandler(this.btn2_member_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admin.Location = new System.Drawing.Point(247, 119);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(174, 47);
            this.btn_admin.TabIndex = 4;
            this.btn_admin.Text = "Admin Girişi";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 445);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn2_member);
            this.Controls.Add(this.btn1_userinput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1_userinput;
        private System.Windows.Forms.Button btn2_member;
        private System.Windows.Forms.Button btn_admin;
    }
}

