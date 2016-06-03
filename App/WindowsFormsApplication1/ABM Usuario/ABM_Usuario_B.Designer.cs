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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombe = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxEmpresa = new System.Windows.Forms.GroupBox();
            this.textBoxCUITVerif = new System.Windows.Forms.TextBox();
            this.textBoxCUITNro = new System.Windows.Forms.TextBox();
            this.textBoxEmailEmp = new System.Windows.Forms.TextBox();
            this.textBoxCUITTipo = new System.Windows.Forms.TextBox();
            this.textBoxRazonSoc = new System.Windows.Forms.TextBox();
            this.labelEmailEmpresa = new System.Windows.Forms.Label();
            this.labelCUIT = new System.Windows.Forms.Label();
            this.labelRazonSoc = new System.Windows.Forms.Label();
            this.labelGuion1 = new System.Windows.Forms.Label();
            this.labelGuion2 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonProceder = new System.Windows.Forms.Button();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxEmpresa.SuspendLayout();
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
            this.groupBoxCliente.Controls.Add(this.textBoxEmail);
            this.groupBoxCliente.Controls.Add(this.textBoxApellido);
            this.groupBoxCliente.Controls.Add(this.textBoxNombe);
            this.groupBoxCliente.Controls.Add(this.labelEmail);
            this.groupBoxCliente.Controls.Add(this.labelDocumento);
            this.groupBoxCliente.Controls.Add(this.labelApellido);
            this.groupBoxCliente.Controls.Add(this.labelNombre);
            this.groupBoxCliente.Location = new System.Drawing.Point(0, 39);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(484, 99);
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
            // groupBoxEmpresa
            // 
            this.groupBoxEmpresa.Controls.Add(this.textBoxCUITVerif);
            this.groupBoxEmpresa.Controls.Add(this.textBoxCUITNro);
            this.groupBoxEmpresa.Controls.Add(this.textBoxEmailEmp);
            this.groupBoxEmpresa.Controls.Add(this.textBoxCUITTipo);
            this.groupBoxEmpresa.Controls.Add(this.textBoxRazonSoc);
            this.groupBoxEmpresa.Controls.Add(this.labelEmailEmpresa);
            this.groupBoxEmpresa.Controls.Add(this.labelCUIT);
            this.groupBoxEmpresa.Controls.Add(this.labelRazonSoc);
            this.groupBoxEmpresa.Controls.Add(this.labelGuion1);
            this.groupBoxEmpresa.Controls.Add(this.labelGuion2);
            this.groupBoxEmpresa.Location = new System.Drawing.Point(0, 39);
            this.groupBoxEmpresa.Name = "groupBoxEmpresa";
            this.groupBoxEmpresa.Size = new System.Drawing.Size(484, 99);
            this.groupBoxEmpresa.TabIndex = 2;
            this.groupBoxEmpresa.TabStop = false;
            this.groupBoxEmpresa.Text = "Buscar una empresa";
            this.groupBoxEmpresa.Visible = false;
            // 
            // textBoxCUITVerif
            // 
            this.textBoxCUITVerif.Location = new System.Drawing.Point(211, 63);
            this.textBoxCUITVerif.MaxLength = 1;
            this.textBoxCUITVerif.Name = "textBoxCUITVerif";
            this.textBoxCUITVerif.Size = new System.Drawing.Size(11, 20);
            this.textBoxCUITVerif.TabIndex = 8;
            // 
            // textBoxCUITNro
            // 
            this.textBoxCUITNro.Location = new System.Drawing.Point(137, 63);
            this.textBoxCUITNro.MaxLength = 8;
            this.textBoxCUITNro.Name = "textBoxCUITNro";
            this.textBoxCUITNro.Size = new System.Drawing.Size(68, 20);
            this.textBoxCUITNro.TabIndex = 7;
            // 
            // textBoxEmailEmp
            // 
            this.textBoxEmailEmp.Location = new System.Drawing.Point(314, 47);
            this.textBoxEmailEmp.Name = "textBoxEmailEmp";
            this.textBoxEmailEmp.Size = new System.Drawing.Size(112, 20);
            this.textBoxEmailEmp.TabIndex = 6;
            // 
            // textBoxCUITTipo
            // 
            this.textBoxCUITTipo.Location = new System.Drawing.Point(110, 63);
            this.textBoxCUITTipo.MaxLength = 2;
            this.textBoxCUITTipo.Name = "textBoxCUITTipo";
            this.textBoxCUITTipo.Size = new System.Drawing.Size(21, 20);
            this.textBoxCUITTipo.TabIndex = 5;
            // 
            // textBoxRazonSoc
            // 
            this.textBoxRazonSoc.Location = new System.Drawing.Point(110, 29);
            this.textBoxRazonSoc.Name = "textBoxRazonSoc";
            this.textBoxRazonSoc.Size = new System.Drawing.Size(112, 20);
            this.textBoxRazonSoc.TabIndex = 4;
            // 
            // labelEmailEmpresa
            // 
            this.labelEmailEmpresa.AutoSize = true;
            this.labelEmailEmpresa.Location = new System.Drawing.Point(270, 50);
            this.labelEmailEmpresa.Name = "labelEmailEmpresa";
            this.labelEmailEmpresa.Size = new System.Drawing.Size(38, 13);
            this.labelEmailEmpresa.TabIndex = 3;
            this.labelEmailEmpresa.Text = "Email: ";
            // 
            // labelCUIT
            // 
            this.labelCUIT.AutoSize = true;
            this.labelCUIT.Location = new System.Drawing.Point(28, 66);
            this.labelCUIT.Name = "labelCUIT";
            this.labelCUIT.Size = new System.Drawing.Size(38, 13);
            this.labelCUIT.TabIndex = 1;
            this.labelCUIT.Text = "CUIT: ";
            // 
            // labelRazonSoc
            // 
            this.labelRazonSoc.AutoSize = true;
            this.labelRazonSoc.Location = new System.Drawing.Point(28, 32);
            this.labelRazonSoc.Name = "labelRazonSoc";
            this.labelRazonSoc.Size = new System.Drawing.Size(76, 13);
            this.labelRazonSoc.TabIndex = 0;
            this.labelRazonSoc.Text = "Razon Social: ";
            // 
            // labelGuion1
            // 
            this.labelGuion1.AutoSize = true;
            this.labelGuion1.Location = new System.Drawing.Point(129, 66);
            this.labelGuion1.Name = "labelGuion1";
            this.labelGuion1.Size = new System.Drawing.Size(10, 13);
            this.labelGuion1.TabIndex = 13;
            this.labelGuion1.Text = "-";
            // 
            // labelGuion2
            // 
            this.labelGuion2.AutoSize = true;
            this.labelGuion2.Location = new System.Drawing.Point(203, 66);
            this.labelGuion2.Name = "labelGuion2";
            this.labelGuion2.Size = new System.Drawing.Size(10, 13);
            this.labelGuion2.TabIndex = 14;
            this.labelGuion2.Text = "-";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(294, 144);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 12;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Enabled = false;
            this.buttonBuscar.Location = new System.Drawing.Point(109, 144);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToOrderColumns = true;
            this.dataGridViewCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(1, 172);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCliente.Size = new System.Drawing.Size(483, 250);
            this.dataGridViewCliente.TabIndex = 9;
            this.dataGridViewCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellClick);
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
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelTipoU);
            this.Controls.Add(this.buttonProceder);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.comboBoxTipoU);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.groupBoxEmpresa);
            this.Controls.Add(this.dataGridViewCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ABM_Usuario_B";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de usuario";
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxEmpresa.ResumeLayout(false);
            this.groupBoxEmpresa.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxEmpresa;
        private System.Windows.Forms.Label labelEmailEmpresa;
        private System.Windows.Forms.Label labelCUIT;
        private System.Windows.Forms.Label labelRazonSoc;
        private System.Windows.Forms.TextBox textBoxEmailEmp;
        private System.Windows.Forms.TextBox textBoxCUITTipo;
        private System.Windows.Forms.TextBox textBoxRazonSoc;
        private System.Windows.Forms.Label labelGuion2;
        private System.Windows.Forms.Label labelGuion1;
        private System.Windows.Forms.TextBox textBoxCUITVerif;
        private System.Windows.Forms.TextBox textBoxCUITNro;
    }
}
