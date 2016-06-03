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
    public partial class FormularioPublicacion : Form
    {
        public Generar_Publicación.GenerarPublicacion generar;
        public int id_usuario;
        public int publicacion_tipo;
        public int publicacion_estado;
        public int publicacion_acepta_envio;
        public int publicacion_acepta_preguntas;
        public FormularioPublicacion(Generar_Publicación.GenerarPublicacion form, int usuario_id)
        {
            generar = form;
            id_usuario = usuario_id;
            InitializeComponent();
        }

        private void FormularioPublicacion_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            radio_compra.Checked = true;
            radio_borrador.Checked = true;

            date_inicio.Value = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);
            date_fin.Value = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);
            date_fin.Value = date_fin.Value.AddDays(30);
            date_fin.Enabled = false;
            date_inicio.Enabled = false;
            cmb_visibilidad.Items.Clear();
            string query_visibilidad = "select v.descripcion from lpb.visibilidades v";
            Conexion con = new Conexion();
            con.cnn.Open();
            SqlCommand command = new SqlCommand(query_visibilidad, con.cnn);
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
                cmb_visibilidad.Items.Add(lector.GetString(0));
            con.cnn.Close();
            string query_rubros = "select r.descripcion from lpb.rubros r";
            con = new Conexion();
            con.cnn.Open();
            command = new SqlCommand(query_rubros, con.cnn);
            lector = command.ExecuteReader();
            while (lector.Read())
                checklist_rubros.Items.Add(lector.GetString(0));
            con.cnn.Close();
            cmb_visibilidad.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            generar.Show();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            text_precio.Text = text_precio.Text.Replace('.', ',');
            Double value;
            if (Double.TryParse(text_precio.Text, out value))
                text_precio.Text = string.Format("{0:0.00}", value);

            else
            {
                if (text_precio.Text != "")
                {
                    text_precio.Text = String.Empty;
                    MessageBox.Show("El formato de moneda ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_precio.Focus();
                }
            }
            text_precio.Text = text_precio.Text.Replace(',', '.');
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void radio_subasta_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_subasta.Checked == true)
            {
                text_stock.Enabled = false;
                publicacion_tipo = 2;
            }
            else text_stock.Enabled = true;

        }

        private void cmb_visibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_visibilidad.SelectedIndex != -1)
            {
                Conexion con = new Conexion();
                string query = "select v.codigo from lpb.visibilidades v where v.descripcion='" + cmb_visibilidad.Text + "'";
                con.cnn.Open();
                SqlCommand command = new SqlCommand(query, con.cnn);
                SqlDataReader lector = command.ExecuteReader();
                if (!lector.Read())
                {
                    con.cnn.Close();
                    MessageBox.Show("Error al seleccionar la Visibilidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                text_visibilidad_id.Text = lector.GetDecimal(0).ToString();
                con.cnn.Close();
            }

            if (cmb_visibilidad.Text == "Gratis") check_envio.Visible = false;
            else check_envio.Visible = true;



        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            text_descripcion.Text = "";
            text_precio.Text = "";
            text_stock.Text = "";
            text_visibilidad_id.Text = "";
            radio_activa.Checked = false;
            radio_borrador.Checked = true;
            radio_compra.Checked = true;
            radio_pausada.Checked = false;
            radio_subasta.Checked = false;
            radio_finalizada.Checked = false;
            check_envio.Checked = false;
            check_pregunta.Checked = false;
            cmb_visibilidad.SelectedIndex = 0;
            foreach (int i in checklist_rubros.CheckedIndices)
            {
                checklist_rubros.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void radio_compra_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_compra.Checked == true) publicacion_tipo = 1;
        }

        private void radio_borrador_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_borrador.Checked == true) publicacion_estado = 1;
        }

        private void radio_activa_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_activa.Checked == true) publicacion_estado = 2;
        }

        private void radio_pausada_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_pausada.Checked == true) publicacion_estado = 3;
        }

        private void radio_finalizada_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_finalizada.Checked == true) publicacion_estado = 4;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Control de Errores
            string error = "Se encontraron los siguientes errores\n";
            if (text_descripcion.Text == "")
                error = error + "El campo Descripcion no puede estar vacio\n";
            if (text_precio.Text == "")
                error = error + "El campo Precio no puede estar vacio\n";
            if (text_stock.Text == "")
                error = error + "El campo Stock no puede estar vacio\n";
            int rubros_seleccionados = 0;
            for (int i = 0; i < checklist_rubros.Items.Count; i++)
                if (checklist_rubros.GetItemChecked(i)) rubros_seleccionados++;
            if (rubros_seleccionados == 0)
                error = error + "Debe seleccionar almenos 1 Rubro para la publicacion\n";
            if (error != "Se encontraron los siguientes errores\n")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Guardar publicacion            
            Conexion cn = new Conexion();
            using (SqlCommand cmd = new SqlCommand("lpb.SP_Guardar_Publicacion", cn.cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Seteo los parametros del SP
                cmd.Parameters.Add("@usuarioid", SqlDbType.Int);
                cmd.Parameters.Add("@publicacion_estado", SqlDbType.Int);
                cmd.Parameters.Add("@publicacion_tipo", SqlDbType.Int);
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 255);
                cmd.Parameters.Add("@stock", SqlDbType.Int);
                cmd.Parameters.Add("@fecha_creacion", SqlDbType.DateTime);
                cmd.Parameters.Add("@fecha_vencimiento", SqlDbType.DateTime);
                cmd.Parameters.Add("@precio", SqlDbType.Int);
                cmd.Parameters.Add("@acepta_envio", SqlDbType.Bit);
                cmd.Parameters.Add("@acepta_pregunta", SqlDbType.Bit);
                cmd.Parameters.Add("@visibilidad_codigo", SqlDbType.Int);
                cmd.Parameters.Add("@nuevo_codigo_publicacion", SqlDbType.Int).Direction = ParameterDirection.Output;

                // Lleno los parametros
                cmd.Parameters["@usuarioid"].Value = id_usuario;
                cmd.Parameters["@publicacion_estado"].Value = publicacion_estado;
                cmd.Parameters["@publicacion_tipo"].Value = publicacion_tipo;
                cmd.Parameters["@descripcion"].Value = text_descripcion.Text;
                cmd.Parameters["@stock"].Value = Convert.ToInt32(text_stock.Text);
                cmd.Parameters["@fecha_creacion"].Value = date_inicio.Value;
                cmd.Parameters["@fecha_vencimiento"].Value = date_fin.Value;
                cmd.Parameters["@precio"].Value = Convert.ToDecimal(text_precio.Text);
                cmd.Parameters["@acepta_envio"].Value = publicacion_acepta_envio;
                cmd.Parameters["@acepta_pregunta"].Value = publicacion_acepta_preguntas;
                cmd.Parameters["@visibilidad_codigo"].Value = Convert.ToInt32(text_visibilidad_id.Text);
                cn.cnn.Open();
                cmd.ExecuteNonQuery();

                // Leer la devolucion del SP
                int codigo_nuevo = Convert.ToInt32(cmd.Parameters["@nuevo_codigo_publicacion"].Value);
                MessageBox.Show(codigo_nuevo.ToString());
                cn.cnn.Close();
            }




        }
    }
}
