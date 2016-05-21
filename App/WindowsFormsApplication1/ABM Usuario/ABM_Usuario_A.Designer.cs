namespace MercadoEnvio.ABM_Usuario
{
    partial class ABM_Usuario_A
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxFechaNac = new System.Windows.Forms.TextBox();
            this.comboBoxLocalidades = new System.Windows.Forms.ComboBox();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.textBoxLocalidadCl = new System.Windows.Forms.TextBox();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.textBoxCodPostCl = new System.Windows.Forms.TextBox();
            this.textBoxDptoCl = new System.Windows.Forms.TextBox();
            this.textBoxPisoCl = new System.Windows.Forms.TextBox();
            this.textBoxNroCl = new System.Windows.Forms.TextBox();
            this.textBoxCalleCl = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelCodPostal = new System.Windows.Forms.Label();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.labelDpto = new System.Windows.Forms.Label();
            this.labelPiso = new System.Windows.Forms.Label();
            this.labelNroCalle = new System.Windows.Forms.Label();
            this.labelCalle = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTipoDoc = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(61, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Username: ";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(14, 35);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(59, 13);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Password: ";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(90, 6);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 2;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(90, 33);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 3;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(55, 62);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(86, 13);
            this.labelRol.TabIndex = 4;
            this.labelRol.Text = "Tipo de usuario: ";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Cliente",
            "Empresa"});
            this.comboBoxRol.Location = new System.Drawing.Point(142, 59);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRol.TabIndex = 5;
            this.comboBoxRol.SelectedIndexChanged += new System.EventHandler(this.comboBoxRol_SelectedIndexChanged);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(188, 349);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.Location = new System.Drawing.Point(35, 349);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.monthCalendar1);
            this.groupBoxCliente.Controls.Add(this.textBoxFechaNac);
            this.groupBoxCliente.Controls.Add(this.comboBoxLocalidades);
            this.groupBoxCliente.Controls.Add(this.buttonSeleccionar);
            this.groupBoxCliente.Controls.Add(this.textBoxLocalidadCl);
            this.groupBoxCliente.Controls.Add(this.labelFechaNac);
            this.groupBoxCliente.Controls.Add(this.textBoxCodPostCl);
            this.groupBoxCliente.Controls.Add(this.textBoxDptoCl);
            this.groupBoxCliente.Controls.Add(this.textBoxPisoCl);
            this.groupBoxCliente.Controls.Add(this.textBoxNroCl);
            this.groupBoxCliente.Controls.Add(this.textBoxCalleCl);
            this.groupBoxCliente.Controls.Add(this.textBoxTelefono);
            this.groupBoxCliente.Controls.Add(this.textBoxMail);
            this.groupBoxCliente.Controls.Add(this.textBoxDNI);
            this.groupBoxCliente.Controls.Add(this.textBox3);
            this.groupBoxCliente.Controls.Add(this.textBoxApellido);
            this.groupBoxCliente.Controls.Add(this.textBoxNombre);
            this.groupBoxCliente.Controls.Add(this.labelCodPostal);
            this.groupBoxCliente.Controls.Add(this.labelLocalidad);
            this.groupBoxCliente.Controls.Add(this.labelDpto);
            this.groupBoxCliente.Controls.Add(this.labelPiso);
            this.groupBoxCliente.Controls.Add(this.labelNroCalle);
            this.groupBoxCliente.Controls.Add(this.labelCalle);
            this.groupBoxCliente.Controls.Add(this.labelDireccion);
            this.groupBoxCliente.Controls.Add(this.labelTelefono);
            this.groupBoxCliente.Controls.Add(this.labelMail);
            this.groupBoxCliente.Controls.Add(this.labelTipoDoc);
            this.groupBoxCliente.Controls.Add(this.labelDNI);
            this.groupBoxCliente.Controls.Add(this.labelApellido);
            this.groupBoxCliente.Controls.Add(this.labelNombre);
            this.groupBoxCliente.Location = new System.Drawing.Point(3, 86);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(294, 257);
            this.groupBoxCliente.TabIndex = 8;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Datos del cliente";
            this.groupBoxCliente.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(62, 56);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // textBoxFechaNac
            // 
            this.textBoxFechaNac.Enabled = false;
            this.textBoxFechaNac.Location = new System.Drawing.Point(104, 224);
            this.textBoxFechaNac.Name = "textBoxFechaNac";
            this.textBoxFechaNac.Size = new System.Drawing.Size(109, 20);
            this.textBoxFechaNac.TabIndex = 29;
            // 
            // comboBoxLocalidades
            // 
            this.comboBoxLocalidades.FormattingEnabled = true;
            this.comboBoxLocalidades.Location = new System.Drawing.Point(62, 193);
            this.comboBoxLocalidades.Name = "comboBoxLocalidades";
            this.comboBoxLocalidades.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocalidades.TabIndex = 28;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(219, 222);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 27;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // textBoxLocalidadCl
            // 
            this.textBoxLocalidadCl.Location = new System.Drawing.Point(189, 193);
            this.textBoxLocalidadCl.Name = "textBoxLocalidadCl";
            this.textBoxLocalidadCl.Size = new System.Drawing.Size(90, 20);
            this.textBoxLocalidadCl.TabIndex = 26;
            this.textBoxLocalidadCl.Visible = false;
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Location = new System.Drawing.Point(1, 227);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(106, 13);
            this.labelFechaNac.TabIndex = 24;
            this.labelFechaNac.Text = "Fecha de nacimiento";
            // 
            // textBoxCodPostCl
            // 
            this.textBoxCodPostCl.Location = new System.Drawing.Point(243, 159);
            this.textBoxCodPostCl.Name = "textBoxCodPostCl";
            this.textBoxCodPostCl.Size = new System.Drawing.Size(36, 20);
            this.textBoxCodPostCl.TabIndex = 23;
            // 
            // textBoxDptoCl
            // 
            this.textBoxDptoCl.Location = new System.Drawing.Point(130, 159);
            this.textBoxDptoCl.Name = "textBoxDptoCl";
            this.textBoxDptoCl.Size = new System.Drawing.Size(36, 20);
            this.textBoxDptoCl.TabIndex = 22;
            // 
            // textBoxPisoCl
            // 
            this.textBoxPisoCl.Location = new System.Drawing.Point(57, 159);
            this.textBoxPisoCl.Name = "textBoxPisoCl";
            this.textBoxPisoCl.Size = new System.Drawing.Size(36, 20);
            this.textBoxPisoCl.TabIndex = 21;
            // 
            // textBoxNroCl
            // 
            this.textBoxNroCl.Location = new System.Drawing.Point(243, 132);
            this.textBoxNroCl.Name = "textBoxNroCl";
            this.textBoxNroCl.Size = new System.Drawing.Size(36, 20);
            this.textBoxNroCl.TabIndex = 20;
            // 
            // textBoxCalleCl
            // 
            this.textBoxCalleCl.Location = new System.Drawing.Point(57, 132);
            this.textBoxCalleCl.Name = "textBoxCalleCl";
            this.textBoxCalleCl.Size = new System.Drawing.Size(130, 20);
            this.textBoxCalleCl.TabIndex = 19;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(193, 76);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(83, 20);
            this.textBoxTelefono.TabIndex = 18;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(57, 76);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(83, 20);
            this.textBoxMail.TabIndex = 17;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(193, 48);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(83, 20);
            this.textBoxDNI.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(193, 19);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(83, 20);
            this.textBoxApellido.TabIndex = 14;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(57, 19);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(83, 20);
            this.textBoxNombre.TabIndex = 13;
            // 
            // labelCodPostal
            // 
            this.labelCodPostal.AutoSize = true;
            this.labelCodPostal.Location = new System.Drawing.Point(182, 162);
            this.labelCodPostal.Name = "labelCodPostal";
            this.labelCodPostal.Size = new System.Drawing.Size(55, 13);
            this.labelCodPostal.TabIndex = 12;
            this.labelCodPostal.Text = "CodPostal";
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(3, 196);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(53, 13);
            this.labelLocalidad.TabIndex = 11;
            this.labelLocalidad.Text = "Localidad";
            // 
            // labelDpto
            // 
            this.labelDpto.AutoSize = true;
            this.labelDpto.Location = new System.Drawing.Point(99, 162);
            this.labelDpto.Name = "labelDpto";
            this.labelDpto.Size = new System.Drawing.Size(30, 13);
            this.labelDpto.TabIndex = 10;
            this.labelDpto.Text = "Dpto";
            // 
            // labelPiso
            // 
            this.labelPiso.AutoSize = true;
            this.labelPiso.Location = new System.Drawing.Point(20, 162);
            this.labelPiso.Name = "labelPiso";
            this.labelPiso.Size = new System.Drawing.Size(27, 13);
            this.labelPiso.TabIndex = 9;
            this.labelPiso.Text = "Piso";
            // 
            // labelNroCalle
            // 
            this.labelNroCalle.AutoSize = true;
            this.labelNroCalle.Location = new System.Drawing.Point(193, 135);
            this.labelNroCalle.Name = "labelNroCalle";
            this.labelNroCalle.Size = new System.Drawing.Size(47, 13);
            this.labelNroCalle.TabIndex = 8;
            this.labelNroCalle.Text = "NroCalle";
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(20, 135);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(30, 13);
            this.labelCalle.TabIndex = 7;
            this.labelCalle.Text = "Calle";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(9, 108);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 6;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(143, 79);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 5;
            this.labelTelefono.Text = "Telefono";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(8, 79);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 4;
            this.labelMail.Text = "Mail";
            // 
            // labelTipoDoc
            // 
            this.labelTipoDoc.AutoSize = true;
            this.labelTipoDoc.Location = new System.Drawing.Point(8, 51);
            this.labelTipoDoc.Name = "labelTipoDoc";
            this.labelTipoDoc.Size = new System.Drawing.Size(48, 13);
            this.labelTipoDoc.TabIndex = 3;
            this.labelTipoDoc.Text = "TipoDoc";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(147, 51);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 2;
            this.labelDNI.Text = "DNI";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(143, 22);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(7, 22);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // ABM_Usuario_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 384);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Name = "ABM_Usuario_A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de un usuario";
            this.Load += new System.EventHandler(this.ABM_Usuario_A_Load);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label labelCodPostal;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.Label labelDpto;
        private System.Windows.Forms.Label labelPiso;
        private System.Windows.Forms.Label labelNroCalle;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTipoDoc;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.TextBox textBoxCodPostCl;
        private System.Windows.Forms.TextBox textBoxDptoCl;
        private System.Windows.Forms.TextBox textBoxPisoCl;
        private System.Windows.Forms.TextBox textBoxNroCl;
        private System.Windows.Forms.TextBox textBoxCalleCl;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxLocalidadCl;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.TextBox textBoxFechaNac;
        private System.Windows.Forms.ComboBox comboBoxLocalidades;
    }
}