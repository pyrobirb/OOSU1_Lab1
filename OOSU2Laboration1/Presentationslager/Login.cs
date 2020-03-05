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
        BibliotekController BibliotekController { get; set; }
        public Login(BibliotekController bibliotekController)
        {
            InitializeComponent();
            BibliotekController = bibliotekController;
            GenereraObjekt();
            UppdateraExpediter();
        }

        public void UppdateraExpediter()
        {
            expediterComboBox.DataSource = BibliotekController.HämtaAllaExpediter();
            expediterComboBox.DisplayMember = "ExpeditFulltNamn";
            expediterComboBox.ValueMember = "AnställningsNummer";
        }

        #region genereraobjekt

        public void GenereraObjekt()
        {
            if (BibliotekController.HämtaAllaExpediter().Count() < 1)
            {
                Expedit expedit = new Expedit("1", "Klas", "Göran", "klas123", "Bibliotekschef");
                Expedit expedit1 = new Expedit("2", "Klara", "Göransson", "klara123", "Expedit");
                BibliotekController.LäggTillExpedit(expedit);
                BibliotekController.LäggTillExpedit(expedit1);
            }
        }

        #endregion

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoggaInBtn_Click(object sender, EventArgs e)
        {
            if (BibliotekController.KontrolleraInloggning(AnvIDTextBox.Text, LösenordTextBox.Text))
            {
                Meny meny = new Meny(BibliotekController);
                BibliotekController.SättInloggadExpedit(((Expedit)expediterComboBox.SelectedItem).AnställningsNummer);
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
