﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Optic_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Optic, new Point(0, Optic.Height));
        }

        private void UnderBarrel_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(Underbarrel, new Point(0, Underbarrel.Height));
        }

        private void SideRails_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(SideRails, new Point(0, SideRails.Height));
        }

        private void Muzzle_Click(object sender, EventArgs e)
        {
            contextMenuStrip4.Show(SideRails, new Point(0, Muzzle.Height));
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
