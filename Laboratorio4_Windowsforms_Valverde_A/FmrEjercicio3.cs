using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio4_Windowsforms_Valverde_A
{
    public partial class FmrEjercicio3 : Form
    {
        public FmrEjercicio3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int i, numero;
            numero = Convert.ToInt32(txtNumero.Text);
            txtTabla.Text = "";
            for (i = 0; i <= 12; i++)
            {
                txtTabla.Text = txtTabla.Text + numero + " x " + i + " = " + ( numero * i) + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
