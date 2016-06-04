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
        private string modalidad = "";
        private string userAModificar = "";
        
        //DATOS PARA MODIFICAR USUARIO
        private string passwordVieja = ""; //En caso de que haya que modificar la password

        public ABM_Usuario_A(string modo, string username)
        {
            InitializeComponent();
            modalidad = modo;
            userAModificar = username;

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

            //SI SE LEVANTA EN MODO MODIFICACION, CARGO LOS DATOS DEL USUARIO 
            if(modalidad.Equals("Modificacion")){
                //Busco el usuario
                Conexion buscarUsuario = new Conexion();
                buscarUsuario.cnn.Open();
                string queryBuscarUsuario="select id,TipoUsuario,username,pass,habilitado from LPB.Usuarios where username='"+userAModificar+"'";
                SqlCommand commandBuscarUsuario=new SqlCommand(queryBuscarUsuario,buscarUsuario.cnn);
                SqlDataReader lectorBuscarUsuario = commandBuscarUsuario.ExecuteReader();
                lectorBuscarUsuario.Read();
                int idUser= lectorBuscarUsuario.GetInt32(0);
                comboBoxRol.Text=lectorBuscarUsuario.GetString(1);
                textBoxUser.Text=lectorBuscarUsuario.GetString(2);
                passwordVieja=lectorBuscarUsuario.GetString(3);
                bool userHabilitado = lectorBuscarUsuario.GetBoolean(4);
                buscarUsuario.cnn.Close();

                textBoxPass.Text="12345678"; //Muestro 8 caracteres cualquiera con *, luego si la quiere modificar comparo con la de verdad
                textBoxConfirmarPass.Text = "12345678";
                textBoxUser.Enabled=false;
                textBoxPass.Enabled=false;
                textBoxConfirmarPass.Enabled = false;
                buttonCambiarPass.Visible = true;
                comboBoxRol.Enabled=false;
                checkBoxHabilitado.Visible = true;
                if (userHabilitado)
                {
                    checkBoxHabilitado.Checked = true;
                }
                else
                {
                    checkBoxHabilitado.Checked = false;
                }

                //Cargo los datos de CLIENTE
                if (comboBoxRol.Text.Equals("Cliente"))
                {   
                    //BUSCO LOS CAMPOS
                    Conexion buscarCliente = new Conexion();
                    buscarCliente.cnn.Open();
                    string queryBuscarCliente = "select documento_tipo,documento_numero,apellido,nombre,fechaNacimiento,mail,telefono,domicilioCalle,nroCalle,piso,dpto,codPostal,Localidad_id from LPB.Clientes where Usuario_id='" + idUser + "'";
                    SqlCommand commandBuscarCliente = new SqlCommand(queryBuscarCliente, buscarCliente.cnn);
                    SqlDataReader lectorBuscarCliente = commandBuscarCliente.ExecuteReader();
                    lectorBuscarCliente.Read();
                    comboBoxTipoDoc.Text = lectorBuscarCliente.GetString(0);
                    textBoxNumeroDoc.Text = lectorBuscarCliente.GetDecimal(1).ToString();
                    textBoxApellido.Text = lectorBuscarCliente.GetString(2);
                    textBoxNombre.Text = lectorBuscarCliente.GetString(3);
                    monthCalendar1.SetDate(lectorBuscarCliente.GetDateTime(4));
                    textBoxFechaNac.Text = monthCalendar1.SelectionStart.Date.ToShortDateString();
                    textBoxMail.Text = lectorBuscarCliente.GetString(5);
                    
                    if (!(lectorBuscarCliente.IsDBNull(6)))
                    {
                        textBoxTelefono.Text = lectorBuscarCliente.GetDecimal(6).ToString();
                    }
                    
                    textBoxCalleCl.Text = lectorBuscarCliente.GetString(7);
                    textBoxNroCl.Text = lectorBuscarCliente.GetDecimal(8).ToString();

                    if (!(lectorBuscarCliente.IsDBNull(9)))
                    {
                        decimal pisoCliente = lectorBuscarCliente.GetDecimal(9);
                        if (pisoCliente == 0) textBoxPisoCl.Text="PB";
                        else textBoxPisoCl.Text=pisoCliente.ToString();
                    }

                    if(!(lectorBuscarCliente.IsDBNull(10)))
                    {
                        textBoxDptoCl.Text=lectorBuscarCliente.GetString(10);
                    }

                    textBoxCodPostCl.Text=lectorBuscarCliente.GetString(11);
                    int localidadId=0;
                    if (!(lectorBuscarCliente.IsDBNull(12)))
                    {
                        localidadId = lectorBuscarCliente.GetInt32(12);
                    }
                    buscarCliente.cnn.Close();

                    if (localidadId != 0)
                    {
                        Conexion buscarLocalidadCli = new Conexion();
                        string queryBuscarLocalidadCli = "select descripcion from LPB.Localidades where id='" + localidadId + "'";
                        buscarLocalidadCli.cnn.Open();
                        SqlCommand commandBuscarLocalidadCli = new SqlCommand(queryBuscarLocalidadCli, buscarLocalidadCli.cnn);
                        SqlDataReader lectorLocalidadCli = commandBuscarLocalidadCli.ExecuteReader();
                        lectorLocalidadCli.Read();
                        comboBoxLocalidades.Text = lectorLocalidadCli.GetString(0);
                        buscarLocalidadCli.cnn.Close();
                    }

                    
                    //Cargo los Roles
                    Conexion buscarRoles = new Conexion();
                    buscarRoles.cnn.Open();
                    string queryBuscarRoles = "select nombre from LPB.Roles where id in (select Rol_id from LPB.RolesPorUsuario where Usuario_id='" + idUser + "')";
                    SqlCommand commandBuscarRoles = new SqlCommand(queryBuscarRoles, buscarRoles.cnn);
                    SqlDataReader lectorBuscarRoles = commandBuscarRoles.ExecuteReader();
                    while (lectorBuscarRoles.Read())
                    {
                        int posicionaChequear=CheckedListBoxCli.FindStringExact(lectorBuscarRoles.GetString(0), 0);        
                        CheckedListBoxCli.SetItemChecked(posicionaChequear, true);
                    }
                    buscarRoles.cnn.Close();
                }

                //Cargo los datos de EMPRESA
                if (comboBoxRol.Text.Equals("Empresa"))
                {
                    Conexion buscarEmpresa = new Conexion();
                    buscarEmpresa.cnn.Open();
                    string queryBuscarEmpresa = "select razonSocial,cuit,mail,telefono,domicilioCalle,nroCalle,piso,dpto,codPostal,Rubro_id,nombreContacto,Localidad_id from LPB.Empresas where Usuario_id='" + idUser + "'";
                    SqlCommand commandBuscarEmpresa = new SqlCommand(queryBuscarEmpresa, buscarEmpresa.cnn);
                    SqlDataReader lectorBuscarEmpresa = commandBuscarEmpresa.ExecuteReader();
                    lectorBuscarEmpresa.Read();
                    textBoxRazonSocial.Text = lectorBuscarEmpresa.GetString(0);
                    textBoxCUITTipo.Text = lectorBuscarEmpresa.GetString(1).Substring(0, 2);
                    textBoxCUITNro.Text = lectorBuscarEmpresa.GetString(1).Substring(3, 8);
                    if (lectorBuscarEmpresa.IsDBNull(9))
                    {
                        textBoxCUITVerif.Text = lectorBuscarEmpresa.GetString(1).Substring(12, 2);
                    }
                    else
                    {
                        textBoxCUITVerif.Text = lectorBuscarEmpresa.GetString(1).Substring(12, 1);
                    }
                    textBoxMailEmp.Text = lectorBuscarEmpresa.GetString(2);

                    if (!(lectorBuscarEmpresa.IsDBNull(3)))
                    {
                        textBoxTelefonoEmp.Text = lectorBuscarEmpresa.GetDecimal(3).ToString();
                    }

                    textBoxCalleEmp.Text = lectorBuscarEmpresa.GetString(4);
                    textboxNroEmpr.Text = lectorBuscarEmpresa.GetDecimal(5).ToString();
                    
                    if (!(lectorBuscarEmpresa.IsDBNull(6)))
                    {
                        decimal pisoEmpresa = lectorBuscarEmpresa.GetDecimal(6);
                        if (pisoEmpresa == 0) textboxPisoEmpr.Text = "PB";
                        else textboxPisoEmpr.Text=pisoEmpresa.ToString();
                    }

                    if(!(lectorBuscarEmpresa.IsDBNull(7)))
                    {
                        textboxDptoEmpr.Text =lectorBuscarEmpresa.GetString(7);
                    }

                    textboxcodpostEmpr.Text = lectorBuscarEmpresa.GetString(8);

                    int rubroID = 0;
                    if (!(lectorBuscarEmpresa.IsDBNull(9)))
                    {
                        rubroID = lectorBuscarEmpresa.GetInt32(9);
                    }

                    if (!(lectorBuscarEmpresa.IsDBNull(10)))
                    {
                        textBoxNombreContacto.Text = lectorBuscarEmpresa.GetString(10);
                    }

                    int localidadID = 0;
                    if (!(lectorBuscarEmpresa.IsDBNull(11)))
                    {
                        localidadID = lectorBuscarEmpresa.GetInt32(11);
                    }
                    buscarEmpresa.cnn.Close();

                    if (localidadID != 0)
                    {
                        Conexion buscarLocalidadEmp = new Conexion();
                        string queryBuscarLocalidadEmp = "select descripcion from LPB.Localidades where id='" + localidadID + "'";
                        buscarLocalidadEmp.cnn.Open();
                        SqlCommand commandBuscarLocalidadEmp = new SqlCommand(queryBuscarLocalidadEmp, buscarLocalidadEmp.cnn);
                        SqlDataReader lectorLocalidadEmp = commandBuscarLocalidadEmp.ExecuteReader();
                        lectorLocalidadEmp.Read();
                        comboBoxLocalidadEmpr.Text = lectorLocalidadEmp.GetString(0);
                        buscarLocalidadEmp.cnn.Close();
                    }
                    if (rubroID != 0)
                    {
                        Conexion buscarRubroEmp = new Conexion();
                        string queryBuscarRubroEmp = "select descripcion from LPB.RubrosEmpresa where id='" + rubroID + "'";
                        buscarRubroEmp.cnn.Open();
                        SqlCommand commandBuscarRubroEmp = new SqlCommand(queryBuscarRubroEmp, buscarRubroEmp.cnn);
                        SqlDataReader lectorRubroEmp = commandBuscarRubroEmp.ExecuteReader();
                        lectorRubroEmp.Read();
                        comboBoxRubro.Text = lectorRubroEmp.GetString(0);
                        buscarRubroEmp.cnn.Close();
                    }


                    //Cargo los Roles
                    Conexion buscarRoles = new Conexion();
                    buscarRoles.cnn.Open();
                    string queryBuscarRoles = "select nombre from LPB.Roles where id in (select Rol_id from LPB.RolesPorUsuario where Usuario_id='" + idUser + "')";
                    SqlCommand commandBuscarRoles = new SqlCommand(queryBuscarRoles, buscarRoles.cnn);
                    SqlDataReader lectorBuscarRoles = commandBuscarRoles.ExecuteReader();
                    while (lectorBuscarRoles.Read())
                    {
                        int posicionaChequear = CheckedListBoxEmp.FindStringExact(lectorBuscarRoles.GetString(0), 0);
                        CheckedListBoxEmp.SetItemChecked(posicionaChequear, true);
                    }
                    buscarRoles.cnn.Close();
                    
                }
            }

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
                    || comboBoxLocalidades.Text.Equals("") || textBoxFechaNac.Text.Equals("")
                    || ((textBoxViejaPass.Visible)&&(textBoxViejaPass.Text.Equals("")))
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
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl número telefónico debe ser solo numérico y debe comenzar con 11 o 15\n");
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
                    if (!(Regex.Match(textBoxPisoCl.Text, "^(\\d\\d?|PB)$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl piso debe ser numérico y hasta dos dígitos (o PB)\n");
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

                //FECHA DE NACIMIENTO

                if (!(textBoxFechaNac.Text.Equals("")))
                {
                    int age = DateTime.Today.Year - monthCalendar1.SelectionStart.Date.Year; 
                    if (age < 18)
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tNo puede darse de alta a clientes menores de 18 años\n");
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
                    string queryDNI = "";
                    if (modalidad.Equals("Alta"))
                    {
                        queryDNI = "Select * from LPB.Clientes where documento_tipo='DNI' and documento_numero = '" + textBoxNumeroDoc.Text + "'";
                    }
                    else
                    {
                        queryDNI = "Select cl.Usuario_id from LPB.Clientes cl where cl.documento_tipo='DNI' and cl.documento_numero = '" + textBoxNumeroDoc.Text + "' and exists(select * from LPB.Usuarios where id=cl.Usuario_id and username<>'"+userAModificar+"')";
                    }
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
                    string queryDNI = "";
                    if (modalidad.Equals("Alta"))
                    {
                        queryDNI = "Select * from LPB.Clientes where documento_tipo='CUIL' and documento_numero = '" + textBoxNumeroDoc.Text + "'";
                    }
                    else
                    {
                        queryDNI = "Select cl.Usuario_id from LPB.Clientes cl where cl.documento_tipo='CUIL' and cl.documento_numero = '" + textBoxNumeroDoc.Text + "' and exists(select * from LPB.Usuarios where id=cl.Usuario_id and username<>'" + userAModificar + "')";
                    }
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
                if (modalidad.Equals("Alta"))
                {
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
                }

                //VALIDACION VIEJA CONTRASEÑA ( SI SE TRATA DE UNA MODIFICACION EN DONDE CAMBIA LA CONTRASEÑA )
                if ((!(textBoxViejaPass.Text.Equals("")))&&(textBoxViejaPass.Visible))
                {
                    if (!(passwordVieja.Equals(Helper.Help.Sha256(textBoxViejaPass.Text))))
                    {
                        hayError = true;
                        mensajeDeError = string.Concat(mensajeDeError, "\tLa password vieja no es correcta\n");
                    }
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
                //SI EL PISO ES NULL CARGO 999 EN LA BASE (LUEGO EL SP CARGARÁ NULL), SI ES PB CARGO 0
                string pisoACargar = textBoxPisoCl.Text;

                if (textBoxPisoCl.Text.Equals("PB"))
                {
                    pisoACargar = "0";
                }
                if (textBoxPisoCl.Text.Equals(""))
                {
                    pisoACargar = "999";
                }

                if (modalidad.Equals("Alta"))
                {
                    //ALTA DE CLIENTE

                    bool resultadoCliente = cargaUsuario.executeProcedure(cargaUsuario.getSchema() + @".SP_Alta_Cliente",
                        Helper.Help.generarListaParaProcedure("@username", "@pass", "@tipoDoc", "@numeroDoc", "@apellido", "@nombre", "@fechaNac", "@mail", "@telefono", "@calle",
                        "@nroCalle", "@piso", "@dpto", "@codPostal", "@descrpLocalidad")
                        , this.textBoxUser.Text, Helper.Help.Sha256(this.textBoxPass.Text), this.comboBoxTipoDoc.Text, this.textBoxNumeroDoc.Text, this.textBoxApellido.Text, this.textBoxNombre.Text, this.monthCalendar1.SelectionStart.Date,
                        this.textBoxMail.Text, this.textBoxTelefono.Text, this.textBoxCalleCl.Text, this.textBoxNroCl.Text, pisoACargar,
                        this.textBoxDptoCl.Text, this.textBoxCodPostCl.Text, this.comboBoxLocalidades.Text);
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

                }

                //MODIFICACION CLIENTE
                else
                {
                    string passwordFinal="";
                    if(textBoxViejaPass.Visible){
                        passwordFinal=Helper.Help.Sha256(textBoxPass.Text);
                    }
                    else{
                        passwordFinal=passwordVieja;
                    }
                    bool modificarCliente = cargaUsuario.executeProcedure(cargaUsuario.getSchema()+@".SP_Modificacion_Cliente",
                        Helper.Help.generarListaParaProcedure("@username","@pass","@habilitado","@tipoDoc","@numeroDoc",
                        "@apellido","@nombre","@fechaNac","@mail","@telefono","@calle","@nroCalle","@piso","@dpto","@codPostal","@descrpLocalidad"),
                        userAModificar,passwordFinal,checkBoxHabilitado.Checked,comboBoxTipoDoc.Text,textBoxNumeroDoc.Text,textBoxApellido.Text,
                        textBoxNombre.Text,monthCalendar1.SelectionStart.Date,textBoxMail.Text,textBoxTelefono.Text,textBoxCalleCl.Text,
                        textBoxNroCl.Text,pisoACargar,textBoxDptoCl.Text,textBoxCodPostCl.Text,comboBoxLocalidades.Text);

                    //Elimino Roles
                    bool eliminarRoles = cargaUsuario.executeProcedure(cargaUsuario.getSchema() + @".SP_Eliminacion_RolesxUsuario",
                        Helper.Help.generarListaParaProcedure("@username"), userAModificar);
                    if (!eliminarRoles)
                    {
                        MessageBox.Show("Problema al reasignar roles, consultar ayuda", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Asignacion Roles
                    foreach (object itemChecked in CheckedListBoxCli.CheckedItems)
                    {
                        bool resultadoRoles = cargaUsuario.executeProcedure(cargaUsuario.getSchema() + @".SP_Asignacion_Rol_Usuario",
                            Helper.Help.generarListaParaProcedure("@username", "@nombreRol"), userAModificar, itemChecked.ToString());
                        if (!resultadoRoles)
                            MessageBox.Show("Problema en la asignacion de roles al usuario, modificar luego", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //VERIFICACION ÉXITO POSITIVO
                    if (modificarCliente)
                        MessageBox.Show("Usuario modificado con éxito", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El Usuario no pudo ser modificado", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cargaUsuario.cnn.Close();
                this.Close();
                return;
            }

            //GUARDAR UNA EMPRESA

            if (comboBoxRol.Text.Equals("Empresa"))
            {
                // VALIDACION DE CAMPOS OBLIGATORIOS
                String mensajeDeError = "Se produjeron los siguientes errores:\n";
                bool hayError = false;
                if (textBoxUser.Text.Equals("") || textBoxPass.Text.Equals("") || textBoxConfirmarPass.Text.Equals("")
                    || textBoxRazonSocial.Text.Equals("") || textBoxCUITTipo.Text.Equals("") || textBoxMailEmp.Text.Equals("")
                    || textBoxTelefonoEmp.Text.Equals("") || textBoxNombreContacto.Text.Equals("") || comboBoxRubro.Text.Equals("")
                    || textBoxCalleEmp.Text.Equals("") || textboxNroEmpr.Text.Equals("") || textboxcodpostEmpr.Text.Equals("") 
                    || comboBoxLocalidadEmpr.Text.Equals("") || textBoxCUITNro.Text.Equals("") || textBoxCUITVerif.Text.Equals("")
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

                //CUIT
                if (!(textBoxCUITTipo.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxCUITTipo.Text, "^\\d+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl CUIT debe estar compuesto por números\n");
                    }
                    if (textBoxCUITTipo.Text.Length.CompareTo(2) != 0)
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl CUIT debe estar compuesto por 11 dígitos: 2 - 8 - 1\n");
                    }
                }
                if (!(textBoxCUITNro.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxCUITNro.Text, "^\\d+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl CUIT debe estar compuesto por números\n");
                    }
                    if (textBoxCUITNro.Text.Length.CompareTo(8) != 0)
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl CUIT debe estar compuesto por 11 dígitos: 2 - 8 - 1\n");
                    }
                }
                if (!(textBoxCUITVerif.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxCUITVerif.Text, "^\\d+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl CUIT debe estar compuesto por números\n");
                    }
                    if (textBoxCUITVerif.Text.Length.CompareTo(1) != 0)
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl CUIT debe estar compuesto por 11 dígitos: 2 - 8 - 1\n");
                    }
                }

                //MAIL

                if (!(textBoxMailEmp.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxMailEmp.Text, "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,3})$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl mail ingresado no es válido\n");
                    }
                }

                //TELEFONO
                if (!(textBoxTelefonoEmp.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxTelefonoEmp.Text, "^(11|15)\\d+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl número telefónico debe ser solo numérico y debe comenzar con 11 o 15\n");
                    }
                    if (textBoxTelefonoEmp.Text.Length.CompareTo(10) != 0)
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl número de teléfono debe ser de 10 dígitos\n");
                    }
                }

                //NOMBRE CONTACTO
                if (!(textBoxNombreContacto.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxNombreContacto.Text, "^\\D+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tSolo puede haber letras en el nombre de contacto\n");
                    }
                }

                //NUMERO DE CALLE

                if (!(textboxNroEmpr.Text.Equals("")))
                {
                    if (!(Regex.Match(textboxNroEmpr.Text, "^\\d+$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tIngrese el número de la dirección solo con números\n");
                    }
                    if (textboxNroEmpr.Text.Length.CompareTo(5) == 1)
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl número de la dirección debe ser como máximo de 5 dígitos\n");
                    }
                }

                //PISO 

                if (!(textboxPisoEmpr.Text.Equals("")))
                {
                    if (!(Regex.Match(textboxPisoEmpr.Text, "^(\\d\\d?|PB)$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl piso debe ser numérico y hasta dos dígitos (o PB)\n");
                    }
                }

                //DPTO

                if (!(textboxDptoEmpr.Text.Equals("")))
                {
                    if (!(Regex.Match(textboxDptoEmpr.Text, "^([A-Z]|[0-9]{1,2})$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl dpto debe ser una letra de A a Z, o bien numérico, hasta dos dígitos\n");
                    }
                }

                //CODIGO POSTAL

                if (!(textboxcodpostEmpr.Text.Equals("")))
                {
                    if (!(Regex.Match(textboxcodpostEmpr.Text, "^([0-9]{4}|[0-9A-Z]{8})$").Success))
                    {
                        hayError = true;
                        mensajeDeError = String.Concat(mensajeDeError, "\tEl código postal debe ser numérico de 4 caractéres o alfanumérico de 8 caractéres\n");
                    }
                }

                //ROLES
                if (CheckedListBoxEmp.CheckedItems.Count == 0)
                {
                    hayError = true;
                    mensajeDeError = String.Concat(mensajeDeError, "\tNo selecciono ningún rol\n");
                }

                //VALIDACION CUIT ÚNICO

                if (!(textBoxCUITTipo.Text.Equals("") || textBoxCUITNro.Text.Equals("") || textBoxCUITVerif.Text.Equals("")))
                {
                    string queryCUIT = "";
                    if (modalidad.Equals("Alta"))
                    {
                        queryCUIT = "Select * from LPB.Empresas where cuit = '" + textBoxCUITTipo.Text + "-"+textBoxCUITNro.Text+"-"+textBoxCUITVerif.Text+"'";
                    }
                    else
                    {
                        queryCUIT = "Select emp.Usuario_id from LPB.Empresas emp where emp.cuit = '" + textBoxCUITTipo.Text + "-"+textBoxCUITNro.Text+"-"+textBoxCUITVerif.Text+ "' and exists(select * from LPB.Usuarios where id=emp.Usuario_id and username<>'" + userAModificar + "')";
                    }
                    Conexion conCUIT = new Conexion();
                    conCUIT.cnn.Open();
                    SqlCommand commandCUIT = new SqlCommand(queryCUIT, conCUIT.cnn);
                    SqlDataReader lectorCUIT = commandCUIT.ExecuteReader();
                    if (lectorCUIT.Read())
                    {
                        hayError = true;
                        mensajeDeError = string.Concat(mensajeDeError, "\tYa existe un usuario con ese número de CUIT\n");
                    }
                    conCUIT.cnn.Close();
                }

                //VALIDACION USERNAME ÚNICO
                if (modalidad.Equals("Alta"))
                {
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
                }


                //VALIDACION VIEJA CONTRASEÑA ( SI SE TRATA DE UNA MODIFICACION EN DONDE CAMBIA LA CONTRASEÑA )
                if ((!(textBoxViejaPass.Text.Equals(""))) && (textBoxViejaPass.Visible))
                {
                    if (!(passwordVieja.Equals(Helper.Help.Sha256(textBoxViejaPass.Text))))
                    {
                        hayError = true;
                        mensajeDeError = string.Concat(mensajeDeError, "\tLa password vieja no es correcta\n");
                    }
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

                //CARGA EMPRESA
                //SI EL PISO ES NULL CARGO 999 EN LA BASE (LUEGO EL SP CARGARÁ NULL), SI ES PB CARGO 0
                string pisoaCargar = textboxPisoEmpr.Text;
                if (textboxPisoEmpr.Text.Equals("PB"))
                {
                    pisoaCargar = "0";
                }
                if (textboxPisoEmpr.Text.Equals(""))
                {
                    pisoaCargar = "999";
                }

                if (modalidad.Equals("Alta"))
                {
                    //ALTA DE EMPRESA
                    bool resultadoEmpresa = cargaUsuario.executeProcedure(cargaUsuario.getSchema() + @".SP_Alta_Empresa",
                        Helper.Help.generarListaParaProcedure("@username", "@pass", "@razonSoc", "@cuit", "@mail", "@telefono", "@calle", "@nroCalle", "@piso", "@dpto",
                        "@codPostal", "@rubroDesc", "@nombreContacto", "@descLocalidad")
                        , this.textBoxUser.Text, Helper.Help.Sha256(this.textBoxPass.Text), this.textBoxRazonSocial.Text, this.textBoxCUITTipo.Text + "-" + this.textBoxCUITNro.Text + "-" + this.textBoxCUITVerif.Text,
                        this.textBoxMailEmp.Text, this.textBoxTelefonoEmp.Text, this.textBoxCalleEmp.Text, this.textboxNroEmpr.Text,
                        pisoaCargar, this.textboxDptoEmpr.Text, this.textboxcodpostEmpr.Text, this.comboBoxRubro.Text, this.textBoxNombreContacto.Text,
                        this.comboBoxLocalidadEmpr.Text);
                    // Hay que ver que pasa cuando dpto va null//

                    //Asignacion Roles
                    foreach (object itemChecked in CheckedListBoxEmp.CheckedItems)
                    {
                        bool resultadoRoles = cargaUsuario.executeProcedure(cargaUsuario.getSchema() + @".SP_Asignacion_Rol_Usuario",
                            Helper.Help.generarListaParaProcedure("@username", "@nombreRol"), this.textBoxUser.Text, itemChecked.ToString());
                        if (!resultadoRoles)
                            MessageBox.Show("Problema en la asignacion de roles al usuario, modificar luego", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //VERIFICACION ÉXITO POSITIVO
                    if (resultadoEmpresa)
                        MessageBox.Show("Alta de usuario realizada con éxito", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El Usuario no pudo ser dado de alta", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //MODIFICACION EMPRESA
                else
                {
                    MessageBox.Show("Se hubiera hecho la modificacion", "Mensaje...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cargaUsuario.cnn.Close();
                this.Close();
                return;
            }


            MessageBox.Show("Seleccione tipo de usuario: Cliente o Empresa", "Error al guardar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            if (modalidad.Equals("Alta"))
            {
                textBoxUser.Text = "";
                textBoxConfirmarPass.Text = "";
                textBoxPass.Text = "";
            }

            if (textBoxViejaPass.Visible)
            {
                textBoxConfirmarPass.Text = "";
                textBoxPass.Text = "";
                textBoxViejaPass.Text = "";
            }

            textBoxApellido.Text = "";
            textBoxCalleCl.Text = "";
            textBoxCodPostCl.Text = "";
            textboxcodpostEmpr.Text = "";            
            textBoxCUITTipo.Text = "";
            textBoxCUITNro.Text = "";
            textBoxCUITVerif.Text = "";
            textBoxDptoCl.Text = "";
            textboxDptoEmpr.Text = "";
            textBoxFechaNac.Text = "";
            textBoxCalleEmp.Text = "";
            textBoxMail.Text = "";
            textBoxMailEmp.Text = "";
            textBoxNombre.Text = "";
            textBoxNombreContacto.Text = "";
            textBoxNroCl.Text = "";
            textboxNroEmpr.Text = "";
            textBoxNumeroDoc.Text = "";
            textBoxPisoCl.Text = "";
            textboxPisoEmpr.Text = "";
            textBoxRazonSocial.Text = "";
            textBoxTelefono.Text = "";
            textBoxTelefonoEmp.Text = "";
            
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

        private void buttonCambiarPass_Click(object sender, EventArgs e)
        {
            labelViejaPass.Visible = true;
            textBoxViejaPass.Visible = true;
            textBoxPass.Enabled = true;
            textBoxConfirmarPass.Enabled = true;
            textBoxPass.Text = "";
            textBoxConfirmarPass.Text = "";
        }

 
 
    }
}
