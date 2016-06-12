using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using conectar;
using common;

namespace visibilidad.ComprarOfertar
{
    public partial class Ofertar_Box : Form
    {
        String montoAnterior;
        int idUsuario;
        int idPublicacion;
        DataGridView tablaPublicaciones;

        public Ofertar_Box(String anterior, int id_usuario, String publicacion, DataGridView rowParaActualizar)
        {
            InitializeComponent();
            label_anterior.Text += anterior;
            montoAnterior = anterior;
            idUsuario = id_usuario;
            tablaPublicaciones = rowParaActualizar;
            try
            {
                idPublicacion = int.Parse(publicacion);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al gestionar la oferta", "Error Oferta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       }

        private void btn_ofertar_Click(object sender, EventArgs e)
        {
            int oferta;
            try
            {
                oferta = int.Parse(tbox_oferta.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El campo oferta debe ser un entero", "Error Oferta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal anterior = decimal.Parse(montoAnterior);

            if (oferta <= anterior)
            {
                MessageBox.Show("La oferta propuesta debe ser un mayor que el monto anterior", "Error Oferta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (realizarOferta(idUsuario, idPublicacion, oferta))
            {
                MessageBox.Show("La oferta se ha realizado con éxito", "Oferta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Common busqueda = new Common();
                tablaPublicaciones.SelectedRows[0].SetValues(busqueda.actualizarPublicacion(tablaPublicaciones, idPublicacion));
            }
            else
            {
                MessageBox.Show("No se pudo registrar la oferta. Por favor, intente nuevamente.", "Error Oferta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean realizarOferta(int idUsuario, int idPublicacion, int monto)
        {
            Boolean resultadoRealizacionOferta;
            Conexion conexion = new Conexion();
            conexion.cnn.Open();
            resultadoRealizacionOferta = conexion.executeProcedure(conexion.getSchema() + @".SP_Realizar_Oferta",
                   Helper.Help.generarListaParaProcedure("@idUsuario", "@idPublicacion", "@monto"),
                   idUsuario, idPublicacion, monto);
            conexion.cnn.Close();
            return resultadoRealizacionOferta;
        }

    }
}
