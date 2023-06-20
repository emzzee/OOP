
namespace OOP_Activity
{
    partial class AddStocks
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
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textstocks = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.btnaddstocks = new System.Windows.Forms.Button();
            this.textid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Stocks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Name";
            // 
            // textstocks
            // 
            this.textstocks.Location = new System.Drawing.Point(81, 133);
            this.textstocks.Name = "textstocks";
            this.textstocks.Size = new System.Drawing.Size(172, 20);
            this.textstocks.TabIndex = 25;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(76, 83);
            this.textname.Name = "textname";
            this.textname.ReadOnly = true;
            this.textname.Size = new System.Drawing.Size(177, 20);
            this.textname.TabIndex = 24;
            // 
            // btnaddstocks
            // 
            this.btnaddstocks.Location = new System.Drawing.Point(153, 182);
            this.btnaddstocks.Name = "btnaddstocks";
            this.btnaddstocks.Size = new System.Drawing.Size(100, 29);
            this.btnaddstocks.TabIndex = 23;
            this.btnaddstocks.Text = "ADD STOCKS";
            this.btnaddstocks.UseVisualStyleBackColor = true;
            this.btnaddstocks.Click += new System.EventHandler(this.btnaddstocks_Click);
            // 
            // textid
            // 
            this.textid.BackColor = System.Drawing.SystemColors.Control;
            this.textid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textid.ForeColor = System.Drawing.Color.Plum;
            this.textid.Location = new System.Drawing.Point(38, 48);
            this.textid.Name = "textid";
            this.textid.ReadOnly = true;
            this.textid.Size = new System.Drawing.Size(74, 13);
            this.textid.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID";
            // 
            // AddStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(273, 250);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textstocks);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.btnaddstocks);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label1);
            this.Name = "AddStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStocks";
            this.Load += new System.EventHandler(this.AddStocks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textstocks;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Button btnaddstocks;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label1;
    }
}