using System;
using System.Windows.Forms;

namespace CustWeaps
{

    public partial class sideArmMods : Form
    {

        public static string SetValueForRifle = "";
        public static string SetValueForRifle2 = "";
        public static string SetValueForRifle3 = "";
        public static string SetValueForRifle4 = "";


        public sideArmMods()
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

            int index3 = comboBox3.FindString(comboBox3.Text);
            comboBox3.SelectedIndex = comboBox3.FindStringExact("comboBox3");
            comboBox3.SelectedIndex = index3;


            SetValueForRifle3 = comboBox3.Text;

            int index4 = comboBox4.FindString(comboBox4.Text);
            comboBox4.SelectedIndex = comboBox4.FindStringExact("comboBox4");
            comboBox4.SelectedIndex = index4;


            SetValueForRifle4 = comboBox4.Text;


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

            int index3 = comboBox3.FindString(comboBox3.Text);
            comboBox3.SelectedIndex = comboBox3.FindStringExact("comboBox3");
            comboBox3.SelectedIndex = index3;


            SetValueForRifle3 = comboBox3.Text;

            int index4 = comboBox4.FindString(comboBox4.Text);
            comboBox4.SelectedIndex = comboBox4.FindStringExact("comboBox4");
            comboBox4.SelectedIndex = index4;


            SetValueForRifle4 = comboBox4.Text;


            Hide();
            sideArmAttachments armAttachments = new sideArmAttachments();
            armAttachments.Show();

        }
    }
}
