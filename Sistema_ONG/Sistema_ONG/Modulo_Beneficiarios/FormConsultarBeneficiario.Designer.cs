namespace Sistema_ONG
{
    partial class frmConsultarBeneficiario
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgBeneficiarios = new System.Windows.Forms.DataGridView();
            this.txtBuscarDui = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.pHeader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBeneficiarios)).BeginInit();
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
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.grpRegistro);
            this.panel1.Location = new System.Drawing.Point(197, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 546);
            this.panel1.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(42, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 91);
            this.panel3.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(221, 21);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(345, 42);
            this.label2.TabIndex = 28;
            this.label2.Text = "Registro de beneficiarios";
            // 
            // grpRegistro
            // 
            this.grpRegistro.AutoSize = true;
            this.grpRegistro.BackColor = System.Drawing.Color.White;
            this.grpRegistro.Controls.Add(this.btnAgregar);
            this.grpRegistro.Controls.Add(this.btnEliminar);
            this.grpRegistro.Controls.Add(this.btnModificar);
            this.grpRegistro.Controls.Add(this.btnBuscar);
            this.grpRegistro.Controls.Add(this.dtgBeneficiarios);
            this.grpRegistro.Controls.Add(this.txtBuscarDui);
            this.grpRegistro.Controls.Add(this.label1);
            this.grpRegistro.Location = new System.Drawing.Point(42, 64);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(832, 435);
            this.grpRegistro.TabIndex = 30;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Tag = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(578, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 34);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(413, 373);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(156, 43);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(251, 373);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(156, 43);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(397, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(156, 34);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // dtgBeneficiarios
            // 
            this.dtgBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBeneficiarios.Location = new System.Drawing.Point(71, 117);
            this.dtgBeneficiarios.Name = "dtgBeneficiarios";
            this.dtgBeneficiarios.Size = new System.Drawing.Size(643, 245);
            this.dtgBeneficiarios.TabIndex = 18;
            // 
            // txtBuscarDui
            // 
            this.txtBuscarDui.Location = new System.Drawing.Point(194, 84);
            this.txtBuscarDui.Mask = "99999999";
            this.txtBuscarDui.Name = "txtBuscarDui";
            this.txtBuscarDui.Size = new System.Drawing.Size(170, 20);
            this.txtBuscarDui.TabIndex = 17;
            this.txtBuscarDui.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 85);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "N° documento dui: ";
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pFooter.Controls.Add(this.button1);
            this.pFooter.Controls.Add(this.lblFecha);
            this.pFooter.Controls.Add(this.lblHora);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.ForeColor = System.Drawing.Color.White;
            this.pFooter.Location = new System.Drawing.Point(0, 586);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1124, 103);
            this.pFooter.TabIndex = 31;
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
            this.button1.TabIndex = 5;
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
            this.lblFecha.Location = new System.Drawing.Point(258, 67);
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
            this.lblHora.Location = new System.Drawing.Point(253, 13);
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
            this.panMenuVertical.Controls.Add(this.btnMenu);
            this.panMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.panMenuVertical.Name = "panMenuVertical";
            this.panMenuVertical.Size = new System.Drawing.Size(197, 586);
            this.panMenuVertical.TabIndex = 32;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 308);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(194, 64);
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
            this.btnIncentivos.Click += new System.EventHandler(this.btnIncentivos_Click_1);
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
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 681);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 100);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Volver al menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Black;
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(197, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(927, 38);
            this.pHeader.TabIndex = 33;
            // 
            // frmConsultarBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1124, 689);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.panMenuVertical);
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultarBeneficiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de beneficiarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBeneficiarios)).EndInit();
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            this.panMenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgBeneficiarios;
        private System.Windows.Forms.MaskedTextBox txtBuscarDui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panMenuVertical;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button btnIncentivosEntregados;
        private System.Windows.Forms.Button btnIncentivos;
        private System.Windows.Forms.Button btnFondos;
        private System.Windows.Forms.Button btnBeneficiarios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}