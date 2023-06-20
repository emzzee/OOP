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
    public partial class Details : Form
    {
        SqlConnection con = new SqlConnection();
        DBConnection dbcon = new DBConnection();
        public Details(string id)
        {
            InitializeComponent();
            DisplayTransactionItems(id);
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DisplayTransactionItems(string transactionId)
        {
            con = new SqlConnection(dbcon.MyConnection());
            con.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT Id, Name, Price, Quantity FROM Orders WHERE TransactionId = @id", con))
            {
                cmd.Parameters.AddWithValue("@id", transactionId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagridview.DataSource = dt;
            }

            con.Close();
        }
    }
}
