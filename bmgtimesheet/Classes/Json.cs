
using System.Collections.Generic;
using bmgtimesheet.models;
using Google.Cloud.Firestore;

namespace bmgtimesheet.Classes
{
	class Json
	{
		public User UserfromJson(DocumentSnapshot usersnapshot)
		{
			var userDocument = usersnapshot.ToDictionary();
			return new User(usersnapshot.Id, userDocument["name"] as string, userDocument["code"] as string, userDocument["email"] as string, userDocument.ContainsKey("password") ? userDocument["password"] as string : "", userDocument.ContainsKey("gender") ? userDocument["gender"] as string : "", userDocument.ContainsKey("office") ? userDocument["office"] as string : "");
		}

		public Dictionary<string, object> UsertoJson(User user)
		{
			return new Dictionary<string, object>
					{
						{ "code", user.code
	},
						{ "name", user.name
},
						{ "email", user.email},
					{ "password",user.password },
					{ "gender",user.gender},
					{ "office",user.office},
					};
		}

		public TimeController TimeControllerfromJson(DocumentSnapshot timeControllerSnapshot)
		{
			var timeDocument = timeControllerSnapshot.ToDictionary();
			return new TimeController(
				timeDocument["RegCM"] as string,
				timeDocument["RegCF"] as string,
				timeDocument["RamCM"] as string,
				timeDocument["RamCF"] as string,
				timeDocument["RegMM"] as string,
				timeDocument["RegMF"] as string,
				timeDocument["RamMM"] as string,
				timeDocument["RamMF"] as string
				);
		}


		public Dictionary<string, object> TimeControllertoJson(TimeController timeController)
		{
			return new Dictionary<string, object>
					{
						{ "RegCM", timeController.RegCM},
						{ "RegCF", timeController.RegCF},
						{ "RamCM", timeController.RamCM},
						{ "RamCF", timeController.RamCF},
						{ "RegMM", timeController.RegMM},
						{ "RegMF", timeController.RegMF},
						{ "RamMM", timeController.RamMM},
						{ "RamMF", timeController.RamMF},

					};
		}
	}
}
