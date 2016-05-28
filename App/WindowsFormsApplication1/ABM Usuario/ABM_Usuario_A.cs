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

namespace visibilidad.ABM_Usuario
{
    public partial class ABM_Usuario_A : Form
    {

        public ABM_Usuario_A()
        {
            InitializeComponent();

            /*CARGA LAS LOCALIDADES EN EL COMBOBOX*/

            Conexion con = new Conexion();
            string query = "SELECT descripcion FROM lpb.Localidades";
            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
            {
                comboBoxLocalidades.Items.Add(lector.GetString(0));
                comboBoxLocalidadEmpr.Items.Add(lector.GetString(0));
            }
            con.cnn.Close();

            /*CARGA LOS RUBROS DE EMPRESA EN EL COMBOBOX*/

            Conexion conEm = new Conexion();
            string queryEm = "SELECT descripcion FROM lpb.RubrosEmpresa";
            conEm.cnn.Open();
            SqlCommand commandEm = new SqlCommand(queryEm, conEm.cnn);
            SqlDataReader lectorEm = commandEm.ExecuteReader();
            while (lectorEm.Read())
            {
                comboBoxRubro.Items.Add(lectorEm.GetString(0));
            }
            conEm.cnn.Close();

            /*CARGA LOS ROLES EN LOS LISTBOX*/
            //Cliente
            Conexion conRolesC = new Conexion();
            string queryRolesC = "SELECT nombre FROM lpb.Roles where nombre not in ('Administrador','Empresa')";
            conRolesC.cnn.Open();
            SqlCommand commandRolesC = new SqlCommand(queryRolesC, conRolesC.cnn);
            SqlDataReader lectorRolesC = commandRolesC.ExecuteReader();
            while (lectorRolesC.Read())
            {
                CheckedListBoxCli.Items.Add(lectorRolesC.GetString(0));
            }
            conRolesC.cnn.Close();

            Conexion conRolesE = new Conexion();
            string queryRolesE = "SELECT nombre FROM lpb.Roles where nombre not in ('Administrador','Cliente')";
            conRolesE.cnn.Open();
            SqlCommand commandRolesE = new SqlCommand(queryRolesE, conRolesE.cnn);
            SqlDataReader lectorRolesE = commandRolesE.ExecuteReader();
            while (lectorRolesE.Read())
            {
                CheckedListBoxEmp.Items.Add(lectorRolesE.GetString(0));
            }
            conRolesE.cnn.Close();

        }

        private void ABM_Usuario_A_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.TopMost = true;
        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxRol.Text.Equals("Cliente"))
            {
                groupBoxCliente.Visible = true;
                groupBoxEmpresa.Visible = false;
            }

            if (comboBoxRol.Text.Equals("Empresa"))
            {
                groupBoxEmpresa.Visible = true;
                groupBoxCliente.Visible = false;
            }

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = false;
            textBoxFechaNac.Text = monthCalendar1.SelectionStart.Date.ToShortDateString();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //GUARDAR UN CLIENTE

            if (comboBoxRol.Text.Equals("Cliente"))
            {
                // VALIDACION DE CAMPOS OBLIGATORIOS
                String mensajeDeError="Se produjeron los siguientes errores:\n";
                bool hayError = false;
                if (textBoxUser.Text.Equals("") || textBoxPass.Text.Equals("") || textBoxConfirmarPass.Text.Equals("")
                    || textBoxNombre.Text.Equals("") || textBoxApellido.Text.Equals("") || textBoxMail.Text.Equals("")
                    || textBoxTelefono.Text.Equals("") || textBoxCalleCl.Text.Equals("") || textBoxCodPostCl.Text.Equals("")
                    || textBoxNumeroDoc.Text.Equals("") || comboBoxTipoDoc.Text.Equals("") || textBoxNroCl.Text.Equals("")
                    || comboBoxLocalidades.Text.Equals("") || textBoxPisoCl.Text.Equals("") || textBoxFechaNac.Text.Equals("")
                    )
                {
                    hayError = true;
                    mensajeDeError = String.Concat(mensajeDeError, "\tHay campos obligatorios vacios\n");
                }

                //VALIDACION DE CONFIRMAR PASSWORD
                if (!(textBoxPass.Text.Equals(textBoxConfirmarPass.Text)))
                {
                    hayError = true;
                    mensajeDeError = String.Concat(mensajeDeError, "\tLos campos Password y Confirmar Password no coinciden\n");  
                }

                //VALIDACION TIPO DE DATOS
                //USERNAME
                if (textBoxUser.Text.Length.CompareTo(45) == 1)
                {
                    hayError = true;
                    mensajeDeError = String.Concat(mensajeDeError, "\tUsername demasiado largo\n");
                }

                //NOMBRE
                if (!(textBoxNombre.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxNombre.Text, "^\\D+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tSolo puede haber letras en el nombre\n");
                    }
                }

