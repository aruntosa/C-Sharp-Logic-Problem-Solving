using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btncalc_Click(object sender, EventArgs e)
        {
            decimal taxes = 0, income, taxesdue;
            income = decimal.Parse(this.txtinc.Text);
            if (this.radsin.Checked == true)
            {
                if (income <= 8700) taxes = .10m * income;
                else if (income <= 35350) taxes = ((income - 8700) * .15m) + 870m;
                else if (income <= 85650) taxes = ((income - 35350) * .25m) + 4867.50m;
                else if (income <= 178650) taxes = ((income - 85650) * .28m) + 17442.50m;
                else MessageBox.Show("Try again");
            }
            else
            {
                if (income <= 17400) taxes = .10m * income;
                else if (income <= 70700) taxes = ((income - 17400) * .15m) + 1740m;
                else if (income <= 142700) taxes = ((income - 70700) * .25m) + 9735m;
                else if (income <= 217450) taxes = ((income - 142700) * .28m) + 27735m;
                else MessageBox.Show("Try again");
            }
            taxesdue = taxes;
            taxesdue = Math.Round(taxes, 2);
            this.txtdue.Text = taxesdue.ToString();
        }
    }
}
