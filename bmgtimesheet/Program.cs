using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmgtimesheet
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var user = new LocalServices().GetUser();
			if (user != null)
			{
				Application.Run(new AttendanceForm(user));
			}
			else
			{
				Application.Run(new Login());
			}
		}
	}
}
