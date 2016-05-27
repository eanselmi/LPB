using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visibilidad.Generar_Publicación
{
    public partial class FormularioPublicacion : Form
    {
        public Generar_Publicación.GenerarPublicacion generar;
        public FormularioPublicacion(Generar_Publicación.GenerarPublicacion form)
        {
            generar = form;
            InitializeComponent();
        }

        private void FormularioPublicacion_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            generar.Show();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            text_precio.Text = text_precio.Text.Replace('.', ',');
            Double value;
            if (Double.TryParse(text_precio.Text, out value))
                text_precio.Text = string.Format("{0:0.00}", value);

            else
            {
                if (text_precio.Text != "")
                {
                    text_precio.Text = String.Empty;
                    MessageBox.Show("El formato de moneda ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_precio.Focus();
                }
            }
            text_precio.Text = text_precio.Text.Replace(',', '.');
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {                
                e.Handled = true;
                return;
            }
        }
    }
}
