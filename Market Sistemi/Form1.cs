using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Market_Sistemi
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0VCIVUV\\MSSQLSERVER01;Initial Catalog=marketdb;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;
        
        
        

        private void btnCategory_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable(); //this is creating a virtual table  
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from giris", baglanti);
            adtr.Fill(dt);
            if (dt.Rows[0]["yetki_no"].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                
                AdminKategoriİşlemleri categoryPage = new AdminKategoriİşlemleri();
                categoryPage.Show();
            }
            else
                MessageBox.Show("Yetkiniz yok");









            //this.Hide();
            //AdminKategoriİşlemleri categoryPage = new AdminKategoriİşlemleri();
            //categoryPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 productpage= new Form2();
            productpage.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach  (FilterInfo cihaz in Cihazlar)
            {
                cmbKamera.Items.Add(cihaz.Name);
            }
            cmbKamera.SelectedIndex= 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kameram= new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);
            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender,AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap GoruntulenenBarkod=(Bitmap)eventArgs.Frame.Clone();
            BarcodeReader okuyucu = new BarcodeReader();
            var sonuc = okuyucu.Decode(GoruntulenenBarkod);
            if (sonuc!=null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarcode.Text = sonuc.ToString();

                }
                ));
            }
            PictureBox1.Image = GoruntulenenBarkod; 
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kameram!=null)
            {
                if (kameram.IsRunning)
                {
                    kameram.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0VCIVUV\\MSSQLSERVER01;Initial Catalog=marketdb;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            baglanti.Open();
            com.Connection = baglanti;
            com.CommandText = "Select *From giris";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                string yetki = dr["yetki_no"].ToString();
                
                baglanti.Close();
                if (yetki=="0" || yetki=="1")
                {
                    deneme kasa = new deneme();
                    kasa.ShowDialog();
                    Form1 form1 = new Form1();
                    form1.Close();
                }
                else
                {
                    MessageBox.Show("Yetkiniz Yok");
                }


            }
            








            
           // deneme kasa = new deneme();
            
        }
    }
}
