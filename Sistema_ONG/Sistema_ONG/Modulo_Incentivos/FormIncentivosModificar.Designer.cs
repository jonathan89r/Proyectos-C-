namespace Sistema_ONG
{
    partial class frmIncentivosModificar
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
            this.panDatos = new System.Windows.Forms.Panel();
            this.cboFondo = new System.Windows.Forms.ComboBox();
            this.richDescripcionIncentivo = new System.Windows.Forms.RichTextBox();
            this.txtNombreIncentivo = new System.Windows.Forms.TextBox();
            this.lblIdFondo = new System.Windows.Forms.Label();
            this.lblDescripcionIncentivo = new System.Windows.Forms.Label();
            this.lblNombreIncentivo = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panDatos);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 464);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(67, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 91);
            this.panel2.TabIndex = 32;
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
            // panDatos
            // 
            this.panDatos.BackColor = System.Drawing.Color.White;
            this.panDatos.Controls.Add(this.cboFondo);
            this.panDatos.Controls.Add(this.richDescripcionIncentivo);
            this.panDatos.Controls.Add(this.txtNombreIncentivo);
            this.panDatos.Controls.Add(this.lblIdFondo);
            this.panDatos.Controls.Add(this.lblDescripcionIncentivo);
            this.panDatos.Controls.Add(this.lblNombreIncentivo);
            this.panDatos.Controls.Add(this.btnActualizar);
            this.panDatos.Location = new System.Drawing.Point(67, 117);
            this.panDatos.Name = "panDatos";
            this.panDatos.Size = new System.Drawing.Size(554, 294);
            this.panDatos.TabIndex = 0;
            // 
            // cboFondo
            // 
            this.cboFondo.FormattingEnabled = true;
            this.cboFondo.Location = new System.Drawing.Point(256, 73);
            this.cboFondo.Name = "cboFondo";
            this.cboFondo.Size = new System.Drawing.Size(220, 21);
            this.cboFondo.TabIndex = 29;
            // 
            // richDescripcionIncentivo
            // 
            this.richDescripcionIncentivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richDescripcionIncentivo.Location = new System.Drawing.Point(256, 111);
            this.richDescripcionIncentivo.Name = "richDescripcionIncentivo";
            this.richDescripcionIncentivo.Size = new System.Drawing.Size(219, 96);
            this.richDescripcionIncentivo.TabIndex = 28;
            this.richDescripcionIncentivo.Text = "";
            // 
            // txtNombreIncentivo
            // 
            this.txtNombreIncentivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreIncentivo.Location = new System.Drawing.Point(256, 29);
            this.txtNombreIncentivo.Name = "txtNombreIncentivo";
            this.txtNombreIncentivo.Size = new System.Drawing.Size(220, 20);
            this.txtNombreIncentivo.TabIndex = 27;
            // 
            // lblIdFondo
            // 
            this.lblIdFondo.AutoSize = true;
            this.lblIdFondo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFondo.Location = new System.Drawing.Point(33, 73);
            this.lblIdFondo.Name = "lblIdFondo";
            this.lblIdFondo.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.lblIdFondo.Size = new System.Drawing.Size(206, 24);
            this.lblIdFondo.TabIndex = 26;
            this.lblIdFondo.Text = "Seleccione destino del incentivo:";
            // 
            // lblDescripcionIncentivo
            // 
            this.lblDescripcionIncentivo.AutoSize = true;
            this.lblDescripcionIncentivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionIncentivo.Location = new System.Drawing.Point(33, 111);
            this.lblDescripcionIncentivo.Name = "lblDescripcionIncentivo";
            this.lblDescripcionIncentivo.Padding = new System.Windows.Forms.Padding(0, 4, 5, 4);
            this.lblDescripcionIncentivo.Size = new System.Drawing.Size(201, 24);
            this.lblDescripcionIncentivo.TabIndex = 25;
            this.lblDescripcionIncentivo.Text = "Digite descripcion del incentivo:";
            // 
            // lblNombreIncentivo
            // 
            this.lblNombreIncentivo.AutoSize = true;
            this.lblNombreIncentivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreIncentivo.Location = new System.Drawing.Point(33, 25);
            this.lblNombreIncentivo.Name = "lblNombreIncentivo";
            this.lblNombreIncentivo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblNombreIncentivo.Size = new System.Drawing.Size(186, 24);
            this.lblNombreIncentivo.TabIndex = 24;
            this.lblNombreIncentivo.Text = "Digite el nombre del incentivo:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(182, 229);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(206, 46);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Modificar registro";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmIncentivosModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIncentivosModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifcacion de incentivo guardado";
            this.Load += new System.EventHandler(this.frmIncentivosModificar_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panDatos.ResumeLayout(false);
            this.panDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panDatos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cboFondo;
        private System.Windows.Forms.RichTextBox richDescripcionIncentivo;
        private System.Windows.Forms.TextBox txtNombreIncentivo;
        private System.Windows.Forms.Label lblIdFondo;
        private System.Windows.Forms.Label lblDescripcionIncentivo;
        private System.Windows.Forms.Label lblNombreIncentivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
    }
}