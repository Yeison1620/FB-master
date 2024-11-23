
namespace FB.Vistas
{
    partial class frmReporte
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
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDocumentoDenunciado = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnEnviarReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUbicacion.Font = new System.Drawing.Font("Red Hat Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(330, 9);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(163, 43);
            this.lblUbicacion.TabIndex = 14;
            this.lblUbicacion.Text = "Reportar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "Tu Número de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 31);
            this.label2.TabIndex = 52;
            this.label2.Text = "Número de Documento de usuario a reportar";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumento.LeadingIcon = null;
            this.txtDocumento.Location = new System.Drawing.Point(213, 106);
            this.txtDocumento.MaxLength = 50;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(407, 50);
            this.txtDocumento.TabIndex = 53;
            this.txtDocumento.Text = "";
            this.txtDocumento.TrailingIcon = null;
            // 
            // txtDocumentoDenunciado
            // 
            this.txtDocumentoDenunciado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentoDenunciado.Depth = 0;
            this.txtDocumentoDenunciado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumentoDenunciado.LeadingIcon = null;
            this.txtDocumentoDenunciado.Location = new System.Drawing.Point(213, 193);
            this.txtDocumentoDenunciado.MaxLength = 50;
            this.txtDocumentoDenunciado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumentoDenunciado.Multiline = false;
            this.txtDocumentoDenunciado.Name = "txtDocumentoDenunciado";
            this.txtDocumentoDenunciado.Size = new System.Drawing.Size(407, 50);
            this.txtDocumentoDenunciado.TabIndex = 54;
            this.txtDocumentoDenunciado.Text = "";
            this.txtDocumentoDenunciado.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 31);
            this.label3.TabIndex = 55;
            this.label3.Text = "Descripción de reporte\r\n";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescripcion.Location = new System.Drawing.Point(116, 294);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(600, 96);
            this.txtDescripcion.TabIndex = 56;
            this.txtDescripcion.Text = "";
            // 
            // btnEnviarReporte
            // 
            this.btnEnviarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnEnviarReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnEnviarReporte.FlatAppearance.BorderSize = 0;
            this.btnEnviarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarReporte.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviarReporte.Location = new System.Drawing.Point(289, 405);
            this.btnEnviarReporte.Name = "btnEnviarReporte";
            this.btnEnviarReporte.Size = new System.Drawing.Size(222, 75);
            this.btnEnviarReporte.TabIndex = 57;
            this.btnEnviarReporte.Text = "Enviar Reporte";
            this.btnEnviarReporte.UseVisualStyleBackColor = false;
            this.btnEnviarReporte.Click += new System.EventHandler(this.btnEnviarReporte_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnEnviarReporte);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocumentoDenunciado);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUbicacion);
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtDocumento;
        private MaterialSkin.Controls.MaterialTextBox txtDocumentoDenunciado;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtDescripcion;
        private System.Windows.Forms.Button btnEnviarReporte;
    }
}