namespace Sistema_ONG
{
    partial class frmIncentivos
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
            this.panMenuVertical = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnIncentivosEntregados = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnIncentivos = new System.Windows.Forms.Button();
            this.btnFondos = new System.Windows.Forms.Button();
            this.btnBeneficiarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtgIncentivos = new System.Windows.Forms.DataGridView();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.cboFondo = new System.Windows.Forms.ComboBox();
            this.richDescripcionIncentivo = new System.Windows.Forms.RichTextBox();
            this.txtNombreIncentivo = new System.Windows.Forms.TextBox();
            this.lblIdFondo = new System.Windows.Forms.Label();
            this.lblDescripcionIncentivo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombreIncentivo = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pFooter = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panMenuVertical.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIncentivos)).BeginInit();
            this.grpRegistro.SuspendLayout();
            this.pFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenuVertical
            // 
            this.panMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panMenuVertical.Controls.Add(this.btnUsuarios);
            this.panMenuVertical.Controls.Add(this.btnIncentivosEntregados);
            this.panMenuVertical.Controls.Add(this.btnMenu);
            this.panMenuVertical.Controls.Add(this.btnIncentivos);
            this.panMenuVertical.Controls.Add(this.btnFondos);
            this.panMenuVertical.Controls.Add(this.btnBeneficiarios);
            this.panMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.panMenuVertical.Name = "panMenuVertical";
            this.panMenuVertical.Size = new System.Drawing.Size(200, 911);
            this.panMenuVertical.TabIndex = 24;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 324);
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
            this.btnIncentivosEntregados.Location = new System.Drawing.Point(3, 254);
            this.btnIncentivosEntregados.Name = "btnIncentivosEntregados";
            this.btnIncentivosEntregados.Size = new System.Drawing.Size(197, 64);
            this.btnIncentivosEntregados.TabIndex = 4;
            this.btnIncentivosEntregados.Text = "Registro de incentivos Entregados";
            this.btnIncentivosEntregados.UseVisualStyleBackColor = true;
            this.btnIncentivosEntregados.Click += new System.EventHandler(this.btnIncentivosEntregados_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 810);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 100);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Volver al menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnIncentivos
            // 
            this.btnIncentivos.FlatAppearance.BorderSize = 0;
            this.btnIncentivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnIncentivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncentivos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncentivos.ForeColor = System.Drawing.Color.White;
            this.btnIncentivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncentivos.Location = new System.Drawing.Point(0, 116);
            this.btnIncentivos.Name = "btnIncentivos";
            this.btnIncentivos.Size = new System.Drawing.Size(197, 40);
            this.btnIncentivos.TabIndex = 2;
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
            this.btnFondos.Location = new System.Drawing.Point(0, 208);
            this.btnFondos.Name = "btnFondos";
            this.btnFondos.Size = new System.Drawing.Size(197, 40);
            this.btnFondos.TabIndex = 1;
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
            this.btnBeneficiarios.Location = new System.Drawing.Point(0, 162);
            this.btnBeneficiarios.Name = "btnBeneficiarios";
            this.btnBeneficiarios.Size = new System.Drawing.Size(197, 40);
            this.btnBeneficiarios.TabIndex = 0;
            this.btnBeneficiarios.Text = "Registro de beneficiarios";
            this.btnBeneficiarios.UseVisualStyleBackColor = true;
            this.btnBeneficiarios.Click += new System.EventHandler(this.btnBeneficiarios_Click_1);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grpDatos);
            this.panel1.Controls.Add(this.grpRegistro);
            this.panel1.Location = new System.Drawing.Point(200, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 778);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(56, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 91);
            this.panel2.TabIndex = 30;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(120, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitulo.Size = new System.Drawing.Size(679, 42);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Registro de datos de nuevos incentivos a entregar";
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.White;
            this.grpDatos.Controls.Add(this.btnEliminar);
            this.grpDatos.Controls.Add(this.btnModificar);
            this.grpDatos.Controls.Add(this.dtgIncentivos);
            this.grpDatos.Location = new System.Drawing.Point(56, 441);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(893, 251);
            this.grpDatos.TabIndex = 27;
            this.grpDatos.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(462, 188);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 46);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(271, 188);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(173, 46);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtgIncentivos
            // 
            this.dtgIncentivos.AllowUserToAddRows = false;
            this.dtgIncentivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgIncentivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIncentivos.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dtgIncentivos.Location = new System.Drawing.Point(31, 33);
            this.dtgIncentivos.MultiSelect = false;
            this.dtgIncentivos.Name = "dtgIncentivos";
            this.dtgIncentivos.ReadOnly = true;
            this.dtgIncentivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgIncentivos.RowHeadersWidth = 70;
            this.dtgIncentivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgIncentivos.Size = new System.Drawing.Size(837, 140);
            this.dtgIncentivos.TabIndex = 0;
            // 
            // grpRegistro
            // 
            this.grpRegistro.AutoSize = true;
            this.grpRegistro.BackColor = System.Drawing.Color.White;
            this.grpRegistro.Controls.Add(this.cboFondo);
            this.grpRegistro.Controls.Add(this.richDescripcionIncentivo);
            this.grpRegistro.Controls.Add(this.txtNombreIncentivo);
            this.grpRegistro.Controls.Add(this.lblIdFondo);
            this.grpRegistro.Controls.Add(this.lblDescripcionIncentivo);
            this.grpRegistro.Controls.Add(this.btnGuardar);
            this.grpRegistro.Controls.Add(this.textBox1);
            this.grpRegistro.Controls.Add(this.lblNombreIncentivo);
            this.grpRegistro.Location = new System.Drawing.Point(56, 136);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(893, 273);
            this.grpRegistro.TabIndex = 26;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Tag = "";
            // 
            // cboFondo
            // 
            this.cboFondo.FormattingEnabled = true;
            this.cboFondo.Location = new System.Drawing.Point(672, 39);
            this.cboFondo.Name = "cboFondo";
            this.cboFondo.Size = new System.Drawing.Size(185, 21);
            this.cboFondo.TabIndex = 23;
            // 
            // richDescripcionIncentivo
            // 
            this.richDescripcionIncentivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richDescripcionIncentivo.Location = new System.Drawing.Point(225, 87);
            this.richDescripcionIncentivo.Name = "richDescripcionIncentivo";
            this.richDescripcionIncentivo.Size = new System.Drawing.Size(219, 96);
            this.richDescripcionIncentivo.TabIndex = 22;
            this.richDescripcionIncentivo.Text = "";
            // 
            // txtNombreIncentivo
            // 
            this.txtNombreIncentivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreIncentivo.Location = new System.Drawing.Point(223, 39);
            this.txtNombreIncentivo.Name = "txtNombreIncentivo";
            this.txtNombreIncentivo.Size = new System.Drawing.Size(220, 20);
            this.txtNombreIncentivo.TabIndex = 20;
            // 
            // lblIdFondo
            // 
            this.lblIdFondo.AutoSize = true;
            this.lblIdFondo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFondo.Location = new System.Drawing.Point(460, 35);
            this.lblIdFondo.Name = "lblIdFondo";
            this.lblIdFondo.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.lblIdFondo.Size = new System.Drawing.Size(205, 24);
            this.lblIdFondo.TabIndex = 19;
            this.lblIdFondo.Text = "Seleccione destino del incentivo:";
            // 
            // lblDescripcionIncentivo
            // 
            this.lblDescripcionIncentivo.AutoSize = true;
            this.lblDescripcionIncentivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionIncentivo.Location = new System.Drawing.Point(17, 87);
            this.lblDescripcionIncentivo.Name = "lblDescripcionIncentivo";
            this.lblDescripcionIncentivo.Padding = new System.Windows.Forms.Padding(0, 4, 5, 4);
            this.lblDescripcionIncentivo.Size = new System.Drawing.Size(200, 24);
            this.lblDescripcionIncentivo.TabIndex = 18;
            this.lblDescripcionIncentivo.Text = "Digite descripcion del incentivo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(364, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(173, 46);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(570, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(60, 13);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // lblNombreIncentivo
            // 
            this.lblNombreIncentivo.AutoSize = true;
            this.lblNombreIncentivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreIncentivo.Location = new System.Drawing.Point(17, 39);
            this.lblNombreIncentivo.Name = "lblNombreIncentivo";
            this.lblNombreIncentivo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblNombreIncentivo.Size = new System.Drawing.Size(185, 24);
            this.lblNombreIncentivo.TabIndex = 17;
            this.lblNombreIncentivo.Text = "Digite el nombre del incentivo:";
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Black;
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(200, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(988, 38);
            this.pHeader.TabIndex = 28;
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pFooter.Controls.Add(this.lblFecha);
            this.pFooter.Controls.Add(this.lblHora);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.ForeColor = System.Drawing.Color.White;
            this.pFooter.Location = new System.Drawing.Point(200, 807);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(988, 104);
            this.pFooter.TabIndex = 29;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(30, 67);
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
            this.lblHora.Location = new System.Drawing.Point(25, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 54);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "21:49:45";
            // 
            // frmIncentivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1188, 911);
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.panMenuVertical);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIncentivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de incentivos";
            this.panMenuVertical.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIncentivos)).EndInit();
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMenuVertical;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnIncentivos;
        private System.Windows.Forms.Button btnFondos;
        private System.Windows.Forms.Button btnBeneficiarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dtgIncentivos;
        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.Label lblIdFondo;
        private System.Windows.Forms.Label lblDescripcionIncentivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombreIncentivo;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtNombreIncentivo;
        private System.Windows.Forms.RichTextBox richDescripcionIncentivo;
        private System.Windows.Forms.ComboBox cboFondo;
        private System.Windows.Forms.Button btnIncentivosEntregados;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
    }
}