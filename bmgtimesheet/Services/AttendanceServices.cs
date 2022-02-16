using System;
using System.Linq;
using System.Collections.Generic;
using Google.Cloud.Firestore;
using System.Windows.Forms;
using bmgtimesheet.models;
using System.Threading.Tasks;
using bmgtimesheet.Classes;

namespace bmgtimesheet
{
	class AttendanceServices : MyTools
	{
		public static FirestoreDb db;
		private readonly LocalServices localServices = new LocalServices();
		public readonly DBHelper dbHelper = new DBHelper();

		public AttendanceServices()
        {
			StartFireStore();
			db = FirestoreDb.Create("bmgtimesheet");
		}

		public void StartFireStore() {
			string path = AppDomain.CurrentDomain.BaseDirectory + @"bmgtimesheet-firebase-adminsdk-sjtu6-bd0c9f674a.json";
			Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
		}
		public async Task<dynamic> StartLeave(User user,Attendance attendance)
		{
			try
			{
				Dictionary<string, object> attend;
				var x = DateTime.Now.ToString("MMMM");
				DocumentReference docRef = db.Collection("Attendance").Document(DateTime.Now.ToString("MMMM")).Collection(user.code).Document(attendance.date);
				if (attendance.endTime == null)
				{
					attend = new Dictionary<string, object>
			{
				{ "startTime", attendance.startTime},
				{ "endTime", ""},
				{ "isHoliday",attendance.isHoliday.ToString()},
				{ "isRamadan",attendance.isRamadan.ToString()},
			};
					await docRef.SetAsync(attend);
					return "Your attendance has been added Successfully";
				}
				else
				{
					attend = new Dictionary<string, object>
			{
				{ "endTime", attendance.endTime},
				{ "isHoliday",attendance.isHoliday.ToString()},
				{ "isRamadan",attendance.isRamadan.ToString()},
			};
					await docRef.UpdateAsync(attend);
					return "Your departure has been added Successfully";
				}
			}
			catch
			{
				return "Something wrong,check your Connection";
			}

		}

		public async Task<dynamic> CheckCode(string userCode,string userPassword)
		{
			User user = null;
			try
			{
				Query usersRef = db.Collection("users").WhereEqualTo("code",userCode);
				QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

				if (snapshot != null && snapshot.Count !=0)
				{
					DocumentSnapshot document = snapshot.Documents[0];
						Dictionary<string, object> documentDictionary = document.ToDictionary();
						bool correctPassword = userPassword == documentDictionary["password"] as string;
						if (correctPassword)
						{
							user = UserfromJson(document);
							localServices.SaveUser(user);
						}
                        else{
							MessageBox.Show("Wrong Password!!");
						}
				}
				else
				{
					MessageBox.Show("Wrong Code!!");
				}
			}
			catch
			{
				MessageBox.Show("Something wrong,check your Connection");
			}

			return user;
		}

		public async Task<dynamic> CheckPassword(User userr) {
			try
			{
				Query usersRef = db.Collection("users").WhereEqualTo("code", userr.code);
				QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

				if (snapshot != null && snapshot.Count != 0)
				{
					DocumentSnapshot document = snapshot.Documents[0];
					Dictionary<string, object> documentDictionary = document.ToDictionary();
					bool correctPassword = userr.password == documentDictionary["password"] as string;
					if (!correctPassword)
					{
						localServices.DeleteData();
						return "Password is not Valid anymore,Ask Boss for new one";
					}
					else
					{
						return "";
					}
				}
				else
				{
					localServices.DeleteData();
					return "Sorry you are not User anymore";
				}
			}
			catch
			{
				return "Something wrong,check your Connection";
			}
		}

		public async Task<List<AttendanceView>> GetAttendance(User user, string month)
		{
			List<AttendanceView> all = new List<AttendanceView>();
			int totalTotal = 0;
			int totalOver = 0;
			int totalHoliday = 0;
			int totalTillNow = 0;
			bool isRamadan = false;
			try
			{
				Query usersRef = db.Collection("Attendance").Document(month).Collection(user.code);
				QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();
				if (snapshot != null)
				{
					foreach (DocumentSnapshot document in snapshot.Documents)
					{
						List<dynamic> attendance = dbHelper.GetAttendanceView(document, user);
						AttendanceView attendanceView = attendance[0];
						all.Add(attendanceView);
						totalTotal += attendance[1];
						totalHoliday += attendance[2];
						isRamadan = attendance[3];
						if (!attendanceView.date.StartsWith("S"))
						{
							totalTillNow += RegularTime(user, isRamadan);
						}

					}
					if (all.Count != 0)
					{

						all = all.OrderBy(x => GetNumber(x.date)).ToList();
					}
					if (totalTotal > totalTillNow)
					{
						totalOver = totalTotal - totalTillNow;
						totalTotal = totalTillNow;
					}
					var final = new AttendanceView("Total in the Month", "", "", Outofmins(totalTotal), Outofmins(totalOver), Outofmins(totalHoliday));
					var totaltillNowRow = new AttendanceView("Gross Hours", "", "", (totalTillNow / 60).ToString() + " Hr", "", "");
					all.Add(final);
					all.Add(totaltillNowRow);
					return all;
				}
				else
				{
					return all;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return all;
			}

		}

		public async Task<dynamic> Startorstop(User user, CheckBox HolCB,CheckBox RamCB)
		{
			try
			{
				DocumentReference usersRef = db.Collection("Attendance").Document(DateTime.Now.ToString("MMMM")).Collection(user.code).Document(DateTime.Now.ToString("dddd, dd MMMM"));
				DocumentSnapshot snapshot = await usersRef.GetSnapshotAsync();

				if (snapshot != null && snapshot.Exists)
				{
						Dictionary<string, object> documentDictionary = snapshot.ToDictionary();
						//if (DateTime.Now.ToString("dddd, dd MMMM") == document.Id && documentDictionary["endTime"] as string == "")
						if ( documentDictionary["endTime"] as string == "")
						{
							if (Boolean.Parse(documentDictionary["isHoliday"] as string)) HolCB.Checked = true;
							
							if (Boolean.Parse(documentDictionary["isRamadan"] as string)) RamCB.Checked = true;
					
						return "readytoend";
					}
						else {
						return "already_signed_today";
						}
				}
				else
				{
					return "readytostart";
				}
			}
			catch
			{
				return "Something wrong,check your Connection";

			}
		}
	}
}
