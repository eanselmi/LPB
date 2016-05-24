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

namespace MercadoEnvio.ABM_Visibilidad
{
    public partial class AMB_Visibilidad_M : Form
    {
        public AMB_Visibilidad_M()
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
            String msg_final = "";

            decimal precio = 0;
            decimal porcentaje = 0;

            if (tbox_descr.Text.Length.CompareTo(255) == 1)  {
                msg_final += "La descripción es demasiado larga\n";
            }

            tbox_descr.Text = tbox_descr.Text.Trim();

            if (tbox_precio.Text.Equals("") || tbox_porc.Text.Equals("") || tbox_descr.Text.Equals("")) {
                msg_final = "Debe completar todos los campos obligatorios\n";
                if (!msg_final.Equals("")) {
                    MessageBox.Show(msg_final, "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try {
                precio = decimal.Parse(tbox_precio.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            } catch (Exception){
                msg_final += "El campo precio debe ser un número\n";
            }

            try {
                porcentaje = decimal.Parse(tbox_porc.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            } catch (Exception){
                msg_final += "El campo porcentaje debe ser un número\n";
            }

            if (porcentaje.CompareTo(100) == 1) {
                msg_final += "El campo porcentaje no debe ser mayor a 100\n";
            }

            if (!msg_final.Equals("")) {
                MessageBox.Show(msg_final, "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (porcentaje.CompareTo(0) != 1)  {
                msg_final += "El campo porcentaje no debe ser negativo\n";
            }

            if (precio.CompareTo(0) != 1) {
                msg_final += "El campo precio no debe ser negativo\n";
            }

            Conexion conexion = new Conexion();
            string query = "select * from LPB.Visibilidades where descripcion = '" + tbox_descr.Text + "'";
            conexion.cnn.Open();
            SqlCommand command = new SqlCommand(query, conexion.cnn);
            SqlDataReader lector = command.ExecuteReader();
            if (lector.Read()) {
                msg_final += "Ya existe una visibilidad con ese nombre\n";
            }
            conexion.cnn.Close();

            if (!msg_final.Equals("")) {
                MessageBox.Show(msg_final, "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     

            conexion.cnn.Open();
            bool resultadoAlta = conexion.executeProcedure(conexion.getSchema() + @".SP_Alta_Visibilidad",
                   Helper.Help.generarListaParaProcedure("@descripcion", "@precio", "@porcentaje", "@comision"),
                   tbox_descr.Text, precio, porcentaje, check_comision.Checked);
            conexion.cnn.Close();

            if (resultadoAlta == false){
                msg_final += "No se pudo guardar la visibilidad";
            }else {
                MessageBox.Show("Visibilidad guardada", "Visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            if (!msg_final.Equals("")) {
                MessageBox.Show(msg_final, "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
