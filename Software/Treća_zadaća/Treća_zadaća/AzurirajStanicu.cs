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
    public partial class LabelID : Form
    {
        public LabelID()
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
            bool postojiIDStanice = autobusneStanice.Exists(stanica => stanica.ID == int.Parse(comboBox1.Text));
            bool postojiNovaLokacija = autobusneStanice.Exists(stanica => stanica.Lokacija == AzuriranaLokacijaAutobusneStanice.Text);
            AutobusnaStanica novaAutobusnaStanica = autobusneStanice.Find(stanica => stanica.ID == int.Parse(comboBox1.Text));
            int IDOdabraneStanice = novaAutobusnaStanica.ID;

            if (string.IsNullOrEmpty(AzuriraniNazivAutobusneStanice.Text) || string.IsNullOrEmpty(AzuriranaLokacijaAutobusneStanice.Text) || AzuriraniNazivAutobusneStanice.Text == "Naziv" || AzuriranaLokacijaAutobusneStanice.Text == "Lokacija")
            {
                MessageBox.Show("Niste unijeli sve podatke", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (postojiIDStanice)
            {
                if (!postojiNovaLokacija && int.Parse(comboBox1.Text) == IDOdabraneStanice)
                {
                    RepozitorijAutobusnihStanica.AzurirajAutobusnuStanicu(int.Parse(comboBox1.Text), AzuriraniNazivAutobusneStanice.Text, AzuriranaLokacijaAutobusneStanice.Text);
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
            List<AutobusnaStanica> autobusneStanice = RepozitorijAutobusnihStanica.DohvatiAutobusneStanice();
            AutobusnaStanica odabranaStanica = autobusneStanice.Find(stanica => stanica.ID.ToString() == comboBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                AzuriraniNazivAutobusneStanice.Text = "Naziv";
                AzuriranaLokacijaAutobusneStanice.Text = "Lokacija";
            } 
            else
            {
                AzuriraniNazivAutobusneStanice.Text = odabranaStanica.Naziv;
                AzuriranaLokacijaAutobusneStanice.Text = odabranaStanica.Lokacija;
            }

        }

        private void AzuriranaLokacijaAutobusneStanice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
