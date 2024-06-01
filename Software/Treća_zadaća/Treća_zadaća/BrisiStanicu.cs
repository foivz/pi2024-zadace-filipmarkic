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
    public partial class BrisiStanicu : Form
    {
        public BrisiStanicu()
        {
            InitializeComponent();
            List<AutobusnaStanica> autobusneStanice = RepozitorijAutobusnihStanica.DohvatiAutobusneStanice();
            var lokacijeAutobusnihStanica = autobusneStanice.Select(stanica => stanica.Lokacija).ToList();
            comboBox1.Items.Add("Odaberite lokaciju");
            comboBox1.Items[0] = "Odaberite lokaciju";
            comboBox1.SelectedItem = comboBox1.Items[0];//defaultno odabrana prva lokacija
            comboBox1.Items.AddRange(lokacijeAutobusnihStanica.ToArray());
        }

        

        private void GumbOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GumbZaBrisanje_Click(object sender, EventArgs e)
        {
            List<AutobusnaStanica> autobusneStanice = RepozitorijAutobusnihStanica.DohvatiAutobusneStanice();            
            bool postojiTrazenaStanicaLokacija = autobusneStanice.Exists(stanica => stanica.Lokacija == comboBox1.Text);
            
            if (string.IsNullOrEmpty(comboBox1.Text) || comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Niste unijeli sve podatke", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (postojiTrazenaStanicaLokacija)
            {
                RepozitorijAutobusnihStanica.ObrisiAutobusnuStanicu(comboBox1.Text);
                MessageBox.Show("Uspješno obrisana autobusna stanica", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Autobusna stanica na ovoj lokaciji ne postoji", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void BrisiStanicu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
