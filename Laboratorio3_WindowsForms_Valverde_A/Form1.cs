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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            txtmensaje.Text = "Mi primer ejercicio";
            txtmensaje2.Text = "Programacion II";
            txtmensaje2.ForeColor = Color.Blue;
            txtmensaje2.BackColor = Color.GreenYellow;

        }
    }
}
