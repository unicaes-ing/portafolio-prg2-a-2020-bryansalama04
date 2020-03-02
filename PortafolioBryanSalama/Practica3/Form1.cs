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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtTabla.Text, out n))
            {
                listTablas.Items.Clear();
                for (int i = 0; i <= 10; i++)
                {
                    listTablas.Items.Add(n + "*" + i + "=" + n * i);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero");
            }
        }
    }
}
