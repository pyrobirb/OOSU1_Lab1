using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DataRepository
{
    class MedlemRepository : IRepository<Medlem>
    {
        public Medlem GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Medlem> HämtaAlla()
        {
            throw new NotImplementedException();
        }

        public void LäggTill(Medlem entity)
        {
            throw new NotImplementedException();
        }

        public void TaBort(Medlem entity)
        {
            throw new NotImplementedException();
        }

        public void Uppdatera(Medlem entity)
        {
            throw new NotImplementedException();
        }
    }
}
