namespace visibilidad
{
    partial class Modificar_pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_pass));
            this.labelviejaPass = new System.Windows.Forms.Label();
            this.textBoxViejaPass = new System.Windows.Forms.TextBox();
            this.textBoxNuevaPass = new System.Windows.Forms.TextBox();
            this.labelnuevaPass = new System.Windows.Forms.Label();
            this.textBoxConfirmarPass = new System.Windows.Forms.TextBox();
            this.labelconfirmarPass = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelviejaPass
            // 
            this.labelviejaPass.AutoSize = true;
            this.labelviejaPass.Location = new System.Drawing.Point(66, 46);
            this.labelviejaPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelviejaPass.Name = "labelviejaPass";
            this.labelviejaPass.Size = new System.Drawing.Size(125, 20);
            this.labelviejaPass.TabIndex = 0;
            this.labelviejaPass.Text = "Vieja Password: ";
            // 
            // textBoxViejaPass
            // 
            this.textBoxViejaPass.Location = new System.Drawing.Point(226, 42);
            this.textBoxViejaPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxViejaPass.Name = "textBoxViejaPass";
            this.textBoxViejaPass.PasswordChar = '*';
            this.textBoxViejaPass.Size = new System.Drawing.Size(148, 26);
            this.textBoxViejaPass.TabIndex = 1;
            // 
            // textBoxNuevaPass
            // 
            this.textBoxNuevaPass.Location = new System.Drawing.Point(226, 100);
            this.textBoxNuevaPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNuevaPass.Name = "textBoxNuevaPass";
            this.textBoxNuevaPass.PasswordChar = '*';
            this.textBoxNuevaPass.Size = new System.Drawing.Size(148, 26);
            this.textBoxNuevaPass.TabIndex = 3;
            // 
            // labelnuevaPass
            // 
            this.labelnuevaPass.AutoSize = true;
            this.labelnuevaPass.Location = new System.Drawing.Point(66, 105);
            this.labelnuevaPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnuevaPass.Name = "labelnuevaPass";
            this.labelnuevaPass.Size = new System.Drawing.Size(135, 20);
            this.labelnuevaPass.TabIndex = 2;
            this.labelnuevaPass.Text = "Nueva Password: ";
            // 
            // textBoxConfirmarPass
            // 
            this.textBoxConfirmarPass.Location = new System.Drawing.Point(226, 151);
            this.textBoxConfirmarPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxConfirmarPass.Name = "textBoxConfirmarPass";
            this.textBoxConfirmarPass.PasswordChar = '*';
            this.textBoxConfirmarPass.Size = new System.Drawing.Size(148, 26);
            this.textBoxConfirmarPass.TabIndex = 5;
            // 
            // labelconfirmarPass
            // 
            this.labelconfirmarPass.AutoSize = true;
            this.labelconfirmarPass.Location = new System.Drawing.Point(66, 155);
            this.labelconfirmarPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelconfirmarPass.Name = "labelconfirmarPass";
            this.labelconfirmarPass.Size = new System.Drawing.Size(159, 20);
            this.labelconfirmarPass.TabIndex = 4;
            this.labelconfirmarPass.Text = "Confirmar Password: ";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(70, 240);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(112, 35);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(264, 240);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(112, 35);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Modificar_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 308);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxConfirmarPass);
            this.Controls.Add(this.labelconfirmarPass);
            this.Controls.Add(this.textBoxNuevaPass);
            this.Controls.Add(this.labelnuevaPass);
            this.Controls.Add(this.textBoxViejaPass);
            this.Controls.Add(this.labelviejaPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Modificar_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar la password";
            this.Load += new System.EventHandler(this.Modificar_pass_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelviejaPass;
        private System.Windows.Forms.TextBox textBoxViejaPass;
        private System.Windows.Forms.TextBox textBoxNuevaPass;
        private System.Windows.Forms.Label labelnuevaPass;
        private System.Windows.Forms.TextBox textBoxConfirmarPass;
        private System.Windows.Forms.Label labelconfirmarPass;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonSalir;
    }
}