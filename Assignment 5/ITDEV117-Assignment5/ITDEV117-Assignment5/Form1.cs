using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITDEV117_Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double val, total, avg, devn;  //declaring variables
            int count = this.listBox1.Items.Count;
            int intX;
            total = 0;

            //Average calculation
            for (intX = 0; intX < count; intX++)
            {
                val = Convert.ToDouble(this.listBox1.Items[intX].ToString());
                total = total + val;
            }
            avg = Math.Round(total / count, 1);   //average calculation to one decimal place         
            this.txtAvg.Text = avg.ToString();    //sending the average value to text box
            
            //Maximum, minimum and range calculation

            int[] numbers = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                object ret = listBox1.Items[i];
                numbers[i] = Convert.ToInt16(ret);
            }
            int min = numbers[0];  //variable declaration
            int max = numbers[0];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (min > numbers[i]) min = numbers[i];
                if (max < numbers[i]) max = numbers[i];
            }
            this.txtMax.Text = max.ToString();
            this.txtMin.Text = min.ToString();
            int range = max - min;  //range calculation
            this.txtRange.Text = range.ToString();

            //Standard deviation calulation

            double dtotal = 0; //variable declaration          
            for (intX = 0; intX < listBox1.Items.Count; intX++)
            {
                dtotal = dtotal + Math.Pow(numbers[intX] - avg, 2);
            }
            devn = Math.Round(Math.Sqrt(dtotal / (count - 1)), 1);
            this.txtStdDeviation.Text = devn.ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