                //APELLIDO
                if (!(textBoxApellido.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxApellido.Text, "^\\D+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tSolo puede haber letras en el apellido\n");
                    }
                }

                //NUMERO DOC
                if ((!(textBoxNumeroDoc.Text.Equals(""))) && comboBoxTipoDoc.Text.Equals("DNI")) 
                {
                    if (!(Regex.Match(textBoxNumeroDoc.Text, "^\\d+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tIngrese el DNI numérico y sin .\n");
                    }
                    if (textBoxNumeroDoc.Text.Length.CompareTo(8) == 1)
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl DNI no puede ser tan largo\n");
                    }
                }

                if ((!(textBoxNumeroDoc.Text.Equals(""))) && comboBoxTipoDoc.Text.Equals("CUIL"))
                {
                    if (!(Regex.Match(textBoxNumeroDoc.Text, "^\\d+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tIngrese para el CUIL solo numeros\n");
                    }
                    if (textBoxNumeroDoc.Text.Length.CompareTo(11) != 0)
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl número de CUIL debe ser de 11 caracteres\n");
                    }
                }

                //MAIL

                if(!(textBoxMail.Text.Equals("")))
                {
                    if(!(Regex.Match(textBoxMail.Text, "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,3})$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl mail ingresado no es válido\n");
                    }
                }

                //TELEFONO
                if (!(textBoxTelefono.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxTelefono.Text, "^(11|15)\\d+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl número telefónico debe ser solo numérico y debe comenzar con 011 o 15\n");
                    }
                    if (textBoxTelefono.Text.Length.CompareTo(10)!=0)
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl número de teléfono debe ser de 10 dígitos\n");
                    }
                }

                //NUMERO DE CALLE

                if (!(textBoxNroCl.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxNroCl.Text, "^\\d+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tIngrese el número de la dirección solo con números\n");
                    }
                    if (textBoxNroCl.Text.Length.CompareTo(5) == 1)
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl número de la dirección debe ser como máximo de 5 dígitos\n");
                    }
                }

                //PISO 

                if (!(textBoxPisoCl.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxPisoCl.Text, "^\\d\\d?$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl piso debe ser numérico (Si desea indicar planta baja, ingrese 0) y hasta dos dígitos\n");
                    }
                }

                //DPTO

                if (!(textBoxDptoCl.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxDptoCl.Text, "^([A-Z]|[0-9]{1,2})$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl dpto debe ser una letra de A a Z, o bien numérico, hasta dos dígitos\n");
                    }
                }

                //CODIGO POSTAL

                if (!(textBoxCodPostCl.Text.Equals(""))) 
                {
                    if (!(Regex.Match(textBoxCodPostCl.Text, "^([0-9]{4}|[0-9A-Z]{8})$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl código postal debe ser numérico de 4 caractéres o alfanumérico de 8 caractéres\n");
                    }
                }

                //ROLES
                if (CheckedListBoxCli.CheckedItems.Count == 0)
                {
                    hayError = true;
                    mensajeDeError = String.Concat(mensajeDeError, "\tNo selecciono ningún rol\n");
                }

                //VALIDACION DNI ÚNICO

                if (!(textBoxNumeroDoc.Text.Equals("")) && comboBoxTipoDoc.Text.Equals("DNI"))
                {
                    Conexion conDNI = new Conexion();
                    string queryDNI = "Select * from LPB.Clientes where documento_tipo='DNI' and documento_numero = '" + textBoxNumeroDoc.Text + "'";
                    conDNI.cnn.Open();
                    SqlCommand commandDNI = new SqlCommand(queryDNI, conDNI.cnn);
                    SqlDataReader lectorDNI = commandDNI.ExecuteReader();
                    if (lectorDNI.Read())
                    {
                        hayError = true;
                        mensajeDeError = string.Concat(mensajeDeError, "\tYa existe un usuario con ese número de DNI\n");
                    }
                    conDNI.cnn.Close();
                }

                //VALIDACION CUIL ÚNICO

                if (!(textBoxNumeroDoc.Text.Equals("")) && comboBoxTipoDoc.Text.Equals("CUIL"))
                {
                    Conexion conDNI = new Conexion();
                    string queryDNI = "Select * from LPB.Clientes where documento_tipo='CUIL' and documento_numero = '" + textBoxNumeroDoc.Text + "'";
                    conDNI.cnn.Open();
                    SqlCommand commandDNI = new SqlCommand(queryDNI, conDNI.cnn);
                    SqlDataReader lectorDNI = commandDNI.ExecuteReader();
                    if (lectorDNI.Read())
                    {
                        hayError = true;
                        mensajeDeError = string.Concat(mensajeDeError, "\tYa existe un usuario con ese número de CUIL\n");
                    }
                    conDNI.cnn.Close();
                }

                //VALIDACION USERNAME ÚNICO

                if (!(textBoxUser.Text.Equals("")))
                {
                    Conexion conUser = new Conexion();
                    string queryUser = "Select * from LPB.Usuarios where username = '" + textBoxUser.Text + "'";
                    conUser.cnn.Open();
                    SqlCommand commandUser = new SqlCommand(queryUser, conUser.cnn);
                    SqlDataReader lectorUser = commandUser.ExecuteReader();
                    if (lectorUser.Read())
                    {
                        hayError = true;
                        mensajeDeError = string.Concat(mensajeDeError, "\tYa existe un usuario con ese username\n");
                    }
                    conUser.cnn.Close();
                }

                //SI HAY ERRORES LOS MUESTRO A TODOS
                if (hayError)
                {
                    MessageBox.Show(mensajeDeError, "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //SI NO HAY ERRORES PROCEDO CON LA CARGA
                Conexion cargaUsuario = new Conexion();
                cargaUsuario.cnn.Open();

                //CARGA CLIENTE

                bool resultadoCliente = cargaUsuario.executeProcedure(cargaUsuario.getSchema() + @".SP_Alta_Cliente",
                    Helper.Help.generarListaParaProcedure("@username","@pass","@tipoDoc","@numeroDoc", "@apellido", "@nombre", "@fechaNac", "@mail", "@telefono", "@calle",
                    "@nroCalle", "@piso", "@dpto", "@codPostal", "@descrpLocalidad", "@user")
                    ,this.textBoxUser.Text,Helper.Help.Sha256(this.textBoxPass.Text), this.comboBoxTipoDoc.Text, this.textBoxNumeroDoc.Text, this.textBoxApellido.Text, this.textBoxNombre.Text, this.monthCalendar1.SelectionStart.Date,
                    this.textBoxMail.Text, this.textBoxTelefono.Text, this.textBoxCalleCl.Text, this.textBoxNroCl.Text, this.textBoxPisoCl.Text,
                    this.textBoxDptoCl.Text, this.textBoxCodPostCl.Text, this.comboBoxLocalidades.Text, this.textBoxUser.Text);
                // Hay que ver que pasa cuando dpto va null//

                //Asignacion Roles
                foreach (object itemChecked in CheckedListBoxCli.CheckedItems)
                {
                    bool resultadoRoles = cargaUsuario.executeProcedure(cargaUsuario.getSchema() + @".SP_Asignacion_Rol_Usuario",
                        Helper.Help.generarListaParaProcedure("@username", "@nombreRol"), this.textBoxUser.Text, itemChecked.ToString());
                    if (!resultadoRoles)
                        MessageBox.Show("Problema en la asignacion de roles al usuario, modificar luego", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //VERIFICACION ÉXITO POSITIVO
                if (resultadoCliente)
                    MessageBox.Show("Alta de usuario realizada con éxito", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El Usuario no pudo ser dado de alta", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cargaUsuario.cnn.Close();
                this.Close();
                return;
            }

            if (comboBoxRol.Text.Equals("Empresa"))
            {
                if (textBoxUser.Text.Equals("") || textBoxPass.Text.Equals("") || textBoxConfirmarPass.Text.Equals(""))
                {
                    MessageBox.Show("Campos obligatorios vacios", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                return;
            }


            MessageBox.Show("Seleccione tipo de usuario: Cliente o Empresa", "Error al guardar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxApellido.Text = "";
            textBoxCalleCl.Text = "";
            textBoxCodPostCl.Text = "";
            textboxcodpostEmpr.Text = "";
            textBoxConfirmarPass.Text = "";
            textBoxCUIT.Text = "";
            textBoxDptoCl.Text = "";
            textboxDptoEmpr.Text = "";
            textBoxFechaNac.Text = "";
            textBoxLocalidadCl.Text = "";
            textboxLocalidadEmp.Text = "";
            textboxLocalidadEmpr.Text = "";
            textBoxMail.Text = "";
            textBoxMailEmp.Text = "";
            textBoxNombre.Text = "";
            textBoxNombreContacto.Text = "";
            textBoxNroCl.Text = "";
            textboxNroEmpr.Text = "";
            textBoxNumeroDoc.Text = "";
            textBoxPass.Text = "";
            textBoxPisoCl.Text = "";
            textboxPisoEmpr.Text = "";
            textBoxRazonSocial.Text = "";
            textBoxTelefono.Text = "";
            textBoxTelefonoEmp.Text = "";
            textBoxUser.Text = "";
            comboBoxLocalidades.SelectedIndex = -1;
            comboBoxLocalidadEmpr.SelectedIndex = -1;
            comboBoxTipoDoc.SelectedIndex = -1;
            comboBoxRubro.SelectedIndex = -1;
            int iCli = CheckedListBoxCli.Items.Count - 1;
            int iEmp = CheckedListBoxEmp.Items.Count - 1;
            while (iCli > -1)
            {
                CheckedListBoxCli.SetItemChecked(iCli, false);
                iCli--;
            }
            
            while (iEmp > -1)
            {
                CheckedListBoxEmp.SetItemChecked(iEmp, false);
                iEmp--;
            }
        }


 
    }
}
