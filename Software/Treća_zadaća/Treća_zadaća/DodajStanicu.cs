using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Treća_zadaća.Modeli;
using Treća_zadaća.Repozitoriji;

namespace Treća_zadaća
{
    public partial class DodajStanicu : Form
    {
        public DodajStanicu()
        {
            InitializeComponent();
        }

        private void DodajAutobusnuStanicu_Load(object sender, EventArgs e)
        {

        }

        private void GumbOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GumbZaDodavanje_Click(object sender, EventArgs e)
        {
            List <AutobusnaStanica> autobusneStanice = RepozitorijAutobusnihStanica.DohvatiAutobusneStanice();
            AutobusnaStanica novaAutobusnaStanica = new AutobusnaStanica(int.Parse(AutobusnaStanicaIDInput.Text), AutobusnaStanicaNazivInput.Text, AutobusnaStanicaLokacijaInput.Text);
            bool postojiTrazenaStanicaLokacija = autobusneStanice.Exists(stanica => stanica.Lokacija == novaAutobusnaStanica.Lokacija);
            bool postojiTrazenaStanicaID = autobusneStanice.Exists(stanica => stanica.ID == novaAutobusnaStanica.ID);

            if (string.IsNullOrEmpty(AutobusnaStanicaNazivInput.Text) || string.IsNullOrEmpty(AutobusnaStanicaLokacijaInput.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!postojiTrazenaStanicaLokacija)
            {
                if (!postojiTrazenaStanicaID) 
                {
                    RepozitorijAutobusnihStanica.DodajAutobusnuStanicu(novaAutobusnaStanica);
                    MessageBox.Show("Uspješno dodana autobusna stanica", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                } 
                else
                {
                    MessageBox.Show("Autobusna stanica s ovim ID već postoji", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Autobusna stanica već postoji na ovoj lokaciji", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
