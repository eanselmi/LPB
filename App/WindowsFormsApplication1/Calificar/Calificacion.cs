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
        public Calificacion(int idUsuario, decimal idPublicacion)
        {
            InitializeComponent();
            idUser = idUsuario;
            idPublic = idPublicacion;
            //Carga del combo Box Estrellas
            comboBoxEstrellas.Items.Add("1");
            comboBoxEstrellas.Items.Add("2");
            comboBoxEstrellas.Items.Add("3");
            comboBoxEstrellas.Items.Add("4");
            comboBoxEstrellas.Items.Add("5");
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
            this.Close();
        }

        private void comboBoxEstrellas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxEstrellas.SelectedItem != "")
            {
                groupBoxDetalle.Enabled = true;
            }
        }
    }
}
