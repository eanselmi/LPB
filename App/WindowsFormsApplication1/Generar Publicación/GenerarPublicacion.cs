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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Conexion con = new Conexion();                        
            string query_publicaciones = "SELECT p.codigo as Codigo, e.descripcion as Estado, t.descripcion as Tipo, p.descripcion as Descripcion " +
                    "FROM lpb.Publicaciones p, lpb.EstadosDePublicacion e, lpb.TiposDePublicacion t " +
                    "where p.EstadoDePublicacion_id=e.id and p.TipoDePublicacion_id=t.id and p.Usuario_id= " + id_usuario;            
            con.cnn.Open();
            DataTable dtDatos = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query_publicaciones, con.cnn);
            da.Fill(dtDatos);            
            datagrid_listado.DataSource = dtDatos;
            con.cnn.Close();
            datagrid_listado.ReadOnly = true;            
            datagrid_listado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            string query_usuario = "select u.username from lpb.usuarios u where u.id='" + id_usuario + "'";
            con = new Conexion();
            con.cnn.Open();
            SqlCommand command = new SqlCommand(query_usuario, con.cnn);
            SqlDataReader lector = command.ExecuteReader();
            lector.Read();
            string usuario = lector.GetString(0);
            con.cnn.Close();
            groupBox1.Text = "Listado de publicaciones del usuario " + usuario;

            cmb_estado.Items.Add("Borrador");
            cmb_estado.Items.Add("Activa");
            cmb_estado.Items.Add("Pausada");
            cmb_estado.Items.Add("Finalizada");

            cmb_tipo.Items.Add("Compra Inmediata");
            cmb_tipo.Items.Add("Subasta");

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generar_Publicación.FormularioPublicacion formularioPublicacion = new Generar_Publicación.FormularioPublicacion(this,id_usuario,0,"A");
            formularioPublicacion.Show();
            this.Hide();
        }
        public void reset_publicaciones()
        {
            this.datagrid_listado.DataSource = null;
            this.datagrid_listado.Rows.Clear();
            Conexion con = new Conexion();                        
            string query_publicaciones = "SELECT p.codigo as Codigo, e.descripcion as Estado, t.descripcion as Tipo, p.descripcion as Descripcion " +
                    "FROM lpb.Publicaciones p, lpb.EstadosDePublicacion e, lpb.TiposDePublicacion t " +
                    "where p.EstadoDePublicacion_id=e.id and p.TipoDePublicacion_id=t.id and p.Usuario_id= " + id_usuario;
            con.cnn.Open();
            DataTable dtDatos = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query_publicaciones, con.cnn);
            da.Fill(dtDatos);
            datagrid_listado.DataSource = dtDatos;
            con.cnn.Close();
            datagrid_listado.ReadOnly = true;
            datagrid_listado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            int ind = datagrid_listado.CurrentCell.RowIndex;
            string cod = datagrid_listado.Rows[ind].Cells["Codigo"].Value.ToString();
            
            Generar_Publicación.FormularioPublicacion formularioPublicacion = new Generar_Publicación.FormularioPublicacion(this,id_usuario,Convert.ToInt32(cod), "M");
            formularioPublicacion.Show();
            
        }

        private void datagrid_listado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void datagrid_listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            string verificar_id = datagrid_listado.Rows[ind].Cells["Codigo"].Value.ToString();
            if (verificar_id == "")
            {
                MessageBox.Show("Por favor seleccione una fila que contenga datos", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.Hide();

            string cod = datagrid_listado.Rows[ind].Cells["Codigo"].Value.ToString();

            Generar_Publicación.FormularioPublicacion formularioPublicacion = new Generar_Publicación.FormularioPublicacion(this, id_usuario, Convert.ToInt32(cod), "V");
            formularioPublicacion.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string descripcion="";
            string estado="";
            string tipo="";

            if (text_descripcion.Text != "")
                descripcion = " and p.descripcion like '%"+text_descripcion.Text+"%'";
            if (cmb_tipo.Text != "")
                tipo = " and t.descripcion = '" + cmb_tipo.Text +"'";
            if (cmb_estado.Text != "")
                estado = " and e.descripcion = '" + cmb_estado.Text + "'";


            this.datagrid_listado.DataSource = null;
            this.datagrid_listado.Rows.Clear();
            Conexion con = new Conexion();
            string query_publicaciones = "SELECT p.codigo as Codigo, e.descripcion as Estado, t.descripcion as Tipo, p.descripcion as Descripcion " +
                    "FROM lpb.Publicaciones p, lpb.EstadosDePublicacion e, lpb.TiposDePublicacion t " +
                    "where p.EstadoDePublicacion_id=e.id and p.TipoDePublicacion_id=t.id and p.Usuario_id= " + id_usuario + descripcion + tipo + estado;
            con.cnn.Open();
            DataTable dtDatos = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query_publicaciones, con.cnn);
            da.Fill(dtDatos);
            datagrid_listado.DataSource = dtDatos;
            con.cnn.Close();
            datagrid_listado.ReadOnly = true;
            datagrid_listado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_descripcion.Text = "";
            cmb_estado.SelectedIndex = -1;
            cmb_tipo.SelectedIndex = -1;
            reset_publicaciones();
        }
    }
}
