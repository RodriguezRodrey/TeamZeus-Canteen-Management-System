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
            this.report_reports = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportbtn_productlist = new System.Windows.Forms.Button();
            this.reportbtn_stockbalance = new System.Windows.Forms.Button();
            this.reportbtn_salesreport = new System.Windows.Forms.Button();
            this.reportbtn_purchasereport = new System.Windows.Forms.Button();
            this.reportbtn_supplierlist = new System.Windows.Forms.Button();
            this.report_startdate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.report_enddate = new System.Windows.Forms.Label();
            this.reportbtn_report = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.report_reports);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 68);
            this.panel1.TabIndex = 0;
            // 
            // report_reports
            // 
            this.report_reports.AutoSize = true;
            this.report_reports.Font = new System.Drawing.Font("Nirmala Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_reports.ForeColor = System.Drawing.Color.White;
            this.report_reports.Location = new System.Drawing.Point(26, 18);
            this.report_reports.Name = "report_reports";
            this.report_reports.Size = new System.Drawing.Size(95, 32);
            this.report_reports.TabIndex = 3;
            this.report_reports.Text = "Reports";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.reportbtn_report);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.report_enddate);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.report_startdate);
            this.panel2.Controls.Add(this.reportbtn_supplierlist);
            this.panel2.Controls.Add(this.reportbtn_purchasereport);
            this.panel2.Controls.Add(this.reportbtn_salesreport);
            this.panel2.Controls.Add(this.reportbtn_stockbalance);
            this.panel2.Controls.Add(this.reportbtn_productlist);
            this.panel2.Location = new System.Drawing.Point(12, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 533);
            this.panel2.TabIndex = 1;
            // 
            // reportbtn_productlist
            // 
            this.reportbtn_productlist.BackColor = System.Drawing.Color.Firebrick;
            this.reportbtn_productlist.FlatAppearance.BorderSize = 0;
            this.reportbtn_productlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbtn_productlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn_productlist.ForeColor = System.Drawing.Color.White;
            this.reportbtn_productlist.Location = new System.Drawing.Point(0, 0);
            this.reportbtn_productlist.Name = "reportbtn_productlist";
            this.reportbtn_productlist.Size = new System.Drawing.Size(257, 45);
            this.reportbtn_productlist.TabIndex = 10;
            this.reportbtn_productlist.Text = "Product List";
            this.reportbtn_productlist.UseVisualStyleBackColor = false;
            // 
            // reportbtn_stockbalance
            // 
            this.reportbtn_stockbalance.BackColor = System.Drawing.Color.Firebrick;
            this.reportbtn_stockbalance.FlatAppearance.BorderSize = 0;
            this.reportbtn_stockbalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbtn_stockbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn_stockbalance.ForeColor = System.Drawing.Color.White;
            this.reportbtn_stockbalance.Location = new System.Drawing.Point(263, 0);
            this.reportbtn_stockbalance.Name = "reportbtn_stockbalance";
            this.reportbtn_stockbalance.Size = new System.Drawing.Size(257, 45);
            this.reportbtn_stockbalance.TabIndex = 11;
            this.reportbtn_stockbalance.Text = "Stock Balance";
            this.reportbtn_stockbalance.UseVisualStyleBackColor = false;
            // 
            // reportbtn_salesreport
            // 
            this.reportbtn_salesreport.BackColor = System.Drawing.Color.Firebrick;
            this.reportbtn_salesreport.FlatAppearance.BorderSize = 0;
            this.reportbtn_salesreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbtn_salesreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn_salesreport.ForeColor = System.Drawing.Color.White;
            this.reportbtn_salesreport.Location = new System.Drawing.Point(526, 0);
            this.reportbtn_salesreport.Name = "reportbtn_salesreport";
            this.reportbtn_salesreport.Size = new System.Drawing.Size(257, 45);
            this.reportbtn_salesreport.TabIndex = 12;
            this.reportbtn_salesreport.Text = "Sales Report";
            this.reportbtn_salesreport.UseVisualStyleBackColor = false;
            // 
            // reportbtn_purchasereport
            // 
            this.reportbtn_purchasereport.BackColor = System.Drawing.Color.Firebrick;
            this.reportbtn_purchasereport.FlatAppearance.BorderSize = 0;
            this.reportbtn_purchasereport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbtn_purchasereport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn_purchasereport.ForeColor = System.Drawing.Color.White;
            this.reportbtn_purchasereport.Location = new System.Drawing.Point(789, 0);
            this.reportbtn_purchasereport.Name = "reportbtn_purchasereport";
            this.reportbtn_purchasereport.Size = new System.Drawing.Size(257, 45);
            this.reportbtn_purchasereport.TabIndex = 13;
            this.reportbtn_purchasereport.Text = "Purchase Report";
            this.reportbtn_purchasereport.UseVisualStyleBackColor = false;
            // 
            // reportbtn_supplierlist
            // 
            this.reportbtn_supplierlist.BackColor = System.Drawing.Color.Firebrick;
            this.reportbtn_supplierlist.FlatAppearance.BorderSize = 0;
            this.reportbtn_supplierlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbtn_supplierlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn_supplierlist.ForeColor = System.Drawing.Color.White;
            this.reportbtn_supplierlist.Location = new System.Drawing.Point(1052, 0);
            this.reportbtn_supplierlist.Name = "reportbtn_supplierlist";
            this.reportbtn_supplierlist.Size = new System.Drawing.Size(257, 45);
            this.reportbtn_supplierlist.TabIndex = 14;
            this.reportbtn_supplierlist.Text = "Supplier List";
            this.reportbtn_supplierlist.UseVisualStyleBackColor = false;
            // 
            // report_startdate
            // 
            this.report_startdate.AutoSize = true;
            this.report_startdate.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_startdate.Location = new System.Drawing.Point(67, 137);
            this.report_startdate.Name = "report_startdate";
            this.report_startdate.Size = new System.Drawing.Size(80, 20);
            this.report_startdate.TabIndex = 15;
            this.report_startdate.Text = "Start Date";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(71, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 28);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(71, 240);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 28);
            this.textBox2.TabIndex = 18;
            // 
            // report_enddate
            // 
            this.report_enddate.AutoSize = true;
            this.report_enddate.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_enddate.Location = new System.Drawing.Point(67, 217);
            this.report_enddate.Name = "report_enddate";
            this.report_enddate.Size = new System.Drawing.Size(72, 20);
            this.report_enddate.TabIndex = 17;
            this.report_enddate.Text = "End Date";
            // 
            // reportbtn_report
            // 
            this.reportbtn_report.BackColor = System.Drawing.Color.Firebrick;
            this.reportbtn_report.FlatAppearance.BorderSize = 0;
            this.reportbtn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbtn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn_report.ForeColor = System.Drawing.Color.White;
            this.reportbtn_report.Location = new System.Drawing.Point(71, 298);
            this.reportbtn_report.Name = "reportbtn_report";
            this.reportbtn_report.Size = new System.Drawing.Size(116, 45);
            this.reportbtn_report.TabIndex = 19;
            this.reportbtn_report.Text = "Report";
            this.reportbtn_report.UseVisualStyleBackColor = false;
            // 
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewReports";
            this.Text = "ViewReports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label report_reports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label report_startdate;
        private System.Windows.Forms.Button reportbtn_supplierlist;
        private System.Windows.Forms.Button reportbtn_purchasereport;
        private System.Windows.Forms.Button reportbtn_salesreport;
        private System.Windows.Forms.Button reportbtn_stockbalance;
        private System.Windows.Forms.Button reportbtn_productlist;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label report_enddate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reportbtn_report;
    }
}