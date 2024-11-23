
namespace FB.Vistas
{
    partial class frmViajes
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
            this.components = new System.ComponentModel.Container();
            this.btnReportar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTituloRecogida = new System.Windows.Forms.Label();
            this.lblTituloDestino = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecogida = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReportarRecogida = new System.Windows.Forms.Button();
            this.btnTerminarViaje = new System.Windows.Forms.Button();
            this.lblEstadoViaje = new System.Windows.Forms.Label();
            this.timerChecker = new System.Windows.Forms.Timer(this.components);
            this.cmbMetodosPago = new System.Windows.Forms.ComboBox();
            this.btnPagarViaje = new System.Windows.Forms.Button();
            this.rdoMetodoPago = new System.Windows.Forms.RadioButton();
            this.rdoEfectivo = new System.Windows.Forms.RadioButton();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.grpCalificacion = new System.Windows.Forms.GroupBox();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.grpPago.SuspendLayout();
            this.grpCalificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportar
            // 
            this.btnReportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnReportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnReportar.FlatAppearance.BorderSize = 0;
            this.btnReportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportar.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportar.Location = new System.Drawing.Point(684, 360);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(152, 96);
            this.btnReportar.TabIndex = 43;
            this.btnReportar.Text = "Reportar Algún Problema";
            this.btnReportar.UseVisualStyleBackColor = false;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Red Hat Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 35);
            this.label5.TabIndex = 44;
            this.label5.Text = "Viaje";
            // 
            // lblTituloRecogida
            // 
            this.lblTituloRecogida.AutoSize = true;
            this.lblTituloRecogida.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloRecogida.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRecogida.Location = new System.Drawing.Point(12, 56);
            this.lblTituloRecogida.Name = "lblTituloRecogida";
            this.lblTituloRecogida.Size = new System.Drawing.Size(296, 27);
            this.lblTituloRecogida.TabIndex = 45;
            this.lblTituloRecogida.Text = "Ve a recoger a tu cliente en:";
            // 
            // lblTituloDestino
            // 
            this.lblTituloDestino.AutoSize = true;
            this.lblTituloDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloDestino.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDestino.Location = new System.Drawing.Point(12, 83);
            this.lblTituloDestino.Name = "lblTituloDestino";
            this.lblTituloDestino.Size = new System.Drawing.Size(124, 27);
            this.lblTituloDestino.TabIndex = 46;
            this.lblTituloDestino.Text = "Quiere ir a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 47;
            this.label2.Text = "Precio:";
            // 
            // lblRecogida
            // 
            this.lblRecogida.AutoSize = true;
            this.lblRecogida.BackColor = System.Drawing.Color.Transparent;
            this.lblRecogida.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecogida.Location = new System.Drawing.Point(314, 56);
            this.lblRecogida.Name = "lblRecogida";
            this.lblRecogida.Size = new System.Drawing.Size(17, 27);
            this.lblRecogida.TabIndex = 48;
            this.lblRecogida.Text = ".";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(314, 83);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(17, 27);
            this.lblDestino.TabIndex = 49;
            this.lblDestino.Text = ".";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(314, 110);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(17, 27);
            this.lblPrecio.TabIndex = 50;
            this.lblPrecio.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 27);
            this.label3.TabIndex = 51;
            this.label3.Text = "$";
            // 
            // btnReportarRecogida
            // 
            this.btnReportarRecogida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnReportarRecogida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnReportarRecogida.FlatAppearance.BorderSize = 0;
            this.btnReportarRecogida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportarRecogida.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportarRecogida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportarRecogida.Location = new System.Drawing.Point(212, 383);
            this.btnReportarRecogida.Name = "btnReportarRecogida";
            this.btnReportarRecogida.Size = new System.Drawing.Size(174, 89);
            this.btnReportarRecogida.TabIndex = 52;
            this.btnReportarRecogida.Text = "Ya recogí al cliente.";
            this.btnReportarRecogida.UseVisualStyleBackColor = false;
            this.btnReportarRecogida.Click += new System.EventHandler(this.btnReportarRecogida_Click);
            // 
            // btnTerminarViaje
            // 
            this.btnTerminarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnTerminarViaje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnTerminarViaje.FlatAppearance.BorderSize = 0;
            this.btnTerminarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminarViaje.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarViaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTerminarViaje.Location = new System.Drawing.Point(392, 383);
            this.btnTerminarViaje.Name = "btnTerminarViaje";
            this.btnTerminarViaje.Size = new System.Drawing.Size(165, 89);
            this.btnTerminarViaje.TabIndex = 53;
            this.btnTerminarViaje.Text = "Ya llegué al destino.";
            this.btnTerminarViaje.UseVisualStyleBackColor = false;
            this.btnTerminarViaje.Click += new System.EventHandler(this.btnTerminarViaje_Click);
            // 
            // lblEstadoViaje
            // 
            this.lblEstadoViaje.AutoSize = true;
            this.lblEstadoViaje.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoViaje.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoViaje.Location = new System.Drawing.Point(141, 166);
            this.lblEstadoViaje.Name = "lblEstadoViaje";
            this.lblEstadoViaje.Size = new System.Drawing.Size(18, 27);
            this.lblEstadoViaje.TabIndex = 54;
            this.lblEstadoViaje.Text = ".";
            this.lblEstadoViaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerChecker
            // 
            this.timerChecker.Enabled = true;
            this.timerChecker.Interval = 2500;
            this.timerChecker.Tick += new System.EventHandler(this.timerChecker_Tick);
            // 
            // cmbMetodosPago
            // 
            this.cmbMetodosPago.FormattingEnabled = true;
            this.cmbMetodosPago.Location = new System.Drawing.Point(212, 294);
            this.cmbMetodosPago.Name = "cmbMetodosPago";
            this.cmbMetodosPago.Size = new System.Drawing.Size(345, 21);
            this.cmbMetodosPago.TabIndex = 55;
            // 
            // btnPagarViaje
            // 
            this.btnPagarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnPagarViaje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnPagarViaje.FlatAppearance.BorderSize = 0;
            this.btnPagarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarViaje.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarViaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPagarViaje.Location = new System.Drawing.Point(319, 321);
            this.btnPagarViaje.Name = "btnPagarViaje";
            this.btnPagarViaje.Size = new System.Drawing.Size(142, 56);
            this.btnPagarViaje.TabIndex = 56;
            this.btnPagarViaje.Text = "Pagar";
            this.btnPagarViaje.UseVisualStyleBackColor = false;
            this.btnPagarViaje.Click += new System.EventHandler(this.btnPagarViaje_Click);
            // 
            // rdoMetodoPago
            // 
            this.rdoMetodoPago.AutoSize = true;
            this.rdoMetodoPago.Location = new System.Drawing.Point(6, 14);
            this.rdoMetodoPago.Name = "rdoMetodoPago";
            this.rdoMetodoPago.Size = new System.Drawing.Size(104, 17);
            this.rdoMetodoPago.TabIndex = 57;
            this.rdoMetodoPago.TabStop = true;
            this.rdoMetodoPago.Text = "Método de Pago";
            this.rdoMetodoPago.UseVisualStyleBackColor = true;
            this.rdoMetodoPago.CheckedChanged += new System.EventHandler(this.rdoMetodoPago_CheckedChanged);
            // 
            // rdoEfectivo
            // 
            this.rdoEfectivo.AutoSize = true;
            this.rdoEfectivo.Location = new System.Drawing.Point(128, 14);
            this.rdoEfectivo.Name = "rdoEfectivo";
            this.rdoEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdoEfectivo.TabIndex = 58;
            this.rdoEfectivo.TabStop = true;
            this.rdoEfectivo.Text = "Efectivo";
            this.rdoEfectivo.UseVisualStyleBackColor = true;
            this.rdoEfectivo.CheckedChanged += new System.EventHandler(this.rdoEfectivo_CheckedChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(511, 56);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(92, 27);
            this.lblCliente.TabIndex = 59;
            this.lblCliente.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 27);
            this.label4.TabIndex = 60;
            this.label4.Text = "Calificación promedio:";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblCalificacion.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(761, 120);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(17, 27);
            this.lblCalificacion.TabIndex = 61;
            this.lblCalificacion.Text = ".";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(642, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(17, 27);
            this.lblNombre.TabIndex = 62;
            this.lblNombre.Text = ".";
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.rdoMetodoPago);
            this.grpPago.Controls.Add(this.rdoEfectivo);
            this.grpPago.Location = new System.Drawing.Point(306, 246);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(198, 37);
            this.grpPago.TabIndex = 63;
            this.grpPago.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 27);
            this.label6.TabIndex = 64;
            this.label6.Text = "Celular:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(630, 83);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(17, 27);
            this.lblCelular.TabIndex = 65;
            this.lblCelular.Text = ".";
            // 
            // grpCalificacion
            // 
            this.grpCalificacion.Controls.Add(this.rdo5);
            this.grpCalificacion.Controls.Add(this.rdo4);
            this.grpCalificacion.Controls.Add(this.rdo3);
            this.grpCalificacion.Controls.Add(this.rdo2);
            this.grpCalificacion.Controls.Add(this.rdo1);
            this.grpCalificacion.Location = new System.Drawing.Point(597, 275);
            this.grpCalificacion.Name = "grpCalificacion";
            this.grpCalificacion.Size = new System.Drawing.Size(200, 40);
            this.grpCalificacion.TabIndex = 66;
            this.grpCalificacion.TabStop = false;
            this.grpCalificacion.Text = "Calificar Conductor";
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(154, 19);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(31, 17);
            this.rdo5.TabIndex = 5;
            this.rdo5.TabStop = true;
            this.rdo5.Text = "5";
            this.rdo5.UseVisualStyleBackColor = true;
            // 
            // rdo4
            // 
            this.rdo4.AutoSize = true;
            this.rdo4.Location = new System.Drawing.Point(117, 19);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(31, 17);
            this.rdo4.TabIndex = 4;
            this.rdo4.TabStop = true;
            this.rdo4.Text = "4";
            this.rdo4.UseVisualStyleBackColor = true;
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Location = new System.Drawing.Point(80, 19);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(31, 17);
            this.rdo3.TabIndex = 3;
            this.rdo3.TabStop = true;
            this.rdo3.Text = "3";
            this.rdo3.UseVisualStyleBackColor = true;
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(43, 19);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(31, 17);
            this.rdo2.TabIndex = 2;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "2";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(6, 19);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(31, 17);
            this.rdo1.TabIndex = 0;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "1";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 67;
            this.label1.Text = "Documento :";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumento.Font = new System.Drawing.Font("Red Hat Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(665, 29);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(17, 27);
            this.lblDocumento.TabIndex = 68;
            this.lblDocumento.Text = ".";
            // 
            // frmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 478);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCalificacion);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpPago);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnPagarViaje);
            this.Controls.Add(this.cmbMetodosPago);
            this.Controls.Add(this.lblEstadoViaje);
            this.Controls.Add(this.btnTerminarViaje);
            this.Controls.Add(this.btnReportarRecogida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblRecogida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTituloDestino);
            this.Controls.Add(this.lblTituloRecogida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReportar);
            this.Name = "frmViajes";
            this.Text = "frmViajes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmViajes_FormClosed);
            this.Load += new System.EventHandler(this.frmViajes_Load);
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.grpCalificacion.ResumeLayout(false);
            this.grpCalificacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTituloRecogida;
        private System.Windows.Forms.Label lblTituloDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecogida;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReportarRecogida;
        private System.Windows.Forms.Button btnTerminarViaje;
        private System.Windows.Forms.Label lblEstadoViaje;
        private System.Windows.Forms.Timer timerChecker;
        private System.Windows.Forms.ComboBox cmbMetodosPago;
        private System.Windows.Forms.Button btnPagarViaje;
        private System.Windows.Forms.RadioButton rdoMetodoPago;
        private System.Windows.Forms.RadioButton rdoEfectivo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.GroupBox grpCalificacion;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDocumento;
    }
}