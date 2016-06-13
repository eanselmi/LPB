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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonCalificar = new System.Windows.Forms.Button();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.buttonOfertas = new System.Windows.Forms.Button();
            this.groupBoxCalificar = new System.Windows.Forms.GroupBox();
            this.dataGridViewCalificar = new System.Windows.Forms.DataGridView();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxCompra = new System.Windows.Forms.TextBox();
            this.groupBoxCalificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(12, 294);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonCalificar
            // 
            this.buttonCalificar.Enabled = false;
            this.buttonCalificar.Location = new System.Drawing.Point(641, 294);
            this.buttonCalificar.Name = "buttonCalificar";
            this.buttonCalificar.Size = new System.Drawing.Size(75, 23);
            this.buttonCalificar.TabIndex = 2;
            this.buttonCalificar.Text = "Calificar";
            this.buttonCalificar.UseVisualStyleBackColor = true;
            this.buttonCalificar.Click += new System.EventHandler(this.buttonCalificar_Click);
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(188, 21);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(130, 23);
            this.buttonComprar.TabIndex = 3;
            this.buttonComprar.Text = "Calificar Compras";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // buttonOfertas
            // 
            this.buttonOfertas.Location = new System.Drawing.Point(414, 21);
            this.buttonOfertas.Name = "buttonOfertas";
            this.buttonOfertas.Size = new System.Drawing.Size(138, 23);
            this.buttonOfertas.TabIndex = 4;
            this.buttonOfertas.Text = "Calificar Ofertas";
            this.buttonOfertas.UseVisualStyleBackColor = true;
            this.buttonOfertas.Click += new System.EventHandler(this.buttonOfertas_Click);
            // 
            // groupBoxCalificar
            // 
            this.groupBoxCalificar.Controls.Add(this.dataGridViewCalificar);
            this.groupBoxCalificar.Location = new System.Drawing.Point(12, 63);
            this.groupBoxCalificar.Name = "groupBoxCalificar";
            this.groupBoxCalificar.Size = new System.Drawing.Size(704, 225);
            this.groupBoxCalificar.TabIndex = 5;
            this.groupBoxCalificar.TabStop = false;
            this.groupBoxCalificar.Visible = false;
            // 
            // dataGridViewCalificar
            // 
            this.dataGridViewCalificar.AllowUserToAddRows = false;
            this.dataGridViewCalificar.AllowUserToDeleteRows = false;
            this.dataGridViewCalificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCalificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalificar.Location = new System.Drawing.Point(18, 19);
            this.dataGridViewCalificar.Name = "dataGridViewCalificar";
            this.dataGridViewCalificar.ReadOnly = true;
            this.dataGridViewCalificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCalificar.Size = new System.Drawing.Size(670, 185);
            this.dataGridViewCalificar.TabIndex = 0;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(30, 12);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 6;
            this.textBoxUser.Visible = false;
            // 
            // textBoxCompra
            // 
            this.textBoxCompra.Location = new System.Drawing.Point(30, 39);
            this.textBoxCompra.Name = "textBoxCompra";
            this.textBoxCompra.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompra.TabIndex = 7;
            this.textBoxCompra.Visible = false;
            // 
            // ComprasOfertasSinCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 329);
            this.Controls.Add(this.textBoxCompra);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.groupBoxCalificar);
            this.Controls.Add(this.buttonOfertas);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.buttonCalificar);
            this.Controls.Add(this.buttonVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComprasOfertasSinCalificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificacion";
            this.Load += new System.EventHandler(this.ComprasOfertasSinCalificar_Load);
            this.groupBoxCalificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonCalificar;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Button buttonOfertas;
        private System.Windows.Forms.GroupBox groupBoxCalificar;
        private System.Windows.Forms.DataGridView dataGridViewCalificar;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxCompra;

    }
}