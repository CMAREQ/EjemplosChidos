using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaAsistente1
{
    public partial class frm_agendaAsistente1 : Form
    {
        public frm_agendaAsistente1()
        {
            InitializeComponent();
        }

        private void frm_AgendaAsistente1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaDataSet.Persona' table. You can move, or remove it, as needed.

        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            this.personaTableAdapter.Fill(this.agendaDataSet.Persona);

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            personaBindingSource.MoveFirst();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            personaBindingSource.MovePrevious();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            personaBindingSource.MoveNext();
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            personaBindingSource.MoveLast();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

