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
    public partial class FrmEjercicio2 : Form
    {
        public FrmEjercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEjercicio2_Load(object sender, EventArgs e)
        {

        }

        private void txtnumero1_TextChanged(object sender, EventArgs e)
        {

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
            double a, b,r;

        //igualando las variables a valores de caja de texto
            a =Convert.ToDouble(txtnumero1.Text);
            b =Convert.ToDouble(txtnumero2.Text);

            //calculo
            r = a + b;
            txtresultado.Text = Convert.ToString(r);
        }
    }
}
