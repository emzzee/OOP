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

namespace OOP_Activity
{
    public partial class AddStocks : Form
    {
        SqlConnection con = new SqlConnection();
        DBConnection dbcon = new DBConnection();
        public string searchbar;
        public string oldstocks;
        public AddStocks(string productname)
        {
            InitializeComponent();
            searchbar = productname;
        }

        private void AddStocks_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(dbcon.MyConnection());
            string q = "SELECT * FROM Products WHERE Name='" + searchbar + "'";
            SqlCommand Comm = new SqlCommand(q, con);
            con.Open();
            SqlDataReader dataread = Comm.ExecuteReader();
            if (dataread.Read())
            {
                textid.Text = dataread.GetValue(0).ToString();
                textname.Text = dataread.GetValue(1).ToString();
                oldstocks = dataread.GetValue(3).ToString();
            }
            con.Close();
        }

        private void btnaddstocks_Click(object sender, EventArgs e)
        {
            int txtid = Convert.ToInt32(textid.Text);
            string txtname = textname.Text;
            int txtstocks = Convert.ToInt32(textstocks.Text);
            int txtstocks3 = txtstocks + Convert.ToInt32(oldstocks);

            string querry = "INSERT INTO ProductHistory VALUES ('" + txtname + "','" + txtstocks + "', GETDATE()) " +
                "\nUPDATE Products SET stocks ='" + txtstocks3 + "' WHERE Id = '" + txtid + "' ";

            con = new SqlConnection(dbcon.MyConnection());
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully!");
            this.Close();
        }
    }
}
