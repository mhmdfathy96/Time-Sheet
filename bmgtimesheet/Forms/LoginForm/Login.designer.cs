
namespace bmgtimesheet
{
	partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnlogin = new System.Windows.Forms.Button();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.logintxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(125, 317);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(243, 43);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Let\'s Start";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // codetxt
            // 
            this.codetxt.Location = new System.Drawing.Point(7, 22);
            this.codetxt.MaxLength = 4;
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(143, 20);
            this.codetxt.TabIndex = 2;
            this.codetxt.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // logintxt
            // 
            this.logintxt.AccessibleDescription = "";
            this.logintxt.AccessibleName = "";
            this.logintxt.AutoSize = true;
            this.logintxt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintxt.Location = new System.Drawing.Point(3, 0);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(46, 19);
            this.logintxt.TabIndex = 3;
            this.logintxt.Text = "Code";
            this.logintxt.Click += new System.EventHandler(this.Codetxt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.logintxt);
            this.panel1.Controls.Add(this.codetxt);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.Passwordtxt);
            this.panel1.Location = new System.Drawing.Point(160, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 104);
            this.panel1.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AccessibleDescription = "";
            this.PasswordLabel.AccessibleName = "";
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(3, 45);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(81, 19);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(6, 67);
            this.Passwordtxt.MaxLength = 11;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(144, 20);
            this.Passwordtxt.TabIndex = 4;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Orange;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitbtn.Location = new System.Drawing.Point(404, 356);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(62, 31);
            this.exitbtn.TabIndex = 11;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::bmgtimesheet.Properties.Resources.WhatsApp_Image_2021_07_14_at_9_32_40_AM__3__1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(263, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 132);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::bmgtimesheet.Properties.Resources.WhatsApp_Image_2021_07_14_at_9_321;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(37, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 132);
            this.panel2.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(196, 162);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.LoginProgressBar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 399);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.btnlogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnlogin;
		private System.Windows.Forms.TextBox codetxt;
		private System.Windows.Forms.Label logintxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

