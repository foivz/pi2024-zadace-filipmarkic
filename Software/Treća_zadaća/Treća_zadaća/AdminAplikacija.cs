﻿using System;
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
    public partial class AdminAplikacija : Form
    {
        public AdminAplikacija()
        {
            InitializeComponent();
        }

        private void AdminAplikacija_Load(object sender, EventArgs e)
        {

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

        private void AutobusniPulsLabel_Click(object sender, EventArgs e)
        {
            //bespotrebno
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //bespotrebno
        }

        private void AutobusneStaniceLabel_Click(object sender, EventArgs e)
        {
            //bespotrebno
        }

        private void PretraziLabel_Click(object sender, EventArgs e)
        {
            //bespotrebno
        }

        private void AutobusnaStanicaTrazi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
