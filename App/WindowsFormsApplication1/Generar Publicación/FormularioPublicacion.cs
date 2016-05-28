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
        public FormularioPublicacion(Generar_Publicación.GenerarPublicacion form)
        {
            generar = form;
            InitializeComponent();
        }

        private void FormularioPublicacion_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
            if (radio_subasta.Checked == true) text_stock.Enabled = false;
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
            radio_borrador.Checked = false;
            radio_compra.Checked = false;
            radio_pausada.Checked = false;
            radio_subasta.Checked = false;
            radio_finalizada.Checked = false;
            check_envio.Checked = false;
            check_pregunta.Checked = false;
            cmb_visibilidad.SelectedIndex = -1;
            foreach (int i in checklist_rubros.CheckedIndices)
            {
                checklist_rubros.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
