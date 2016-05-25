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

namespace visibilidad.ABM_Visibilidad
{
    public partial class BajaVisibilidad : Form
    {
        decimal codigoVisibilidad;
       
        public BajaVisibilidad(String descripcion)
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            string query = "select * from LPB.Visibilidades where descripcion = '" + descripcion + "'";
            conexion.cnn.Open();
            SqlCommand command = new SqlCommand(query, conexion.cnn);
            SqlDataReader lector = command.ExecuteReader();
            if (lector.Read())
            {
                codigoVisibilidad = lector.GetDecimal(0);
            }
            else
            {
                MessageBox.Show("No se encontró la visibilidad", "Visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cnn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ValidacionesVisibilidad vv = new ValidacionesVisibilidad();
            Boolean resultadoBaja = vv.impactarDBBajaVisibilidad(codigoVisibilidad);
            String msg_final = "";

            if (!resultadoBaja)
            {
                msg_final += "No se pudo eliminar la visibilidad";
                if (!msg_final.Equals(""))
                {
                    MessageBox.Show(msg_final, "Error al eliminar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Visibilidad eliminada", "Visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
