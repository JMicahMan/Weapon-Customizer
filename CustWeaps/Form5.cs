using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Dynamic;



namespace CustWeaps
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label1.Text = "Weapon Name";

            label2.Text = "Top Piece";
            label3.Text = "Reciver";
            label4.Text = "Barrel";
            label5.Text = "Stock";
            label6.Text = "Handguard";

            label7.Text = "Optic";
            label8.Text = "Underbarrel";
            label9.Text = "Side Rails";
            label10.Text = "Muzzle";

        }

        public void Finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Save_Click(object sender, EventArgs e)
        {


            Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

    }


}
