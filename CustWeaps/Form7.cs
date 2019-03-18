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
                WeaponName = "Weapon Name\n\n\n",


                TopPiece = "Top Piece\n",

                Reciver = "Reciver\n",

                Barrel = "Barrel\n",

                Stock = "Stock\n",

                Handguard = "Handguard\n\n",


                Optic = "Optic\n",

                Underbarrel = "Underbarrel\n",

                SideRails = "Side Rails\n",

                Muzzle = "Muzzle"


            });


            string json = JsonConvert.SerializeObject(_data.ToArray());


            System.IO.File.WriteAllText(@"C:\Users\s188041\source\repos\Weapon-Customizer\CustWeaps\bin\Debug\CustomGun.json", json);

            Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

       
    }

    public class UserData
    {
        public string WeaponName
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
