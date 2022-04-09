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
    public partial class FrmEjercicio4 : Form
    {
        public FrmEjercicio4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtinicio.Clear();
            txtfin.Clear();
            txtTabla.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int a, b, i;
            a = Convert.ToInt32(txtinicio.Text);
            b= Convert.ToInt32(txtfin.Text);

            if (a<b)
            {
                for (i = a; i <= b; i++)
                {
                    if (i % 2 == 0)
                    {
                        txtTabla.Text = txtTabla.Text + "El numero  : " + i + " es PAR " + "\r\n";
                    }
                    else
                    {
                        txtTabla.Text = txtTabla.Text + "El numero  : " + i + " es IMPAR " + "\r\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("El numero inicial no puede ser mayor que el numero final .... ", "Numero Pares e Impares", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
