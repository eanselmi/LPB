using System;
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
                btn_ofertar.Visible = false;
                btn_ofertar.Enabled = false;

                btn_comprar.Visible = true;
            }
            else
            {
                btn_comprar.Visible = false;
                btn_comprar.Enabled = false;

                btn_ofertar.Visible = true;
            }

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

     
    }
}
