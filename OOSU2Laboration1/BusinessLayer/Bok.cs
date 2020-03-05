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
			private set { ISBNnummer = value; }
		}

		private string titel;
		public string Titel
		{
			get { return titel; }
			private set { titel = value; }
		}

		private string författare;
		public string Författare
		{
			get { return författare; }
			private set { författare = value; }
		}


		private int bokID;
		public int BokID
		{
			get { return bokID; }
			private set { bokID = value; }
		}

		public string BokTitelFörfattare
		{
			get { return ISBNNummer + " " + Författare + " - " + Titel; }
		}

		public Bok(string isbnnr, string titel, string författare, int bokID)
		{
			ISBNNummer = isbnnr;
			Titel = titel;
			Författare = författare;
			BokID = bokID;
		}
		
	}
}
