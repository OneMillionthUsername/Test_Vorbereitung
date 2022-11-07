using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
	class Motorrad : Fahrzeug
	{
		public Motorrad()
		{

		}

		public Motorrad(string name, int leistung, int anzahlSitze) : base(name, leistung)
		{
			Name = name;
			Leistung = leistung;
			AnzahlSitze = anzahlSitze;
		}

		public int AnzahlSitze { get; set; }
		public override string GetFahrzeugToString()
		{
			return string.Format($"{this.GetType().Name} {Name} hat {Leistung} PS.\nFahrzeug hat {AnzahlSitze} Sitze.");
		}
	}
}
