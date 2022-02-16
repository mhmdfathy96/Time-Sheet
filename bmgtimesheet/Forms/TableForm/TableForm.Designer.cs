
namespace bmgtimesheet
{
    partial class Tableform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tableform));
            this.exitbtn2 = new System.Windows.Forms.Button();
            this.empname2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalthismonth = new System.Windows.Forms.Label();
            this.backbtn2 = new System.Windows.Forms.Button();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoliday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn2
            // 
            this.exitbtn2.BackColor = System.Drawing.Color.Red;
            this.exitbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn2.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitbtn2.Location = new System.Drawing.Point(620, 537);
            this.exitbtn2.Name = "exitbtn2";
            this.exitbtn2.Padding = new System.Windows.Forms.Padding(5);
            this.exitbtn2.Size = new System.Drawing.Size(86, 39);
            this.exitbtn2.TabIndex = 6;
            this.exitbtn2.Text = "Exit";
            this.exitbtn2.UseVisualStyleBackColor = false;
            this.exitbtn2.Click += new System.EventHandler(this.Exitbtn2_Click);
            // 
            // empname2
            // 
            this.empname2.AutoSize = true;
            this.empname2.BackColor = System.Drawing.Color.Orange;
            this.empname2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empname2.Font = new System.Drawing.Font("BankGothic Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empname2.Location = new System.Drawing.Point(312, 9);
            this.empname2.Name = "empname2";
            this.empname2.Padding = new System.Windows.Forms.Padding(2);
            this.empname2.Size = new System.Drawing.Size(188, 28);
            this.empname2.TabIndex = 8;
            this.empname2.Text = "Employee Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colStart,
            this.colEnd,
            this.colTotal,
            this.colOver,
            this.colHoliday});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(694, 445);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // totalthismonth
            // 
            this.totalthismonth.AutoSize = true;
            this.totalthismonth.BackColor = System.Drawing.Color.DarkOrange;
            this.totalthismonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalthismonth.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalthismonth.Location = new System.Drawing.Point(12, 543);
            this.totalthismonth.Name = "totalthismonth";
            this.totalthismonth.Padding = new System.Windows.Forms.Padding(2);
            this.totalthismonth.Size = new System.Drawing.Size(109, 23);
            this.totalthismonth.TabIndex = 11;
            this.totalthismonth.Text = "Total Days";
            this.totalthismonth.Click += new System.EventHandler(this.Totalthismonth_Click);
            // 
            // backbtn2
            // 
            this.backbtn2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backbtn2.BackgroundImage = global::bmgtimesheet.Properties.Resources.Round_Back_Button_PNG_Image_Background;
            this.backbtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbtn2.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn2.Location = new System.Drawing.Point(12, 17);
            this.backbtn2.Name = "backbtn2";
            this.backbtn2.Size = new System.Drawing.Size(62, 31);
            this.backbtn2.TabIndex = 12;
            this.backbtn2.UseVisualStyleBackColor = false;
            this.backbtn2.Click += new System.EventHandler(this.Backbtn2_Click_1);
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 150;
            // 
            // colStart
            // 
            this.colStart.HeaderText = "Start";
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            // 
            // colEnd
            // 
            this.colEnd.HeaderText = "End";
            this.colEnd.Name = "colEnd";
            this.colEnd.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Regular";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colOver
            // 
            this.colOver.HeaderText = "Overtime";
            this.colOver.Name = "colOver";
            this.colOver.ReadOnly = true;
            // 
            // colHoliday
            // 
            this.colHoliday.HeaderText = "HolidayHours";
            this.colHoliday.Name = "colHoliday";
            this.colHoliday.ReadOnly = true;
            // 
            // MonthCombo
            // 
            this.MonthCombo.BackColor = System.Drawing.Color.Yellow;
            this.MonthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCombo.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthCombo.FormattingEnabled = true;
            this.MonthCombo.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthCombo.Location = new System.Drawing.Point(292, 48);
            this.MonthCombo.Name = "MonthCombo";
            this.MonthCombo.Size = new System.Drawing.Size(235, 25);
            this.MonthCombo.TabIndex = 13;
            this.MonthCombo.SelectedIndexChanged += new System.EventHandler(this.MonthCombo_SelectedIndexChanged);
            // 
            // Tableform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(723, 581);
            this.Controls.Add(this.MonthCombo);
            this.Controls.Add(this.backbtn2);
            this.Controls.Add(this.totalthismonth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.empname2);
            this.Controls.Add(this.exitbtn2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tableform";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Tableform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitbtn2;
        private System.Windows.Forms.Label empname2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totalthismonth;
        private System.Windows.Forms.Button backbtn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoliday;
        private System.Windows.Forms.ComboBox MonthCombo;
    }
}