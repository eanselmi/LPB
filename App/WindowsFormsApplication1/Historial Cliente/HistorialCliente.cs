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


namespace visibilidad.Historial_Cliente
{
    public partial class HistorialCliente : Form
    {
        private int idUsuario;

        public HistorialCliente(int idUser)
        {
            InitializeComponent();
            idUsuario = idUser;
            Conexion datosCliente = new Conexion();
            string queryCliente = "select documento_tipo,documento_numero,apellido,nombre,fechaNacimiento,mail,telefono,domicilioCalle,nroCalle,piso,dpto,codPostal,Localidad_id,id from LPB.Clientes where Usuario_id='"+idUsuario+"'";
            datosCliente.cnn.Open();
            SqlCommand comandoCliente = new SqlCommand(queryCliente, datosCliente.cnn);
            SqlDataReader lectorCliente = comandoCliente.ExecuteReader();
            lectorCliente.Read();
            labelTipoDoc.Text = lectorCliente.GetString(0);
            labelNumeroDoc.Text = lectorCliente.GetDecimal(1).ToString();
            labelApellido.Text = lectorCliente.GetString(2);
            labelNombreCliente.Text = lectorCliente.GetString(3);
            labelFechaNac.Text = lectorCliente.GetDateTime(4).ToShortDateString();
            labelMail.Text = lectorCliente.GetString(5);
            if (!(lectorCliente.IsDBNull(6)))
            {
                labelTelefono.Text = lectorCliente.GetDecimal(6).ToString();
            }
            labelCalle.Text = lectorCliente.GetString(7);
            labelNroCalle.Text = lectorCliente.GetDecimal(8).ToString();
            if (!(lectorCliente.IsDBNull(9)))
            {
                labelPiso.Text = lectorCliente.GetDecimal(9).ToString();
            }
            if (!(lectorCliente.IsDBNull(10)))
            {
                labelDpto.Text = lectorCliente.GetString(10);
            }
            labelCodPostal.Text = lectorCliente.GetString(11);
            int localidad_id = 0;
            if (!(lectorCliente.IsDBNull(12)))
            {
                localidad_id = lectorCliente.GetInt32(12);
            }
            int clienteID = lectorCliente.GetInt32(13);
            datosCliente.cnn.Close();


            if (localidad_id != 0)
            {
                Conexion buscarLocalidad = new Conexion();
                string queryLocalidad = "select descripcion from LPB.Localidades where id='"+localidad_id+"'";
                buscarLocalidad.cnn.Open();
                SqlCommand comandoLocalidad = new SqlCommand(queryLocalidad, buscarLocalidad.cnn);
                SqlDataReader lectorLoc = comandoLocalidad.ExecuteReader();
                lectorLoc.Read();
                labelLocalidad.Text = lectorLoc.GetString(0);
                buscarLocalidad.cnn.Close();
            }

            DateTime fechadeHoy;
            fechadeHoy = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);

