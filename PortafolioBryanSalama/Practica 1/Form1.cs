using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c, prom;
            a = Convert.ToDouble(txtExamen1.Text);
            b = Convert.ToDouble(txtExamen2.Text);
            c = Convert.ToDouble(txtExamen3.Text);
            prom = (a + b + c) / 3;
            txtProm.Text = Convert.ToString(prom);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExamen1.Clear();
            txtExamen2.Clear();
            txtExamen3.Clear();
            txtProm.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
