using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsDnevnik
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Osoba nova = new Osoba();
                nova.Show();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Raspodela nova = new Raspodela();
                nova.Show();
        }

        private void ocenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Ocena nova = new Ocena();
                nova.Show();
        }
    }
}
