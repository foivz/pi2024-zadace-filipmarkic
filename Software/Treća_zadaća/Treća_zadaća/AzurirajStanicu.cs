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
    public partial class AzurirajStanicu : Form
    {
        public AzurirajStanicu()
        {
            InitializeComponent();
            List<AutobusnaStanica> autobusneStanice = RepozitorijAutobusnihStanica.DohvatiAutobusneStanice();
            var IDAutobusnihStanica = autobusneStanice.Select(stanica => stanica.ID).ToList();
            comboBox1.Items.Add("Odaberite ID");
            comboBox1.Items[0] = "Odaberite ID";
            comboBox1.SelectedItem = comboBox1.Items[0];//defaultno odabrana prva lokacija
            for (int i = 0; i < IDAutobusnihStanica.Count; i++){
                comboBox1.Items.Add(IDAutobusnihStanica[i]);
            }
        }

        private void GumbOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IDAutobusneStanice_TextChanged(object sender, EventArgs e)
        {

        }

        private void GumbZaAzuriranje_Click(object sender, EventArgs e)
        {
            List<AutobusnaStanica> autobusneStanice = RepozitorijAutobusnihStanica.DohvatiAutobusneStanice();
            bool postojiIDStanice = autobusneStanice.Exists(stanica => stanica.ID == int.Parse(IDAutobusneStanice.Text));
            bool postojiNovaLokacija = autobusneStanice.Exists(stanica => stanica.Lokacija == AzuriranaLokacijaAutobusneStanice.Text);
            if (postojiIDStanice)
            {
                if (!postojiNovaLokacija)
                {
                    RepozitorijAutobusnihStanica.AzurirajAutobusnuStanicu(int.Parse(IDAutobusneStanice.Text), AzuriraniNazivAutobusneStanice.Text, AzuriranaLokacijaAutobusneStanice.Text);
                    MessageBox.Show("Podaci autobusne stanice uspješno ažurirani", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Već postoji autobusna stanica s tom lokacijom", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nema postoji stanica s takvim ID", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
