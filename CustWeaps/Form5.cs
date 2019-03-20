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
            List<UserData> _data = new List<UserData>();
            _data.Add(new UserData()
            {
                AssualtRifle = AssualtRifles.SetValueForRifle,

                BattleRifle = BattleRifles.SetValueForRifle,

                Submachine_Gun = SMGs.SetValueForRifle,

                Light_or_General_Purpose_Machine_Gun = LMGs.SetValueForRifle,

                Shotgun = Shotguns.SetValueForRifle,

                SniperRifle = SniperRifles.SetValueForRifle,

                TopPiece = Form2.SetValueForRifle,

                Reciver = Form2.SetValueForRifle2,

                Barrel = Form2.SetValueForRifle3,

                Stock = Form2.SetValueForRifle4,

                Handguard = Form2.SetValueForRifle5,


                Optic = Form4.SetValueForRifle,

                Underbarrel = Form4.SetValueForRifle2,

                SideRails = Form4.SetValueForRifle3,

                Muzzle = Form4.SetValueForRifle4


            });


            string json = JsonConvert.SerializeObject(_data.ToArray());


            System.IO.File.WriteAllText(@"C:\Users\s188041\source\repos\Weapon-Customizer\CustWeaps\bin\Debug\CustomGun.json", json);


        }
        public class UserData
        {
            public string AssualtRifle
            {
                get;
                set;
            }

            public string BattleRifle
            {
                get;
                set;
            }

            public string Submachine_Gun
            {
                get;
                set;
            }

            public string Light_or_General_Purpose_Machine_Gun
            {
                get;
                set;
            }

            public string Shotgun
            {
                get;
                set;
            }

            public string SniperRifle
            {
                get;
                set;
            }


            public string TopPiece
            {
                get;
                set;
            }

            public string Reciver
            {
                get;
                set;
            }

            public string Barrel
            {
                get;
                set;
            }

            public string Stock
            {
                get;
                set;
            }

            public string Handguard
            {
                get;
                set;
            }




            public string Optic
            {
                get;
                set;
            }

            public string Underbarrel
            {
                get;
                set;
            }

            public string SideRails
            {
                get;
                set;
            }

            public string Muzzle
            {
                get;
                set;
            }

        }

    }

}



