namespace visibilidad.Calificar
{
    partial class ComprasOfertasSinCalificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasOfertasSinCalificar));
            this.tabControlCO = new System.Windows.Forms.TabControl();
            this.tabPageCompras = new System.Windows.Forms.TabPage();
            this.tabPageOfertas = new System.Windows.Forms.TabPage();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonCalificar = new System.Windows.Forms.Button();
            this.dataGridViewOfertas = new System.Windows.Forms.DataGridView();
            this.dataGridViewCompras = new System.Windows.Forms.DataGridView();
            this.tabControlCO.SuspendLayout();
            this.tabPageCompras.SuspendLayout();
            this.tabPageOfertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCO
            // 
            this.tabControlCO.Controls.Add(this.tabPageCompras);
            this.tabControlCO.Controls.Add(this.tabPageOfertas);
            this.tabControlCO.Location = new System.Drawing.Point(0, 0);
            this.tabControlCO.Name = "tabControlCO";
            this.tabControlCO.SelectedIndex = 0;
            this.tabControlCO.Size = new System.Drawing.Size(388, 281);
            this.tabControlCO.TabIndex = 0;
            // 
            // tabPageCompras
            // 
            this.tabPageCompras.Controls.Add(this.dataGridViewCompras);
            this.tabPageCompras.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompras.Name = "tabPageCompras";
            this.tabPageCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompras.Size = new System.Drawing.Size(380, 255);
            this.tabPageCompras.TabIndex = 0;
            this.tabPageCompras.Text = "Compras";
            this.tabPageCompras.UseVisualStyleBackColor = true;
            // 
            // tabPageOfertas
            // 
            this.tabPageOfertas.Controls.Add(this.dataGridViewOfertas);
            this.tabPageOfertas.Location = new System.Drawing.Point(4, 22);
            this.tabPageOfertas.Name = "tabPageOfertas";
            this.tabPageOfertas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOfertas.Size = new System.Drawing.Size(380, 255);
            this.tabPageOfertas.TabIndex = 1;
            this.tabPageOfertas.Text = "Ofertas";
            this.tabPageOfertas.UseVisualStyleBackColor = true;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(4, 287);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // buttonCalificar
            // 
            this.buttonCalificar.Location = new System.Drawing.Point(309, 287);
            this.buttonCalificar.Name = "buttonCalificar";
            this.buttonCalificar.Size = new System.Drawing.Size(75, 23);
            this.buttonCalificar.TabIndex = 2;
            this.buttonCalificar.Text = "Calificar";
            this.buttonCalificar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOfertas
            // 
            this.dataGridViewOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfertas.Location = new System.Drawing.Point(0, 1);
            this.dataGridViewOfertas.Name = "dataGridViewOfertas";
            this.dataGridViewOfertas.Size = new System.Drawing.Size(380, 252);
            this.dataGridViewOfertas.TabIndex = 1;
            // 
            // dataGridViewCompras
            // 
            this.dataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompras.Location = new System.Drawing.Point(0, 1);
            this.dataGridViewCompras.Name = "dataGridViewCompras";
            this.dataGridViewCompras.Size = new System.Drawing.Size(380, 252);
            this.dataGridViewCompras.TabIndex = 1;
            this.dataGridViewCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompras_CellContentClick);
            // 
            // Calificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 320);
            this.Controls.Add(this.buttonCalificar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.tabControlCO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calificacion";
            this.Text = "Calificacion";
            this.tabControlCO.ResumeLayout(false);
            this.tabPageCompras.ResumeLayout(false);
            this.tabPageOfertas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCO;
        private System.Windows.Forms.TabPage tabPageCompras;
        private System.Windows.Forms.TabPage tabPageOfertas;
        private System.Windows.Forms.DataGridView dataGridViewOfertas;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonCalificar;
        private System.Windows.Forms.DataGridView dataGridViewCompras;

    }
}