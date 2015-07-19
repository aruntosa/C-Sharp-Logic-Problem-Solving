using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();//instantiating the random class
        
        int num1, num2, ans, guess;//declaring the variables
        string oprn;
        int correct = 0; //initialize the counters
        int incorrect = 0;


        public Form1()
        {
            InitializeComponent();
        }
        public void SetTheGame()
        {
                oprn = this.txtopr.SelectedItem.ToString(); // choosing the operation

                if (this.radioButton1.Checked == true)
                {
                    num1 = rand.Next(1,10); //generate the rndom nos.for grade1
                    num2 = rand.Next(1,10) ;
                }
                else
                {
                    num1 = rand.Next(10,100); //generate the random nos for grade2
                    num2 = rand.Next(10,100);
                }
                if (oprn == "-") //validate minus operation
                {
                    if (num1 < num2)
                    {
                        int swapValues;
                        swapValues = num2;
                        num2 = num1;
                        num1  = swapValues;
                    }
                    
                
                    else if (oprn == "/") //validate division operation
                    {
                        if (num1 % num2 != 0)
                            num1 = num2 * 2;
                    }
                 }
                 this.txtnum1.Text = num1.ToString(); //assigning random nos. to textboxes
                 this.txtnum2.Text = num2.ToString();
            }

            private void Button1_Click(object sender, EventArgs e)
            {
                string guessPattern = @"^[0-9]\d*(\d+)?$"; //regular expression validation
                string errmsg = "";
                if (this.txtguess.Text == "")
                { errmsg = errmsg + "Pls enter your answer"; }
                else if (Regex.IsMatch(this.txtguess.Text, guessPattern) == false)
                    errmsg = errmsg + "Pls enter again";

                if (errmsg.Length == 0)
                {

                    num1 = Convert.ToInt32(this.txtnum1.Text);
                    num2 = Convert.ToInt32(this.txtnum2.Text);
                    guess = Convert.ToInt32(this.txtguess.Text);

                    if (oprn == "+")
                    { ans = num1 + num2; }
                    else if (oprn == "-")
                    { ans = num1 - num2; }
                    else if (oprn == "*")
                    { ans = num1 * num2; }
                    else
                    { ans = num1 / num2; }

                    if (guess == ans)//validate the guess against correct answer
                    {
                        correct = correct + 1;//update counters
                        this.txtcorrect.Text = correct.ToString();
                        MessageBox.Show("Yes, that is correct");
                        txtguess.Clear();
                        SetTheGame();
                        txtguess.Focus();
                    }
                    else
                    {
                        incorrect = incorrect + 1;
                        this.txtincorrect.Text = incorrect.ToString();
                        MessageBox.Show("Sorry, Wrong answer");
                        txtguess.Clear();
                        SetTheGame();
                        txtguess.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(errmsg);
                    this.txtguess.Clear();
                    this.txtguess.Focus();
                }      
                }
                private void radioButton1_CheckedChanged(object sender, EventArgs e)
                {
                    this.SetTheGame();
                }

                private void radioButton2_CheckedChanged(object sender, EventArgs e)
                {
                    this.SetTheGame();
                }    
            }
    }
