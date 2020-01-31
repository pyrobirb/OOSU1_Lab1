using System;


namespace Business_layer
{
    public class Medlem
    {
		private string medlemsNummer;
		public string MedlemsNummer
		{
			get { return medlemsNummer; }
			set { medlemsNummer = value; }
		}

		private string namn;
		public string Namn
		{
			get { return namn; }
			set { namn = value; }
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



	}
}
