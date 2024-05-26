using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Treća_zadaća.Modeli;
using Treća_zadaća.Repozitoriji;

namespace Treća_zadaća
{
    public partial class BrisiAutobusnuStanicu : Form
    {
        public BrisiAutobusnuStanicu()
        {
            InitializeComponent();
        }

        private void GumbOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GumbZaBrisanje_Click(object sender, EventArgs e)
        {
            List<AutobusnaStanica> autobusneStanice = RepozitorijAutobusnihStanica.DohvatiAutobusneStanice();            
            bool postojiTrazenaStanicaLokacija = autobusneStanice.Exists(stanica => stanica.Lokacija == LokacijaAutobusneStaniceZaBrisanje.Text);
            
            if (string.IsNullOrEmpty(LokacijaAutobusneStaniceZaBrisanje.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (postojiTrazenaStanicaLokacija)
            {
                RepozitorijAutobusnihStanica.ObrisiAutobusnuStanicu(LokacijaAutobusneStaniceZaBrisanje.Text);
                MessageBox.Show("Uspješno obrisana autobusna stanica", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Autobusna stanica na ovoj lokaciji ne postoji", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
