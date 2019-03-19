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

    public partial class Form2 : Form
    {

        public static string SetValueForRifle = "";
        public static string SetValueForRifle2 = "";
        public static string SetValueForRifle3 = "";
        public static string SetValueForRifle4 = "";
        public static string SetValueForRifle5 = "";


        public Form2()
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

            int index5 = comboBox5.FindString(comboBox5.Text);
            comboBox5.SelectedIndex = comboBox5.FindStringExact("comboBox5");
            comboBox5.SelectedIndex = index5;


            SetValueForRifle5 = comboBox5.Text;




        }


        public void Continue_Click(object sender, EventArgs e)
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

            int index5 = comboBox5.FindString(comboBox5.Text);
            comboBox5.SelectedIndex = comboBox5.FindStringExact("comboBox5");
            comboBox5.SelectedIndex = index5;


            SetValueForRifle5 = comboBox5.Text;

            Hide();
            Form4 form4 = new Form4();
            form4.Show();

        }


    }
}
