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
    public partial class Informe : Form
    {
        Conexion cn = new Conexion();
        private int idUser;
        public Informe(int idUsuario)
        {
            InitializeComponent();
            idUser = idUsuario;
        }

        private void buttonVolverInforme_Click(object sender, EventArgs e)
        {
            this.Close();
            Calificar.Opciones options2 = new Calificar.Opciones(idUser);
            options2.Show();
        }

        private void Informe_Load(object sender, EventArgs e)
        {

       

         

        }

        private void buttonInformeCompras_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<string> lista = Helper.Help.generarListaParaProcedure("@idUser");
            cn.cnn.Open();
            dt = cn.obtenerTablaSegunProcedure(cn.getSchema() + @".SP_Cantidad_Estrellas_Compras", lista, idUser);
            cn.cnn.Close();
            this.dataGridViewInformes.DataSource = dt;
            groupBoxInforme.Visible = true;
        }

        private void buttonInformeOfertas_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            List<string> lista1 = Helper.Help.generarListaParaProcedure("@idUser");
            cn.cnn.Open();
            dt1 = cn.obtenerTablaSegunProcedure(cn.getSchema() + @".SP_Cantidad_Estrellas_Ofertas", lista1, idUser);
            cn.cnn.Close();
            this.dataGridViewInformes.DataSource = dt1;
            groupBoxInforme.Visible = true;
        }



    }
}
