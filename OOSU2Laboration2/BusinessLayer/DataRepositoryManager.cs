using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DataRepositoryManager
    {
        DataRepository.BokningRepository BoknRep = new DataRepository.BokningRepository();
        DataRepository.BokRepository BokRep = new DataRepository.BokRepository();
        DataRepository.ExpeditRepository ExpRep = new DataRepository.ExpeditRepository();
        DataRepository.FakturaRepository FakRep = new DataRepository.FakturaRepository();
        DataRepository.MedlemRepository MedRep = new DataRepository.MedlemRepository();

        #region Bokning
        public IEnumerable<Bokning> HämtaAllaBokningar()
        {
            return BoknRep.HämtaAlla();
        }

        public Bokning GetBokningByID(string id)
        {
            return BoknRep.HämtaMedID(id);
        }

        public void LäggTillBokning(Bokning bokning)
        {
            BoknRep.LäggTill(bokning);
        }

        public void TaBortBokning(Bokning bokning)
        {
            BoknRep.TaBort(bokning);
        }

        public void UppdateraBokning(Bokning bokning)
        {
            BoknRep.Uppdatera(bokning);
        }

        #endregion

        #region Bok
        public IEnumerable<Bok> HämtaAllaBocker()
        {
            return BokRep.HämtaAlla();
        }

        public Bok GetBokByID(string id)
        {
            return BokRep.HämtaMedID(id);
        }

        public void LäggTillBok(Bok bok)
        {
            BokRep.LäggTill(bok);
        }

        public void TaBortBok(Bok bok)
        {
            BokRep.TaBort(bok);
        }

        public void UppdateraBok(Bok bok)
        {
            BokRep.Uppdatera(bok);
        }
        #endregion

        #region Expedit
        public IEnumerable<Expedit> HämtaAllaExpediter()
        {
            return ExpRep.HämtaAlla();
        }

        public Expedit GetExpeditByID(string id)
        {
            return ExpRep.HämtaMedID(id);
        }

        public void LäggTillExpedit(Expedit expedit)
        {
            ExpRep.LäggTill(expedit);
        }

        public void TaBortExpedit(Expedit expedit)
        {
            ExpRep.TaBort(expedit);
        }

        public void UppdateraExpedit(Expedit expedit)
        {
            ExpRep.Uppdatera(expedit);
        }

        #endregion

        #region Faktura
        public IEnumerable<Faktura> HämtaAllaFakturor()
        {
            return FakRep.HämtaAlla();
        }

        public Faktura GetFakturaByID(string id)
        {
            return FakRep.HämtaMedID(id);
        }

        public void LäggTillExpedit(Faktura faktura)
        {
            FakRep.LäggTill(faktura);
        }

        public void TaBortExpedit(Faktura faktura)
        {
            FakRep.TaBort(faktura);
        }

        public void UppdateraExpedit(Faktura faktura)
        {
            FakRep.Uppdatera(faktura);
        }

        #endregion

        #region Medlem

        public IEnumerable<Medlem> HämtaAllaMedlemmar()
        {
            return MedRep.HämtaAlla();
        }
        
        public Medlem GetMedlemByID(string id)
        {
            return MedRep.HämtaMedID(id);
        }

        public void LäggTillExpedit(Medlem medlem)
        {
            MedRep.LäggTill(medlem);
        }

        public void TaBortExpedit(Medlem medlem)
        {
            MedRep.TaBort(medlem);
        }

        public void UppdateraExpedit(Medlem medlem)
        {
            MedRep.Uppdatera(medlem);
        }

        #endregion
    }
}
