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
    public partial class createfrm : Form
    {
        SqlConnection con = new SqlConnection();
        DBConnection dbcon = new DBConnection();
        
        public createfrm()
        {
            InitializeComponent();
        }

        private void createfrm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(dbcon.MyConnection());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Category", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            cbcategory.DataSource = ds.Tables[0];
            cbcategory.DisplayMember = "Category";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(dbcon.MyConnection());
            string txtname = tbname.Text;
            int txtprice = Convert.ToInt32(tbprice.Text);
            int txtstocks = Convert.ToInt32(tbstocks.Text);
            int txtunits = Convert.ToInt32(tbunits.Text);
            string txtcategory = cbcategory.Text;
        string querry = "INSERT INTO ProductHistory VALUES('" + txtname + "','" + txtstocks + "', GETDATE()) "
                +"\nINSERT INTO Products VALUES('" + txtname.ToString() +"', '" +
                txtprice + "','" + txtstocks + "','" +txtunits + "', '" + txtcategory.ToString()+ "')";

            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully!");
            this.Close();
            //Application.Exit();
        }
    }
}
