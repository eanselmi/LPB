﻿namespace visibilidad.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoEstadistico));
            this.groupBoxListados = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.labelRubro = new System.Windows.Forms.Label();
            this.comboBoxVisibilidad = new System.Windows.Forms.ComboBox();
            this.labelVisibilidad = new System.Windows.Forms.Label();
            this.dataGridViewListados = new System.Windows.Forms.DataGridView();
            this.comboBoxListados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.labelTrimestre = new System.Windows.Forms.Label();
            this.dateTimePickerListados = new System.Windows.Forms.DateTimePicker();
            this.labelAnio = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBoxListados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListados
            // 
            this.groupBoxListados.Controls.Add(this.buttonLimpiar);
            this.groupBoxListados.Controls.Add(this.comboBoxRubro);
            this.groupBoxListados.Controls.Add(this.labelRubro);
            this.groupBoxListados.Controls.Add(this.comboBoxVisibilidad);
            this.groupBoxListados.Controls.Add(this.labelVisibilidad);
            this.groupBoxListados.Controls.Add(this.dataGridViewListados);
            this.groupBoxListados.Controls.Add(this.comboBoxListados);
            this.groupBoxListados.Controls.Add(this.label1);
            this.groupBoxListados.Controls.Add(this.comboBoxTrimestre);
            this.groupBoxListados.Controls.Add(this.labelTrimestre);
            this.groupBoxListados.Controls.Add(this.dateTimePickerListados);
            this.groupBoxListados.Controls.Add(this.labelAnio);
            this.groupBoxListados.Location = new System.Drawing.Point(12, 12);
            this.groupBoxListados.Name = "groupBoxListados";
            this.groupBoxListados.Size = new System.Drawing.Size(661, 444);
            this.groupBoxListados.TabIndex = 0;
            this.groupBoxListados.TabStop = false;
            this.groupBoxListados.Text = "Listados";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(445, 190);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(91, 22);
            this.buttonLimpiar.TabIndex = 3;
            this.buttonLimpiar.Text = "Limpiar filtros";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRubro.Enabled = false;
            this.comboBoxRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(131, 189);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(169, 21);
            this.comboBoxRubro.TabIndex = 10;
            this.comboBoxRubro.SelectedIndexChanged += new System.EventHandler(this.comboBoxRubro_SelectedIndexChanged);
            // 
            // labelRubro
            // 
            this.labelRubro.AutoSize = true;
            this.labelRubro.Enabled = false;
            this.labelRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRubro.Location = new System.Drawing.Point(36, 190);
            this.labelRubro.Name = "labelRubro";
            this.labelRubro.Size = new System.Drawing.Size(41, 15);
            this.labelRubro.TabIndex = 9;
            this.labelRubro.Text = "Rubro";
            // 
            // comboBoxVisibilidad
            // 
            this.comboBoxVisibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisibilidad.Enabled = false;
            this.comboBoxVisibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVisibilidad.FormattingEnabled = true;
            this.comboBoxVisibilidad.Location = new System.Drawing.Point(131, 152);
            this.comboBoxVisibilidad.Name = "comboBoxVisibilidad";
            this.comboBoxVisibilidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisibilidad.TabIndex = 8;
            this.comboBoxVisibilidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisibilidad_SelectedIndexChanged);
            // 
            // labelVisibilidad
            // 
            this.labelVisibilidad.AutoSize = true;
            this.labelVisibilidad.Enabled = false;
            this.labelVisibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisibilidad.Location = new System.Drawing.Point(36, 155);
            this.labelVisibilidad.Name = "labelVisibilidad";
            this.labelVisibilidad.Size = new System.Drawing.Size(63, 15);
            this.labelVisibilidad.TabIndex = 7;
            this.labelVisibilidad.Text = "Visibilidad";
            // 
            // dataGridViewListados
            // 
            this.dataGridViewListados.AllowUserToAddRows = false;
            this.dataGridViewListados.AllowUserToDeleteRows = false;
            this.dataGridViewListados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListados.Location = new System.Drawing.Point(6, 223);
            this.dataGridViewListados.Name = "dataGridViewListados";
            this.dataGridViewListados.ReadOnly = true;
            this.dataGridViewListados.Size = new System.Drawing.Size(650, 203);
            this.dataGridViewListados.TabIndex = 6;
            // 
            // comboBoxListados
            // 
            this.comboBoxListados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListados.Enabled = false;
            this.comboBoxListados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListados.FormattingEnabled = true;
            this.comboBoxListados.Location = new System.Drawing.Point(131, 109);
            this.comboBoxListados.Name = "comboBoxListados";
            this.comboBoxListados.Size = new System.Drawing.Size(415, 24);
            this.comboBoxListados.TabIndex = 5;
            this.comboBoxListados.SelectedIndexChanged += new System.EventHandler(this.comboBoxListados_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listados";
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrimestre.DropDownWidth = 116;
            this.comboBoxTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Location = new System.Drawing.Point(131, 66);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(115, 24);
            this.comboBoxTrimestre.TabIndex = 3;
            this.comboBoxTrimestre.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrimestre_SelectedIndexChanged);
            // 
            // labelTrimestre
            // 
            this.labelTrimestre.AutoSize = true;
            this.labelTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrimestre.Location = new System.Drawing.Point(36, 73);
            this.labelTrimestre.Name = "labelTrimestre";
            this.labelTrimestre.Size = new System.Drawing.Size(68, 17);
            this.labelTrimestre.TabIndex = 2;
            this.labelTrimestre.Text = "Trimestre";
            // 
            // dateTimePickerListados
            // 
            this.dateTimePickerListados.CustomFormat = "yyyy";
            this.dateTimePickerListados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerListados.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerListados.Location = new System.Drawing.Point(131, 28);
            this.dateTimePickerListados.Name = "dateTimePickerListados";
            this.dateTimePickerListados.ShowUpDown = true;
            this.dateTimePickerListados.Size = new System.Drawing.Size(62, 23);
            this.dateTimePickerListados.TabIndex = 1;
            this.dateTimePickerListados.Value = new System.DateTime(2016, 5, 28, 12, 30, 12, 0);
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnio.Location = new System.Drawing.Point(36, 28);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(33, 17);
            this.labelAnio.TabIndex = 0;
            this.labelAnio.Text = "Año";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(12, 477);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(91, 22);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Enabled = false;
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(571, 480);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(102, 22);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 514);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.groupBoxListados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoEstadistico";
            this.Text = "Listados Estadisticos  ";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.groupBoxListados.ResumeLayout(false);
            this.groupBoxListados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListados;
        private System.Windows.Forms.DateTimePicker dateTimePickerListados;
        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
        private System.Windows.Forms.Label labelTrimestre;
        private System.Windows.Forms.DataGridView dataGridViewListados;
        private System.Windows.Forms.ComboBox comboBoxListados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label labelVisibilidad;
        private System.Windows.Forms.ComboBox comboBoxVisibilidad;
        private System.Windows.Forms.ComboBox comboBoxRubro;
        private System.Windows.Forms.Label labelRubro;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}