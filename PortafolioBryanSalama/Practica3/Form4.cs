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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dgvTabla.Size = new Size(210, 220);
            dgvTabla.AllowUserToAddRows = false;
            dgvTabla.ScrollBars = ScrollBars.None;
            dgvTabla.ColumnCount = 10;
            dgvTabla.ColumnHeadersVisible = false;
            dgvTabla.RowHeadersVisible = false;
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Random r = new Random();
            for (int f = 0; f < 10; f++)
            {
                dgvTabla.Rows.Add();
                for (int c = 0; c < 10; c++)
                {
                    dgvTabla.Rows[f].Cells[c].Value = r.Next(10, 100);
                    dgvTabla.Rows[f].Cells[c].Style.BackColor = Color.Blue;
                }
            }
            dgvTabla.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumBuscado.Text);
                for (int f = 0; f < 10; f++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (dgvTabla.Rows[f].Cells[i].Value.Equals(num))
                        {
                            dgvTabla.Rows[f].Cells[i].Style.BackColor = Color.Cyan;
                        }
                        else
                        {
                            dgvTabla.Rows[f].Cells[i].Style.BackColor = Color.Black;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese el número");
            }
        }
    }
}
