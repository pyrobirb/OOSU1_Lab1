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
        BibliotekController BibliotekController { get; set; }

        public ÅterlämningAvBöcker(BibliotekController bibliotekController)
        {
            InitializeComponent();
            BibliotekController = bibliotekController;
            UppdateraBokningsLista();
        }

        public void UppdateraBokningsLista()
        {
            allaBokningarcomboBox.DataSource = null;
            var allabokningar = BibliotekController.HämtaAllaBokningar();
            allaBokningarcomboBox.DataSource = allabokningar;
            allaBokningarcomboBox.DisplayMember = "BokningsNummer";
            allaBokningarcomboBox.ValueMember = "BokningsNummer";
        }
        private void allaBokningarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allaBokningarcomboBox.SelectedItem != null)
            {
                UppdateraListBoxar();
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
            Meny meny = new Meny(BibliotekController);
            meny.Show();
            this.Hide();
        }

        private void återlämningBtn_Click(object sender, EventArgs e)
        {
            var valdBokning = (Bokning)allaBokningarcomboBox.SelectedItem;

            List<Bok> valdaBöcker = new List<Bok>();
            foreach (Bok bok in allaBöckerPåBoknListBox.SelectedItems)
            {
                valdaBöcker.Add(bok);
            }

            Faktura faktura = BibliotekController.ÅterlämnaMarkeradeBöckerOchGenereraFaktura(valdBokning, valdaBöcker);
            SkrivUtFakturaID(faktura);


            if (valdBokning.FakturaLista == null || valdBokning.FakturaLista.Count() == 0)
            {
                List<Faktura> fList = new List<Faktura>();
                fList.Add(faktura);
                valdBokning.FakturaLista = fList;
                FakturorComboBox.DataSource = null;
                FakturorComboBox.DataSource = valdBokning.FakturaLista;
                FakturorComboBox.DisplayMember = "FakturaNummer";
            }
            else
            {
                var fList = valdBokning.FakturaLista;
                fList.Add(faktura);

                valdBokning.FakturaLista = fList;
                FakturorComboBox.DataSource = null;
                FakturorComboBox.DataSource = valdBokning.FakturaLista;
                FakturorComboBox.DisplayMember = "FakturaNummer";

            }

            UppdateraBoklistor(valdaBöcker, valdBokning);

            UppdateraFakturorÅterlämnadeBöcker();
            UppdateraListBoxar();

        }

        private void SkrivUtFakturaID(Faktura f)
        {
            nyFakturaGenereradID.Text = f.FakturaNummer;
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
