namespace PracticaWinForms
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtboxApellido = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.txtboxEdad = new System.Windows.Forms.TextBox();
            this.txtboxDireccion = new System.Windows.Forms.TextBox();
            this.txtboxResultado = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellido.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApellido.Location = new System.Drawing.Point(67, 27);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(105, 26);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "APELLIDO";
            this.lblApellido.MouseLeave += new System.EventHandler(this.lblApellido_MouseLeave);
            this.lblApellido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblApellido_MouseMove);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(67, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 26);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            this.lblNombre.MouseLeave += new System.EventHandler(this.lblNombre_MouseLeave);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEdad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEdad.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEdad.Location = new System.Drawing.Point(67, 135);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(64, 26);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "EDAD";
            this.lblEdad.MouseLeave += new System.EventHandler(this.lblEdad_MouseLeave);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDireccion.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccion.Location = new System.Drawing.Point(50, 187);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(122, 26);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "DIRECCIÓN";
            this.lblDireccion.MouseLeave += new System.EventHandler(this.lblDireccion_MouseLeave);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultado.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Location = new System.Drawing.Point(28, 247);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(125, 26);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "RESULTADO";
            this.lblResultado.MouseLeave += new System.EventHandler(this.lblResultado_MouseLeave);
            // 
            // txtboxApellido
            // 
            this.txtboxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtboxApellido.Location = new System.Drawing.Point(178, 31);
            this.txtboxApellido.MaxLength = 20;
            this.txtboxApellido.Name = "txtboxApellido";
            this.txtboxApellido.Size = new System.Drawing.Size(369, 20);
            this.txtboxApellido.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoEllipsis = true;
            this.btnAceptar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(82, 414);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 32);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtboxNombre.Location = new System.Drawing.Point(178, 84);
            this.txtboxNombre.MaxLength = 20;
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(369, 20);
            this.txtboxNombre.TabIndex = 7;
            // 
            // txtboxEdad
            // 
            this.txtboxEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtboxEdad.Location = new System.Drawing.Point(178, 139);
            this.txtboxEdad.MaxLength = 20;
            this.txtboxEdad.Name = "txtboxEdad";
            this.txtboxEdad.Size = new System.Drawing.Size(369, 20);
            this.txtboxEdad.TabIndex = 8;
            this.txtboxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxEdad_KeyPress);
            // 
            // txtboxDireccion
            // 
            this.txtboxDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtboxDireccion.Location = new System.Drawing.Point(178, 193);
            this.txtboxDireccion.MaxLength = 20;
            this.txtboxDireccion.Name = "txtboxDireccion";
            this.txtboxDireccion.Size = new System.Drawing.Size(369, 20);
            this.txtboxDireccion.TabIndex = 9;
            // 
            // txtboxResultado
            // 
            this.txtboxResultado.AcceptsReturn = true;
            this.txtboxResultado.Location = new System.Drawing.Point(28, 276);
            this.txtboxResultado.Multiline = true;
            this.txtboxResultado.Name = "txtboxResultado";
            this.txtboxResultado.Size = new System.Drawing.Size(526, 133);
            this.txtboxResultado.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoEllipsis = true;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(343, 414);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 32);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(614, 459);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtboxResultado);
            this.Controls.Add(this.txtboxDireccion);
            this.Controls.Add(this.txtboxEdad);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtboxApellido);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtboxApellido;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.TextBox txtboxEdad;
        private System.Windows.Forms.TextBox txtboxDireccion;
        private System.Windows.Forms.TextBox txtboxResultado;
        private System.Windows.Forms.Button btnCancelar;
    }
}

