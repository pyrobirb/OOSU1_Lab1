using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    class Expedit
    {
		private string anställningsNummer;
		public string AnställningsNummer
		{
			get { return anställningsNummer; }
			set { anställningsNummer = value; }
		}

		private string namn;
		public string Namn
		{
			get { return namn; }
			set { namn = value; }
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
	}
}
