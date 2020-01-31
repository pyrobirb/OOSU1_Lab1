using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer.Repository
{
    class BokningRepository
    {
		private List<Bok> bokLista;
		public List<Bok> BokLista
		{
			get { return bokLista; }
			set { bokLista = value; }
		}

		Expedit Expedit { get; set; }


	}
}
