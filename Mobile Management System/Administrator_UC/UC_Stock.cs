using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Management_System.Administrator_UC
{
    public partial class UC_Stock : UserControl
    {
        function fn = new function();
        String query;
        public UC_Stock()
        {
            InitializeComponent();
        }

        private void UC_Stock_Enter(object sender, EventArgs e)
        {
            query = "select * from mobilelist";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            query = "select * from mobilelist where mid = " + bid + "";
            DataSet ds = fn.getData(query);

            companylabel.Text = ds.Tables[0].Rows[0][1].ToString();
            modellabel.Text = ds.Tables[0].Rows[0][2].ToString();
            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            displaylabel.Text = ds.Tables[0].Rows[0][5].ToString();
            rearlabel.Text = ds.Tables[0].Rows[0][6].ToString();
            frontlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            fingerlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            networklabel.Text = ds.Tables[0].Rows[0][9].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][10].ToString();
        }
    }
}
