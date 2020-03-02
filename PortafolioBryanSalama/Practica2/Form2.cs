using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = 0, cant = 0, desc = 0, desc = 0;
                if (rdo0.Checked)
                {
                    desc = 0;
                }
                else if (rdo5.Checked)
                {
                    desc = 0.05;
                }
                else if (rdo10.Checked)
                {
                    desc = 0.10;
                }
                else if (rdo15.Checked)
                {
                    desc = 0.15;
                }
                else if (rdo20.Checked)
                {
                    desc = 0.20;
                }
                precio = Convert.ToDouble(txtPrec.Text);
                cant = Convert.ToDouble(txtCant.Text);
                desc = (precio * cant) * desc;
                txtDesc.Text = String.Format("{0:C2}", desc);
                txtTotal.Text = String.Format("{0:C2}", (precio * cant) - desc);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese correctamente los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCant.Clear();
            txtDesc.Clear();
            txtPrec.Clear();
            txtTotal.Clear();
            txtCant.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
