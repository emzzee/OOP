
namespace OOP_Activity
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btncart = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncategory = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btntransaction = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.btntransaction);
            this.panel1.Controls.Add(this.btncart);
            this.panel1.Controls.Add(this.btnproduct);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btncategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 445);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnadmin);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 116);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(186, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 38);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(186, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(667, 407);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(667, 407);
            this.panel6.TabIndex = 0;
            // 
            // btncart
            // 
            this.btncart.BackColor = System.Drawing.Color.Transparent;
            this.btncart.FlatAppearance.BorderSize = 0;
            this.btncart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.btncart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncart.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncart.Image = global::OOP_Activity.Properties.Resources.green_shopping_cart_10909;
            this.btncart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncart.Location = new System.Drawing.Point(0, 294);
            this.btncart.Name = "btncart";
            this.btncart.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btncart.Size = new System.Drawing.Size(186, 43);
            this.btncart.TabIndex = 4;
            this.btncart.Text = "Cart";
            this.btncart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncart.UseVisualStyleBackColor = false;
            this.btncart.Click += new System.EventHandler(this.btncart_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.Transparent;
            this.btnproduct.FlatAppearance.BorderSize = 0;
            this.btnproduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnproduct.Image = global::OOP_Activity.Properties.Resources.delivery_box_11395__1_;
            this.btnproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.Location = new System.Drawing.Point(0, 147);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnproduct.Size = new System.Drawing.Size(186, 43);
            this.btnproduct.TabIndex = 3;
            this.btnproduct.Text = "Products";
            this.btnproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btncategory
            // 
            this.btncategory.BackColor = System.Drawing.Color.Transparent;
            this.btncategory.FlatAppearance.BorderSize = 0;
            this.btncategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.btncategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncategory.Image = ((System.Drawing.Image)(resources.GetObject("btncategory.Image")));
            this.btncategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategory.Location = new System.Drawing.Point(0, 196);
            this.btncategory.Name = "btncategory";
            this.btncategory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btncategory.Size = new System.Drawing.Size(186, 43);
            this.btncategory.TabIndex = 1;
            this.btncategory.Text = "Category";
            this.btncategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncategory.UseVisualStyleBackColor = false;
            this.btncategory.Click += new System.EventHandler(this.btncategory_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.Transparent;
            this.btnadmin.FlatAppearance.BorderSize = 0;
            this.btnadmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.Location = new System.Drawing.Point(85, 40);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnadmin.Size = new System.Drawing.Size(98, 43);
            this.btnadmin.TabIndex = 4;
            this.btnadmin.Text = "ADMIN";
            this.btnadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btntransaction
            // 
            this.btntransaction.BackColor = System.Drawing.Color.Transparent;
            this.btntransaction.FlatAppearance.BorderSize = 0;
            this.btntransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.btntransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btntransaction.Image = ((System.Drawing.Image)(resources.GetObject("btntransaction.Image")));
            this.btntransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntransaction.Location = new System.Drawing.Point(0, 245);
            this.btntransaction.Name = "btntransaction";
            this.btntransaction.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btntransaction.Size = new System.Drawing.Size(186, 43);
            this.btntransaction.TabIndex = 5;
            this.btntransaction.Text = "Transactions";
            this.btntransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntransaction.UseVisualStyleBackColor = false;
            this.btntransaction.Click += new System.EventHandler(this.btntransaction_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 445);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOP";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btncart;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btntransaction;
    }
}