namespace Empleados
{
    partial class FormaFacil
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label turnoLabel;
            System.Windows.Forms.Label contactoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaFacil));
            this.dBProyectoDataSet = new Empleados.DBProyectoDataSet();
            this.dBPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPTableAdapter = new Empleados.DBProyectoDataSetTableAdapters.DBPTableAdapter();
            this.tableAdapterManager = new Empleados.DBProyectoDataSetTableAdapters.TableAdapterManager();
            this.dBPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dBPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.turnoTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.pic_Empleado = new System.Windows.Forms.PictureBox();
            this.dBPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pic_Empresa = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            turnoLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBProyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPBindingNavigator)).BeginInit();
            this.dBPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Empresa)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(23, 180);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(23, 211);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(63, 16);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(23, 242);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(64, 16);
            apellidoLabel.TabIndex = 5;
            apellidoLabel.Text = "Apellido:";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departamentoLabel.Location = new System.Drawing.Point(23, 273);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(107, 16);
            departamentoLabel.TabIndex = 7;
            departamentoLabel.Text = "Departamento:";
            // 
            // turnoLabel
            // 
            turnoLabel.AutoSize = true;
            turnoLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            turnoLabel.Location = new System.Drawing.Point(23, 303);
            turnoLabel.Name = "turnoLabel";
            turnoLabel.Size = new System.Drawing.Size(51, 16);
            turnoLabel.TabIndex = 9;
            turnoLabel.Text = "Turno:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactoLabel.Location = new System.Drawing.Point(23, 335);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(75, 16);
            contactoLabel.TabIndex = 11;
            contactoLabel.Text = "Contacto:";
            // 
            // dBProyectoDataSet
            // 
            this.dBProyectoDataSet.DataSetName = "DBProyectoDataSet";
            this.dBProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBPBindingSource
            // 
            this.dBPBindingSource.DataMember = "DBP";
            this.dBPBindingSource.DataSource = this.dBProyectoDataSet;
            // 
            // dBPTableAdapter
            // 
            this.dBPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DBPTableAdapter = this.dBPTableAdapter;
            this.tableAdapterManager.UpdateOrder = Empleados.DBProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dBPBindingNavigator
            // 
            this.dBPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dBPBindingNavigator.BindingSource = this.dBPBindingSource;
            this.dBPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dBPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dBPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dBPBindingNavigatorSaveItem});
            this.dBPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dBPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dBPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dBPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dBPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dBPBindingNavigator.Name = "dBPBindingNavigator";
            this.dBPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dBPBindingNavigator.Size = new System.Drawing.Size(589, 25);
            this.dBPBindingNavigator.TabIndex = 0;
            this.dBPBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dBPBindingNavigatorSaveItem
            // 
            this.dBPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dBPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dBPBindingNavigatorSaveItem.Image")));
            this.dBPBindingNavigatorSaveItem.Name = "dBPBindingNavigatorSaveItem";
            this.dBPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dBPBindingNavigatorSaveItem.Text = "Guardar datos";
            this.dBPBindingNavigatorSaveItem.Click += new System.EventHandler(this.dBPBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(139, 177);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(172, 23);
            this.idTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(139, 208);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(172, 23);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(139, 239);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(172, 23);
            this.apellidoTextBox.TabIndex = 6;
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Departamento", true));
            this.departamentoTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamentoTextBox.Location = new System.Drawing.Point(139, 270);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(172, 23);
            this.departamentoTextBox.TabIndex = 8;
            // 
            // turnoTextBox
            // 
            this.turnoTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.turnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Turno", true));
            this.turnoTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnoTextBox.Location = new System.Drawing.Point(139, 300);
            this.turnoTextBox.Name = "turnoTextBox";
            this.turnoTextBox.Size = new System.Drawing.Size(172, 23);
            this.turnoTextBox.TabIndex = 10;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Contacto", true));
            this.contactoTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactoTextBox.Location = new System.Drawing.Point(139, 332);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(172, 23);
            this.contactoTextBox.TabIndex = 12;
            // 
            // pic_Empleado
            // 
            this.pic_Empleado.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dBPBindingSource, "Imagen", true));
            this.pic_Empleado.Location = new System.Drawing.Point(328, 41);
            this.pic_Empleado.Name = "pic_Empleado";
            this.pic_Empleado.Size = new System.Drawing.Size(241, 314);
            this.pic_Empleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Empleado.TabIndex = 13;
            this.pic_Empleado.TabStop = false;
            // 
            // dBPBindingSource1
            // 
            this.dBPBindingSource1.DataMember = "DBP";
            this.dBPBindingSource1.DataSource = this.dBProyectoDataSet;
            // 
            // pic_Empresa
            // 
            this.pic_Empresa.Image = global::Empleados.Properties.Resources.Imagen1;
            this.pic_Empresa.Location = new System.Drawing.Point(26, 41);
            this.pic_Empresa.Name = "pic_Empresa";
            this.pic_Empresa.Size = new System.Drawing.Size(285, 115);
            this.pic_Empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Empresa.TabIndex = 14;
            this.pic_Empresa.TabStop = false;
            // 
            // FormaFacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(589, 385);
            this.Controls.Add(this.pic_Empresa);
            this.Controls.Add(this.pic_Empleado);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(departamentoLabel);
            this.Controls.Add(this.departamentoTextBox);
            this.Controls.Add(turnoLabel);
            this.Controls.Add(this.turnoTextBox);
            this.Controls.Add(contactoLabel);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(this.dBPBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormaFacil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBProyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPBindingNavigator)).EndInit();
            this.dBPBindingNavigator.ResumeLayout(false);
            this.dBPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Empresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBProyectoDataSet dBProyectoDataSet;
        private System.Windows.Forms.BindingSource dBPBindingSource;
        private DBProyectoDataSetTableAdapters.DBPTableAdapter dBPTableAdapter;
        private DBProyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dBPBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dBPBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.TextBox turnoTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.PictureBox pic_Empleado;
        private System.Windows.Forms.BindingSource dBPBindingSource1;
        private System.Windows.Forms.PictureBox pic_Empresa;
    }
}

