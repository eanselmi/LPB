using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Helper;
using conectar;
using System.Data.SqlClient;

namespace visibilidad.Calificar
{
    public partial class Historial : Form
    {
        Conexion cn = new Conexion();
        private int idUser;
        public Historial(int idUsuario)
        {
            InitializeComponent();
            idUser = idUsuario;
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<string> lista = Helper.Help.generarListaParaProcedure("@idUser");
            cn.cnn.Open();
            dt = cn.obtenerTablaSegunProcedure(cn.getSchema() + @".SP_Ultimas_Cinco_Calificaciones", lista, idUser);
            cn.cnn.Close();
            this.dataGridViewHistorial.DataSource = dt;
            
        }

        private void buttonVolverHistorial_Click(object sender, EventArgs e)
        {
            this.Close();
            Calificar.Opciones options1 = new Calificar.Opciones(idUser);
            options1.Show();
        }

    }
}
