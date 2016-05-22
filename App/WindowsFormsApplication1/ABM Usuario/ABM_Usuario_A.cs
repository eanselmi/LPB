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

namespace MercadoEnvio.ABM_Usuario
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
            comboBoxLocalidades.Items.Add("Otra");
            comboBoxLocalidadEmpr.Items.Add("Otra");
            con.cnn.Close();

            /*CARGA LOS RUBROS EN EL COMBOBOX*/
            Conexion conRub = new Conexion();
            string queryRubro = "SELECT descripcion FROM lpb.Rubros";
            conRub.cnn.Open();
            SqlCommand commandRubro = new SqlCommand(queryRubro, conRub.cnn);
            SqlDataReader lectorRubro = commandRubro.ExecuteReader();
            while (lectorRubro.Read())
            {
                comboBoxRubro.Items.Add(lectorRubro.GetString(0));
            }
            conRub.cnn.Close();

        }

        private void ABM_Usuario_A_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
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

                if (textBoxUser.Text.Equals("") || textBoxPass.Text.Equals("") || textBoxConfirmarPass.Text.Equals("")
                    || textBoxNombre.Text.Equals("") || textBoxApellido.Text.Equals("") || textBoxMail.Text.Equals("")
                    || textBoxTelefono.Text.Equals("") || textBoxCalleCl.Text.Equals("") || textBoxCodPostCl.Text.Equals("")
                    || textBoxNumeroDoc.Text.Equals("") || comboBoxTipoDoc.Text.Equals("") || textBoxNroCl.Text.Equals("")
                    || comboBoxLocalidades.Text.Equals("") || textBoxPisoCl.Text.Equals("") || textBoxFechaNac.Text.Equals("")
                    )
                {
                    MessageBox.Show("Campos obligatorios vacios", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //VALIDACION DE CONFIRMAR PASSWORD
                if (!(textBoxPass.Text.Equals(textBoxConfirmarPass.Text)))
                {
                      MessageBox.Show("Los campos Password y Confirmar Password no coinciden", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //VALIDACION TIPO DE DATOS
                //USERNAME
                if (textBoxUser.Text.Length.CompareTo(45) == 1)
                {
                    MessageBox.Show("Username demasiado largo", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //NOMBRE
                if (!(textBoxNombre.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxNombre.Text, "^\\D+$").Success))
                    {
                        MessageBox.Show("Solo puede haber letras en el nombre", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //APELLIDO
                if (!(textBoxApellido.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxApellido.Text, "^\\D+$").Success))
                    {
                        MessageBox.Show("Solo puede haber letras en el apellido", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //NUMERO DOC
                if ((!(textBoxNumeroDoc.Text.Equals(""))) && comboBoxTipoDoc.Text.Equals("DNI")) 
                {
                    if (!(Regex.Match(textBoxNumeroDoc.Text, "^\\d+$").Success))
                    {
                        MessageBox.Show("Ingrese el DNI numérico y sin .", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (textBoxNumeroDoc.Text.Length.CompareTo(8) == 1)
                    {
                        MessageBox.Show("El DNI no puede ser tan largo", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if ((!(textBoxNumeroDoc.Text.Equals(""))) && comboBoxTipoDoc.Text.Equals("Pasaporte"))
                {
                    if (!(Regex.Match(textBoxNumeroDoc.Text, "^[0-9A-Z]+$").Success))
                    {
                        MessageBox.Show("El número de pasaporte debe comprender letras y números", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (textBoxNumeroDoc.Text.Length.CompareTo(10) == 1)
                    {
                        MessageBox.Show("El número de pasaporte no puede ser tan largo", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //MAIL

                if(!(textBoxMail.Text.Equals("")))
                {
                    if(!(Regex.Match(textBoxMail.Text, "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,3})$").Success))
                    {
                        MessageBox.Show("El mail ingresado no es válido", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //TELEFONO
                if (!(textBoxTelefono.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxTelefono.Text, "^(011|15)\\d+$").Success))
                    {
                        MessageBox.Show("El número telefónico debe ser solo numérico y debe comenzar con 011 o 15", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (textBoxTelefono.Text.Length.CompareTo(11) == 1 || textBoxTelefono.Text.Length.CompareTo(10)==-1)
                    {
                        MessageBox.Show("El número de teléfono debe ser de 11 o 10 dígitos", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //NUMERO DE CALLE

                if (!(textBoxNroCl.Text.Equals("")))
                {
                    if (!(Regex.Match(textBoxNroCl.Text, "^\\d+$").Success))
                    {
                        MessageBox.Show("Ingrese el número de la dirección solo con números", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (textBoxNroCl.Text.Length.CompareTo(5) == 1)
                    {
                        MessageBox.Show("El número de la dirección debe ser como máximo de 5 dígitos", "Error al guardar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

 
    }
}
