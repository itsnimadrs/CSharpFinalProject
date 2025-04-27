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
    public partial class frmCustomer : Form
    {
        SqlConnection myconnection = new SqlConnection("Data Source = .;Initial Catalog=shopDB;Integrated Security=True");
        public frmCustomer()
        {
            InitializeComponent();
        }
        public void systemcode()
        {
            try
            {
                SqlDataAdapter myda = new SqlDataAdapter("select max(CustomerID)from customer", myconnection);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                txtCode.Text = (Convert.ToInt32(mydt.Rows[0].ItemArray[0] )+ 1).ToString();
            
            
            }
            catch (Exception)
            {

                txtCode.Text = "1000";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                txtCode.Focus();
            }
            else if (string.IsNullOrEmpty(txtFname.Text))
            {
                txtFname.Focus();
            }
            else if (string.IsNullOrEmpty(txtLname.Text))
            {
                txtLname.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobile.Text))
            {
                txtMobile.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                txtAddress.Focus();
            }


            else
            {
                try
                {
                    myconnection.Open();
                    SqlCommand mycommand = new SqlCommand("INSERT INTO Customer(CustomerID, CustomerFirstname, CustomerLastname, CustomerAddress, CustomerCellphone) VALUES(@CustomerID, @CustomerFirstname, @CustomerLastname, @CustomerAddress, @CustomerCellphone)", myconnection);
                    mycommand.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(txtCode.Text));
                    mycommand.Parameters.AddWithValue("@CustomerFirstname", txtFname.Text);
                    mycommand.Parameters.AddWithValue("@CustomerLastname", txtLname.Text);
                    mycommand.Parameters.AddWithValue("@CustomerAddress", txtAddress.Text);
                    mycommand.Parameters.AddWithValue("@CustomerCellphone", txtMobile.Text);
                    mycommand.ExecuteNonQuery();
                    myconnection.Close();

                    txtCode.Clear();
                    txtFname.Clear();
                    txtLname.Clear();
                    txtAddress.Clear();
                    txtMobile.Clear();
                   
                    txtFname.Focus();
                    MessageBox.Show("مشتری جدید با موفقیت ثبت گردید ");
                    frmCustomer_Load(sender, e);
                }
                catch (Exception)
                {

                    MessageBox.Show("نام تکراری وارد شده است");
                }
            }

        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            SqlDataAdapter myda = new SqlDataAdapter(" SELECT  CustomerID AS [کد مشتری], CustomerFirstname AS [نام مشتری], CustomerLastname AS [نام خانوادگی], CustomerAddress AS [آدرس],CustomerCellphone AS [موبایل] from Customer order by CustomerID desc", myconnection);
           
            DataTable mydt = new DataTable();
            myda.Fill(mydt);
            grv1.DataSource = mydt;
            systemcode();
        }
        private void TxtLname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void TxtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMobile.Focus();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
