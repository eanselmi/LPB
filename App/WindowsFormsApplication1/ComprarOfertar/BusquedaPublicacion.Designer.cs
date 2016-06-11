﻿namespace visibilidad.ComprarOfertar
 {
     partial class BusquedaPublicacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaPublicacion));
            this.group_buscar = new System.Windows.Forms.GroupBox();
            this.btn_todas = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label_rubro = new System.Windows.Forms.Label();
            this.tbox_descr = new System.Windows.Forms.TextBox();
            this.checklist_rubros = new System.Windows.Forms.CheckedListBox();
            this.label_palabrasclave = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.superGridPublis = new visibilidad.Historial_Cliente.SuperGrid();
            this.checkbox_envio = new System.Windows.Forms.CheckBox();
            this.tbox_cant = new System.Windows.Forms.TextBox();
            this.label_cantidad = new System.Windows.Forms.Label();
            this.btn_pregunta = new System.Windows.Forms.Button();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.group_buscar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superGridPublis)).BeginInit();
            this.SuspendLayout();
            // 
            // group_buscar
            // 
            this.group_buscar.BackColor = System.Drawing.Color.Transparent;
            this.group_buscar.Controls.Add(this.btn_todas);
            this.group_buscar.Controls.Add(this.btn_limpiar);
            this.group_buscar.Controls.Add(this.label_rubro);
            this.group_buscar.Controls.Add(this.tbox_descr);
            this.group_buscar.Controls.Add(this.checklist_rubros);
            this.group_buscar.Controls.Add(this.label_palabrasclave);
            this.group_buscar.Controls.Add(this.btn_volver);
            this.group_buscar.Controls.Add(this.btn_buscar);
            this.group_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.group_buscar.Location = new System.Drawing.Point(9, 9);
            this.group_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.group_buscar.Name = "group_buscar";
            this.group_buscar.Padding = new System.Windows.Forms.Padding(2);
            this.group_buscar.Size = new System.Drawing.Size(660, 165);
            this.group_buscar.TabIndex = 4;
            this.group_buscar.TabStop = false;
            this.group_buscar.Text = "Búsqueda de Publicaciones";
            // 
            // btn_todas
            // 
            this.btn_todas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_todas.Location = new System.Drawing.Point(536, 94);
            this.btn_todas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_todas.Name = "btn_todas";
            this.btn_todas.Size = new System.Drawing.Size(112, 24);
            this.btn_todas.TabIndex = 9;
            this.btn_todas.Text = "Todas";
            this.btn_todas.UseVisualStyleBackColor = true;
            this.btn_todas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_limpiar.Location = new System.Drawing.Point(536, 61);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(112, 24);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label_rubro
            // 
            this.label_rubro.AutoSize = true;
            this.label_rubro.Location = new System.Drawing.Point(14, 59);
            this.label_rubro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rubro.Name = "label_rubro";
            this.label_rubro.Size = new System.Drawing.Size(54, 17);
            this.label_rubro.TabIndex = 7;
            this.label_rubro.Text = "Rubros";
            // 
            // tbox_descr
            // 
            this.tbox_descr.Location = new System.Drawing.Point(118, 29);
            this.tbox_descr.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_descr.Name = "tbox_descr";
            this.tbox_descr.Size = new System.Drawing.Size(407, 23);
            this.tbox_descr.TabIndex = 6;
            this.tbox_descr.TextChanged += new System.EventHandler(this.tbox_descr_TextChanged);
            // 
            // checklist_rubros
            // 
            this.checklist_rubros.CheckOnClick = true;
            this.checklist_rubros.FormattingEnabled = true;
            this.checklist_rubros.Location = new System.Drawing.Point(118, 59);
            this.checklist_rubros.Margin = new System.Windows.Forms.Padding(2);
            this.checklist_rubros.Name = "checklist_rubros";
            this.checklist_rubros.Size = new System.Drawing.Size(407, 76);
            this.checklist_rubros.TabIndex = 5;
            this.checklist_rubros.SelectedIndexChanged += new System.EventHandler(this.checklist_rubros_SelectedIndexChanged);
            // 
            // label_palabrasclave
            // 
            this.label_palabrasclave.AutoSize = true;
            this.label_palabrasclave.Location = new System.Drawing.Point(14, 29);
            this.label_palabrasclave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_palabrasclave.Name = "label_palabrasclave";
            this.label_palabrasclave.Size = new System.Drawing.Size(82, 17);
            this.label_palabrasclave.TabIndex = 4;
            this.label_palabrasclave.Text = "Descripción";
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_volver.Location = new System.Drawing.Point(536, 128);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(2);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(112, 24);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_buscar.Location = new System.Drawing.Point(536, 28);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(112, 24);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.superGridPublis);
            this.groupBox1.Controls.Add(this.checkbox_envio);
            this.groupBox1.Controls.Add(this.tbox_cant);
            this.groupBox1.Controls.Add(this.label_cantidad);
            this.groupBox1.Controls.Add(this.btn_pregunta);
            this.groupBox1.Controls.Add(this.btn_comprar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(9, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(660, 422);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de Publicaciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(133, 390);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(211, 25);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // superGridPublis
            // 
            //
            this.superGridPublis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.superGridPublis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.superGridPublis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.superGridPublis.MultiSelect = false;
            this.superGridPublis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.superGridPublis.AllowUserToAddRows = false;
            this.superGridPublis.AllowUserToDeleteRows = false;
            this.superGridPublis.AllowUserToOrderColumns = true;
            this.superGridPublis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.superGridPublis.Location = new System.Drawing.Point(5, 30);
            this.superGridPublis.Name = "superGridPublis";
            this.superGridPublis.PageSize = 14;
            this.superGridPublis.ReadOnly = true;
            this.superGridPublis.RowHeadersVisible = false;
            this.superGridPublis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.superGridPublis.Size = new System.Drawing.Size(520, 357);
            this.superGridPublis.TabIndex = 15;
            // 
            // checkbox_envio
            // 
            this.checkbox_envio.AutoSize = true;
            this.checkbox_envio.Enabled = false;
            this.checkbox_envio.Location = new System.Drawing.Point(536, 191);
            this.checkbox_envio.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_envio.Name = "checkbox_envio";
            this.checkbox_envio.Size = new System.Drawing.Size(115, 21);
            this.checkbox_envio.TabIndex = 14;
            this.checkbox_envio.Text = "Solicitar envío";
            this.checkbox_envio.UseVisualStyleBackColor = true;
            // 
            // tbox_cant
            // 
            this.tbox_cant.Location = new System.Drawing.Point(596, 120);
            this.tbox_cant.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_cant.Name = "tbox_cant";
            this.tbox_cant.Size = new System.Drawing.Size(54, 23);
            this.tbox_cant.TabIndex = 12;
            this.tbox_cant.Text = "1";
            // 
            // label_cantidad
            // 
            this.label_cantidad.AutoSize = true;
            this.label_cantidad.Location = new System.Drawing.Point(532, 123);
            this.label_cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cantidad.Name = "label_cantidad";
            this.label_cantidad.Size = new System.Drawing.Size(64, 17);
            this.label_cantidad.TabIndex = 11;
            this.label_cantidad.Text = "Cantidad";
            // 
            // btn_pregunta
            // 
            this.btn_pregunta.Enabled = false;
            this.btn_pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pregunta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pregunta.Location = new System.Drawing.Point(536, 48);
            this.btn_pregunta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pregunta.Name = "btn_pregunta";
            this.btn_pregunta.Size = new System.Drawing.Size(112, 60);
            this.btn_pregunta.TabIndex = 9;
            this.btn_pregunta.Text = "Realizar Pregunta";
            this.btn_pregunta.UseVisualStyleBackColor = true;
            this.btn_pregunta.Click += new System.EventHandler(this.btn_pregunta_Click);
            // 
            // btn_comprar
            // 
            this.btn_comprar.Enabled = false;
            this.btn_comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_comprar.Location = new System.Drawing.Point(536, 154);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(112, 24);
            this.btn_comprar.TabIndex = 8;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // BusquedaPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group_buscar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BusquedaPublicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Publicaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group_buscar.ResumeLayout(false);
            this.group_buscar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superGridPublis)).EndInit();
            this.ResumeLayout(false);

         }

         #endregion

         public System.Windows.Forms.GroupBox group_buscar;
         private System.Windows.Forms.Label label_rubro;
         private System.Windows.Forms.TextBox tbox_descr;
         private System.Windows.Forms.CheckedListBox checklist_rubros;
         private System.Windows.Forms.Label label_palabrasclave;
         private System.Windows.Forms.Button btn_volver;
         private System.Windows.Forms.Button btn_buscar;
         public System.Windows.Forms.GroupBox groupBox1;
         private System.Windows.Forms.Button btn_pregunta;
         private System.Windows.Forms.Button btn_comprar;
         private System.Windows.Forms.Button btn_limpiar;
         private System.Windows.Forms.Button btn_todas;
         private System.Windows.Forms.TextBox tbox_cant;
         private System.Windows.Forms.Label label_cantidad;
         private System.Windows.Forms.CheckBox checkbox_envio;
         private Historial_Cliente.SuperGrid superGridPublis;
         private System.Windows.Forms.BindingNavigator bindingNavigator1;
         private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
         private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
         private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
         private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
         private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
         private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
         private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
         private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
         private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
     }
 }