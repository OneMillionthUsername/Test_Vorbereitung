using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vorbereitung
{
	abstract class Fahrzeug
	{
		public Fahrzeug()
		{

		}
		protected Fahrzeug(string name, int leistung)
		{
			Name = name;
			Leistung = leistung;
		}

		public string Name { get; set; }
		public int Leistung { get; set; }
		public virtual string GetFahrzeugToString()
		{
			return string.Format($"{this.GetType().Name} {Name} hat {Leistung} PS.");
		}
	}
}
