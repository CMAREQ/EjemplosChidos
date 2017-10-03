using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamenAlumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limpiar() {
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtMateria.Text = "";
            txtMatricula.Focus();
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumno Consultar = new Alumno();
            Consultar.Matricula = txtMatricula.Text;
            if (Consultar.Consulta())
            {
                txtNombre.Text = Consultar.Nombre;
                txtApellido.Text = Consultar.Apellido;
                txtMateria.Text = Consultar.Materia;
            }
            else
            {
                MessageBox.Show("Alumno no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumno Agregar = new Alumno();
            Agregar.Matricula = txtMatricula.Text;
            Agregar.Nombre = txtNombre.Text;
            Agregar.Apellido = txtApellido.Text;
            Agregar.Materia = txtMateria.Text;
            if (Agregar.Alta())
            {
                limpiar();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumno Modificar = new Alumno();
            Modificar.Nombre = txtNombre.Text;
            Modificar.Apellido = txtApellido.Text;
            Modificar.Materia = txtMateria.Text;
            Modificar.Matricula = txtMatricula.Text;
            if (Modificar.Actualiza())
            {
                limpiar();
            }
            else
            {
                MessageBox.Show("Alumno no actualizado", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                limpiar();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumno Eliminar = new Alumno();
            Eliminar.Matricula = txtMatricula.Text;
            if (Eliminar.Baja())
            {
                limpiar();
            } 
            else
            {
                MessageBox.Show("Alumno no Eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
