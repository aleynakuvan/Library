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
    public partial class AdminGecis : Form
    {
        public AdminGecis()
        {
            InitializeComponent();
        }

        private void btn_kitap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kitapislemleri kitapislemleri = new Kitapislemleri();
            kitapislemleri.Show();
        }

        private void btn_üye_Click(object sender, EventArgs e)
        {

            this.Hide();
            Üyeİslemleri islemler = new Üyeİslemleri();
            islemler.Show();
        }
    }
}
