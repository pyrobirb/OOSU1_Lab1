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
    public partial class Meny : Form
    {
        BibliotekController BibliotekController { get; set; }
        
        
        public Meny(BibliotekController bibliotekController)
        {
            InitializeComponent();
            BibliotekController = bibliotekController;
        }

        private void BokningBtn_Click(object sender, EventArgs e)
        {
            Form bokning = Application.OpenForms["Bokning"];
            if (bokning != null)
            {
                this.Hide();
                bokning.Focus();
                bokning.Show();
            }
            else
            {
                SkapaBokning nyBokning = new SkapaBokning(BibliotekController);
                nyBokning.Show();
                this.Hide();
            }
        }
        private void BorttagningBtn_Click(object sender, EventArgs e)
        {
            
        }


        private void återlämningBtn_Click(object sender, EventArgs e)
        {
            Form återL = Application.OpenForms["ÅterlämningAvBöcker"];
            if (återL != null)
            {
                this.Hide();
                återL.Focus();
                återL.Show();
                
            }
            else
            {
                ÅterlämningAvBöcker nyåterL = new ÅterlämningAvBöcker(BibliotekController);
                nyåterL.Show();
                this.Hide();
            }
        }

        private void tillbakaBtn_Click(object sender, EventArgs e)
        {
            TillbakaTillLogin();
        }
        public void TillbakaTillLogin()
        {
            Login login = new Login(BibliotekController);
            login.Show();
            this.Hide();
        }

        

        private void Meny_Load(object sender, EventArgs e)
        {
            inloggadAnvändareLabel.Text = BibliotekController.HämtaInloggadExpedit();
        }

        public string HämtaInloggadExpedit()
        {

            List<Expedit> allaexpediter = (List<Expedit>)BibliotekController.HämtaAllaExpediter();

            var expedit =
                (from exp in allaexpediter
                 where exp.AnställningsNummer == GLOBALS.inloggadExpeditID
                 select exp.ExpeditFulltNamn).SingleOrDefault();

            return expedit;
        }

        private void inloggadAnvändareLabel_Click(object sender, EventArgs e)
        {

        }

        private void UtlämningBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
