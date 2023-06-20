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
    public partial class CreateCategory : Form
    {
        SqlConnection con = new SqlConnection();
        DBConnection dbcon = new DBConnection();
        public CreateCategory()
        {
            InitializeComponent();
        }

        private void CreateCategory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtcategory = tbcategory.Text;
            string querry = "INSERT INTO Category VALUES ('" + txtcategory + "')";
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
