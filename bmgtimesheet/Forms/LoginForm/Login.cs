using System;
using System.Windows.Forms;
using bmgtimesheet.models;

namespace bmgtimesheet
{
	public partial class Login : Form
	{
		private static MyTools myTools;
		private readonly AttendanceServices attendanceServices=new AttendanceServices();
		public Login()
		{
			InitializeComponent();
		}


		private void Codetxt_Click(object sender, EventArgs e)
		{

		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private async void Btnlogin_Click(object sender, EventArgs e)
		{
			string userCode = codetxt.Text.Trim();
			string userPassword = Passwordtxt.Text.Trim();
			if (userCode.Length == 0 || userPassword.Length == 0)
			{
				MessageBox.Show("Please fill your DATA");
			}
			else if (userCode.Length != 4)
			{
				MessageBox.Show("Code must be 4 letters");
			} else if (userPassword.Length != 8) {
				MessageBox.Show("Password must be 8 letters");
			}
			else {
				var response=await myTools.Button_Click(attendanceServices.CheckCode(userCode,userPassword));
				if (response != null) myTools.Opennewform(new AttendanceForm(response as User), this);
			}
		}

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
			Application.Exit();
		}

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
			myTools = new MyTools(currentForm: this);
		}

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
			Passwordtxt.PasswordChar = Passwordtxt.PasswordChar == '*' ? '\0' : '*';
		}
    }
}
