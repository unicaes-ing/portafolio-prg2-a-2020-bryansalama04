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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("La Divina Comedia"))
            {
                txtPrec.Text = "15.00";
            }
            else if (comboBox1.SelectedItem.Equals("Jupiter"))
            {
                txtPrec.Text = "20.50";
            }
            else if (comboBox1.SelectedItem.Equals("Narraciones Extraordinarias"))
            {
                txtPrec.Text = "10.50";
            }
            else if (comboBox1.SelectedItem.Equals("Luz Negra"))
            {
                txtPrec.Text = "8.00";
            }
            else if (comboBox1.SelectedItem.Equals("20 poemas de amor y una canción desesperada"))
            {
                txtPrec.Text = "5.00";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cantidad, prec, subt, imp, tot;
            if (comboBox1.SelectedItem.Equals("La Divina Comedia"))
            {
                subt = Convert.ToDouble(txtPrec.Text) * Convert.ToInt32(txtCant.Text);
                imp = subt * 0.13;
                tot = subt + imp;

                txtSubt.Text = subt.ToString("{0:C2}");
                txtIVA.Text = imp.ToString("{0:C2}");
                txtTotal.Text = tot.ToString("{0:C2}");
            }
            else if (comboBox1.SelectedItem.Equals("Jupiter"))
            {
                subt = Convert.ToDouble(txtPrec.Text) * Convert.ToInt32(txtCant.Text);
                imp = subt * 0.13;
                tot = subt + imp;

                txtSubt.Text = subt.ToString("{0:C2}");
                txtIVA.Text = imp.ToString("{0:C2}");
                txtTotal.Text = tot.ToString("{0:C2}");
            }
            else if (comboBox1.SelectedItem.Equals("Narraciones Extraordinarias"))
            {
                subt = Convert.ToDouble(txtPrec.Text) * Convert.ToInt32(txtCant.Text);
                imp = subt * 0.13;
                tot = subt + imp;

                txtSubt.Text = subt.ToString("0:C2");
                txtIVA.Text = imp.ToString("{0:C2}");
                txtTotal.Text = tot.ToString("{0:C2}");
            }
            else if (comboBox1.SelectedItem.Equals("Luz Negra"))
            {
                subt = Convert.ToDouble(txtPrec.Text) * Convert.ToInt32(txtCant.Text);
                imp = subt * 0.13;
                tot = subt + imp;
                txtSubt.Text = subt.ToString("{0:C2}");
                txtIVA.Text = imp.ToString("{0:C2}");
                txtTotal.Text = tot.ToString("{0:C2}");
            }
            else if (comboBox1.SelectedItem.Equals("20 poemas de amor y una canción desesperada"))
            {
                subt = Convert.ToDouble(txtPrec.Text) * Convert.ToInt32(txtCant.Text);
                imp = subt * 0.13;
                tot = subt + imp;
                txtSubt.Text = subt.ToString("0:C2");
                txtIVA.Text = imp.ToString("{0:C2}");
                txtTotal.Text = tot.ToString("{0:C2}");
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            txtTotal.Clear();
            txtSubt.Clear();
            txtPrec.Clear();
            txtIVA.Clear();
            txtCant.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
