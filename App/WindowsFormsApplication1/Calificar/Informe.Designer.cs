namespace visibilidad.Calificar
{
    partial class Informe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe));
            this.buttonVolverInforme = new System.Windows.Forms.Button();
            this.groupBoxInforme = new System.Windows.Forms.GroupBox();
            this.buttonInformeCompras = new System.Windows.Forms.Button();
            this.buttonInformeOfertas = new System.Windows.Forms.Button();
            this.dataGridViewInformes = new System.Windows.Forms.DataGridView();
            this.groupBoxInforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolverInforme
            // 
            this.buttonVolverInforme.Location = new System.Drawing.Point(163, 232);
            this.buttonVolverInforme.Name = "buttonVolverInforme";
            this.buttonVolverInforme.Size = new System.Drawing.Size(75, 23);
            this.buttonVolverInforme.TabIndex = 1;
            this.buttonVolverInforme.Text = "Volver";
            this.buttonVolverInforme.UseVisualStyleBackColor = true;
            this.buttonVolverInforme.Click += new System.EventHandler(this.buttonVolverInforme_Click);
            // 
            // groupBoxInforme
            // 
            this.groupBoxInforme.Controls.Add(this.dataGridViewInformes);
            this.groupBoxInforme.Location = new System.Drawing.Point(12, 48);
            this.groupBoxInforme.Name = "groupBoxInforme";
            this.groupBoxInforme.Size = new System.Drawing.Size(396, 178);
            this.groupBoxInforme.TabIndex = 2;
            this.groupBoxInforme.TabStop = false;
            this.groupBoxInforme.Visible = false;
            // 
            // buttonInformeCompras
            // 
            this.buttonInformeCompras.Location = new System.Drawing.Point(22, 19);
            this.buttonInformeCompras.Name = "buttonInformeCompras";
            this.buttonInformeCompras.Size = new System.Drawing.Size(136, 23);
            this.buttonInformeCompras.TabIndex = 3;
            this.buttonInformeCompras.Text = "Informe De Compras";
            this.buttonInformeCompras.UseVisualStyleBackColor = true;
            this.buttonInformeCompras.Click += new System.EventHandler(this.buttonInformeCompras_Click);
            // 
            // buttonInformeOfertas
            // 
            this.buttonInformeOfertas.Location = new System.Drawing.Point(258, 19);
            this.buttonInformeOfertas.Name = "buttonInformeOfertas";
            this.buttonInformeOfertas.Size = new System.Drawing.Size(136, 23);
            this.buttonInformeOfertas.TabIndex = 4;
            this.buttonInformeOfertas.Text = "Informe De Ofertas";
            this.buttonInformeOfertas.UseVisualStyleBackColor = true;
            this.buttonInformeOfertas.Click += new System.EventHandler(this.buttonInformeOfertas_Click);
            // 
            // dataGridViewInformes
            // 
            this.dataGridViewInformes.AllowUserToAddRows = false;
            this.dataGridViewInformes.AllowUserToDeleteRows = false;
            this.dataGridViewInformes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformes.Location = new System.Drawing.Point(10, 19);
            this.dataGridViewInformes.Name = "dataGridViewInformes";
            this.dataGridViewInformes.ReadOnly = true;
            this.dataGridViewInformes.Size = new System.Drawing.Size(372, 142);
            this.dataGridViewInformes.TabIndex = 0;
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
            this.Controls.Add(this.buttonInformeOfertas);
            this.Controls.Add(this.buttonInformeCompras);
            this.Controls.Add(this.groupBoxInforme);
            this.Controls.Add(this.buttonVolverInforme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Informe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe";
            this.TopMost = true;
            this.groupBoxInforme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolverInforme;
        private System.Windows.Forms.GroupBox groupBoxInforme;
        private System.Windows.Forms.DataGridView dataGridViewInformes;
        private System.Windows.Forms.Button buttonInformeCompras;
        private System.Windows.Forms.Button buttonInformeOfertas;
    }
}