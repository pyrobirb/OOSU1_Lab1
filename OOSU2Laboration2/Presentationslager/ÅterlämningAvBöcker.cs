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
            UppdateraBokningsLista();
        }

        public void UppdateraBokningsLista()
        {
            allaBokningarcomboBox.DataSource = null;
            var allabokningar = Drm.HämtaAllaBokningar();
            allaBokningarcomboBox.DataSource = allabokningar;
            allaBokningarcomboBox.DisplayMember = "BokningsNummer";
            allaBokningarcomboBox.ValueMember = "BokningsNummer";
        }
        private void allaBokningarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allaBokningarcomboBox.SelectedItem != null)
            {
                UppdateraListBoxar();
                //UppdateraFakturaComboBox();
            }

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
            ÅterLämnaMarkeradeBöcker();
        }

        public void ÅterLämnaMarkeradeBöcker()
        {
            var valdBokning = (Bokning)allaBokningarcomboBox.SelectedItem;
            List<Bok> valdaBöcker = new List<Bok>();
            var återlämningsDatum = DateTime.Now;


            foreach (Bok bok in allaBöckerPåBoknListBox.SelectedItems)
            {
                valdaBöcker.Add(bok);
            }

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

            Drm.LäggTillFaktura(f);

            if (valdBokning.FakturaLista == null || valdBokning.FakturaLista.Count() == 0)
            {
                List<Faktura> fList = new List<Faktura>();
                fList.Add(f);
                valdBokning.FakturaLista = fList;
                FakturorComboBox.DataSource = null;
                FakturorComboBox.DataSource = valdBokning.FakturaLista;
                FakturorComboBox.DisplayMember = "FakturaNummer";
            }
            else
            {
                var fList = valdBokning.FakturaLista;
                fList.Add(f);

                valdBokning.FakturaLista = fList;
                FakturorComboBox.DataSource = null;
                FakturorComboBox.DataSource = valdBokning.FakturaLista;
                FakturorComboBox.DisplayMember = "FakturaNummer";

            }

            UppdateraBoklistor(valdaBöcker, valdBokning);


            UppdateraFakturorÅterlämnadeBöcker();
            UppdateraListBoxar();
        }

        public void UppdateraListBoxar()
        {
            if (allaBokningarcomboBox.SelectedItem != null)
            {
                allaBöckerPåBoknListBox.DataSource = null;
                allaBöckerPåBoknListBox.DataSource = ((Bokning)allaBokningarcomboBox.SelectedItem).LånadeBöcker;
                allaBöckerPåBoknListBox.DisplayMember = "BokTitelFörfattare";

                

            }



        }
        

        public void UppdateraFakturorÅterlämnadeBöcker()
        {
            if (((Faktura)FakturorComboBox.SelectedItem) != null)
            {
                fakturaÅterlämnadeböckerListBox.DataSource = null;
                fakturaÅterlämnadeböckerListBox.DataSource = ((Faktura)FakturorComboBox.SelectedItem).faktureradeBöcker;
                fakturaÅterlämnadeböckerListBox.DisplayMember = "BokTitelFörfattare";
            }
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
                if (((Faktura)FakturorComboBox.SelectedItem) != null)
                {

                    fakturaNummerlabel.Text = ((Faktura)FakturorComboBox.SelectedItem).FakturaNummer;
                    fakturaTotalPrislabel.Text = (((Faktura)FakturorComboBox.SelectedItem).Totalpris.ToString()) + " " + "kr";
                    UppdateraFakturorÅterlämnadeBöcker();
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            UppdateraBokningsLista();
            UppdateraFakturorÅterlämnadeBöcker();
        }

        private void fakturaÅterlämnadeböckerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
