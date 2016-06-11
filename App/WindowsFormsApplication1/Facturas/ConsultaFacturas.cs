using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conectar;
using Helper;
using System.Data.SqlClient;

namespace visibilidad.Facturas
{
    public partial class ConsultaFacturas : Form
    {
        private int idUser;
        private DataTable dataFacturas = new DataTable();

        public ConsultaFacturas(int id_usuario)
        {
            InitializeComponent();
            idUser = id_usuario;

            //CARGO LAS FACTURAS
            Conexion connFacturas = new Conexion();
            connFacturas.cnn.Open();
            string queryFacturas = "select numero as 'NUMERO DE FACTURA' from LPB.Facturas where usuario_id='"+idUser+"'";
            SqlDataAdapter sqlAdapterFac = new SqlDataAdapter(queryFacturas, connFacturas.cnn);
            SqlCommandBuilder sqlCommandFac = new SqlCommandBuilder(sqlAdapterFac);
            sqlAdapterFac.Fill(dataFacturas);
            superGridFacturas.SetPagedDataSource(dataFacturas, bindingNavigator1);
            connFacturas.cnn.Close();

        }

        private void ConsultaFacturas_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.TopMost = true;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxFechaDesde.Text="";
            textBoxFechaHasta.Text="";
            textBoxMontoDesce.Text="";
            textBoxMontoHasta.Text="";
            comboBoxDetalle.SelectedIndex = -1;            
        }
    }
}
