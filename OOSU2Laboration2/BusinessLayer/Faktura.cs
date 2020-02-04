using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Faktura
    {
		Bokning faktureradBokning { get; set; }

		private string fakturaNummer;

		public string FakturaNummer
		{
			get { return fakturaNummer; }
			set { fakturaNummer = value; }
		}

		private int totalpris;
		public int Totalpris
		{
			get { return totalpris; }
			set { totalpris = value; }
		}

		private DateTime startDatum;
		public DateTime StartDatum
		{
			get { return startDatum; }
			set { startDatum = value; }
		}

		private DateTime förfallodatum;
		public DateTime FörfalloDatum
		{
			get { return förfallodatum; }
			set { förfallodatum = value; }
		}
		public Faktura(string fakturanummer, int totalpris, DateTime startDatum, DateTime förfallodatum, Bokning bokning)
		{
			FakturaNummer = fakturanummer;
			Totalpris = totalpris;
			StartDatum = startDatum;
			FörfalloDatum = förfallodatum;
			faktureradBokning = bokning;
		}
	}
}
