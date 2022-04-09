using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3_WindowsForms_Valverde_A
{
    public partial class FrmEjercicio4 : Form
    {
        public FrmEjercicio4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtResultado.Text = "";
            txtResultado.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a, b, r=0;

            //igualando las variables a valores de caja de texto
            a = Convert.ToDouble(txtnumero1.Text);
            b = Convert.ToDouble(txtnumero2.Text);

            //calculo
            if (cmboperaciones.SelectedIndex == 0)
            {
                r = a + b;
            }
            else if (cmboperaciones.SelectedIndex ==1)
            {
                r = a - b;
            }
            else if (cmboperaciones.SelectedIndex == 2)
            {
                r = a * b;
            }
            else
            {
                if (b != 0)
                {
                    r = a / b;
                }
                else
                {
                    lblmensaje.Text = "El valor del numero2 debe ser distinto a cero";
                }

                txtResultado.Text = Convert.ToString(r);
            }
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEjercicio4_Load(object sender, EventArgs e)
        {

        }
    }
}

