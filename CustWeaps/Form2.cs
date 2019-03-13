using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustWeaps
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void TopPiece_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(TopPiece, new Point(0, TopPiece.Height));
        }

        public void Receiver_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(Receiver, new Point(0, Receiver.Height));
        }

        public void Barrel_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(Barrel, new Point(0, Barrel.Height));
        }

        public void Stock_Click(object sender, EventArgs e)
        {
            contextMenuStrip4.Show(Stock, new Point(0, Stock.Height));
        }

        public void Handgaurd_Click(object sender, EventArgs e)
        {
            contextMenuStrip5.Show(Handgaurd, new Point(0, Handgaurd.Height));
        }

        public void Continue_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

    }
}
