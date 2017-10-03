﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ExamenAlumno
{
    class Alumno
    {
        #region Definicion de propiedades        
        private String MstrMatricula;
        private String MstrNombre;
        private String MstrApellido;
        private String MstrMateria;
        #endregion

        public string Matricula
        {
            get
            {
                return MstrMatricula;
            }
            set
            {
                MstrMatricula = value;
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

        public string Materia
        {
            get
            {
                return MstrMateria;
            }
            set
            {
                MstrMateria = value;
            }
        }



        #region Definicion de metodos
        public Boolean Alta()
        {
            SqlConnection cnx = new SqlConnection("Server=CMR-PC; database=Examen; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("dbo.AlAlta", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Matricula", MstrMatricula));
            cmd.Parameters.Add(new SqlParameter("@Nombre", MstrNombre));
            cmd.Parameters.Add(new SqlParameter("@Apellido", MstrApellido));
            cmd.Parameters.Add(new SqlParameter("@Materia", MstrMateria));
            cnx.Open();
            cmd.ExecuteScalar();
            cnx.Close();
            return true;
        }

        public Boolean Baja()
        {
            SqlConnection cnx = new SqlConnection("Server=CMR-PC; database=Examen; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("dbo.AlBaja", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Matricula", MstrMatricula));
            cnx.Open();
            cmd.ExecuteScalar();
            cnx.Close();
            return true;
        }

        public Boolean Actualiza()
        {
            SqlConnection cnx = new SqlConnection("Server=CMR-PC; database=Examen; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("dbo.AlActualiza", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Nombre", MstrNombre));
            cmd.Parameters.Add(new SqlParameter("@Apellido", MstrApellido));
            cmd.Parameters.Add(new SqlParameter("@Materia", MstrMateria));
            cmd.Parameters.Add(new SqlParameter("@Matricula", MstrMatricula));
            cnx.Open();
            cmd.ExecuteScalar();
            cnx.Close();
            return true;
        }

        public Boolean Consulta()
        {
            SqlConnection cnx = new SqlConnection("Server=CMR-PC; database=Examen; Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("dbo.AlConsulta", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            String Nombre1, Apellido1, Materia1;
            Boolean pasar = false;
            cmd.Parameters.Add(new SqlParameter("@Matricula", MstrMatricula));
            cnx.Open();
            SqlDataReader leer;
            leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                Nombre1 = leer[1].ToString();
                Apellido1 = leer[2].ToString();
                Materia1 = leer[3].ToString();
                Nombre = Nombre1;
                Apellido = Apellido1;
                Materia = Materia1;
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