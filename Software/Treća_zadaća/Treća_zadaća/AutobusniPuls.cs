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
    public partial class AutobusniPuls : Form
    {
        public AutobusniPuls()
        {
            InitializeComponent();
        }

        private void AutobusniPuls_Load(object sender, EventArgs e)
        {

        }

        private void GumbZaPrijavu_Click(object sender, EventArgs e)
        {
            PrijavaUAutobusniPuls otvorenProzorZaPrijavu = new PrijavaUAutobusniPuls();
            Hide();
            otvorenProzorZaPrijavu.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
