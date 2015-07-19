using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_Assignment
{
    public partial class Form1 : Form
    {
        int[] scores; //declare array
        public Form1()
        {
            InitializeComponent();
            int intx, num = this.listBox1.Items.Count; //declare variables
            scores = new int[num];
            for (intx = 0; intx < num; intx++)
                scores[intx] = Convert.ToInt32(this.listBox1.Items[intx].ToString()); //convert the listbox items to integers
            Array.Sort(scores);  // sort listbox items
        }       
             
        private void button1_Click(object sender, EventArgs e)
        {
            string fullsort = " "; //declare string variables
            string oddsort = " ";
            string evensort = " ";
            foreach (string item in listBox1.Items)
            {
                fullsort += item + "\n ";

            }
            if (radioButton1.Checked == true)
            {
                this.richTextBox1.Text = "Here is the Full List\n" + fullsort; //this popsup the full list sorted in the rich text box
            }
            if (radioButton2.Checked == true)
            {
                foreach (string item in listBox1.Items)   
                    if (Convert.ToInt32(item) % 2 == 0)   //converting to integer and displaying only even nos. in the richtextbox
                        evensort += item + "\n ";

                this.richTextBox1.Text = "Here is the Even List\n" + evensort;
            }
            else if (radioButton3.Checked == true)
            {
                foreach (string item in listBox1.Items)
                    if (Convert.ToInt32(item) % 2 != 0) //converting to integer and displaying only odd nos. in the richtextbox
                        oddsort += item + "\n ";

                this.richTextBox1.Text = "Here is the Odd List\n" + oddsort;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int intx, intcount = 0;                                                 //calculation to find out the number of times the particular number occurs
            int num1 = Convert.ToInt32(this.textBox2.Text);
            for (intx = 0; intx < scores.Length; intx++)
                if (scores[intx] == num1) intcount++;
            this.richTextBox1.Text = "The number " + num1.ToString() + " occurs " + intcount.ToString() + " times";
        }

        private void button3_Click(object sender, EventArgs e)                      //calculation to find out the numbers divisible by the given number
        {
            string divisibleList = " ";
            int intDivisible = Convert.ToInt32(this.textBox3.Text);
            foreach (string item in listBox1.Items)
                if (Convert.ToInt32(item) % intDivisible == 0)
                    divisibleList += item + "\n ";

            this.richTextBox1.Text = "These are the numbers divisible by  " + intDivisible + "\n" + divisibleList;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string higherList = " ";                                                //calculation to find out the numbers higher than the given number
            int intHigher = Convert.ToInt32(this.textBox4.Text);
            foreach (string item in listBox1.Items)
                if (Convert.ToInt32(item) > intHigher)
                    higherList += item + "\n ";

            this.richTextBox1.Text = "These are the numbers higher than  " + intHigher + "\n" + higherList;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){}
        private void radioButton1_CheckedChanged(object sender, EventArgs e){}
    }
}
