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
    public partial class LMGs : Form
    {
        public LMGs()
        {
            InitializeComponent();
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = index;

            if (comboBox1.SelectedIndex == -1)
            {
                button1.Enabled = false;
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {

            Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
