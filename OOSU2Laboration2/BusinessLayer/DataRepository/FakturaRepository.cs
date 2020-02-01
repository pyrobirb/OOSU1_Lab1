using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DataRepository
{
    class FakturaRepository : IRepository<Faktura>
    {
        public Faktura GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Faktura> HämtaAlla()
        {
            throw new NotImplementedException();
        }

        public void LäggTill(Faktura entity)
        {
            throw new NotImplementedException();
        }

        public void TaBort(Faktura entity)
        {
            throw new NotImplementedException();
        }

        public void Uppdatera(Faktura entity)
        {
            throw new NotImplementedException();
        }
    }
}
