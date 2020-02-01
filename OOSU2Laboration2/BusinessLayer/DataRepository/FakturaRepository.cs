using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.DataRepository
{
    internal class FakturaRepository : IRepository<Faktura>
    {
        List<Faktura> fakturorLista { get; set; }
        public Faktura GetById(string id)
        {
            foreach (Faktura faktura in fakturorLista)
            {
                if (faktura.FakturaNummer == id)
                {
                    Faktura hittadFaktura = faktura;
                    return hittadFaktura;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public IEnumerable<Faktura> HämtaAlla()
        {
            return fakturorLista ;
        }

        public void LäggTill(Faktura faktura)
        {
            fakturorLista.Add(faktura);
        }

        public void TaBort(Faktura faktura)
        {
            fakturorLista.Remove(fakturorLista.SingleOrDefault(f => f.FakturaNummer == faktura.FakturaNummer));
        }

        public void Uppdatera(Faktura faktura)
        {
            fakturorLista.Remove(fakturorLista.SingleOrDefault(f => f.FakturaNummer == faktura.FakturaNummer));
            fakturorLista.Add(faktura);

        }
    }
}
