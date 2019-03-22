using System;
using System.IO;
using System.Windows.Forms;



namespace CustWeaps
{
    public partial class Form6 : Form
    {

        
        public Form6()
        {
            InitializeComponent();
        }

        public void SavedGun_Click(object sender, EventArgs e)
        {

           textBox1.Text =  File.ReadAllText("CustomGun.json");


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
