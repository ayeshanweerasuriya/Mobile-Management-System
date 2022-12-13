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

namespace Mobile_Management_System.Administrator_UC
{
    public partial class UC_Customer : UserControl
    {
        function fn = new function();
        String query;
        public UC_Customer()
        {
            InitializeComponent();
        }


        public void setComboBOX(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void UC_Customer_Enter(object sender, EventArgs e)
        {
            txtcompany.Items.Clear();
            query = "select distinct cname from mobilelist";
            setComboBOX(query, txtcompany);
        }

        private void txtcompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmodel.Items.Clear();
            String cname = txtcompany.Text;
            query = "select mname from mobilelist where cname = '" + cname + "'";
            setComboBOX(query, txtmodel);
        }

        private void txtmodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from mobilelist where mname = '" + txtmodel.Text + "'";
            DataSet ds = fn.getData(query);

            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            rearlabel.Text = ds.Tables[0].Rows[0][6].ToString();
            frontlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            fingerlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][10].ToString();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtcontact.Text != "" && txtemail.Text != "" && txtaddress.Text != "" && txtcompany.Text != "" && txtimei.Text != "" && txtmodel.Text != "")
            {

                String name = txtname.Text;
                Int64 contact = Int64.Parse(txtcontact.Text);
                String email = txtemail.Text;
                String address = txtaddress.Text;
                String company = txtcompany.Text;
                String imei = txtimei.Text;
                String model = txtmodel.Text;

                query = "insert into customerPurchase (cname,contact,email,caddress,company,imei,model) values ('" + name + "', " + contact + ", '" + email + "', '" + address + "', '" + company + "', '" + imei + "', '" + model + "')";
                fn.setData(query);

                txtname.Clear();
                txtcontact.Clear();
                txtemail.Clear();
                txtaddress.Clear();
                txtcompany.SelectedIndex = -1;
                txtimei.Clear();
                txtmodel.SelectedIndex = -1;

                ramlabel.Clear();
                internallabel.Clear();
                rearlabel.Clear();
                frontlabel.Clear();
                fingerlabel.Clear();
                pricelabel.Clear();
            }

            else
            {
                MessageBox.Show("Fill all the fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
