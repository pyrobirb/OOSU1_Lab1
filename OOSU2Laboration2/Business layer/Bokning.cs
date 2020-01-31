using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    class Bokning
    {
		private string bokningsNummer;
		public string BokningsNummer
		{
			get { return bokningsNummer; }
			set { bokningsNummer = value; }
		}

		private DateTime startDatum;
		public DateTime StartDatum
		{
			get { return startDatum; }
			set { startDatum = value; }
		}

		private DateTime slutDatum;
		public DateTime SlutDatum
		{
			get { return slutDatum; }
			set { slutDatum = value; }
		}

		private DateTime återlämningsDatum;
		public DateTime ÅterlämningsDatum
		{
			get { return återlämningsDatum; }
			set { återlämningsDatum = value; }
		}
	}
}
