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
            label1.Text = label2.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label2.Text = "";
            try {
                if (Vocal(textBox1.Text))
                {
                    label1.Text = "CUMPLE";
                }
                else
                {
                    label1.Text = "NO CUMPLE";
                    if (textBox1.TextLength == 0)
                    {
                        MessageBox.Show("Ingrese en la Caja 1");
                    }
                }
            }
            catch {  }
        }

        bool Vocal(string text)
        {
           
            bool a, e, i, o, u;
            a = false;
            e = false;
            i = false;
            o = false;
            u = false;

            foreach (char c in text.ToUpper())
            {
                int d = Convert.ToInt32(c);
                if (d == 65)
                {
                    a = true;
                }
                else if (d == 69)
                {
                    e = true;
                }
                else if (d == 73)
                {
                    i = true;
                }
                else if (d == 79)
                {
                    o = true;
                }
                else if (d == 85)
                {
                    u = true;
                }


            }
            if (a == true && e == true && i == true && o == true && u == true) {
                return true;
            }

            else
	{
                return false;

            } }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label2.Text = "";
            try
            {
               label1.Text= Invertir(textBox1.Text, textBox2.Text);
            }
            catch
            {

                
            }
        }

        private string Invertir(string text1, string text2)
        {
            string palabra1 = "";
            string palabra2 = "";
            foreach(char cc in text1)
            {
                palabra1 = cc + palabra1;
            }
            foreach (char cc in text2)
            {
                palabra2 = cc + palabra2;
            }
            return palabra1 + " " + palabra2 + "_201314164";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label2.Text = "";
            double n1, n2, n3;
            

            try {
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                n3 = Convert.ToDouble(textBox3.Text);
                label1.Text = n1 + " es a " + n2;
                label2.Text = "Como " + n3 + " es a " + Regla3(n1, n2, n3);
            }
            catch { MessageBox.Show("Entrada incorrecta, por favor ingrese numeros");}
        }

        private double Regla3(double n1, double n2, double n3)
        {
            return Math.Round((n2 * n3) / n1,2);
        }

       
    } }