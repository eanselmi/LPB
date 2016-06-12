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
        private DateTime fechadeHoy = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);

        public ConsultaFacturas(int id_usuario)
        {
            InitializeComponent();
            idUser = id_usuario;

            //CARGO LAS FACTURAS
            string queryFacturas = "select factu.numero as 'FACTURA', it1.publicacion_cod as 'PUBLICACION', (select count(*) from LPB.ITEMS it2 where it2.Factura_nro=factu.numero) as 'CANTIDAD ITEMS',it1.descripcion as 'DETALLE', it1.cantidad as 'CANTIDAD',it1.monto as 'MONTO ITEM',factu.total as 'TOTAL FACTURA' ,factu.fecha as 'FECHA EMISIÓN' from LPB.Facturas factu, LPB.Items it1 where factu.numero=it1.Factura_nro and factu.Usuario_id='" + idUser + "' and factu.fecha <='" + fechadeHoy.ToShortDateString() + "' order by factu.numero desc, it1.monto";
            this.rellenarGrid(queryFacturas);
        }

        private void rellenarGrid(string queryParaLlenar)
        {
            dataFacturas.Rows.Clear();
            dataFacturas.Columns.Clear();
            superGridFacturas.clearData();
            Conexion connFacturas = new Conexion();
            connFacturas.cnn.Open();
            SqlDataAdapter sqlAdapterFac = new SqlDataAdapter(queryParaLlenar, connFacturas.cnn);
            SqlCommandBuilder sqlCommandFac = new SqlCommandBuilder(sqlAdapterFac);
            sqlAdapterFac.Fill(dataFacturas);

            //CHEQUEO SI NO HAY VALORES
            SqlCommand command = new SqlCommand(queryParaLlenar, connFacturas.cnn);
            SqlDataReader lector1 = command.ExecuteReader();
            lector1.Read();
            if (!(lector1.HasRows))
            {
                dataFacturas.Rows.Clear();
                dataFacturas.Columns.Clear();
                superGridFacturas.clearData();
                superGridFacturas.DataSource = dataFacturas;
                connFacturas.cnn.Close();
                return;             
            }

            superGridFacturas.SetPagedDataSource(dataFacturas, bindingNavigator1);
            connFacturas.cnn.Close();
            return;
    
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

        private void buttonSeleccionarDesde_Click(object sender, EventArgs e)
        {
            monthCalendarDesde.Visible = true;
            monthCalendarHasta.Visible = false;
        }

        private void buttonSeleccionarHasta_Click(object sender, EventArgs e)
        {
            monthCalendarDesde.Visible = false;
            monthCalendarHasta.Visible = true;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (textBoxMontoHasta.Text.Equals("") && textBoxMontoDesce.Text.Equals("") && textBoxFechaHasta.Text.Equals("")
                && textBoxFechaDesde.Text.Equals("") && comboBoxDetalle.Text.Equals(""))
            {
                MessageBox.Show("Debe completar algún criterio de filtro", "Mensaje..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            
            string queryFacturas = "select factu.numero as 'FACTURA', it1.publicacion_cod as 'PUBLICACION', (select count(*) from LPB.ITEMS it2 where it2.Factura_nro=factu.numero) as 'CANTIDAD ITEMS',it1.descripcion as 'DETALLE', it1.cantidad as 'CANTIDAD',it1.monto as 'MONTO ITEM',factu.total as 'TOTAL FACTURA' ,factu.fecha as 'FECHA EMISIÓN' from LPB.Facturas factu, LPB.Items it1 where factu.numero=it1.Factura_nro and factu.Usuario_id='" + idUser + "'";
            string queryFacturasFin = " order by factu.numero desc, it1.monto";

            if (!(textBoxFechaDesde.Text.Equals(""))) queryFacturas=string.Concat(queryFacturas," AND factu.fecha>='"+textBoxFechaDesde.Text+"'");
            if (!(textBoxFechaHasta.Text.Equals(""))) queryFacturas=string.Concat(queryFacturas," AND factu.fecha<='"+textBoxFechaHasta.Text+"'");
            if (!(textBoxMontoDesce.Text.Equals(""))) queryFacturas=string.Concat(queryFacturas," AND factu.total>='"+textBoxMontoDesce.Text+"'");
            if (!(textBoxMontoHasta.Text.Equals(""))) queryFacturas = string.Concat(queryFacturas, " AND factu.total<='" + textBoxMontoHasta.Text + "'");
            if (!(comboBoxDetalle.Text.Equals(""))) queryFacturas = string.Concat(queryFacturas, " AND it1.descripcion='" + comboBoxDetalle.Text + "'");

            queryFacturas = string.Concat(queryFacturas, queryFacturasFin);

            this.rellenarGrid(queryFacturas);
            
            this.buttonTodas.Enabled = true;
            return;
        }

        private void buttonTodas_Click(object sender, EventArgs e)
        {
            string queryFacturas = "select factu.numero as 'FACTURA', it1.publicacion_cod as 'PUBLICACION', (select count(*) from LPB.ITEMS it2 where it2.Factura_nro=factu.numero) as 'CANTIDAD ITEMS',it1.descripcion as 'DETALLE', it1.cantidad as 'CANTIDAD',it1.monto as 'MONTO ITEM',factu.total as 'TOTAL FACTURA' ,factu.fecha as 'FECHA EMISIÓN' from LPB.Facturas factu, LPB.Items it1 where factu.numero=it1.Factura_nro and factu.Usuario_id='" + idUser + "' and factu.fecha <='" + fechadeHoy.ToShortDateString() + "' order by factu.numero desc, it1.monto";
            this.rellenarGrid(queryFacturas);
            return;
        }

        private void monthCalendarDesde_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendarDesde.Visible = false;
            if (!(textBoxFechaHasta.Text.Equals(""))&&(monthCalendarDesde.SelectionStart.Date.CompareTo(monthCalendarHasta.SelectionStart.Date)>0))
            {
                MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta", "Mensaje..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            textBoxFechaDesde.Text = monthCalendarDesde.SelectionStart.Date.ToShortDateString();
            return;
        }

        private void monthCalendarHasta_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendarHasta.Visible = false;
            if (!(textBoxFechaDesde.Text.Equals("")) && (monthCalendarHasta.SelectionStart.Date.CompareTo(monthCalendarDesde.SelectionStart.Date) < 0))
            {
                MessageBox.Show("La fecha hasta no puede ser menor a la fecha desde", "Mensaje..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxFechaHasta.Text = monthCalendarHasta.SelectionStart.Date.ToShortDateString();
            return;

        }
    }
}
