using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
	class Auto : Fahrzeug
	{
		public Auto()
		{

		}
		public Auto(string name, int leistung, int gears, bool isAutomatic) : base(name, leistung)
		{
			Name = name;
			Leistung = leistung;
			Gears = gears;
			IsAutomatic = isAutomatic;
		}

		public int Gears { get; set; }
		public bool IsAutomatic { get; set; }
		public override string GetFahrzeugToString()
		{
			return string.Format($"{this.GetType().Name} {Name} hat {Leistung} PS.\nFahrzeug hat {Gears} Gänge. Automatische Gangschaltung: {IsAutomatic}.");
		}
	}
}
