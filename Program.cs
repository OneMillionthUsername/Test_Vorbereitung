using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_Vorbereitung
{
	class Program
	{
		public delegate void MakeOutput(string text);
		public delegate void Say(string say);

		public static void SayHello(string str)
		{
			Console.WriteLine("Hello " + str);
		}
		public static void MakeOutputToConsole(string txt)
		{
			Console.WriteLine(txt);
		}
		static void Main(string[] args)
		{
			List<Fahrzeug> fahrzeuge = new() { 
			new Auto("Ferrari", 300, 6, true), 
			new Auto("Porsche GT", 400, 6, true), 
			new Auto("Fiat Punto", 60, 5, false), 
			new Auto("Renault", 55, 5, true), 
			new Auto("Lamborghini", 350, 6, false) 
			};

			fahrzeuge.Add(new Auto() { Name="Audi", Leistung=180, IsAutomatic=true, Gears=6 });
			fahrzeuge.Add(new Motorrad() { Name="Kawazaki Ninja", Leistung=180, AnzahlSitze=1 });
			fahrzeuge.Add(new Auto() { Name="VW Golf", Leistung=80, IsAutomatic=true, Gears=5 });
			fahrzeuge.Add(new Auto() { Name="Trabant", Leistung=40, IsAutomatic=false, Gears=4 });
			fahrzeuge.Add(new Motorrad() { Name="Verspa Roller", Leistung=30, AnzahlSitze=2 });

			foreach (var fz in fahrzeuge)
			{
				Console.WriteLine(fz.GetFahrzeugToString());
			}
			//Abfragen
			int anzahlVonAutos = fahrzeuge.Count(x => x.GetType().Name == "Auto");
			Console.WriteLine($"Anzahl aller Autos = {anzahlVonAutos}");
			int summePs = fahrzeuge.Where(x => x.GetType().Name == "Auto").Sum(x => x.Leistung);
			Console.WriteLine($"Summe der PS aller Autos = {summePs}");
			var sortiertAbstreigendNachPS = fahrzeuge.OrderByDescending(x => x.Leistung).ToList();
			Console.WriteLine("Fahrzeuge absteigend sortiert nach PS:");
			foreach (var fz in sortiertAbstreigendNachPS)
			{
				Console.WriteLine(fz.GetFahrzeugToString());
			}
			var zweiSchwaechstenAutos = fahrzeuge.OrderBy(x => x.Leistung).Where(x => x.GetType().Name == "Auto").Take(2);
			Console.WriteLine("Die zwei schwächsten Autos");
			foreach (var auto in zweiSchwaechstenAutos)
			{
				Console.WriteLine(auto.GetFahrzeugToString());
			}
			var durchschnittDerGaenge = fahrzeuge.Average(x => {
				if (x.GetType() == typeof(Auto))
				{
					return ((Auto)x).Gears;
				}
				else
				{
					return null;
				}
				});
			Console.WriteLine($"Durchschnitt der Gänge {durchschnittDerGaenge}");
			var anzahlAutomatik = fahrzeuge.Count(x => {
				if (x.GetType() == typeof(Auto))
				{
					if (((Auto)x).IsAutomatic)
						return true;
				}
				return false;
			}).CompareTo(fahrzeuge.Count(x => {
				if (x.GetType() == typeof(Auto))
				{
					if (!((Auto)x).IsAutomatic)
						return true;
				}
				return false;
			}));
			Console.WriteLine($"Ist die Anzahl von Automatik größer als die Anzahl von Nicht-Automatik (>0 größer, 0 gleich, <0 kleiner)? = {anzahlAutomatik}");

			// DELEGATES
			MakeOutput makeOutput = MakeOutputToConsole;
			makeOutput("thsss");
			makeOutput += MakeOutputToConsole;
			makeOutput += MakeOutputToConsole;
			makeOutput.Invoke("lalala");
			Console.WriteLine("----------------------");
			//-------------------------
			Say say = SayHello;
			say("Bob"); //Hello Bob
			say += SayHi; //Hello Max
			say("Max"); //Hi Max
			say.Invoke("Max");
			say -= SayHello;
			say("Anna"); //Ausgabe ohne SayHello Funktion.
			say -= SayHi;
			//say("Lisa"); //ERROR - pointer zeigt auf keine Methode!
		}
		public static void SayHi(string str)
		{
			Console.WriteLine("Hi " + str);
		}
	}
}
