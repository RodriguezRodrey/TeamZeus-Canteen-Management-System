namespace CanteenManagementSystem.src.ui
{
    partial class ViewReports
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
            this.receiptpreview_ = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.receiptpreview_reporttype = new System.Windows.Forms.Label();
            this.receiptpreview_fromdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.receiptpreview_filterby = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.receiptpreview_exportpdfbtn = new System.Windows.Forms.Button();
            this.receiptpreview_generatereportsbtn = new System.Windows.Forms.Button();
            this.receiptpreview_printbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usermanagement_userlist = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.receiptpreview_);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 68);
            this.panel1.TabIndex = 0;
            // 
            // receiptpreview_
            // 
            this.receiptpreview_.AutoSize = true;
            this.receiptpreview_.Font = new System.Drawing.Font("Nirmala Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptpreview_.ForeColor = System.Drawing.Color.White;
            this.receiptpreview_.Location = new System.Drawing.Point(26, 18);
            this.receiptpreview_.Name = "receiptpreview_";
            this.receiptpreview_.Size = new System.Drawing.Size(95, 32);
            this.receiptpreview_.TabIndex = 3;
            this.receiptpreview_.Text = "Reports";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.usermanagement_userlist);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.receiptpreview_printbtn);
            this.panel2.Controls.Add(this.receiptpreview_exportpdfbtn);
            this.panel2.Controls.Add(this.receiptpreview_generatereportsbtn);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.receiptpreview_filterby);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.receiptpreview_fromdate);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.receiptpreview_reporttype);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 645);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // receiptpreview_reporttype
            // 
            this.receiptpreview_reporttype.AutoSize = true;
            this.receiptpreview_reporttype.Font = new System.Drawing.Font("Nirmala Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptpreview_reporttype.Location = new System.Drawing.Point(50, 30);
            this.receiptpreview_reporttype.Name = "receiptpreview_reporttype";
            this.receiptpreview_reporttype.Size = new System.Drawing.Size(98, 20);
            this.receiptpreview_reporttype.TabIndex = 23;
            this.receiptpreview_reporttype.Text = "Report Type:";
            // 
            // receiptpreview_fromdate
            // 
            this.receiptpreview_fromdate.AutoSize = true;
            this.receiptpreview_fromdate.Font = new System.Drawing.Font("Nirmala Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptpreview_fromdate.Location = new System.Drawing.Point(50, 64);
            this.receiptpreview_fromdate.Name = "receiptpreview_fromdate";
            this.receiptpreview_fromdate.Size = new System.Drawing.Size(118, 20);
            this.receiptpreview_fromdate.TabIndex = 25;
            this.receiptpreview_fromdate.Text = "receiptpreview_";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // receiptpreview_filterby
            // 
            this.receiptpreview_filterby.AutoSize = true;
            this.receiptpreview_filterby.Font = new System.Drawing.Font("Nirmala Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptpreview_filterby.Location = new System.Drawing.Point(73, 99);
            this.receiptpreview_filterby.Name = "receiptpreview_filterby";
            this.receiptpreview_filterby.Size = new System.Drawing.Size(75, 20);
            this.receiptpreview_filterby.TabIndex = 27;
            this.receiptpreview_filterby.Text = "Filter By: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(154, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 28;
            // 
            // receiptpreview_exportpdfbtn
            // 
            this.receiptpreview_exportpdfbtn.BackColor = System.Drawing.Color.Firebrick;
            this.receiptpreview_exportpdfbtn.FlatAppearance.BorderSize = 0;
            this.receiptpreview_exportpdfbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptpreview_exportpdfbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptpreview_exportpdfbtn.ForeColor = System.Drawing.Color.White;
            this.receiptpreview_exportpdfbtn.Location = new System.Drawing.Point(172, 148);
            this.receiptpreview_exportpdfbtn.Name = "receiptpreview_exportpdfbtn";
            this.receiptpreview_exportpdfbtn.Size = new System.Drawing.Size(133, 45);
            this.receiptpreview_exportpdfbtn.TabIndex = 30;
            this.receiptpreview_exportpdfbtn.Text = "Export PDF";
            this.receiptpreview_exportpdfbtn.UseVisualStyleBackColor = false;
            // 
            // receiptpreview_generatereportsbtn
            // 
            this.receiptpreview_generatereportsbtn.BackColor = System.Drawing.Color.Firebrick;
            this.receiptpreview_generatereportsbtn.FlatAppearance.BorderSize = 0;
            this.receiptpreview_generatereportsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptpreview_generatereportsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptpreview_generatereportsbtn.ForeColor = System.Drawing.Color.White;
            this.receiptpreview_generatereportsbtn.Location = new System.Drawing.Point(32, 148);
            this.receiptpreview_generatereportsbtn.Name = "receiptpreview_generatereportsbtn";
            this.receiptpreview_generatereportsbtn.Size = new System.Drawing.Size(134, 45);
            this.receiptpreview_generatereportsbtn.TabIndex = 29;
            this.receiptpreview_generatereportsbtn.Text = "Generate Reports";
            this.receiptpreview_generatereportsbtn.UseVisualStyleBackColor = false;
            // 
            // receiptpreview_printbtn
            // 
            this.receiptpreview_printbtn.BackColor = System.Drawing.Color.Firebrick;
            this.receiptpreview_printbtn.FlatAppearance.BorderSize = 0;
            this.receiptpreview_printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptpreview_printbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptpreview_printbtn.ForeColor = System.Drawing.Color.White;
            this.receiptpreview_printbtn.Location = new System.Drawing.Point(465, 148);
            this.receiptpreview_printbtn.Name = "receiptpreview_printbtn";
            this.receiptpreview_printbtn.Size = new System.Drawing.Size(133, 45);
            this.receiptpreview_printbtn.TabIndex = 31;
            this.receiptpreview_printbtn.Text = "Print";
            this.receiptpreview_printbtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 394);
            this.dataGridView1.TabIndex = 32;
            // 
            // usermanagement_userlist
            // 
            this.usermanagement_userlist.AutoSize = true;
            this.usermanagement_userlist.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usermanagement_userlist.ForeColor = System.Drawing.Color.Black;
            this.usermanagement_userlist.Location = new System.Drawing.Point(17, 214);
            this.usermanagement_userlist.Name = "usermanagement_userlist";
            this.usermanagement_userlist.Size = new System.Drawing.Size(122, 21);
            this.usermanagement_userlist.TabIndex = 5;
            this.usermanagement_userlist.Text = "Report Display";
            // 
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewReports";
            this.Text = "ViewReports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label receiptpreview_;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label receiptpreview_filterby;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label receiptpreview_fromdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label receiptpreview_reporttype;
        private System.Windows.Forms.Button receiptpreview_printbtn;
        private System.Windows.Forms.Button receiptpreview_exportpdfbtn;
        private System.Windows.Forms.Button receiptpreview_generatereportsbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label usermanagement_userlist;
    }
}