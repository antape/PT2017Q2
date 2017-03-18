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
        private bool operbefore = false;
        
        private void digitbtn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (displayClear)
            {
                displayBox.Text = "";
                displayClear = false;
            }

            if (operbefore)
            {
                displayBox.Text = "";
                displayClear = false;
                operbefore = false;
                
            }

            if (dotClick && btn.Text == ".")
            {
                displayBox.Text += btn.Text;
                dotClick = false;
            }
            if (!(btn.Text == "."))
            {
                displayBox.Text += btn.Text;
                
            }

            if (calculate.firstoperand > 0) { 
            label1.Text = calculate.firstoperand.ToString();
            label1.Text += calculate.operations;
            }
        }

        CalcBrain calculate = new CalcBrain();
        private void op_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            calculate.operations = btn.Text;
            calculate.firstoperand = double.Parse(displayBox.Text);
            
            displayClear = true;

            
        }

        private void result_click(object sender, EventArgs e)
        {
           

            calculate.secondoperand = double.Parse(displayBox.Text);
           
            calculate.calculate();
            displayBox.Text = calculate.result.ToString();
           
            operbefore = true;
            

        }

        private void c_click(object sender, EventArgs e)
        {
            calculate.firstoperand = 0;
            calculate.secondoperand = 0;
            displayClear = true;
            displayBox.Text = "0";
        }
    }
}
