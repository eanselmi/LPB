using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Helper;
using conectar;
using readConfiguracion;


namespace visibilidad.Generar_Publicación
{
    public partial class GenerarPublicacion : Form
    {
        public int id_usuario;
        public GenerarPublicacion(int usuario_id)
        {
            id_usuario = usuario_id;
            InitializeComponent();
        }

        private void GenerarPublicacion_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Conexion con = new Conexion();
            string query;
            
            query = "SELECT p.codigo as Codigo, e.descripcion as Estado, t.descripcion as Tipo, p.descripcion as Descripcion " +
                    "FROM lpb.Publicaciones p, lpb.EstadosDePublicacion e, lpb.TiposDePublicacion t " +
                    "where p.EstadoDePublicacion_id=e.id and p.TipoDePublicacion_id=t.id and p.Usuario_id= " + id_usuario;            
            con.cnn.Open();
            DataTable dtDatos = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con.cnn);
            da.Fill(dtDatos);
            //dt = dtDatos;
            dataGridView1.DataSource = dtDatos;
            con.cnn.Close();
            dataGridView1.ReadOnly = true;
            //c.AutoResizeColumn(0);
            //dataGridView1.AutoResizeColumn(1);
            //dataGridView1.AutoResizeColumn(2);
            //dataGridView1.AutoResizeColumn(3);
            //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
