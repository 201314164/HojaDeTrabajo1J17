using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HojaDeTrabajo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);

                label1.Text = "A = " + a + " B = " + b;
                label2.Text = "La hipotenusa es de " + Convert.ToString(Hipotenusa(a, b));
            }
            catch { MessageBox.Show("Entradas incorrectas"); }

        }

        private double Hipotenusa(double a, double b)
        {

            double z = Math.Round(Math.Sqrt(a * a + b * b), 2);
            return z;
        }
    }
}
