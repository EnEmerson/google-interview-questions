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
        int[] numbers = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random beep = new Random();
            for(int boop = 0; boop < 10; boop++)
            {
                int bip = beep.Next(1, 31);
                numbers[boop] = bip;

            }

            Array.Sort(numbers);

            foreach(int i in numbers)
            {
                numsBox.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int oof = 0;
            bool isTestable = int.TryParse(testBox.Text, out oof);

            if(!isTestable)
            {
                MessageBox.Show("enter a testable integer please");
            }
            else
            {
                MessageBox.Show("temporary success");
            }


        }
    }
}
