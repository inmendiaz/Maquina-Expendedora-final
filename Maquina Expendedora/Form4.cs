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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 Ven5 = new Form5();
            Ven5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 Ven6 = new Form6();
            Ven6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 Ven7 = new Form7();
            Ven7.Show();
        }
    }
}
