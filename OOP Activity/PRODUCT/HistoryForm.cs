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
    public partial class HistoryForm : Form
    {
        SqlConnection con = new SqlConnection();
        DBConnection dbcon = new DBConnection();
        public string searchbar;
        public HistoryForm(string productname)
        {
            InitializeComponent();
            searchbar = productname;
            RefreshData();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            Label label2 = new Label();
            label2.Text = searchbar;
            label2.Location = new Point(111, 38);
            label2.Font = new Font("Calibri", 10);
            this.Controls.Add(label2);
            RefreshData();


        }

        public void RefreshData()
       {
            string querry = "SELECT * FROM ProductHistory WHERE Name = '" + searchbar + "' ORDER BY Id DESC";
            con = new SqlConnection(dbcon.MyConnection());
            SqlDataAdapter dataadapt = new SqlDataAdapter(querry, con);
            DataSet ds = new DataSet();

            con.Open();
            dataadapt.Fill(ds, "Products");
            datagridhistory.DataSource = ds;
            datagridhistory.DataMember = "Products";
            con.Close();
        }
    }
}
