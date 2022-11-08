using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Delegates
{
	public class SMSHandler : User
	{
		public SMSHandler(string name, string nachricht) : base(name, nachricht)
		{
		}

		public void sendSMS()
		{
			Console.WriteLine($"SMS an: {Name} mit der Nachricht {Nachricht}");
		}
	}
}
