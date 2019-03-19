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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
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

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            
            //if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string strfilename = openFileDialog.FileName;
            //    MessageBox.Show(strfilename);
            //}

            string json = JsonConvert.SerializeObject(_data.ToArray());


            System.IO.File.WriteAllText(@"C:\Users\s188041\source\repos\Weapon-Customizer\CustWeaps\bin\Debug\CustomGun.json", json);

            Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

       
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
