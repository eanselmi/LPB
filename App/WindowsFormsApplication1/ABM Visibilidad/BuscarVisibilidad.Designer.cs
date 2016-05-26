namespace visibilidad.ABM_Visibilidad
{
    partial class BuscarVisibilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarVisibilidad));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_visibilidades = new System.Windows.Forms.ComboBox();
            this.label_visibilidades = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(22, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(362, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // combo_visibilidades
            // 
            this.combo_visibilidades.FormattingEnabled = true;
            this.combo_visibilidades.Location = new System.Drawing.Point(125, 16);
            this.combo_visibilidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_visibilidades.Name = "combo_visibilidades";
            this.combo_visibilidades.Size = new System.Drawing.Size(259, 28);
            this.combo_visibilidades.TabIndex = 5;
            this.combo_visibilidades.SelectedIndexChanged += new System.EventHandler(this.combo_funciones_SelectedIndexChanged);
            // 
            // label_visibilidades
            // 
            this.label_visibilidades.AutoSize = true;
            this.label_visibilidades.Location = new System.Drawing.Point(19, 21);
            this.label_visibilidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_visibilidades.Name = "label_visibilidades";
            this.label_visibilidades.Size = new System.Drawing.Size(96, 20);
            this.label_visibilidades.TabIndex = 4;
            this.label_visibilidades.Text = "Visibilidades";
            this.label_visibilidades.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(207, 142);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(169, 35);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(29, 142);
            this.btn_seleccionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(169, 35);
            this.btn_seleccionar.TabIndex = 2;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // BuscarVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 209);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.combo_visibilidades);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.label_visibilidades);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BuscarVisibilidad";
            this.Text = "Buscar Visibilidad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combo_visibilidades;
        private System.Windows.Forms.Label label_visibilidades;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_seleccionar;
    }
}