using System;
using System.Windows.Forms;

namespace CustWeaps
{

    public partial class sideArmAttachments : Form
    {

        public static string SetValueForRifle = "";
        public static string SetValueForRifle2 = "";


        public sideArmAttachments()
        {
            InitializeComponent();
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = comboBox1.FindStringExact("comboBox1");
            comboBox1.SelectedIndex = index;


            SetValueForRifle = comboBox1.Text;

            int index2 = comboBox2.FindString(comboBox2.Text);
            comboBox2.SelectedIndex = comboBox2.FindStringExact("comboBox2");
            comboBox2.SelectedIndex = index2;


            SetValueForRifle2 = comboBox2.Text;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = comboBox1.FindStringExact("comboBox1");
            comboBox1.SelectedIndex = index;


            SetValueForRifle = comboBox1.Text;

            int index2 = comboBox2.FindString(comboBox2.Text);
            comboBox2.SelectedIndex = comboBox2.FindStringExact("comboBox2");
            comboBox2.SelectedIndex = index2;


            SetValueForRifle2 = comboBox2.Text;

            Hide();
            Form5 form5 = new Form5();
            form5.Show();

        }
    }
}
