using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustWeaps
{
    public partial class BaseWeapon : Form
    {
        public BaseWeapon()
        {
            InitializeComponent();
        }

        private void WeaponChoice_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(WeaponChoice, new Point(0, WeaponChoice.Height));
            

        }


        private void Load_Click(object sender, EventArgs e)
        {


            Hide();
            Form6 form6 = new Form6();
            form6.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void assualtRiflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AssualtRifles assualtRifles = new AssualtRifles();
            assualtRifles.Show();
        }


        private void battleRiflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            BattleRifles battleRifles = new BattleRifles();
            battleRifles.Show();
        }

        private void sMGsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            SMGs sMGs = new SMGs();
            sMGs.Show();
        }

        private void lMGsGPMGsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            LMGs lMGs = new LMGs();
            lMGs.Show();
        }

        private void shotgunsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Shotguns shotguns = new Shotguns();
            shotguns.Show();
        }

        private void sniperRiflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            SniperRifles sniperRifles = new SniperRifles();
            sniperRifles.Show();
        }
    }
}
