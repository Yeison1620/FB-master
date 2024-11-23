
namespace FB.Vistas
{
    partial class frmSolicitantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDejarTrabajar = new System.Windows.Forms.Button();
            this.timerChecker = new System.Windows.Forms.Timer(this.components);
            this.dtgSolicitantes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRecogida = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumSolicitud = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Red Hat Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Posibles clientes";
            // 
            // btnDejarTrabajar
            // 
            this.btnDejarTrabajar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDejarTrabajar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnDejarTrabajar.FlatAppearance.BorderSize = 0;
            this.btnDejarTrabajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDejarTrabajar.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDejarTrabajar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDejarTrabajar.Location = new System.Drawing.Point(883, 54);
            this.btnDejarTrabajar.Name = "btnDejarTrabajar";
            this.btnDejarTrabajar.Size = new System.Drawing.Size(142, 63);
            this.btnDejarTrabajar.TabIndex = 43;
            this.btnDejarTrabajar.Text = "Dejar de Trabajar";
            this.btnDejarTrabajar.UseVisualStyleBackColor = false;
            this.btnDejarTrabajar.Click += new System.EventHandler(this.btnDejarTrabajar_Click);
            // 
            // timerChecker
            // 
            this.timerChecker.Enabled = true;
            this.timerChecker.Interval = 4500;
            this.timerChecker.Tick += new System.EventHandler(this.timerChecker_Tick);
            // 
            // dtgSolicitantes
            // 
            this.dtgSolicitantes.AllowUserToAddRows = false;
            this.dtgSolicitantes.AllowUserToDeleteRows = false;
            this.dtgSolicitantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(79)))));
            this.dtgSolicitantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSolicitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSolicitantes.Location = new System.Drawing.Point(113, 134);
            this.dtgSolicitantes.Name = "dtgSolicitantes";
            this.dtgSolicitantes.ReadOnly = true;
            this.dtgSolicitantes.Size = new System.Drawing.Size(781, 261);
            this.dtgSolicitantes.TabIndex = 44;
            this.dtgSolicitantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConductoresActivos_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 45;
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnAtender.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnAtender.FlatAppearance.BorderSize = 0;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtender.Location = new System.Drawing.Point(729, 62);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(126, 47);
            this.btnAtender.TabIndex = 59;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Red Hat Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(746, 181);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 35);
            this.lblNombre.TabIndex = 63;
            // 
            // lblRecogida
            // 
            this.lblRecogida.AutoSize = true;
            this.lblRecogida.BackColor = System.Drawing.Color.Transparent;
            this.lblRecogida.Font = new System.Drawing.Font("Red Hat Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecogida.Location = new System.Drawing.Point(799, 229);
            this.lblRecogida.Name = "lblRecogida";
            this.lblRecogida.Size = new System.Drawing.Size(0, 35);
            this.lblRecogida.TabIndex = 64;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Red Hat Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(824, 316);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 35);
            this.lblPrecio.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 62);
            this.label3.TabIndex = 68;
            this.label3.Text = "Escoge el número de solicitud del que\r\nquieras atender";
            // 
            // txtNumSolicitud
            // 
            this.txtNumSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumSolicitud.Depth = 0;
            this.txtNumSolicitud.Enabled = false;
            this.txtNumSolicitud.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumSolicitud.LeadingIcon = null;
            this.txtNumSolicitud.Location = new System.Drawing.Point(541, 62);
            this.txtNumSolicitud.MaxLength = 50;
            this.txtNumSolicitud.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumSolicitud.Multiline = false;
            this.txtNumSolicitud.Name = "txtNumSolicitud";
            this.txtNumSolicitud.Size = new System.Drawing.Size(100, 50);
            this.txtNumSolicitud.TabIndex = 69;
            this.txtNumSolicitud.Text = "";
            this.txtNumSolicitud.TrailingIcon = null;
            // 
            // frmSolicitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 407);
            this.Controls.Add(this.txtNumSolicitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblRecogida);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgSolicitantes);
            this.Controls.Add(this.btnDejarTrabajar);
            this.Controls.Add(this.label1);
            this.Name = "frmSolicitantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSolicitantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSolicitantes_FormClosing);
            this.Load += new System.EventHandler(this.frmSolicitantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDejarTrabajar;
        private System.Windows.Forms.Timer timerChecker;
        private System.Windows.Forms.DataGridView dtgSolicitantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRecogida;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtNumSolicitud;
    }
}