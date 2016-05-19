namespace MercadoEnvio.Abm_Rol
{
    partial class ABMRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMRol));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_habilitado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_rol = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_seleccionar_todo = new System.Windows.Forms.Button();
            this.checkedList_funciones = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_habilitado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_rol);
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(412, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Rol";
            // 
            // checkBox_habilitado
            // 
            this.checkBox_habilitado.AutoSize = true;
            this.checkBox_habilitado.Location = new System.Drawing.Point(297, 40);
            this.checkBox_habilitado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_habilitado.Name = "checkBox_habilitado";
            this.checkBox_habilitado.Size = new System.Drawing.Size(106, 24);
            this.checkBox_habilitado.TabIndex = 2;
            this.checkBox_habilitado.Text = "Habilitado";
            this.checkBox_habilitado.UseVisualStyleBackColor = true;
            this.checkBox_habilitado.Visible = false;
            this.checkBox_habilitado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Rol";
            // 
            // text_rol
            // 
            this.text_rol.Location = new System.Drawing.Point(138, 35);
            this.text_rol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_rol.Name = "text_rol";
            this.text_rol.Size = new System.Drawing.Size(148, 26);
            this.text_rol.TabIndex = 0;
            this.text_rol.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_seleccionar_todo);
            this.groupBox2.Controls.Add(this.checkedList_funciones);
            this.groupBox2.Location = new System.Drawing.Point(18, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(412, 369);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionalidades para el Rol";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(249, 322);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(154, 35);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "Limpiar Seleccion";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_seleccionar_todo
            // 
            this.btn_seleccionar_todo.Location = new System.Drawing.Point(18, 322);
            this.btn_seleccionar_todo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_seleccionar_todo.Name = "btn_seleccionar_todo";
            this.btn_seleccionar_todo.Size = new System.Drawing.Size(154, 35);
            this.btn_seleccionar_todo.TabIndex = 1;
            this.btn_seleccionar_todo.Text = "Seleccionar Todo";
            this.btn_seleccionar_todo.UseVisualStyleBackColor = true;
            this.btn_seleccionar_todo.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedList_funciones
            // 
            this.checkedList_funciones.FormattingEnabled = true;
            this.checkedList_funciones.Location = new System.Drawing.Point(14, 29);
            this.checkedList_funciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedList_funciones.Name = "checkedList_funciones";
            this.checkedList_funciones.Size = new System.Drawing.Size(388, 277);
            this.checkedList_funciones.TabIndex = 0;
            this.checkedList_funciones.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_salir);
            this.groupBox3.Controls.Add(this.btn_grabar);
            this.groupBox3.Location = new System.Drawing.Point(21, 486);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(412, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(224, 29);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(180, 35);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(15, 29);
            this.btn_grabar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(180, 35);
            this.btn_grabar.TabIndex = 3;
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ABMRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMRol";
            this.Load += new System.EventHandler(this.ABMRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_rol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedList_funciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.CheckBox checkBox_habilitado;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_seleccionar_todo;
    }
}