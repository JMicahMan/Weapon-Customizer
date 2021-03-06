﻿using System;
using System.Windows.Forms;

namespace CustWeaps
{
    public partial class Automatics : Form
    {
        public static string SetValueForRifle = "";

        public Automatics()
        {
            InitializeComponent();
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedIndex = index;

            if (comboBox1.SelectedIndex == -1)
            {
                button1.Enabled = false;
            }
            SetValueForRifle = comboBox1.Text;

            comboBox1.Text = "1911 : .45 ACP";
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
