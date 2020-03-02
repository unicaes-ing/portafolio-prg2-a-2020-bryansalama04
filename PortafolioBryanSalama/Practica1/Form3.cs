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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toInver= Convert.ToDouble(txtInver1.Text) + Convert.ToDouble(txtInver2.Text) + Convert.ToDouble(txtInver3.Text);
            txtPor1.Text = Convert.ToString(((Convert.ToDouble(txtInver1.Text) / toInver) * 100).ToString("N2")) + "%";
            txtPor2.Text = Convert.ToString(((Convert.ToDouble(txtInver2.Text) / toInver) * 100).ToString("N2")) + "%";
            txtPor3.Text = Convert.ToString(((Convert.ToDouble(txtInver3.Text) / toInver) * 100).ToString("N2")) + "%";
            txtTotal.Text = toInver.ToString("C2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInver2.Clear();
            txtInver3.Clear();
            txtPor1.Clear();
            txtPor2.Clear();
            txtPor3.Clear();
            txtTotal.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
