using Market_Sistemi.Classes;
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
    public partial class deneme : Form
    {
        public deneme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0VCIVUV\\MSSQLSERVER01;Initial Catalog=marketdb;Integrated Security=True");
        DataSet daset=new DataSet();
        

        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr=new SqlDataAdapter("Select *from sepet",baglanti);
            adtr.Fill(daset,"sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible= false;
            baglanti.Close();
        }

        private void deneme_Load(object sender, EventArgs e)
        {
            sepetlistele();

            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from TableProduct where ProductBarcode like '"+textBox1.Text+"'",baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                textBox2.Text = read["ProductName"].ToString();
                textBox3.Text = read["ProductPrice"].ToString() ;
                




            }
            baglanti.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text=(double.Parse(textBox4.Text)*double.Parse(textBox3.Text)).ToString();
            }
            catch (Exception)
            {
                ;
             
            }



            //SqlCommand hesapla = new SqlCommand("select  ProductPrice from TableProduct", SqlConnectionClass.connect);
            //string deger = dataGridView1.CurrentRow.Cells["ProductPrice"].Value.ToString();

                

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
        //bool durum;
      

        private void button1_Click(object sender, EventArgs e)
        {
                //int deger = Convert.ToInt32(textBox3.Text);

                //int miktar = Convert.ToInt32(textBox4.Text);
                //textBox5.Text = (deger * miktar).ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Sepet(barkodno,urunadi,miktari,satisfiyati,toplamfiyati) values(@barkodno,@urunadi,@satisfiyati,@miktari,@toplamfiyati)",baglanti);
            komut.Parameters.AddWithValue("@barkodno",textBox1.Text);
            komut.Parameters.AddWithValue("@urunadi", textBox2.Text);
            komut.Parameters.AddWithValue("@miktari",int.Parse(textBox3.Text));
            komut.Parameters.AddWithValue("@satisfiyati",double.Parse (textBox4.Text));
            komut.Parameters.AddWithValue("@toplamfiyati", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Sepet"].Clear();
            sepetlistele();
            textBox4.Text = "1";
            foreach (Control item in groupBox1.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    if (item !=textBox4)
                    {
                        item.Text = "";

                    }

                }

            }
            






        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Sepet where barkodno='"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Başarıyla Silindi.");
            daset.Tables["sepet"].Clear();
            sepetlistele();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SATIŞ İPTAL EDİLDİ.");
            daset.Tables["sepet"].Clear();
            sepetlistele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kullanicilar_Frm f1=new Kullanicilar_Frm();
            f1.Show();
        }
    }
}
