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
    public partial class Login : Form
    {

        DataRepositoryManager Drm { get; set; }
        public Login(DataRepositoryManager drm)
        {
            InitializeComponent();
            Drm = drm;
            GenereraObjekt();
            UppdateraExpediter();
        }

        public void UppdateraExpediter()
        {
            expediterComboBox.DataSource = Drm.HämtaAllaExpediter();
            expediterComboBox.DisplayMember = "ExpeditFulltNamn";
            expediterComboBox.ValueMember = "AnställningsNummer";
        }

        #region genereraobjekt

        public void GenereraObjekt()
        {
            if (Drm.HämtaAllaExpediter().Count() < 1)
            {
                Expedit expedit = new Expedit("1", "Klas", "Göran", "klas123", "Bibliotekschef");
                Expedit expedit1 = new Expedit("2", "Klara", "Göransson", "klara123", "Expedit");
                Drm.LäggTillExpedit(expedit);
                Drm.LäggTillExpedit(expedit1);
            }
        }

        #endregion

        public bool KontrolleraInloggning(string ID, string Lösenord)
        {
            var expediter = Drm.HämtaAllaExpediter();

            if ((ID != null) || (Lösenord != null))
            {
                foreach (var expedit in expediter)
                {
                    if ((ID == expedit.AnställningsNummer) && (Lösenord == expedit.Lösenord))
                    {
                        return true;
                    }
                }
                return false;
            }
            else return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoggaInBtn_Click(object sender, EventArgs e)
        {
            if (KontrolleraInloggning(AnvIDTextBox.Text, LösenordTextBox.Text))
            {
                Meny meny = new Meny(Drm, AnvIDTextBox.Text);
                meny.InloggadAnvändare(AnvIDTextBox.Text);
                meny.Show();
                this.Hide();
            }
            else
            {
                felLösenLabel.Text = "Fel lösenord eller ID";
            }
        }


        private void expediterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valdExpedit = (Expedit)expediterComboBox.SelectedItem;
            AnvIDTextBox.Text = valdExpedit.AnställningsNummer;
            LösenordTextBox.Text = valdExpedit.Lösenord;
        }

        private void AvslutaBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
