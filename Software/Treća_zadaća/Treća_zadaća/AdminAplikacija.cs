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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
