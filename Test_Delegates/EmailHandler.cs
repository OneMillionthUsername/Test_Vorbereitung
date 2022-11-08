using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Delegates
{
	public class EmailHandler : User
	{
		public EmailHandler(string name, string nachricht) : base(name, nachricht)
		{
		}
		public void sendEmail()
		{
			Console.WriteLine($"Email an: {Name} mit der Nachricht {Nachricht}");
		}
	}
}
