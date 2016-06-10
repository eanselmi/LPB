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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButtonNegativo = new System.Windows.Forms.RadioButton();
            this.radioButtonNeutral = new System.Windows.Forms.RadioButton();
            this.radioButtonPositivo = new System.Windows.Forms.RadioButton();
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
            this.groupBoxDetalle.Controls.Add(this.textBox1);
            this.groupBoxDetalle.Controls.Add(this.radioButton4);
            this.groupBoxDetalle.Controls.Add(this.radioButtonNegativo);
            this.groupBoxDetalle.Controls.Add(this.radioButtonNeutral);
            this.groupBoxDetalle.Controls.Add(this.radioButtonPositivo);
            this.groupBoxDetalle.Enabled = false;
            this.groupBoxDetalle.Location = new System.Drawing.Point(12, 48);
            this.groupBoxDetalle.Name = "groupBoxDetalle";
            this.groupBoxDetalle.Size = new System.Drawing.Size(245, 133);
            this.groupBoxDetalle.TabIndex = 2;
            this.groupBoxDetalle.TabStop = false;
            this.groupBoxDetalle.Text = "Detalle De La Calificacion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(21, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButtonNegativo
            // 
            this.radioButtonNegativo.AutoSize = true;
            this.radioButtonNegativo.Location = new System.Drawing.Point(21, 78);
            this.radioButtonNegativo.Name = "radioButtonNegativo";
            this.radioButtonNegativo.Size = new System.Drawing.Size(68, 17);
            this.radioButtonNegativo.TabIndex = 2;
            this.radioButtonNegativo.TabStop = true;
            this.radioButtonNegativo.Text = "Negativo";
            this.radioButtonNegativo.UseVisualStyleBackColor = true;
            // 
            // radioButtonNeutral
            // 
            this.radioButtonNeutral.AutoSize = true;
            this.radioButtonNeutral.Location = new System.Drawing.Point(21, 55);
            this.radioButtonNeutral.Name = "radioButtonNeutral";
            this.radioButtonNeutral.Size = new System.Drawing.Size(59, 17);
            this.radioButtonNeutral.TabIndex = 1;
            this.radioButtonNeutral.TabStop = true;
            this.radioButtonNeutral.Text = "Neutral";
            this.radioButtonNeutral.UseVisualStyleBackColor = true;
            // 
            // radioButtonPositivo
            // 
            this.radioButtonPositivo.AutoSize = true;
            this.radioButtonPositivo.Location = new System.Drawing.Point(21, 32);
            this.radioButtonPositivo.Name = "radioButtonPositivo";
            this.radioButtonPositivo.Size = new System.Drawing.Size(62, 17);
            this.radioButtonPositivo.TabIndex = 0;
            this.radioButtonPositivo.TabStop = true;
            this.radioButtonPositivo.Text = "Positivo";
            this.radioButtonPositivo.UseVisualStyleBackColor = true;
            // 
            // buttonVolverCalificacion
            // 
            this.buttonVolverCalificacion.Location = new System.Drawing.Point(15, 201);
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
            this.buttonConfirmar.Location = new System.Drawing.Point(182, 201);
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
            // 
            // Calificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 246);
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
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButtonNegativo;
        private System.Windows.Forms.RadioButton radioButtonNeutral;
        private System.Windows.Forms.RadioButton radioButtonPositivo;
        private System.Windows.Forms.Button buttonVolverCalificacion;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}