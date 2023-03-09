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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn1_userinput_Click(object sender, EventArgs e)
        {
           
           KullanıcıGirişi form = new KullanıcıGirişi();
            form.Show();
            this.Hide();
        }

        private void btn2_member_Click(object sender, EventArgs e)
        {
            KayıtSayfası form = new KayıtSayfası();
            form.Show();
            this.Hide();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            AdminGiriş admin = new AdminGiriş();
            this.Hide();
            admin.Show();
        }
    }
}
