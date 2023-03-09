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
    public partial class Kitapislemleri : Form
    {
        Projectcontext db;
        public Kitapislemleri()
        {
            InitializeComponent();
            db = new Projectcontext();
        }

        private void btn_yenikitap_Click(object sender, EventArgs e)
        {

            Kitap book = db.Kitaps.Where(i => i.KitapAdi == txt1_kitapadi.Text && i.KitabinYazari == txt_yazar.Text && i.KitabinYayinEvi == txt_yay.Text).FirstOrDefault();
           
            
                Kitap k = new Kitap();
                k.KitapAdi = txt1_kitapadi.Text;
                k.KitabinYazari = txt_yazar.Text;
                k.KitabinYayinEvi = txt_yay.Text;


                db.Kitaps.Add(k);
                db.SaveChanges();
                KitapListesi();

                txt1_kitapadi.Text = string.Empty;
                txt_yazar.Text = string.Empty;
                txt_yay.Text = string.Empty;


                MessageBox.Show("Kayıt Başarılı...");

            
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            KitapListesi();
        }
       



        Kitap updated;
        private void Kitaplistesi_DoubleClick(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Kitaplistesi.SelectedItems[0].Tag);
            updated = db.Kitaps.Find(id);
            txt1_kitapadi.Text = updated.KitapAdi;

            txt_yazar.Text = updated.KitabinYazari;
            txt_yay.Text = updated.KitabinYayinEvi;

        }
        
        private void KitapListesi()
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

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (Kitaplistesi.SelectedItems.Count <= 0) return;

            int id = Convert.ToInt32(Kitaplistesi.SelectedItems[0].Tag);

            Kitap deleted = db.Kitaps.Find(id);
            db.Kitaps.Remove(deleted);
            db.SaveChanges();

            KitapListesi();
            MessageBox.Show("İşlem Başarılı...");
        }
        private void btn_güncel_Click(object sender, EventArgs e)
        {


            string kitapadi = txt1_kitapadi.Text;
            Kitap a = db.Kitaps.Where(i => i.KitapAdi == kitapadi).FirstOrDefault();
            a.KitapAdi = txt1_kitapadi.Text;
            a.KitabinYazari = txt_yazar.Text;
            a.KitabinYayinEvi = txt_yay.Text;

            KitapListesi();
            MessageBox.Show("İşlem Başarılı...");
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            AdminGecis admin = new AdminGecis();
            this.Hide();
            admin.Show();

        }

        private void btn_liste_Click(object sender, EventArgs e)
        {
            KitapListesi();
        }
       
    }

}
