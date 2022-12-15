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

namespace Maquina_Expendedora
{
    public partial class Pagoexitoso : Form
    {
        private void temp(int time)
        {
            for (int a = 0; a < time; a++)
            {
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
            }
        }
        int choose = 0;
        int dinero = 0;
        public Pagoexitoso()
        {
            InitializeComponent();
        }

        private void Pagoexitoso_Load(object sender, EventArgs e)
        {
            choose = Form2.debcred;
            if (choose == 1)
            {
                dinero = 400;
            } 
            else if (choose == 2) 
            {
                dinero = 10;
            }

            temp(100);
            label1.Text = "Pago exitoso";
            label2.Text = "Ahora su saldo es de " + dinero + " pesos";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.total = dinero;
            this.Close();
        }
    }
}
