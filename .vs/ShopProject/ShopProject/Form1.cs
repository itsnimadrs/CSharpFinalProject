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
   
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ثبتاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ثبتکاربرجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser myUser = new frmUser();
            myUser.ShowDialog();

        }

        private void ثبتمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer mycustomer = new frmCustomer();
            mycustomer.ShowDialog();

        }

        private void ثبتکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct myproduct = new frmProduct();
            myproduct.ShowDialog();

        }
    }
}
