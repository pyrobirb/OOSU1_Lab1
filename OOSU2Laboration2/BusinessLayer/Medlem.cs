using System;


namespace BusinessLayer
{
    public class Medlem
    {
		private string medlemsNummer;
		public string MedlemsNummer
		{
			get { return medlemsNummer; }
			set { medlemsNummer = value; }
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

		private string telefonnummer;
		public string Telefonnummer
		{
			get { return telefonnummer; }
			set { telefonnummer = value; }
		}

		private string epost;
		public string Epost
		{
			get { return epost; }
			set { epost = value; }
		}

		public string MedlemFullName()
		{
			return FörNamn + " " + EfterNamn;
		}


	}
}
