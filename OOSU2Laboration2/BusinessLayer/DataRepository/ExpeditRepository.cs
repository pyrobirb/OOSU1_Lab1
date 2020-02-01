using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.DataRepository
{
    internal class ExpeditRepository : IRepository<Expedit>
    {
        List<Expedit> expediterLista { get; set; }
        public Expedit HämtaMedID(string id)
        {
            foreach (Expedit expedit in expediterLista)
            {
                if (expedit.AnställningsNummer == id)
                {
                    Expedit hittadExpedit = expedit;
                    return hittadExpedit;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public IEnumerable<Expedit> HämtaAlla()
        {
            return expediterLista;
        }

        public void LäggTill(Expedit expedit)
        {
            expediterLista.Add(expedit);
        }

        public void TaBort(Expedit expedit)
        {
            expediterLista.Remove(expediterLista.SingleOrDefault(e => e.AnställningsNummer == expedit.AnställningsNummer));
        }

        public void Uppdatera(Expedit expedit)
        {
            expediterLista.Remove(expediterLista.SingleOrDefault(e => e.AnställningsNummer == expedit.AnställningsNummer));
            expediterLista.Add(expedit);
        }
    }
}
