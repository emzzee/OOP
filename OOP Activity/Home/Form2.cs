using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Activity
{
    public partial class Form2 : Form
    {
        private Form currentForm;
        public Form2()
        {
            InitializeComponent();
        }
        private void SwitchForm(Form newForm)
        {
            currentForm?.Hide();
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            // Check if panel2 already contains a form
            if (panel6.Controls.Count > 0)
            {
                Control currentFormControl = panel6.Controls[0];
                currentFormControl.Hide();
                panel6.Controls.Remove(currentFormControl);
            }
            panel6.Controls.Add(newForm);
            newForm.Show();

            currentForm = newForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            btnadmin.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnproduct.BackColor = Color.FromArgb(0, 0, 0, 0);
            btncategory.BackColor = Color.FromArgb(189, 197, 129);
            btntransaction.BackColor = Color.FromArgb(0, 0, 0, 0);
            btncart.BackColor = Color.FromArgb(0, 0, 0, 0);

            SwitchForm(new CategoryForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            btnadmin.BackColor = Color.FromArgb(189, 197, 129);
            btnproduct.BackColor = Color.FromArgb(0, 0, 0, 0);
            btncategory.BackColor = Color.FromArgb(0, 0, 0, 0);
            btntransaction.BackColor = Color.FromArgb(0, 0, 0, 0);
            btncart.BackColor = Color.FromArgb(0, 0, 0, 0);

            SwitchForm(new Form1());
        }

        private void btntransaction_Click(object sender, EventArgs e)
        {
            btnadmin.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnproduct.BackColor = Color.FromArgb(0, 0, 0, 0);
            btncategory.BackColor = Color.FromArgb(0, 0, 0, 0);
            btntransaction.BackColor = Color.FromArgb(189, 197, 129);
            btncart.BackColor = Color.FromArgb(0, 0, 0, 0);

            SwitchForm(new Transaction());
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            btnadmin.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnproduct.BackColor = Color.FromArgb(189, 197, 129);
            btncategory.BackColor = Color.FromArgb(0, 0, 0, 0);
            btntransaction.BackColor = Color.FromArgb(0, 0, 0, 0);
            btncart.BackColor = Color.FromArgb(0, 0, 0, 0);

            SwitchForm(new Product());
        }

        private void btncart_Click(object sender, EventArgs e)
        {
            btnadmin.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnproduct.BackColor = Color.FromArgb(0, 0, 0, 0);
            btncategory.BackColor = Color.FromArgb(0, 0, 0, 0);
            btntransaction.BackColor = Color.FromArgb(0, 0, 0, 0);
            btncart.BackColor = Color.FromArgb(189, 197, 129);

            SwitchForm(new Cart());
        }
    }
}
