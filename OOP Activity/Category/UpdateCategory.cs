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
    public partial class UpdateCategory : Form
    {
        SqlConnection con = new SqlConnection();
        DBConnection dbcon = new DBConnection();
        public string txtname;
        public UpdateCategory(string nameprod)
        {

            InitializeComponent();
            txtname = nameprod;
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(dbcon.MyConnection());
            string q = "SELECT * FROM Category WHERE Category='" + txtname + "'";
            SqlCommand Comm = new SqlCommand(q, con);
            con.Open();
            SqlDataReader dataread = Comm.ExecuteReader();
            if (dataread.Read())
            {
                tbcategory.Text = dataread.GetValue(1).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string txtcategory = tbcategory.Text;
            string querry = "UPDATE Category SET Category ='" + txtcategory + "' WHERE Category = '" + txtname+ "'";
            con = new SqlConnection(dbcon.MyConnection());

            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }
    }
}
