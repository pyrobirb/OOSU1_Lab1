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
        DataRepositoryManager drm = new DataRepositoryManager();
        public Meny()
        {
            InitializeComponent();
            GenereraObjekt();
        }

        private void Meny_Load(object sender, EventArgs e)
        {

        }

        #region genereraobjekt

        public void GenereraObjekt()
        {
            Medlem m1 = new Medlem("12", "Lars", "Kagge", "073019202", "Lars.Kagge@gmail.com", null);
            Medlem m2 = new Medlem("13", "Kalle", "Larsson", "073119202", "Kalle.Larsson@gmail.com", null);
            Medlem m3 = new Medlem("14", "Klara", "Lagge", "073018202", "Klara.Lagge@gmail.com", null);
            Medlem m4 = new Medlem("15", "Lila", "Nagge", "073010202", "Lila.Nagge@gmail.com", null);
            Medlem m5 = new Medlem("16", "Hagge", "Kagge", "073119202", "Hagge.Kagge@gmail.com", null);

            Bok b1 = new Bok("1788478126", "C# 8.0 and .NET Core 3.0", "Mark J. Price", false, 2);
            Bok b2 = new Bok("0134494164", "Clean Architecture", "Robert C. Martin", false, 3);;
            Bok b3 = new Bok("9780132350884", "Clean Code", "Robert C. Martin", false, 2);
            Bok b4 = new Bok("0137081073", "The Clean Coder", "Robert C. Martin", false, 1);
            Bok b5 = new Bok("1844132390", "Man's Search For Meaning","Viktor E. Frankl", false, 4);
            Bok b6 = new Bok("9780722532935", "The Alchemist","Paul Coelho", false, 2);
            Bok b7 = new Bok("9780316029186", "The Last Wish", "Andrzej Sapkowski", false, 1);

            

            //List<Bok> lånadeBöckerBokn = new List<Bok>();
            //lånadeBöckerBokn.Add()
            //Bokning bokn = new Bokning("1", DateTime.Now.ToString("dd/MM/yyyy"), )


        }

        #endregion

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            TillbakaTillLogin();
        }

        public void TillbakaTillLogin()
        {
            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form is Login)
                {
                    form.Show();
                    break;
                }
            }
        }
    }
}
