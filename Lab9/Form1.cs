using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool displayClear = true;
        private bool dotClick = true;
       // private bool dotClick2 = true;
        private bool operbefore = false;
        private bool resulbefore = false;
       private string dotStr = ",";
       private bool dotClick2 = false;
        private bool m = false;
        public double mm = 0;


        private void digitbtn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           

            if (displayClear)
            {
                displayBox.Text = "";
                displayClear = false;
                
            }


            dotClick2 = displayBox.Text.Contains(dotStr);

            if (dotClick && btn.Text == "," && !(displayBox.Text == "") && !dotClick2)
            {
                displayBox.Text += btn.Text;
                dotClick = false;
                displayClear = false;
                operbefore = false;
                resulbefore = false;

            }
            else if ((operbefore == true) && (resulbefore == true))
            {
                displayBox.Text = "";
                displayClear = false;
                operbefore = false;
                resulbefore = false;
                calculate.operations = " ";
                dotClick = true;
            }


           
           

            if (!(btn.Text == ","))
            {
                displayBox.Text += btn.Text;
                displayClear = false;
                
            }



           

        }

        CalcBrain calculate = new CalcBrain();
        private void op_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           
                calculate.operations = btn.Text;
           //calculate.secondoperand = double.Parse(displayBox.Text);
            calculate.firstoperand = double.Parse(displayBox.Text);

           


            displayClear = true;
            
           operbefore = false;
           resulbefore = false;

            if (calculate.firstoperand > 0)
            {
                label1.Text = calculate.firstoperand.ToString();
                label1.Text += calculate.operations;
            }


            dotClick = true;

        }

        private void result_click(object sender, EventArgs e)
        {
            
            calculate.secondoperand = double.Parse(displayBox.Text);
            calculate.calculate();
            
            displayBox.Text = calculate.result.ToString();

            MessageBox.Show(calculate.operations + " " + calculate.firstoperand + " " + calculate.secondoperand + "" + dotClick + "    " + calculate.result);



            if (!(calculate.operations == " ")){
                operbefore = true;
                resulbefore = true;
                
                // dotClick2 = true;
                dotClick = true;
                // calculate.operations = " ";


            } else
            {
                operbefore = false;
                resulbefore = false;

                //calculate.operations = " ";
            }

       
           


        }

        private void c_click(object sender, EventArgs e)
        {
            calculate.firstoperand = 0;
            calculate.secondoperand = 0;
            displayClear = true;
            displayBox.Text = "0";
            label1.Text = " ";
            dotClick = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double tmr = 0;
            tmr = double.Parse(displayBox.Text);
            tmr *= -1;
            displayBox.Text = tmr.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string tmr2;
            tmr2 = displayBox.Text;
            if (tmr2.Length > 0)
           tmr2 = tmr2.Substring(0, tmr2.Length - 1); 
            displayBox.Text = tmr2;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            mm = double.Parse(displayBox.Text);
            m = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (m)
                displayBox.Text = mm.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (m)
            {
                mm = 0;
                m = false;
            }

        }
    }
}
