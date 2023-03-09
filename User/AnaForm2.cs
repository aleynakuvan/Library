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
    public partial class AnaForm2 : Form
    {
        Projectcontext db;
        public AnaForm2()
        {
            InitializeComponent();
            db = new Projectcontext();
        }

       
        private void Kullanıcı_Load(object sender, EventArgs e)
        {
            KitapListe();

        }

      
        private void KitapListe()
        {
            Kitaplistesi.Items.Clear();

            List<Kitap> liste = db.Kitaps.ToList();
            foreach (Kitap item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Id.ToString();
                lvi.SubItems.Add(item.KitapAdi);
                lvi.SubItems.Add(item.KitabinYazari);
                lvi.SubItems.Add(item.KitabinYayinEvi);
                lvi.Tag = item.Id;
                Kitaplistesi.Items.Add(lvi);
            }
         

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            txt_nu.Clear();
            MessageBox.Show("İsteğiniz Bize Ulaşmıştır.Kitabı Kütüphanemizden 'Id' Numarasını Söyleyerek Alabilirsiniz.");

           
        }

        private void btn_liste_Click(object sender, EventArgs e)
        {
           
            KitapListe();

        }

        private void btn_ckis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış İşleminiz Yapılmıştır.");
            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }
    }
}
