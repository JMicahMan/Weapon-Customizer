﻿using System;
using System.Windows.Forms;

namespace CustWeaps
{

    public partial class BattleRifles : Form
    {

        public static string SetValueForRifle = "  ";

        public BattleRifles()
        {
            InitializeComponent();
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = comboBox1.FindStringExact("comboBox1");
            comboBox1.SelectedIndex = index;

            comboBox1.Text = "FAL : 7.62x51mm";

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
