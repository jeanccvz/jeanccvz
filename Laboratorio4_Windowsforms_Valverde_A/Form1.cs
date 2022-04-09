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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstOperacion.Items.Clear();
            lstOperacion.Items.Add("Suma");
            lstOperacion.Items.Add("Resta");
            lstOperacion.Items.Add("Multiplicacion");
            lstOperacion.Items.Add("Division");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtResultado.Text = "";
            txtResultado.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, r = 0;

            //igualando las variables a valores de caja de texto
            a = Convert.ToDouble(txtnumero1.Text);
            b = Convert.ToDouble(txtnumero2.Text);

            //calculo
            if (lstOperacion.SelectedIndex == 0)
            {
                r = a + b;
            }
            else if (lstOperacion.SelectedItem.ToString() == "Resta")
            {
                r = a - b;
            }
            else if (lstOperacion.SelectedItem.ToString() == "Multiplicacion")
            {
                r = a * b;
            }
            else if (lstOperacion.SelectedItem.ToString() == "Division")
            {
                if (b != 0)
                {
                    r = a / b;
                    txtResultado.Text = string.Format("{0:n2}", (Math.Truncate(r * 100) / 100));
                }
                else
                {
                    MessageBox.Show("Elnumero 2 tiene que se distinto a cero ...",
                       "Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblmensaje.Text = "El valor del numero2 debe ser distinto a cero";
                }

               txtResultado.Text = Convert.ToString(r);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
