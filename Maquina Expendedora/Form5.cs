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
    public partial class Form5 : Form
    {
        int PrecMordisko = 0;
        int PrecClassic_Magnum = 0;
        int PrecBob_esponja = 0;
        int PrecSolero = 0;
        int PrecLapiz_de_Color = 0;
        int PrecNesquik = 0;
        int PrecOreo = 0;
        int PrecPinta_Lengua = 0;
        int PrecChoco = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            PrecMordisko = Form1.PreMordisko;
            PrecClassic_Magnum = Form1.PreClassic_Magnum;
            PrecBob_esponja = Form1.PreBob_esponja;
            PrecSolero = Form1.PreSolero;
            PrecLapiz_de_Color = Form1.PreLapiz_de_Color;
            PrecNesquik = Form1.PreNesquik;
            PrecOreo = Form1.PreOreo;
            PrecPinta_Lengua = Form1.PrePinta_Lengua;
            PrecChoco = Form1.PreChoco;

            textBox1.Text = "" + PrecMordisko;
            textBox2.Text = "" + PrecClassic_Magnum;
            textBox3.Text = "" + PrecBob_esponja;
            textBox4.Text = "" + PrecSolero;
            textBox5.Text = "" + PrecLapiz_de_Color;
            textBox6.Text = "" + PrecNesquik;
            textBox7.Text = "" + PrecOreo;
            textBox8.Text = "" + PrecPinta_Lengua;
            textBox9.Text = "" + PrecChoco;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrecMordisko = Convert.ToInt32(textBox1.Text);
            PrecClassic_Magnum = Convert.ToInt32(textBox2.Text);
            PrecBob_esponja = Convert.ToInt32(textBox3.Text);
            PrecSolero = Convert.ToInt32(textBox4.Text);
            PrecLapiz_de_Color = Convert.ToInt32(textBox5.Text);
            PrecNesquik = Convert.ToInt32(textBox6.Text);
            PrecOreo = Convert.ToInt32(textBox7.Text);
            PrecPinta_Lengua = Convert.ToInt32(textBox8.Text);
            PrecChoco = Convert.ToInt32(textBox9.Text);

            Form1.PreMordisko = PrecMordisko;
            Form1.PreClassic_Magnum = PrecClassic_Magnum;
            Form1.PreBob_esponja =  PrecBob_esponja;
            Form1.PreSolero = PrecSolero;
            Form1.PreLapiz_de_Color = PrecLapiz_de_Color;
            Form1.PreNesquik = PrecNesquik;
            Form1.PreOreo = PrecOreo;
            Form1.PrePinta_Lengua = PrecPinta_Lengua;
            Form1.PreChoco = PrecChoco;
            
            this.Close();


        }
    }
}
