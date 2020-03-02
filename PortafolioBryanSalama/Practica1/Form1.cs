using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c, prom;
            a = Convert.ToDouble(txtExam1.Text);
            b = Convert.ToDouble(txtExam2.Text);
            c = Convert.ToDouble(txtExam3.Text);
            prom = (a + b + c) / 3;
            txtProm.Text = Convert.ToString(prom);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExam1.Clear();
            txtExam2.Clear();
            txtExam3.Clear();
            txtProm.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
