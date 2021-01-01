using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4
{
    public partial class Form1 : Form
    {
        public int area1, area2;
        public Form1()
        {
            int area1 = Convert.ToInt32(label12);
            int area2 = Convert.ToInt32(label13);
            InitializeComponent();

        }
        public void funktion()
        {
            label11.Text = Convert.ToString(area1 / area2) ;
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            var g = pictureBox1.CreateGraphics();
            Func<string, Point> convert = (s) => new Point(int.Parse(s.Split(',')[0]), int.Parse(s.Split(',')[1]));

            var point1 = convert(textBox1.Text);
            var point2 = convert(textBox2.Text);
            var point3 = convert(textBox3.Text);
            var point4 = convert(textBox8.Text);

            g.DrawLines(new Pen(Color.Red, 1), new[] { point1, point2, point3, point4 });
            double area = 0;
            area1 = Convert.ToInt32(Math.Sqrt(Math.Pow(Math.Abs(point2.X-point1.X),2) + Math.Pow(Math.Abs(point2.Y - point1.Y), 2) + Math.Sqrt(Math.Pow(Math.Abs(point3.X - point2.X), 2) + Math.Pow(Math.Abs(point3.Y - point2.Y), 2) + Math.Sqrt(Math.Pow(Math.Abs(point4.X - point3.X), 2) + Math.Pow(Math.Abs(point4.Y - point3.Y), 2)))));
            label12.Text = Convert.ToString(area1);
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            var g = pictureBox2.CreateGraphics();

            Func<string, Point> convert = (s) => new Point(int.Parse(s.Split(',')[0]), int.Parse(s.Split(',')[1]));

            var point1 = convert(textBox4.Text);
            var point2 = convert(textBox5.Text);
            var point3 = convert(textBox6.Text);
            var point4 = convert(textBox7.Text);

            g.DrawLines(new Pen(Color.Green, 1), new[] { point1, point2, point3, point4, point1 });
            double area = 0;
            area2 = Convert.ToInt32(Math.Sqrt(Math.Pow(Math.Abs(point2.X - point1.X), 2) + Math.Pow(Math.Abs(point2.Y - point1.Y), 2) + Math.Sqrt(Math.Pow(Math.Abs(point3.X - point2.X), 2) + Math.Pow(Math.Abs(point3.Y - point2.Y), 2) + Math.Sqrt(Math.Pow(Math.Abs(point4.X - point3.X), 2) + Math.Pow(Math.Abs(point4.Y - point3.Y), 2) + Math.Sqrt(Math.Pow(Math.Abs(point1.X - point4.X), 2) + Math.Pow(Math.Abs(point1.Y - point4.Y), 2))))));
            label13.Text = Convert.ToString(area2);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            funktion();
        }
    }
}
