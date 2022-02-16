using System;
using System.Windows.Forms;
using bmgtimesheet.models;

namespace bmgtimesheet
{
    class LocalServices
    {
        static Properties.Settings props;

        public LocalServices() {
            props = Properties.Settings.Default;
        }

        public void SaveUser(User user)
        {
            props.userId = user.id;
            props.userName = user.name;
            props.userCode = user.code;
            props.userEmail = user.email;
            props.userPassword = user.password;
            props.userGender = user.gender;
            props.userOffice = user.office;
            props.Save();
        }

        public User GetUser()
        {
            if (props.userId != string.Empty)
            {
                return new User(props.userId, props.userName, props.userCode, props.userEmail, props.userPassword, props.userGender, props.userOffice);
            }
            else {
                return null;
            }
        }

        public void DeleteData()
        {
            props.Reset();
        }

    }
}
