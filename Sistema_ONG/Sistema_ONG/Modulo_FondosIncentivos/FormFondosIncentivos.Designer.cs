namespace Sistema_ONG.Modulo_FondosIncentivos
{
    partial class frmFondosIncentivos
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblfondo = new System.Windows.Forms.Label();
            this.txtFondo = new System.Windows.Forms.TextBox();
            this.btnModificarDatos = new System.Windows.Forms.Button();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.btnLlenarDatos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgFondosIncentivos = new System.Windows.Forms.DataGridView();
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
            this.panel3.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFondosIncentivos)).BeginInit();
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
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.grpRegistro);
            this.panel1.Location = new System.Drawing.Point(197, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 389);
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
            this.lblTitulo.Location = new System.Drawing.Point(236, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitulo.Size = new System.Drawing.Size(490, 42);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Registro de fondos de los incentivos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.lblfondo);
            this.panel3.Controls.Add(this.txtFondo);
            this.panel3.Controls.Add(this.btnModificarDatos);
            this.panel3.Location = new System.Drawing.Point(48, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 230);
            this.panel3.TabIndex = 52;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(166, 104);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 54;
            this.txtId.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardar.Location = new System.Drawing.Point(133, 134);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 47);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblfondo
            // 
            this.lblfondo.AutoSize = true;
            this.lblfondo.BackColor = System.Drawing.Color.White;
            this.lblfondo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblfondo.ForeColor = System.Drawing.Color.Black;
            this.lblfondo.Location = new System.Drawing.Point(36, 71);
            this.lblfondo.Name = "lblfondo";
            this.lblfondo.Size = new System.Drawing.Size(117, 16);
            this.lblfondo.TabIndex = 52;
            this.lblfondo.Text = "Nombre del fondo:";
            // 
            // txtFondo
            // 
            this.txtFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFondo.Location = new System.Drawing.Point(166, 65);
            this.txtFondo.Name = "txtFondo";
            this.txtFondo.Size = new System.Drawing.Size(212, 26);
            this.txtFondo.TabIndex = 51;
            // 
            // btnModificarDatos
            // 
            this.btnModificarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnModificarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDatos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModificarDatos.Location = new System.Drawing.Point(133, 134);
            this.btnModificarDatos.Name = "btnModificarDatos";
            this.btnModificarDatos.Size = new System.Drawing.Size(141, 47);
            this.btnModificarDatos.TabIndex = 50;
            this.btnModificarDatos.Text = "Modificar";
            this.btnModificarDatos.UseVisualStyleBackColor = false;
            this.btnModificarDatos.Click += new System.EventHandler(this.btnModificarDatos_Click);
            // 
            // grpRegistro
            // 
            this.grpRegistro.AutoSize = true;
            this.grpRegistro.BackColor = System.Drawing.Color.White;
            this.grpRegistro.Controls.Add(this.btnLlenarDatos);
            this.grpRegistro.Controls.Add(this.btnEliminar);
            this.grpRegistro.Controls.Add(this.dtgFondosIncentivos);
            this.grpRegistro.Location = new System.Drawing.Point(489, 119);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(547, 230);
            this.grpRegistro.TabIndex = 30;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Tag = "";
            // 
            // btnLlenarDatos
            // 
            this.btnLlenarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnLlenarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLlenarDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenarDatos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLlenarDatos.Location = new System.Drawing.Point(12, 53);
            this.btnLlenarDatos.Name = "btnLlenarDatos";
            this.btnLlenarDatos.Size = new System.Drawing.Size(141, 47);
            this.btnLlenarDatos.TabIndex = 49;
            this.btnLlenarDatos.Text = "Modificar";
            this.btnLlenarDatos.UseVisualStyleBackColor = false;
            this.btnLlenarDatos.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.Location = new System.Drawing.Point(12, 112);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 42);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtgFondosIncentivos
            // 
            this.dtgFondosIncentivos.AllowUserToAddRows = false;
            this.dtgFondosIncentivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFondosIncentivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFondosIncentivos.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dtgFondosIncentivos.Location = new System.Drawing.Point(171, 44);
            this.dtgFondosIncentivos.MultiSelect = false;
            this.dtgFondosIncentivos.Name = "dtgFondosIncentivos";
            this.dtgFondosIncentivos.ReadOnly = true;
            this.dtgFondosIncentivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgFondosIncentivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFondosIncentivos.Size = new System.Drawing.Size(348, 157);
            this.dtgFondosIncentivos.TabIndex = 30;
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pFooter.Controls.Add(this.button1);
            this.pFooter.Controls.Add(this.lblFecha);
            this.pFooter.Controls.Add(this.lblHora);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.ForeColor = System.Drawing.Color.White;
            this.pFooter.Location = new System.Drawing.Point(0, 427);
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
            this.panMenuVertical.Size = new System.Drawing.Size(197, 427);
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
            // frmFondosIncentivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 530);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.panMenuVertical);
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.panel1);
            this.Name = "frmFondosIncentivos";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de fondos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFondosIncentivos)).EndInit();
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            this.panMenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.Button btnLlenarDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dtgFondosIncentivos;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblfondo;
        private System.Windows.Forms.TextBox txtFondo;
        private System.Windows.Forms.Button btnModificarDatos;
        private System.Windows.Forms.TextBox txtId;
    }
}