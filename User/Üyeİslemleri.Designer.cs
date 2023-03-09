namespace User
{
    partial class Üyeİslemleri
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
            System.Windows.Forms.Button btn_sil;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Üyelist = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_liste = new System.Windows.Forms.Button();
            this.btn_guncel = new System.Windows.Forms.Button();
            this.Geri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_soyism = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.m_telefon = new System.Windows.Forms.MaskedTextBox();
            this.r_adres = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kadi = new System.Windows.Forms.TextBox();
            btn_sil = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            btn_sil.Location = new System.Drawing.Point(437, 340);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new System.Drawing.Size(140, 23);
            btn_sil.TabIndex = 8;
            btn_sil.Text = "SİL";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Üyelist);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üye Listesi";
            // 
            // Üyelist
            // 
            this.Üyelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.Üyelist.FullRowSelect = true;
            this.Üyelist.GridLines = true;
            this.Üyelist.HideSelection = false;
            this.Üyelist.Location = new System.Drawing.Point(6, 19);
            this.Üyelist.Name = "Üyelist";
            this.Üyelist.Size = new System.Drawing.Size(716, 239);
            this.Üyelist.TabIndex = 2;
            this.Üyelist.UseCompatibleStateImageBehavior = false;
            this.Üyelist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kullanıcı Adı";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adres";
            this.columnHeader6.Width = 100;
            // 
            // btn_liste
            // 
            this.btn_liste.Location = new System.Drawing.Point(604, 340);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(140, 23);
            this.btn_liste.TabIndex = 10;
            this.btn_liste.Text = "LİSTEYİ GÖRÜNTÜLE";
            this.btn_liste.UseVisualStyleBackColor = true;
            this.btn_liste.Click += new System.EventHandler(this.btn_liste_Click);
            // 
            // btn_guncel
            // 
            this.btn_guncel.Location = new System.Drawing.Point(437, 378);
            this.btn_guncel.Name = "btn_guncel";
            this.btn_guncel.Size = new System.Drawing.Size(140, 23);
            this.btn_guncel.TabIndex = 9;
            this.btn_guncel.Text = "GÜNCELLE";
            this.btn_guncel.UseVisualStyleBackColor = true;
            this.btn_guncel.Click += new System.EventHandler(this.btn_guncel_Click);
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(604, 378);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(140, 23);
            this.Geri.TabIndex = 11;
            this.Geri.Text = "GERİ";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "E-Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Adres:";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(81, 287);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(153, 20);
            this.txt_isim.TabIndex = 24;
            // 
            // txt_soyism
            // 
            this.txt_soyism.Location = new System.Drawing.Point(81, 313);
            this.txt_soyism.Name = "txt_soyism";
            this.txt_soyism.Size = new System.Drawing.Size(153, 20);
            this.txt_soyism.TabIndex = 25;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(81, 403);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(153, 20);
            this.txt_email.TabIndex = 26;
            // 
            // m_telefon
            // 
            this.m_telefon.Location = new System.Drawing.Point(81, 377);
            this.m_telefon.Mask = "(999) 000-0000";
            this.m_telefon.Name = "m_telefon";
            this.m_telefon.Size = new System.Drawing.Size(153, 20);
            this.m_telefon.TabIndex = 17;
            // 
            // r_adres
            // 
            this.r_adres.Location = new System.Drawing.Point(283, 303);
            this.r_adres.Name = "r_adres";
            this.r_adres.Size = new System.Drawing.Size(132, 120);
            this.r_adres.TabIndex = 27;
            this.r_adres.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txt_kadi
            // 
            this.txt_kadi.Location = new System.Drawing.Point(79, 339);
            this.txt_kadi.Name = "txt_kadi";
            this.txt_kadi.Size = new System.Drawing.Size(155, 20);
            this.txt_kadi.TabIndex = 30;
            // 
            // Üyeİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 433);
            this.Controls.Add(this.txt_kadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r_adres);
            this.Controls.Add(this.m_telefon);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_soyism);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.btn_liste);
            this.Controls.Add(this.btn_guncel);
            this.Controls.Add(btn_sil);
            this.Controls.Add(this.groupBox2);
            this.Name = "Üyeİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyeİslemleri";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView Üyelist;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_liste;
        private System.Windows.Forms.Button btn_guncel;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soyism;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox m_telefon;
        private System.Windows.Forms.RichTextBox r_adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kadi;
    }
}