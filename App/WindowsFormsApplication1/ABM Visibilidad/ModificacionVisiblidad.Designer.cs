namespace visibilidad.ABM_Visibilidad
{
    partial class ModificacionVisiblidad
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
            this.label_aviso = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.check_comision = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_porc = new System.Windows.Forms.TextBox();
            this.label_porc = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tbox_precio = new System.Windows.Forms.TextBox();
            this.label_precio = new System.Windows.Forms.Label();
            this.tbox_descr = new System.Windows.Forms.TextBox();
            this.label_descr = new System.Windows.Forms.Label();
            this.label_codigo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_aviso
            // 
            this.label_aviso.AutoSize = true;
            this.label_aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aviso.Location = new System.Drawing.Point(12, 189);
            this.label_aviso.Name = "label_aviso";
            this.label_aviso.Size = new System.Drawing.Size(110, 13);
            this.label_aviso.TabIndex = 21;
            this.label_aviso.Text = "* Campos Obligatorios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_cancelar);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Location = new System.Drawing.Point(15, 129);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(301, 55);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(152, 17);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(139, 28);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(8, 17);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(139, 28);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // check_comision
            // 
            this.check_comision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.check_comision.AutoSize = true;
            this.check_comision.Location = new System.Drawing.Point(12, 103);
            this.check_comision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_comision.Name = "check_comision";
            this.check_comision.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.check_comision.Size = new System.Drawing.Size(156, 21);
            this.check_comision.TabIndex = 19;
            this.check_comision.Text = "*Comisión por Envío";
            this.check_comision.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "%";
            // 
            // tbox_porc
            // 
            this.tbox_porc.Location = new System.Drawing.Point(239, 77);
            this.tbox_porc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_porc.Name = "tbox_porc";
            this.tbox_porc.Size = new System.Drawing.Size(72, 22);
            this.tbox_porc.TabIndex = 17;
            // 
            // label_porc
            // 
            this.label_porc.AutoSize = true;
            this.label_porc.Location = new System.Drawing.Point(12, 76);
            this.label_porc.Name = "label_porc";
            this.label_porc.Size = new System.Drawing.Size(81, 17);
            this.label_porc.TabIndex = 16;
            this.label_porc.Text = "Porcentaje*";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(196, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 17);
            this.label.TabIndex = 15;
            this.label.Text = "AR$";
            // 
            // tbox_precio
            // 
            this.tbox_precio.Location = new System.Drawing.Point(239, 48);
            this.tbox_precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_precio.Name = "tbox_precio";
            this.tbox_precio.Size = new System.Drawing.Size(72, 22);
            this.tbox_precio.TabIndex = 14;
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(12, 48);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(53, 17);
            this.label_precio.TabIndex = 13;
            this.label_precio.Text = "Precio*";
            // 
            // tbox_descr
            // 
            this.tbox_descr.Location = new System.Drawing.Point(145, 20);
            this.tbox_descr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_descr.Name = "tbox_descr";
            this.tbox_descr.Size = new System.Drawing.Size(167, 22);
            this.tbox_descr.TabIndex = 12;
            // 
            // label_descr
            // 
            this.label_descr.AutoSize = true;
            this.label_descr.Location = new System.Drawing.Point(12, 20);
            this.label_descr.Name = "label_descr";
            this.label_descr.Size = new System.Drawing.Size(87, 17);
            this.label_descr.TabIndex = 11;
            this.label_descr.Text = "Descripción*";
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Location = new System.Drawing.Point(245, 189);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(0, 17);
            this.label_codigo.TabIndex = 22;
            this.label_codigo.Visible = false;
            // 
            // ModificacionVisiblidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 209);
            this.Controls.Add(this.label_codigo);
            this.Controls.Add(this.label_aviso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.check_comision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_porc);
            this.Controls.Add(this.label_porc);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbox_precio);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.tbox_descr);
            this.Controls.Add(this.label_descr);
            this.Name = "ModificacionVisiblidad";
            this.Text = "Editar visibilidad";
            this.Load += new System.EventHandler(this.ModificacionVisiblidad_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_aviso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.CheckBox check_comision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_porc;
        private System.Windows.Forms.Label label_porc;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbox_precio;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.TextBox tbox_descr;
        private System.Windows.Forms.Label label_descr;
        private System.Windows.Forms.Label label_codigo;
    }
}