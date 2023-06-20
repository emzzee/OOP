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
    public partial class Transaction : Form
    {
        SqlConnection con = new SqlConnection();
        DBConnection dbcon = new DBConnection();
        public Transaction()
        {
            InitializeComponent();
            DisplayTransaction();
        }
        private void DisplayTransaction()
        {
            con = new SqlConnection(dbcon.MyConnection());
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Transaction]", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagridview.DataSource = dt;
            }
            con.Close();
        }

        private void datagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridview.SelectedRows.Count > 0)
            {
                string id = (string)datagridview.SelectedRows[0].Cells[7].Value;
                Details dlg = new Details(id);
                dlg.ShowDialog();
            }
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }
    }
}
