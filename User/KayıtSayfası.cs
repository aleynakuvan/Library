using Library.ORM.Context;
using Library.ORM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace User
{
    public partial class KayıtSayfası : Form
    {
        Projectcontext db;
        public KayıtSayfası()
        {
            InitializeComponent();
            db = new Projectcontext();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

           Kullanıcı k = new Kullanıcı();
            k.Ad = txt_isim.Text;
            k.Soyad= txt_soyism.Text;
            k.KullanıcıAdı = txt_kadi.Text;
            k.Sifre = txt_sifre.Text;
            k.Telefon = m_telefon.Text;

            k.Email = txt_email.Text;
            k.Adres = r_adres.Text;


            db.Kullanıcıs.Add(k);
            db.SaveChanges();
           


            txt_isim.Text = string.Empty;
            txt_soyism.Text = string.Empty;
            txt_kadi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
            m_telefon.Text = string.Empty;
            txt_email.Text = string.Empty;
            r_adres.Text = string.Empty;

            MessageBox.Show("Kayıt Başarılı.Giriş Yapabilirsiniz...");
            KullanıcıGirişi girs = new KullanıcıGirişi();
            this.Hide();
            girs.Show();


        }
      
    }
}
