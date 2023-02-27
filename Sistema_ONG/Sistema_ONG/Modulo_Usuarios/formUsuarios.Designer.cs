
namespace Sistema_ONG.Modulo_Usuarios
{
    partial class frmUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_tipo_usuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masktbox_password = new System.Windows.Forms.MaskedTextBox();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_direccion_empleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combob_Sexo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datepicker_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_Apellido_Empleado = new System.Windows.Forms.Label();
            this.lbnombre_empleado = new System.Windows.Forms.Label();
            this.txtApellido_Empleado = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Empleado = new System.Windows.Forms.TextBox();
            this.DGW_Users = new System.Windows.Forms.DataGridView();
            this.pFooter = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panMenuVertical = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnIncentivosEntregados = new System.Windows.Forms.Button();
            this.btnIncentivos = new System.Windows.Forms.Button();
            this.btnFondos = new System.Windows.Forms.Button();
            this.btnBeneficiarios = new System.Windows.Forms.Button();
            this.pHeader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Users)).BeginInit();
            this.pFooter.SuspendLayout();
            this.panMenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grpRegistro);
            this.panel1.Location = new System.Drawing.Point(197, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 660);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(48, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 91);
            this.panel2.TabIndex = 51;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(352, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitulo.Size = new System.Drawing.Size(284, 42);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Registro de usuarios";
            // 
            // grpRegistro
            // 
            this.grpRegistro.AutoSize = true;
            this.grpRegistro.BackColor = System.Drawing.Color.White;
            this.grpRegistro.Controls.Add(this.btn_guardar);
            this.grpRegistro.Controls.Add(this.btn_modificar);
            this.grpRegistro.Controls.Add(this.btn_eliminar);
            this.grpRegistro.Controls.Add(this.btn_nuevo);
            this.grpRegistro.Controls.Add(this.label5);
            this.grpRegistro.Controls.Add(this.cmb_tipo_usuario);
            this.grpRegistro.Controls.Add(this.label4);
            this.grpRegistro.Controls.Add(this.masktbox_password);
            this.grpRegistro.Controls.Add(this.lbl_nombre_usuario);
            this.grpRegistro.Controls.Add(this.txt_nombre_usuario);
            this.grpRegistro.Controls.Add(this.label3);
            this.grpRegistro.Controls.Add(this.txt_direccion_empleado);
            this.grpRegistro.Controls.Add(this.label2);
            this.grpRegistro.Controls.Add(this.combob_Sexo);
            this.grpRegistro.Controls.Add(this.label1);
            this.grpRegistro.Controls.Add(this.datepicker_fecha_nacimiento);
            this.grpRegistro.Controls.Add(this.lbl_Apellido_Empleado);
            this.grpRegistro.Controls.Add(this.lbnombre_empleado);
            this.grpRegistro.Controls.Add(this.txtApellido_Empleado);
            this.grpRegistro.Controls.Add(this.txt_Nombre_Empleado);
            this.grpRegistro.Controls.Add(this.DGW_Users);
            this.grpRegistro.Location = new System.Drawing.Point(48, 119);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(988, 510);
            this.grpRegistro.TabIndex = 30;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Tag = "";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_guardar.Location = new System.Drawing.Point(19, 38);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(141, 43);
            this.btn_guardar.TabIndex = 50;
            this.btn_guardar.Text = "Guardar Usuario";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_modificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_modificar.Location = new System.Drawing.Point(19, 88);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(141, 47);
            this.btn_modificar.TabIndex = 49;
            this.btn_modificar.Text = "Modificar Usuario";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click_1);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_eliminar.Location = new System.Drawing.Point(19, 136);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(141, 42);
            this.btn_eliminar.TabIndex = 48;
            this.btn_eliminar.Text = "Eliminar Usuario";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_nuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_nuevo.Location = new System.Drawing.Point(19, 36);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(141, 46);
            this.btn_nuevo.TabIndex = 47;
            this.btn_nuevo.Text = "Nuevo Usuario";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(577, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tipo Usuario:";
            // 
            // cmb_tipo_usuario
            // 
            this.cmb_tipo_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_tipo_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_usuario.FormattingEnabled = true;
            this.cmb_tipo_usuario.Items.AddRange(new object[] {
            "Administrador",
            "Normal"});
            this.cmb_tipo_usuario.Location = new System.Drawing.Point(697, 365);
            this.cmb_tipo_usuario.Name = "cmb_tipo_usuario";
            this.cmb_tipo_usuario.Size = new System.Drawing.Size(225, 28);
            this.cmb_tipo_usuario.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(577, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Contraseña Usuario:";
            // 
            // masktbox_password
            // 
            this.masktbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktbox_password.Location = new System.Drawing.Point(707, 311);
            this.masktbox_password.Name = "masktbox_password";
            this.masktbox_password.PasswordChar = '*';
            this.masktbox_password.Size = new System.Drawing.Size(217, 26);
            this.masktbox_password.TabIndex = 43;
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.BackColor = System.Drawing.Color.White;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_nombre_usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(577, 264);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(104, 16);
            this.lbl_nombre_usuario.TabIndex = 42;
            this.lbl_nombre_usuario.Text = "Nombre Usuario:";
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.Location = new System.Drawing.Point(697, 258);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(227, 26);
            this.txt_nombre_usuario.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(177, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Dirección Empleado:";
            // 
            // txt_direccion_empleado
            // 
            this.txt_direccion_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_empleado.Location = new System.Drawing.Point(178, 403);
            this.txt_direccion_empleado.Multiline = true;
            this.txt_direccion_empleado.Name = "txt_direccion_empleado";
            this.txt_direccion_empleado.Size = new System.Drawing.Size(340, 73);
            this.txt_direccion_empleado.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(579, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Sexo Empleado:";
            // 
            // combob_Sexo
            // 
            this.combob_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combob_Sexo.FormattingEnabled = true;
            this.combob_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.combob_Sexo.Location = new System.Drawing.Point(697, 210);
            this.combob_Sexo.Name = "combob_Sexo";
            this.combob_Sexo.Size = new System.Drawing.Size(227, 28);
            this.combob_Sexo.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(177, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fecha de Nacimiento:";
            // 
            // datepicker_fecha_nacimiento
            // 
            this.datepicker_fecha_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker_fecha_nacimiento.Location = new System.Drawing.Point(321, 317);
            this.datepicker_fecha_nacimiento.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.datepicker_fecha_nacimiento.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.datepicker_fecha_nacimiento.Name = "datepicker_fecha_nacimiento";
            this.datepicker_fecha_nacimiento.Size = new System.Drawing.Size(198, 26);
            this.datepicker_fecha_nacimiento.TabIndex = 35;
            this.datepicker_fecha_nacimiento.Value = new System.DateTime(2022, 11, 24, 0, 0, 0, 0);
            // 
            // lbl_Apellido_Empleado
            // 
            this.lbl_Apellido_Empleado.AutoSize = true;
            this.lbl_Apellido_Empleado.BackColor = System.Drawing.Color.White;
            this.lbl_Apellido_Empleado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Apellido_Empleado.ForeColor = System.Drawing.Color.Black;
            this.lbl_Apellido_Empleado.Location = new System.Drawing.Point(175, 258);
            this.lbl_Apellido_Empleado.Name = "lbl_Apellido_Empleado";
            this.lbl_Apellido_Empleado.Size = new System.Drawing.Size(123, 16);
            this.lbl_Apellido_Empleado.TabIndex = 34;
            this.lbl_Apellido_Empleado.Text = "Apellido Empleado:";
            // 
            // lbnombre_empleado
            // 
            this.lbnombre_empleado.AutoSize = true;
            this.lbnombre_empleado.BackColor = System.Drawing.Color.White;
            this.lbnombre_empleado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lbnombre_empleado.ForeColor = System.Drawing.Color.Black;
            this.lbnombre_empleado.Location = new System.Drawing.Point(177, 216);
            this.lbnombre_empleado.Name = "lbnombre_empleado";
            this.lbnombre_empleado.Size = new System.Drawing.Size(121, 16);
            this.lbnombre_empleado.TabIndex = 33;
            this.lbnombre_empleado.Text = "Nombre Empleado:";
            // 
            // txtApellido_Empleado
            // 
            this.txtApellido_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido_Empleado.Location = new System.Drawing.Point(307, 258);
            this.txtApellido_Empleado.Name = "txtApellido_Empleado";
            this.txtApellido_Empleado.Size = new System.Drawing.Size(212, 26);
            this.txtApellido_Empleado.TabIndex = 32;
            // 
            // txt_Nombre_Empleado
            // 
            this.txt_Nombre_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre_Empleado.Location = new System.Drawing.Point(307, 210);
            this.txt_Nombre_Empleado.Name = "txt_Nombre_Empleado";
            this.txt_Nombre_Empleado.Size = new System.Drawing.Size(212, 26);
            this.txt_Nombre_Empleado.TabIndex = 31;
            // 
            // DGW_Users
            // 
            this.DGW_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Users.GridColor = System.Drawing.Color.DarkKhaki;
            this.DGW_Users.Location = new System.Drawing.Point(178, 34);
            this.DGW_Users.Name = "DGW_Users";
            this.DGW_Users.ReadOnly = true;
            this.DGW_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGW_Users.Size = new System.Drawing.Size(786, 157);
            this.DGW_Users.TabIndex = 30;
            this.DGW_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_Users_CellContentClick);
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pFooter.Controls.Add(this.button1);
            this.pFooter.Controls.Add(this.lblFecha);
            this.pFooter.Controls.Add(this.lblHora);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.ForeColor = System.Drawing.Color.White;
            this.pFooter.Location = new System.Drawing.Point(0, 701);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1284, 103);
            this.pFooter.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 103);
            this.button1.TabIndex = 12;
            this.button1.Text = "Volver al menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(278, 67);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(224, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(273, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 54);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "21:49:45";
            // 
            // panMenuVertical
            // 
            this.panMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panMenuVertical.Controls.Add(this.btnUsuarios);
            this.panMenuVertical.Controls.Add(this.btnIncentivosEntregados);
            this.panMenuVertical.Controls.Add(this.btnIncentivos);
            this.panMenuVertical.Controls.Add(this.btnFondos);
            this.panMenuVertical.Controls.Add(this.btnBeneficiarios);
            this.panMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.panMenuVertical.Name = "panMenuVertical";
            this.panMenuVertical.Size = new System.Drawing.Size(197, 701);
            this.panMenuVertical.TabIndex = 37;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 304);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(197, 64);
            this.btnUsuarios.TabIndex = 30;
            this.btnUsuarios.Text = "Registro de usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnIncentivosEntregados
            // 
            this.btnIncentivosEntregados.FlatAppearance.BorderSize = 0;
            this.btnIncentivosEntregados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnIncentivosEntregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncentivosEntregados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncentivosEntregados.ForeColor = System.Drawing.Color.White;
            this.btnIncentivosEntregados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncentivosEntregados.Location = new System.Drawing.Point(-3, 238);
            this.btnIncentivosEntregados.Name = "btnIncentivosEntregados";
            this.btnIncentivosEntregados.Size = new System.Drawing.Size(200, 64);
            this.btnIncentivosEntregados.TabIndex = 11;
            this.btnIncentivosEntregados.Text = "Registro de incentivos Entregados";
            this.btnIncentivosEntregados.UseVisualStyleBackColor = true;
            this.btnIncentivosEntregados.Click += new System.EventHandler(this.btnIncentivosEntregados_Click);
            // 
            // btnIncentivos
            // 
            this.btnIncentivos.FlatAppearance.BorderSize = 0;
            this.btnIncentivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnIncentivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncentivos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncentivos.ForeColor = System.Drawing.Color.White;
            this.btnIncentivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncentivos.Location = new System.Drawing.Point(-3, 100);
            this.btnIncentivos.Name = "btnIncentivos";
            this.btnIncentivos.Size = new System.Drawing.Size(200, 40);
            this.btnIncentivos.TabIndex = 10;
            this.btnIncentivos.Text = "Registro de incentivos";
            this.btnIncentivos.UseVisualStyleBackColor = true;
            this.btnIncentivos.Click += new System.EventHandler(this.btnIncentivos_Click);
            // 
            // btnFondos
            // 
            this.btnFondos.FlatAppearance.BorderSize = 0;
            this.btnFondos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnFondos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFondos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFondos.ForeColor = System.Drawing.Color.White;
            this.btnFondos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFondos.Location = new System.Drawing.Point(-3, 192);
            this.btnFondos.Name = "btnFondos";
            this.btnFondos.Size = new System.Drawing.Size(200, 40);
            this.btnFondos.TabIndex = 9;
            this.btnFondos.Text = "Registro de fondos";
            this.btnFondos.UseVisualStyleBackColor = true;
            this.btnFondos.Click += new System.EventHandler(this.btnFondos_Click);
            // 
            // btnBeneficiarios
            // 
            this.btnBeneficiarios.FlatAppearance.BorderSize = 0;
            this.btnBeneficiarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnBeneficiarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeneficiarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeneficiarios.ForeColor = System.Drawing.Color.White;
            this.btnBeneficiarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeneficiarios.Location = new System.Drawing.Point(-3, 146);
            this.btnBeneficiarios.Name = "btnBeneficiarios";
            this.btnBeneficiarios.Size = new System.Drawing.Size(200, 40);
            this.btnBeneficiarios.TabIndex = 8;
            this.btnBeneficiarios.Text = "Registro de beneficiarios";
            this.btnBeneficiarios.UseVisualStyleBackColor = true;
            this.btnBeneficiarios.Click += new System.EventHandler(this.btnBeneficiarios_Click);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Black;
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(197, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1087, 38);
            this.pHeader.TabIndex = 38;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 804);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.panMenuVertical);
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.panel1);
            this.Name = "frmUsuarios";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Users)).EndInit();
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            this.panMenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_tipo_usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox masktbox_password;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_direccion_empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combob_Sexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datepicker_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_Apellido_Empleado;
        private System.Windows.Forms.Label lbnombre_empleado;
        private System.Windows.Forms.TextBox txtApellido_Empleado;
        private System.Windows.Forms.TextBox txt_Nombre_Empleado;
        private System.Windows.Forms.DataGridView DGW_Users;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panMenuVertical;
        private System.Windows.Forms.Button btnIncentivosEntregados;
        private System.Windows.Forms.Button btnIncentivos;
        private System.Windows.Forms.Button btnFondos;
        private System.Windows.Forms.Button btnBeneficiarios;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
    }
}