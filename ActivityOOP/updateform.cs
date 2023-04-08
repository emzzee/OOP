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

namespace ActivityOOP
{
    public partial class updateform : Form
    {
        public string connectionstring = "Data Source=(localdb)\\ProjectModels;Initial Catalog=OOP;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        Form closeform = new Form();
        public updateform()
        {
            InitializeComponent();
        }

        private void updateform_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            int txtid =Convert.ToInt32(tbid.Text);
            string txtname = tbname.Text;
            string txtprice = tbprice.Text;
            string txtstocks = tbstocks.Text;
            string txtunits = tbunits.Text;
            string txtcategory = cbcategory.Text;

            SqlConnection connection = new SqlConnection(connectionstring);
            string querry = "UPDATE Products SET('" + "Name= '" + txtname.ToString() + "'" + "Price=" +
                txtprice.ToString() + "Stocks=" + txtstocks.ToString() + "Units=" + txtunits.ToString() + "Category =" +
                txtcategory.ToString() + "WHERE Id =" + txtid.ToString()+"')";

            connection.Open();
            SqlCommand cmd = new SqlCommand(querry, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Inserted Successfully!");
            closeform.Close();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            updateform closeform = new updateform();
            closeform.Close();
            productform f2 = new productform();
            f2.ShowDialog();
        }
    }
}
