using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNombre.Text;
                double total = 0, subtotal = 0, imp = 0, horas = Convert.ToDouble(txtHTrabajadas.Text), canthr = Convert.ToDouble(txtVhora.Text), t = 0;
                subtotal = horas * canthr;
                imp = subtotal * 0.10;
                total = subtotal - imp;
                dvgPlanilla.Rows.Add(name, horas, String.Format("{0:C2}", canthr), String.Format("{0:C2}", subtotal), String.Format("{0:C2}", imp), String.Format("{0}", total));
                for (int i = 0; i < dvgPlanilla.Rows.Count; ++i)
                {
                    t += Convert.ToDouble(dvgPlanilla.Rows[i].Cells[5].Value);
                }
                txtTotal.Text = String.Format("{0:C2}", t);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los datos correctamente por favor");
            }
        }
    }
}
