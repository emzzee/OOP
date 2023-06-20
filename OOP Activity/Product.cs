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
    public partial class Product : Form
    {
        DBConnection dbcon = new DBConnection();
        SqlConnection con = new SqlConnection();
        public Product()
        {
            InitializeComponent();
            DisplayData();
            AddToCart();
        }

        public void DisplayData()
        {
            con = new SqlConnection(dbcon.MyConnection());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Product_Load(object sender, EventArgs e)
        {

        }
        private void AddToCart()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Text = "Add to Cart",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.CellContentClick -= dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void PerformSearch()
        {
            con.Open();
            DataTable dt = new DataTable("Customer");

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE Name LIKE '%' + @SearchTerm + '%' OR Category LIKE '%' + @SearchTerm + '%'", con))
            {
                cmd.Parameters.AddWithValue("@SearchTerm", "%" + textBox1.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Get the values from the selected row
                string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value);

                // Check if the item already exists in the cart
                con = new SqlConnection(dbcon.MyConnection());
                con.Open();
                string selectQuery = "SELECT Quantity, Price FROM Cart WHERE Name = @Name";

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, con))
                {
                    selectCommand.Parameters.AddWithValue("@Name", name);
                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        // Item already exists in the cart, update the quantity and price
                        int existingQuantity = Convert.ToInt32(reader["Quantity"]);
                        int existingPrice = Convert.ToInt32(reader["Price"]);
                        int newQuantity = existingQuantity + 1;
                        int newPrice = existingPrice;

                        reader.Close();

                        string updateQuery = "UPDATE Cart SET Quantity = @Quantity, Price = @Price WHERE Name = @Name";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, con))
                        {
                            updateCommand.Parameters.AddWithValue("@Quantity", newQuantity);
                            updateCommand.Parameters.AddWithValue("@Price", newPrice);
                            updateCommand.Parameters.AddWithValue("@Name", name);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        reader.Close();

                        // Item does not exist in the cart, insert a new row
                        string insertQuery = "INSERT INTO Cart (Name, Price, Quantity) VALUES (@Name, @Price, 1)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
                        {
                            insertCommand.Parameters.AddWithValue("@Name", name);
                            insertCommand.Parameters.AddWithValue("@Price", price);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                con.Close();


                // Provide feedback when item successfully added to cart
                MessageBox.Show("Product added to cart.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformSearch();
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                PerformSearch();
            }
        }
    }
}
