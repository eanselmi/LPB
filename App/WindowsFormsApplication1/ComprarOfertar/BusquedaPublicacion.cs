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

namespace visibilidad.ComprarOfertar
{
    public partial class BusquedaPublicacion : Form
    {
        String tipoPublicacionABuscar;

        public BusquedaPublicacion(String tipoPublicacion)
        {
            InitializeComponent();
            tipoPublicacionABuscar = tipoPublicacion;
            if (tipoPublicacionABuscar.Equals("Compra Inmediata"))
            {
                btn_comprar.Text = "Comprar";
            }
            else
            {
                btn_comprar.Text = "Ofertar";
            }
            btn_comprar.Enabled = false;

            Common busqueda = new Common();
            checklist_rubros = busqueda.cargarRubros(checklist_rubros);
            limpiar();
            grid_publis = busqueda.cargarPublicaciones(grid_publis, tipoPublicacion , null, null);

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
            btn_todas.Enabled = true;
            Common busqueda = new Common();
            grid_publis = busqueda.cargarPublicaciones(grid_publis, tipoPublicacionABuscar, tbox_descr.Text, checklist_rubros.CheckedItems);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Common busqueda = new Common();
            grid_publis = busqueda.cargarPublicaciones(grid_publis, tipoPublicacionABuscar, null, null);
            limpiar();
        }

        private void grid_publis_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grid_publis.SelectedRows[0];

            btn_comprar.Enabled = true;
            btn_pregunta.Enabled = obtenerEnabledSegunValor(row,"aceptaPreguntas");
            checkbox_envio.Enabled = obtenerEnabledSegunValor(row, "aceptaEnvio");
          
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

     
    }
}