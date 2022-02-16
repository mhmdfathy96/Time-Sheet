using System;
using System.Windows.Forms;
using bmgtimesheet.models;
using bmgtimesheet.Services;

namespace bmgtimesheet
{
    public partial class AttendanceForm : Form
    {
        private static User user;
        private Boolean isHoliday = false;
        private Boolean isRamadan = false;
        private static string mDate;
        private static string mTime;
        private readonly AttendanceServices attendanceServices = new AttendanceServices();
        private readonly TimeControllerServices timeControllerServices = new TimeControllerServices();
        private readonly LocalServices localServices = new LocalServices();
        private static MyTools myTools;
        private static TimeController timeController;
        public AttendanceForm(User mUser)
        {
            InitializeComponent();
            empname.Text = mUser.name;
            user = mUser;
            mDate = DateTime.Now.ToString("dddd, dd MMMM");
            dateview.Text = mDate;
            mTime = DateTime.Now.ToString("HH:mm");
            timeview.Text = mTime;
        }
        private void Button1_Click(object sender, EventArgs e) {
            myTools.Opennewform(new Login(), this);
            localServices.DeleteData();
        }

        private void Startendbtn_Click(object sender, EventArgs e)
        {

            GetReady(false);

        }

        private void Timepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void Tablebtn_Click(object sender, EventArgs e)
        {
            timeController = await myTools.Button_Click(timeControllerServices.GetSettings());
            if (timeController != null)
            {
                myTools.Opennewform(new Tableform(user, timeController), this);
            }
            else {
                MessageBox.Show("Something wrong,check your Connection");
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HolidayCB_CheckedChanged(object sender, EventArgs e)
        {
            isHoliday = !isHoliday;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            mDate = DateTime.Now.ToString("dddd, dd MMMM");
            dateview.Text = mDate;
            mTime = DateTime.Now.ToString("HH:mm");
            timeview.Text = mTime;
        }

        private void Attendanceform_Load(object sender, EventArgs e)
        {
            myTools = new MyTools(currentForm: this);
            if (mDate.StartsWith("S")) HolidayCB.Enabled = false;
            GetReady(true);
            /*
            if (new LocalData().IsRamadan())
            {
                RamadanCB.CheckState = CheckState.Checked;
            }
            */

        }

        private void RamadanCB_CheckedChanged(object sender, EventArgs e)
        {
            isRamadan = !isRamadan;

        }

        private void Dateview_ValueChanged(object sender, EventArgs e)
        {
        }

        private void RefreshBtnn_Click(object sender, EventArgs e)
        {
            GetReady(true);
        }

        private async void GetReady(bool regORpass){
          string res= await myTools.Button_Click(attendanceServices.CheckPassword(user));
            if (res == "")
            {
                if (regORpass)
                {
                    StartorEnd();
                }
                else {
                    Register();
                }
            }
            else if(res == "Something wrong,check your Connection")
            {
                MessageBox.Show(res);
            }else {
                MessageBox.Show(res);
                myTools.Opennewform(new Login(),this);
            }
            
        }

        private async void StartorEnd() {
            string res = await myTools.Button_Click(attendanceServices.Startorstop(user, HolidayCB, RamadanCB));
            if (res == "readytostart")
            {
                myTools.Enablebtn(startendbtn, "Start");
            }
            else if (res == "readytoend")
            {
                myTools.Enablebtn(startendbtn, "End");
            }
            else if (res == "already_signed_today")
            {
                MessageBox.Show("Today's Attendance is Done");
            }
            else
            {
                MessageBox.Show(res);
            }
        }

        private async void Register() {
            var isStart = (startendbtn.Text == "Start");
           string res= await myTools.Button_Click(attendanceServices.StartLeave(user, new Attendance(mDate, isStart ? mTime : null, isStart ? null : mTime, isHoliday, isRamadan)));
            MessageBox.Show(res);
            startendbtn.Enabled = false;
            startendbtn.Text = "Done";
            startendbtn.BackColor = System.Drawing.Color.Gray;
        }
    }
}
