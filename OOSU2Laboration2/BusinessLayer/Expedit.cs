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
			set { anställningsNummer = value; }
		}

		private string förnamn;
		public string Förnamn
		{
			get { return förnamn; }
			set { förnamn = value; }
		}
		private string efternamn;
		public string Efternamn
		{
			get { return efternamn; }
			set { efternamn = value; }
		}

		private string lösenord;
		public string Lösenord
		{
			get { return lösenord; }
			set { lösenord = value; }
		}

		private string roll;
		public string Roll
		{
			get { return roll; }
			set { roll = value; }
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
