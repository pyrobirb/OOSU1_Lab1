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

        DataRepositoryManager drm = new DataRepositoryManager();
        public Login()
        {
            InitializeComponent();
            GenereraObjekt();
            UppdateraExpediter();
        }

        public void UppdateraExpediter()
        {
            expediterComboBox.DataSource = drm.HämtaAllaExpediter();
            expediterComboBox.DisplayMember = "ExpeditFullName";
            expediterComboBox.ValueMember = "AnställningsNummer";
        }

        #region genereraobjekt

        public void GenereraObjekt()
        {
            Expedit expedit = new Expedit("1", "Klas", "Göran", "klas123", "Expedit");
            Expedit expedit1 = new Expedit("2", "KLara", "Göransson", "klara123", "Expedit");
            drm.LäggTillExpedit(expedit);
            drm.LäggTillExpedit(expedit1);
        }

        #endregion

        public bool KontrolleraInloggning(string ID, string Lösenord)
        {
            var expediter = drm.HämtaAllaExpediter();

            if ((ID != null) || (Lösenord != null))
            {
                foreach (var expedit in expediter)
                {
                    if ((ID == expedit.AnställningsNummer) && (Lösenord == expedit.Lösenord))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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
                Meny meny = new Meny();
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


    }
}
