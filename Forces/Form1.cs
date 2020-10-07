using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double X=double.Parse(textBox1.Text);
            double angle = sin(X);
            label1.Text = "Angle=" + angle;
        }

        double sin(double X)
        {
            return (Math.Sin(X * Math.PI / 180.0));
        }

        double asin(double X)
        {
            return (Math.Asin(X) * 180 / Math.PI);
        }

        double cos(double X)
        {
            return (Math.Cos(X * Math.PI / 180.0));
        }

        double acos(double X)
        {
            return (Math.Acos(X) * 180 / Math.PI);
        }

        double Tan(double X)
        {
            return (Math.Tan(X * Math.PI / 180.0));
        }

        double atan(double X)
        {
            return (Math.Atan(X) * 180 / Math.PI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
