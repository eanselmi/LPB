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
    public partial class ComprasOfertasSinCalificar : Form
    {
        Conexion cn = new Conexion();
        private int idUser;

        public ComprasOfertasSinCalificar(int idUsuario)
        {
            InitializeComponent();
            idUser = idUsuario;
            this.textBoxUser.Text = idUser.ToString();
        }


        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Calificar.Opciones options3 = new Calificar.Opciones(idUser);
            options3.Show();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<string> lista = Helper.Help.generarListaParaProcedure("@idUser");
            cn.cnn.Open();
            dt = cn.obtenerTablaSegunProcedure(cn.getSchema() + @".SP_Compras_Sin_Calificar", lista, idUser);
            cn.cnn.Close();
            this.dataGridViewCalificar.DataSource = dt;

            this.dataGridViewCalificar.Columns[3].Visible = false;
            //Conexion con = new Conexion();
            //string query_publicaciones = "SELECT  DISTINCT c.Publicacion_cod as publicacion ,descripcion AS Descripcion , c.cantidad as Cantidad, p.Usuario_id as Vendedor " +
            //        "FROM LPB.Compras c INNER JOIN LPB.Publicaciones p ON c.Publicacion_cod = p.codigo INNER JOIN LPB.Clientes cli ON c.Cliente_id = cli.id " +
            //        "WHERE c.Calificacion_cod IS NULL AND c.Cliente_id != p.Usuario_id AND cli.Usuario_id = " + idUser;
            //con.cnn.Open();
            //DataTable dtDatos = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(query_publicaciones, con.cnn);
            //da.Fill(dtDatos);
            //dataGridViewCalificar.DataSource = dtDatos;
            //con.cnn.Close();
        
           
            groupBoxCalificar.Visible = true;
            if (dataGridViewCalificar.Rows.Count != 0)
            {
                buttonCalificar.Enabled = true;
            }
            else
            {
                buttonCalificar.Enabled = false;
            }
            this.textBoxCompra.Text = "1";

     
        }

        private void buttonOfertas_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            List<string> lista = Helper.Help.generarListaParaProcedure("@idUser");
            cn.cnn.Open();
            dt1 = cn.obtenerTablaSegunProcedure(cn.getSchema() + @".SP_Ofertas_Sin_Calificar", lista, idUser);
            cn.cnn.Close();
            this.dataGridViewCalificar.DataSource = dt1;
            this.dataGridViewCalificar.Columns[3].Visible = false;
           
            groupBoxCalificar.Visible = true;
            if (dataGridViewCalificar.Rows.Count != 0)
            {
                buttonCalificar.Enabled = true;
            }
            else
            {
                buttonCalificar.Enabled = false;
            }

            this.textBoxCompra.Text = "0";
     
        }

        private void buttonCalificar_Click(object sender, EventArgs e)
        {
            int CuO = Int32.Parse(this.textBoxCompra.Text.ToString());
            string  idPublicacion = dataGridViewCalificar.SelectedCells[0].Value.ToString();
            string vendedor = dataGridViewCalificar.SelectedCells[3].Value.ToString();
            //int ind = dataGridViewCalificar.CurrentCell.RowIndex;
            //string vendedor = dataGridViewCalificar.Rows[ind].Cells["Vendedor"].Value.ToString();
            //string idPublicacion = dataGridViewCalificar.Rows[ind].Cells["publicacion"].Value.ToString();
            MessageBox.Show(vendedor);
            MessageBox.Show(idPublicacion);
  
            this.Close();
            Calificar.Calificacion calificacion = new Calificar.Calificacion(idUser, Convert.ToDecimal(idPublicacion), CuO, Convert.ToInt32(vendedor));
            calificacion.Show();
        }

        private void ComprasOfertasSinCalificar_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }


    }
}

