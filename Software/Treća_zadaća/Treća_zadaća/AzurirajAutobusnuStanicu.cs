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
    public partial class AzurirajAutobusnuStanicu : Form
    {
        public AzurirajAutobusnuStanicu()
        {
            InitializeComponent();
        }

        private void GumbOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
