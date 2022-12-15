using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Maquina_Expendedora
{
    public partial class Form1 : Form
    {
        public static string contraseña = "Porter";
        public int precio = 0;
        public static string Prom = "";
        public static int total = 0;
        bool firstime = true;
        
        
        public static int Mordisko = 10;
        public static int Classic_Magnum = 10;
        public static int Bob_esponja = 10;
        public static int Solero = 10;
        public static int Lapiz_de_Color = 10;
        public static int Nesquik = 10;
        public static int Oreo = 10;
        public static int Pinta_Lengua = 10;
        public static int Choco = 10;

        public static int PreMordisko = 25;
        public static int PreClassic_Magnum = 20;
        public static int PreBob_esponja = 15 ;
        public static int PreSolero = 15;
        public static int PreLapiz_de_Color = 15;
        public static int PreNesquik = 18;
        public static int PreOreo = 15;
        public static int PrePinta_Lengua = 16;
        public static int PreChoco = 10;

        private void temp(int time)
        {
            for (int a = 0; a < time; a++)
            {
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();    
            }
        }
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
            Form2 ven3 = new Form2();
            ven3.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label6.Text = "$" + PreMordisko;
            label7.Text = "$" + PreClassic_Magnum;
            label8.Text = "$" + PreBob_esponja;
            label17.Text = "$" + PreSolero;
            label18.Text = "$" + PreLapiz_de_Color;
            label19.Text = "$" + PreNesquik;
            label20.Text = "$" + PreOreo;
            label21.Text = "$" + PrePinta_Lengua;
            label22.Text = "$" + PreChoco;

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

        private void button19_Click(object sender, EventArgs e)
        {
            Efectivo ven2 = new Efectivo();
            ven2.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            total += 1;
            textBox10.Text = Convert.ToString(total);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            total += 2;
            textBox10.Text = Convert.ToString(total);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            total += 5;
            textBox10.Text = Convert.ToString(total);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            total += 10;
            textBox10.Text = Convert.ToString(total);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            total += 20;
            textBox10.Text = Convert.ToString(total);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            total += 50;
            textBox10.Text = Convert.ToString(total);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            total += 100;
            textBox10.Text = Convert.ToString(total);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            total += 200;
            textBox10.Text = Convert.ToString(total);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Prom = Convert.ToString(precio);
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
           
                Form3 ven3 = new Form3();
                ven3.Show();
             
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "#A1")
            {
                if (total < PreMordisko)
                {
                    label25.Text = "Cantidad insuficiente";
                    textBox10.Text = "Su cambio es " + total;
                }
                else
                {
                    if (Mordisko < 1)
                    {
                        textBox10.Text = "Sin disponibilidad";
                    }
                    else
                    {
                        total = total - PreMordisko;
                        Mordisko = Mordisko - 1;
                        textBox10.Text = "Su cambio es " + total;
                    }
                }
            }
            else if (textBox9.Text == "#B1")
            {
                if (total < PreClassic_Magnum)
                {
                    label25.Text = "Cantidad insuficiente";
                    textBox10.Text = "Su cambio es " + total;
                }
                else
                {
                    if (Classic_Magnum < 1)
                    {
                        textBox10.Text = "Sin disponibilidad";
                    }
                    else
                    {
                        total = total - PreClassic_Magnum;
                        Classic_Magnum = Classic_Magnum - 1;
                        textBox10.Text = "Su cambio es " + total;
                    }
                }
            }
            else if (textBox9.Text == "#C2")
            {
                if (total < PreBob_esponja)
                {
                    label25.Text = "Cantidad insuficiente";
                    textBox10.Text = "Su cambio es " + total;
                }
                else
                {
                    if (Bob_esponja < 1)
                    {
                        textBox10.Text = "Sin disponibilidad";
                    }
                    else
                    {
                        total = total - PreBob_esponja;
                        Bob_esponja = Bob_esponja - 1;
                        textBox10.Text = "Su cambio es " + total;
                    }
                }
            }
            else if (textBox9.Text == "#D2")
            {
                if (total < PreSolero)
                {
                    label25.Text = "Cantidad insuficiente";
                    textBox10.Text = "Su cambio es " + total;
                }
                else
                {
                    if (Solero < 1)
                    {
                        textBox10.Text = "Sin disponibilidad";
                    }
                    else
                    {
                        total = total - PreSolero;
                        Solero = Solero - 1;
                        textBox10.Text = "Su cambio es " + total;
                    }
                }
            }
            else if (textBox9.Text == "#A3")
            {
                if (total < PreLapiz_de_Color)
                {
                    label25.Text = "Cantidad insuficiente";
                    textBox10.Text = "Su cambio es " + total;
                }
                else
                {
                    if (Lapiz_de_Color < 1)
                    {
                        textBox10.Text = "Sin disponibilidad";
                    }
                    else
                    {
                        total = total - PreLapiz_de_Color;
                        Lapiz_de_Color = Lapiz_de_Color - 1;
                        textBox10.Text = "Su cambio es " + total;
                    }
                }
            }
            else if (textBox9.Text == "#B3")
            {
                if (total < PreNesquik)
                {
                    label25.Text = "Cantidad insuficiente";
                    textBox10.Text = "Su cambio es " + total;
                }
                else
                {
                    if (Nesquik < 1)
                    {
                        textBox10.Text = "Sin disponibilidad";
                    }
                    else
                    {
                        total = total - PreNesquik;
                        Nesquik = Nesquik - 1;
                        textBox10.Text = "Su cambio es " + total;
                    }
                }
            }
            else if (textBox9.Text == "#C4")
            {
                if (total < PreOreo)
                {
                    label25.Text = "Cantidad insuficiente";
                    textBox10.Text = "Su cambio es " + total;
                }
                else
                {
                    if (Oreo < 1)
                    {
                        textBox10.Text = "Sin disponibilidad";
                    }
                    else
                    {
                        total = total - PreOreo;
                        Oreo = Oreo - 1;
                        textBox10.Text = "Su cambio es " + total;
                    }
                }
            }
            else if (textBox9.Text == "#D4")
            {
                if (total < PrePinta_Lengua)
                {
                    label25.Text = "Cantidad insuficiente";
                    textBox10.Text = "Su cambio es " + total;
                }
                else
                {
                    if (Pinta_Lengua < 1)
                    {
                        textBox10.Text = "Sin disponibilidad";
                    }
                    else
                    {
                        total = total - PrePinta_Lengua;
                        Pinta_Lengua = Pinta_Lengua - 1;
                        textBox10.Text = "Su cambio es " + total;
                    }
                }
            }
            else if (textBox9.Text == "#C5")
            {
                if (total < PreChoco)
                {
                    label25.Text = "Cantidad insuficiente";
                    textBox10.Text = "Su cambio es " + total;
                }
                else
                {
                    if (Choco < 1)
                    {
                        textBox10.Text = "Sin disponibilidad";
                    }
                    else
                    {
                       total = total - PreChoco;
                        Choco = Choco - 1;
                        textBox10.Text = "Su cambio es " + total;
                    }
                }
            }
            else
            {
                label25.Text = "Hubo un error";
            }

            temp(100);
            textBox10.Text  = "";
            total= 0;
            textBox9.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            label6.Text = "$" + PreMordisko;
            label7.Text = "$" + PreClassic_Magnum;
            label8.Text = "$" + PreBob_esponja;
            label17.Text = "$" + PreSolero;
            label18.Text = "$" + PreLapiz_de_Color;
            label19.Text = "$" + PreNesquik;
            label20.Text = "$" + PreOreo;
            label21.Text = "$" + PrePinta_Lengua;
            label22.Text = "$" + PreChoco;

            label5.Text = "" + Mordisko;
            label16.Text = "" + Classic_Magnum;
            label15.Text = "" + Bob_esponja;
            label14.Text = "" + Solero;
            label13.Text = "" + Lapiz_de_Color;
            label12.Text = "" + Nesquik;
            label11.Text = "" + Oreo;
            label9.Text = "" + Pinta_Lengua;
            label23.Text = "" + Choco;
        }
    }

}
