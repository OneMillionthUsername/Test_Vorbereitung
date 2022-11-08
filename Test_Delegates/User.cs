using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Delegates
{
	public class User
	{
		public string Name { get; set; }
		public string Nachricht { get; set; }
		public User(string name, string nachricht)
		{
			Name = name;
			Nachricht = nachricht;
		}

	}
}
