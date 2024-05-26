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
    public partial class AdminAplikacija : Form
    {
        public AdminAplikacija()
        {
            InitializeComponent();
        }

        private void AdminAplikacija_Load(object sender, EventArgs e)
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

        private void GumbZaPretragu_Click(object sender, EventArgs e)
        {
            List<AutobusnaStanica> autobusneStanice = RepozitorijAutobusnihStanica.DohvatiAutobusneStanice();
            bool postojiTrazenaStanica = autobusneStanice.Exists(stanica => stanica.Lokacija == AutobusnaStanicaTrazi.Text);
            if (postojiTrazenaStanica)
            {
                dataGridView1.DataSource = autobusneStanice.Where(stanica => stanica.Lokacija == AutobusnaStanicaTrazi.Text).ToList();
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

        private void GumbZaAdd_Click(object sender, EventArgs e)
        {
            DodajAutobusnuStanicu dodajAutobusnuStanicu = new DodajAutobusnuStanicu();
            dodajAutobusnuStanicu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GumbZaDelete_Click(object sender, EventArgs e)
        {
            BrisiAutobusnuStanicu brisiAutobusnuStanicu = new BrisiAutobusnuStanicu();
            brisiAutobusnuStanicu.Show();
        }

        private void GumbZaUpdate_Click(object sender, EventArgs e)
        {
            AzurirajAutobusnuStanicu azurirajAutobusnuStanicu = new AzurirajAutobusnuStanicu();
            azurirajAutobusnuStanicu.Show();
        }

        private void GumbZaUpdatePrikazaTablice_Click(object sender, EventArgs e)
        {
            PrikaziAutobusneStanice();
        }
    }
}
