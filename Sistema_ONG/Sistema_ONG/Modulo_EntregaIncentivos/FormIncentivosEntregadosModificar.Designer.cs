namespace Sistema_ONG
{
    partial class frmIncentivosEntregadosModificar
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
            this.panDatos = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblIncentivoActualizar = new System.Windows.Forms.Label();
            this.lblBeneficiarioActualizar = new System.Windows.Forms.Label();
            this.lblFechaEntregaActualizar = new System.Windows.Forms.Label();
            this.cboBeneficiario = new System.Windows.Forms.ComboBox();
            this.cboFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.cboIncentivo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDatos
            // 
            this.panDatos.BackColor = System.Drawing.Color.White;
            this.panDatos.Controls.Add(this.btnActualizar);
            this.panDatos.Controls.Add(this.lblIncentivoActualizar);
            this.panDatos.Controls.Add(this.lblBeneficiarioActualizar);
            this.panDatos.Controls.Add(this.lblFechaEntregaActualizar);
            this.panDatos.Controls.Add(this.cboBeneficiario);
            this.panDatos.Controls.Add(this.cboFechaEntrega);
            this.panDatos.Controls.Add(this.cboIncentivo);
            this.panDatos.Location = new System.Drawing.Point(70, 138);
            this.panDatos.Name = "panDatos";
            this.panDatos.Size = new System.Drawing.Size(554, 267);
            this.panDatos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(171, 193);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(206, 46);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Modificar registro";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblIncentivoActualizar
            // 
            this.lblIncentivoActualizar.AutoSize = true;
            this.lblIncentivoActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncentivoActualizar.Location = new System.Drawing.Point(33, 84);
            this.lblIncentivoActualizar.Name = "lblIncentivoActualizar";
            this.lblIncentivoActualizar.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.lblIncentivoActualizar.Size = new System.Drawing.Size(139, 24);
            this.lblIncentivoActualizar.TabIndex = 22;
            this.lblIncentivoActualizar.Text = "Seleccione incentivo:";
            // 
            // lblBeneficiarioActualizar
            // 
            this.lblBeneficiarioActualizar.AutoSize = true;
            this.lblBeneficiarioActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiarioActualizar.Location = new System.Drawing.Point(33, 135);
            this.lblBeneficiarioActualizar.Name = "lblBeneficiarioActualizar";
            this.lblBeneficiarioActualizar.Padding = new System.Windows.Forms.Padding(0, 4, 20, 4);
            this.lblBeneficiarioActualizar.Size = new System.Drawing.Size(172, 24);
            this.lblBeneficiarioActualizar.TabIndex = 21;
            this.lblBeneficiarioActualizar.Text = "Seleccione beneficiario:";
            // 
            // lblFechaEntregaActualizar
            // 
            this.lblFechaEntregaActualizar.AutoSize = true;
            this.lblFechaEntregaActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntregaActualizar.Location = new System.Drawing.Point(33, 36);
            this.lblFechaEntregaActualizar.Name = "lblFechaEntregaActualizar";
            this.lblFechaEntregaActualizar.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblFechaEntregaActualizar.Size = new System.Drawing.Size(179, 24);
            this.lblFechaEntregaActualizar.TabIndex = 20;
            this.lblFechaEntregaActualizar.Text = "Seleccione fecha a entregar:";
            // 
            // cboBeneficiario
            // 
            this.cboBeneficiario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBeneficiario.FormattingEnabled = true;
            this.cboBeneficiario.Location = new System.Drawing.Point(222, 135);
            this.cboBeneficiario.Name = "cboBeneficiario";
            this.cboBeneficiario.Size = new System.Drawing.Size(264, 25);
            this.cboBeneficiario.TabIndex = 17;
            // 
            // cboFechaEntrega
            // 
            this.cboFechaEntrega.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cboFechaEntrega.Location = new System.Drawing.Point(222, 36);
            this.cboFechaEntrega.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.cboFechaEntrega.MinDate = new System.DateTime(2022, 11, 18, 0, 0, 0, 0);
            this.cboFechaEntrega.Name = "cboFechaEntrega";
            this.cboFechaEntrega.Size = new System.Drawing.Size(264, 22);
            this.cboFechaEntrega.TabIndex = 19;
            this.cboFechaEntrega.Value = new System.DateTime(2022, 11, 18, 0, 0, 0, 0);
            // 
            // cboIncentivo
            // 
            this.cboIncentivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIncentivo.FormattingEnabled = true;
            this.cboIncentivo.Items.AddRange(new object[] {
            "Seleccione beneficiario"});
            this.cboIncentivo.Location = new System.Drawing.Point(222, 84);
            this.cboIncentivo.Name = "cboIncentivo";
            this.cboIncentivo.Size = new System.Drawing.Size(264, 25);
            this.cboIncentivo.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panDatos);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 463);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(70, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 91);
            this.panel2.TabIndex = 33;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(136, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitulo.Size = new System.Drawing.Size(268, 42);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Registro guardado";
            // 
            // frmIncentivosEntregadosModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIncentivosEntregadosModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifcacion de incentivo guardado";
            this.Load += new System.EventHandler(this.frmIncentivosEntregadosModificar_Load);
            this.panDatos.ResumeLayout(false);
            this.panDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panDatos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblIncentivoActualizar;
        private System.Windows.Forms.Label lblBeneficiarioActualizar;
        private System.Windows.Forms.Label lblFechaEntregaActualizar;
        private System.Windows.Forms.ComboBox cboBeneficiario;
        private System.Windows.Forms.DateTimePicker cboFechaEntrega;
        private System.Windows.Forms.ComboBox cboIncentivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
    }
}