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
    public partial class UC_Delete_Phone_Record : UserControl
    {
        function fn = new function();
        String query;
        public UC_Delete_Phone_Record()
        {
            InitializeComponent();
        }

        private void UC_Delete_Phone_Record_Enter(object sender, EventArgs e)
        {
            query = "select * from mobilelist";
            DataSet ds = fn.getData(query);
            DataGridView2.DataSource = ds.Tables[0];
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from mobilelist where cname like '" + txtsearch.Text + "%' or mname like '" + txtsearch.Text + "%' ";
            DataSet ds = fn.getData(query);
            DataGridView2.DataSource = ds.Tables[0];
        }

        int bid;
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            query = "delete from mobilelist where mid = " + bid + "";
            if (MessageBox.Show("Deleting Record of " + bid + "", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("You Cancelled the Operation.", "Back <-", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
