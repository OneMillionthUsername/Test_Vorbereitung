using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
	class Auto : Fahrzeug
	{
		public int Gears { get; set; }
		public bool IsAutomatic { get; set; }
		public override string GetFahrzeugToString()
		{
			return string.Format($"Fahrzeug {Name} hat {Leistung} PS.\nFahrzeug hat {Gears} Gänge. Automatische Gangschaltung: {IsAutomatic}.");
		}
	}
}
