using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.DataRepository
{
    internal class BokningRepository : IRepository<Bokning>
    {

		List<Bokning> bokningarLista = new List<Bokning>();
		

		public Bokning HämtaMedID(string id)
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

		public void LäggTill(Bokning bokning)
		{
			bokningarLista.Add(bokning);
		}

		public void TaBort(Bokning bokning)
		{
			bokningarLista.Remove(bokningarLista.SingleOrDefault(b => b.BokningsNummer == bokning.BokningsNummer));
		}

		public void Uppdatera(Bokning bokning)
		{
			bokningarLista.Remove(bokningarLista.SingleOrDefault(b => b.BokningsNummer == bokning.BokningsNummer));
			bokningarLista.Add(bokning);
		}
	}
}
