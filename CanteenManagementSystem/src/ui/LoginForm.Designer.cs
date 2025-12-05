namespace CanteenManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.x = new System.Windows.Forms.Label();
            this.loginbttn = new System.Windows.Forms.Button();
            this.frgtpass = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.passwrd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userid = new System.Windows.Forms.Label();
            this.logtxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.x);
            this.panel1.Controls.Add(this.loginbttn);
            this.panel1.Controls.Add(this.frgtpass);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.passwrd);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.userid);
            this.panel1.Controls.Add(this.logtxt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.BackColor = System.Drawing.SystemColors.HighlightText;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(608, 9);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(16, 15);
            this.x.TabIndex = 8;
            this.x.Text = "X";
            // 
            // loginbttn
            // 
            this.loginbttn.BackColor = System.Drawing.Color.Transparent;
            this.loginbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbttn.Location = new System.Drawing.Point(424, 316);
            this.loginbttn.Name = "loginbttn";
            this.loginbttn.Size = new System.Drawing.Size(141, 32);
            this.loginbttn.TabIndex = 7;
            this.loginbttn.Text = "Log In";
            this.loginbttn.UseVisualStyleBackColor = false;
            this.loginbttn.Click += new System.EventHandler(this.loginbttn_Click);
            // 
            // frgtpass
            // 
            this.frgtpass.AutoSize = true;
            this.frgtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frgtpass.Location = new System.Drawing.Point(446, 266);
            this.frgtpass.Name = "frgtpass";
            this.frgtpass.Size = new System.Drawing.Size(97, 12);
            this.frgtpass.TabIndex = 6;
            this.frgtpass.Text = "Forgot Password?";
            this.frgtpass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(397, 228);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 35);
            this.textBox2.TabIndex = 5;
            // 
            // passwrd
            // 
            this.passwrd.AutoSize = true;
            this.passwrd.BackColor = System.Drawing.Color.Firebrick;
            this.passwrd.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrd.Location = new System.Drawing.Point(394, 209);
            this.passwrd.Name = "passwrd";
            this.passwrd.Size = new System.Drawing.Size(53, 15);
            this.passwrd.TabIndex = 4;
            this.passwrd.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 148);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 33);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userid.Location = new System.Drawing.Point(394, 130);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(42, 15);
            this.userid.TabIndex = 2;
            this.userid.Text = "User ID";
            // 
            // logtxt
            // 
            this.logtxt.AutoSize = true;
            this.logtxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logtxt.Location = new System.Drawing.Point(466, 96);
            this.logtxt.Name = "logtxt";
            this.logtxt.Size = new System.Drawing.Size(59, 24);
            this.logtxt.TabIndex = 1;
            this.logtxt.Text = "Log In";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 406);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome Back";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(634, 406);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.Label logtxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label frgtpass;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label passwrd;
        private System.Windows.Forms.Button loginbttn;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

