using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Market_Sistemi.Classes;

namespace Market_Sistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public  void LoadProduct()
        {
            SqlCommand commandlist = new SqlCommand("Select ProductID,ProductName,ProductPrice,ProductBarcode,CategoryName from TableProduct inner join TableCategory on TableProduct.ProductCategory=TableCategory.CategoryID", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            SqlDataAdapter da = new SqlDataAdapter(commandlist);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgProduct.DataSource = dt;

        }
        public void LoadCategories() 
        {
            SqlCommand commandLoadCategories = new SqlCommand("Select * from TableCategory",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            

            cmbBoxCategory.DisplayMember= "CategoryName";
            cmbBoxCategory.ValueMember= "CategoryID";
            
            SqlDataAdapter daLoadCategories = new SqlDataAdapter(commandLoadCategories);
            DataTable dtLoadCategories = new DataTable();
                daLoadCategories.Fill(dtLoadCategories);
            cmbBoxCategory.DataSource=dtLoadCategories;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           LoadProduct();
           LoadCategories();

        }

        private void btnMW_Click(object sender, EventArgs e)
        {
            this.Hide();
            _YonetimEkrani_Frm newForm= new _YonetimEkrani_Frm();
            newForm.Show();
        }

       

        public void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandadd = new SqlCommand("Insert into TableProduct(ProductName,ProductCategory,ProductPrice,ProductBarcode)values(@pname,@pcategory,@pprice,@pbarcode)",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection (SqlConnectionClass.connect);

            commandadd.Parameters.AddWithValue("@pname", tboxProductName.Text);
            commandadd.Parameters.AddWithValue("@pcategory", Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandadd.Parameters.AddWithValue("@pprice", tboxProductPrice.Text);
            commandadd.Parameters.AddWithValue("@pbarcode", tboxProductBarcode.Text);
            commandadd.ExecuteNonQuery();
            IncreaseCategoryCount();
             LoadProduct(); 

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from TableProduct where ProductId=@pid",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection (SqlConnectionClass.connect);

            commandDelete.Parameters.AddWithValue("@pid",Convert.ToInt32(tboxDelete.Text));
            commandDelete.ExecuteNonQuery();
            DecreaseCategoryCount();
            LoadProduct();
        }
        public  void IncreaseCategoryCount()
        {
            SqlCommand commandIncrease = new SqlCommand("Update TableCategory set CategoryCount+=1 where CategoryID=@pid",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandIncrease.Parameters.AddWithValue("@pid",Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandIncrease.ExecuteNonQuery();
        }
        public void DecreaseCategoryCount()
        {
            SqlCommand commandIncrease = new SqlCommand("Update TableCategory set CategoryCount-=1 where CategoryID=@pid", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConnection(SqlConnectionClass.connect);
            commandIncrease.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandIncrease.ExecuteNonQuery();
        }

       

        private void tboxDelete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
