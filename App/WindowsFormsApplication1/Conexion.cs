using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using readConfiguracion;
using System.Data;
using System.Text.RegularExpressions;

namespace conectar
{
    class Conexion
    {
        public string cadenaconexion;
        public string schema = "LPB";
        public SqlConnection cnn;

        public Conexion()
        {
            try
            {                
                this.cadenaconexion = readConfiguracion.Configuracion.cadenaConexion();
                this.cnn = new SqlConnection(this.cadenaconexion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la conexion", ex.ToString());
            }


        }

        public SqlConnection getCn()
        {
            return cnn;
        }      

        public DataTable obtenerTablaSegunConsultaString(string consulta)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = getCn();
                SqlCommand cmd = new SqlCommand(consulta, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public string getSchema()
        {
            return schema;
        }

        public bool executeProcedure(string procedure, List<string> args, params object[] values)
        {
            try
            {
                SqlDataReader dr;
                SqlConnection cn = getCn();
                SqlCommand cmd = new SqlCommand(procedure, cn);
                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cmd);
                }
                dr = cmd.ExecuteReader();
                dr.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private static bool _validateArgumentsAndParameters(List<string> args, params object[] values)
        {
            if (args != null && values != null)
            {
                if (args.Count != values.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }
        private static void _loadSqlCommand(List<string> args, object[] values, SqlCommand cm)
        {
            for (int i = 0; i < args.Count; i++)
            {
                cm.Parameters.AddWithValue(args[i], values[i]);
            }
        }

        public DataTable obtenerTablaSegunProcedure(string procedure, List<string> args, params object[] values)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = getCn();
                SqlCommand cmd = new SqlCommand(procedure, cn);
                cmd.CommandTimeout = 1000;
                cmd.CommandType = CommandType.StoredProcedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cmd);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}