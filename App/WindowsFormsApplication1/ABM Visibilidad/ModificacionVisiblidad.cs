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

namespace MercadoEnvio.ABM_Visibilidad
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
                tbox_descr.Text = lector.GetString(1);
                decimal precioComision = lector.GetDecimal(4);
                check_comision.Checked = !precioComision.Equals(0);
                tbox_precio.Text = lector.GetDecimal(2).ToString();
                tbox_porc.Text = lector.GetDecimal(3).ToString();

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
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
