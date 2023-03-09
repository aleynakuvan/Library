namespace User
{
    partial class AnaForm2
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
            this.Kitaplistesi = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_liste = new System.Windows.Forms.Button();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ckis = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kitaplistesi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verilen Kitap Detayları";
            // 
            // Kitaplistesi
            // 
            this.Kitaplistesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.Kitaplistesi.FullRowSelect = true;
            this.Kitaplistesi.GridLines = true;
            this.Kitaplistesi.HideSelection = false;
            this.Kitaplistesi.Location = new System.Drawing.Point(7, 19);
            this.Kitaplistesi.Name = "Kitaplistesi";
            this.Kitaplistesi.Size = new System.Drawing.Size(465, 239);
            this.Kitaplistesi.TabIndex = 1;
            this.Kitaplistesi.UseCompatibleStateImageBehavior = false;
            this.Kitaplistesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kitap Adı";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aldığınız kitapları 15 gün içerisinde teslim ediniz.";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(225, 86);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(110, 19);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_liste
            // 
            this.btn_liste.Location = new System.Drawing.Point(516, 113);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(110, 43);
            this.btn_liste.TabIndex = 5;
            this.btn_liste.Text = "LİSTEYİ GÖRÜNTÜLE";
            this.btn_liste.UseVisualStyleBackColor = true;
            this.btn_liste.Click += new System.EventHandler(this.btn_liste_Click);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 100;
            // 
            // btn_ckis
            // 
            this.btn_ckis.Location = new System.Drawing.Point(516, 183);
            this.btn_ckis.Name = "btn_ckis";
            this.btn_ckis.Size = new System.Drawing.Size(110, 43);
            this.btn_ckis.TabIndex = 6;
            this.btn_ckis.Text = "ÇIKIŞ";
            this.btn_ckis.UseVisualStyleBackColor = true;
            this.btn_ckis.Click += new System.EventHandler(this.btn_ckis_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kitabın Yazarı";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kitabın YayınEvi";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Location = new System.Drawing.Point(5, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lütfen Almak İstediğiniz Kitabın \"Id\" Numarasını Yazınız.";
            // 
            // txt_nu
            // 
            this.txt_nu.Location = new System.Drawing.Point(6, 43);
            this.txt_nu.Name = "txt_nu";
            this.txt_nu.Size = new System.Drawing.Size(270, 20);
            this.txt_nu.TabIndex = 7;
            // 
            // AnaForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_ckis);
            this.Controls.Add(this.btn_liste);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_liste;
        private System.Windows.Forms.ListView Kitaplistesi;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button btn_ckis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nu;
        private System.Windows.Forms.Label label1;
    }
}