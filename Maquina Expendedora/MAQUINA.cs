using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Maquina_Expendedora
{
    public partial class Form1 : Form
    {
        bool firstime = true;
        List<string> clave = new List<string>();
        List<int> precios = new List<int>();
        List<string> nombre = new List<string>();


        public Form1()

        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            precios.Add(25);
            precios.Add(30);
            precios.Add(15);
            precios.Add(15);
            precios.Add(15);
            precios.Add(18);
            precios.Add(15);
            precios.Add(16);

            clave.Add("#A1");
            clave.Add("#B1");
            clave.Add("#C2");
            clave.Add("#D2");
            clave.Add("#A3");
            clave.Add("#B3");
            clave.Add("#C4");
            clave.Add("#D4");

            nombre.Add("Mordisko");
            nombre.Add("Magnum Classic");
            nombre.Add("Bob Esponja");
            nombre.Add("Solero");
            nombre.Add("Lápiz de color");
            nombre.Add("Nesquik");
            nombre.Add("Oreo");
            nombre.Add("Pinta lengua");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (firstime)
                {
                    textBox9.Text = "";
                    firstime = false;
                }
                textBox9.Text += "A";

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "B";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "C";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "D";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (firstime)
            {
                textBox9.Text = "";
                firstime = false;
            }
            textBox9.Text += "#";
        }

    }

}
