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
    public partial class BorttagningAvBokning : Form
    {
        DataRepositoryManager Drm { get; set; }
        string inloggadAnvändare { get; set; }
        public BorttagningAvBokning(DataRepositoryManager drm)
        {
            InitializeComponent();
            Drm = drm;
        }

        private void BokningAttTaBortcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
