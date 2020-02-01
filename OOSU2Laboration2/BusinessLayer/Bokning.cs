using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Bokning
    {
		List<Bok> LånadeBöcker { get; set; }
		Expedit Expedit { get; set; }
		Medlem Medlem { get; set; }
		List<Faktura> FakturaLista = new List<Faktura>();

		private string bokningsNummer;
		public string BokningsNummer
		{
			get { return bokningsNummer; }
			set { bokningsNummer = value; }
		}

		//DateTime.Now.ToString("MM/dd/yyyy")
		private DateTime startDatum;
		public DateTime StartDatum
		{
			get { return startDatum; }
			set { startDatum = value; }
		}
		//DateTime.AddMonths(Int32) Method
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

		public Bokning(string bokningsnummer, DateTime startDatum, List<Bok> lånadeBöcker, Expedit expedit, Medlem medlem )
		{
			BokningsNummer = bokningsnummer;
			StartDatum = startDatum;
			LånadeBöcker = lånadeBöcker;
			Expedit = expedit;
			Medlem = medlem;
		}
		
	}
}
