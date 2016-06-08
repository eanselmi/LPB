using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace visibilidad.ComprarOfertar
{
    public partial class Ofertar_Box : Form
    {
        String montoAnterior;
        public Ofertar_Box(String anterior)
        {
            InitializeComponent();
            label_anterior.Text += anterior;
            montoAnterior = anterior;
        }

        private void btn_ofertar_Click(object sender, EventArgs e)
        {
            int oferta;
            try
            {
                oferta = int.Parse(tbox_oferta.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El campo oferta debe ser un entero", "Error Oferta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal anterior = decimal.Parse(montoAnterior);

            if (oferta <= anterior)
            {
                MessageBox.Show("La oferta propuesta debe ser un mayor que el monto anterior", "Error Oferta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
