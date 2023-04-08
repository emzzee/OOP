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
    public partial class createform : Form
    {
        public string connectionstring = "Data Source=(localdb)\\ProjectModels;Initial Catalog=OOP;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public createform()
        {
            InitializeComponent();
        }

        private void createform_Load(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            
            string txtname = tbname.Text;
            string txtprice = tbprice.Text;
            string txtstocks = tbstocks.Text;
            string txtunits = tbunits.Text;
            string txtcategory = cbcategory.Text;

            string querry = "INSERT INTO Products VALUES('" + txtname.ToString() +
                txtprice.ToString() + txtstocks.ToString() + txtunits.ToString() +
                txtcategory.ToString() + "')";

            connection.Open();
            SqlCommand cmd = new SqlCommand(querry, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Inserted Successfully!");
            Application.Exit();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
