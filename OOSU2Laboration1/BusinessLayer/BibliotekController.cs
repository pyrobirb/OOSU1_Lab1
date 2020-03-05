using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BibliotekController
    {
        public static string inloggadExpeditID { get; set; }

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

        public Bokning HämtaBokningMedID(string id)
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

        public Expedit HämtaExpeditMedID(string id)
        {
            return ExpRep.HämtaMedID(id);
        }
        public int BeräknaTotalPris(List<Bok> böcker, DateTime återlämningsDatum, Bokning bokning)
        {

            foreach (Bok bok in böcker)
            {
                if (återlämningsDatum > bokning.SlutDatum)
                {
                    int TotalPris = Convert.ToInt32(((återlämningsDatum - bokning.SlutDatum).TotalDays)) * 10;
                    return TotalPris;

                }
            }
            return 0;
        }

        public Faktura ÅterlämnaMarkeradeBöckerOchGenereraFaktura(Bokning valdBokning, List<Bok> valdaBöcker)
        {
            var återlämningsDatum = DateTime.Now;

            //faktura
            int fakturaID;
            if (valdBokning.FakturaLista == null)
            {
                fakturaID = 0;
            }
            else
            {
                fakturaID = valdBokning.FakturaLista.Count();
            }


            string fakturaNummer = valdBokning.BokningsNummer + fakturaID.ToString();

            var nyaTotalPriset = BeräknaTotalPris(valdaBöcker, återlämningsDatum, valdBokning);

            var förfalloDatum = återlämningsDatum.AddDays(30);
            Faktura f = new Faktura(fakturaNummer, nyaTotalPriset, återlämningsDatum, förfalloDatum, valdBokning, valdaBöcker);

            LäggTillFaktura(f);

            return f;

        }

        public string HämtaInloggadExpedit()
        {
            List<Expedit> allaexpediter = (List<Expedit>)HämtaAllaExpediter();

            var expedit =
                (from exp in allaexpediter
                 where exp.AnställningsNummer == BibliotekController.inloggadExpeditID
                 select exp.ExpeditFulltNamn).SingleOrDefault();

            return expedit;
        }

        public void LäggTillExpedit(Expedit expedit)
        {
            ExpRep.LäggTill(expedit);
        }

        public bool KontrolleraInloggning(string användarID, string Lösenord)
        {
            var expediter = HämtaAllaExpediter();

            if ((användarID != null) || (Lösenord != null))
            {
                foreach (var expedit in expediter)
                {
                    if ((användarID == expedit.AnställningsNummer) && (Lösenord == expedit.Lösenord))
                    {
                        return true;
                    }
                }
                return false;
            }
            else return false;
        }

        public void TaBortExpedit(Expedit expedit)
        {
            ExpRep.TaBort(expedit);
        }

        public void UppdateraExpedit(Expedit expedit)
        {
            ExpRep.Uppdatera(expedit);
        }

        public void SättInloggadExpedit(string anställningsNummer)
        {
            BibliotekController.inloggadExpeditID = anställningsNummer;
        }

        #endregion

        #region Faktura
        public IEnumerable<Faktura> HämtaAllaFakturor()
        {
            return FakRep.HämtaAlla();
        }

        public Faktura HämtaFakturaMedID(string id)
        {
            return FakRep.HämtaMedID(id);
        }

        public void LäggTillFaktura(Faktura faktura)
        {
            FakRep.LäggTill(faktura);
        }

        public void TaBortFaktura(Faktura faktura)
        {
            FakRep.TaBort(faktura);
        }

        public List<Bok> GivenEttDatum_ReturneraEnListaMedTillgängligaBöcker(DateTime valtStartDatum)
        {

            List<Bok> tillgängligaBöcker = (List<Bok>)HämtaAllaBocker();
            List<Bok> uppbokadeBöcker = new List<Bok>();
            List<Bokning> allaBokningar = (List<Bokning>)HämtaAllaBokningar();

            DateTime valtSlutDatum = valtStartDatum.AddDays(14);

            List<Bok> nyaTillgängligaBöcker = new List<Bok>();


            if (HämtaAllaBokningar().Any())
            {
                foreach (Bokning bokning in allaBokningar)
                {
                    foreach (Bok lånadBok in bokning.LånadeBöcker)
                    {
                        if (!(((bokning.SlutDatum < valtStartDatum) && (bokning.StartDatum < valtStartDatum)) || ((bokning.StartDatum > valtSlutDatum && bokning.SlutDatum > valtSlutDatum))))
                        {
                            uppbokadeBöcker.Add(lånadBok);
                        }
                    }
                }

                IEnumerable<Bok> båda = tillgängligaBöcker.Except(uppbokadeBöcker).ToList();

                nyaTillgängligaBöcker = (List<Bok>)båda.ToList();
            }
            else
            {
                nyaTillgängligaBöcker = (List<Bok>)HämtaAllaBocker();
            }
            return nyaTillgängligaBöcker;
        }

        public void UppdateraFaktura(Faktura faktura)
        {
            FakRep.Uppdatera(faktura);
        }

        #endregion

        #region Medlem

        public IEnumerable<Medlem> HämtaAllaMedlemmar()
        {
            return MedRep.HämtaAlla();
        }

        public Medlem HämtaMedlemMedID(string id)
        {
            return MedRep.HämtaMedID(id);
        }

        public void LäggTillMedlem(Medlem medlem)
        {
            MedRep.LäggTill(medlem);
        }

        public void TaBortMedlem(Medlem medlem)
        {
            MedRep.TaBort(medlem);
        }

        public void UppdateraMedlem(Medlem medlem)
        {
            MedRep.Uppdatera(medlem);
        }

        public Bokning SparaBokning(string medlemsnummer, IEnumerable<Bok> selectedItems, DateTime startdatum)
        {
            
                string bokningsnummer = (HämtaAllaBokningar().Count() + 1).ToString();
                var startDatum = startdatum;
                var slutDatum = startDatum.AddDays(14);
                var expedit = HämtaExpeditMedID(BibliotekController.inloggadExpeditID);
                var medlem = HämtaMedlemMedID(medlemsnummer);

                List<Bok> valdaBöcker = new List<Bok>();

                foreach (Bok bok in selectedItems)
                {
                    valdaBöcker.Add(bok);
                }



                Bokning b = new Bokning(bokningsnummer, startDatum, slutDatum, expedit, medlem, valdaBöcker);

                LäggTillBokning(b);
                return b;
            
        }

        #endregion
    }
}
