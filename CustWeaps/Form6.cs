using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;



namespace CustWeaps
{
    public partial class Form6 : Form
    {
        public bool LoadedGun;

        OpenFileDialog openFileDialog = new OpenFileDialog();
        public Form6()
        {
            InitializeComponent();

            LoadedGun = false;

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
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


            public bool LoadedAGun = true;

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

        public void SavedGun_Click(object sender, EventArgs e)
        {



            textBox1.Text =  File.ReadAllText("CustomGun.json");


            // var loader = JsonConvert.DeserializeObject<UserData>("CustomGun.json");

            


            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";

            LoadedGun = true;

            Hide();
            Form5 form5 = new Form5(this);
            form5.Show();


        }







    }
}
