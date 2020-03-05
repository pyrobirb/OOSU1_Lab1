using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Expedit
    {
		private string anställningsNummer;
		public string AnställningsNummer
		{
			get { return anställningsNummer; }
			private set { anställningsNummer = value; }
		}

		private string förnamn;
		public string Förnamn
		{
			get { return förnamn; }
			private set { förnamn = value; }
		}
		private string efternamn;
		public string Efternamn
		{
			get { return efternamn; }
			private set { efternamn = value; }
		}

		private string lösenord;
		public string Lösenord
		{
			get { return lösenord; }
			private set { lösenord = value; }
		}

		private string roll;
		public string Roll
		{
			get { return roll; }
			private set { roll = value; }
		}

		public string ExpeditFulltNamn
		{
			get { return Förnamn + " " + Efternamn; }
		}

		public Expedit(string anställningsnummer, string förnamn, string efternamn, string lösenord, string roll)
		{
			AnställningsNummer = anställningsnummer;
			Förnamn = förnamn;
			Efternamn = efternamn;
			Lösenord = lösenord;
			Roll = roll;
		}
	}
}
