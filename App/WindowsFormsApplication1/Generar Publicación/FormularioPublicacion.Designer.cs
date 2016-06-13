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
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.text_visibilidad_id = new System.Windows.Forms.TextBox();
            this.text_precio_aux = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(497, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // check_pregunta
            // 
            this.check_pregunta.AutoSize = true;
            this.check_pregunta.Location = new System.Drawing.Point(158, 152);
            this.check_pregunta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_pregunta.Name = "check_pregunta";
            this.check_pregunta.Size = new System.Drawing.Size(111, 17);
            this.check_pregunta.TabIndex = 23;
            this.check_pregunta.Text = "Acepta Preguntas";
            this.check_pregunta.UseVisualStyleBackColor = true;
            this.check_pregunta.CheckedChanged += new System.EventHandler(this.check_pregunta_CheckedChanged_1);
            // 
            // text_stock
            // 
            this.text_stock.Location = new System.Drawing.Point(77, 109);
            this.text_stock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(68, 20);
            this.text_stock.TabIndex = 22;
            this.text_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // text_precio
            // 
            this.text_precio.Location = new System.Drawing.Point(77, 149);
            this.text_precio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(68, 20);
            this.text_precio.TabIndex = 21;
            this.text_precio.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // check_envio
            // 
            this.check_envio.AutoSize = true;
            this.check_envio.Location = new System.Drawing.Point(158, 112);
            this.check_envio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_envio.Name = "check_envio";
            this.check_envio.Size = new System.Drawing.Size(90, 17);
            this.check_envio.TabIndex = 16;
            this.check_envio.Text = "Acepta Envio";
            this.check_envio.UseVisualStyleBackColor = true;
            this.check_envio.CheckedChanged += new System.EventHandler(this.check_envio_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checklist_rubros);
            this.groupBox4.Location = new System.Drawing.Point(17, 257);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(462, 196);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rubros";
            // 
            // checklist_rubros
            // 
            this.checklist_rubros.FormattingEnabled = true;
            this.checklist_rubros.Location = new System.Drawing.Point(12, 16);
            this.checklist_rubros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checklist_rubros.Name = "checklist_rubros";
            this.checklist_rubros.Size = new System.Drawing.Size(439, 154);
            this.checklist_rubros.TabIndex = 0;
            // 
            // date_fin
            // 
            this.date_fin.Enabled = false;
            this.date_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fin.Location = new System.Drawing.Point(235, 194);
            this.date_fin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(93, 20);
            this.date_fin.TabIndex = 13;
            // 
            // date_inicio
            // 
            this.date_inicio.Enabled = false;
            this.date_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_inicio.Location = new System.Drawing.Point(82, 194);
            this.date_inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_inicio.Name = "date_inicio";
            this.date_inicio.Size = new System.Drawing.Size(93, 20);
            this.date_inicio.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock";
            // 
            // cmb_visibilidad
            // 
            this.cmb_visibilidad.FormattingEnabled = true;
            this.cmb_visibilidad.Location = new System.Drawing.Point(80, 62);
            this.cmb_visibilidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_visibilidad.Name = "cmb_visibilidad";
            this.cmb_visibilidad.Size = new System.Drawing.Size(152, 21);
            this.cmb_visibilidad.TabIndex = 5;
            this.cmb_visibilidad.SelectedIndexChanged += new System.EventHandler(this.cmb_visibilidad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Visibilidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio_finalizada);
            this.groupBox3.Controls.Add(this.radio_pausada);
            this.groupBox3.Controls.Add(this.radio_activa);
            this.groupBox3.Controls.Add(this.radio_borrador);
            this.groupBox3.Location = new System.Drawing.Point(353, 113);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(126, 133);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado";
            // 
            // radio_finalizada
            // 
            this.radio_finalizada.AutoSize = true;
            this.radio_finalizada.Enabled = false;
            this.radio_finalizada.Location = new System.Drawing.Point(24, 104);
            this.radio_finalizada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_finalizada.Name = "radio_finalizada";
            this.radio_finalizada.Size = new System.Drawing.Size(72, 17);
            this.radio_finalizada.TabIndex = 5;
            this.radio_finalizada.TabStop = true;
            this.radio_finalizada.Text = "Finalizada";
            this.radio_finalizada.UseVisualStyleBackColor = true;
            this.radio_finalizada.CheckedChanged += new System.EventHandler(this.radio_finalizada_CheckedChanged);
            // 
            // radio_pausada
            // 
            this.radio_pausada.AutoSize = true;
            this.radio_pausada.Enabled = false;
            this.radio_pausada.Location = new System.Drawing.Point(24, 73);
            this.radio_pausada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_pausada.Name = "radio_pausada";
            this.radio_pausada.Size = new System.Drawing.Size(67, 17);
            this.radio_pausada.TabIndex = 4;
            this.radio_pausada.TabStop = true;
            this.radio_pausada.Text = "Pausada";
            this.radio_pausada.UseVisualStyleBackColor = true;
            this.radio_pausada.CheckedChanged += new System.EventHandler(this.radio_pausada_CheckedChanged);
            // 
            // radio_activa
            // 
            this.radio_activa.AutoSize = true;
            this.radio_activa.Location = new System.Drawing.Point(24, 45);
            this.radio_activa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_activa.Name = "radio_activa";
            this.radio_activa.Size = new System.Drawing.Size(55, 17);
            this.radio_activa.TabIndex = 3;
            this.radio_activa.TabStop = true;
            this.radio_activa.Text = "Activa";
            this.radio_activa.UseVisualStyleBackColor = true;
            this.radio_activa.CheckedChanged += new System.EventHandler(this.radio_activa_CheckedChanged);
            // 
            // radio_borrador
            // 
            this.radio_borrador.AutoSize = true;
            this.radio_borrador.Location = new System.Drawing.Point(24, 16);
            this.radio_borrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_borrador.Name = "radio_borrador";
            this.radio_borrador.Size = new System.Drawing.Size(65, 17);
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
            this.groupBox2.Location = new System.Drawing.Point(353, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(126, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // radio_subasta
            // 
            this.radio_subasta.AutoSize = true;
            this.radio_subasta.Location = new System.Drawing.Point(12, 58);
            this.radio_subasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_subasta.Name = "radio_subasta";
            this.radio_subasta.Size = new System.Drawing.Size(64, 17);
            this.radio_subasta.TabIndex = 1;
            this.radio_subasta.TabStop = true;
            this.radio_subasta.Text = "Subasta";
            this.radio_subasta.UseVisualStyleBackColor = true;
            this.radio_subasta.CheckedChanged += new System.EventHandler(this.radio_subasta_CheckedChanged);
            // 
            // radio_compra
            // 
            this.radio_compra.AutoSize = true;
            this.radio_compra.Location = new System.Drawing.Point(12, 27);
            this.radio_compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_compra.Name = "radio_compra";
            this.radio_compra.Size = new System.Drawing.Size(110, 17);
            this.radio_compra.TabIndex = 0;
            this.radio_compra.TabStop = true;
            this.radio_compra.Text = "Compra Inmediata";
            this.radio_compra.UseVisualStyleBackColor = true;
            this.radio_compra.CheckedChanged += new System.EventHandler(this.radio_compra_CheckedChanged);
            // 
            // text_descripcion
            // 
            this.text_descripcion.Location = new System.Drawing.Point(80, 21);
            this.text_descripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(152, 20);
            this.text_descripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(395, 477);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(110, 23);
            this.btn_volver.TabIndex = 19;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(205, 477);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(110, 23);
            this.btn_limpiar.TabIndex = 18;
            this.btn_limpiar.Text = "Reestablecer";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(8, 477);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 23);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // text_visibilidad_id
            // 
            this.text_visibilidad_id.Location = new System.Drawing.Point(530, 71);
            this.text_visibilidad_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_visibilidad_id.Name = "text_visibilidad_id";
            this.text_visibilidad_id.Size = new System.Drawing.Size(68, 20);
            this.text_visibilidad_id.TabIndex = 1;
            this.text_visibilidad_id.Visible = false;
            // 
            // text_precio_aux
            // 
            this.text_precio_aux.Location = new System.Drawing.Point(530, 157);
            this.text_precio_aux.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_precio_aux.Name = "text_precio_aux";
            this.text_precio_aux.Size = new System.Drawing.Size(68, 20);
            this.text_precio_aux.TabIndex = 2;
            this.text_precio_aux.Visible = false;
            // 
            // FormularioPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(519, 506);
            this.Controls.Add(this.text_precio_aux);
            this.Controls.Add(this.text_visibilidad_id);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox text_precio_aux;
    }
}