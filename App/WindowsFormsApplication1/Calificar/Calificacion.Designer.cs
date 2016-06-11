namespace visibilidad.Calificar
{
    partial class Calificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calificacion));
            this.labelEstrellas = new System.Windows.Forms.Label();
            this.comboBoxEstrellas = new System.Windows.Forms.ComboBox();
            this.groupBoxDetalle = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDetalle = new System.Windows.Forms.ComboBox();
            this.textBoxDetalleP = new System.Windows.Forms.TextBox();
            this.buttonVolverCalificacion = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEstrellas
            // 
            this.labelEstrellas.AutoSize = true;
            this.labelEstrellas.Location = new System.Drawing.Point(12, 19);
            this.labelEstrellas.Name = "labelEstrellas";
            this.labelEstrellas.Size = new System.Drawing.Size(46, 13);
            this.labelEstrellas.TabIndex = 0;
            this.labelEstrellas.Text = "Estrellas";
            // 
            // comboBoxEstrellas
            // 
            this.comboBoxEstrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstrellas.FormattingEnabled = true;
            this.comboBoxEstrellas.Location = new System.Drawing.Point(65, 19);
            this.comboBoxEstrellas.MaxDropDownItems = 5;
            this.comboBoxEstrellas.Name = "comboBoxEstrellas";
            this.comboBoxEstrellas.Size = new System.Drawing.Size(53, 21);
            this.comboBoxEstrellas.TabIndex = 1;
            this.comboBoxEstrellas.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstrellas_SelectedIndexChanged);
            // 
            // groupBoxDetalle
            // 
            this.groupBoxDetalle.Controls.Add(this.label2);
            this.groupBoxDetalle.Controls.Add(this.label1);
            this.groupBoxDetalle.Controls.Add(this.comboBoxDetalle);
            this.groupBoxDetalle.Controls.Add(this.textBoxDetalleP);
            this.groupBoxDetalle.Enabled = false;
            this.groupBoxDetalle.Location = new System.Drawing.Point(12, 48);
            this.groupBoxDetalle.Name = "groupBoxDetalle";
            this.groupBoxDetalle.Size = new System.Drawing.Size(245, 115);
            this.groupBoxDetalle.TabIndex = 2;
            this.groupBoxDetalle.TabStop = false;
            this.groupBoxDetalle.Text = "Detalle De La Calificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalle Personal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Elegir Detalle";
            // 
            // comboBoxDetalle
            // 
            this.comboBoxDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDetalle.FormattingEnabled = true;
            this.comboBoxDetalle.Location = new System.Drawing.Point(102, 31);
            this.comboBoxDetalle.Name = "comboBoxDetalle";
            this.comboBoxDetalle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDetalle.TabIndex = 5;
            this.comboBoxDetalle.SelectedIndexChanged += new System.EventHandler(this.comboBoxDetalle_SelectedIndexChanged);
            // 
            // textBoxDetalleP
            // 
            this.textBoxDetalleP.Location = new System.Drawing.Point(102, 71);
            this.textBoxDetalleP.Name = "textBoxDetalleP";
            this.textBoxDetalleP.Size = new System.Drawing.Size(121, 20);
            this.textBoxDetalleP.TabIndex = 4;
            this.textBoxDetalleP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDetalleP_MouseClick);
            this.textBoxDetalleP.MouseLeave += new System.EventHandler(this.textBoxDetalleP_MouseLeave);
            // 
            // buttonVolverCalificacion
            // 
            this.buttonVolverCalificacion.Location = new System.Drawing.Point(15, 183);
            this.buttonVolverCalificacion.Name = "buttonVolverCalificacion";
            this.buttonVolverCalificacion.Size = new System.Drawing.Size(75, 23);
            this.buttonVolverCalificacion.TabIndex = 3;
            this.buttonVolverCalificacion.Text = "Volver";
            this.buttonVolverCalificacion.UseVisualStyleBackColor = true;
            this.buttonVolverCalificacion.Click += new System.EventHandler(this.buttonVolverCalificacion_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Enabled = false;
            this.buttonConfirmar.Location = new System.Drawing.Point(182, 183);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 4;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            // 
            // Calificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 221);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonVolverCalificacion);
            this.Controls.Add(this.groupBoxDetalle);
            this.Controls.Add(this.comboBoxEstrellas);
            this.Controls.Add(this.labelEstrellas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificacion";
            this.TopMost = true;
            this.groupBoxDetalle.ResumeLayout(false);
            this.groupBoxDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstrellas;
        private System.Windows.Forms.ComboBox comboBoxEstrellas;
        private System.Windows.Forms.GroupBox groupBoxDetalle;
        private System.Windows.Forms.Button buttonVolverCalificacion;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBoxDetalleP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDetalle;
    }
}