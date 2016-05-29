using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Helper;
using conectar;
using System.Data.SqlClient;

namespace visibilidad.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
            //Propiedades de la ventana Listados Estadisticos
            this.TopMost = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            //Propiedades de el DateTimePicker
            dateTimePickerListados.Format = DateTimePickerFormat.Custom;
            dateTimePickerListados.CustomFormat = "yyyy";
            dateTimePickerListados.ShowUpDown = true;
            //Carga del combo Box Listado
            comboBoxListados.Items.Add("Destinos con más pasajes comprados");
            comboBoxListados.Items.Add("Destinos con aeronaves más vacias");
            comboBoxListados.Items.Add("Clientes con más puntos acumulados");
            comboBoxListados.Items.Add("Destinos con más pasajes cancelados");
            comboBoxListados.Items.Add("Aeronaves con mayor cantidad de dias fuera de servicio");
            //Prpiedades del combo Box Listado
            comboBoxListados.DropDownStyle = ComboBoxStyle.DropDownList;
            //Carga del combo Box Trimestre
            comboBoxTrimestre.Items.Add("1 al 3");
            comboBoxTrimestre.Items.Add("4 al 6");
            comboBoxTrimestre.Items.Add("6 al 9");
            comboBoxTrimestre.Items.Add("10 al 12");
            //Propiedades del combo Box Trimestre
            comboBoxListados.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            Conexion listado = new Conexion();

            DataTable dt = new DataTable();
            Int32 mesInicio = 0;
            Int32 mesFin = 0;
            if(comboBoxTrimestre.SelectedIndex == 0){
                mesInicio = 1;
                mesFin = 3;
            }
            if (comboBoxTrimestre.SelectedIndex == 1)      
            {
                mesInicio = 4;
                mesFin = 6;
              
            }
            if (comboBoxTrimestre.SelectedIndex == 2)
            {
                mesInicio = 7;
                mesFin = 9;

            }
            if (comboBoxTrimestre.SelectedIndex == 3)
            {
                mesInicio = 10;
                mesFin = 12;

            }

            //Creo las fechas de Inicio y Fin dependiendo del año y trimestre elegido
            DateTime fechaInicio = new DateTime(Int32.Parse(dateTimePickerListados.Text), mesInicio, 1);
            DateTime fechaFin = new DateTime(Int32.Parse(dateTimePickerListados.Text), mesFin, 1);
            List<string> lista = Helper.Help.generarListaParaProcedure("@FechaDesde", "@FechaHasta");
            switch ((String)this.comboBoxListados.SelectedItem)
            {
                case "Vendedores con mayor cantidad de productos no vendidos":
                    listado.cnn.Open();
                    dt = listado.obtenerTablaSegunProcedure(listado.getSchema() + @".SP_Vendedores_Mayor_Productos_No_Vendidos",
                        lista, String.Format("{0:yyyyMMdd HH:mm:ss}", fechaInicio), String.Format("{0:yyyyMMdd HH:mm:ss}", fechaFin));
                    listado.cnn.Close();
                    break;
                case "Clientes con mayor cantidad de productos comprados":
                    listado.cnn.Open();
                    dt = listado.obtenerTablaSegunProcedure(listado.getSchema() + @".SP_Clientes_Mayor_Productos_Comprados",
                        lista, String.Format("{0:yyyyMMdd HH:mm:ss}", fechaInicio), String.Format("{0:yyyyMMdd HH:mm:ss}", fechaFin));
                    listado.cnn.Close();
                    break;
                case "Vendedores con mayor cantidad de facturas":
                    listado.cnn.Open();
                    dt = listado.obtenerTablaSegunProcedure(listado.getSchema() + @".SP_Vendedores_Mayor_Facturas",
                        lista, String.Format("{0:yyyyMMdd HH:mm:ss}", fechaInicio), String.Format("{0:yyyyMMdd HH:mm:ss}", fechaFin));
                    listado.cnn.Close();
                    break;
                case "Vendedores con mayor monto facturado":
                    listado.cnn.Open();
                    dt = listado.obtenerTablaSegunProcedure(listado.getSchema() + @".SP_Vendedores_Mayor_Facturacion",
                        lista, String.Format("{0:yyyyMMdd HH:mm:ss}", fechaInicio), String.Format("{0:yyyyMMdd HH:mm:ss}", fechaFin));
                    listado.cnn.Close();
                    break;
            }
            this.dataGridViewListados.DataSource = dt;

        }




    }
}
