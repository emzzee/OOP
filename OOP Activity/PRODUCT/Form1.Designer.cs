
namespace OOP_Activity
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnaddstocks = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnhistory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbid = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(12, 156);
            this.btndelete.Name = "btndelete";
            this.btndelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btndelete.Size = new System.Drawing.Size(137, 43);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "DELETE";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(12, 108);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnupdate.Size = new System.Drawing.Size(137, 32);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnaddstocks
            // 
            this.btnaddstocks.BackColor = System.Drawing.Color.Transparent;
            this.btnaddstocks.FlatAppearance.BorderSize = 0;
            this.btnaddstocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.btnaddstocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddstocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnaddstocks.Image = ((System.Drawing.Image)(resources.GetObject("btnaddstocks.Image")));
            this.btnaddstocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddstocks.Location = new System.Drawing.Point(9, 205);
            this.btnaddstocks.Name = "btnaddstocks";
            this.btnaddstocks.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnaddstocks.Size = new System.Drawing.Size(140, 43);
            this.btnaddstocks.TabIndex = 6;
            this.btnaddstocks.Text = "ADD STOCKS";
            this.btnaddstocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddstocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddstocks.UseVisualStyleBackColor = false;
            this.btnaddstocks.Click += new System.EventHandler(this.btnaddstocks_Click);
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.Color.Transparent;
            this.btncreate.FlatAppearance.BorderSize = 0;
            this.btncreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncreate.Image = ((System.Drawing.Image)(resources.GetObject("btncreate.Image")));
            this.btncreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreate.Location = new System.Drawing.Point(15, 59);
            this.btncreate.Name = "btncreate";
            this.btncreate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btncreate.Size = new System.Drawing.Size(134, 43);
            this.btncreate.TabIndex = 1;
            this.btncreate.Text = "CREATE";
            this.btncreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.BackColor = System.Drawing.Color.Transparent;
            this.btnhistory.FlatAppearance.BorderSize = 0;
            this.btnhistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.btnhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnhistory.Image = ((System.Drawing.Image)(resources.GetObject("btnhistory.Image")));
            this.btnhistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhistory.Location = new System.Drawing.Point(12, 254);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnhistory.Size = new System.Drawing.Size(137, 43);
            this.btnhistory.TabIndex = 7;
            this.btnhistory.Text = "HISTORY";
            this.btnhistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhistory.UseVisualStyleBackColor = false;
            this.btnhistory.Click += new System.EventHandler(this.btnhistory_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.tbid);
            this.panel2.Controls.Add(this.btnhistory);
            this.panel2.Controls.Add(this.btncreate);
            this.panel2.Controls.Add(this.btnaddstocks);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 407);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(15, 24);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(122, 20);
            this.tbid.TabIndex = 9;
            this.tbid.TextChanged += new System.EventHandler(this.tbid_TextChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid.Location = new System.Drawing.Point(161, 0);
            this.datagrid.Name = "datagrid";
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(506, 407);
            this.datagrid.TabIndex = 10;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 407);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.product_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnaddstocks;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.TextBox tbid;
    }
}

