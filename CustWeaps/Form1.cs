using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustWeaps
{
    public partial class BaseWeapon : Form
    {
        public BaseWeapon()
        {
            InitializeComponent();
        }

        public void WeaponChoice_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(WeaponChoice, new Point(0, WeaponChoice.Height));
            

        }


        public void Load_Click(object sender, EventArgs e)
        {


            Hide();
            Form6 form6 = new Form6();
            form6.Show();

        }


        public void assualtRiflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AssualtRifles assualtRifles = new AssualtRifles();
            assualtRifles.Show();
        }


        public void battleRiflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            BattleRifles battleRifles = new BattleRifles();
            battleRifles.Show();
        }

        public void sMGsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            SMGs sMGs = new SMGs();
            sMGs.Show();
        }

        public void lMGsGPMGsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            LMGs lMGs = new LMGs();
            lMGs.Show();
        }

        public void shotgunsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Shotguns shotguns = new Shotguns();
            shotguns.Show();
        }

        public void sniperRiflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            SniperRifles sniperRifles = new SniperRifles();
            sniperRifles.Show();
        }
    }
}
