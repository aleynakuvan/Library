namespace User
{
    partial class Kitapislemleri
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
            this.btn_yenikitap = new System.Windows.Forms.Button();
            this.btn_güncel = new System.Windows.Forms.Button();
            this.Geri = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Kitaplistesi = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_yay = new System.Windows.Forms.TextBox();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.txt1_kitapadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_liste = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_yenikitap
            // 
            this.btn_yenikitap.Location = new System.Drawing.Point(556, 28);
            this.btn_yenikitap.Name = "btn_yenikitap";
            this.btn_yenikitap.Size = new System.Drawing.Size(179, 47);
            this.btn_yenikitap.TabIndex = 0;
            this.btn_yenikitap.Text = "Kitap Ekleme";
            this.btn_yenikitap.UseVisualStyleBackColor = true;
            this.btn_yenikitap.Click += new System.EventHandler(this.btn_yenikitap_Click);
            // 
            // btn_güncel
            // 
            this.btn_güncel.Location = new System.Drawing.Point(556, 96);
            this.btn_güncel.Name = "btn_güncel";
            this.btn_güncel.Size = new System.Drawing.Size(179, 45);
            this.btn_güncel.TabIndex = 1;
            this.btn_güncel.Text = "Kitap Güncelleme";
            this.btn_güncel.UseVisualStyleBackColor = true;
            this.btn_güncel.Click += new System.EventHandler(this.btn_güncel_Click);
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(556, 292);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(179, 47);
            this.Geri.TabIndex = 2;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(556, 162);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(179, 47);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Kitap Silme";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Kitaplistesi);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 261);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Listesi";
            // 
            // Kitaplistesi
            // 
            this.Kitaplistesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Kitaplistesi.FullRowSelect = true;
            this.Kitaplistesi.GridLines = true;
            this.Kitaplistesi.HideSelection = false;
            this.Kitaplistesi.Location = new System.Drawing.Point(6, 16);
            this.Kitaplistesi.Name = "Kitaplistesi";
            this.Kitaplistesi.Size = new System.Drawing.Size(466, 239);
            this.Kitaplistesi.TabIndex = 0;
            this.Kitaplistesi.UseCompatibleStateImageBehavior = false;
            this.Kitaplistesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kitap Adı";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kitabın Yazarı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kitabın Yayınevi";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // txt_yay
            // 
            this.txt_yay.Location = new System.Drawing.Point(112, 334);
            this.txt_yay.Name = "txt_yay";
            this.txt_yay.Size = new System.Drawing.Size(170, 20);
            this.txt_yay.TabIndex = 22;
            // 
            // txt_yazar
            // 
            this.txt_yazar.Location = new System.Drawing.Point(112, 306);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(170, 20);
            this.txt_yazar.TabIndex = 21;
            // 
            // txt1_kitapadi
            // 
            this.txt1_kitapadi.Location = new System.Drawing.Point(112, 277);
            this.txt1_kitapadi.Name = "txt1_kitapadi";
            this.txt1_kitapadi.Size = new System.Drawing.Size(170, 20);
            this.txt1_kitapadi.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yayın Evi Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kitabın Yazarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kitabın Adı:";
            // 
            // btn_liste
            // 
            this.btn_liste.Location = new System.Drawing.Point(556, 226);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(179, 47);
            this.btn_liste.TabIndex = 23;
            this.btn_liste.Text = "Listele";
            this.btn_liste.UseVisualStyleBackColor = true;
            this.btn_liste.Click += new System.EventHandler(this.btn_liste_Click);
            // 
            // Kitapislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 368);
            this.Controls.Add(this.btn_liste);
            this.Controls.Add(this.txt_yay);
            this.Controls.Add(this.txt_yazar);
            this.Controls.Add(this.txt1_kitapadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.btn_güncel);
            this.Controls.Add(this.btn_yenikitap);
            this.Name = "Kitapislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitapislemleri";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yenikitap;
        private System.Windows.Forms.Button btn_güncel;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView Kitaplistesi;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txt_yay;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.TextBox txt1_kitapadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_liste;
    }
}