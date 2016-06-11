namespace visibilidad.Calificar
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.groupBoxLH = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistorial = new System.Windows.Forms.DataGridView();
            this.buttonVolverHistorial = new System.Windows.Forms.Button();
            this.groupBoxLH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLH
            // 
            this.groupBoxLH.Controls.Add(this.dataGridViewHistorial);
            this.groupBoxLH.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLH.Name = "groupBoxLH";
            this.groupBoxLH.Size = new System.Drawing.Size(456, 187);
            this.groupBoxLH.TabIndex = 0;
            this.groupBoxLH.TabStop = false;
            this.groupBoxLH.Text = "Listado";
            // 
            // dataGridViewHistorial
            // 
            this.dataGridViewHistorial.AllowUserToAddRows = false;
            this.dataGridViewHistorial.AllowUserToDeleteRows = false;
            this.dataGridViewHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorial.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewHistorial.Name = "dataGridViewHistorial";
            this.dataGridViewHistorial.ReadOnly = true;
            this.dataGridViewHistorial.Size = new System.Drawing.Size(444, 151);
            this.dataGridViewHistorial.TabIndex = 0;
            // 
            // buttonVolverHistorial
            // 
            this.buttonVolverHistorial.Location = new System.Drawing.Point(200, 205);
            this.buttonVolverHistorial.Name = "buttonVolverHistorial";
            this.buttonVolverHistorial.Size = new System.Drawing.Size(75, 23);
            this.buttonVolverHistorial.TabIndex = 1;
            this.buttonVolverHistorial.Text = "Volver";
            this.buttonVolverHistorial.UseVisualStyleBackColor = true;
            this.buttonVolverHistorial.Click += new System.EventHandler(this.buttonVolverHistorial_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 240);
            this.Controls.Add(this.buttonVolverHistorial);
            this.Controls.Add(this.groupBoxLH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Historial De Calificaciones";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Historial_Load);
            this.groupBoxLH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLH;
        private System.Windows.Forms.DataGridView dataGridViewHistorial;
        private System.Windows.Forms.Button buttonVolverHistorial;
    }
}