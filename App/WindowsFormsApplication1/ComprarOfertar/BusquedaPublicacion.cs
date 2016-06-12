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
        String publicacionSeleccionada;
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
            busqueda.cargarPublicaciones(tablaPublicaciones, tipoPublicacion , null, null);

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
           

            btn_todas.Enabled = false;
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
            busqueda.cargarPublicaciones(tablaPublicaciones, tipoPublicacionABuscar, tbox_descr.Text, checklist_rubros.CheckedItems);
            superGridPublis.SetPagedDataSource(tablaPublicaciones, bindingNavigator1);

        }

        public void button1_Click(object sender, EventArgs e)
        {
            tablaPublicaciones.Rows.Clear();
            tablaPublicaciones.Columns.Clear();
            superGridPublis.clearData();
            Common busqueda = new Common();
            busqueda.cargarPublicaciones(tablaPublicaciones, tipoPublicacionABuscar, null, null);
            superGridPublis.SetPagedDataSource(tablaPublicaciones, bindingNavigator1);
            limpiar();
        }

        private void grid_publis_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = superGridPublis.SelectedRows[0];

            btn_comprar.Enabled = true;
            btn_pregunta.Enabled = obtenerEnabledSegunValor(row,"aceptaPreguntas");
            checkbox_envio.Enabled = obtenerEnabledSegunValor(row, "aceptaEnvio");
            publicacionSeleccionada = row.Cells["codigo"].Value.ToString();
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
            /* Chequeo que alcance el stock */
            Conexion con = new Conexion();
            String query = "select COUNT(*) from LPB.Publicaciones where stock>=" + tbox_cant.Text + " and codigo = " +
                publicacionSeleccionada;
            int stock = 0;
            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();

            while (lector.Read())
            {
                stock = lector.GetInt32(0);
            }
            con.cnn.Close();

            if (stock <= 0)
            {
                MessageBox.Show("No hay suficiente stock para realizar esta acción", btn_comprar.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* Evaluo cantidad a ofertar */
            if(btn_comprar.Text.Equals("Ofertar")){
                DataGridViewRow row = superGridPublis.SelectedRows[0];
                Ofertar_Box ofertar = new Ofertar_Box(row.Cells["precio"].Value.ToString(), idUsuario, publicacionSeleccionada, superGridPublis, this);
                ofertar.Show();
                btn_todas.Enabled = true;

            }


        }

        private void superGridPublis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_publis_Click(sender,e);
        }

     
    }
}