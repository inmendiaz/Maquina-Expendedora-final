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
    public partial class Form2 : Form
    {
        public static int chances = 3;
        public static int debcred;
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234" && checkBox1.Checked) 
            {
                debcred = 1;
                Pagoexitoso Ven3 = new Pagoexitoso();
                Ven3.Show();
                textBox1.Text = "";
                this.Close();
            }
            else if (textBox1.Text == "1234" && checkBox2.Checked)
            {
                debcred = 2;
                Pagoexitoso Ven3 = new Pagoexitoso();
                Ven3.Show();
                textBox1.Text = "";
                this.Close();
            }
            else
            { 
                errorpago Ven4 = new errorpago();
                Ven4.Show();
                textBox1.Text = "";
                chances = chances - 1;
                if (chances == 0)
                {
                    this.Close();
                }
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
