
namespace bmgtimesheet
{
    partial class AttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.empname = new System.Windows.Forms.Label();
            this.startendbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.tablebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RamadanCB = new System.Windows.Forms.CheckBox();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.dateview = new System.Windows.Forms.DateTimePicker();
            this.timeview = new System.Windows.Forms.Label();
            this.HolidayCB = new System.Windows.Forms.CheckBox();
            this.RefreshBtnn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // empname
            // 
            this.empname.AutoSize = true;
            this.empname.BackColor = System.Drawing.Color.Orange;
            this.empname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.empname.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empname.Location = new System.Drawing.Point(194, 22);
            this.empname.Name = "empname";
            this.empname.Padding = new System.Windows.Forms.Padding(6);
            this.empname.Size = new System.Drawing.Size(152, 31);
            this.empname.TabIndex = 0;
            this.empname.Text = "Employee Name";
            // 
            // startendbtn
            // 
            this.startendbtn.BackColor = System.Drawing.Color.Gray;
            this.startendbtn.Enabled = false;
            this.startendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startendbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startendbtn.ForeColor = System.Drawing.Color.Black;
            this.startendbtn.Location = new System.Drawing.Point(230, 242);
            this.startendbtn.Name = "startendbtn";
            this.startendbtn.Size = new System.Drawing.Size(116, 51);
            this.startendbtn.TabIndex = 1;
            this.startendbtn.Text = "Start";
            this.startendbtn.UseVisualStyleBackColor = false;
            this.startendbtn.Click += new System.EventHandler(this.Startendbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.GhostWhite;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(12, 22);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 31);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "LogOut";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Red;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitbtn.Location = new System.Drawing.Point(453, 328);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(99, 38);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // tablebtn
            // 
            this.tablebtn.BackColor = System.Drawing.Color.Tan;
            this.tablebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tablebtn.FlatAppearance.BorderSize = 5;
            this.tablebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tablebtn.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablebtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.tablebtn.Location = new System.Drawing.Point(216, 307);
            this.tablebtn.Name = "tablebtn";
            this.tablebtn.Size = new System.Drawing.Size(153, 33);
            this.tablebtn.TabIndex = 7;
            this.tablebtn.Text = "My Attendance";
            this.tablebtn.UseVisualStyleBackColor = false;
            this.tablebtn.Click += new System.EventHandler(this.Tablebtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.RamadanCB);
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.dateview);
            this.panel1.Controls.Add(this.timeview);
            this.panel1.Controls.Add(this.HolidayCB);
            this.panel1.Location = new System.Drawing.Point(131, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 137);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // RamadanCB
            // 
            this.RamadanCB.AutoSize = true;
            this.RamadanCB.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamadanCB.Location = new System.Drawing.Point(30, 114);
            this.RamadanCB.Name = "RamadanCB";
            this.RamadanCB.Size = new System.Drawing.Size(170, 21);
            this.RamadanCB.TabIndex = 12;
            this.RamadanCB.Text = "Is it a Ramadan?";
            this.RamadanCB.UseVisualStyleBackColor = true;
            this.RamadanCB.CheckedChanged += new System.EventHandler(this.RamadanCB_CheckedChanged);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshbtn.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.Color.Black;
            this.refreshbtn.Location = new System.Drawing.Point(178, 60);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(57, 25);
            this.refreshbtn.TabIndex = 9;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // dateview
            // 
            this.dateview.Enabled = false;
            this.dateview.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateview.Location = new System.Drawing.Point(16, 16);
            this.dateview.Name = "dateview";
            this.dateview.Size = new System.Drawing.Size(304, 24);
            this.dateview.TabIndex = 11;
            this.dateview.Value = new System.DateTime(2021, 12, 14, 21, 21, 0, 0);
            this.dateview.ValueChanged += new System.EventHandler(this.Dateview_ValueChanged);
            // 
            // timeview
            // 
            this.timeview.AutoSize = true;
            this.timeview.BackColor = System.Drawing.Color.PaleTurquoise;
            this.timeview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeview.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeview.Location = new System.Drawing.Point(96, 56);
            this.timeview.Name = "timeview";
            this.timeview.Padding = new System.Windows.Forms.Padding(6);
            this.timeview.Size = new System.Drawing.Size(76, 31);
            this.timeview.TabIndex = 10;
            this.timeview.Text = "22:22";
            this.timeview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeview.Click += new System.EventHandler(this.Label1_Click);
            // 
            // HolidayCB
            // 
            this.HolidayCB.AutoSize = true;
            this.HolidayCB.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolidayCB.Location = new System.Drawing.Point(30, 90);
            this.HolidayCB.Name = "HolidayCB";
            this.HolidayCB.Size = new System.Drawing.Size(162, 21);
            this.HolidayCB.TabIndex = 7;
            this.HolidayCB.Text = "Is it a Holiday?";
            this.HolidayCB.UseVisualStyleBackColor = true;
            this.HolidayCB.CheckedChanged += new System.EventHandler(this.HolidayCB_CheckedChanged);
            // 
            // RefreshBtnn
            // 
            this.RefreshBtnn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtnn.BackgroundImage = global::bmgtimesheet.Properties.Resources.refresh;
            this.RefreshBtnn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshBtnn.Location = new System.Drawing.Point(352, 249);
            this.RefreshBtnn.Name = "RefreshBtnn";
            this.RefreshBtnn.Size = new System.Drawing.Size(39, 36);
            this.RefreshBtnn.TabIndex = 9;
            this.RefreshBtnn.UseVisualStyleBackColor = false;
            this.RefreshBtnn.Click += new System.EventHandler(this.RefreshBtnn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(234, 213);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 369);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.RefreshBtnn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablebtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.startendbtn);
            this.Controls.Add(this.empname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttendanceForm";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendanceform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empname;
        private System.Windows.Forms.Button startendbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button tablebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox HolidayCB;
        private System.Windows.Forms.Label timeview;
        private System.Windows.Forms.DateTimePicker dateview;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.CheckBox RamadanCB;
        private System.Windows.Forms.Button RefreshBtnn;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}