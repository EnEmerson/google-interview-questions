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
        // will contain the sorted list of ints
        int[] numbers = new int[10];

        // inclusive
        private static int MIN_VAL = 1;
        // exclusive
        private static int MAX_VAL = 31;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create a new random generator
            Random rand = new Random();
            // create 10 new random ints between the max and min values
            for(int x = 0; x < numbers.Length; x++)
            {
                int nextInt = rand.Next(MIN_VAL, MAX_VAL);
                numbers[x] = nextInt;

            }

            // sort the array of ints, ascending
            Array.Sort(numbers);
            // put the sorted list of numbers into the listbox so we can see them in the UI
            foreach(int i in numbers)
            {
                numsBox.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             * 1. Iterate through the array
             * 2. Subtract current value from the target number
             * 3. Check if remainder exists in array
             */
        }
    }
}
