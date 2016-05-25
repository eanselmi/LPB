using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conectar;
using System.Data.SqlClient;
using System.Globalization;
using visibilidad;

namespace visibilidad.ABM_Visibilidad
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

        private void btn_guardar_Click(object sender, EventArgs e) {
         
            decimal precio = 0;
            decimal porcentaje = 0;

            ValidacionesVisibilidad vv = new ValidacionesVisibilidad();
            String msg_final = null;
            String evento = "";
            
            msg_final += vv.validarInputVisibilidad(tbox_descr.Text, tbox_precio.Text, precio, tbox_porc.Text, porcentaje);
            msg_final += vv.validarExistente(tbox_descr.Text, evento);

            if (!msg_final.Equals("")) {
                MessageBox.Show(msg_final, "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                precio = decimal.Parse(tbox_precio.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
                porcentaje = decimal.Parse(tbox_porc.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar", "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Boolean resultadoAlta = vv.impactarDBAltaVisibilidad(tbox_descr.Text, precio, porcentaje, check_comision.Checked);

            if (!resultadoAlta){
                msg_final += "No se pudo guardar la visibilidad";
                if (!msg_final.Equals("")) {
                    MessageBox.Show(msg_final, "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }else {
                MessageBox.Show("Visibilidad guardada", "Visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Close();
            }
            return;
          }

        private void tbox_descr_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaVisibilidad_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.TopMost = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
