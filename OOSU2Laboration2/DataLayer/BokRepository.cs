using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    class BokRepository : IRepository<Bok>
    {
        List<Bok> bokLista { get; set; }

        public Bok GetById(string id)
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
            throw new NotImplementedException();
        }

        public void LäggTill(Bok entity)
        {
            throw new NotImplementedException();
        }

        public void TaBort(Bok entity)
        {
            throw new NotImplementedException();
        }

        public void Uppdatera(Bok entity)
        {
            throw new NotImplementedException();
        }
    }
}
