using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP_Activity
{
    public partial class UPDATE : Form
    {
        SqlConnection con = new SqlConnection();
        DBConnection dbcon = new DBConnection();
        Form closeform = new Form();
        
        public UPDATE(string srchbar)
        {
            InitializeComponent();
            string searchbar = srchbar;
            textname.Text= searchbar;
            slot = searchbar;

        }
        public string slot;

        private void UPDATE_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(dbcon.MyConnection());
            string q = "SELECT * FROM Products WHERE name='" + textname.Text + "'";
            SqlCommand Comm = new SqlCommand(q, con);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Category", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            SqlDataReader dataread = Comm.ExecuteReader();
            if (dataread.Read())
            {
                textid.Text = dataread.GetValue(0).ToString();
                textname.Text = dataread.GetValue(1).ToString();
                textprice.Text = dataread.GetValue(2).ToString();
                textstocks.Text = dataread.GetValue(3).ToString();
                textunits.Text = dataread.GetValue(4).ToString();
                combobox.Text = dataread.GetValue(5).ToString();
            }
            con.Close();

            combobox.DataSource = ds.Tables[0];
            combobox.DisplayMember = "Category";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int txtid = Convert.ToInt32(textid.Text);
            string txtname = textname.Text;
            int txtprice = Convert.ToInt32(textprice.Text);
            int txtstocks = Convert.ToInt32(textstocks.Text);
            int txtunits = Convert.ToInt32(textunits.Text);
            string txtcategory = combobox.Text;

            con= new SqlConnection(dbcon.MyConnection());
            string querry = "INSERT INTO ProductHistory VALUES('" + txtname + "','" + txtstocks + "', GETDATE()) " + 
                "\nUPDATE Products SET Name ='" + txtname + "', Price ='" + txtprice + "'" +
                ", Stocks ='" + txtstocks + "',Units ='" + txtunits + "',Category ='" + txtcategory + "' " +
                "WHERE Id = '" + txtid + "'";

            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully!");
            this.Close();
        }
    }
}








