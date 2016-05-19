using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;
using conectar;
using System.Data.SqlClient;

namespace MercadoEnvio.Abm_Rol
{
    public partial class BuscarRol : Form
    {
        public string evento;
        public BuscarRol(string ev)
        {
            InitializeComponent();
            evento = ev;
            btn_continuar.Enabled = false;
            if (evento == "M")
                btn_continuar.Text = "Modificar";
            else
                btn_continuar.Text = "Eliminar";

            /*CARGA LOS ROLES EN EL COMBOBOX*/
            Conexion con = new Conexion();
            string query;
            if (evento == "M")
                query = "SELECT nombre FROM lpb.roles";
            else
                query = "SELECT nombre FROM lpb.roles WHERE habilitado = 1 ";

            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();

            while (lector.Read())
            {
                combo_funciones.Items.Add(lector.GetString(0));

            }
            con.cnn.Close();
            btn_continuar.Enabled = false;

        }

        private Int32 getIdRol(string rol)
        {
            Conexion con = new Conexion();

            //CONSIGO ID_ROL
            string query3 = "SELECT id FROM lpb.roles WHERE nombre = '" + rol + "'";
            con.cnn.Open();
            SqlCommand command3 = new SqlCommand(query3, con.cnn);
            Int32 id_rol = Convert.ToInt32(command3.ExecuteScalar());
            con.cnn.Close();
            return id_rol;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (evento == "B")
            {
                Conexion con = new Conexion();
                string query = "UPDATE lpb.roles SET habilitado = 0 WHERE nombre = '" + combo_funciones.Text + "'";
                con.cnn.Open();
                SqlCommand command = new SqlCommand(query, con.cnn);
                command.ExecuteNonQuery();
                con.cnn.Close();

                Int32 id_rol = getIdRol(combo_funciones.Text);
                query = "DELETE lpb.funcionalidadesPorRol WHERE Rol_id = " + id_rol + "";
                con.cnn.Open();
                SqlCommand command2 = new SqlCommand(query, con.cnn);
                command2.ExecuteNonQuery();
                con.cnn.Close();

                
                MessageBox.Show("Rol Eliminado Correctamente", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                ABMRol abmRol = new ABMRol(combo_funciones.Text);
                abmRol.Show();
                this.Close();
            }

        }

        private void BuscarRol_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_funciones.Text != "")
                btn_continuar.Enabled = true;
        }
    }
}
