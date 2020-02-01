using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Bok
    {
		
		private string ISBNnummer;
		public string ISBNNummer
		{
			get { return ISBNnummer; }
			set { ISBNnummer = value; }
		}

		private string titel;
		public string Titel
		{
			get { return titel; }
			set { titel = value; }
		}

		private bool utlånad;
		public bool Utlånad
		{
			get { return utlånad; }
			set { utlånad = value; }
		}

		private int antalKopior;
		public int AntalKopior
		{
			get { return antalKopior; }
			set { antalKopior = value; }
		}

		public Bok(string isbnnr, string titel, bool utlånad, int antalkopior)
		{
			ISBNNummer = isbnnr;
			Titel = titel;
			Utlånad = utlånad;
			AntalKopior = antalkopior;
		}
		
	}
}
