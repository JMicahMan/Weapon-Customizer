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



namespace CustWeaps
{

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void Finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Save_Click(object sender, EventArgs e)
        {
            UserData udOBj = new UserData()
            {
                WeaponName = "Weapon Name",

                TopPiece = "Top Piece",
                Reciver = "Reciver",
                Barrel = "Barrel",
                Stock = "Stock",
                Handguard = "Handgaurd",

                Optic = "Optic",
                Underbarrel = "Under Barrel",
                SideRails = "Side Rails",
                Muzzle = "Muzzle"

            };

            DataContractJsonSerializer Jser = new DataContractJsonSerializer(typeof(UserData));
            MemoryStream msObj = new MemoryStream();
            Jser.WriteObject(msObj, udOBj);
            msObj.Position = 0;
            string json = JsonConvert.SerializeObject(udOBj);
          

            Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

    }
}
