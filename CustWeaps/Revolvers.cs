﻿using System;
using System.Windows.Forms;

namespace CustWeaps
{
    public partial class Revolvers : Form
    {
        public static string SetValueForRifle = "";

        public Revolvers()
        {
            InitializeComponent();
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = index;

            if (comboBox1.SelectedIndex == -1)
            {
                button1.Enabled = false;
            }

            comboBox1.Text = "S&W 10 : .38 Spc.";

            SetValueForRifle = comboBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = index;

            if (comboBox1.SelectedIndex == -1)
            {
                button1.Enabled = false;
            }

            SetValueForRifle = comboBox1.Text;

            Hide();
            sideArmMods armMods = new sideArmMods();
            armMods.Show();
        }
    }
}
