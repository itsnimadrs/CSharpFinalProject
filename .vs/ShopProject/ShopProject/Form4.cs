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


namespace ShopProject
{
   
    public partial class frmProduct : Form
    {
        SqlConnection myconnection = new SqlConnection("Data Source =.;Initial Catalog=ShopDB;Integrated Security= True");
        Boolean mychekCode;
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            SqlDataAdapter myda = new SqlDataAdapter("SELECT ProductID AS[کد کالا ] ,ProductTitle AS[نام کالا],ProducPrice AS [قیمت کالا ],ProducInventory AS[موجودی کالا ]FROM Product", myconnection);
            DataTable mydt = new DataTable();
            myda.Fill(mydt);
            grv1.DataSource = mydt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                txtCode.Focus();
            }
            else if (mychekCode==true)
            {
                txtCode.Focus();

                MessageBox.Show("کدکالا تکراری است ");


            }else if (string.IsNullOrEmpty(txtTitle.Text))
            {
                txtTitle.Focus();
            }else if (string.IsNullOrEmpty(txtPrice.Text))
            {
                txtPrice.Focus();
            }else if (string.IsNullOrEmpty(txtQTY.Text))
            {
                txtQTY.Focus();
            }
            else
            {
                try
                {
                    myconnection.Open();
                    SqlCommand myinsertproduct = new SqlCommand("INSERT INTO Product(ProductID,ProductTitle, ProducPrice, ProducInventory)VALUES(@ProductID,@ProductTitle, @ProducPrice, @ProducInventory)", myconnection);
                    myinsertproduct.Parameters.AddWithValue("@ProductID", Convert.ToInt32(txtCode.Text));
                    myinsertproduct.Parameters.AddWithValue("@ProductTitle", (txtTitle.Text));
                    myinsertproduct.Parameters.AddWithValue("@ProducPrice", (txtPrice.Text));
                    myinsertproduct.Parameters.AddWithValue("@ProducInventory", (txtQTY.Text));
                    myinsertproduct.ExecuteNonQuery();
                    myconnection.Close();
                    txtCode.Clear();
                    txtTitle.Clear();
                    txtPrice.Clear();
                    txtQTY.Clear();
                    MessageBox.Show("با موفقیت ثبت شد ");
                    frmProduct_Load(sender, e);


                }
                catch (Exception)
                {

                    MessageBox.Show("خطا در گرفتن اطلاعات کالا ها ");
                }
                myconnection.Close();

            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

            try
            {
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("select *from Product where ProductID =@ProductID", myconnection);
                mycommand.Parameters.AddWithValue("@ProductID", txtCode.Text);
                mychekCode = Convert.ToBoolean(mycommand.ExecuteScalar());
                myconnection.Close();





            }
            catch (Exception)
            {
                txtTitle.Clear();
                txtPrice.Clear();
                txtQTY.Clear();

                mychekCode = false;
               
            }
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (grv1.SelectedRows.Count > 0)
            {
                try
                {
                    int productId = Convert.ToInt32(grv1.SelectedRows[0].Cells["کد کالا "].Value); 

                    myconnection.Open();
                    SqlCommand mycommandDelete = new SqlCommand("DELETE FROM Product WHERE ProductID=@ProductID", myconnection);
                    mycommandDelete.Parameters.AddWithValue("@ProductID", productId);
                    mycommandDelete.ExecuteNonQuery();
                    myconnection.Close();

                    frmProduct_Load(sender, e); 
                    MessageBox.Show("اطلاعات کالا حذف گردید.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("اشکال در حذف اطلاعات: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("لطفاً یک کالا را انتخاب کنید.");
            }
        }
    }
}
