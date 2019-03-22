using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustWeaps
{
    public partial class Sidearms : Form
    {
        public Sidearms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button1, new Point(0, button1.Height));
        }

        private void automaticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Automatics automatics = new Automatics();
            automatics.Show();
        }

        private void revolversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Revolvers revolvers = new Revolvers();
            revolvers.Show();
        }
    }
}
