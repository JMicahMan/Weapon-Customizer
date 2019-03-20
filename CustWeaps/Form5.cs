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
            label1.AutoSize = true;
            label11.Text = BattleRifles.SetValueForRifle;
            label11.AutoSize = true;
            label12.Text = SMGs.SetValueForRifle;
            label12.AutoSize = true;
            label13.Text = LMGs.SetValueForRifle;
            label13.AutoSize = true;
            label14.Text = Shotguns.SetValueForRifle;
            label14.AutoSize = true;
            label15.Text = SniperRifles.SetValueForRifle;
            label15.AutoSize = true;
            label16.Text = "";



            label2.Text = Form2.SetValueForRifle;
            label2.AutoSize = true;
            label3.Text = Form2.SetValueForRifle2;
            label3.AutoSize = true;
            label4.Text = Form2.SetValueForRifle3;
            label4.AutoSize = true;
            label5.Text = Form2.SetValueForRifle4;
            label5.AutoSize = true;
            label6.Text = Form2.SetValueForRifle5;
            label6.AutoSize = true;

            label7.Text = Form4.SetValueForRifle;
            label7.AutoSize = true;
            label8.Text = Form4.SetValueForRifle2;
            label8.AutoSize = true;
            label9.Text = Form4.SetValueForRifle3;
            label9.AutoSize = true;
            label10.Text = Form4.SetValueForRifle4;
            label10.AutoSize = true;






            label17.Text = Automatics.SetValueForRifle;
            label17.AutoSize = true;
            label18.Text = Revolvers.SetValueForRifle;
            label18.AutoSize = true;


            label19.Text = sideArmMods.SetValueForRifle;
            label19.AutoSize = true;
            label20.Text = sideArmMods.SetValueForRifle2;
            label20.AutoSize = true;
            label21.Text = sideArmMods.SetValueForRifle3;
            label21.AutoSize = true;
            label22.Text = sideArmMods.SetValueForRifle4;
            label22.AutoSize = true;


            label23.Text = sideArmAttachments.SetValueForRifle;
            label23.AutoSize = true;
            label24.Text = sideArmAttachments.SetValueForRifle2;
            label24.AutoSize = true;


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

                Muzzle = Form4.SetValueForRifle4,




                Automatic = Automatics.SetValueForRifle,

                Revolver = Revolvers.SetValueForRifle,

                Pistol_Barrel = sideArmMods.SetValueForRifle,

                Trigger = sideArmMods.SetValueForRifle2,

                Slide = sideArmMods.SetValueForRifle3,

                Frame = sideArmMods.SetValueForRifle4,

                Pistol_Muzzle = sideArmAttachments.SetValueForRifle,

                RailMount = sideArmAttachments.SetValueForRifle2







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




            public string Automatic
            {
                get;
                set;
            }

            public string Revolver
            {
                get;
                set;
            }




            public string Pistol_Barrel
            {
                get;
                set;
            }

            public string Trigger
            {
                get;
                set;
            }

            public string Slide
            {
                get;
                set;
            }

            public string Frame
            {
                get;
                set;
            }



            public string Pistol_Muzzle
            {
                get;
                set;
            }

            public string RailMount
            {
                get;
                set;
            }

        }

    }

}



