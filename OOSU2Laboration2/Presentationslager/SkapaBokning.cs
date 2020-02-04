using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;


namespace Presentationslager
{
    public partial class SkapaBokning : Form
    {
        DataRepositoryManager Drm { get; set; }
        string inloggadAnvändare { get; set; }
        public SkapaBokning(DataRepositoryManager drm, string anvID)
        {
            InitializeComponent();
            Drm = drm;
            inloggadAnvändare = anvID;
            GenereraObjekt();
            UppdateraDataSourceRollAnvändare();
        }

        private void Meny_Load(object sender, EventArgs e)
        {

        }

        public string HämtaInloggadAnvändare()
        {
            List<Expedit> allaexpediter = (List<Expedit>)Drm.HämtaAllaExpediter();

            var expedit =
                (from exp in allaexpediter
                 where exp.AnställningsNummer == inloggadAnvändare
                 select exp.ExpeditFulltNamn).SingleOrDefault();

            return expedit;
        }
        public string HämtaInloggadAnvändareRoll()
        {
            List<Expedit> allaexpediter = (List<Expedit>)Drm.HämtaAllaExpediter();

            var expedit =
                (from exp in allaexpediter
                 where exp.AnställningsNummer == inloggadAnvändare
                 select exp.Roll).SingleOrDefault();

            return expedit;
        }

        public void UppdateraDataSourceRollAnvändare()
        {
            inloggadAnvändareLabel.Text = HämtaInloggadAnvändare();
            rollLabel.Text = HämtaInloggadAnvändareRoll();

            medlemComboBox.DataSource = Drm.HämtaAllaMedlemmar();
            medlemComboBox.DisplayMember = "MedlemFulltNamn";
            medlemComboBox.ValueMember = "MedlemsNummer";
        }

        #region genereraobjekt

        public void GenereraObjekt()
        {
            if ((Drm.HämtaAllaMedlemmar().Count() < 1) && (Drm.HämtaAllaBocker().Count() < 1))
            {

                //Medlemmar
                Medlem m1 = new Medlem("12", "Lars", "Kagge", "073019202", "Lars.Kagge@gmail.com", null);
                Medlem m2 = new Medlem("13", "Kalle", "Larsson", "073119202", "Kalle.Larsson@gmail.com", null);
                Medlem m3 = new Medlem("14", "Klara", "Lagge", "073018202", "Klara.Lagge@gmail.com", null);
                Medlem m4 = new Medlem("15", "Lila", "Nagge", "073010202", "Lila.Nagge@gmail.com", null);
                Medlem m5 = new Medlem("16", "Hagge", "Kagge", "073119202", "Hagge.Kagge@gmail.com", null);

                IEnumerable<Medlem> medlemmar = new List<Medlem>() { m1, m2, m3, m4, m5 };

                foreach (Medlem medlem in medlemmar)
                {
                    Drm.LäggTillMedlem(medlem);
                }


                //Böcker
                List<Bokning> tomBokningsLista = new List<Bokning>();
                Bok b1 = new Bok("1788478126", "C# 8.0 and .NET Core 3.0", "Mark J. Price", false, 1, tomBokningsLista);
                Bok b2 = new Bok("0134494164", "Clean Architecture", "Robert C. Martin", false, 2, tomBokningsLista); ;
                Bok b3 = new Bok("9780132350884", "Clean Code", "Robert C. Martin", false, 3, tomBokningsLista);
                Bok b4 = new Bok("0137081073", "The Clean Coder", "Robert C. Martin", false, 4, tomBokningsLista);
                Bok b5 = new Bok("1844132390", "Man's Search For Meaning", "Viktor E. Frankl", false, 5, tomBokningsLista);
                Bok b6 = new Bok("9780722532935", "The Alchemist", "Paul Coelho", false, 6, tomBokningsLista);
                Bok b7 = new Bok("9780316029186", "The Last Wish", "Andrzej Sapkowski", false, 7, tomBokningsLista);
                Bok b8 = new Bok("9780316029186", "The Last Wish", "Andrzej Sapkowski", false, 8, tomBokningsLista);

                IEnumerable<Bok> böcker = new List<Bok>() { b1, b2, b3, b4, b5, b6, b7, b8 };

                foreach (Bok bok in böcker)
                {
                    Drm.LäggTillBok(bok);
                }
            }

        }

        #endregion

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            TillbakaTillMeny();
        }

        public void TillbakaTillMeny()
        {
            Meny meny = new Meny(Drm, inloggadAnvändare);
            meny.Show();
            this.Hide();
        }

        private void tillgängligaBöckerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startDatumPicker_ValueChanged(object sender, EventArgs e)
        {
            tillgängligaBöckerListBox.DataSource = null;
            tillgängligaBöckerListBox.DataSource = GivenEttDatum_ReturneraEnListaMedTillgängligaBöcker(startDatumPicker.Value);
            tillgängligaBöckerListBox.DisplayMember = "BokTitelFörfattare";
            återlämningsDatumLabel.Text = startDatumPicker.Value.AddDays(14).ToString("dd/MMMM/yyyy");
        }

        public List<Bok> GivenEttDatum_ReturneraEnListaMedTillgängligaBöcker(DateTime valtStartDatum)
        {
            List<Bok> tillgängligaBöcker = (List<Bok>)Drm.HämtaAllaBocker();
            List<Bok> uppbokadeBöcker = new List<Bok>();
            List<Bokning> allaBokningar = (List<Bokning>)Drm.HämtaAllaBokningar();

            DateTime valtSlutDatum = valtStartDatum.AddDays(14);

            List<Bok> nyaTillgängligaBöcker = new List<Bok>();


            if (Drm.HämtaAllaBokningar().Any())
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
                


                //foreach (var Bok in böckerAttTaBort)
                //{
                //    foreach (Bok bok in tillgängligaBöcker)
                //    {
                //        if (Bok == bok)
                //        {
                //            tillgängligaBöcker.Remove(bok);
                //            break;
                //        }
                //    }
                //}

                //nyaTillgängligaBöcker = tillgängligaBöcker;





            }
            else
            {
                nyaTillgängligaBöcker = (List<Bok>)Drm.HämtaAllaBocker();

            }



            return nyaTillgängligaBöcker;
        }


        private void medlemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            medlemsIDlabel.Text = ((Medlem)medlemComboBox.SelectedItem).Medlemsnummer;
        }

        private void bokaBtn_Click(object sender, EventArgs e)
        {
            SparaBokning();
        }


        public void SparaBokning()
        {
            string bokningsnummer = (Drm.HämtaAllaBokningar().Count() + 1).ToString();
            var startDatum = startDatumPicker.Value;
            var slutDatum = startDatum.AddDays(14);
            var expedit = Drm.HämtaExpeditMedID(inloggadAnvändare);
            var medlem = (Medlem)medlemComboBox.SelectedItem;

            List<Bok> valdaBöcker = new List<Bok>();

            foreach (Bok bok in tillgängligaBöckerListBox.SelectedItems)
            {

                valdaBöcker.Add(bok);
            }



            Bokning b = new Bokning(bokningsnummer, startDatum, slutDatum, expedit, medlem, valdaBöcker);

            Drm.LäggTillBokning(b);
            LäggTillBokningTillBok(valdaBöcker, b);
        }

        public void LäggTillBokningTillBok(List<Bok> böcker, Bokning bokning)
        {
            foreach (Bok bok in böcker)
            {
                bok.BokningsLista.Add(bokning);
            }
        }

    }
}
