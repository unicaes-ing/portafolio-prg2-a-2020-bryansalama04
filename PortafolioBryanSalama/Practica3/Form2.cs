﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listLetras.ForeColor = Color.Blue;
            listLetras.Items.Clear();
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                listLetras.Items.Add(letra);
            }
            listLetras.Items.Insert(14, 'Ñ');
        }
    }
}
