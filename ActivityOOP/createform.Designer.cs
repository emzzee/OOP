namespace ActivityOOP
{
    partial class createform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbstocks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbunits = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(75, 64);
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(213, 28);
            this.tbname.TabIndex = 2;
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(75, 107);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(213, 20);
            this.tbprice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stocks";
            // 
            // tbstocks
            // 
            this.tbstocks.Location = new System.Drawing.Point(75, 144);
            this.tbstocks.Name = "tbstocks";
            this.tbstocks.Size = new System.Drawing.Size(213, 20);
            this.tbstocks.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Units";
            // 
            // tbunits
            // 
            this.tbunits.Location = new System.Drawing.Point(75, 183);
            this.tbunits.Name = "tbunits";
            this.tbunits.Size = new System.Drawing.Size(213, 20);
            this.tbunits.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Category";
            // 
            // cbcategory
            // 
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Items.AddRange(new object[] {
            "Clothes",
            "Food",
            "Beverages",
            "Furniture"});
            this.cbcategory.Location = new System.Drawing.Point(75, 214);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(122, 21);
            this.cbcategory.TabIndex = 11;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(193, 265);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 35);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(75, 265);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(95, 35);
            this.create.TabIndex = 15;
            this.create.Text = "CREATE";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // createform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 312);
            this.Controls.Add(this.create);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.cbcategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbunits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbstocks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "createform";
            this.Text = "CREATE";
            this.Load += new System.EventHandler(this.createform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbstocks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbunits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
    }
}