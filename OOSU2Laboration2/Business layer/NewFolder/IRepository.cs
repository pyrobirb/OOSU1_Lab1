using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    interface IRepository <T>
    {
        void LäggTill(T entity); //create
        IEnumerable<T> HämtaAlla(); //read
        T GetById(string id);
        void Uppdatera(T entity);
        void TaBort(T entity); //delete

    }
}
