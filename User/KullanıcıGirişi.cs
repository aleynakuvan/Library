using Library.ORM.Context;
using Library.ORM.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User
{
    public partial class KullanıcıGirişi : Form
    {
        Projectcontext db;
        public KullanıcıGirişi()
        {
            InitializeComponent();
            db = new Projectcontext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Kullanıcı user = db.Kullanıcıs.Where(i => i.KullanıcıAdı == txt_kadi.Text && i.Sifre == txt_sifre.Text).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı veya Şifre hatalı!!!");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı");
                AnaForm2 form2 = new AnaForm2();
                this.Hide();
                form2.Show();
            }

        }

       
    }
}