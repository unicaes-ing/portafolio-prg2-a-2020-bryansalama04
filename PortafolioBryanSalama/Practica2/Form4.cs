using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            error.Clear();
            if (txtCorreo.TextLength <= 0)
            {
                error.SetError(txtCorreo, "Ingrese su correo");
                validado = false;
            }
            else
            {
                string patronCorreo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
                {
                    error.SetError(txtCorreo, "Ingrese correctamente su correo");
                    validado = false;
                }
            }
            if (txtContra.TextLength <= 0)
            {
                error.SetError(txtContra, "Ingrese la contraseña");
                validado = false;
            }
            else
            {
                string patronContra = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
                if (!Regex.IsMatch(txtContra.Text, patronContra))
                {
                    error.SetError(txtContra, "Formato de contraseña no valido");
                    validado = false;
                }
            }
            if (!Equals(txtContra.Text, txtConfir_Contra.Text) || txtConfir_Contra.TextLength <= 0)
            {
                error.SetError(txtConfir_Contra, "La contraseña no es igual");
                validado = false;
            }
            if (validado)
            {
                MessageBox.Show("Los Datos fueron validados correctamente", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
