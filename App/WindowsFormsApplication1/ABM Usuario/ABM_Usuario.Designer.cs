namespace MercadoEnvio.ABM_Usuario
{
    partial class ABM_Usuario
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

        private void InitializeComponent(){
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Modificacion = new System.Windows.Forms.Button();
            this.btn_VolverAlMenu = new System.Windows.Forms.Button();
            this.grp_Alta = new System.Windows.Forms.GroupBox();
            this.grp_ABM = new System.Windows.Forms.GroupBox();
            this.grp_Alta.SuspendLayout();
            this.grp_ABM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(210, 93);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(122, 41);
            this.btn_Alta.TabIndex = 0;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(210, 180);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(122, 41);
            this.btn_Baja.TabIndex = 1;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            // 
            // btn_Modificacion
            // 
            this.btn_Modificacion.Location = new System.Drawing.Point(210, 265);
            this.btn_Modificacion.Name = "btn_Modificacion";
            this.btn_Modificacion.Size = new System.Drawing.Size(122, 41);
            this.btn_Modificacion.TabIndex = 2;
            this.btn_Modificacion.Text = "Modificación";
            this.btn_Modificacion.UseVisualStyleBackColor = true;
            // 
            // btn_VolverAlMenu
            // 
            this.btn_VolverAlMenu.Location = new System.Drawing.Point(367, 366);
            this.btn_VolverAlMenu.Name = "btn_VolverAlMenu";
            this.btn_VolverAlMenu.Size = new System.Drawing.Size(147, 35);
            this.btn_VolverAlMenu.TabIndex = 3;
            this.btn_VolverAlMenu.Text = "Volver al menú principal";
            this.btn_VolverAlMenu.UseVisualStyleBackColor = true;
            // 
            // grp_Alta
            // 
            this.grp_Alta.Controls.Add(this.grp_ABM);
            this.grp_Alta.Location = new System.Drawing.Point(0, 0);
            this.grp_Alta.Name = "grp_Alta";
            this.grp_Alta.Size = new System.Drawing.Size(558, 430);
            this.grp_Alta.TabIndex = 4;
            this.grp_Alta.TabStop = false;
            this.grp_Alta.Text = "Alta de usuario";
            this.grp_Alta.Visible = false;
            // 
            // grp_ABM
            // 
            this.grp_ABM.Location = new System.Drawing.Point(0, 0);
            this.grp_ABM.Name = "grp_ABM";
            this.grp_ABM.Size = new System.Drawing.Size(558, 430);
            this.grp_ABM.Controls.Add(this.btn_Alta);
            this.grp_ABM.Controls.Add(this.btn_Baja);
            this.grp_ABM.Controls.Add(this.btn_Modificacion);
            this.grp_ABM.Controls.Add(this.btn_VolverAlMenu);
            this.grp_ABM.TabIndex = 0;
            this.grp_ABM.TabStop = false;
            this.grp_ABM.Text = "grp_ABM";
            this.grp_ABM.Visible = true;

            // 
            // ABM_Usuario
            // 
            this.ClientSize = new System.Drawing.Size(557, 428);
            this.Controls.Add(this.grp_Alta);
            this.Controls.Add(this.btn_VolverAlMenu);
            this.Controls.Add(this.btn_Modificacion);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Alta);
            this.Name = "ABM_Usuario";
            this.Text = "ABM de Usuario";
            this.grp_Alta.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Modificacion;
        private System.Windows.Forms.Button btn_VolverAlMenu;
        private System.Windows.Forms.GroupBox grp_Alta;
        private System.Windows.Forms.GroupBox grp_ABM;
    }
}