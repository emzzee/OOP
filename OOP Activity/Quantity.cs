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
    public partial class Quantity : Form
    {
        SqlConnection con = new SqlConnection();
        DBConnection dbcon = new DBConnection();
        readonly private int itemId;

        public Quantity(int id, int quantity)
        {
            InitializeComponent();
            itemId = id;
            textBox2.Text = quantity.ToString();
        }

        private void Quantity_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(dbcon.MyConnection());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Cart SET Quantity = @quantity WHERE Id = @id";
            cmd.Parameters.AddWithValue("@quantity", textBox2.Text);
            cmd.Parameters.AddWithValue("@id", itemId);
            cmd.ExecuteNonQuery();
            con.Close();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox2.Text);
            value++;
            textBox2.Text = value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int value))
            {
                if (value > 1)
                {
                    value--;
                    textBox2.Text = value.ToString();
                }
            }
        }
    }
}
