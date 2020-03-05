using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Faktura
    {
		Bokning faktureradBokning { get; set; }
		public List<Bok> faktureradeBöcker = new List<Bok>();

		private string fakturaNummer;

		public string FakturaNummer
		{
			get { return fakturaNummer; }
			private set { fakturaNummer = value; }
		}

		private int totalpris;
		public int Totalpris
		{
			get { return totalpris; }
			private set { totalpris = value; }
		}

		private DateTime startDatum;
		public DateTime StartDatum
		{
			get { return startDatum; }
			private set { startDatum = value; }
		}

		private DateTime förfallodatum;
		public DateTime FörfalloDatum
		{
			get { return förfallodatum; }
			private set { förfallodatum = value; }
		}
		public Faktura(string fakturanummer, int totalpris, DateTime startDatum, DateTime förfallodatum, Bokning bokning, List<Bok> återlämnadeBöcker)
		{
			FakturaNummer = fakturanummer;
			Totalpris = totalpris;
			StartDatum = startDatum;
			FörfalloDatum = förfallodatum;
			faktureradBokning = bokning;
			faktureradeBöcker = återlämnadeBöcker;
		}
	}
}
