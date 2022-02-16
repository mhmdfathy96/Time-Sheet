using System;
using System.Collections.Generic;
using System.Windows.Forms;
using bmgtimesheet.models;
using Microsoft.VisualBasic;

namespace bmgtimesheet
{
    public partial class Tableform : Form
    {
        private static User user;
        private static TimeController timeController;
        public string thismonth;
        private readonly AttendanceServices attendanceServices = new AttendanceServices();
        private static MyTools myTools;
        private readonly List<string> AllMonths = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public Tableform(User userr,TimeController timeControllerr)
        {
            InitializeComponent();
            user = userr;
            timeController = timeControllerr;
            this.empname2.Text = user.name;
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Tableform_Load(object sender, EventArgs e)
        {
            myTools = new MyTools(currentForm:this,timeControllerr:timeController);
            thismonth = AllMonths[DateTime.Now.Month - 1];
            MonthCombo.SelectedIndex=DateTime.Now.Month - 1;
            await attendanceServices.GetAttendance(user, thismonth);
            myTools.FetchAttendance(await attendanceServices.GetAttendance(user,thismonth));
            MonthDetails();
        }

        private void Exitbtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Backbtn2_Click_1(object sender, EventArgs e) =>  myTools.Opennewform(new AttendanceForm(user), this);

        private void Totalthismonth_Click(object sender, EventArgs e)
        {
           var res= Interaction.InputBox("Please enter Ramadan's days in this Month","How many days in Ramadan?","0");

            if (int.TryParse(res, out _) && int.Parse(res)<=31)
            {
                MonthDetails(int.Parse(res));
            }
            else {
                MessageBox.Show("NOT VALID!!");
            }


        }

        private void MonthDetails(int daysinRamadan=0) {
            var result = myTools.Totalhoursofthemonth(thismonth,daysinRamadan);
            var totalhours = result["totalHours"];
            var totaldays = result["totalDays"];
            totalthismonth.Text = $"Note:Total Regular Hours in {thismonth} = {totalhours} in {totaldays} Days";

        }

        private async void MonthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            thismonth = MonthCombo.SelectedItem as string;
            myTools.FetchAttendance(await attendanceServices.GetAttendance(user, thismonth));
            MonthDetails();
        }
    }
}
