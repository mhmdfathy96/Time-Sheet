using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using bmgtimesheet.Classes;
using bmgtimesheet.models;

namespace bmgtimesheet
{
	 class MyTools:Json
	{

		private readonly Form currentForm;
		public static TimeController timeController;
		public MyTools(Form currentForm = null, TimeController timeControllerr = null)
		{
			if (currentForm != null) this.currentForm = currentForm;
			if (timeControllerr != null) timeController = timeControllerr;
		}


		public async Task<dynamic> Button_Click(Task<dynamic> task)
		{
			ProgressBar progressBar = currentForm.Controls.OfType<ProgressBar>().FirstOrDefault();
			progressBar.Show();
			currentForm.Enabled = false;
			var dynamicObject = await task;
			currentForm.Enabled = true;
			progressBar.Value = 100;
			progressBar.Hide();
			return dynamicObject;
		}

		public void Opennewform(Form newform,Form previousform) {
            previousform.Hide();
            var form2 = newform;
            form2.Closed += (s, args) => previousform.Close();
			form2.Show();


		}

		public string Outofmins(int mins)
		{
			if (mins <= 540)
			{

			}
			int hrs = mins / 60;
			int minutes = mins % 60;
			string hr;
			string min;
			if (hrs.ToString().Length == 1)
			{
				hr = $"0{hrs}";
			}
			else
			{
				hr = hrs.ToString();
			}
			if (minutes.ToString().Length == 1)
			{
				min = $"0{minutes}";
			}
			else
			{
				min = minutes.ToString();
			}
			return $"{hr}:{min}";
		}

		public Dictionary<string, int> Totalhoursofthemonth(string month, int daysinRamadan)
		{
			int totalhours = 0;
			int totaldays = 0;
			var thismonth = Getmonth(month);
			var alldays = DateTime.DaysInMonth(DateTime.Now.Year, thismonth);
			for (int x = 1; x <= alldays; x++)
			{
				var dat = DateTime.Parse($"{thismonth}/{x}").DayOfWeek.ToString();
				if (!dat.StartsWith("S"))
				{
					totalhours += 9;
					totaldays += 1;
				}
			}
			if (daysinRamadan != 0 && daysinRamadan <= alldays) totalhours -= daysinRamadan;
			return new Dictionary<string, int> { { "totalHours", totalhours }, { "totalDays", totaldays } };
		}

		public int Getmonth(string name)
		{
			Dictionary<string, int> AllMonth = new Dictionary<string, int> { { "january", 1 }, { "february", 2 }, { "march", 3 }, { "april", 4 }, { "may", 5 }, { "june", 6 }, { "july", 7 }, { "august", 8 }, { "september", 9 }, { "october", 10 }, { "november", 11 }, { "december", 12 }, };
			return AllMonth[name.ToLower()];
		}

		public void Enablebtn(Button btn,string text) {
			btn.Text = text;
			btn.Enabled = true;
			btn.BackColor = System.Drawing.Color.ForestGreen;
		}

		public int GetNumber(string val) {
			string result = "";
			for (int x = 0; x < val.Length; x++) {
				if (Char.IsDigit(val[x])) result += val[x];
			}
			return int.Parse(result);
		}

		public void FetchAttendance(List<AttendanceView> attendanceViews)
		{
			DataGridView dataGridView = currentForm.Controls.OfType<DataGridView>().FirstOrDefault();
			dataGridView.Rows.Clear();
			foreach (AttendanceView attendance in attendanceViews)
			{
				dataGridView.Rows.Add(attendance.date, attendance.startTime, attendance.endTime, attendance.regular, attendance.overTime, attendance.holidayHours);
			}
		}

		public int RegularTime(User user, bool isRamadan)
		{
			return (user.office == "Mansoura") ? (user.gender == "Male") ? isRamadan ? int.Parse(timeController.RamMM) * 60 : int.Parse(timeController.RegMM) * 60 :
																									isRamadan ? int.Parse(timeController.RamMF) * 60 : int.Parse(timeController.RegMF) * 60 :
																		  (user.gender == "Male") ? isRamadan ? int.Parse(timeController.RamCM) * 60 : int.Parse(timeController.RegCM) * 60 :
																									isRamadan ? int.Parse(timeController.RamCF) * 60 : int.Parse(timeController.RegCF) * 60;
		}

	}
}
