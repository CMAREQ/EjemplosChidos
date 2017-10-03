using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Socio
{
    public class Socio
    {
        #region Definicion de propiedades        
        private String MstrId;
        private String MstrNombre;
        private String MstrApellido;
        private String MstrDireccion;
        private String MstrTelefono;
        #endregion

        public string Id
        {
            get
            {
                return MstrId;
            }
            set
            {
                MstrId = value;
            }
        }

        public string Nombre
        {
            get
            {
                return MstrNombre;
            }
            set
            {
                MstrNombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return MstrApellido;
            }
            set
            {
                MstrApellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return MstrDireccion;
            }
            set
            {
                MstrDireccion = value;
            }
        }
        
        public string Telefono 
        {
            get
            {
                return MstrTelefono;
            }
            set 
            {
                MstrTelefono = value;
            }
        }


        #region Definicion de metodos
        public Boolean SocioAlta()
        {
            SqlConnection cnx = new SqlConnection("Server=CMR-PC; database=Socio; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("dbo.SocAlta", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id", MstrId));
            cmd.Parameters.Add(new SqlParameter("@Nombre", MstrNombre));
            cmd.Parameters.Add(new SqlParameter("@Apellido", MstrApellido));
            cmd.Parameters.Add(new SqlParameter("@Direccion", MstrDireccion));
            cmd.Parameters.Add(new SqlParameter("@Telefono", MstrTelefono));
            cnx.Open();
            cmd.ExecuteScalar();
            cnx.Close();
            return true;
        }

        public Boolean SocioBaja()
        {
            SqlConnection cnx = new SqlConnection("Server=CMR-PC; database=Socio; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("dbo.SocBaja", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id", MstrId));
            cnx.Open();
            cmd.ExecuteScalar();
            cnx.Close();
            return true;
        }

        public Boolean SocioActualiza()
        {
            SqlConnection cnx = new SqlConnection("Server=CMR-PC; database=Socio; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("dbo.SocActualiza", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Nombre", MstrNombre));
            cmd.Parameters.Add(new SqlParameter("@Apellido", MstrApellido));
            cmd.Parameters.Add(new SqlParameter("@Direccion", MstrDireccion));
            cmd.Parameters.Add(new SqlParameter("@Telefono", MstrTelefono));
            cmd.Parameters.Add(new SqlParameter("@Id", MstrId));
            cnx.Open();
            cmd.ExecuteScalar();
            cnx.Close();
            return true;
        }

        public Boolean SocioConsulta()
        {
            SqlConnection cnx = new SqlConnection("Server=CMR-PC; database=Socio; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("dbo.SocConsulta", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            String NombreSocio1, ApellidoSocio1, DireccionSocio1, TelefonoSocio1;
            Boolean pasar = false;
            cmd.Parameters.Add(new SqlParameter("@Id", MstrId));
            cnx.Open();
            SqlDataReader leer;
            leer = cmd.ExecuteReader();
            if (leer.Read()==true)
            {
                NombreSocio1 = leer[1].ToString();
                ApellidoSocio1 = leer[2].ToString();
                DireccionSocio1 = leer[3].ToString();
                TelefonoSocio1 = leer[4].ToString();
                Nombre = NombreSocio1;
                Apellido = ApellidoSocio1;
                Direccion = DireccionSocio1;
                Telefono = TelefonoSocio1;
                cnx.Close();
                pasar = true;
            }
            if (pasar)
                return true;
            else
                return false;
        }

        #endregion
    }
}