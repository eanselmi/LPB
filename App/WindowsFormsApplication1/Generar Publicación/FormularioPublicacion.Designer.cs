namespace visibilidad.Generar_Publicación
{
    partial class FormularioPublicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPublicacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_pregunta = new System.Windows.Forms.CheckBox();
            this.text_stock = new System.Windows.Forms.TextBox();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.check_envio = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checklist_rubros = new System.Windows.Forms.CheckedListBox();
            this.date_fin = new System.Windows.Forms.DateTimePicker();
            this.date_inicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_visibilidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radio_finalizada = new System.Windows.Forms.RadioButton();
            this.radio_pausada = new System.Windows.Forms.RadioButton();
            this.radio_activa = new System.Windows.Forms.RadioButton();
            this.radio_borrador = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_subasta = new System.Windows.Forms.RadioButton();
            this.radio_compra = new System.Windows.Forms.RadioButton();
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_visibilidad_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_pregunta);
            this.groupBox1.Controls.Add(this.text_stock);
            this.groupBox1.Controls.Add(this.text_precio);
            this.groupBox1.Controls.Add(this.btn_volver);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.check_envio);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.date_fin);
            this.groupBox1.Controls.Add(this.date_inicio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_visibilidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.text_descripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 560);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // check_pregunta
            // 
            this.check_pregunta.AutoSize = true;
            this.check_pregunta.Location = new System.Drawing.Point(237, 234);
            this.check_pregunta.Name = "check_pregunta";
            this.check_pregunta.Size = new System.Drawing.Size(163, 24);
            this.check_pregunta.TabIndex = 23;
            this.check_pregunta.Text = "Acepta Preguntas";
            this.check_pregunta.UseVisualStyleBackColor = true;
            // 
            // text_stock
            // 
            this.text_stock.Location = new System.Drawing.Point(116, 168);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(100, 26);
            this.text_stock.TabIndex = 22;
            this.text_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // text_precio
            // 
            this.text_precio.Location = new System.Drawing.Point(116, 229);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(100, 26);
            this.text_precio.TabIndex = 21;
            this.text_precio.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(548, 502);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(165, 35);
            this.btn_volver.TabIndex = 19;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(548, 446);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(165, 35);
            this.btn_limpiar.TabIndex = 18;
            this.btn_limpiar.Text = "Reestablecer";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(548, 395);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(165, 35);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // check_envio
            // 
            this.check_envio.AutoSize = true;
            this.check_envio.Location = new System.Drawing.Point(237, 172);
            this.check_envio.Name = "check_envio";
            this.check_envio.Size = new System.Drawing.Size(129, 24);
            this.check_envio.TabIndex = 16;
            this.check_envio.Text = "Acepta Envio";
            this.check_envio.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checklist_rubros);
            this.groupBox4.Location = new System.Drawing.Point(26, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(486, 192);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rubros";
            // 
            // checklist_rubros
            // 
            this.checklist_rubros.FormattingEnabled = true;
            this.checklist_rubros.Location = new System.Drawing.Point(18, 25);
            this.checklist_rubros.Name = "checklist_rubros";
            this.checklist_rubros.Size = new System.Drawing.Size(445, 130);
            this.checklist_rubros.TabIndex = 0;
            // 
            // date_fin
            // 
            this.date_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fin.Location = new System.Drawing.Point(352, 298);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(138, 26);
            this.date_fin.TabIndex = 13;
            // 
            // date_inicio
            // 
            this.date_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_inicio.Location = new System.Drawing.Point(123, 298);
            this.date_inicio.Name = "date_inicio";
            this.date_inicio.Size = new System.Drawing.Size(138, 26);
            this.date_inicio.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock";
            // 
            // cmb_visibilidad
            // 
            this.cmb_visibilidad.FormattingEnabled = true;
            this.cmb_visibilidad.Location = new System.Drawing.Point(120, 95);
            this.cmb_visibilidad.Name = "cmb_visibilidad";
            this.cmb_visibilidad.Size = new System.Drawing.Size(226, 28);
            this.cmb_visibilidad.TabIndex = 5;
            this.cmb_visibilidad.SelectedIndexChanged += new System.EventHandler(this.cmb_visibilidad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Visibilidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio_finalizada);
            this.groupBox3.Controls.Add(this.radio_pausada);
            this.groupBox3.Controls.Add(this.radio_activa);
            this.groupBox3.Controls.Add(this.radio_borrador);
            this.groupBox3.Location = new System.Drawing.Point(530, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 205);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado";
            // 
            // radio_finalizada
            // 
            this.radio_finalizada.AutoSize = true;
            this.radio_finalizada.Location = new System.Drawing.Point(36, 160);
            this.radio_finalizada.Name = "radio_finalizada";
            this.radio_finalizada.Size = new System.Drawing.Size(106, 24);
            this.radio_finalizada.TabIndex = 5;
            this.radio_finalizada.TabStop = true;
            this.radio_finalizada.Text = "Finalizada";
            this.radio_finalizada.UseVisualStyleBackColor = true;
            this.radio_finalizada.CheckedChanged += new System.EventHandler(this.radio_finalizada_CheckedChanged);
            // 
            // radio_pausada
            // 
            this.radio_pausada.AutoSize = true;
            this.radio_pausada.Location = new System.Drawing.Point(36, 113);
            this.radio_pausada.Name = "radio_pausada";
            this.radio_pausada.Size = new System.Drawing.Size(97, 24);
            this.radio_pausada.TabIndex = 4;
            this.radio_pausada.TabStop = true;
            this.radio_pausada.Text = "Pausada";
            this.radio_pausada.UseVisualStyleBackColor = true;
            this.radio_pausada.CheckedChanged += new System.EventHandler(this.radio_pausada_CheckedChanged);
            // 
            // radio_activa
            // 
            this.radio_activa.AutoSize = true;
            this.radio_activa.Location = new System.Drawing.Point(36, 70);
            this.radio_activa.Name = "radio_activa";
            this.radio_activa.Size = new System.Drawing.Size(77, 24);
            this.radio_activa.TabIndex = 3;
            this.radio_activa.TabStop = true;
            this.radio_activa.Text = "Activa";
            this.radio_activa.UseVisualStyleBackColor = true;
            this.radio_activa.CheckedChanged += new System.EventHandler(this.radio_activa_CheckedChanged);
            // 
            // radio_borrador
            // 
            this.radio_borrador.AutoSize = true;
            this.radio_borrador.Location = new System.Drawing.Point(36, 25);
            this.radio_borrador.Name = "radio_borrador";
            this.radio_borrador.Size = new System.Drawing.Size(96, 24);
            this.radio_borrador.TabIndex = 2;
            this.radio_borrador.TabStop = true;
            this.radio_borrador.Text = "Borrador";
            this.radio_borrador.UseVisualStyleBackColor = true;
            this.radio_borrador.CheckedChanged += new System.EventHandler(this.radio_borrador_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_subasta);
            this.groupBox2.Controls.Add(this.radio_compra);
            this.groupBox2.Location = new System.Drawing.Point(530, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // radio_subasta
            // 
            this.radio_subasta.AutoSize = true;
            this.radio_subasta.Location = new System.Drawing.Point(18, 89);
            this.radio_subasta.Name = "radio_subasta";
            this.radio_subasta.Size = new System.Drawing.Size(94, 24);
            this.radio_subasta.TabIndex = 1;
            this.radio_subasta.TabStop = true;
            this.radio_subasta.Text = "Subasta";
            this.radio_subasta.UseVisualStyleBackColor = true;
            this.radio_subasta.CheckedChanged += new System.EventHandler(this.radio_subasta_CheckedChanged);
            // 
            // radio_compra
            // 
            this.radio_compra.AutoSize = true;
            this.radio_compra.Location = new System.Drawing.Point(18, 42);
            this.radio_compra.Name = "radio_compra";
            this.radio_compra.Size = new System.Drawing.Size(165, 24);
            this.radio_compra.TabIndex = 0;
            this.radio_compra.TabStop = true;
            this.radio_compra.Text = "Compra Inmediata";
            this.radio_compra.UseVisualStyleBackColor = true;
            this.radio_compra.CheckedChanged += new System.EventHandler(this.radio_compra_CheckedChanged);
            // 
            // text_descripcion
            // 
            this.text_descripcion.Location = new System.Drawing.Point(120, 32);
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(226, 26);
            this.text_descripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // text_visibilidad_id
            // 
            this.text_visibilidad_id.Location = new System.Drawing.Point(795, 110);
            this.text_visibilidad_id.Name = "text_visibilidad_id";
            this.text_visibilidad_id.Size = new System.Drawing.Size(100, 26);
            this.text_visibilidad_id.TabIndex = 1;
            // 
            // FormularioPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 602);
            this.Controls.Add(this.text_visibilidad_id);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioPublicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPublicacion";
            this.Load += new System.EventHandler(this.FormularioPublicacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_visibilidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radio_finalizada;
        private System.Windows.Forms.RadioButton radio_pausada;
        private System.Windows.Forms.RadioButton radio_activa;
        private System.Windows.Forms.RadioButton radio_borrador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_subasta;
        private System.Windows.Forms.RadioButton radio_compra;
        private System.Windows.Forms.TextBox text_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.CheckBox check_envio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox checklist_rubros;
        private System.Windows.Forms.DateTimePicker date_fin;
        private System.Windows.Forms.DateTimePicker date_inicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_precio;
        private System.Windows.Forms.TextBox text_stock;
        private System.Windows.Forms.CheckBox check_pregunta;
        private System.Windows.Forms.TextBox text_visibilidad_id;
    }
}