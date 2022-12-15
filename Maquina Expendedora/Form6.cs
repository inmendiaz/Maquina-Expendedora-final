using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquina_Expendedora
{
    public partial class Form6 : Form
    {


        int eMordisko = 10;
        int eClassic_Magnum = 10;
        int eBob_esponja = 10;
        int eSolero = 10;
        int eLapiz_de_Color = 10;
        int eNesquik = 10;
        int eOreo = 10;
        int ePinta_Lengua = 10;
        int eChoco = 10;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            eMordisko = Form1.Mordisko;
            eClassic_Magnum = Form1.Classic_Magnum;
            eBob_esponja = Form1.Bob_esponja;
            eSolero = Form1.Solero;
            eLapiz_de_Color = Form1.Lapiz_de_Color;
            eNesquik = Form1.Nesquik;
            eOreo = Form1.Oreo;
            ePinta_Lengua = Form1.Pinta_Lengua;
            eChoco = Form1.Choco;

           label11.Text = "" + eMordisko;
            label12.Text = "" + eClassic_Magnum;
            label13.Text = "" + eBob_esponja;
            label14.Text = "" + eSolero;
            label15.Text = "" + eLapiz_de_Color;
            label16.Text = "" + eNesquik;
            label17.Text = "" + eOreo;
            label18.Text = "" + ePinta_Lengua;
            label19.Text = "" + eChoco;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                eMordisko += 0;
            }
            else
            {
                eMordisko += Convert.ToInt32(textBox1.Text);
            }

            if (textBox2.Text == "")
            {
                eClassic_Magnum += 0;
            }
            else
            {
                eClassic_Magnum += Convert.ToInt32(textBox2.Text);
            }

            if (textBox3.Text == "")
            {
                eBob_esponja += 0;
            }
            else
            {
                eBob_esponja += Convert.ToInt32(textBox3.Text);
            }

            if (textBox4.Text == "")
            {
                eSolero += 0;
            }
            else
            {
                eSolero += Convert.ToInt32(textBox4.Text);
            }

            if (textBox5.Text == "")
            {
                eLapiz_de_Color += 0;
            }
            else
            {
                eLapiz_de_Color += Convert.ToInt32(textBox5.Text);
            }

            if (textBox6.Text == "")
            {
                eNesquik += 0;
            }
            else
            {
                eNesquik += Convert.ToInt32(textBox6.Text);
            }

            if (textBox7.Text == "")
            {
                eOreo += 0;
            }
            else
            {
                eOreo += Convert.ToInt32(textBox7.Text);
            }

            if (textBox8.Text == "")
            {
                ePinta_Lengua += 0;
            }
            else
            {
                ePinta_Lengua += Convert.ToInt32(textBox8.Text);
            }

            if (textBox9.Text == "")
            {
                eChoco += 0;
            }
            else
            {
                eChoco += Convert.ToInt32(textBox9.Text);
            }

            Form1.Mordisko = eMordisko;
            Form1.Classic_Magnum = eClassic_Magnum;
            Form1.Bob_esponja = eBob_esponja;
            Form1.Solero = eSolero;
            Form1.Lapiz_de_Color = eLapiz_de_Color;
            Form1.Nesquik = eNesquik;
            Form1.Oreo = eOreo;
            Form1.Pinta_Lengua = ePinta_Lengua;
            Form1.Choco = eChoco;

            this.Close();
        }
    }
}
