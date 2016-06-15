﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using common;
using conectar;
using System.Data.SqlClient;

namespace visibilidad.ComprarOfertar
{
    public partial class BusquedaPublicacion : Form
    {
        String tipoPublicacionABuscar;
        int publicacionSeleccionada;
        int idUsuario;
        DataTable tablaPublicaciones = new DataTable();


        public BusquedaPublicacion(String tipoPublicacion, int id_usuario)
        {
            InitializeComponent();
            tipoPublicacionABuscar = tipoPublicacion;
            idUsuario = id_usuario;
            if (tipoPublicacionABuscar.Equals("Compra Inmediata"))
            {
                btn_comprar.Text = "Comprar";
            }
            else
            {
                btn_comprar.Text = "Ofertar";
                tbox_cant.Visible = false;
                label_cantidad.Visible = false;
            }
            btn_comprar.Enabled = false;

            Common busqueda = new Common();
            checklist_rubros = busqueda.cargarRubros(checklist_rubros);
            limpiar();
            cargarTodasLasPublicaciones(tipoPublicacion, busqueda);
           
        }

        private void limpiar()
        {
            btn_buscar.Enabled = false;
            btn_comprar.Enabled = false;
            btn_pregunta.Enabled = false;
            tbox_descr.Text = "";

            foreach (int i in checklist_rubros.CheckedIndices)
            {
                checklist_rubros.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void habilitarBusqueda(Boolean habilitado)
        {
            btn_buscar.Enabled = habilitado;
        }

        private void tbox_descr_TextChanged(object sender, EventArgs e)
        {
            habilitarBusqueda(tbox_descr.Text.Length >= 3 || 
                (checklist_rubros.CheckedItems.Count != 0 
                && tbox_descr.Text.Equals("")) );
        }

 
        private void checklist_rubros_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBusqueda(checklist_rubros.CheckedItems.Count != 0 
                && (tbox_descr.Text.Equals("") || tbox_descr.Text.Length >= 3) );
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            tablaPublicaciones.Rows.Clear();
            tablaPublicaciones.Columns.Clear();
            superGridPublis.clearData();
            btn_todas.Enabled = true;
            Common busqueda = new Common();
            if(!(busqueda.cargarPublicaciones(idUsuario,tablaPublicaciones, tipoPublicacionABuscar, tbox_descr.Text, checklist_rubros.CheckedItems)))
            {
                superGridPublis.DataSource = null;
            }
            else
            {
                superGridPublis.SetPagedDataSource(tablaPublicaciones, bindingNavigator1);
                busqueda.crearColumnas(superGridPublis, 0, "codigo", "Código", true);
                busqueda.crearColumnas(superGridPublis, 1, "Usuario_id", "Usuario_id", false);
                busqueda.crearColumnas(superGridPublis, 2, "EstadoDePublicacion_id", "EstadoDePublicacion_id", false);
                busqueda.crearColumnas(superGridPublis, 3, "descripcion", "Descripción", true);
                busqueda.crearColumnas(superGridPublis, 4, "stock", "Stock", true);
                busqueda.crearColumnas(superGridPublis, 5, "fechaVencimiento", "Fecha de Vencimiento", true);
                busqueda.crearColumnas(superGridPublis, 6, "precio", "Precio", true);
                busqueda.crearColumnas(superGridPublis, 7, "aceptaEnvio", "aceptaEnvio", false);
                busqueda.crearColumnas(superGridPublis, 8, "aceptaPreguntas", "aceptaPreguntas", false);
                busqueda.crearColumnas(superGridPublis, 9, "Visibilidad_codigo", "Visibilidad_codigo", false);
                busqueda.crearColumnas(superGridPublis, 10, "precio1", "precio1", false);
                busqueda.crearColumnas(superGridPublis, 11, "reputacion", "Reputacion del vendedor", true);

            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            tablaPublicaciones.Rows.Clear();
            tablaPublicaciones.Columns.Clear();
            superGridPublis.clearData();
            Common busqueda = new Common();
            if(!(busqueda.cargarPublicaciones(idUsuario,tablaPublicaciones, tipoPublicacionABuscar, null, null)))
            {
                superGridPublis.DataSource = null;
            }
            else
            {
                superGridPublis.SetPagedDataSource(tablaPublicaciones, bindingNavigator1);
                busqueda.crearColumnas(superGridPublis, 0, "codigo", "Código", true);
                busqueda.crearColumnas(superGridPublis, 1, "Usuario_id", "Usuario_id", false);
                busqueda.crearColumnas(superGridPublis, 2, "EstadoDePublicacion_id", "EstadoDePublicacion_id", false);
                busqueda.crearColumnas(superGridPublis, 3, "descripcion", "Descripción", true);
                busqueda.crearColumnas(superGridPublis, 4, "stock", "Stock", true);
                busqueda.crearColumnas(superGridPublis, 5, "fechaVencimiento", "Fecha de Vencimiento", true);
                busqueda.crearColumnas(superGridPublis, 6, "precio", "Precio", true);
                busqueda.crearColumnas(superGridPublis, 7, "aceptaEnvio", "aceptaEnvio", false);
                busqueda.crearColumnas(superGridPublis, 8, "aceptaPreguntas", "aceptaPreguntas", false);
                busqueda.crearColumnas(superGridPublis, 9, "Visibilidad_codigo", "Visibilidad_codigo", false);
                busqueda.crearColumnas(superGridPublis, 10, "precio1", "precio1", false);
                busqueda.crearColumnas(superGridPublis, 11, "reputacion", "Reputacion del vendedor", true);
            }
            limpiar();
        }

        private void grid_publis_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = superGridPublis.SelectedRows[0];

            btn_comprar.Enabled = true;
            btn_pregunta.Enabled = obtenerEnabledSegunValor(row,"aceptaPreguntas");
            checkbox_envio.Enabled = obtenerEnabledSegunValor(row, "aceptaEnvio");

            try
            {
                publicacionSeleccionada = int.Parse(row.Cells["codigo"].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al gestionar la carga", "Error Publicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool obtenerEnabledSegunValor(DataGridViewRow row, String columna)
        {
            if (row.Cells[columna].Value.ToString().Equals("True") ||
                row.Cells[columna].Value.ToString().Equals("False"))
            {
                return bool.Parse(row.Cells[columna].Value.ToString());
            }
            else
            {
                return false;
            }
        }

        private void btn_pregunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad aún no está disponible", "Realizar pregunta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {

            /* Chequeo que no tenga 3 operaciones sin calificar*/
            string queryCheck = "select count(*) from (select a.id from lpb.Compras a where a.cliente_id=(select id from LPB.Clientes where Usuario_id='" + idUsuario + "') and a.Calificacion_cod is null union select b.id from lpb.ofertas b where b.Cliente_id=(select id from LPB.Clientes where Usuario_id='" + idUsuario + "') and b.ganadora=1 and b.Calificacion_cod is null) as pubsincalif";
            Conexion conCSSC = new Conexion();
            conCSSC.cnn.Open();
            SqlCommand comandoCSSC = new SqlCommand(queryCheck, conCSSC.cnn);
            SqlDataReader lector1 = comandoCSSC.ExecuteReader();
            lector1.Read();
            if (lector1.GetInt32(0) >= 3)
            {
                MessageBox.Show("No puede realizar otra operación porque tiene 3 operaciones sin calificar", "Mensaje..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conCSSC.cnn.Close();
                return;
            }
            conCSSC.cnn.Close();

            /* Chequeo que no esté en estado "pausada"*/
            DataGridViewRow rowSeleccionada = superGridPublis.SelectedRows[0];
            int estadoPub = int.Parse(rowSeleccionada.Cells["EstadoDePublicacion_id"].Value.ToString());
            if (estadoPub == 3)
            {
                MessageBox.Show("No puede realizar una operación en la publicación seleccionada, ya que se encuentra pausada", "Mensaje..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            /* Chequeo que alcance el stock */
            Conexion con = new Conexion();
            String query = "select COUNT(*) from LPB.Publicaciones where stock>=" + tbox_cant.Text + " and codigo = " +
                publicacionSeleccionada;
            int publicacionesconStock = 0;
            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();

            while (lector.Read())
            {
                publicacionesconStock = lector.GetInt32(0);
            }
            con.cnn.Close();

            if (publicacionesconStock <= 0)
            {
                MessageBox.Show("No hay suficiente stock para realizar esta acción", btn_comprar.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* Evaluo cantidad a ofertar */
            if(btn_comprar.Text.Equals("Ofertar")){
                DataGridViewRow row = superGridPublis.SelectedRows[0];
                Ofertar_Box ofertar = new Ofertar_Box(row.Cells["precio"].Value.ToString(), idUsuario, publicacionSeleccionada.ToString(), superGridPublis, this);
                ofertar.Show();
                btn_todas.Enabled = true;
            }

            if(btn_comprar.Text.Equals("Comprar")){
                DataGridViewRow row = superGridPublis.SelectedRows[0];
                int cantidad;
                decimal monto;
                int visibilidad;
                int vendedor;
                Boolean envio;

                try
                {
                    cantidad = int.Parse(tbox_cant.Text);
                    visibilidad = int.Parse(row.Cells["Visibilidad_codigo"].Value.ToString());
                    envio = bool.Parse(checkbox_envio.Checked.ToString());
                    monto = decimal.Parse(row.Cells["precio"].Value.ToString());
                    vendedor = int.Parse(row.Cells["Usuario_id"].Value.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al gestionar la compra", "Error Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (facturarCompra(vendedor, visibilidad, monto, cantidad, envio))
                {
                    cargarTodasLasPublicaciones("Compra inmediata", new Common());
                    checkbox_envio.Checked = false;
                    tbox_cant.Text = "1";
                    MessageBox.Show("¡Muchas gracias por su compra!", btn_comprar.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error gestionando su compra. Por favor, vuelva a intentarlo.", btn_comprar.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
            }

        }

        private Boolean facturarCompra(int vendedor, int visibilidad, decimal monto, int cantidad, Boolean envio)
        {
            Boolean resultadoFacturaCompra;
            DateTime fecha = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);
           
            Conexion conexion = new Conexion();
            conexion.cnn.Open();
            resultadoFacturaCompra = conexion.executeProcedure(conexion.getSchema() + @".SP_Generar_Facturacion_Venta",
                   Helper.Help.generarListaParaProcedure("@fecha", "@publicacion_cod", "@visibilidad_codigo", "@vendedor_id","@comprador_id", "@monto", "@cantidad", "@envio"),
                   fecha, publicacionSeleccionada, visibilidad, vendedor, idUsuario, monto, cantidad, envio);
            conexion.cnn.Close();
            return resultadoFacturaCompra;
        }

        private void superGridPublis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_publis_Click(sender,e);
        }

        private void cargarTodasLasPublicaciones(String tipoPublicacion, Common busqueda)
        {
            tablaPublicaciones.Rows.Clear();
            tablaPublicaciones.Columns.Clear();
            superGridPublis.clearData();
           
            //SI NO HAY PUBLICACIONES NO CARGO NADA EN EL GRID
            if (!(busqueda.cargarPublicaciones(idUsuario, tablaPublicaciones, tipoPublicacion, null, null)))
            {
                superGridPublis.DataSource = null;
            }
            else
            {
                superGridPublis.SetPagedDataSource(tablaPublicaciones, bindingNavigator1);
                busqueda.crearColumnas(superGridPublis, 0, "codigo", "Código", true);
                busqueda.crearColumnas(superGridPublis, 1, "Usuario_id", "Usuario_id", false);
                busqueda.crearColumnas(superGridPublis, 2, "EstadoDePublicacion_id", "EstadoDePublicacion_id", false);
                busqueda.crearColumnas(superGridPublis, 3, "descripcion", "Descripción", true);
                busqueda.crearColumnas(superGridPublis, 4, "stock", "Stock", true);
                busqueda.crearColumnas(superGridPublis, 5, "fechaVencimiento", "Fecha de Vencimiento", true);
                busqueda.crearColumnas(superGridPublis, 6, "precio", "Precio", true);
                busqueda.crearColumnas(superGridPublis, 7, "aceptaEnvio", "aceptaEnvio", false);
                busqueda.crearColumnas(superGridPublis, 8, "aceptaPreguntas", "aceptaPreguntas", false);
                busqueda.crearColumnas(superGridPublis, 9, "Visibilidad_codigo", "Visibilidad_codigo", false);
                busqueda.crearColumnas(superGridPublis, 10, "precio1", "precio1", false);
                busqueda.crearColumnas(superGridPublis, 11, "reputacion", "Reputacion del vendedor", true);
            }

            

            btn_todas.Enabled = false;
        }

     
    }
}