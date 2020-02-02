﻿using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer
{
    public class Medlem
    {
		List<Bokning> BokningsLista = new List<Bokning>();

		private string medlemsnummer;
		public string Medlemsnummer
		{
			get { return medlemsnummer; }
			set { medlemsnummer = value; }
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

		public string MedlemFulltNamn
		{
			get { return FörNamn + " " + EfterNamn; }
		}

		public Medlem(string medlemsnummer, string förnamn, string efternamn, string telefonnummer, string epost, List<Bokning> bokningsLista)
		{
			Medlemsnummer = medlemsnummer;
			FörNamn = förnamn;
			EfterNamn = efternamn;
			Telefonnummer = telefonnummer;
			Epost = epost;
			BokningsLista = bokningsLista;
		}

	}
}
