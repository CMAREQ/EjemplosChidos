using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Empleados
{
    public partial class FormaFacil : Form
    {
        public FormaFacil()
        {
            InitializeComponent();
        }

        private void dBPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dBPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBProyectoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoDataSet.DBP' Puede moverla o quitarla según sea necesario.
            this.dBPTableAdapter.Fill(this.dBProyectoDataSet.DBP);

        }
    }
}
