using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
	abstract class Fahrzeug
	{
		public string Name { get; set; }
		public int Leistung { get; set; }
		public virtual string GetFahrzeugToString()
		{
			return string.Format($"Fahrzeug {Name} hat {Leistung} PS.");
		}
	}
}
