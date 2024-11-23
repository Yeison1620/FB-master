
namespace FB.Vistas
{
    partial class frmMetodoPago
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtTarjeta = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoSeguridad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMesVencimiento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodigoPostal = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoTarjeta = new MaterialSkin.Controls.MaterialComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnoVencimiento = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbConcepto = new MaterialSkin.Controls.MaterialComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUbicacion.Font = new System.Drawing.Font("Red Hat Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(213, 9);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(309, 39);
            this.lblUbicacion.TabIndex = 13;
            this.lblUbicacion.Text = "METODOS DE PAGO";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(534, 350);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(152, 54);
            this.btnConfirmar.TabIndex = 48;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarjeta.Depth = 0;
            this.txtTarjeta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTarjeta.LeadingIcon = null;
            this.txtTarjeta.Location = new System.Drawing.Point(12, 106);
            this.txtTarjeta.MaxLength = 20;
            this.txtTarjeta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTarjeta.Multiline = false;
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(407, 50);
            this.txtTarjeta.TabIndex = 49;
            this.txtTarjeta.Text = "";
            this.txtTarjeta.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "Numero Tarjeta (Con guiones)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 31);
            this.label3.TabIndex = 53;
            this.label3.Text = "Codigo Seguridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 31);
            this.label4.TabIndex = 54;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // txtCodigoSeguridad
            // 
            this.txtCodigoSeguridad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoSeguridad.Depth = 0;
            this.txtCodigoSeguridad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoSeguridad.LeadingIcon = null;
            this.txtCodigoSeguridad.Location = new System.Drawing.Point(476, 106);
            this.txtCodigoSeguridad.MaxLength = 3;
            this.txtCodigoSeguridad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoSeguridad.Multiline = false;
            this.txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            this.txtCodigoSeguridad.Size = new System.Drawing.Size(171, 50);
            this.txtCodigoSeguridad.TabIndex = 55;
            this.txtCodigoSeguridad.Text = "";
            this.txtCodigoSeguridad.TrailingIcon = null;
            // 
            // txtMesVencimiento
            // 
            this.txtMesVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMesVencimiento.Depth = 0;
            this.txtMesVencimiento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMesVencimiento.LeadingIcon = null;
            this.txtMesVencimiento.Location = new System.Drawing.Point(23, 325);
            this.txtMesVencimiento.MaxLength = 2;
            this.txtMesVencimiento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMesVencimiento.Multiline = false;
            this.txtMesVencimiento.Name = "txtMesVencimiento";
            this.txtMesVencimiento.Size = new System.Drawing.Size(83, 50);
            this.txtMesVencimiento.TabIndex = 56;
            this.txtMesVencimiento.Text = "";
            this.txtMesVencimiento.TrailingIcon = null;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoPostal.Depth = 0;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoPostal.LeadingIcon = null;
            this.txtCodigoPostal.Location = new System.Drawing.Point(513, 222);
            this.txtCodigoPostal.MaxLength = 50;
            this.txtCodigoPostal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoPostal.Multiline = false;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(145, 50);
            this.txtCodigoPostal.TabIndex = 57;
            this.txtCodigoPostal.Text = "";
            this.txtCodigoPostal.TrailingIcon = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 31);
            this.label5.TabIndex = 58;
            this.label5.Text = "Codigo Postal";
            // 
            // cmbTipoTarjeta
            // 
            this.cmbTipoTarjeta.AutoResize = false;
            this.cmbTipoTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTipoTarjeta.Depth = 0;
            this.cmbTipoTarjeta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipoTarjeta.DropDownHeight = 174;
            this.cmbTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTarjeta.DropDownWidth = 121;
            this.cmbTipoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipoTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTipoTarjeta.FormattingEnabled = true;
            this.cmbTipoTarjeta.IntegralHeight = false;
            this.cmbTipoTarjeta.ItemHeight = 43;
            this.cmbTipoTarjeta.Location = new System.Drawing.Point(30, 224);
            this.cmbTipoTarjeta.MaxDropDownItems = 4;
            this.cmbTipoTarjeta.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoTarjeta.Name = "cmbTipoTarjeta";
            this.cmbTipoTarjeta.Size = new System.Drawing.Size(192, 49);
            this.cmbTipoTarjeta.StartIndex = 0;
            this.cmbTipoTarjeta.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 31);
            this.label6.TabIndex = 60;
            this.label6.Text = "Tipo de Tarjeta";
            // 
            // txtAnoVencimiento
            // 
            this.txtAnoVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnoVencimiento.Depth = 0;
            this.txtAnoVencimiento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAnoVencimiento.LeadingIcon = null;
            this.txtAnoVencimiento.Location = new System.Drawing.Point(159, 325);
            this.txtAnoVencimiento.MaxLength = 2;
            this.txtAnoVencimiento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAnoVencimiento.Multiline = false;
            this.txtAnoVencimiento.Name = "txtAnoVencimiento";
            this.txtAnoVencimiento.Size = new System.Drawing.Size(83, 50);
            this.txtAnoVencimiento.TabIndex = 61;
            this.txtAnoVencimiento.Text = "";
            this.txtAnoVencimiento.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Red Hat Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(112, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 64);
            this.label2.TabIndex = 62;
            this.label2.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(33, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 31);
            this.label7.TabIndex = 63;
            this.label7.Text = "MM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(171, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 31);
            this.label8.TabIndex = 64;
            this.label8.Text = "YY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(33, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 31);
            this.label9.TabIndex = 65;
            this.label9.Text = "Algo así: 0123-4567-25...";
            // 
            // cmbConcepto
            // 
            this.cmbConcepto.AutoResize = false;
            this.cmbConcepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbConcepto.Depth = 0;
            this.cmbConcepto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbConcepto.DropDownHeight = 174;
            this.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConcepto.DropDownWidth = 121;
            this.cmbConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbConcepto.FormattingEnabled = true;
            this.cmbConcepto.IntegralHeight = false;
            this.cmbConcepto.ItemHeight = 43;
            this.cmbConcepto.Location = new System.Drawing.Point(267, 220);
            this.cmbConcepto.MaxDropDownItems = 4;
            this.cmbConcepto.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbConcepto.Name = "cmbConcepto";
            this.cmbConcepto.Size = new System.Drawing.Size(192, 49);
            this.cmbConcepto.StartIndex = 0;
            this.cmbConcepto.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Red Hat Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 31);
            this.label10.TabIndex = 67;
            this.label10.Text = "Concepto";
            // 
            // frmMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 412);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbConcepto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAnoVencimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMesVencimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoTarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtCodigoSeguridad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblUbicacion);
            this.Name = "frmMetodoPago";
            this.Text = "cmbConcepto";
            this.Load += new System.EventHandler(this.frmMetodoPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Button btnConfirmar;
        private MaterialSkin.Controls.MaterialTextBox txtTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoSeguridad;
        private MaterialSkin.Controls.MaterialTextBox txtMesVencimiento;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoPostal;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoTarjeta;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtAnoVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialComboBox cmbConcepto;
        private System.Windows.Forms.Label label10;
    }
}