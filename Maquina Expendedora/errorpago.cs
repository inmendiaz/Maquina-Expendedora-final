using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquina_Expendedora
{
    public partial class errorpago : Form
    {
        int intentos = 3;
        public errorpago()
        {
            InitializeComponent();
        }

        private void errorpago_Load(object sender, EventArgs e)
        {
            intentos = Form2.chances;
            label2.Text = "Has cometido demasiados errores te quedan " + (intentos - 1) + " intentos";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
