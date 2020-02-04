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
            allaBöckerPåBoknListBox.DisplayMember = "BokTitelFörfattare"; ;
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


            foreach (Bok bok in allaBöckerPåBoknListBox.Items)
            {
                valdaBöcker.Add(bok);
            }

            //faktura
            string fakturaNummer = valdBokning.BokningsNummer + 1000;

            var nyaTotalPriset = BeräknaTotalPris(valdaBöcker, återlämningsDatum, valdBokning);

            var förfalloDatum = återlämningsDatum.AddDays(30);
            Faktura f = new Faktura(fakturaNummer,nyaTotalPriset, återlämningsDatum, förfalloDatum, valdBokning);

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
            UppdateraBoklistor(valdaBöcker, valdaBöcker, valdBokning);

            



        }


        public void UppdateraBoklistor(List<Bok> återlämnadeBöcker, List<Bok> lånadeBöcker, Bokning valdBokning)
        {





        }


        public int BeräknaTotalPris(List<Bok> böcker, DateTime återlämningsDatum, Bokning bokning ) 
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

    }
}
