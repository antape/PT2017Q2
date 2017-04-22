using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWeekForm12
{
    public partial class Form1 : Form
    {
        Shapes currentShape = Shapes.Free;
        Pen pen = new Pen(Color.Black, 2);
        Point start, current, end;
        Bitmap bmp;
        GraphicsPath gp = new GraphicsPath;
        Graphics g;

        private void numericUoDown_ValuecChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage; 
        }

        private void pir1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
    enum Shapes { Free, Line, Ellipse, Reactangle, Trangle };
}
