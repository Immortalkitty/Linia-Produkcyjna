using System;
using System.Collections.Generic;

namespace LiniaProdukcyjna
{
	class User
	{
		public string login { get; private set; }
		public string password { get; private set; }

		static public List<User> Users = new List<User>();
		
		public User(string login,string password)
		{
			this.login = login;
			this.password = password;
			Users.Add(this);
		}

	}
}
