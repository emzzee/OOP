
namespace OOP_Activity
{
    partial class UPDATE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnupdate = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.textunits = new System.Windows.Forms.TextBox();
            this.textstocks = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(213, 305);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 29);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(177, 68);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(177, 20);
            this.textname.TabIndex = 10;
            this.textname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textunits
            // 
            this.textunits.Location = new System.Drawing.Point(177, 216);
            this.textunits.Name = "textunits";
            this.textunits.Size = new System.Drawing.Size(177, 20);
            this.textunits.TabIndex = 12;
            // 
            // textstocks
            // 
            this.textstocks.Location = new System.Drawing.Point(177, 174);
            this.textstocks.Name = "textstocks";
            this.textstocks.Size = new System.Drawing.Size(177, 20);
            this.textstocks.TabIndex = 13;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(177, 118);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(177, 20);
            this.textprice.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Units";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Stocks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Price";
            // 
            // combobox
            // 
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "Beauty Products",
            "Clothes",
            "Jewelry",
            "Food",
            "Beverage"});
            this.combobox.Location = new System.Drawing.Point(177, 263);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(177, 21);
            this.combobox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Category";
            // 
            // textid
            // 
            this.textid.BackColor = System.Drawing.SystemColors.Control;
            this.textid.ForeColor = System.Drawing.Color.Plum;
            this.textid.Location = new System.Drawing.Point(10, 10);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(74, 20);
            this.textid.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.textid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 366);
            this.panel1.TabIndex = 23;
            // 
            // UPDATE
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(211)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(366, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textstocks);
            this.Controls.Add(this.textunits);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.btnupdate);
            this.Name = "UPDATE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UPDATE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textunits;
        private System.Windows.Forms.TextBox textstocks;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}