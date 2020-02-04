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
    }
}
