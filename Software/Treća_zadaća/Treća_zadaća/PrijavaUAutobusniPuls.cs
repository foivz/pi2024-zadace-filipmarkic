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
    public partial class PrijavaUAutobusniPuls : Form
    {
        public PrijavaUAutobusniPuls()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) //labela za korisničko ime
        {

        }

        private void LozinkaLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //input za lozinku
        
        {

        }

        private void PrijavaUSustav_Click(object sender, EventArgs e) //gumb za prijavu
        {
            string[] korisnici = new string[2]; //kreiranje polja korisnika
            korisnici[0] = "admin"; //dodavanje korisnika
            korisnici[1] = "korisnik";

            string[] lozinke = new string[2]; //kreiranje polja lozinki
            lozinke[0] = "admin"; //dodavanje lozinki
            lozinke[1] = "korisnik";

            if (KorisnickoImeTextBox.Text == "") //provjera jesu li polja prazna
            {
                MessageBox.Show("Niste unijeli korisničko ime!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LozinkaTextBox.Text == "")
            {
                MessageBox.Show("Niste unijeli lozinku!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //situacija za admina

            if (KorisnickoImeTextBox.Text == korisnici[0])
            {
                if (LozinkaTextBox.Text == lozinke[0])
                {
                    Hide();
                    MessageBox.Show("Pristupili ste aplikaciji kao admin!", "Uspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminAplikacija adminAplikacija = new AdminAplikacija();
                    adminAplikacija.Show();
                    
                } 

                else
                {
                    MessageBox.Show("Unijeli ste netočnu lozinku!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //situacija za korisnika

            else if (KorisnickoImeTextBox.Text == korisnici[1])
            {
                if (LozinkaTextBox.Text == lozinke[1])
                {
                    Hide();
                    MessageBox.Show("Pristupili ste aplikaciji kao korisnik!", "Uspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KorisnikAplikacija korisnikAplikacija = new KorisnikAplikacija();
                    korisnikAplikacija.Show();
                } 
                
                else 
                {
                    MessageBox.Show("Unijeli ste netočnu lozinku!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            
            else if (KorisnickoImeTextBox.Text != "")
            {    
                MessageBox.Show("Unijeli ste nepostojeće korisničko ime!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PrijavaUAutobusniPuls_Load(object sender, EventArgs e)
        {

        }

        private void KorisnickoImeTextBox_TextChanged(object sender, EventArgs e) //input za korisničko ime
        {

        }
    }
}
