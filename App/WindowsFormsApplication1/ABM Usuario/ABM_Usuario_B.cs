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
        private DataTable tabla = new DataTable();
        private string modalidad;

        public ABM_Usuario_B(string modo)
        {
            InitializeComponent();
            this.modalidad = modo;
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
                groupBoxEmpresa.Visible = false;
                this.buttonBuscar.Enabled = true;
            }
            if (this.comboBoxTipoU.Text.Equals("Empresa"))
            {
                groupBoxEmpresa.Visible = true;
                groupBoxCliente.Visible = false;
                this.buttonBuscar.Enabled = true;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
            tabla.Columns.Clear();
            String queryABuscar = "";

            //Creo la query para buscar distinguiendo si seleccione un Cliente o una Empresa
            //Si es CLIENTE
            if (this.comboBoxTipoU.Text.Equals("Cliente"))
            {
                //CREO LA QUERY PRINCIPAL
                queryABuscar = string.Concat(queryABuscar,"select documento_tipo as 'TIPO DOCUMENTO',documento_numero as 'NUMERO DOCUMENTO',nombre as 'NOMBRE',apellido as 'APELLIDO',mail as 'EMAIL' from LPB.Clientes where 1=1");

                //AGREGO LOS FILTROS SI LOS HAY
                if (!(textBoxNombe.Text.Equals("")))
                {
                    queryABuscar = String.Concat(queryABuscar, " AND nombre like '%" + textBoxNombe.Text + "%'");
                }
                if (!(textBoxApellido.Text.Equals("")))
                {
                    queryABuscar = String.Concat(queryABuscar, " AND apellido like '%" + textBoxApellido.Text + "%'");
                }
                if (!(textBoxEmail.Text.Equals("")))
                {
                    queryABuscar = String.Concat(queryABuscar, " AND mail like '%" + textBoxEmail.Text + "%'");
                }
                if ((!(comboBoxTipoDoc.Text.Equals(""))) && (!(textBoxDNI.Text.Equals(""))))
                {
                    if (comboBoxTipoDoc.Text.Equals("DNI"))
                    {
                        queryABuscar = String.Concat(queryABuscar, " AND documento_tipo='DNI' AND documento_numero='" + textBoxDNI.Text + "'");
                    }
                    if (comboBoxTipoDoc.Text.Equals("CUIL"))
                    {
                        queryABuscar = String.Concat(queryABuscar, " AND documento_tipo='CUIL' AND documento_numero='" + textBoxDNI.Text + "'");
                    }
                }
            }

            //Si es EMPRESA
            if(this.comboBoxTipoU.Text.Equals("Empresa")){
                //CREO LA QUERY PRINCIPAL
                queryABuscar=string.Concat(queryABuscar,"select razonSocial as RAZON SOCIAL, cuit as CUIT, mail as EMAIL from LPB.Empresas where 1=1");

                //AGREGO LOS FILTROS SI ES QUE HAY
                if(!(textBoxRazonSoc.Text.Equals(""))){
                    queryABuscar=string.Concat(queryABuscar," AND razonSocial like '%"+textBoxRazonSoc.Text+"%'");
                }
                if((!(textBoxCUITTipo.Text.Equals("")))||(!(textBoxCUITNro.Text.Equals("")))||(!(textBoxCUITVerif.Text.Equals("")))){
                    queryABuscar=string.Concat(queryABuscar," AND cuit = '"+textBoxCUITTipo.Text+"-"+textBoxCUITNro.Text+"-"+textBoxCUITVerif.Text+"'");
                }
                if(!(textBoxEmailEmp.Text.Equals(""))){
                    queryABuscar=string.Concat(queryABuscar," AND mail like '%"+textBoxEmailEmp.Text+"%'");
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
            textBoxDNI.Text = "";
            textBoxEmail.Text = "";
            textBoxNombe.Text = "";
            textBoxApellido.Text = "";
            comboBoxTipoDoc.SelectedIndex = -1;
            textBoxCUITNro.Text = "";
            textBoxCUITTipo.Text = "";
            textBoxCUITVerif.Text = "";
            textBoxEmailEmp.Text = "";
            textBoxRazonSoc.Text = "";
            buttonProceder.Enabled = false;
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonProceder.Enabled = true;
        }

        private void buttonProceder_Click(object sender, EventArgs e)
        {
            if (modalidad.Equals("Baja"))
            {
                switch (MessageBox.Show("¿Desea proceder con la baja del usuario seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        {
                            string username = "";

                            //Si es cliente busco el username desde el cliente
                            if (comboBoxTipoU.Text.Equals("Cliente"))
                            {
                                string tipoDoc = dataGridViewCliente.SelectedCells[0].Value.ToString();
                                string numDoc = dataGridViewCliente.SelectedCells[1].Value.ToString();
                                //OBTENGO EL USERNAME
                                string queryObtenerUsername = "select username from lpb.Usuarios where id in (select Usuario_id from LPB.Clientes where documento_tipo='" + tipoDoc + "' and documento_numero='" + numDoc + "')";
                                Conexion connObtener = new Conexion();
                                connObtener.cnn.Open();
                                SqlCommand command = new SqlCommand(queryObtenerUsername, connObtener.cnn);
                                SqlDataReader lector = command.ExecuteReader();
                                lector.Read();
                                username = lector.GetString(0);
                                connObtener.cnn.Close();
                            }

                            //Si es Empresa busco el username desde la empresa
                            if (comboBoxTipoU.Text.Equals("Empresa"))
                            {
                                string cuit = dataGridViewCliente.SelectedCells[0].Value.ToString();
                                //OBTENGO EL USERNAME
                                string queryObtenerUsername = "select username from lpb.Usuarios where id in (select Usuario_id from LPB.Empresas where cuit='" + cuit + "')";
                                Conexion connObtener = new Conexion();
                                connObtener.cnn.Open();
                                SqlCommand command = new SqlCommand(queryObtenerUsername, connObtener.cnn);
                                SqlDataReader lector = command.ExecuteReader();
                                lector.Read();
                                username = lector.GetString(0);
                                connObtener.cnn.Close();
                            }

                            Conexion bajaUsuario = new Conexion();
                            bajaUsuario.cnn.Open();

                            //BAJA USUARIO
                            bool resultadoBaja = bajaUsuario.executeProcedure(bajaUsuario.getSchema() + @".SP_Baja_Usuario",
                                Helper.Help.generarListaParaProcedure("@username"), username);

                            bajaUsuario.cnn.Close();

                            if (resultadoBaja)
                            {
                                MessageBox.Show("Baja del usuario exitosa!", "Mensaje..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo realizar la baja del usuario", "Mensaje..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            break;
                        }
                }
            }
            if (modalidad.Equals("Modificacion"))
            {
                switch (MessageBox.Show("¿Desea modificar el usuario seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        {
                            string username = "";

                            //Si es cliente busco el username desde el cliente
                            if (comboBoxTipoU.Text.Equals("Cliente"))
                            {
                                string tipoDoc = dataGridViewCliente.SelectedCells[0].Value.ToString();
                                string numDoc = dataGridViewCliente.SelectedCells[1].Value.ToString();
                                //OBTENGO EL USERNAME
                                string queryObtenerUsername = "select username from lpb.Usuarios where id in (select Usuario_id from LPB.Clientes where documento_tipo='" + tipoDoc + "' and documento_numero='" + numDoc + "')";
                                Conexion connObtener = new Conexion();
                                connObtener.cnn.Open();
                                SqlCommand command = new SqlCommand(queryObtenerUsername, connObtener.cnn);
                                SqlDataReader lector = command.ExecuteReader();
                                lector.Read();
                                username = lector.GetString(0);
                                connObtener.cnn.Close();
                            }

                            //Si es Empresa busco el username desde la empresa
                            if (comboBoxTipoU.Text.Equals("Empresa"))
                            {
                                string cuit = dataGridViewCliente.SelectedCells[0].Value.ToString();
                                //OBTENGO EL USERNAME
                                string queryObtenerUsername = "select username from lpb.Usuarios where id in (select Usuario_id from LPB.Empresas where cuit='" + cuit + "')";
                                Conexion connObtener = new Conexion();
                                connObtener.cnn.Open();
                                SqlCommand command = new SqlCommand(queryObtenerUsername, connObtener.cnn);
                                SqlDataReader lector = command.ExecuteReader();
                                lector.Read();
                                username = lector.GetString(0);
                                connObtener.cnn.Close();
                            }
                            ABM_Usuario_A modificaU = new ABM_Usuario_A();
                            modificaU.Show();
                            this.Close();
                            break;
                        }
                }
            }
        }
            
        
    }
}
