namespace CanteenManagementSystem.src.ui
{
    partial class pos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblposinterface = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pos_availableproducts = new System.Windows.Forms.Label();
            this.pos_category = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pos_price = new System.Windows.Forms.Label();
            this.pos_productname = new System.Windows.Forms.Label();
            this.pos_quantity = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.addbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.pos_totalprice = new System.Windows.Forms.Label();
            this.pos_amount = new System.Windows.Forms.Label();
            this.pos_change = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paybtn = new System.Windows.Forms.Button();
            this.recipbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblposinterface);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 41);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblposinterface
            // 
            this.lblposinterface.AutoSize = true;
            this.lblposinterface.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposinterface.ForeColor = System.Drawing.Color.White;
            this.lblposinterface.Location = new System.Drawing.Point(3, 8);
            this.lblposinterface.Name = "lblposinterface";
            this.lblposinterface.Size = new System.Drawing.Size(60, 39);
            this.lblposinterface.TabIndex = 0;
            this.lblposinterface.Text = "POS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pos_availableproducts);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 300);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.recipbtn);
            this.panel3.Controls.Add(this.paybtn);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pos_change);
            this.panel3.Controls.Add(this.pos_totalprice);
            this.panel3.Controls.Add(this.pos_amount);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(593, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 627);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.clearbtn);
            this.panel4.Controls.Add(this.removebtn);
            this.panel4.Controls.Add(this.addbtn);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.pos_quantity);
            this.panel4.Controls.Add(this.pos_productname);
            this.panel4.Controls.Add(this.pos_price);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.pos_category);
            this.panel4.Location = new System.Drawing.Point(12, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(575, 321);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(356, 278);
            this.dataGridView2.TabIndex = 0;
            // 
            // pos_availableproducts
            // 
            this.pos_availableproducts.AutoSize = true;
            this.pos_availableproducts.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_availableproducts.Location = new System.Drawing.Point(17, 10);
            this.pos_availableproducts.Name = "pos_availableproducts";
            this.pos_availableproducts.Size = new System.Drawing.Size(196, 30);
            this.pos_availableproducts.TabIndex = 1;
            this.pos_availableproducts.Text = "Available Products";
            // 
            // pos_category
            // 
            this.pos_category.AutoSize = true;
            this.pos_category.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_category.Location = new System.Drawing.Point(22, 73);
            this.pos_category.Name = "pos_category";
            this.pos_category.Size = new System.Drawing.Size(84, 21);
            this.pos_category.TabIndex = 0;
            this.pos_category.Text = "Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // pos_price
            // 
            this.pos_price.AutoSize = true;
            this.pos_price.Font = new System.Drawing.Font("Nirmala Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_price.Location = new System.Drawing.Point(22, 155);
            this.pos_price.Name = "pos_price";
            this.pos_price.Size = new System.Drawing.Size(47, 20);
            this.pos_price.TabIndex = 2;
            this.pos_price.Text = "Price:";
            this.pos_price.Click += new System.EventHandler(this.label3_Click);
            // 
            // pos_productname
            // 
            this.pos_productname.AutoSize = true;
            this.pos_productname.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_productname.Location = new System.Drawing.Point(22, 122);
            this.pos_productname.Name = "pos_productname";
            this.pos_productname.Size = new System.Drawing.Size(114, 20);
            this.pos_productname.TabIndex = 3;
            this.pos_productname.Text = "Product Name:";
            this.pos_productname.Click += new System.EventHandler(this.label4_Click);
            // 
            // pos_quantity
            // 
            this.pos_quantity.AutoSize = true;
            this.pos_quantity.Font = new System.Drawing.Font("Nirmala Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_quantity.Location = new System.Drawing.Point(284, 122);
            this.pos_quantity.Name = "pos_quantity";
            this.pos_quantity.Size = new System.Drawing.Size(74, 20);
            this.pos_quantity.TabIndex = 4;
            this.pos_quantity.Text = "Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(372, 122);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Firebrick;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(26, 227);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(133, 45);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.Firebrick;
            this.removebtn.FlatAppearance.BorderSize = 0;
            this.removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.ForeColor = System.Drawing.Color.White;
            this.removebtn.Location = new System.Drawing.Point(165, 227);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(133, 45);
            this.removebtn.TabIndex = 7;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = false;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.Firebrick;
            this.clearbtn.FlatAppearance.BorderSize = 0;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Location = new System.Drawing.Point(426, 227);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(133, 45);
            this.clearbtn.TabIndex = 8;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            // 
            // pos_totalprice
            // 
            this.pos_totalprice.AutoSize = true;
            this.pos_totalprice.Font = new System.Drawing.Font("Nirmala Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_totalprice.Location = new System.Drawing.Point(24, 322);
            this.pos_totalprice.Name = "pos_totalprice";
            this.pos_totalprice.Size = new System.Drawing.Size(85, 20);
            this.pos_totalprice.TabIndex = 5;
            this.pos_totalprice.Text = "Total Price:";
            // 
            // pos_amount
            // 
            this.pos_amount.AutoSize = true;
            this.pos_amount.Font = new System.Drawing.Font("Nirmala Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_amount.Location = new System.Drawing.Point(24, 355);
            this.pos_amount.Name = "pos_amount";
            this.pos_amount.Size = new System.Drawing.Size(71, 20);
            this.pos_amount.TabIndex = 4;
            this.pos_amount.Text = "Amount:";
            // 
            // pos_change
            // 
            this.pos_change.AutoSize = true;
            this.pos_change.Font = new System.Drawing.Font("Nirmala Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_change.Location = new System.Drawing.Point(24, 393);
            this.pos_change.Name = "pos_change";
            this.pos_change.Size = new System.Drawing.Size(65, 20);
            this.pos_change.TabIndex = 6;
            this.pos_change.Text = "Change:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "0.00";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(99, 355);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 8;
            // 
            // paybtn
            // 
            this.paybtn.BackColor = System.Drawing.Color.Firebrick;
            this.paybtn.FlatAppearance.BorderSize = 0;
            this.paybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paybtn.ForeColor = System.Drawing.Color.White;
            this.paybtn.Location = new System.Drawing.Point(65, 493);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(257, 45);
            this.paybtn.TabIndex = 9;
            this.paybtn.Text = "Pay Orders";
            this.paybtn.UseVisualStyleBackColor = false;
            // 
            // recipbtn
            // 
            this.recipbtn.BackColor = System.Drawing.Color.Firebrick;
            this.recipbtn.FlatAppearance.BorderSize = 0;
            this.recipbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recipbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipbtn.ForeColor = System.Drawing.Color.White;
            this.recipbtn.Location = new System.Drawing.Point(65, 558);
            this.recipbtn.Name = "recipbtn";
            this.recipbtn.Size = new System.Drawing.Size(257, 45);
            this.recipbtn.TabIndex = 10;
            this.recipbtn.Text = "Reciept";
            this.recipbtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select your orders";
            // 
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(992, 704);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pos";
            this.Text = "POS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblposinterface;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pos_availableproducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label pos_productname;
        private System.Windows.Forms.Label pos_price;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label pos_category;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label pos_quantity;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label pos_change;
        private System.Windows.Forms.Label pos_totalprice;
        private System.Windows.Forms.Label pos_amount;
        private System.Windows.Forms.Button recipbtn;
        private System.Windows.Forms.Button paybtn;
        private System.Windows.Forms.Label label1;
    }
}