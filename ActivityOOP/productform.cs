using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ActivityOOP
{
    public partial class productform : Form
    {
        public string connectionstring = "Data Source=(localdb)\\ProjectModels;Initial Catalog=OOP;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public productform()
        {
            InitializeComponent();
        }

        public void DisplayData()
        {
            string sql = "SELECT * FROM Products ORDER BY Id DESC";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();

            connection.Open();
            dataadapter.Fill(ds, "Products");
            dgv.DataSource = ds;
            dgv.DataMember = "Products";
            connection.Close();
        }

        private void productform_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void create_Click(object sender, EventArgs e)
        {

            createform cform = new createform();
            cform.ShowDialog();
            DisplayData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            updateform uform = new updateform();
            uform.ShowDialog();
            DisplayData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete", "Record deleted successfully!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                string q = "DELETE FROM Products";

                connection.Open();
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                tbID.Clear();
                connection.Close();
                DisplayData();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
