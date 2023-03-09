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
    public partial class AdminGiriş : Form
    {
        Projectcontext db;
        public AdminGiriş()
        {
            InitializeComponent();
            db = new Projectcontext();
        }

        private void btn_admingiris_Click(object sender, EventArgs e)
        {
            Kullanıcı user = db.Kullanıcıs.Where(i => i.KullanıcıAdı == txt_adminad.Text && i.Sifre == txt_adminsifre.Text).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı veya Şifre boş geçemez!!!");
            }
            else
            {
                if (user.IsAdmin)
                {
                    MessageBox.Show("Giriş Başarılı...");
                    AdminGecis form = new AdminGecis();
                    form.Show();
                    this.Hide();
                }


                else
                {
                    txt_adminad.Clear();
                    txt_adminsifre.Clear();
                    MessageBox.Show("Kullanıcı adı veya Şifre hatalı!");
                   
                }
            }
        }

    }

}
