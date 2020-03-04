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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static int Fibonacci(int num)
        {
            int a, b, c, x;
            x = num;
            a = 0;
            b = 1;
            for (int i = 0; i < x; i++)
            {
                c = a;
                a = b;
                b = c + a;
            }
            return a;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num, n;
            num = Convert.ToInt32(txtNúmero.Text);
            n = Fibonacci(num);
            txtFibo.Text = string.Format("{0}", n);
        }
    }
}
