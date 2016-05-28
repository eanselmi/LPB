using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conectar;
using System.Data.SqlClient;

namespace common
{
    class Common
    {
        public CheckedListBox cargarRubros(CheckedListBox rubros)
        {
            Conexion con = new Conexion();
            String query = "SELECT descripcion FROM lpb.Rubros";

            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();

            while (lector.Read())
            {
                rubros.Items.Add(lector.GetString(0));
            }
            con.cnn.Close();

            return rubros;
        }
    }
}
