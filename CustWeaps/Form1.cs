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

        private void Continue_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.Show();
        
        }

        private void Load_Click(object sender, EventArgs e)
        {


            Hide();
            Form6 form6 = new Form6();
            form6.Show();

        }

    }
}
