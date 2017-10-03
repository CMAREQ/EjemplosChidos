namespace AgendaAsistente2
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label calleYNumeroLabel;
            System.Windows.Forms.Label coloniaLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label telCasaLabel;
            System.Windows.Forms.Label telCelLabel;
            System.Windows.Forms.Label emailPersonalLabel;
            System.Windows.Forms.Label emailTrabajoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.agendaDataSet = new AgendaAsistente2.agendaDataSet();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new AgendaAsistente2.agendaDataSetTableAdapters.PersonaTableAdapter();
            this.tableAdapterManager = new AgendaAsistente2.agendaDataSetTableAdapters.TableAdapterManager();
            this.personaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.personaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.calleYNumeroTextBox = new System.Windows.Forms.TextBox();
            this.coloniaTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.telCasaTextBox = new System.Windows.Forms.TextBox();
            this.telCelTextBox = new System.Windows.Forms.TextBox();
            this.emailPersonalTextBox = new System.Windows.Forms.TextBox();
            this.emailTrabajoTextBox = new System.Windows.Forms.TextBox();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            calleYNumeroLabel = new System.Windows.Forms.Label();
            coloniaLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            telCasaLabel = new System.Windows.Forms.Label();
            telCelLabel = new System.Windows.Forms.Label();
            emailPersonalLabel = new System.Windows.Forms.Label();
            emailTrabajoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingNavigator)).BeginInit();
            this.personaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(23, 57);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(23, 83);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 5;
            apellidoLabel.Text = "Apellido:";
            // 
            // calleYNumeroLabel
            // 
            calleYNumeroLabel.AutoSize = true;
            calleYNumeroLabel.Location = new System.Drawing.Point(23, 109);
            calleYNumeroLabel.Name = "calleYNumeroLabel";
            calleYNumeroLabel.Size = new System.Drawing.Size(80, 13);
            calleYNumeroLabel.TabIndex = 7;
            calleYNumeroLabel.Text = "Calle YNumero:";
            // 
            // coloniaLabel
            // 
            coloniaLabel.AutoSize = true;
            coloniaLabel.Location = new System.Drawing.Point(23, 135);
            coloniaLabel.Name = "coloniaLabel";
            coloniaLabel.Size = new System.Drawing.Size(45, 13);
            coloniaLabel.TabIndex = 9;
            coloniaLabel.Text = "Colonia:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(23, 161);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 11;
            ciudadLabel.Text = "Ciudad:";
            // 
            // telCasaLabel
            // 
            telCasaLabel.AutoSize = true;
            telCasaLabel.Location = new System.Drawing.Point(23, 187);
            telCasaLabel.Name = "telCasaLabel";
            telCasaLabel.Size = new System.Drawing.Size(52, 13);
            telCasaLabel.TabIndex = 13;
            telCasaLabel.Text = "Tel Casa:";
            // 
            // telCelLabel
            // 
            telCelLabel.AutoSize = true;
            telCelLabel.Location = new System.Drawing.Point(23, 213);
            telCelLabel.Name = "telCelLabel";
            telCelLabel.Size = new System.Drawing.Size(43, 13);
            telCelLabel.TabIndex = 15;
            telCelLabel.Text = "Tel Cel:";
            // 
            // emailPersonalLabel
            // 
            emailPersonalLabel.AutoSize = true;
            emailPersonalLabel.Location = new System.Drawing.Point(23, 239);
            emailPersonalLabel.Name = "emailPersonalLabel";
            emailPersonalLabel.Size = new System.Drawing.Size(79, 13);
            emailPersonalLabel.TabIndex = 17;
            emailPersonalLabel.Text = "Email Personal:";
            // 
            // emailTrabajoLabel
            // 
            emailTrabajoLabel.AutoSize = true;
            emailTrabajoLabel.Location = new System.Drawing.Point(23, 265);
            emailTrabajoLabel.Name = "emailTrabajoLabel";
            emailTrabajoLabel.Size = new System.Drawing.Size(74, 13);
            emailTrabajoLabel.TabIndex = 19;
            emailTrabajoLabel.Text = "Email Trabajo:";
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.agendaDataSet;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonaTableAdapter = this.personaTableAdapter;
            this.tableAdapterManager.UpdateOrder = AgendaAsistente2.agendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personaBindingNavigator
            // 
            this.personaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personaBindingNavigator.BindingSource = this.personaBindingSource;
            this.personaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.personaBindingNavigatorSaveItem});
            this.personaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personaBindingNavigator.Name = "personaBindingNavigator";
            this.personaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personaBindingNavigator.Size = new System.Drawing.Size(777, 25);
            this.personaBindingNavigator.TabIndex = 0;
            this.personaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personaBindingNavigatorSaveItem
            // 
            this.personaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personaBindingNavigatorSaveItem.Image")));
            this.personaBindingNavigatorSaveItem.Name = "personaBindingNavigatorSaveItem";
            this.personaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personaBindingNavigatorSaveItem.Text = "Save Data";
            this.personaBindingNavigatorSaveItem.Click += new System.EventHandler(this.personaBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(109, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(320, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(109, 54);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(320, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(109, 80);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(320, 20);
            this.apellidoTextBox.TabIndex = 6;
            // 
            // calleYNumeroTextBox
            // 
            this.calleYNumeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "CalleYNumero", true));
            this.calleYNumeroTextBox.Location = new System.Drawing.Point(109, 106);
            this.calleYNumeroTextBox.Name = "calleYNumeroTextBox";
            this.calleYNumeroTextBox.Size = new System.Drawing.Size(320, 20);
            this.calleYNumeroTextBox.TabIndex = 8;
            // 
            // coloniaTextBox
            // 
            this.coloniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Colonia", true));
            this.coloniaTextBox.Location = new System.Drawing.Point(109, 132);
            this.coloniaTextBox.Name = "coloniaTextBox";
            this.coloniaTextBox.Size = new System.Drawing.Size(320, 20);
            this.coloniaTextBox.TabIndex = 10;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(109, 158);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(320, 20);
            this.ciudadTextBox.TabIndex = 12;
            // 
            // telCasaTextBox
            // 
            this.telCasaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "TelCasa", true));
            this.telCasaTextBox.Location = new System.Drawing.Point(109, 184);
            this.telCasaTextBox.Name = "telCasaTextBox";
            this.telCasaTextBox.Size = new System.Drawing.Size(320, 20);
            this.telCasaTextBox.TabIndex = 14;
            // 
            // telCelTextBox
            // 
            this.telCelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "TelCel", true));
            this.telCelTextBox.Location = new System.Drawing.Point(109, 210);
            this.telCelTextBox.Name = "telCelTextBox";
            this.telCelTextBox.Size = new System.Drawing.Size(320, 20);
            this.telCelTextBox.TabIndex = 16;
            // 
            // emailPersonalTextBox
            // 
            this.emailPersonalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "EmailPersonal", true));
            this.emailPersonalTextBox.Location = new System.Drawing.Point(109, 236);
            this.emailPersonalTextBox.Name = "emailPersonalTextBox";
            this.emailPersonalTextBox.Size = new System.Drawing.Size(320, 20);
            this.emailPersonalTextBox.TabIndex = 18;
            // 
            // emailTrabajoTextBox
            // 
            this.emailTrabajoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "EmailTrabajo", true));
            this.emailTrabajoTextBox.Location = new System.Drawing.Point(109, 262);
            this.emailTrabajoTextBox.Name = "emailTrabajoTextBox";
            this.emailTrabajoTextBox.Size = new System.Drawing.Size(320, 20);
            this.emailTrabajoTextBox.TabIndex = 20;
            // 
            // pic_foto
            // 
            this.pic_foto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personaBindingSource, "Fotografia", true));
            this.pic_foto.Location = new System.Drawing.Point(461, 35);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(241, 243);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_foto.TabIndex = 21;
            this.pic_foto.TabStop = false;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(26, 316);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(107, 29);
            this.btn_cargar.TabIndex = 22;
            this.btn_cargar.Text = "Cargar datos";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(252, 316);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(107, 29);
            this.btn_anterior.TabIndex = 23;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(365, 316);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(107, 29);
            this.btn_siguiente.TabIndex = 24;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.Location = new System.Drawing.Point(139, 316);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(107, 29);
            this.btn_primero.TabIndex = 25;
            this.btn_primero.Text = "Primero";
            this.btn_primero.UseVisualStyleBackColor = true;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.Location = new System.Drawing.Point(478, 316);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(107, 29);
            this.btn_ultimo.TabIndex = 26;
            this.btn_ultimo.Text = "Último";
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(591, 316);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(90, 29);
            this.btn_salir.TabIndex = 27;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.personaBindingSource, "Fotografia", true));
            this.pictureBox1.Location = new System.Drawing.Point(506, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 405);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(calleYNumeroLabel);
            this.Controls.Add(this.calleYNumeroTextBox);
            this.Controls.Add(coloniaLabel);
            this.Controls.Add(this.coloniaTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(telCasaLabel);
            this.Controls.Add(this.telCasaTextBox);
            this.Controls.Add(telCelLabel);
            this.Controls.Add(this.telCelTextBox);
            this.Controls.Add(emailPersonalLabel);
            this.Controls.Add(this.emailPersonalTextBox);
            this.Controls.Add(emailTrabajoLabel);
            this.Controls.Add(this.emailTrabajoTextBox);
            this.Controls.Add(this.personaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Agenda asistente 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingNavigator)).EndInit();
            this.personaBindingNavigator.ResumeLayout(false);
            this.personaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private agendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private agendaDataSetTableAdapters.PersonaTableAdapter personaTableAdapter;
        private agendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton personaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox calleYNumeroTextBox;
        private System.Windows.Forms.TextBox coloniaTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox telCasaTextBox;
        private System.Windows.Forms.TextBox telCelTextBox;
        private System.Windows.Forms.TextBox emailPersonalTextBox;
        private System.Windows.Forms.TextBox emailTrabajoTextBox;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

