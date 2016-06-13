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
namespace visibilidad.Calificar
{
    public partial class Calificacion : Form
    {
        Conexion cn = new Conexion();
        private int idUser;
        private decimal idPublic;
        private int CuO;
        public Calificacion(int idUsuario, decimal idPublicacion, int compraUOferta)
        {
            InitializeComponent();
            idUser = idUsuario;
            idPublic = idPublicacion;
            CuO = compraUOferta;
            //Carga del combo Box Estrellas
            comboBoxEstrellas.Items.Add("1");
            comboBoxEstrellas.Items.Add("2");
            comboBoxEstrellas.Items.Add("3");
            comboBoxEstrellas.Items.Add("4");
            comboBoxEstrellas.Items.Add("5");
            //Carga del combo Box Detalle
            comboBoxDetalle.Items.Add("Positivo");
            comboBoxDetalle.Items.Add("Neutral");
            comboBoxDetalle.Items.Add("Negativo");
            this.textBox2.Text = idPublic.ToString();
        }




        private void buttonVolverCalificacion_Click(object sender, EventArgs e)
        {
            this.Close();
            Calificar.ComprasOfertasSinCalificar COSinCalificar = new Calificar.ComprasOfertasSinCalificar(idUser);
            COSinCalificar.Show();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            int estrella = int.Parse(comboBoxEstrellas.SelectedItem.ToString());
            List<string> lista = Helper.Help.generarListaParaProcedure("@Publicacion_cod", "@detalle", "@estrellas");
            Conexion cn = new Conexion();
            cn.cnn.Open();
            if (CuO == 1)
            {
                if (comboBoxDetalle.Text == "")
                {
                    string detalle = this.textBoxDetalleP.Text.ToString();
                     bool resultado = cn.executeProcedure(cn.getSchema() + @".SP_Insertar_Calificacion_Compras", lista, idPublic, detalle, estrella);
                     if (resultado)
                         MessageBox.Show("Ha calificado correctamente la Compra", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     else
                         MessageBox.Show("No se ha podido calificar la Compra", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string detalle = ((string)comboBoxDetalle.SelectedItem.ToString());
                    bool resultado = cn.executeProcedure(cn.getSchema() + @".SP_Insertar_Calificacion_Compras", lista, idPublic, detalle, estrella);
                    if (resultado)
                        MessageBox.Show("Ha calificado correctamente la Compra", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se ha podido calificar la Compra", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               
                
            }
            else
            {
                if (comboBoxDetalle.Text ==  "")
                {
                    string detalle = this.textBoxDetalleP.Text.ToString();
                   bool resultado = cn.executeProcedure(cn.getSchema() + @".SP_Insertar_Calificacion_Ofertas", lista, idPublic, detalle, estrella);
                   if (resultado)
                       MessageBox.Show("Ha calificado correctamente la Oferta", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   else
                       MessageBox.Show("No se ha podido calificar la Oferta", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string detalle = ((string)comboBoxDetalle.SelectedItem.ToString());
                   bool resultado = cn.executeProcedure(cn.getSchema() + @".SP_Insertar_Calificacion_Ofertas", lista, idPublic, detalle, estrella);
                   if (resultado)
                       MessageBox.Show("Ha calificado correctamente la Oferta", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   else
                       MessageBox.Show("No se ha podido calificar la Oferta", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            cn.cnn.Close();
            this.Close();

           
        }

        private void comboBoxEstrellas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxEstrellas.SelectedItem != "")
            {
                groupBoxDetalle.Enabled = true;
            }

        }

        private void comboBoxDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxDetalle.SelectedItem != "")
            {
                this.textBoxDetalleP.Enabled = false;
                buttonConfirmar.Enabled = true;
            }
            else
            {
                this.textBoxDetalleP.Enabled = true;
                buttonConfirmar.Enabled = false;
            }

          
        }

        private void textBoxDetalleP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxDetalleP.Text))
            {
                this.comboBoxDetalle.Enabled = true;
                buttonConfirmar.Enabled = false;
            }
            else
            {
                this.comboBoxDetalle.Enabled = false;
                buttonConfirmar.Enabled = true;
            }
        }
    }
}
