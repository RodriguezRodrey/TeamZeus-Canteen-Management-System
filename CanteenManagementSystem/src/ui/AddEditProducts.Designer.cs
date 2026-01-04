namespace CanteenManagementSystem.src.ui
{
    partial class addedit
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
            this.addedit_productdetails = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addedituser_name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addedituser_updatebtn = new System.Windows.Forms.Button();
            this.addedituser_addbtn = new System.Windows.Forms.Button();
            this.addedituser_clearbtn = new System.Windows.Forms.Button();
            this.addedituser_removebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.addedit_productdetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 100);
            this.panel1.TabIndex = 0;
            // 
            // addedit_productdetails
            // 
            this.addedit_productdetails.AutoSize = true;
            this.addedit_productdetails.Font = new System.Drawing.Font("Nirmala Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedit_productdetails.ForeColor = System.Drawing.Color.White;
            this.addedit_productdetails.Location = new System.Drawing.Point(36, 33);
            this.addedit_productdetails.Name = "addedit_productdetails";
            this.addedit_productdetails.Size = new System.Drawing.Size(185, 32);
            this.addedit_productdetails.TabIndex = 0;
            this.addedit_productdetails.Text = "Products Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 339);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(957, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Products";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.addedituser_clearbtn);
            this.panel3.Controls.Add(this.addedituser_removebtn);
            this.panel3.Controls.Add(this.addedituser_updatebtn);
            this.panel3.Controls.Add(this.addedituser_addbtn);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.addedituser_name);
            this.panel3.Location = new System.Drawing.Point(12, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 254);
            this.panel3.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(182, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 25);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addedituser_name
            // 
            this.addedituser_name.AutoSize = true;
            this.addedituser_name.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedituser_name.Location = new System.Drawing.Point(98, 31);
            this.addedituser_name.Name = "addedituser_name";
            this.addedituser_name.Size = new System.Drawing.Size(78, 17);
            this.addedituser_name.TabIndex = 5;
            this.addedituser_name.Text = "Product ID:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(204, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 25);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(604, 83);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 25);
            this.textBox3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stock:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(600, 32);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 25);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(627, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status";
            // 
            // addedituser_updatebtn
            // 
            this.addedituser_updatebtn.BackColor = System.Drawing.Color.Firebrick;
            this.addedituser_updatebtn.FlatAppearance.BorderSize = 0;
            this.addedituser_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addedituser_updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedituser_updatebtn.ForeColor = System.Drawing.Color.White;
            this.addedituser_updatebtn.Location = new System.Drawing.Point(338, 188);
            this.addedituser_updatebtn.Name = "addedituser_updatebtn";
            this.addedituser_updatebtn.Size = new System.Drawing.Size(99, 45);
            this.addedituser_updatebtn.TabIndex = 18;
            this.addedituser_updatebtn.Text = "Update";
            this.addedituser_updatebtn.UseVisualStyleBackColor = false;
            // 
            // addedituser_addbtn
            // 
            this.addedituser_addbtn.BackColor = System.Drawing.Color.Firebrick;
            this.addedituser_addbtn.FlatAppearance.BorderSize = 0;
            this.addedituser_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addedituser_addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedituser_addbtn.ForeColor = System.Drawing.Color.White;
            this.addedituser_addbtn.Location = new System.Drawing.Point(205, 188);
            this.addedituser_addbtn.Name = "addedituser_addbtn";
            this.addedituser_addbtn.Size = new System.Drawing.Size(99, 45);
            this.addedituser_addbtn.TabIndex = 17;
            this.addedituser_addbtn.Text = "Add";
            this.addedituser_addbtn.UseVisualStyleBackColor = false;
            // 
            // addedituser_clearbtn
            // 
            this.addedituser_clearbtn.BackColor = System.Drawing.Color.Firebrick;
            this.addedituser_clearbtn.FlatAppearance.BorderSize = 0;
            this.addedituser_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addedituser_clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedituser_clearbtn.ForeColor = System.Drawing.Color.White;
            this.addedituser_clearbtn.Location = new System.Drawing.Point(627, 188);
            this.addedituser_clearbtn.Name = "addedituser_clearbtn";
            this.addedituser_clearbtn.Size = new System.Drawing.Size(99, 45);
            this.addedituser_clearbtn.TabIndex = 20;
            this.addedituser_clearbtn.Text = "Clear";
            this.addedituser_clearbtn.UseVisualStyleBackColor = false;
            // 
            // addedituser_removebtn
            // 
            this.addedituser_removebtn.BackColor = System.Drawing.Color.Firebrick;
            this.addedituser_removebtn.FlatAppearance.BorderSize = 0;
            this.addedituser_removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addedituser_removebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedituser_removebtn.ForeColor = System.Drawing.Color.White;
            this.addedituser_removebtn.Location = new System.Drawing.Point(494, 188);
            this.addedituser_removebtn.Name = "addedituser_removebtn";
            this.addedituser_removebtn.Size = new System.Drawing.Size(99, 45);
            this.addedituser_removebtn.TabIndex = 19;
            this.addedituser_removebtn.Text = "Remove";
            this.addedituser_removebtn.UseVisualStyleBackColor = false;
            // 
            // addedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1014, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Products";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addedit_productdetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label addedituser_name;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addedituser_updatebtn;
        private System.Windows.Forms.Button addedituser_addbtn;
        private System.Windows.Forms.Button addedituser_clearbtn;
        private System.Windows.Forms.Button addedituser_removebtn;
    }
}