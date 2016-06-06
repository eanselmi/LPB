using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;
using conectar;
using System.Data.SqlClient;

namespace visibilidad.Historial_Cliente
{
    public partial class HistorialCliente : Form
    {
        private int idUsuario;

        public HistorialCliente(int idUser)
        {
            InitializeComponent();
            idUsuario = idUser;
            Conexion datosCliente = new Conexion();
            string queryCliente = "select documento_tipo,documento_numero,apellido,nombre,fechaNacimiento,mail,telefono,domicilioCalle,nroCalle,piso,dpto,codPostal,Localidad_id from LPB.Clientes where Usuario_id='"+idUsuario+"'";
            datosCliente.cnn.Open();
            SqlCommand comandoCliente = new SqlCommand(queryCliente, datosCliente.cnn);
            SqlDataReader lectorCliente = comandoCliente.ExecuteReader();
            lectorCliente.Read();
            labelTipoDoc.Text = lectorCliente.GetString(0);
            labelNumeroDoc.Text = lectorCliente.GetDecimal(1).ToString();
            labelApellido.Text = lectorCliente.GetString(2);
            labelNombreCliente.Text = lectorCliente.GetString(3);
            labelFechaNac.Text = lectorCliente.GetDateTime(4).ToShortDateString();
            labelMail.Text = lectorCliente.GetString(5);
            if (!(lectorCliente.IsDBNull(6)))
            {
                labelTelefono.Text = lectorCliente.GetDecimal(6).ToString();
            }
            labelCalle.Text = lectorCliente.GetString(7);
            labelNroCalle.Text = lectorCliente.GetDecimal(8).ToString();
            if (!(lectorCliente.IsDBNull(9)))
            {
                labelPiso.Text = lectorCliente.GetDecimal(9).ToString();
            }
            if (!(lectorCliente.IsDBNull(10)))
            {
                labelDpto.Text = lectorCliente.GetString(10);
            }
            labelCodPostal.Text = lectorCliente.GetString(11);
            int localidad_id = 0;
            if (!(lectorCliente.IsDBNull(12)))
            {
                localidad_id = lectorCliente.GetInt32(12);
            }
            datosCliente.cnn.Close();

            if (localidad_id != 0)
            {
                Conexion buscarLocalidad = new Conexion();
                string queryLocalidad = "select descripcion from LPB.Localidades where id='"+localidad_id+"'";
                buscarLocalidad.cnn.Open();
                SqlCommand comandoLocalidad = new SqlCommand(queryLocalidad, buscarLocalidad.cnn);
                SqlDataReader lectorLoc = comandoLocalidad.ExecuteReader();
                lectorLoc.Read();
                labelLocalidad.Text = lectorLoc.GetString(0);
                buscarLocalidad.cnn.Close();
            }

        }


        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.TopMost = true;
        }

    }
}
