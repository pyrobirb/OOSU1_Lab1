using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DataRepository
{
    class BokningRepository : IRepository<Bokning>
    {
		List<Bok> bokLista { get; set; }
		List<Bokning> bokningarLista { get; set; }
		Expedit Expedit { get; set; }
		Medlem Medlem { get; set; }
		List<Faktura> FakturaLista { get; set; }

		public Bokning GetById(string id)
		{
			foreach (Bokning bokn in bokningarLista)
			{
				if (bokn.BokningsNummer == id)
				{
					Bokning hittadBokn = bokn;
					return hittadBokn;
				}
				else
				{
					return null;
				}
			}
			return null;
		}

		public IEnumerable<Bokning> HämtaAlla()
		{
			return bokningarLista;
		}

		public void LäggTill(Bokning entity)
		{
			throw new NotImplementedException();
		}

		public void TaBort(Bokning entity)
		{
			throw new NotImplementedException();
		}

		public void Uppdatera(Bokning entity)
		{
			throw new NotImplementedException();
		}
	}
}
