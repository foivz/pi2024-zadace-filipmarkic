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
    }
}
