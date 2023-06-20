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
    public partial class Form1 : Form
    {
        DBConnection dbcon = new DBConnection();
        SqlConnection connection = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void product_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            string querry = "SELECT * FROM Products";
            connection = new SqlConnection(dbcon.MyConnection());
            SqlDataAdapter dataadapt = new SqlDataAdapter(querry, connection);
            DataSet ds = new DataSet();

            connection.Open();
            dataadapt.Fill(ds, "Products");
            datagrid.DataSource = ds;
            datagrid.DataMember = "Products";
            connection.Close();
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshData();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            createfrm create = new createfrm();
            create.ShowDialog();
            RefreshData();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UPDATE update = new UPDATE(tbid.Text);
            update.ShowDialog();
            RefreshData();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete", "Record deleted successfully!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection = new SqlConnection(dbcon.MyConnection());
                string q = "DELETE FROM Products WHERE Name = '"+ tbid.Text +"' ";

                connection.Open();
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                tbid.Clear();
                connection.Close();
                RefreshData();
            }
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = datagrid.Rows[indexRow];

            tbid.Text = row.Cells[1].Value.ToString();
        }


        private void btnaddstocks_Click(object sender, EventArgs e)
        {
            AddStocks stocks = new AddStocks(tbid.Text);
            stocks.ShowDialog();
            RefreshData();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm(tbid.Text);
            history.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datagrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

