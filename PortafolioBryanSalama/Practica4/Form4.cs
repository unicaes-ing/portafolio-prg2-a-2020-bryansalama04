using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static int Número(int N1, int N2, int N3)
        {
            int Num1, Num2, Num3;
            Num1 = N1;
            Num2 = N2;
            Num3 = N3;
            if (Num1 > Num2 && Num1 > Num3)
            {
                return Num1;
            }
            else if (Num2 > Num1 && Num2 > Num3)
            {
                return Num2;
            }
            else
            {
                return Num3;
            }
        }
        private void btnMayor_Click(object sender, EventArgs e)
        {
            int n, n1, n2, Numayor;
            n = Convert.ToInt32(txtNm1.Text);
            n1 = Convert.ToInt32(txtNm2.Text);
            n2 = Convert.ToInt32(txtNm3.Text);
            Numayor = Número(n, n1, n2);
            lblResultado.Text = string.Format("{0}", Numayor);
        }
    }
}
