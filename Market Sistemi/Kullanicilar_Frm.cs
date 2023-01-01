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
    public partial class Kullanicilar_Frm : Form
    {
        public Kullanicilar_Frm()
        {
            InitializeComponent();
        }
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void kasabtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            deneme f1 = new deneme();
            f1.Show();
        }

        private void Kullanicilar_Frm_Load(object sender, EventArgs e)
        {
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo cihaz in Cihazlar)
            {
                cmbKamera.Items.Add(cihaz.Name);
            }
            cmbKamera.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);
            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap GoruntulenenBarkod = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader okuyucu = new BarcodeReader();
            var sonuc = okuyucu.Decode(GoruntulenenBarkod);
            if (sonuc != null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarcode.Text = sonuc.ToString();

                }
                ));
            }
            PictureBox1.Image = GoruntulenenBarkod;
        }
    }
}
