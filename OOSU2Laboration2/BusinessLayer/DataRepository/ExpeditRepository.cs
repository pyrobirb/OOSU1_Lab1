using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DataRepository
{
    internal class ExpeditRepository : IRepository<Expedit>
    {
        List<Expedit> expediterLista { get; set; }
        public Expedit GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expedit> HämtaAlla()
        {
            return expediterLista;
        }

        public void LäggTill(Expedit entity)
        {
            throw new NotImplementedException();
        }

        public void TaBort(Expedit entity)
        {
            throw new NotImplementedException();
        }

        public void Uppdatera(Expedit entity)
        {
            throw new NotImplementedException();
        }
    }
}
