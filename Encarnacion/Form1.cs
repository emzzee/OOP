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

namespace Encarnacion
{
    public partial class Form1 : Form
    {
        public string connectionstring = "Data Source=CCS-PC011\\SQLEXPRESS;Initial Catalog=New Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlCommand cmd;
        //int ID;
        public int indexRow;
        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayData()
        {
            string sql = "SELECT * FROM Category ORDER BY Id DESC";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Category");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Category";
            connection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            string txtname = textname.Text.Trim();
            //string txtid = textid.Text.Trim();
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string array = "INSERT INTO Category VALUES('"
           + txtname.ToString() + "')";
                cmd = new SqlCommand(array, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }

            textname.Text = string.Empty;
            textid.Text = string.Empty;
            DisplayData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            //newDataRow.Cells[0].Value = textid.Text;
            newDataRow.Cells[1].Value = textname.Text;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "Record deleted successfully!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();

                string q = "DELETE FROM Category";

                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                textname.Clear();
                textid.Text = string.Empty;
                connection.Close();
                DisplayData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            textid.Text = row.Cells[0].Value.ToString();
            textname.Text = row.Cells[1].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
