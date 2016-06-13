namespace visibilidad.Calificar
{
    partial class Opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones));
            this.buttonIniciarCalificar = new System.Windows.Forms.Button();
            this.buttonHistorial = new System.Windows.Forms.Button();
            this.buttonInforme = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIniciarCalificar
            // 
            this.buttonIniciarCalificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarCalificar.Location = new System.Drawing.Point(16, 27);
            this.buttonIniciarCalificar.Name = "buttonIniciarCalificar";
            this.buttonIniciarCalificar.Size = new System.Drawing.Size(149, 34);
            this.buttonIniciarCalificar.TabIndex = 0;
            this.buttonIniciarCalificar.Text = "Iniciar Calificacion";
            this.buttonIniciarCalificar.UseVisualStyleBackColor = true;
            this.buttonIniciarCalificar.Click += new System.EventHandler(this.buttonIniciarCalificar_Click);
            // 
            // buttonHistorial
            // 
            this.buttonHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistorial.Location = new System.Drawing.Point(189, 27);
            this.buttonHistorial.Name = "buttonHistorial";
            this.buttonHistorial.Size = new System.Drawing.Size(149, 34);
            this.buttonHistorial.TabIndex = 1;
            this.buttonHistorial.Text = "Ver Historial";
            this.buttonHistorial.UseVisualStyleBackColor = true;
            this.buttonHistorial.Click += new System.EventHandler(this.buttonHistorial_Click);
            // 
            // buttonInforme
            // 
            this.buttonInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInforme.Location = new System.Drawing.Point(370, 27);
            this.buttonInforme.Name = "buttonInforme";
            this.buttonInforme.Size = new System.Drawing.Size(149, 34);
            this.buttonInforme.TabIndex = 2;
            this.buttonInforme.Text = "Ver Informe ";
            this.buttonInforme.UseVisualStyleBackColor = true;
            this.buttonInforme.Click += new System.EventHandler(this.buttonInforme_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonIniciarCalificar);
            this.groupBox1.Controls.Add(this.buttonInforme);
            this.groupBox1.Controls.Add(this.buttonHistorial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificaciones";
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 116);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Opciones";
            this.Text = "Opciones De Calificar";
          //  this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciarCalificar;
        private System.Windows.Forms.Button buttonHistorial;
        private System.Windows.Forms.Button buttonInforme;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}