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
            // clear out any old numbers that may remain
            numsBox.Items.Clear();
            // create a new random generator
            Random rand = new Random();
            // fill array with 10 new random ints between the max and min values
            for(int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = rand.Next(MIN_VAL, MAX_VAL);
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
            /* Algorithm:
             * 1. Iterate through the array
             * 2. Subtract current value from the target number
             * 3. Check if remainder exists in array
             */

            // check if target number data is valid
            int targetNumber = 0;
            bool goodData = Int32.TryParse(testBox.Text, out targetNumber);
            if (goodData && (MIN_VAL <= targetNumber))
            {
                // set target number from the test box input
                targetNumber = int.Parse(testBox.Text);
                // 1. begin iteration thru numbers array
                for (int num = 0; num < numbers.Length; num++)
                {
                    int currentNumber = numbers[num];
                    // 2. subtract current value from the target number
                    int remainder = targetNumber - currentNumber;
                    // 3a. iterate through rest of array
                    for (int checkNum = num + 1; checkNum < numbers.Length; checkNum++)
                    {
                        int nextNumber = numbers[checkNum];
                        // 3b. check if remainder is in the array
                        if (remainder == nextNumber)
                        {
                            // found a match!
                            MessageBox.Show("Match found! \r\n'"
                                + currentNumber + "' at index: [" + num + "]"
                                + "\r\n AND \r\n'"
                                + nextNumber + "' at index: [" + checkNum + "]\r\n"
                                + " add up to the target number: '" + targetNumber + "'");
                            Application.Exit();
                        }
                    }
                }
                // none of the numbers match
                MessageBox.Show("No two integers in this list add up to the target number.");
            }
            else
            {
                MessageBox.Show("Bad input data");
            }
        }
    }
}
