using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SQLEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string strFileName;

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            departamentoTextBox.Clear();
            turnoTextBox.Clear();
            contactoTextBox.Clear();
            pic_Empleado.ImageLocation = "";
            idTextBox.Focus();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string BUSCAR = "SELECT * FROM DBP WHERE Id=@Id";
            OleDbCommand CmdBuscar = new OleDbCommand(BUSCAR, Cnx);
            CmdBuscar.CommandType = CommandType.Text;
            CmdBuscar.Parameters.AddWithValue("@Id", idTextBox.Text);
            Cnx.Open();
            OleDbDataReader Lectura;
            Lectura = CmdBuscar.ExecuteReader();
            if (Lectura.Read() == true)
            {
                nombreTextBox.Text = Lectura[1].ToString();
                apellidoTextBox.Text = Lectura[2].ToString();
                departamentoTextBox.Text = Lectura[3].ToString();
                turnoTextBox.Text = Lectura[4].ToString();
                contactoTextBox.Text = Lectura[5].ToString();
                pic_Empleado.ImageLocation = Lectura[6].ToString();
            }
            else
            {
                MessageBox.Show("Los Datos a Buscar No Estan Registrados");
                idTextBox.Clear();
                idTextBox.Focus();
            }
            Cnx.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string Insertar = "Insert Into DBP Values (@Id, @Nombre,@Apellido, @Departamento, @Turno, @Contacto, @Imagen)" ;
 OleDbCommand Cmd = new OleDbCommand(Insertar, Cnx);
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("@Id", idTextBox.Text);
                Cmd.Parameters.AddWithValue("@Nombre", nombreTextBox.Text);
                Cmd.Parameters.AddWithValue("@Apellido", apellidoTextBox.Text);
                Cmd.Parameters.AddWithValue("@Departamento", departamentoTextBox.Text);
                Cmd.Parameters.AddWithValue("@Turno", turnoTextBox.Text);
                Cmd.Parameters.AddWithValue("@Contacto", contactoTextBox.Text);
                pic_Empleado.ImageLocation = strFileName;
                Cmd.Parameters.AddWithValue("@Imagen", pic_Empleado.ImageLocation);
                Cnx.Open();
                Cmd.ExecuteNonQuery();
                Cnx.Close();
                MessageBox.Show("El Contacto Fue Registrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Clave a Registrar Ya Existe", ex.Message);
            }
            idTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            departamentoTextBox.Clear();
            turnoTextBox.Clear();
            contactoTextBox.Clear();
            pic_Empleado.ImageLocation = "";
            idTextBox.Focus();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                string Actualizar = "UPDATE DBP SET Id=@Id, Nombre=@Nombre,Apellido = @Apellido,Departamento = @Departamento,Turno = @Turno,Contacto = @Contacto,Imagen = @Imagen WHERE Id = @Id" ;
 OleDbCommand Cmd = new OleDbCommand(Actualizar, Cnx);
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("@Id", idTextBox.Text);
                Cmd.Parameters.AddWithValue("@Nombre", nombreTextBox.Text);
                Cmd.Parameters.AddWithValue("@Apellido", apellidoTextBox.Text);
                Cmd.Parameters.AddWithValue("@Departamento", departamentoTextBox.Text);
                Cmd.Parameters.AddWithValue("@Turno", turnoTextBox.Text);
                Cmd.Parameters.AddWithValue("@Contacto", contactoTextBox.Text);
                Cmd.Parameters.AddWithValue("@Imagen", pic_Empleado.ImageLocation);
                Cnx.Open();
                Cmd.ExecuteNonQuery();
                Cnx.Close();
                MessageBox.Show("Los Datos Del Contacto Fueron Actualizados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            idTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            departamentoTextBox.Clear();
            turnoTextBox.Clear();
            contactoTextBox.Clear();
            pic_Empleado.ImageLocation = "";
            idTextBox.Focus();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string Eliminar = "DELETE FROM DBP WHERE Id=@Id";
                OleDbCommand Cmd = new OleDbCommand(Eliminar, Cnx);
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("@Id", idTextBox.Text);
                Cnx.Open();
                Cmd.ExecuteNonQuery();
                Cnx.Close();
                MessageBox.Show("El Contacto Fue Eliminado....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            idTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            departamentoTextBox.Clear();
            turnoTextBox.Clear();
            contactoTextBox.Clear();
            pic_Empleado.ImageLocation = "";
            idTextBox.Focus();
        }

        private void btn_Foto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Abrir un archivo de imagen";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    strFileName = openFileDialog1.FileName;
                    pic_Empleado.Image = Image.FromFile(strFileName);
                    openFileDialog1.Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, null, MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
    }
    
}
