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
    public partial class frmUser : Form
    {
        SqlConnection myconnection = new SqlConnection("Data Source = .;Initial Catalog=shopDB;Integrated Security=True");
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
       
        SqlDataAdapter myda = new SqlDataAdapter("SELECT Users.userName AS [te AS [تانام کاربری], Users.LoginQTY AS [تعداد ورود], Users.LastDate AS [ریخ آخرین ورود], Users.LastTime AS [ساعت آخرین ورود], userRoles.roleType AS نقش FROM   Users INNER JOIN    userRoles ON Users.userType = userRoles.userType ", myconnection);
        DataTable mydt = new DataTable();
        myda.Fill(mydt);
        grv1.DataSource = mydt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Focus();
            }else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();

            }
            else
            {
                int usertype;
                if (radioButton1.Checked == true)
                {
                    usertype = 0; //مدیر 

                }
                else
                {
                    usertype = 1; //کاربر عادی 

                    try
                    {
                        //درج کاربر  
                        myconnection.Open();
                        SqlCommand myCommend = new SqlCommand("INSERT INTO Users(userName,userPass,userType,LoginQTY)VALUES(@userName,@userPass,@userType,@LoginQTY)", myconnection);
                        myCommend.Parameters.AddWithValue("@userName", txtUsername.Text);
                        myCommend.Parameters.AddWithValue("@userPass", txtPassword.Text);
                        myCommend.Parameters.AddWithValue("@usertype", usertype);
                        myCommend.Parameters.AddWithValue("@LoginQTY", 0);
                        myCommend.ExecuteNonQuery();
                        myconnection.Close();

                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                        MessageBox.Show("کاربر جدید با موفقیت ثبت شد ");

                        frmUser_Load(sender, e);
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("نام تکراری وارد شده است ");
                    }
                
                
                }
            }


            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
