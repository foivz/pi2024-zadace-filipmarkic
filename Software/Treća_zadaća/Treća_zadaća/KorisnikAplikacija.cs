using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treća_zadaća
{
    public partial class KorisnikAplikacija : Form
    {
        public KorisnikAplikacija()
        {
            InitializeComponent();
        }

        private void AutobusneStaniceLabel_Click(object sender, EventArgs e)
        {
            //bespotrebno
        }

        private void AutobusnaStanicaTrazi_TextChanged(object sender, EventArgs e)
        {

        }

        private void GumbZaOdjavu_Click(object sender, EventArgs e)
        {
            AutobusniPuls autobusniPuls = new AutobusniPuls();
            Close();
            autobusniPuls.Show();
        }
    }
}
