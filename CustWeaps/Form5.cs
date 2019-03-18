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
            //UserData udOBj = new UserData()
            //{
            //    WeaponName = "Weapon Name",

            //    TopPiece = "Top Piece",
            //    Reciver = "Reciver",
            //    Barrel = "Barrel",
            //    Stock = "Stock",
            //    Handguard = "Handgaurd",

            //    Optic = "Optic",
            //    Underbarrel = "Under Barrel",
            //    SideRails = "Side Rails",
            //    Muzzle = "Muzzle"

            //};

            //DataContractJsonSerializer Jser = new DataContractJsonSerializer(typeof(UserData));
            //MemoryStream msObj = new MemoryStream();
            //Jser.WriteObject(msObj, udOBj);
            //msObj.Position = 0;
            //string json = JsonConvert.SerializeObject(udOBj);
            //StreamReader sr = new StreamReader(msObj);
            //string JSS = sr.ReadToEnd();
            //var filepath = Path.Combine(Directory.GetCurrentDirectory(), "CustomWeapon.json");

            //sr.Close();
            //msObj.Close();



            //string UserData = @"{
            //'WeaponName',
            //'TopPiece',
            //'Reciver',
            //'Barrel',
            //'Stock',
            //'Handguard',
            //'Optic',
            //'Underbarrel',
            //'SideRails',
            //'Muzzle'}";


            //JsonTextReader reader = new JsonTextReader(new StringReader(UserData));
            //while (reader.Read()) ;
            //{
            //    if (reader.Value != null)
            //    {
            //        Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
            //    }

            //    else
            //    {
            //        Console.WriteLine("Token: {0}", reader.TokenType);
            //    }
            //}


            //dynamic UserData = new ExpandoObject();

            //UserData.WeaponName = "Weapon Name";

            //UserData.TopPiece = "Top Piece";
            //UserData.Reciver = "Reciver";
            //UserData.Barrel = "Barrel";
            //UserData.Stock = "Stock";
            //UserData.Handguard = "Handguard";

            //UserData.Optic = "Optic";
            //UserData.Underbarrel = "Underbarrel";
            //UserData.SideRails = "Side Rails";
            //UserData.Muzzle = "Muzzle";

            //List<string> articles = new List<string>();
            //articles.Add("Custom Gun");

            //UserData.articles = articles;

            //string json = JsonConvert.SerializeObject(UserData);
            //var filepath = Path.Combine(Directory.GetCurrentDirectory(), "CustomWeapon.json");

            //Console.WriteLine(json);

           

    

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

                Muzzle = "Muzzle\n"


            });


            string json = JsonConvert.SerializeObject(_data.ToArray());

      
            System.IO.File.WriteAllText(@"C:\Users\s188041\source\repos\Weapon-Customizer\CustWeaps\bin\Debug\CustomGun.json", json);



            Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

    }
}
