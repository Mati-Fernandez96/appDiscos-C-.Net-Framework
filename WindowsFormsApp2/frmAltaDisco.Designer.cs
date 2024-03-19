namespace WindowsFormsApp2
{
    partial class frmAltaDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.dtpFechaLanz = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudCantCanciones = new System.Windows.Forms.NumericUpDown();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cbEdicion = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.pbDisco = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(22, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(22, 76);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(115, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha de Lanzamiento";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Location = new System.Drawing.Point(22, 102);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(116, 13);
            this.lblCantCanciones.TabIndex = 2;
            this.lblCantCanciones.Text = "Cantidad de canciones";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(160, 43);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // dtpFechaLanz
            // 
            this.dtpFechaLanz.Location = new System.Drawing.Point(160, 69);
            this.dtpFechaLanz.Name = "dtpFechaLanz";
            this.dtpFechaLanz.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLanz.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(64, 325);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudCantCanciones
            // 
            this.nudCantCanciones.Location = new System.Drawing.Point(160, 95);
            this.nudCantCanciones.Name = "nudCantCanciones";
            this.nudCantCanciones.Size = new System.Drawing.Size(120, 20);
            this.nudCantCanciones.TabIndex = 2;
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(22, 173);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(65, 13);
            this.lblTipoEdicion.TabIndex = 10;
            this.lblTipoEdicion.Text = "Tipo edicion";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(22, 197);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "Genero";
            // 
            // cbEdicion
            // 
            this.cbEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdicion.FormattingEnabled = true;
            this.cbEdicion.Location = new System.Drawing.Point(160, 164);
            this.cbEdicion.Name = "cbEdicion";
            this.cbEdicion.Size = new System.Drawing.Size(121, 21);
            this.cbEdicion.TabIndex = 4;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(159, 194);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 5;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(160, 121);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(100, 20);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtUrlImagen.Leave += new System.EventHandler(this.boxUrl_Leave);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(22, 121);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(58, 13);
            this.lblUrl.TabIndex = 14;
            this.lblUrl.Text = "Url Imagen";
            this.lblUrl.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbDisco
            // 
            this.pbDisco.Location = new System.Drawing.Point(423, 38);
            this.pbDisco.Name = "pbDisco";
            this.pbDisco.Size = new System.Drawing.Size(305, 310);
            this.pbDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisco.TabIndex = 16;
            this.pbDisco.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(280, 117);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarImagen.TabIndex = 17;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 403);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pbDisco);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbEdicion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.nudCantCanciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpFechaLanz);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCantCanciones);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaLanz;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudCantCanciones;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cbEdicion;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.PictureBox pbDisco;
        private System.Windows.Forms.Button btnAgregarImagen;
    }
}