using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.DataRepository
{
    internal class BokRepository : IRepository<Bok>
    {
        List<Bok> bokLista { get; set; }

        public Bok HämtaMedID(string id)
        {
            foreach (Bok bok in bokLista)
            {
                if (bok.ISBNNummer == id)
                {
                    Bok hittadBok = bok;
                    return hittadBok;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public IEnumerable<Bok> HämtaAlla()
        {
            return bokLista;
        }

        public void LäggTill(Bok bok)
        {
            bokLista.Add(bok);

        }

        public void TaBort(Bok bok)
        {
            bokLista.Remove(bokLista.SingleOrDefault(b => b.ISBNNummer == bok.ISBNNummer));
        }

        public void Uppdatera(Bok bok)
        {
            bokLista.Remove(bokLista.SingleOrDefault(b => b.ISBNNummer == bok.ISBNNummer));
            bokLista.Add(bok);
        }
    }
}
