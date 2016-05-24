using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.ABM_Visibilidad
{
    public partial class AltaVisibilidad : Form
    {
        public AltaVisibilidad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void check_comision_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            String msg_precio = validateTextDouble("Precio", tbox_precio, e);
            if(msg_precio!="")
            MessageBox.Show(msg_precio, "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tbox_descr_TextChanged(object sender, EventArgs e)
        {

        }

        private String validateTextDouble(String texto, object sender, EventArgs e)
        {
            String msg = "";
            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    decimal x = decimal.Parse(T.Text);  
                }
            }
            catch (Exception)
            {
                msg = "El campo "+texto+" debe ser un número";
            }

            return msg;
        }

        private void AltaVisibilidad_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.TopMost = true;
        } 
    }
}
