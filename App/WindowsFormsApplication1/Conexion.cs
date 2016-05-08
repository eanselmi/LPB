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
    }
}