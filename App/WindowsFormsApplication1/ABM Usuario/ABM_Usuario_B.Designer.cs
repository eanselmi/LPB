namespace visibilidad.ABM_Usuario
{
    partial class ABM_Usuario_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Usuario_B));
            this.comboBoxTipoU = new System.Windows.Forms.ComboBox();
            this.labelTipoU = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelTipoDoc = new System.Windows.Forms.Label();
            this.labelNumeroDoc = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombe = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonProceder = new System.Windows.Forms.Button();
            this.groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipoU
            // 
            this.comboBoxTipoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoU.FormattingEnabled = true;
            this.comboBoxTipoU.Items.AddRange(new object[] {
            "Cliente",
            "Empresa"});
            this.comboBoxTipoU.Location = new System.Drawing.Point(229, 12);
            this.comboBoxTipoU.Name = "comboBoxTipoU";
            this.comboBoxTipoU.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoU.TabIndex = 0;
            this.comboBoxTipoU.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoU_SelectedIndexChanged);
            // 
            // labelTipoU
            // 
            this.labelTipoU.AutoSize = true;
            this.labelTipoU.Location = new System.Drawing.Point(137, 15);
            this.labelTipoU.Name = "labelTipoU";
            this.labelTipoU.Size = new System.Drawing.Size(86, 13);
            this.labelTipoU.TabIndex = 1;
            this.labelTipoU.Text = "Tipo de usuario: ";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.comboBoxTipoDoc);
            this.groupBoxCliente.Controls.Add(this.textBoxDNI);
            this.groupBoxCliente.Controls.Add(this.labelTipoDoc);
            this.groupBoxCliente.Controls.Add(this.labelNumeroDoc);
            this.groupBoxCliente.Controls.Add(this.buttonLimpiar);
            this.groupBoxCliente.Controls.Add(this.buttonBuscar);
            this.groupBoxCliente.Controls.Add(this.textBoxEmail);
            this.groupBoxCliente.Controls.Add(this.textBoxApellido);
            this.groupBoxCliente.Controls.Add(this.textBoxNombe);
            this.groupBoxCliente.Controls.Add(this.labelEmail);
            this.groupBoxCliente.Controls.Add(this.labelDocumento);
            this.groupBoxCliente.Controls.Add(this.labelApellido);
            this.groupBoxCliente.Controls.Add(this.labelNombre);
            this.groupBoxCliente.Controls.Add(this.dataGridViewCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(0, 39);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(484, 383);
            this.groupBoxCliente.TabIndex = 2;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Buscar un cliente";
            this.groupBoxCliente.Visible = false;
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "CUIL"});
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(274, 66);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(51, 21);
            this.comboBoxTipoDoc.TabIndex = 12;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(377, 67);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(86, 20);
            this.textBoxDNI.TabIndex = 6;
            // 
            // labelTipoDoc
            // 
            this.labelTipoDoc.AutoSize = true;
            this.labelTipoDoc.Location = new System.Drawing.Point(240, 70);
            this.labelTipoDoc.Name = "labelTipoDoc";
            this.labelTipoDoc.Size = new System.Drawing.Size(34, 13);
            this.labelTipoDoc.TabIndex = 14;
            this.labelTipoDoc.Text = "Tipo: ";
            // 
            // labelNumeroDoc
            // 
            this.labelNumeroDoc.AutoSize = true;
            this.labelNumeroDoc.Location = new System.Drawing.Point(331, 70);
            this.labelNumeroDoc.Name = "labelNumeroDoc";
            this.labelNumeroDoc.Size = new System.Drawing.Size(50, 13);
            this.labelNumeroDoc.TabIndex = 13;
            this.labelNumeroDoc.Text = "Número: ";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(290, 100);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 12;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(109, 100);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(363, 29);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(84, 63);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 5;
            // 
            // textBoxNombe
            // 
            this.textBoxNombe.Location = new System.Drawing.Point(84, 29);
            this.textBoxNombe.Name = "textBoxNombe";
            this.textBoxNombe.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombe.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(318, 32);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email: ";
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(225, 50);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(62, 13);
            this.labelDocumento.TabIndex = 2;
            this.labelDocumento.Text = "Documento";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(28, 66);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(50, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido: ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(28, 32);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre: ";
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToOrderColumns = true;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(6, 129);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCliente.Size = new System.Drawing.Size(472, 250);
            this.dataGridViewCliente.TabIndex = 9;
            this.dataGridViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellContentClick);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(316, 428);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 11;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonProceder
            // 
            this.buttonProceder.Enabled = false;
            this.buttonProceder.Location = new System.Drawing.Point(98, 428);
            this.buttonProceder.Name = "buttonProceder";
            this.buttonProceder.Size = new System.Drawing.Size(75, 23);
            this.buttonProceder.TabIndex = 10;
            this.buttonProceder.Text = "Proceder";
            this.buttonProceder.UseVisualStyleBackColor = true;
            this.buttonProceder.Click += new System.EventHandler(this.buttonProceder_Click);
            // 
            // ABM_Usuario_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 461);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelTipoU);
            this.Controls.Add(this.buttonProceder);
            this.Controls.Add(this.comboBoxTipoU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ABM_Usuario_B";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de usuario";
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoU;
        private System.Windows.Forms.Label labelTipoU;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombe;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonProceder;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label labelTipoDoc;
        private System.Windows.Forms.Label labelNumeroDoc;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
    }
}