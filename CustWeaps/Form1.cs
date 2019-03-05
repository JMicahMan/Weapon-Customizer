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

        private void BaseWeapon_Load(object sender, EventArgs e)
        {

        }

        private void WeaponChoice_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(WeaponChoice, new Point(0, WeaponChoice.Height));
        }

        private void x39ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void x39mmToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem57_Click(object sender, EventArgs e)
        {

        }

        private void modelLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void t65ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
