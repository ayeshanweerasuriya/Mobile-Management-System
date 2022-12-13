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
    public partial class UC_AddNewPhone : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddNewPhone()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtcompany.Text != "" && txtmodel.Text != "" && txtram.Text != "" && txtinternal.Text != "" && txtdisplay.Text != "" && txtrearcamera.Text != "" && txtfrontcamera.Text != "" && txtfingerprint.Text != "" && txtnetworktype.Text != "" && txtprice.Text != "")

            {
                String company = txtcompany.Text;
                String model = txtmodel.Text;
                String ram = txtram.Text;
                String intel = txtinternal.Text;
                String display = txtdisplay.Text;
                String rear = txtrearcamera.Text;
                String front = txtfrontcamera.Text;
                String fingerprint = txtfingerprint.Text;
                String network = txtnetworktype.Text;
                Int64 price = Int64.Parse(txtprice.Text);

                query = "insert into mobilelist (cname,mname,ram,internal,display,rear,front,finger,network,price) values('" + company + "', '" + model + "', '" + ram + "', '" + intel + "', '" + display + "', '" + rear + "', '" + front + "', '" + fingerprint + "', '" + network + "', " + price + " )";
                fn.setData(query);
            }

            else
            {
                MessageBox.Show("Fill All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcompany.StartIndex = -1;
            txtmodel.Clear();
            txtram.StartIndex = -1;
            txtinternal.StartIndex = -1;
            txtdisplay.StartIndex = -1;
            txtrearcamera.StartIndex = -1;
            txtfrontcamera.StartIndex = -1;
            txtfingerprint.StartIndex = -1;
            txtnetworktype.StartIndex = -1;
            txtprice.Clear();
        }
    }
}
