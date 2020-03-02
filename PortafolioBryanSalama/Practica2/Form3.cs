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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    double tot, cant = Convert.ToDouble(txtLong_Conv.Text);
                    if (listConvert.Text == "Pulgadas" && listConvert2.Text == "Pies")
                    {
                        tot = cant * 1 / 12;
                    }
                    else if (listConvert.Text == "Pulgadas" && listConvert2.Text == "Yardas")
                    {
                        tot = cant * 1 / 36;
                    }
                    else if (listConvert.Text == "Pies" && listConvert2.Text == "Pulgadas")
                    {
                        tot = cant * 12;
                    }
                    else if (listConvert.Text == "Pies" && listConvert2.Text == "Yardas")
                    {
                        tot= cant * 1 / 3;
                    }
                    else if (listConvert.Text == "Yardas" && listConvert2.Text == "Pulgadas")
                    {
                        tot = cant * 36;
                    }
                    else if (listConvert.Text == "Yardas" && listConvert2.Text == "Pies")
                    {
                        tot = cant * 3;
                    }
                    else
                    {
                        tot = cant;
                    }
                    txtLongConvertida.Text = Convert.ToString(tot);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
