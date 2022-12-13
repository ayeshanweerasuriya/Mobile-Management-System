using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Management_System.Administrator_UC
{
    public partial class UC_Customer_Records : UserControl
    {
        function fn = new function();
        String query;
        public UC_Customer_Records()
        {
            InitializeComponent();
        }

        private void UC_Customer_Records_Enter(object sender, EventArgs e)
        {
            query = "select * from customerPurchase";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        Boolean flag;
        private void txtsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtsearchby.SelectedIndex == 0)
            {
                flag = false;
                labeltoset.Text = "Enter Customer Name";
            }

            else if (txtsearchby.SelectedIndex == 1)
            {
                flag = true;
                labeltoset.Text = "Enter IMEI Number";
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                query = "select * from customerPurchase where cname like '" + txtsearch.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
            }

            else
            {
                query = "select * from customerPurchase where imei like '" + txtsearch.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
            }
        }
    }
}
