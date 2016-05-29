namespace visibilidad.Listado_Estadistico
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
            this.groupBoxListados.Controls.Add(this.dataGridViewListados);
            this.groupBoxListados.Controls.Add(this.comboBoxListados);
            this.groupBoxListados.Controls.Add(this.label1);
            this.groupBoxListados.Controls.Add(this.comboBoxTrimestre);
            this.groupBoxListados.Controls.Add(this.labelTrimestre);
            this.groupBoxListados.Controls.Add(this.dateTimePickerListados);
            this.groupBoxListados.Controls.Add(this.labelAnio);
            this.groupBoxListados.Location = new System.Drawing.Point(12, 12);
            this.groupBoxListados.Name = "groupBoxListados";
            this.groupBoxListados.Size = new System.Drawing.Size(552, 396);
            this.groupBoxListados.TabIndex = 0;
            this.groupBoxListados.TabStop = false;
            this.groupBoxListados.Text = "Listados";
            // 
            // dataGridViewListados
            // 
            this.dataGridViewListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListados.Location = new System.Drawing.Point(6, 153);
            this.dataGridViewListados.Name = "dataGridViewListados";
            this.dataGridViewListados.Size = new System.Drawing.Size(540, 230);
            this.dataGridViewListados.TabIndex = 6;
            // 
            // comboBoxListados
            // 
            this.comboBoxListados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListados.FormattingEnabled = true;
            this.comboBoxListados.Location = new System.Drawing.Point(131, 109);
            this.comboBoxListados.Name = "comboBoxListados";
            this.comboBoxListados.Size = new System.Drawing.Size(351, 24);
            this.comboBoxListados.TabIndex = 5;
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
            this.buttonVolver.Location = new System.Drawing.Point(12, 428);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(91, 22);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(462, 428);
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
            this.ClientSize = new System.Drawing.Size(576, 462);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.groupBoxListados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoEstadistico";
            this.Text = "Listados Estadisticos  ";
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
    }
}