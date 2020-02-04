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
    public partial class ÅterlämningAvBöcker : Form
    {
        DataRepositoryManager Drm { get; set; }
        string inloggadAnvändare { get; set; }

        public ÅterlämningAvBöcker(DataRepositoryManager drm, string anvID)
        {
            InitializeComponent();
            Drm = drm;
            inloggadAnvändare = anvID;
            UppdateraBokingsLista();
        }

        public void UppdateraBokingsLista()
        {
            allaBokningarcomboBox.DataSource = Drm.HämtaAllaBokningar();
            allaBokningarcomboBox.DisplayMember = "BokningsNummer";
            allaBokningarcomboBox.ValueMember = "BokningsNummer";
        }
        private void allaBokningarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            allaBöckerPåBoknListBox.DataSource = ReturneraBöckerPåBokning((Bokning)allaBokningarcomboBox.SelectedItem);
            allaBöckerPåBoknListBox.DisplayMember = "BokTitelFörfattare";
            UppdateraFakturaComboBox();
        }

        public List<Bok> ReturneraBöckerPåBokning(Bokning b)
        {
            return b.LånadeBöcker;
        }
        private void ÅterlämningAvBöcker_Load(object sender, EventArgs e)
        {

        }

        private void tillbakaBtn_Click(object sender, EventArgs e)
        {
            TillbakaTillMeny();
        }
        public void TillbakaTillMeny()
        {
            Meny meny = new Meny(Drm, inloggadAnvändare);
            meny.Show();
            this.Hide();
        }

        private void återlämningBtn_Click(object sender, EventArgs e)
        {
            var valdBokning = (Bokning)allaBokningarcomboBox.SelectedItem;
            List<Bok> valdaBöcker = new List<Bok>();
            var återlämningsDatum = DateTime.Now;


            foreach (Bok bok in allaBöckerPåBoknListBox.SelectedItems)
            {
                valdaBöcker.Add(bok);
            }

            //faktura
            string fakturaNummer = valdBokning.BokningsNummer + 1000;

            var nyaTotalPriset = BeräknaTotalPris(valdaBöcker, återlämningsDatum, valdBokning);

            var förfalloDatum = återlämningsDatum.AddDays(30);
            Faktura f = new Faktura(fakturaNummer, nyaTotalPriset, återlämningsDatum, förfalloDatum, valdBokning, valdaBöcker);

            Drm.LäggTillFaktura(f);

            if (valdBokning.FakturaLista == null || valdBokning.FakturaLista.Count() == 0)
            {
                List<Faktura> fList = new List<Faktura>();
                fList.Add(f);
                valdBokning.FakturaLista = fList;
            }
            else
            {
                valdBokning.FakturaLista.Add(f);
            }

            //Boklistor
            UppdateraBoklistor(valdaBöcker, valdBokning);


            UppdateraFakturaComboBox();
            UppdateraListBoxar();
        }

        public void UppdateraListBoxar()
        {
            allaBöckerPåBoknListBox.DataSource = null;
            allaBöckerPåBoknListBox.DataSource = ((Bokning)allaBokningarcomboBox.SelectedItem).LånadeBöcker;
            fakturaÅterlämnadeböckerListBox.DataSource = null;
            fakturaÅterlämnadeböckerListBox.DataSource = ((Faktura)FakturorComboBox.SelectedItem).faktureradeBöcker;

        }
        public void UppdateraFakturaComboBox() 
        {
            FakturorComboBox.DataSource = ((Bokning)allaBokningarcomboBox.SelectedItem).FakturaLista;
            FakturorComboBox.DisplayMember = "FakturaNummer";
        }


        public void UppdateraBoklistor(List<Bok> återlämnadeBöcker, Bokning valdBokning)
        {
            foreach (Bok bok in återlämnadeBöcker)
            {
                valdBokning.ÅterlämnadeBöcker.Add(bok);
            }
            IEnumerable<Bok> nyaLånadeBöcker = (valdBokning.LånadeBöcker).Except(återlämnadeBöcker).ToList();

            valdBokning.LånadeBöcker = (List<Bok>)nyaLånadeBöcker;



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

        private void FakturorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Bokning)allaBokningarcomboBox.SelectedItem).FakturaLista.Count < 1)
            {
                fakturaNummerlabel.Text = "---";
                fakturaTotalPrislabel.Text = "---";
            }
            else
            {

            fakturaNummerlabel.Text = ((Faktura)FakturorComboBox.SelectedItem).FakturaNummer;
            fakturaTotalPrislabel.Text = (((Faktura)FakturorComboBox.SelectedItem).Totalpris.ToString()) + " " + "kr";
            fakturaÅterlämnadeböckerListBox.DataSource = ((Bokning)allaBokningarcomboBox.SelectedItem).ÅterlämnadeBöcker;
            }
        }
    }
}
