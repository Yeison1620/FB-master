
namespace FB
{
    partial class frmConductoresDisponibles
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPropuestaPrecio = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarConductores = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgConductores = new System.Windows.Forms.DataGridView();
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConductores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Red Hat Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Conductores disponibles";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(524, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(305, 49);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.Text = "Aceptar Conductor";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPropuestaPrecio
            // 
            this.txtPropuestaPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPropuestaPrecio.Depth = 0;
            this.txtPropuestaPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPropuestaPrecio.Hint = "Precio";
            this.txtPropuestaPrecio.LeadingIcon = null;
            this.txtPropuestaPrecio.Location = new System.Drawing.Point(360, 69);
            this.txtPropuestaPrecio.MaxLength = 50;
            this.txtPropuestaPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPropuestaPrecio.Multiline = false;
            this.txtPropuestaPrecio.Name = "txtPropuestaPrecio";
            this.txtPropuestaPrecio.Size = new System.Drawing.Size(173, 50);
            this.txtPropuestaPrecio.TabIndex = 44;
            this.txtPropuestaPrecio.Text = "";
            this.txtPropuestaPrecio.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 31);
            this.label3.TabIndex = 45;
            this.label3.Text = "Propuesta de precio:";
            // 
            // btnBuscarConductores
            // 
            this.btnBuscarConductores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(234)))), ((int)(((byte)(78)))));
            this.btnBuscarConductores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnBuscarConductores.FlatAppearance.BorderSize = 0;
            this.btnBuscarConductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarConductores.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarConductores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarConductores.Location = new System.Drawing.Point(198, 143);
            this.btnBuscarConductores.Name = "btnBuscarConductores";
            this.btnBuscarConductores.Size = new System.Drawing.Size(240, 41);
            this.btnBuscarConductores.TabIndex = 46;
            this.btnBuscarConductores.Text = "Buscar Conductores";
            this.btnBuscarConductores.UseVisualStyleBackColor = false;
            this.btnBuscarConductores.Click += new System.EventHandler(this.btnBuscarConductores_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "$";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(243)))), ((int)(((byte)(70)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Red Hat Display Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(458, 143);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(240, 41);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar Petición";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Red Hat Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 31);
            this.label2.TabIndex = 50;
            this.label2.Text = "Escoge en la tabla el conductor:";
            // 
            // dtgConductores
            // 
            this.dtgConductores.AllowUserToAddRows = false;
            this.dtgConductores.AllowUserToDeleteRows = false;
            this.dtgConductores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(79)))));
            this.dtgConductores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConductores.Location = new System.Drawing.Point(12, 263);
            this.dtgConductores.Name = "dtgConductores";
            this.dtgConductores.ReadOnly = true;
            this.dtgConductores.Size = new System.Drawing.Size(859, 248);
            this.dtgConductores.TabIndex = 51;
            this.dtgConductores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConductores_CellClick);
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Depth = 0;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(410, 207);
            this.txtId.MaxLength = 50;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 50);
            this.txtId.TabIndex = 52;
            this.txtId.Text = "";
            this.txtId.TrailingIcon = null;
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Interval = 4500;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // frmConductoresDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 491);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtgConductores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarConductores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPropuestaPrecio);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Name = "frmConductoresDisponibles";
            this.Text = "txtPropuestaPrecio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConductoresDisponibles_FormClosing);
            this.Load += new System.EventHandler(this.frmConductoresDisponibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConductores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private MaterialSkin.Controls.MaterialTextBox txtPropuestaPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarConductores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgConductores;
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private System.Windows.Forms.Timer timerCheck;
    }
}