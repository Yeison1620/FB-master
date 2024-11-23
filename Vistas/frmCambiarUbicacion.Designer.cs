
namespace FB.Vistas
{
    partial class frmCambiarUbicacion
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
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCambiarUbicacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecogida = new MaterialSkin.Controls.MaterialTextBox();
            this.lblRecogida = new System.Windows.Forms.Label();
            this.txtDestino = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbPais = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbCiudad = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(161, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 31);
            this.lblTitulo.TabIndex = 11;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUbicacion.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(7, 115);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(154, 31);
            this.lblUbicacion.TabIndex = 12;
            this.lblUbicacion.Text = "UBICACION";
            this.lblUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(661, 342);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(187, 114);
            this.btnConfirmar.TabIndex = 47;
            this.btnConfirmar.Text = "Pedir Transporte";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCambiarUbicacion
            // 
            this.btnCambiarUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnCambiarUbicacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnCambiarUbicacion.FlatAppearance.BorderSize = 0;
            this.btnCambiarUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarUbicacion.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUbicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarUbicacion.Location = new System.Drawing.Point(661, 224);
            this.btnCambiarUbicacion.Name = "btnCambiarUbicacion";
            this.btnCambiarUbicacion.Size = new System.Drawing.Size(187, 112);
            this.btnCambiarUbicacion.TabIndex = 48;
            this.btnCambiarUbicacion.Text = "Cambiar ubicación";
            this.btnCambiarUbicacion.UseVisualStyleBackColor = false;
            this.btnCambiarUbicacion.Click += new System.EventHandler(this.btnCambiarUbicacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Red Hat Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 27);
            this.label3.TabIndex = 52;
            this.label3.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Red Hat Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 27);
            this.label4.TabIndex = 53;
            this.label4.Text = "Estado/Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Red Hat Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 27);
            this.label5.TabIndex = 54;
            this.label5.Text = "Ciudad";
            // 
            // txtRecogida
            // 
            this.txtRecogida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecogida.Depth = 0;
            this.txtRecogida.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRecogida.LeadingIcon = null;
            this.txtRecogida.Location = new System.Drawing.Point(297, 308);
            this.txtRecogida.MaxLength = 50;
            this.txtRecogida.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRecogida.Multiline = false;
            this.txtRecogida.Name = "txtRecogida";
            this.txtRecogida.Size = new System.Drawing.Size(251, 50);
            this.txtRecogida.TabIndex = 55;
            this.txtRecogida.Text = "";
            this.txtRecogida.TrailingIcon = null;
            // 
            // lblRecogida
            // 
            this.lblRecogida.AutoSize = true;
            this.lblRecogida.BackColor = System.Drawing.Color.Transparent;
            this.lblRecogida.Font = new System.Drawing.Font("Red Hat Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecogida.Location = new System.Drawing.Point(32, 314);
            this.lblRecogida.Name = "lblRecogida";
            this.lblRecogida.Size = new System.Drawing.Size(225, 27);
            this.lblRecogida.TabIndex = 57;
            this.lblRecogida.Text = "Dirección de recogida";
            // 
            // txtDestino
            // 
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestino.Depth = 0;
            this.txtDestino.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDestino.LeadingIcon = null;
            this.txtDestino.Location = new System.Drawing.Point(297, 364);
            this.txtDestino.MaxLength = 50;
            this.txtDestino.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDestino.Multiline = false;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(251, 50);
            this.txtDestino.TabIndex = 58;
            this.txtDestino.Text = "";
            this.txtDestino.TrailingIcon = null;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.Font = new System.Drawing.Font("Red Hat Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(32, 364);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(212, 27);
            this.lblDestino.TabIndex = 59;
            this.lblDestino.Text = "Dirección de destino";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(18, 403);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 65);
            this.btnVolver.TabIndex = 60;
            this.btnVolver.Text = "Volver al menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbPais
            // 
            this.cmbPais.AutoResize = false;
            this.cmbPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPais.Depth = 0;
            this.cmbPais.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPais.DropDownHeight = 174;
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.DropDownWidth = 121;
            this.cmbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.IntegralHeight = false;
            this.cmbPais.ItemHeight = 43;
            this.cmbPais.Location = new System.Drawing.Point(18, 238);
            this.cmbPais.MaxDropDownItems = 4;
            this.cmbPais.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(167, 49);
            this.cmbPais.StartIndex = 0;
            this.cmbPais.TabIndex = 63;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            this.cmbPais.SelectedValueChanged += new System.EventHandler(this.cmbPais_SelectedValueChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoResize = false;
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstado.Depth = 0;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownHeight = 174;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.DropDownWidth = 121;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 43;
            this.cmbEstado.Location = new System.Drawing.Point(210, 237);
            this.cmbEstado.MaxDropDownItems = 4;
            this.cmbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(205, 49);
            this.cmbEstado.StartIndex = 0;
            this.cmbEstado.TabIndex = 64;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.AutoResize = false;
            this.cmbCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCiudad.Depth = 0;
            this.cmbCiudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCiudad.DropDownHeight = 174;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.DropDownWidth = 121;
            this.cmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.IntegralHeight = false;
            this.cmbCiudad.ItemHeight = 43;
            this.cmbCiudad.Location = new System.Drawing.Point(435, 238);
            this.cmbCiudad.MaxDropDownItems = 4;
            this.cmbCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(205, 49);
            this.cmbCiudad.StartIndex = 0;
            this.cmbCiudad.TabIndex = 65;
            // 
            // frmCambiarUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 468);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblRecogida);
            this.Controls.Add(this.txtRecogida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCambiarUbicacion);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCambiarUbicacion";
            this.Text = "frmCambiarUbicacion";
            this.Load += new System.EventHandler(this.frmCambiarUbicacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCambiarUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtRecogida;
        private System.Windows.Forms.Label lblRecogida;
        private MaterialSkin.Controls.MaterialTextBox txtDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnVolver;
        private MaterialSkin.Controls.MaterialComboBox cmbPais;
        private MaterialSkin.Controls.MaterialComboBox cmbEstado;
        private MaterialSkin.Controls.MaterialComboBox cmbCiudad;
    }
}