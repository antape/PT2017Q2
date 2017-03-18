using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWeek9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void btn_click(object sender, EventArgs e)
        {
            
            //label1.Text = i.ToString();

           // i++;
            //textBox1.Text = i.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // String name = textBoxName.Text;
            //MessageBox.Show(name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool displayClear = true;
        private bool dotClick = true;
        private void digit_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (displayClear)
            {
                display.Text = "";
                displayClear = false;

            }
            if (dotClick && btn.Text == ",")
            {

            }

           
            display.Text = "test";
        }

        CalcBrain calcbrain = new CalcBrain();
        private void opbtn_click(object sender, EventArgs e)
        {
            calcbrain.first = double.Parse(display.Text);

        }
    }
}
