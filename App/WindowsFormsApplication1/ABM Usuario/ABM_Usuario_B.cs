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

namespace visibilidad.ABM_Usuario
{
    public partial class ABM_Usuario_B : Form
    {
        DataTable tabla = new DataTable();

        public ABM_Usuario_B()
        {
            InitializeComponent();
        }

        private void ABM_Usuario_B_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.TopMost = true;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTipoU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxTipoU.Text.Equals("Cliente"))
            {
                groupBoxCliente.Visible = true;
            }
            if (this.comboBoxTipoU.Text.Equals("Empresa"))
            {
                groupBoxCliente.Visible = false;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
            tabla.Columns.Clear();

            //CREO LA QUERY PRINCIPAL
            String queryABuscar = "select documento_tipo as 'TIPO DOCUMENTO',documento_numero as 'NUMERO DOCUMENTO',nombre as 'NOMBRE',apellido as 'APELLIDO',mail as 'EMAIL' from LPB.Clientes where 1=1";
            
            //AGREGO LOS FILTROS SI LOS HAY
            if (!(textBoxNombe.Text.Equals("")))
            {
                queryABuscar=String.Concat(queryABuscar, " AND nombre like '%" + textBoxNombe.Text + "%'");
            }
            if (!(textBoxApellido.Text.Equals("")))
            {
                queryABuscar=String.Concat(queryABuscar, " AND apellido like '%" + textBoxApellido.Text + "%'");
            }
            if (!(textBoxEmail.Text.Equals("")))
            {
                queryABuscar=String.Concat(queryABuscar, " AND mail like '%" + textBoxEmail.Text + "%'");
            }
            if ((!(comboBoxTipoDoc.Text.Equals(""))) && (!(textBoxDNI.Text.Equals(""))))
            {
                if (comboBoxTipoDoc.Text.Equals("DNI"))
                {
                    queryABuscar=String.Concat(queryABuscar, " AND documento_tipo='DNI' AND documento_numero='" + textBoxDNI.Text + "'");
                }
                if (comboBoxTipoDoc.Text.Equals("CUIL"))
                {
                    queryABuscar=String.Concat(queryABuscar, " AND documento_tipo='CUIL' AND documento_numero='" + textBoxDNI.Text + "'");
                }
            }

            Conexion connQuery = new Conexion();
            connQuery.cnn.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(queryABuscar, connQuery.cnn);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(sqlAdapter);
            sqlAdapter.Fill(tabla);
            dataGridViewCliente.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewCliente.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            dataGridViewCliente.DataSource=tabla;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
            tabla.Columns.Clear();
        }
            
        
    }
}
