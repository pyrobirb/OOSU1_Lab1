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
                Bok b1 = new Bok("1788478126", "C# 8.0 and .NET Core 3.0", "Mark J. Price", false, 2, null);
                Bok b2 = new Bok("0134494164", "Clean Architecture", "Robert C. Martin", false, 3, null); ;
                Bok b3 = new Bok("9780132350884", "Clean Code", "Robert C. Martin", false, 2, null);
                Bok b4 = new Bok("0137081073", "The Clean Coder", "Robert C. Martin", false, 1, null);
                Bok b5 = new Bok("1844132390", "Man's Search For Meaning", "Viktor E. Frankl", false, 4, null);
                Bok b6 = new Bok("9780722532935", "The Alchemist", "Paul Coelho", false, 2, null);
                Bok b7 = new Bok("9780316029186", "The Last Wish", "Andrzej Sapkowski", false, 1, null);

                IEnumerable<Bok> böcker = new List<Bok>() { b1, b2, b3, b4, b5, b6, b7 };

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
            tillgängligaBöckerListBox.DataSource = GivenEttDatum_ReturneraEnListaMedTillgängligaBöcker(startDatumPicker.Value);
            tillgängligaBöckerListBox.DisplayMember = "BokTitelFörfattare";
            återlämningsDatumLabel.Text = startDatumPicker.Value.AddDays(14).ToString("dd/MMMM/yyyy");
        }

        public List<Bok> GivenEttDatum_ReturneraEnListaMedTillgängligaBöcker(DateTime valtStartDatum)
        {
            List<Bok> tillgängligaBöcker = new List<Bok>();


            //foreach (var bokning in Drm.HämtaAllaBokningar())
            //{
            //    foreach (var bok in bokning.LånadeBöcker)
            //    {
            //        if ((valtStartDatum > bokning.SlutDatum) && (valtStartDatum < bokning.StartDatum) && (bok.AntalKopior > 0))
            //        {
            //            tillgängligaBöcker.Add(bok);
            //        }
            //    }
            //}

            foreach (Bok bok in Drm.HämtaAllaBocker())
            {
                if ((bok.BokningsLista == null) && (bok.AntalKopior > 0))
                {
                    tillgängligaBöcker.Add(bok);
                }
            }
            return tillgängligaBöcker;
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
            var expedit = Drm.HämtaExpeditMedID(inloggadAnvändare);
            var medlem = (Medlem)medlemComboBox.SelectedItem;
            List<Bok> valdaBöcker = (List<Bok>)tillgängligaBöckerListBox.SelectedItems.Cast<Bok>();

            Bokning b = new Bokning(bokningsnummer, startDatum, expedit, medlem, valdaBöcker);

            Drm.LäggTillBokning(b);
            LäggTillBokningTillBok(valdaBöcker,b);
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
