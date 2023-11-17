using System;
using System.Collections.Generic;

namespace LiniaProdukcyjna
{
	class User
	{
		public string login { get; private set; }
		public string password { get; private set; }

		
		
		public User(string login,string password)
		{
			this.login = login;
			this.password = password;
			
		}

	}
}
