using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWinForms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al asistente de datos personales");
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por usar esta App....");
        }

        private void lblApellido_MouseMove(object sender, MouseEventArgs e)
        {
            lblApellido.Cursor = Cursors.No;
        }

        private void lblApellido_MouseLeave(object sender, EventArgs e)
        {
            lblApellido.Cursor = Cursors.No; 
        }

        private void lblNombre_MouseLeave(object sender, EventArgs e)
        {
            lblNombre.Cursor = Cursors.No;
        }

        private void lblEdad_MouseLeave(object sender, EventArgs e)
        {
            lblEdad.Cursor = Cursors.No;
        }

        private void lblDireccion_MouseLeave(object sender, EventArgs e)
        {
            lblDireccion.Cursor = Cursors.No;
        }

        private void lblResultado_MouseLeave(object sender, EventArgs e)
        {
            lblResultado.Cursor = Cursors.No;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtboxApellido.Text == "")
                txtboxApellido.BackColor = Color.Red;
            else
                txtboxApellido.BackColor = SystemColors.Control;

            if (txtboxNombre.Text == "")
                txtboxNombre.BackColor = Color.Red;
            else
                txtboxNombre.BackColor = SystemColors.Control;

            if (txtboxEdad.Text == "")
                txtboxEdad.BackColor = Color.Red;
            else
                txtboxEdad.BackColor = SystemColors.Control;

            if (txtboxDireccion.Text == "")
                txtboxDireccion.BackColor = Color.Red;
            else
                txtboxDireccion.BackColor = SystemColors.Control;

            if (txtboxApellido.Text != "" && txtboxNombre.Text != "" && txtboxEdad.Text != "" && txtboxDireccion.Text != ""){
                string apellido = txtboxApellido.Text; 
                string nombre = txtboxNombre.Text; 
                string edad = txtboxEdad.Text;      
                string direccion = txtboxDireccion.Text;

                txtboxResultado.Text = "Apellido y Nombre: " + apellido + ", " + nombre + Environment.NewLine + 
                "Edad: " + edad + Environment.NewLine + "Dirección: " + direccion; 

            }


        }

        private void txtboxEdad_KeyPress(object sender, KeyPressEventArgs e)//Eveto Key Press de un TexBox se ejecuta al presionar una tecla
        {//e.KeyChar es el valor de la tecla que presiono. Si apreto 7 lo guardo en e.KeyChar

            if (Char.IsDigit(e.KeyChar))
              {
                e.Handled = false; //e.Handled es si se lleva a cabo o no el evento. 
              }
            else if (Char.IsControl(e.KeyChar))//control es Mayuscula u otra tecla modificadora.
              {
                e.Handled = false;
              }
            else if (Char.IsSeparator(e.KeyChar))//valida que sea la barra espaciadora
              {
                e.Handled = false;
              }
            else 
              {
                e.Handled = true;
              }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
