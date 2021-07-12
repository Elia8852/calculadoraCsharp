using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWindows
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        classes.ClassAdiction obj1 = new classes.ClassAdiction();
        classes.ClassSubtraction obj2 = new classes.ClassSubtraction();
        classes.Classmultiplication obj3 = new classes.Classmultiplication();
        classes.ClassDivision obj4 = new classes.ClassDivision();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
       

       

       

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +  "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnAdiction_Click(object sender, EventArgs e)
        {
            operador = "+" ;
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnultiplication_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textBox1.Text);

            double Addic;
            double Subc;
            double multip;
            double divi;

            switch (operador)
            {
                case "+":
                    Addic = obj1.Adiction((primero),(segundo));
                    textBox1.Text = Addic.ToString();
                    break;
                case "-":
                    Subc = obj2.Subtraction((primero), (segundo));
                    textBox1.Text = Subc.ToString();
                    break;
                case "*":
                    multip = obj3.multiplication((primero), (segundo));
                    textBox1.Text = multip.ToString();
                    break;
                case "/":
                    divi = obj4.Division((primero), (segundo));
                    textBox1.Text = divi.ToString();
                    break;
                default:
                    break;


            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
    }
}