            //CARGO LAS ESTADÍSTICAS
            Conexion connEstrellas = new Conexion();
            string queryEstrellas = "select (select count(codigo) from LPB.Calificaciones where cantEstrellas='1' and codigo in (select calificacion_cod from LPB.Compras where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"' UNION select calificacion_cod from LPB.Ofertas where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"') ), (select count(codigo) from LPB.Calificaciones where cantEstrellas='2' and codigo in (select calificacion_cod from LPB.Compras where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"' UNION select calificacion_cod from LPB.Ofertas where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"' )), (select count(codigo) from LPB.Calificaciones where cantEstrellas='3' and codigo in (select calificacion_cod from LPB.Compras where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"' UNION select calificacion_cod from LPB.Ofertas where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"' )), (select count(codigo) from LPB.Calificaciones where cantEstrellas='4' and codigo in (select calificacion_cod from LPB.Compras where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"' UNION select calificacion_cod from LPB.Ofertas where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"' )), (select count(codigo) from LPB.Calificaciones where cantEstrellas='5' and codigo in (select calificacion_cod from LPB.Compras where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"' UNION select calificacion_cod from LPB.Ofertas where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"')),(select count(id) from lpb.Compras where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"') as 'COMPRAS HECHAS',(select count(id) from LPB.Ofertas where Cliente_id='"+clienteID+"' and fecha<='"+fechadeHoy.ToShortDateString()+"') as 'SUBASTAS HECHAS',(select count(id) from LPB.Ofertas where Cliente_id='"+clienteID+"' and ganadora=1 and fecha<='"+fechadeHoy.ToShortDateString()+"') as 'SUBASTAS GANADAS',(select count(*) from (select a.id from lpb.Compras a where a.cliente_id='"+clienteID+"' and a.Calificacion_cod is null union select b.id from lpb.ofertas b where b.Cliente_id='"+clienteID+"' and b.ganadora=1 and b.Calificacion_cod is null) as publicacionesSinCalif)";
            connEstrellas.cnn.Open();
            SqlCommand comandoEstrellas = new SqlCommand(queryEstrellas, connEstrellas.cnn);
            SqlDataReader lectorEstrellas = comandoEstrellas.ExecuteReader();
            lectorEstrellas.Read();
            int unaEstrellas=0;
            int dosEstrellas = 0;
            int tresEstrellas = 0;
            int cuatroEstrellas = 0;
            int cincoEstrellas = 0;
            if (!(lectorEstrellas.IsDBNull(0))) unaEstrellas = lectorEstrellas.GetInt32(0);
            if (!(lectorEstrellas.IsDBNull(1))) dosEstrellas = lectorEstrellas.GetInt32(1);
            if (!(lectorEstrellas.IsDBNull(2))) tresEstrellas = lectorEstrellas.GetInt32(2);
            if (!(lectorEstrellas.IsDBNull(3))) cuatroEstrellas = lectorEstrellas.GetInt32(3);
            if (!(lectorEstrellas.IsDBNull(4))) cincoEstrellas = lectorEstrellas.GetInt32(4);
            if (!(lectorEstrellas.IsDBNull(5))) labelDatosComprasHechas.Text = lectorEstrellas.GetInt32(5).ToString();
            if (!(lectorEstrellas.IsDBNull(6))) labelDatosOfertasHechas.Text = lectorEstrellas.GetInt32(6).ToString();
            if (!(lectorEstrellas.IsDBNull(7))) labelDatosOfertasGanadas.Text = lectorEstrellas.GetInt32(7).ToString();
            if (!(lectorEstrellas.IsDBNull(8))) labelDatosOpSinCalif.Text = lectorEstrellas.GetInt32(8).ToString();

            connEstrellas.cnn.Close();

            labelDatos1Estrella.Text = unaEstrellas.ToString();
            labelDatos2Estrellas.Text = dosEstrellas.ToString();
            labelDatos3Estrellas.Text = tresEstrellas.ToString();
            labelDatos4Estrellas.Text = cuatroEstrellas.ToString();
            labelDatos5Estrellas.Text = cincoEstrellas.ToString();

            labelDatosOpConCalif.Text = (unaEstrellas + dosEstrellas + tresEstrellas + cuatroEstrellas + cincoEstrellas).ToString();


            //CARGO LAS GRILLAS
            // CARGO LA GRILLA DE COMPRAS

            Conexion connCompras = new Conexion();
            connCompras.cnn.Open();
            DataTable dataCompras = new DataTable();
            string queryCompras = "select Publicacion_cod as 'CÓDIGO DE PUBLICACIÓN',cantidad as 'CANTIDAD',case envio when 0 then 'NO' else 'SI' END as 'CON ENVIO',case Calificacion_cod when NULL then 'NO' else Calificacion_cod END as 'CALIFICACIÓN ID',fecha as 'FECHA' from LPB.Compras where Cliente_id='" + clienteID + "' and fecha <='"+fechadeHoy.ToShortDateString()+"'  order by fecha desc";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryCompras, connCompras.cnn);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(sqlAdapter);
            sqlAdapter.Fill(dataCompras);
            superGridCompras.SetPagedDataSource(dataCompras, bindingNavigator1);
            connCompras.cnn.Close();

            //CARGO LA GRILLA DE SUBASTAS
            Conexion connSubastas = new Conexion();
            connSubastas.cnn.Open();
            DataTable dataSubastas = new DataTable();
            string querySubastas = "select Publicacion_cod as 'CÓDIGO DE PUBLICACIÓN',monto as 'MONTO', case ganadora when 1 then 'SI' else 'NO' END as 'GANADORA',case envio when 0 then 'NO' else 'SI' END as 'CON ENVIO',case Calificacion_cod when NULL then 'NO' else Calificacion_cod END as 'CALIFICACIÓN ID', fecha as 'FECHA' from LPB.Ofertas where Cliente_id='"+clienteID+"' and fecha <='"+fechadeHoy.ToShortDateString()+"' order by fecha desc";
            SqlDataAdapter sqlAdapterSub = new SqlDataAdapter(querySubastas, connSubastas.cnn);
            SqlCommandBuilder sqlCommandSub = new SqlCommandBuilder(sqlAdapterSub);
            sqlAdapterSub.Fill(dataSubastas);
            superGridOfertas.SetPagedDataSource(dataSubastas, bindingNavigator2);
            connSubastas.cnn.Close();


        }


        private void HistorialCliente_Load(object sender, EventArgs e)
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

        private void HistorialCliente_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

  


    }

    //CLASE PARA MANEJAR EL DATAGRID PAGINADO
    public class SuperGrid : DataGridView
    {
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }

        public int _pageSize = 10;
        BindingSource bs = new BindingSource();
        BindingList<DataTable> tables = new BindingList<DataTable>();

        public void SetPagedDataSource(DataTable dataTable, BindingNavigator bnav)
        {
            DataTable dt = null;
            int counter = 1;
            foreach (DataRow dr in dataTable.Rows)
            {
                if (counter == 1)
                {
                    dt = dataTable.Clone();
                    tables.Add(dt);
                }
                dt.Rows.Add(dr.ItemArray);
                if (PageSize < ++counter)
                {
                    counter = 1;
                }
            }
            bnav.BindingSource = bs;
            bs.DataSource = tables;
            bs.PositionChanged += bs_PositionChanged;
            bs_PositionChanged(bs, EventArgs.Empty);
        }

        void bs_PositionChanged(object sender, EventArgs e)
        {
            if (bs.Position >= 0)
            {
                this.DataSource = tables[bs.Position];
            }
        }

        public void clearData()
        {
            tables.Clear();
        }
    }
}
