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
            DateTime fechadeHoy;
            fechadeHoy = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);
            Conexion connFacturas = new Conexion();
            connFacturas.cnn.Open();
            string queryFacturas = "select factu.numero as 'FACTURA', it1.publicacion_cod as 'PUBLICACION', (select count(*) from LPB.ITEMS it2 where it2.Factura_nro=factu.numero) as 'CANTIDAD ITEMS',it1.descripcion as 'DETALLE', it1.cantidad as 'CANTIDAD',it1.monto as 'MONTO ITEM',factu.total as 'TOTAL FACTURA' ,factu.fecha as 'FECHA EMISIÓN' from LPB.Facturas factu, LPB.Items it1 where factu.numero=it1.Factura_nro and factu.Usuario_id='"+idUser+"' and factu.fecha <='"+fechadeHoy.ToShortDateString()+"' order by factu.numero desc, it1.monto";
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
