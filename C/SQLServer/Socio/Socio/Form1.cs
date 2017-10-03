using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Socio
{
    public partial class Soc : Form
    {
        public Soc()
        {
            InitializeComponent();
        }

        private void limpiar() {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtID.Focus();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Socio Consultar = new Socio();
            Consultar.Id = txtID.Text;
            if (Consultar.SocioConsulta())
            {
                txtNombre.Text = Consultar.Nombre;
                txtApellido.Text = Consultar.Apellido;
                txtDireccion.Text = Consultar.Direccion;
                txtTelefono.Text = Consultar.Telefono;
            }
            else 
            {
                MessageBox.Show("Socio no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Socio Agregar = new Socio();
            Agregar.Id = txtID.Text;
            Agregar.Nombre = txtNombre.Text;
            Agregar.Apellido = txtApellido.Text;
            Agregar.Direccion = txtDireccion.Text;
            Agregar.Telefono = txtTelefono.Text;
            if(Agregar.SocioAlta())
            {
                limpiar();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Socio Modificar = new Socio();
            Modificar.Nombre = txtNombre.Text;
            Modificar.Apellido = txtApellido.Text;
            Modificar.Direccion = txtDireccion.Text;
            Modificar.Telefono = txtTelefono.Text;
            Modificar.Id = txtID.Text;
            if (Modificar.SocioActualiza())
            {
                limpiar(); 
            }
            else
            {
                MessageBox.Show("Socio no actualizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Socio Eliminar = new Socio();
            Eliminar.Id = txtID.Text;
            if(Eliminar.SocioBaja())
            {
                limpiar();
            }
            else
            {
                MessageBox.Show("Socio no Eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
