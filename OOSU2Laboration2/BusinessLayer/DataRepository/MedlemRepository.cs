using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.DataRepository
{
    internal class MedlemRepository : IRepository<Medlem>
    {
        List<Medlem> medlemmar = new List<Medlem>();
        public Medlem GetById(string id)
        {
            foreach (Medlem medlem in medlemmar)
            {
                if (medlem.MedlemsNummer == id)
                {
                    Medlem hittadMedlem = medlem;
                    return hittadMedlem;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public IEnumerable<Medlem> HämtaAlla()
        {
            return medlemmar;
        }

        public void LäggTill(Medlem medlem)
        {
            medlemmar.Add(medlem);
        }

        public void TaBort(Medlem medlem)
        {
            medlemmar.Remove(medlemmar.SingleOrDefault(m => m.MedlemsNummer == medlem.MedlemsNummer));
        }

        public void Uppdatera(Medlem medlem)
        {
            medlemmar.Remove(medlemmar.SingleOrDefault(m => m.MedlemsNummer == medlem.MedlemsNummer));
            medlemmar.Add(medlem);

        }
    }
}
