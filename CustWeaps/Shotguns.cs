using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CustWeaps
{

    public partial class Shotguns : Form
    {

        public static string SetValueForRifle = "";

        public Shotguns()
        {
            InitializeComponent();
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = comboBox1.FindStringExact("comboBox1");
            comboBox1.SelectedIndex = index;


            SetValueForRifle = comboBox1.Text;


        }


        public void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = comboBox1.FindStringExact("comboBox1");
            comboBox1.SelectedIndex = index;

            SetValueForRifle = comboBox1.Text;

            Hide();
            Form2 form2 = new Form2();
            form2.Show();

        }


    }
}
