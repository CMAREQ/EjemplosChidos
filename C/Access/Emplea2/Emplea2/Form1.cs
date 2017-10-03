using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Emplea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoDataSet.DBP' Puede moverla o quitarla según sea necesario.
            this.dBPTableAdapter.Fill(this.dBProyectoDataSet.DBP);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            this.dBPBindingSource.MoveFirst();
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            this.dBPBindingSource.MovePrevious();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            this.dBPBindingSource.MoveNext();
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            this.dBPBindingSource.MoveLast();
        }
    }
}
