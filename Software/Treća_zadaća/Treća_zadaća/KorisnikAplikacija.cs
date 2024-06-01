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
    public partial class KorisnikAplikacija : Form
    {
        public KorisnikAplikacija()
        {
            InitializeComponent();
        }

        private void GumbZaPretragu_Click(object sender, EventArgs e)
        {
            List<AutobusnaStanica> autobusneStanice = RepozitorijAutobusnihStanica.DohvatiAutobusneStanice();
            bool postojiTrazenaLokacija = autobusneStanice.Exists(stanica => stanica.Lokacija == AutobusnaStanicaTrazi.Text);
            bool postojiTrazenaStanica = autobusneStanice.Exists(stanica => stanica.Naziv == AutobusnaStanicaTrazi.Text);
            if (AutobusnaStanicaTrazi.Text == "")
            {
                MessageBox.Show("Unesite naziv ili lokaciju autobusne stanice", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrikaziAutobusneStanice();
            }
            else if (postojiTrazenaLokacija)
            {
                dataGridView1.DataSource = autobusneStanice.Where(stanica => stanica.Lokacija == AutobusnaStanicaTrazi.Text).ToList();
            }
            else if (postojiTrazenaStanica)
            {
                dataGridView1.DataSource = autobusneStanice.Where(stanica => stanica.Naziv == AutobusnaStanicaTrazi.Text).ToList();
            }
            else
            {
                MessageBox.Show("Nema takve autobusne stanice", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrikaziAutobusneStanice();
            }
        }

        private void GumbZaOdjavu_Click(object sender, EventArgs e)
        {
            AutobusniPuls autobusniPuls = new AutobusniPuls();
            Close();
            autobusniPuls.Show();
        }

        private void KorisnikAplikacija_Load(object sender, EventArgs e)
        {
            PrikaziAutobusneStanice();
        }

        private void PrikaziAutobusneStanice()
        {
            List<AutobusnaStanica> autobusneStanice = RepozitorijAutobusnihStanica.DohvatiAutobusneStanice();
            dataGridView1.DataSource = autobusneStanice;
            dataGridView1.Columns["ID"].DisplayIndex = 0;
            dataGridView1.Columns["Naziv"].DisplayIndex = 1;
            dataGridView1.Columns["Lokacija"].DisplayIndex = 2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //bespotrebno
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
