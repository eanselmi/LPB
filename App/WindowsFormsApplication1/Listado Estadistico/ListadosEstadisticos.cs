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
        Conexion listado = new Conexion();

        public ListadoEstadistico()
        {
            InitializeComponent();
            //Propiedades de la ventana Listados Estadisticos
            //this.TopMost = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            //Propiedades de el DateTimePicker
            dateTimePickerListados.Format = DateTimePickerFormat.Custom;
            dateTimePickerListados.CustomFormat = "yyyy";
            dateTimePickerListados.ShowUpDown = true;
            //Carga del combo Box Trimestre
            comboBoxTrimestre.Items.Add("1");
            comboBoxTrimestre.Items.Add("2");
            comboBoxTrimestre.Items.Add("3");
            comboBoxTrimestre.Items.Add("4");
            //Propiedades del combo Box Trimestre
            comboBoxListados.DropDownStyle = ComboBoxStyle.DropDownList;
            //Carga del combo Box Listado
            comboBoxListados.Items.Add("Vendedores con mayor cantidad de productos no vendidos");
            comboBoxListados.Items.Add("Clientes con mayor cantidad de productos comprados");
            comboBoxListados.Items.Add("Vendedores con mayor cantidad de facturas");
            comboBoxListados.Items.Add("Vendedores con mayor monto facturado");
            //Prpiedades del combo Box Listado
            comboBoxListados.DropDownStyle = ComboBoxStyle.DropDownList;
            //Carga del combo Box Visibilidad
            DataTable dt = new DataTable();
            dt = listado.obtenerTablaSegunConsultaString("SELECT codigo, descripcion from " + listado.getSchema() + ".Visibilidades");
            comboBoxVisibilidad.Items.Clear();
            comboBoxVisibilidad.DataSource = dt;
            comboBoxVisibilidad.ValueMember = "codigo";
            comboBoxVisibilidad.DisplayMember = "descripcion";
            comboBoxVisibilidad.SelectedIndex = -1;
            //Carga del combo Box Rubro
            DataTable dt1 = new DataTable();
            dt1 = listado.obtenerTablaSegunConsultaString("SELECT id, descripcion from " + listado.getSchema() + ".Rubros");
            comboBoxRubro.Items.Clear();
            comboBoxRubro.DataSource = dt1;
            comboBoxRubro.ValueMember = "id";
            comboBoxRubro.DisplayMember = "descripcion";
            comboBoxRubro.SelectedIndex = -1;
        }

        private void comboBoxTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxTrimestre.SelectedItem != "")
            {
                comboBoxListados.Enabled = true;
            }
        }


        private void comboBoxListados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxListados.SelectedItem == "Vendedores con mayor cantidad de productos no vendidos")
            {
                labelVisibilidad.Enabled = true;
                comboBoxVisibilidad.Enabled = true;
                labelRubro.Enabled = false;
                comboBoxRubro.Enabled = false;
                comboBoxRubro.SelectedIndex = -1;
                buttonConsultar.Enabled = false;
 
            }else
            {

                 if ((string)comboBoxListados.SelectedItem == "Clientes con mayor cantidad de productos comprados")
                 {
                    labelRubro.Enabled = true;
                    comboBoxRubro.Enabled = true;
                    labelVisibilidad.Enabled = false;
                    comboBoxVisibilidad.Enabled = false;
                    comboBoxVisibilidad.SelectedIndex = -1;
                    buttonConsultar.Enabled = false;
                 }
                    else
                    {
                        labelVisibilidad.Enabled = false;
                        comboBoxVisibilidad.Enabled = false;
                        comboBoxRubro.SelectedIndex = -1;
                        comboBoxVisibilidad.SelectedIndex = -1;
                        labelRubro.Enabled = false;
                        comboBoxRubro.Enabled = false;
                        buttonConsultar.Enabled = true;

                    }
            }

        }


        private void comboBoxVisibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVisibilidad.SelectedValue != null)
            {
                buttonConsultar.Enabled = true;
            }

        }

        private void comboBoxRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRubro.SelectedValue != null)
            {
                buttonConsultar.Enabled = true;
            }
        }



        private void buttonConsultar_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            int anio = Convert.ToInt32(dateTimePickerListados.Value.Year.ToString());
            int trimestre =  int.Parse(comboBoxTrimestre.SelectedItem.ToString());
            List<string> lista1 = Helper.Help.generarListaParaProcedure("@anio", "@trimestre", "@visibilidad");
            List<string> lista2 = Helper.Help.generarListaParaProcedure("@anio", "@trimestre", "@rubro");
            List<string> lista3y4 = Helper.Help.generarListaParaProcedure("@anio", "@trimestre");
            
            switch ((String)this.comboBoxListados.SelectedItem)
            {
                case "Vendedores con mayor cantidad de productos no vendidos":
                    decimal visibilidad = Decimal.Parse(comboBoxVisibilidad.SelectedValue.ToString());
                    listado.cnn.Open();
                    dt = listado.obtenerTablaSegunProcedure(listado.getSchema() + @".SP_Vendedores_Mayor_Productos_No_Vendidos",
                        lista1, anio, trimestre, visibilidad);
                    listado.cnn.Close();
                    break;
                case "Clientes con mayor cantidad de productos comprados":
                    int rubro = int.Parse(comboBoxRubro.SelectedValue.ToString());
                    listado.cnn.Open();
                    dt = listado.obtenerTablaSegunProcedure(listado.getSchema() + @".SP_Clientes_Mayor_Productos_Comprados",
                        lista2, anio, trimestre, rubro);
                    listado.cnn.Close();
                    break;
                case "Vendedores con mayor cantidad de facturas":
                    listado.cnn.Open();
                    dt = listado.obtenerTablaSegunProcedure(listado.getSchema() + @".SP_Vendedores_Mayor_Facturas",
                        lista3y4, anio, trimestre);
                    listado.cnn.Close();
                    break;
                case "Vendedores con mayor monto facturado":
                    listado.cnn.Open();
                    dt = listado.obtenerTablaSegunProcedure(listado.getSchema() + @".SP_Vendedores_Mayor_Facturacion",
                        lista3y4, anio, trimestre);
                    listado.cnn.Close();
                    break;
            }
                    this.dataGridViewListados.DataSource = dt;
            

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            dateTimePickerListados.ResetText();
            comboBoxListados.SelectedIndex = -1;
            comboBoxRubro.SelectedIndex = -1;
            comboBoxTrimestre.SelectedIndex = -1;
            comboBoxVisibilidad.SelectedIndex = -1;
            buttonConsultar.Enabled = false;
        }





      

        


       


    

    }
}
