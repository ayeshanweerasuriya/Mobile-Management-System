using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Management_System
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnaddnewphone_Click(object sender, EventArgs e)
        {
            uC_AddNewPhone1.Visible = true;
            uC_AddNewPhone1.BringToFront();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_AddNewPhone1.Visible = true;
            btnaddnewphone.PerformClick();
            uC_Customer1.Visible = false;
            uC_Stock1.Visible = false;
            uC_Customer_Records1.Visible = false;
            uC_Delete_Phone_Record1.Visible = false;

            enableDisable(false, false, false);
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();
        }

        private void btncustomerrecords_Click(object sender, EventArgs e)
        {
            uC_Customer_Records1.Visible = true;
            uC_Customer_Records1.BringToFront();
        }

        //----------- For Hide -----------//

        public void enableDisable(Boolean txtbox, Boolean btn1, Boolean btn2)
        {
            txtpassword.Visible = txtbox;
            btnverify.Visible = btn1;
            btncancel.Visible = btn2;
        }

        private void btndeletephone_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            enableDisable(true, true, true);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            enableDisable(false, false, false);
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "password")
            {
                panel2.Enabled = true;
                uC_Delete_Phone_Record1.Visible = true;
                uC_Delete_Phone_Record1.BringToFront();
                enableDisable(false, false, false);
                txtpassword.Clear();
            }
            else
            {
                txtpassword.Clear();
            }
        }
    }
}
