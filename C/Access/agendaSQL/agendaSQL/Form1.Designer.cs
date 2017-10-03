namespace agendaSQL
{
    partial class frm_agenda_sql
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
            this.lbl_fotografia = new System.Windows.Forms.Label();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_email_empresarial = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telmovil = new System.Windows.Forms.TextBox();
            this.txt_telcasa = new System.Windows.Forms.TextBox();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_colonia = new System.Windows.Forms.TextBox();
            this.txt_domicilio = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_email_empresarial = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telcel = new System.Windows.Forms.Label();
            this.lbl_telcasa = new System.Windows.Forms.Label();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.lbl_colonia = new System.Windows.Forms.Label();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_cargar_foto = new System.Windows.Forms.Button();
            this.Cnx = new System.Data.OleDb.OleDbConnection();
            this.ofd_foto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fotografia
            // 
            this.lbl_fotografia.AutoSize = true;
            this.lbl_fotografia.Location = new System.Drawing.Point(522, 8);
            this.lbl_fotografia.Name = "lbl_fotografia";
            this.lbl_fotografia.Size = new System.Drawing.Size(56, 13);
            this.lbl_fotografia.TabIndex = 55;
            this.lbl_fotografia.Text = "Fotografía";
            // 
            // pic_foto
            // 
            this.pic_foto.Location = new System.Drawing.Point(424, 32);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(262, 333);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_foto.TabIndex = 54;
            this.pic_foto.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(562, 425);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 25);
            this.btn_salir.TabIndex = 53;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(458, 425);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 25);
            this.btn_eliminar.TabIndex = 52;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(344, 425);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 25);
            this.btn_modificar.TabIndex = 51;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(236, 425);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 25);
            this.btn_agregar.TabIndex = 50;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(126, 425);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 25);
            this.btn_buscar.TabIndex = 49;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(24, 425);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 25);
            this.btn_limpiar.TabIndex = 48;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // txt_email_empresarial
            // 
            this.txt_email_empresarial.Location = new System.Drawing.Point(125, 345);
            this.txt_email_empresarial.Name = "txt_email_empresarial";
            this.txt_email_empresarial.Size = new System.Drawing.Size(249, 20);
            this.txt_email_empresarial.TabIndex = 47;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(125, 313);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(249, 20);
            this.txt_email.TabIndex = 46;
            // 
            // txt_telmovil
            // 
            this.txt_telmovil.Location = new System.Drawing.Point(125, 279);
            this.txt_telmovil.Name = "txt_telmovil";
            this.txt_telmovil.Size = new System.Drawing.Size(249, 20);
            this.txt_telmovil.TabIndex = 45;
            // 
            // txt_telcasa
            // 
            this.txt_telcasa.Location = new System.Drawing.Point(123, 246);
            this.txt_telcasa.Name = "txt_telcasa";
            this.txt_telcasa.Size = new System.Drawing.Size(249, 20);
            this.txt_telcasa.TabIndex = 44;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(123, 216);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(249, 20);
            this.txt_ciudad.TabIndex = 43;
            // 
            // txt_colonia
            // 
            this.txt_colonia.Location = new System.Drawing.Point(123, 179);
            this.txt_colonia.Name = "txt_colonia";
            this.txt_colonia.Size = new System.Drawing.Size(249, 20);
            this.txt_colonia.TabIndex = 42;
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Location = new System.Drawing.Point(122, 143);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(249, 20);
            this.txt_domicilio.TabIndex = 41;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(120, 105);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(249, 20);
            this.txt_apellido.TabIndex = 40;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(120, 68);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(249, 20);
            this.txt_nombre.TabIndex = 39;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(117, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(249, 20);
            this.txt_id.TabIndex = 38;
            // 
            // lbl_email_empresarial
            // 
            this.lbl_email_empresarial.AutoSize = true;
            this.lbl_email_empresarial.Location = new System.Drawing.Point(9, 348);
            this.lbl_email_empresarial.Name = "lbl_email_empresarial";
            this.lbl_email_empresarial.Size = new System.Drawing.Size(89, 13);
            this.lbl_email_empresarial.TabIndex = 37;
            this.lbl_email_empresarial.Text = "Email Empresarial";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(9, 316);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 36;
            this.lbl_email.Text = "Email";
            // 
            // lbl_telcel
            // 
            this.lbl_telcel.AutoSize = true;
            this.lbl_telcel.Location = new System.Drawing.Point(9, 286);
            this.lbl_telcel.Name = "lbl_telcel";
            this.lbl_telcel.Size = new System.Drawing.Size(76, 13);
            this.lbl_telcel.TabIndex = 35;
            this.lbl_telcel.Text = "Teléfono móvil";
            // 
            // lbl_telcasa
            // 
            this.lbl_telcasa.AutoSize = true;
            this.lbl_telcasa.Location = new System.Drawing.Point(9, 253);
            this.lbl_telcasa.Name = "lbl_telcasa";
            this.lbl_telcasa.Size = new System.Drawing.Size(90, 13);
            this.lbl_telcasa.TabIndex = 34;
            this.lbl_telcasa.Text = "Teléfono de casa";
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Location = new System.Drawing.Point(9, 223);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudad.TabIndex = 33;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // lbl_colonia
            // 
            this.lbl_colonia.AutoSize = true;
            this.lbl_colonia.Location = new System.Drawing.Point(9, 182);
            this.lbl_colonia.Name = "lbl_colonia";
            this.lbl_colonia.Size = new System.Drawing.Size(42, 13);
            this.lbl_colonia.TabIndex = 32;
            this.lbl_colonia.Text = "Colonia";
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Location = new System.Drawing.Point(9, 143);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(78, 13);
            this.lbl_domicilio.TabIndex = 31;
            this.lbl_domicilio.Text = "Calle y Número";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(9, 109);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 30;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(9, 72);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 29;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 31);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 13);
            this.lbl_id.TabIndex = 28;
            this.lbl_id.Text = "Id";
            // 
            // btn_cargar_foto
            // 
            this.btn_cargar_foto.Location = new System.Drawing.Point(489, 371);
            this.btn_cargar_foto.Name = "btn_cargar_foto";
            this.btn_cargar_foto.Size = new System.Drawing.Size(118, 35);
            this.btn_cargar_foto.TabIndex = 56;
            this.btn_cargar_foto.Text = "Cargar fotografía";
            this.btn_cargar_foto.UseVisualStyleBackColor = true;
            this.btn_cargar_foto.Click += new System.EventHandler(this.btn_cargar_foto_Click);
            // 
            // Cnx
            // 
            this.Cnx.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\clemente\\Documents\\Visual" +
    " Studio 2010\\Projects\\agendaSQL\\agenda.accdb\"";
            // 
            // frm_agenda_sql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 474);
            this.Controls.Add(this.btn_cargar_foto);
            this.Controls.Add(this.lbl_fotografia);
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_limpiar);
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
            this.Name = "frm_agenda_sql";
            this.Text = "Agenda SQL";
            this.Load += new System.EventHandler(this.frm_agenda_sql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fotografia;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.TextBox txt_email_empresarial;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telmovil;
        private System.Windows.Forms.TextBox txt_telcasa;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_colonia;
        private System.Windows.Forms.TextBox txt_domicilio;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_email_empresarial;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telcel;
        private System.Windows.Forms.Label lbl_telcasa;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_colonia;
        private System.Windows.Forms.Label lbl_domicilio;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_cargar_foto;
        private System.Data.OleDb.OleDbConnection Cnx;
        private System.Windows.Forms.OpenFileDialog ofd_foto;
    }
}

