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
            label1.Text = AssualtRifles.SetValueForRifle;
            label11.Text = BattleRifles.SetValueForRifle;
            label12.Text = SMGs.SetValueForRifle;
            label13.Text = LMGs.SetValueForRifle;
            label14.Text = Shotguns.SetValueForRifle;
            label15.Text = SniperRifles.SetValueForRifle;
            label16.Text = "";



            label2.Text = Form2.SetValueForRifle;
            label3.Text = Form2.SetValueForRifle2;
            label4.Text = Form2.SetValueForRifle3;
            label5.Text = Form2.SetValueForRifle4;
            label6.Text = Form2.SetValueForRifle5;

            label7.Text = Form4.SetValueForRifle;
            label8.Text = Form4.SetValueForRifle2;
            label9.Text = Form4.SetValueForRifle3;
            label10.Text = Form4.SetValueForRifle4;
            

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
