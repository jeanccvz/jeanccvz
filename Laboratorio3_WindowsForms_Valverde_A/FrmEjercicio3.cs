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
    public partial class FrmEjercicio3 : Form
    {
        public FrmEjercicio3()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtresultado.Text = "";
            txtresultado.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a, b, r=0;

            //igualando las variables a valores de caja de texto
            a = Convert.ToDouble(txtnumero1.Text);
            b = Convert.ToDouble(txtnumero2.Text);

            //calculo
            if (rbtnSuma.Checked == true)
            {
                r = a + b;
            }
            else if (rbtnResta.Checked == true)
            {
                r = a - b;
            }
            else if (rbtnMultiplicacion.Checked == true)
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
                txtresultado.Text = Convert.ToString(r);
            }
            
        }

        private void FrmEjercicio3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
