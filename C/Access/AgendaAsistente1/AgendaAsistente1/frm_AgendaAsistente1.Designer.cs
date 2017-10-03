namespace AgendaAsistente1
{
    partial class frm_agendaAsistente1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.lbl_colonia = new System.Windows.Forms.Label();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.lbl_telcasa = new System.Windows.Forms.Label();
            this.lbl_telcel = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_email_empresarial = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet = new AgendaAsistente1.agendaDataSet();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_domicilio = new System.Windows.Forms.TextBox();
            this.txt_colonia = new System.Windows.Forms.TextBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_telcasa = new System.Windows.Forms.TextBox();
            this.txt_telmovil = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_email_empresarial = new System.Windows.Forms.TextBox();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.lbl_fotografia = new System.Windows.Forms.Label();
            this.personaTableAdapter = new AgendaAsistente1.agendaDataSetTableAdapters.PersonaTableAdapter();
            this.personaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.personaBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource8)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(24, 44);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Id";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(21, 85);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(21, 122);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Location = new System.Drawing.Point(21, 156);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(78, 13);
            this.lbl_domicilio.TabIndex = 3;
            this.lbl_domicilio.Text = "Calle y Número";
            // 
            // lbl_colonia
            // 
            this.lbl_colonia.AutoSize = true;
            this.lbl_colonia.Location = new System.Drawing.Point(21, 195);
            this.lbl_colonia.Name = "lbl_colonia";
            this.lbl_colonia.Size = new System.Drawing.Size(42, 13);
            this.lbl_colonia.TabIndex = 4;
            this.lbl_colonia.Text = "Colonia";
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(21, 236);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 5;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // lbl_telcasa
            // 
            this.lbl_telcasa.AutoSize = true;
            this.lbl_telcasa.Location = new System.Drawing.Point(21, 266);
            this.lbl_telcasa.Name = "lbl_telcasa";
            this.lbl_telcasa.Size = new System.Drawing.Size(90, 13);
            this.lbl_telcasa.TabIndex = 6;
            this.lbl_telcasa.Text = "Teléfono de casa";
            // 
            // lbl_telcel
            // 
            this.lbl_telcel.AutoSize = true;
            this.lbl_telcel.Location = new System.Drawing.Point(21, 299);
            this.lbl_telcel.Name = "lbl_telcel";
            this.lbl_telcel.Size = new System.Drawing.Size(76, 13);
            this.lbl_telcel.TabIndex = 7;
            this.lbl_telcel.Text = "Teléfono móvil";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(21, 329);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email";
            // 
            // lbl_email_empresarial
            // 
            this.lbl_email_empresarial.AutoSize = true;
            this.lbl_email_empresarial.Location = new System.Drawing.Point(21, 361);
            this.lbl_email_empresarial.Name = "lbl_email_empresarial";
            this.lbl_email_empresarial.Size = new System.Drawing.Size(89, 13);
            this.lbl_email_empresarial.TabIndex = 9;
            this.lbl_email_empresarial.Text = "Email Empresarial";
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Id", true));
            this.txt_id.Location = new System.Drawing.Point(129, 44);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(249, 20);
            this.txt_id.TabIndex = 10;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.agendaDataSet;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "agendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_nombre
            // 
            this.txt_nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Nombre", true));
            this.txt_nombre.Location = new System.Drawing.Point(132, 81);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(249, 20);
            this.txt_nombre.TabIndex = 11;
            // 
            // txt_apellido
            // 
            this.txt_apellido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Apellido", true));
            this.txt_apellido.Location = new System.Drawing.Point(132, 118);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(249, 20);
            this.txt_apellido.TabIndex = 12;
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "CalleYNumero", true));
            this.txt_domicilio.Location = new System.Drawing.Point(134, 156);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(249, 20);
            this.txt_domicilio.TabIndex = 13;
            // 
            // txt_colonia
            // 
            this.txt_colonia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Colonia", true));
            this.txt_colonia.Location = new System.Drawing.Point(135, 192);
            this.txt_colonia.Name = "txt_colonia";
            this.txt_colonia.Size = new System.Drawing.Size(249, 20);
            this.txt_colonia.TabIndex = 14;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Ciudad", true));
            this.txt_ciudad.Location = new System.Drawing.Point(135, 229);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(249, 20);
            this.txt_ciudad.TabIndex = 15;
            // 
            // txt_telcasa
            // 
            this.txt_telcasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "TelCasa", true));
            this.txt_telcasa.Location = new System.Drawing.Point(135, 259);
            this.txt_telcasa.Name = "txt_telcasa";
            this.txt_telcasa.Size = new System.Drawing.Size(249, 20);
            this.txt_telcasa.TabIndex = 16;
            // 
            // txt_telmovil
            // 
            this.txt_telmovil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "TelCel", true));
            this.txt_telmovil.Location = new System.Drawing.Point(137, 292);
            this.txt_telmovil.Name = "txt_telmovil";
            this.txt_telmovil.Size = new System.Drawing.Size(249, 20);
            this.txt_telmovil.TabIndex = 17;
            // 
            // txt_email
            // 
            this.txt_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "EmailPersonal", true));
            this.txt_email.Location = new System.Drawing.Point(137, 326);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(249, 20);
            this.txt_email.TabIndex = 18;
            // 
            // txt_email_empresarial
            // 
            this.txt_email_empresarial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "EmailTrabajo", true));
            this.txt_email_empresarial.Location = new System.Drawing.Point(137, 358);
            this.txt_email_empresarial.Name = "txt_email_empresarial";
            this.txt_email_empresarial.Size = new System.Drawing.Size(249, 20);
            this.txt_email_empresarial.TabIndex = 19;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(36, 397);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(75, 42);
            this.btn_cargar.TabIndex = 20;
            this.btn_cargar.Text = "Cargar Datos";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.Location = new System.Drawing.Point(138, 397);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(75, 25);
            this.btn_primero.TabIndex = 21;
            this.btn_primero.Text = "Primero";
            this.btn_primero.UseVisualStyleBackColor = true;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(248, 397);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(75, 25);
            this.btn_anterior.TabIndex = 22;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(356, 397);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 25);
            this.btn_siguiente.TabIndex = 23;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.Location = new System.Drawing.Point(470, 397);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(75, 25);
            this.btn_ultimo.TabIndex = 24;
            this.btn_ultimo.Text = "Último";
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(574, 397);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 25);
            this.btn_salir.TabIndex = 25;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pic_foto
            // 
            this.pic_foto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personaBindingSource, "Fotografia", true));
            this.pic_foto.Location = new System.Drawing.Point(434, 37);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(262, 333);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_foto.TabIndex = 26;
            this.pic_foto.TabStop = false;
            // 
            // lbl_fotografia
            // 
            this.lbl_fotografia.AutoSize = true;
            this.lbl_fotografia.Location = new System.Drawing.Point(534, 21);
            this.lbl_fotografia.Name = "lbl_fotografia";
            this.lbl_fotografia.Size = new System.Drawing.Size(56, 13);
            this.lbl_fotografia.TabIndex = 27;
            this.lbl_fotografia.Text = "Fotografía";
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // personaBindingSource1
            // 
            this.personaBindingSource1.DataMember = "Persona";
            this.personaBindingSource1.DataSource = this.agendaDataSet;
            // 
            // personaBindingSource2
            // 
            this.personaBindingSource2.DataMember = "Persona";
            this.personaBindingSource2.DataSource = this.agendaDataSet;
            // 
            // personaBindingSource3
            // 
            this.personaBindingSource3.DataMember = "Persona";
            this.personaBindingSource3.DataSource = this.agendaDataSet;
            // 
            // personaBindingSource4
            // 
            this.personaBindingSource4.DataMember = "Persona";
            this.personaBindingSource4.DataSource = this.agendaDataSet;
            // 
            // personaBindingSource5
            // 
            this.personaBindingSource5.DataMember = "Persona";
            this.personaBindingSource5.DataSource = this.agendaDataSet;
            // 
            // personaBindingSource6
            // 
            this.personaBindingSource6.DataMember = "Persona";
            this.personaBindingSource6.DataSource = this.agendaDataSet;
            // 
            // personaBindingSource7
            // 
            this.personaBindingSource7.DataMember = "Persona";
            this.personaBindingSource7.DataSource = this.agendaDataSet;
            // 
            // personaBindingSource8
            // 
            this.personaBindingSource8.DataMember = "Persona";
            this.personaBindingSource8.DataSource = this.agendaDataSet;
            // 
            // frm_agendaAsistente1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 458);
            this.Controls.Add(this.lbl_fotografia);
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.txt_email_empresarial);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telmovil);
            this.Controls.Add(this.txt_telcasa);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.txt_colonia);
            this.Controls.Add(this.txt_domicilio);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_email_empresarial);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_telcel);
            this.Controls.Add(this.lbl_telcasa);
            this.Controls.Add(this.lbl_ciudad);
            this.Controls.Add(this.lbl_colonia);
            this.Controls.Add(this.lbl_domicilio);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_agendaAsistente1";
            this.Text = "Agenda Asistente 1";
            this.Load += new System.EventHandler(this.frm_AgendaAsistente1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_domicilio;
        private System.Windows.Forms.Label lbl_colonia;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_telcasa;
        private System.Windows.Forms.Label lbl_telcel;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_email_empresarial;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_domicilio;
        private System.Windows.Forms.TextBox txt_colonia;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_telcasa;
        private System.Windows.Forms.TextBox txt_telmovil;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_email_empresarial;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.Label lbl_fotografia;
        private agendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private agendaDataSetTableAdapters.PersonaTableAdapter personaTableAdapter;
        private System.Windows.Forms.BindingSource personaBindingSource1;
        private System.Windows.Forms.BindingSource personaBindingSource2;
        private System.Windows.Forms.BindingSource personaBindingSource3;
        private System.Windows.Forms.BindingSource personaBindingSource4;
        private System.Windows.Forms.BindingSource personaBindingSource5;
        private System.Windows.Forms.BindingSource personaBindingSource6;
        private System.Windows.Forms.BindingSource personaBindingSource7;
        private System.Windows.Forms.BindingSource personaBindingSource8;
    }
}

