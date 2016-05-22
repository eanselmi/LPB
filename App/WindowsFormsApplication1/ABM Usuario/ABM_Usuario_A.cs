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

namespace MercadoEnvio.ABM_Usuario
{
    public partial class ABM_Usuario_A : Form
    {

        public ABM_Usuario_A()
        {
            InitializeComponent();

            /*CARGA LAS LOCALIDADES EN EL COMBOBOX*/

            Conexion con = new Conexion();
            string query = "SELECT descripcion FROM lpb.Localidades";
            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                comboBoxLocalidades.Items.Add(lector.GetString(0));
                comboBoxLocalidadEmpr.Items.Add(lector.GetString(0));
            }
            comboBoxLocalidades.Items.Add("Otra");
            comboBoxLocalidadEmpr.Items.Add("Otra");
            con.cnn.Close();

            /*CARGA LOS RUBROS EN EL COMBOBOX*/
            Conexion conRub = new Conexion();
            string queryRubro = "SELECT descripcion FROM lpb.Rubros";
            conRub.cnn.Open();
            SqlCommand commandRubro = new SqlCommand(queryRubro, conRub.cnn);
            SqlDataReader lectorRubro = commandRubro.ExecuteReader();
            while (lectorRubro.Read())
            {
                comboBoxRubro.Items.Add(lectorRubro.GetString(0));
            }
            conRub.cnn.Close();

        }

        private void ABM_Usuario_A_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRol.Text.Equals("Cliente"))
            {
                groupBoxCliente.Visible = true;
                groupBoxEmpresa.Visible = false;
            }

            if (comboBoxRol.Text.Equals("Empresa"))
            {
                groupBoxEmpresa.Visible = true;
                groupBoxCliente.Visible = false;
            }

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = false;
            textBoxFechaNac.Text = monthCalendar1.SelectionStart.Date.ToShortDateString();
        }

 
    }
}
