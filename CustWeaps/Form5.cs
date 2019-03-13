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
            //XmlSerializer serializer = new XmlSerializer(typeof(Form5));
            //TextWriter writer = new StreamWriter("output.xml");

            //Form5 obj = new Form5();
            //serializer.Serialize(writer, obj);
            //writer.Close();

            //Console.WriteLine("Data Saved");

            Properties.Settings.Default.Save();


            Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

    }
}
