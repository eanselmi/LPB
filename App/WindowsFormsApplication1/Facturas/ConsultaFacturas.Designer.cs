namespace visibilidad.Facturas
{
    partial class ConsultaFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFacturas));
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
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelFechaDesde = new System.Windows.Forms.Label();
            this.labelFechaHasta = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.labelMontoDesde = new System.Windows.Forms.Label();
            this.labelMontoHasta = new System.Windows.Forms.Label();
            this.labelDetalle = new System.Windows.Forms.Label();
            this.textBoxFechaDesde = new System.Windows.Forms.TextBox();
            this.textBoxFechaHasta = new System.Windows.Forms.TextBox();
            this.textBoxMontoDesce = new System.Windows.Forms.TextBox();
            this.textBoxMontoHasta = new System.Windows.Forms.TextBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.superGridFacturas = new visibilidad.Historial_Cliente.SuperGrid();
            this.comboBoxDetalle = new System.Windows.Forms.ComboBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSeleccionarDesde = new System.Windows.Forms.Button();
            this.buttonSeleccionarHasta = new System.Windows.Forms.Button();
            this.monthCalendarDesde = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarHasta = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superGridFacturas)).BeginInit();
            this.SuspendLayout();
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
            this.bindingNavigator1.Location = new System.Drawing.Point(213, 560);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(211, 25);
            this.bindingNavigator1.TabIndex = 1;
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
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(60, 7);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(42, 13);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "FECHA";
            // 
            // labelFechaDesde
            // 
            this.labelFechaDesde.AutoSize = true;
            this.labelFechaDesde.Location = new System.Drawing.Point(104, 25);
            this.labelFechaDesde.Name = "labelFechaDesde";
            this.labelFechaDesde.Size = new System.Drawing.Size(44, 13);
            this.labelFechaDesde.TabIndex = 3;
            this.labelFechaDesde.Text = "Desde: ";
            // 
            // labelFechaHasta
            // 
            this.labelFechaHasta.AutoSize = true;
            this.labelFechaHasta.Location = new System.Drawing.Point(104, 63);
            this.labelFechaHasta.Name = "labelFechaHasta";
            this.labelFechaHasta.Size = new System.Drawing.Size(41, 13);
            this.labelFechaHasta.TabIndex = 4;
            this.labelFechaHasta.Text = "Hasta: ";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(56, 86);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(47, 13);
            this.labelMonto.TabIndex = 5;
            this.labelMonto.Text = "MONTO";
            // 
            // labelMontoDesde
            // 
            this.labelMontoDesde.AutoSize = true;
            this.labelMontoDesde.Location = new System.Drawing.Point(103, 99);
            this.labelMontoDesde.Name = "labelMontoDesde";
            this.labelMontoDesde.Size = new System.Drawing.Size(44, 13);
            this.labelMontoDesde.TabIndex = 6;
            this.labelMontoDesde.Text = "Desde: ";
            // 
            // labelMontoHasta
            // 
            this.labelMontoHasta.AutoSize = true;
            this.labelMontoHasta.Location = new System.Drawing.Point(247, 99);
            this.labelMontoHasta.Name = "labelMontoHasta";
            this.labelMontoHasta.Size = new System.Drawing.Size(41, 13);
            this.labelMontoHasta.TabIndex = 7;
            this.labelMontoHasta.Text = "Hasta: ";
            // 
            // labelDetalle
            // 
            this.labelDetalle.AutoSize = true;
            this.labelDetalle.Location = new System.Drawing.Point(103, 135);
            this.labelDetalle.Name = "labelDetalle";
            this.labelDetalle.Size = new System.Drawing.Size(46, 13);
            this.labelDetalle.TabIndex = 8;
            this.labelDetalle.Text = "Detalle: ";
            // 
            // textBoxFechaDesde
            // 
            this.textBoxFechaDesde.Enabled = false;
            this.textBoxFechaDesde.Location = new System.Drawing.Point(153, 23);
            this.textBoxFechaDesde.Name = "textBoxFechaDesde";
            this.textBoxFechaDesde.Size = new System.Drawing.Size(134, 20);
            this.textBoxFechaDesde.TabIndex = 10;
            // 
            // textBoxFechaHasta
            // 
            this.textBoxFechaHasta.Enabled = false;
            this.textBoxFechaHasta.Location = new System.Drawing.Point(153, 60);
            this.textBoxFechaHasta.Name = "textBoxFechaHasta";
            this.textBoxFechaHasta.Size = new System.Drawing.Size(134, 20);
            this.textBoxFechaHasta.TabIndex = 11;
            // 
            // textBoxMontoDesce
            // 
            this.textBoxMontoDesce.Location = new System.Drawing.Point(153, 96);
            this.textBoxMontoDesce.Name = "textBoxMontoDesce";
            this.textBoxMontoDesce.Size = new System.Drawing.Size(74, 20);
            this.textBoxMontoDesce.TabIndex = 12;
            // 
            // textBoxMontoHasta
            // 
            this.textBoxMontoHasta.Location = new System.Drawing.Point(294, 96);
            this.textBoxMontoHasta.Name = "textBoxMontoHasta";
            this.textBoxMontoHasta.Size = new System.Drawing.Size(74, 20);
            this.textBoxMontoHasta.TabIndex = 13;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(468, 31);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 16;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(468, 115);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 17;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // superGridFacturas
            // 
            this.superGridFacturas.AllowUserToAddRows = false;
            this.superGridFacturas.AllowUserToDeleteRows = false;
            this.superGridFacturas.AllowUserToOrderColumns = true;
            this.superGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.superGridFacturas.Location = new System.Drawing.Point(12, 165);
            this.superGridFacturas.Name = "superGridFacturas";
            this.superGridFacturas.PageSize = 10;
            this.superGridFacturas.ReadOnly = true;
            this.superGridFacturas.RowHeadersVisible = false;
            this.superGridFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.superGridFacturas.Size = new System.Drawing.Size(635, 382);
            this.superGridFacturas.TabIndex = 0;
            // 
            // comboBoxDetalle
            // 
            this.comboBoxDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDetalle.FormattingEnabled = true;
            this.comboBoxDetalle.Items.AddRange(new object[] {
            "Comisión por venta",
            "Costo por publicación",
            "Costo por envío"});
            this.comboBoxDetalle.Location = new System.Drawing.Point(153, 132);
            this.comboBoxDetalle.Name = "comboBoxDetalle";
            this.comboBoxDetalle.Size = new System.Drawing.Size(215, 21);
            this.comboBoxDetalle.TabIndex = 19;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(468, 73);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 20;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonSeleccionarDesde
            // 
            this.buttonSeleccionarDesde.Location = new System.Drawing.Point(294, 23);
            this.buttonSeleccionarDesde.Name = "buttonSeleccionarDesde";
            this.buttonSeleccionarDesde.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionarDesde.TabIndex = 23;
            this.buttonSeleccionarDesde.Text = "Seleccionar";
            this.buttonSeleccionarDesde.UseVisualStyleBackColor = true;
            // 
            // buttonSeleccionarHasta
            // 
            this.buttonSeleccionarHasta.Location = new System.Drawing.Point(293, 60);
            this.buttonSeleccionarHasta.Name = "buttonSeleccionarHasta";
            this.buttonSeleccionarHasta.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionarHasta.TabIndex = 24;
            this.buttonSeleccionarHasta.Text = "Seleccionar";
            this.buttonSeleccionarHasta.UseVisualStyleBackColor = true;
            // 
            // monthCalendarDesde
            // 
            this.monthCalendarDesde.Location = new System.Drawing.Point(381, 23);
            this.monthCalendarDesde.Name = "monthCalendarDesde";
            this.monthCalendarDesde.TabIndex = 25;
            this.monthCalendarDesde.Visible = false;
            // 
            // monthCalendarHasta
            // 
            this.monthCalendarHasta.Location = new System.Drawing.Point(381, 60);
            this.monthCalendarHasta.Name = "monthCalendarHasta";
            this.monthCalendarHasta.TabIndex = 26;
            this.monthCalendarHasta.Visible = false;
            // 
            // ConsultaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 594);
            this.Controls.Add(this.monthCalendarHasta);
            this.Controls.Add(this.monthCalendarDesde);
            this.Controls.Add(this.buttonSeleccionarHasta);
            this.Controls.Add(this.buttonSeleccionarDesde);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.comboBoxDetalle);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.textBoxMontoHasta);
            this.Controls.Add(this.textBoxMontoDesce);
            this.Controls.Add(this.textBoxFechaHasta);
            this.Controls.Add(this.textBoxFechaDesde);
            this.Controls.Add(this.labelDetalle);
            this.Controls.Add(this.labelMontoHasta);
            this.Controls.Add(this.labelMontoDesde);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelFechaHasta);
            this.Controls.Add(this.labelFechaDesde);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.superGridFacturas);
            this.Name = "ConsultaFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas realizadas al vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superGridFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Historial_Cliente.SuperGrid superGridFacturas;
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
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelFechaDesde;
        private System.Windows.Forms.Label labelFechaHasta;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Label labelMontoDesde;
        private System.Windows.Forms.Label labelMontoHasta;
        private System.Windows.Forms.Label labelDetalle;
        private System.Windows.Forms.TextBox textBoxFechaDesde;
        private System.Windows.Forms.TextBox textBoxFechaHasta;
        private System.Windows.Forms.TextBox textBoxMontoDesce;
        private System.Windows.Forms.TextBox textBoxMontoHasta;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ComboBox comboBoxDetalle;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSeleccionarDesde;
        private System.Windows.Forms.Button buttonSeleccionarHasta;
        private System.Windows.Forms.MonthCalendar monthCalendarDesde;
        private System.Windows.Forms.MonthCalendar monthCalendarHasta;
    }
}