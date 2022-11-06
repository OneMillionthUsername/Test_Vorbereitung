using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_Vorbereitung
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Fahrzeug> fahrzeuge = new();
			fahrzeuge.Add(new Auto() { Name="Audi", Leistung=180, IsAutomatic=true, Gears=6 });
			fahrzeuge.Add(new Motorrad() { Name="Kawazaki Ninja", Leistung=180, AnzahlSitze=1 });
			fahrzeuge.Add(new Auto() { Name="VW Golf", Leistung=80, IsAutomatic=false, Gears=5 });
			fahrzeuge.Add(new Auto() { Name="Trabant", Leistung=40, IsAutomatic=false, Gears=4 });
			fahrzeuge.Add(new Motorrad() { Name="Verspa Roller", Leistung=30, AnzahlSitze=2 });

			foreach (var fz in fahrzeuge)
			{
				Console.WriteLine(fz.GetFahrzeugToString());
			}
			//Abfragen
			//int AnzahlVonAutos = fahrzeuge.Count(x => fahrzeuge.Where(x.GetType() == typeof(Auto) )
		}
	}
}
