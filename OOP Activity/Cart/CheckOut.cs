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
    public partial class CheckOut : Form
    {
        SqlConnection con = new SqlConnection();
        DBConnection dbcon = new DBConnection();
        private string transactionId;
        private static readonly HashSet<string> generatedIds = new HashSet<string>();
        public CheckOut(int totalPrice)
        {
            label3.Text = totalPrice.ToString();
            InitializeComboBox(comboBox1);
            CalculateDiscount();
            LoadCartItems();

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            InitializeComponent();
        }

        public static void InitializeComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add(new ComboBoxItem { Value = 10, Description = "10% off" });
            comboBox.Items.Add(new ComboBoxItem { Value = 15, Description = "15% off" });
            comboBox.Items.Add(new ComboBoxItem { Value = 30, Description = "30% off" });
            comboBox.Items.Add(new ComboBoxItem { Value = 50, Description = "50% off" });

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }

        private string GenerateTransactionId()
        {
            string uniqueTransactionId;

            do
            {
                uniqueTransactionId = Guid.NewGuid().ToString();
            }
            while (generatedIds.Contains(uniqueTransactionId));

            generatedIds.Add(uniqueTransactionId);

            return uniqueTransactionId;
        }

        public class ComboBoxItem
        {
            public double Value { get; set; }
            public string Description { get; set; }

            public override string ToString()
            {
                return Description;
            }
        }

        private void LoadCartItems()
        {
            try
            {
                new SqlConnection(dbcon.MyConnection());
                con.Open();

                string selectQuery = "SELECT Name, Price, Quantity FROM Cart";

                using (SqlCommand command = new SqlCommand(selectQuery, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List.Items.Clear();

                        while (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            int price = Convert.ToInt32(reader["Price"]);
                            int quantity = Convert.ToInt32(reader["Quantity"]);

                            string item = $"{quantity} x {name} - ${price}";
                            List.Items.Add(item);
                        }
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading cart items: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void CalculateDiscount()
        {
            int total = Convert.ToInt32(label3.Text);
            double discountAmount = 0;

            if (comboBox1.SelectedItem is ComboBoxItem selectedItem)
            {
                double discountPercent = selectedItem.Value;
                discountAmount = total * (discountPercent / 100);
            }

            double totalAfterDiscount = total - discountAmount;
            label7.Text = (0 - discountAmount).ToString();
            label8.Text = totalAfterDiscount.ToString();
        }

        private void ProcessTransaction()
        {
            int total = Convert.ToInt32(label3.Text);
            int cash = string.IsNullOrWhiteSpace(textBox2.Text) ? 0 : Convert.ToInt32(textBox2.Text);
            double discountPercent = 0;
            if (comboBox1.SelectedItem is ComboBoxItem selectedItem)
            {
                discountPercent = selectedItem.Value;
            }

            // Calculate the discount amount
            double discountAmount = total * (discountPercent / 100);

            // Validate if there is enough cash
            if (cash < (total - discountAmount))
            {
                MessageBox.Show("Not enough cash to complete the transaction.");
                return;
            }

            double change = cash - (total - discountAmount);
            DateTime currentDate = DateTime.Now;
            string transactionId = this.transactionId;

            // Save the transaction data to the database
            try
            {
                con = new SqlConnection(dbcon.MyConnection());
                con.Open();
                string insertQuery = "INSERT INTO [Transaction] (TransactionId, Total, Cash, DiscountPercent, DiscountAmount, [Change], Date) VALUES (@TransactionId, @Total, @Cash, @DiscountPercent, @DiscountAmount, @Change, @Date)";

                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@TransactionId", transactionId);
                    command.Parameters.AddWithValue("@Total", total);
                    command.Parameters.AddWithValue("@Cash", cash);
                    command.Parameters.AddWithValue("@DiscountPercent", discountPercent);
                    command.Parameters.AddWithValue("@DiscountAmount", discountAmount);
                    command.Parameters.AddWithValue("@Change", change);
                    command.Parameters.AddWithValue("@Date", currentDate);
                    command.ExecuteNonQuery();
                }

                // Delete the data from the Cart table after successful transaction
                string deleteQuery = "DELETE FROM [Cart]";
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, con))
                {
                    deleteCommand.ExecuteNonQuery();
                }
                con.Close();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the transaction: " + ex.Message);
            }
        }

        //MOVE CART ITEM TO ANOTHER DATABASE
        private void InsertTransactionItems()
        {
            con = new SqlConnection(dbcon.MyConnection());
            con.Open();
            // Get the next product ID
            string nextTransactionId = this.transactionId;

            // Insert the data from the listBox1 into the TransactionItem table
            string insertQuery = "INSERT INTO Orders (TransactionId, Name, Price, Quantity) VALUES (@TransactionId, @Name, @Price, @Quantity)";
            using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
            {
                foreach (var item in List.Items)
                {
                    string[] parts = item.ToString().Split(new string[] { " x ", " - $" }, StringSplitOptions.None);
                    string name = parts[1];
                    decimal price = decimal.Parse(parts[2]);
                    int quantity = int.Parse(parts[0]);

                    insertCommand.Parameters.Clear();
                    insertCommand.Parameters.AddWithValue("@TransactionId", nextTransactionId);
                    insertCommand.Parameters.AddWithValue("@Name", name);
                    insertCommand.Parameters.AddWithValue("@Price", price);
                    insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                    insertCommand.ExecuteNonQuery();
                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transactionId = GenerateTransactionId();
            InsertTransactionItems();
            ProcessTransaction();
        }
    }
}
