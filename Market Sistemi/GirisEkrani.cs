using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Market_Sistemi
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        SqlDataReader dr;

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0VCIVUV\MSSQLSERVER01;Initial Catalog=marketdb;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select yetki_no  from giris where kullaci_adi=@lastname and sifre=@firstname ", conn);

            cmd.Parameters.AddWithValue("@lastname", kaditext.Text);
            cmd.Parameters.AddWithValue("@firstname", pwtext.Text);

            if (cmd.ExecuteScalar() != null)
            {
                if (cmd.ExecuteScalar().ToString() == "1")
                {

                    _YonetimEkrani_Frm admin = new _YonetimEkrani_Frm();
                    admin.Show();
                    MessageBox.Show("Yönetici Girişi Yapıldı.");
                    this.Hide();

                }
                else
                {
                    Kullanicilar_Frm kul = new Kullanicilar_Frm();
                    kul.Show();
                    MessageBox.Show("Kasiyer Girişi Yapıldı.");
                    this.Hide();



                }
                conn.Close();
                cmd.Parameters.Clear();
                cmd.Dispose();

            }

            conn.Close();
            cmd.Parameters.Clear();
            cmd.Dispose();
        }
    }
}
