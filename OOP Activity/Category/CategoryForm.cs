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
    public partial class CategoryForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string nameproduct;

        public CategoryForm()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.MyConnection());
            RefreshData();
        }

        public void RefreshData()
        {
            string querry = "SELECT * FROM Category";
            con = new SqlConnection(dbcon.MyConnection());
            SqlDataAdapter dataadapt = new SqlDataAdapter(querry, con);
            DataSet ds = new DataSet();

            con.Open();
            dataadapt.Fill(ds, "Category");
            datagrid.DataSource = ds;
            datagrid.DataMember = "Category";
            con.Close();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            CreateCategory category = new CreateCategory();
            category.ShowDialog();
            RefreshData();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateCategory category = new UpdateCategory(nameproduct);
            category.ShowDialog();
            RefreshData();
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = datagrid.Rows[indexRow];

            nameproduct = row.Cells[1].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete", "Record deleted successfully!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con = new SqlConnection(dbcon.MyConnection());
                string q = "DELETE FROM Category WHERE Category = '" + nameproduct + "' ";

                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                RefreshData();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}