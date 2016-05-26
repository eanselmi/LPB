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
    public partial class ModificacionVisiblidad : Form
    {
        public ModificacionVisiblidad(String visibilidad_descr)
        {
            InitializeComponent();

            Conexion conexion = new Conexion();
            string query = "select * from LPB.Visibilidades where descripcion = '" + visibilidad_descr + "'";
            conexion.cnn.Open();
            SqlCommand command = new SqlCommand(query, conexion.cnn);
            SqlDataReader lector = command.ExecuteReader();
            if (lector.Read())
            {
                label_codigo.Text = lector.GetDecimal(0).ToString(CultureInfo.InvariantCulture); 
                tbox_descr.Text = lector.GetString(1);
                decimal precioComision = lector.GetDecimal(4);
                check_comision.Checked = !precioComision.Equals(0);
                tbox_precio.Text = lector.GetDecimal(2).ToString(CultureInfo.InvariantCulture);
                tbox_porc.Text = lector.GetDecimal(3).ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("No se encontró la visibilidad", "Visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cnn.Close();
        }

        private void ModificacionVisiblidad_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            decimal precio=0;
            decimal porcentaje = 0;
            decimal codigo = 0;

            String evento = "and codigo!=" + label_codigo.Text;

            ValidacionesVisibilidad vv = new ValidacionesVisibilidad();
            String msg_final = vv.validarInputVisibilidad(tbox_descr.Text, tbox_precio.Text, precio, tbox_porc.Text, porcentaje);
            msg_final += vv.validarExistente(tbox_descr.Text, evento);

            if (!msg_final.Equals(""))  {
                MessageBox.Show(msg_final, "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                precio = decimal.Parse(tbox_precio.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
                porcentaje = decimal.Parse(tbox_porc.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
                codigo = decimal.Parse(label_codigo.Text, NumberStyles.Any, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar", "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Boolean resultadoAlta = vv.impactarDBModificacionVisibilidad(codigo,tbox_descr.Text, precio, porcentaje, check_comision.Checked);

            if (!resultadoAlta)
            {
                msg_final += "No se pudo guardar la visibilidad";
                if (!msg_final.Equals(""))
                {
                    MessageBox.Show(msg_final, "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Visibilidad guardada", "Visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            return;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
