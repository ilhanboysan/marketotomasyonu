using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Sistemi
{
    public partial class _YonetimEkrani_Frm : Form
    {
        public _YonetimEkrani_Frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminKategoriİşlemleri f1 = new AdminKategoriİşlemleri();
            f1.Show();
        }
    }
}
