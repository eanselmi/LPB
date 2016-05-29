using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;
using conectar;

namespace visibilidad
{
    class ValidacionesVisibilidad
    {

        public String validarInputVisibilidad(String description, String sPrecio, decimal precio, String sPorcentaje, decimal porcentaje)
        {
            String msg_final = "";
            if (description.Length.CompareTo(255) == 1)
            {
                msg_final += "La descripción es demasiado larga\n";
            }

            description = description.Trim();

            if (sPrecio.Equals("") || sPrecio.Equals("") || sPrecio.Equals(""))
            {
                msg_final = "Debe completar todos los campos obligatorios\n";
                if (!msg_final.Equals(""))
                {
                    MessageBox.Show(msg_final, "Error al guardar visibilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                precio = decimal.Parse(sPrecio, NumberStyles.Any, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                msg_final += "El campo precio debe ser un número\n";
            }

            try
            {
                porcentaje = decimal.Parse(sPorcentaje, NumberStyles.Any, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                msg_final += "El campo porcentaje debe ser un número\n";
            }

            if (porcentaje.CompareTo(100) == 1)
            {
                msg_final += "El campo porcentaje no debe ser mayor a 100\n";
            }


            if (porcentaje.CompareTo(0) != 1)
            {
                msg_final += "El campo porcentaje no debe ser negativo\n";
            }

            if (precio.CompareTo(0) != 1)
            {
                msg_final += "El campo precio no debe ser negativo\n";
            }

            return msg_final;
        }

        public String validarExistente(String campo, String evento)
        {
            String msg_final = "";
            string query = "select * from LPB.Visibilidades where descripcion = '" +campo+ "' "+evento;
            Conexion conexion = new Conexion();
            conexion.cnn.Open();
            SqlCommand command = new SqlCommand(query, conexion.cnn);
            SqlDataReader lector = command.ExecuteReader();
            if (lector.Read())
            {
                msg_final += "Ya existe una visibilidad con ese nombre\n";
            }
            conexion.cnn.Close();
            return msg_final;
        }

        public Boolean impactarDBAltaVisibilidad(String descripcion, decimal precio, decimal porcentaje, bool comision)
        {
            Boolean resultadoAlta;
            Conexion conexion = new Conexion();
            conexion.cnn.Open();
            resultadoAlta = conexion.executeProcedure(conexion.getSchema() + @".SP_Alta_Visibilidad",
                   Helper.Help.generarListaParaProcedure("@descripcion", "@precio", "@porcentaje", "@comision"),
                   descripcion, precio, porcentaje, comision);
            conexion.cnn.Close();
            return resultadoAlta;
        }

        public Boolean impactarDBModificacionVisibilidad(decimal codigo, String descripcion, decimal precio, decimal porcentaje, bool comision)
        {
            Boolean resultadoAlta;
            Conexion conexion = new Conexion();
            conexion.cnn.Open();
            resultadoAlta = conexion.executeProcedure(conexion.getSchema() + @".SP_Modificacion_Visibilidad",
                   Helper.Help.generarListaParaProcedure("@codigo", "@descripcion", "@precio", "@porcentaje", "@comision"),
                   codigo, descripcion, precio, porcentaje, comision);
            conexion.cnn.Close();
            return resultadoAlta;
        }

        public Boolean impactarDBBajaVisibilidad(decimal codigoVisibilidad){
            Boolean resultadoAlta;
            Conexion conexion = new Conexion();
            conexion.cnn.Open();
            resultadoAlta = conexion.executeProcedure(conexion.getSchema() + @".SP_Baja_Visibilidad",
                   Helper.Help.generarListaParaProcedure("@codigo"), codigoVisibilidad);
            conexion.cnn.Close();
            return resultadoAlta;
        }

        public Boolean hayFKs(decimal codigoVisibilidad)
        {
            String query = "select count(*) from LPB.Publicaciones p, LPB.Visibilidades v " +
                            " where p.Visibilidad_codigo = v.codigo and v.codigo = " + codigoVisibilidad;
            int resultado = 0;
            Conexion con = new Conexion();
            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                resultado = lector.GetInt32(0);
            }
            con.cnn.Close();
            return resultado > 0;
        }
    }
}
