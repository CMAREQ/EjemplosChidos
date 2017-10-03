namespace Emplea2
{
    partial class Form1
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
            this.pic_Empleado = new System.Windows.Forms.PictureBox();
            this.dBPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProyectoDataSet = new Emplea2.DBProyectoDataSet();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.turnoTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_Anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pic_Empresa = new System.Windows.Forms.PictureBox();
            this.dBPTableAdapter = new Emplea2.DBProyectoDataSetTableAdapters.DBPTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            turnoLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Empresa)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(12, 151);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 16);
            idLabel.TabIndex = 14;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(12, 182);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(63, 16);
            nombreLabel.TabIndex = 16;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(12, 213);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(64, 16);
            apellidoLabel.TabIndex = 18;
            apellidoLabel.Text = "Apellido:";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departamentoLabel.Location = new System.Drawing.Point(12, 244);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(107, 16);
            departamentoLabel.TabIndex = 20;
            departamentoLabel.Text = "Departamento:";
            // 
            // turnoLabel
            // 
            turnoLabel.AutoSize = true;
            turnoLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            turnoLabel.Location = new System.Drawing.Point(12, 274);
            turnoLabel.Name = "turnoLabel";
            turnoLabel.Size = new System.Drawing.Size(51, 16);
            turnoLabel.TabIndex = 22;
            turnoLabel.Text = "Turno:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactoLabel.Location = new System.Drawing.Point(12, 306);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(75, 16);
            contactoLabel.TabIndex = 24;
            contactoLabel.Text = "Contacto:";
            // 
            // pic_Empleado
            // 
            this.pic_Empleado.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dBPBindingSource, "Imagen", true));
            this.pic_Empleado.Location = new System.Drawing.Point(317, 12);
            this.pic_Empleado.Name = "pic_Empleado";
            this.pic_Empleado.Size = new System.Drawing.Size(241, 314);
            this.pic_Empleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Empleado.TabIndex = 26;
            this.pic_Empleado.TabStop = false;
            // 
            // dBPBindingSource
            // 
            this.dBPBindingSource.DataMember = "DBP";
            this.dBPBindingSource.DataSource = this.dBProyectoDataSet;
            // 
            // dBProyectoDataSet
            // 
            this.dBProyectoDataSet.DataSetName = "DBProyectoDataSet";
            this.dBProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(128, 148);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(172, 23);
            this.idTextBox.TabIndex = 15;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(128, 179);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(172, 23);
            this.nombreTextBox.TabIndex = 17;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(128, 210);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(172, 23);
            this.apellidoTextBox.TabIndex = 19;
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Departamento", true));
            this.departamentoTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamentoTextBox.Location = new System.Drawing.Point(128, 241);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(172, 23);
            this.departamentoTextBox.TabIndex = 21;
            // 
            // turnoTextBox
            // 
            this.turnoTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.turnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Turno", true));
            this.turnoTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnoTextBox.Location = new System.Drawing.Point(128, 271);
            this.turnoTextBox.Name = "turnoTextBox";
            this.turnoTextBox.Size = new System.Drawing.Size(172, 23);
            this.turnoTextBox.TabIndex = 23;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBPBindingSource, "Contacto", true));
            this.contactoTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactoTextBox.Location = new System.Drawing.Point(128, 303);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(172, 23);
            this.contactoTextBox.TabIndex = 25;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.Location = new System.Drawing.Point(14, 359);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar.TabIndex = 27;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_primero.Location = new System.Drawing.Point(105, 359);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(75, 23);
            this.btn_primero.TabIndex = 28;
            this.btn_primero.Text = "Primero";
            this.btn_primero.UseVisualStyleBackColor = true;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anterior.Location = new System.Drawing.Point(205, 359);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_Anterior.TabIndex = 29;
            this.btn_Anterior.Text = "Anterior";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            this.btn_Anterior.Click += new System.EventHandler(this.btn_Anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Location = new System.Drawing.Point(286, 359);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguiente.TabIndex = 30;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ultimo.Location = new System.Drawing.Point(389, 359);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(75, 23);
            this.btn_ultimo.TabIndex = 31;
            this.btn_ultimo.Text = "Ultimo";
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(482, 359);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 32;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pic_Empresa
            // 
            this.pic_Empresa.Image = global::Emplea2.Properties.Resources.Imagen1;
            this.pic_Empresa.Location = new System.Drawing.Point(15, 12);
            this.pic_Empresa.Name = "pic_Empresa";
            this.pic_Empresa.Size = new System.Drawing.Size(285, 115);
            this.pic_Empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Empresa.TabIndex = 33;
            this.pic_Empresa.TabStop = false;
            // 
            // dBPTableAdapter
            // 
            this.dBPTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(575, 391);
            this.Controls.Add(this.pic_Empresa);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_Anterior);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(this.btn_cargar);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Empresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Empleado;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.TextBox turnoTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_Anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pic_Empresa;
        private DBProyectoDataSet dBProyectoDataSet;
        private System.Windows.Forms.BindingSource dBPBindingSource;
        private DBProyectoDataSetTableAdapters.DBPTableAdapter dBPTableAdapter;
    }
}

