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
    public partial class Opciones : Form
    {
        private int idUsuario;
  
        public Opciones(int id_usuario)
        {
            InitializeComponent();
            idUsuario = id_usuario;
            // Propiedades de la ventada de opciones
            this.TopMost = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            this.Close();
            Calificar.Historial historial = new Calificar.Historial(idUsuario);
            historial.Show();
        }

        private void buttonInforme_Click(object sender, EventArgs e)
        {
            this.Close();
            Calificar.Informe informe = new Calificar.Informe(idUsuario);
            informe.Show();
        }

        private void buttonIniciarCalificar_Click(object sender, EventArgs e)
        {
            this.Close();
            Calificar.ComprasOfertasSinCalificar COSinCalificar = new Calificar.ComprasOfertasSinCalificar(idUsuario);
            COSinCalificar.Show();
        }
    }
}
