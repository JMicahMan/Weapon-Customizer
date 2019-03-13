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


namespace CustWeaps
{

    public class Data
    {
        public string member0;

        public string member1;
        public string member2;
        public string member3;
        public string member4;
        public string member5;
        public string member6;
        public string member7;
        public string member8;
        public string member9;
        [XmlIgnore]
        public string member10;

        public Data()
        {
            member0 = "*none*";

            member1 = "*none*";
            member2 = "*none*";
            member3 = "*none*";
            member4 = "*none*";
            member5 = "*none*";

            member6 = "*none*";
            member7 = "*none*";
            member8 = "*none*";
            member9 = "*none*";
            member10 = "*nani*";
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
            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            TextWriter writer = new StreamWriter("gun.xml");

            Data obj = new Data();
            serializer.Serialize(writer, obj);
            writer.Close();



            Properties.Settings.Default.Save();


            Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

    }
}
