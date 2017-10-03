using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace agendaSQL
{
    public partial class frm_agenda_sql : Form
    {
        public frm_agenda_sql()
        {
            InitializeComponent();
        }

        public string strFileName;

        private void frm_agenda_sql_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {


            txt_id.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_domicilio.Clear();
            txt_colonia.Clear();
            txt_ciudad.Clear();
            txt_telcasa.Clear();
            txt_telmovil.Clear();
            txt_email.Clear();
            txt_email_empresarial.Clear();
            pic_foto.ImageLocation = "";
            txt_id.Focus();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string BUSCAR = "SELECT * FROM persona WHERE Id=@Id";
            OleDbCommand CmdBuscar = new OleDbCommand(BUSCAR, Cnx);
            CmdBuscar.CommandType = CommandType.Text;
            CmdBuscar.Parameters.AddWithValue("@Id", txt_id.Text);
            Cnx.Open();
            OleDbDataReader Lectura;
            Lectura = CmdBuscar.ExecuteReader();
            if (Lectura.Read() == true)
            {
                txt_nombre.Text = Lectura[1].ToString();
                txt_apellido.Text = Lectura[2].ToString();
                txt_domicilio.Text = Lectura[3].ToString();
                txt_colonia.Text = Lectura[4].ToString();
                txt_ciudad.Text = Lectura[5].ToString();
                txt_telcasa.Text = Lectura[6].ToString();
                txt_telmovil.Text = Lectura[7].ToString();
                txt_email.Text = Lectura[8].ToString();
                txt_email_empresarial.Text = Lectura[9].ToString();
                pic_foto.ImageLocation = Lectura[10].ToString();
            }


            else
            {
                MessageBox.Show("Los Datos a Buscar No Estan Registrados");
                txt_id.Clear();
                txt_id.Focus();
            }
            Cnx.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            try
            {
                string Insertar = "Insert Into persona Values (@Id, @Nombre,@Apellido, @CalleYNumero, @Colonia, @Ciudad, @TelCasa, @TelCel, @EmailPersonal,@EmailTrabajo, @Fotografia)";
                OleDbCommand Cmd = new OleDbCommand(Insertar, Cnx);
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("@Id", txt_id.Text);
                Cmd.Parameters.AddWithValue("@Nombre", txt_nombre.Text);
                Cmd.Parameters.AddWithValue("@Apellido", txt_apellido.Text);
                Cmd.Parameters.AddWithValue("@CalleYNumero", txt_domicilio.Text);
                Cmd.Parameters.AddWithValue("@Colonia", txt_colonia.Text);
                Cmd.Parameters.AddWithValue("@Ciudad", txt_ciudad.Text);
                Cmd.Parameters.AddWithValue("@TelCasa", txt_telcasa.Text);
                Cmd.Parameters.AddWithValue("@TelCel", txt_telmovil.Text);
                Cmd.Parameters.AddWithValue("@EmailPersonal",
                txt_email.Text);
                Cmd.Parameters.AddWithValue("@EmailTrabajo", txt_email_empresarial.Text);
                pic_foto.ImageLocation = strFileName;
                Cmd.Parameters.AddWithValue("@Fotografia", pic_foto.ImageLocation);
                Cnx.Open();
                Cmd.ExecuteNonQuery();
                Cnx.Close();
                MessageBox.Show("El Contacto Fue Registrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Clave a Registrar Ya Existe", ex.Message);
            }
            txt_id.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_domicilio.Clear();
            txt_colonia.Clear();
            txt_ciudad.Clear();
            txt_telcasa.Clear();
            txt_telmovil.Clear();
            txt_email.Clear();
            txt_email_empresarial.Clear();
            pic_foto.ImageLocation = "";
            txt_id.Focus();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                string Actualizar = "UPDATE persona SET Id=@Id, Nombre=@Nombre, Apellido=@Apellido, CalleYNumero=@CalleYNumero, Colonia=@Colonia, Ciudad=@Ciudad, TelCasa=@TelCasa, TelCel=@TelCel, EmailPersonal=@EmailPersonal, EmailTrabajo=@EmailTrabajo, Fotografia=@Fotografia WHERE Id=@Id";
                OleDbCommand Cmd = new OleDbCommand(Actualizar, Cnx);
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("@Id", txt_id.Text);
                Cmd.Parameters.AddWithValue("@Nombre", txt_nombre.Text);
                Cmd.Parameters.AddWithValue("@Apellido", txt_apellido.Text);
                Cmd.Parameters.AddWithValue("@CalleYNumero", txt_domicilio.Text);
                Cmd.Parameters.AddWithValue("@Colonia", txt_colonia.Text);
                Cmd.Parameters.AddWithValue("@Ciudad", txt_ciudad.Text);
                Cmd.Parameters.AddWithValue("@TelCasa", txt_telcasa.Text);
                Cmd.Parameters.AddWithValue("@TelCel", txt_telmovil.Text);
                Cmd.Parameters.AddWithValue("@EmailPersonal",
                txt_email.Text);
                Cmd.Parameters.AddWithValue("@EmailTrabajo", txt_email_empresarial.Text);
                Cmd.Parameters.AddWithValue("@Fotografia", pic_foto.ImageLocation);
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
            txt_id.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_domicilio.Clear();
            txt_colonia.Clear();
            txt_ciudad.Clear();
            txt_telcasa.Clear();
            txt_telmovil.Clear();
            txt_email.Clear();
            txt_email_empresarial.Clear();
            pic_foto.ImageLocation = "";
            txt_id.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                string Eliminar = "DELETE FROM persona WHERE Id=@Id";
                OleDbCommand Cmd = new OleDbCommand(Eliminar, Cnx);
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("@Id", txt_id.Text);
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
            txt_id.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_domicilio.Clear();
            txt_colonia.Clear();
            txt_ciudad.Clear();
            txt_telcasa.Clear();
            txt_telmovil.Clear();
            txt_email.Clear();
            txt_email_empresarial.Clear();
            pic_foto.ImageLocation = "";
            txt_id.Focus();


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_cargar_foto_Click(object sender, EventArgs e)
        {
            ofd_foto.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp";
            ofd_foto.FilterIndex = 1;
            ofd_foto.Title = "Abrir un archivo de imagen";
            if (ofd_foto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    strFileName = ofd_foto.FileName;
                    pic_foto.Image = Image.FromFile(strFileName);
                    ofd_foto.Reset();
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