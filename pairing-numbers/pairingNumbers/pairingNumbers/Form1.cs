using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pairingNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random beep = new Random();
            for(int boop = 0; boop < 10; boop++)
            {
                numsBox.Items.Add(beep.Next(1,31));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
