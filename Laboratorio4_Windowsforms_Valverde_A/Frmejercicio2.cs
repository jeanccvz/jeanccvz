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
    public partial class Frmejercicio2 : Form
    {
        public Frmejercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2;
            string resultado;

            n1 = Convert.ToDouble(txtNumero1.Text);
            n2 = Convert.ToDouble(txtNumero2.Text);

            if (n1 > n2)
            {
                resultado = "Numero 1 : " + n1 + " es mayor que" + "Numero 2: " + n2;
                MessageBox.Show(resultado, "Numero mayor y menor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (n2 > n1)
            {
                resultado = "Numero 1 : " + n1 + " es mayor que" + "Numero 2: " + n1;
                MessageBox.Show(resultado, "Numero mayor y menor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (n1.Equals(n2))
            {
                resultado = "Numero 1 : " + n1 + " es igual que " + "Numero 2: " + n2;
                MessageBox.Show(resultado, "Numero mayor y menor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede realizar la operacion","Numero mayor y menor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";
            txtResultado.Clear();
        }
    }
}
