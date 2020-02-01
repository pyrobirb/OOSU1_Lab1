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

		private string förNamn;
		public string FörNamn
		{
			get { return förNamn; }
			set { förNamn = value; }
		}
		private string efterNamn;
		public string EfterNamn
		{
			get { return efterNamn; }
			set { efterNamn = value; }
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

		public string ExpeditFullName()
		{
			return FörNamn + " " + EfterNamn;
		}

		public Expedit(string anställningsnummer, string förnamn, string efternamn, string lösenord, string roll)
		{
			AnställningsNummer = anställningsnummer;
			FörNamn = förnamn;
			EfterNamn = efternamn;
			Lösenord = lösenord;
			Roll = roll;
		}
	}
}
