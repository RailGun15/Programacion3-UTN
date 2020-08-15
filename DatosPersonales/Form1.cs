using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosPersonales
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por Usar la Aplicación!");
            Application.Exit();
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
                error1.SetError(txtApellido, "Debe ingresar un apellido");
                txtApellido.Focus();
                return;
            }
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
            error1.SetError(txtApellido, "");

            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                error1.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
            error1.SetError(txtNombre, "");

            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
                error1.SetError(txtEdad, "Debe ingresar una edad");
                txtEdad.Focus();
                return;
            }
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
            error1.SetError(txtEdad, "");

            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
                error1.SetError(txtDireccion, "Debe ingresar un direccion");
                txtDireccion.Focus();
                return;
            }
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            error1.SetError(txtDireccion, "");



            txtResultado.Text = "Nombre y Apellido: " + txtNombre.Text + " " + txtApellido.Text + Environment.NewLine +
                                "Edad: " + txtEdad.Text + Environment.NewLine + "Direccion: " + txtDireccion.Text;
        }
    }
}
