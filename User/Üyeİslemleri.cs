using Library.ORM.Context;
using Library.ORM.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace User
{
    public partial class Üyeİslemleri : Form
    {
        Projectcontext db;
        public Üyeİslemleri()
        {
            InitializeComponent();
            db = new Projectcontext();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            AdminGecis admin = new AdminGecis();
            this.Hide();
            admin.Show();
        }
        private void AdminGecis_Load(object sender, EventArgs e)
        {
            UyeListesi();
        }
        Kullanıcı updated;

      
        private void UyeListesi()
        {
            Üyelist.Items.Clear();

            List<Kullanıcı> liste = db.Kullanıcıs.ToList();
            foreach (Kullanıcı item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Id.ToString();
                lvi.SubItems.Add(item.Ad);
                lvi.SubItems.Add(item.Soyad);
                lvi.SubItems.Add(item.KullanıcıAdı);
                lvi.SubItems.Add(item.Telefon);
                lvi.SubItems.Add(item.Email);
                lvi.SubItems.Add(item.Adres);
                lvi.Tag = item.Id;
                Üyelist.Items.Add(lvi);
            }  }
      

        private void btn_liste_Click(object sender, EventArgs e)
        {
            UyeListesi();
        }

        private void btn_guncel_Click(object sender, EventArgs e)
        {
            string İsim = txt_isim.Text;
            Kullanıcı a = db.Kullanıcıs.Where(i => i.Ad == İsim).FirstOrDefault();
            a.Ad = txt_isim.Text;
            a.Soyad = txt_soyism.Text;
            a.KullanıcıAdı = txt_kadi.Text;

            a.Telefon = m_telefon.Text;
            a.Email = txt_email.Text;
            a.Adres = r_adres.Text;
            UyeListesi();
            txt_isim.Clear();
            txt_soyism.Clear();
            txt_kadi.Clear();
            m_telefon.Clear();
            txt_email.Clear();
            r_adres.Clear();
            MessageBox.Show("İşlem Başarılı...");

        }
        private void Üyelist_DoubleClick(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Üyelist.SelectedItems[0].Tag);
            updated = db.Kullanıcıs.Find(id);
            txt_isim.Text = updated.Ad;
            txt_soyism.Text = updated.Soyad;
            txt_kadi.Text = updated.KullanıcıAdı;
           
            m_telefon.Text = updated.Telefon;
            txt_email.Text = updated.Email;
            r_adres.Text = updated.Adres;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (Üyelist.SelectedItems.Count <= 0) return;

            int id = Convert.ToInt32(Üyelist.SelectedItems[0].Tag);

            Kullanıcı deleted = db.Kullanıcıs.Find(id);
            db.Kullanıcıs.Remove(deleted);
            db.SaveChanges();

            UyeListesi();
            MessageBox.Show("İşlem Başarılı...");


        }


    }
}
