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
    public partial class ComprasOfertasSinCalificar : Form
    {
        Conexion cn = new Conexion();
        private int idUser;

        public ComprasOfertasSinCalificar(int idUsuario)
        {
            InitializeComponent();
            idUser = idUsuario;
            this.textBoxUser.Text = idUser.ToString();
        }


        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Calificar.Opciones options3 = new Calificar.Opciones(idUser);
            options3.Show();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<string> lista = Helper.Help.generarListaParaProcedure("@idUser");
            cn.cnn.Open();
            dt = cn.obtenerTablaSegunProcedure(cn.getSchema() + @".SP_Compras_Sin_Calificar", lista, idUser);
            cn.cnn.Close();
            this.dataGridViewCalificar.DataSource = dt;

            this.dataGridViewCalificar.Columns[3].Visible = false;
            this.dataGridViewCalificar.Columns[4].Visible = false;
            groupBoxCalificar.Visible = true;
            if (dataGridViewCalificar.Rows.Count != 0)
            {
                buttonCalificar.Enabled = true;
            }
            else
            {
                buttonCalificar.Enabled = false;
            }
            this.textBoxCompra.Text = "1";

     
        }

        private void buttonOfertas_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            List<string> lista = Helper.Help.generarListaParaProcedure("@idUser");
            cn.cnn.Open();
            dt1 = cn.obtenerTablaSegunProcedure(cn.getSchema() + @".SP_Ofertas_Sin_Calificar", lista, idUser);
            cn.cnn.Close();
            this.dataGridViewCalificar.DataSource = dt1;
            this.dataGridViewCalificar.Columns[3].Visible = false;
            this.dataGridViewCalificar.Columns[4].Visible = false;
            groupBoxCalificar.Visible = true;
            if (dataGridViewCalificar.Rows.Count != 0)
            {
                buttonCalificar.Enabled = true;
            }
            else
            {
                buttonCalificar.Enabled = false;
            }

            this.textBoxCompra.Text = "0";
     
        }

        private void buttonCalificar_Click(object sender, EventArgs e)
        {
            int CuO = Int32.Parse(this.textBoxCompra.Text.ToString());
            string vendedor = dataGridViewCalificar.SelectedCells[3].Value.ToString();
            string operacion = dataGridViewCalificar.SelectedCells[4].Value.ToString();
            this.Close();
            Calificar.Calificacion calificacion = new Calificar.Calificacion(idUser, CuO, Convert.ToInt32(vendedor), Convert.ToInt32(operacion));
            calificacion.Show();
        }

        private void ComprasOfertasSinCalificar_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }


    }
}

