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
        BibliotekController BibliotekController { get; set; }
        public SkapaBokning(BibliotekController bibliotekController)
        {
            InitializeComponent();
            BibliotekController = bibliotekController;
            GenereraObjekt();
            UppdateraDataSourceRollAnvändare();
        }

        private void Meny_Load(object sender, EventArgs e)
        {

        }

        public void UppdateraDataSourceRollAnvändare()
        {
            inloggadAnvändareLabel.Text = BibliotekController.HämtaExpeditMedID(GLOBALS.inloggadExpeditID).ExpeditFulltNamn;
            rollLabel.Text = BibliotekController.HämtaExpeditMedID(GLOBALS.inloggadExpeditID).Roll;

            medlemComboBox.DataSource = BibliotekController.HämtaAllaMedlemmar();
            medlemComboBox.DisplayMember = "MedlemFulltNamn";
            medlemComboBox.ValueMember = "MedlemsNummer";
        }

        #region genereraobjekt

        public void GenereraObjekt()
        {
            if ((BibliotekController.HämtaAllaMedlemmar().Count() < 1) && (BibliotekController.HämtaAllaBocker().Count() < 1))
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
                    BibliotekController.LäggTillMedlem(medlem);
                }


                //Böcker
                Bok b1 = new Bok("1788478126", "C# 8.0 and .NET Core 3.0", "Mark J. Price", 1);
                Bok b2 = new Bok("0134494164", "Clean Architecture", "Robert C. Martin", 2); ;
                Bok b3 = new Bok("9780132350884", "Clean Code", "Robert C. Martin", 3);
                Bok b4 = new Bok("0137081073", "The Clean Coder", "Robert C. Martin", 4);
                Bok b5 = new Bok("1844132390", "Man's Search For Meaning", "Viktor E. Frankl", 5);
                Bok b6 = new Bok("9780722532935", "The Alchemist", "Paul Coelho", 6);
                Bok b7 = new Bok("9780316029186", "The Last Wish", "Andrzej Sapkowski", 7);
                Bok b8 = new Bok("9780316029186", "The Last Wish", "Andrzej Sapkowski", 8);

                IEnumerable<Bok> böcker = new List<Bok>() { b1, b2, b3, b4, b5, b6, b7, b8 };
                foreach (Bok bok in böcker)
                {
                    BibliotekController.LäggTillBok(bok);
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
            Meny meny = new Meny(BibliotekController);
            meny.Show();
            this.Hide();
        }

        private void tillgängligaBöckerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startDatumPicker_ValueChanged(object sender, EventArgs e)
        {
            tillgängligaBöckerListBox.DataSource = null;
            tillgängligaBöckerListBox.DataSource = BibliotekController.GivenEttDatum_ReturneraEnListaMedTillgängligaBöcker(startDatumPicker.Value);
                
            tillgängligaBöckerListBox.DisplayMember = "BokTitelFörfattare";
            återlämningsDatumLabel.Text = startDatumPicker.Value.AddDays(14).ToString("dd/MMMM/yyyy");
            GömBokningsID();
        }
  
        private void medlemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            medlemsIDlabel.Text = ((Medlem)medlemComboBox.SelectedItem).Medlemsnummer;
        }

        private void bokaBtn_Click(object sender, EventArgs e)
        {
            List<Bok> valdaBöcker = new List<Bok>();

            foreach (Bok bok in tillgängligaBöckerListBox.SelectedItems)
            {
                valdaBöcker.Add(bok);
            }

            SkrivUtBokningsID(BibliotekController.SparaBokning(((Medlem)medlemComboBox.SelectedItem).Medlemsnummer, valdaBöcker, startDatumPicker.Value));
            
        }
        public void SkrivUtBokningsID(Bokning bokning)
        {
            bokningSkapadMeddelande.Text = "Din bokning är skapad med bokningsID: " + bokning.BokningsNummer;
        }
        public void GömBokningsID()
        {
            bokningSkapadMeddelande.Text = "";

        }
    }
}
