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
    public partial class Bokning : Form
    {
        DataRepositoryManager Drm { get; set; }
        public Bokning(DataRepositoryManager drm)
        {
            InitializeComponent();
            Drm = drm;
            GenereraObjekt();
            UppdateraDatasources();
        }

        private void Meny_Load(object sender, EventArgs e)
        {

        }

        public void UppdateraDatasources()
        {
            tillgängligaBöckerListBox.DataSource = Drm.HämtaAllaBocker();
            tillgängligaBöckerListBox.DisplayMember = "BokTitelFörfattare";
            tillgängligaBöckerListBox.ValueMember = "ISBNNummer";

            medlemComboBox.DataSource = Drm.HämtaAllaMedlemmar();
            medlemComboBox.DisplayMember = "MedlemFulltNamn";
            medlemComboBox.ValueMember = "MedlemsNummer";
        }

        #region genereraobjekt

        public void GenereraObjekt()
        {

            //Medlemmar
            Medlem m1 = new Medlem("12", "Lars", "Kagge", "073019202", "Lars.Kagge@gmail.com", null);
            Medlem m2 = new Medlem("13", "Kalle", "Larsson", "073119202", "Kalle.Larsson@gmail.com", null);
            Medlem m3 = new Medlem("14", "Klara", "Lagge", "073018202", "Klara.Lagge@gmail.com", null);
            Medlem m4 = new Medlem("15", "Lila", "Nagge", "073010202", "Lila.Nagge@gmail.com", null);
            Medlem m5 = new Medlem("16", "Hagge", "Kagge", "073119202", "Hagge.Kagge@gmail.com", null);

            IEnumerable<Medlem> medlemmar = new List<Medlem>() { m1,m2,m3,m4,m5 };

            foreach (Medlem medlem in medlemmar)
            {
                Drm.LäggTillMedlem(medlem);
            }
            

            //Böcker
            Bok b1 = new Bok("1788478126", "C# 8.0 and .NET Core 3.0", "Mark J. Price", false, 2);
            Bok b2 = new Bok("0134494164", "Clean Architecture", "Robert C. Martin", false, 3);;
            Bok b3 = new Bok("9780132350884", "Clean Code", "Robert C. Martin", false, 2);
            Bok b4 = new Bok("0137081073", "The Clean Coder", "Robert C. Martin", false, 1);
            Bok b5 = new Bok("1844132390", "Man's Search For Meaning","Viktor E. Frankl", false, 4);
            Bok b6 = new Bok("9780722532935", "The Alchemist","Paul Coelho", false, 2);
            Bok b7 = new Bok("9780316029186", "The Last Wish", "Andrzej Sapkowski", false, 1);

            IEnumerable<Bok> böcker = new List<Bok>() { b1, b2, b3, b4, b5, b6, b7 };

            foreach (Bok bok in böcker)
            {
                Drm.LäggTillBok(bok);
            }

        }

        #endregion

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            TillbakaTillMeny();
        }

        public void TillbakaTillMeny()
        {
            
                Meny meny = new Meny(Drm);
                meny.Show();
                this.Hide();
            
        }

        private void tillgängligaBöckerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
