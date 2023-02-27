namespace Sistema_ONG
{
    partial class frmMenu
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIncentivosEntregados = new System.Windows.Forms.Button();
            this.btnIncentivos = new System.Windows.Forms.Button();
            this.btnFondos = new System.Windows.Forms.Button();
            this.btnBeneficiarios = new System.Windows.Forms.Button();
            this.pFooter = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panMenuVertical.SuspendLayout();
            this.pFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenuVertical
            // 
            this.panMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panMenuVertical.Controls.Add(this.btnUsuarios);
            this.panMenuVertical.Controls.Add(this.btnSalir);
            this.panMenuVertical.Controls.Add(this.btnIncentivosEntregados);
            this.panMenuVertical.Controls.Add(this.btnIncentivos);
            this.panMenuVertical.Controls.Add(this.btnFondos);
            this.panMenuVertical.Controls.Add(this.btnBeneficiarios);
            this.panMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.panMenuVertical.Name = "panMenuVertical";
            this.panMenuVertical.Size = new System.Drawing.Size(200, 657);
            this.panMenuVertical.TabIndex = 25;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 553);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 102);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIncentivosEntregados
            // 
            this.btnIncentivosEntregados.FlatAppearance.BorderSize = 0;
            this.btnIncentivosEntregados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnIncentivosEntregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncentivosEntregados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncentivosEntregados.ForeColor = System.Drawing.Color.White;
            this.btnIncentivosEntregados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncentivosEntregados.Location = new System.Drawing.Point(0, 254);
            this.btnIncentivosEntregados.Name = "btnIncentivosEntregados";
            this.btnIncentivosEntregados.Size = new System.Drawing.Size(197, 64);
            this.btnIncentivosEntregados.TabIndex = 3;
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
            this.btnBeneficiarios.Click += new System.EventHandler(this.btnBeneficiarios_Click);
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pFooter.Controls.Add(this.lblFecha);
            this.pFooter.Controls.Add(this.lblHora);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.ForeColor = System.Drawing.Color.White;
            this.pFooter.Location = new System.Drawing.Point(200, 553);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(984, 104);
            this.pFooter.TabIndex = 26;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(26, 68);
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
            this.lblHora.Location = new System.Drawing.Point(21, 14);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 54);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "21:49:45";
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Black;
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(200, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(984, 38);
            this.pHeader.TabIndex = 27;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 312);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(197, 64);
            this.btnUsuarios.TabIndex = 29;
            this.btnUsuarios.Text = "Registro de usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1184, 657);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.panMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.panMenuVertical.ResumeLayout(false);
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panMenuVertical;
        private System.Windows.Forms.Button btnIncentivos;
        private System.Windows.Forms.Button btnFondos;
        private System.Windows.Forms.Button btnBeneficiarios;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button btnIncentivosEntregados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUsuarios;
    }
}