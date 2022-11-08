using System;
using System.Linq;

namespace Test_Delegates
{
	class Program
	{
		static void Main(string[] args)
		{

			while (true)
			{
				string input = Console.ReadLine();
				while (input.Count(x => x == ':') > 1)
				{
					input.Replace((char)input.LastIndexOf(':'), ' ');
				}
				string[] nachricht = input.Split(":");
				User user = new(nachricht[0], nachricht[1]+1);
				SMSHandler sms = new(user.Nachricht, user.Nachricht);
				EmailHandler email = new(user.Nachricht, user.Nachricht);
				sms.sendSMS();
				email.sendEmail();
			}
		}
	}
}
