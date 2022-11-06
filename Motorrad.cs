using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
	class Motorrad : Fahrzeug
	{
		public int AnzahlSitze { get; set; }
		public override string GetFahrzeugToString()
		{
			return string.Format($"Fahrzeug {Name} hat {Leistung} PS.\nFahrzeug hat {AnzahlSitze} Sitze.");
		}
	}
}
