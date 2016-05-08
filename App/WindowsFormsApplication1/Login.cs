using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Helper;
using conectar;
using readConfiguracion;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public int intFallidos;
        public bool userHabilitado;
        public string pass = "";
        public string rol = "";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (text_usuario.Text == "")
            {
                MessageBox.Show("El campo usuario no puede estar vacio", "Inicio de sesion erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (text_password.Text == "")
            {
                MessageBox.Show("El campo password no puede estar vacio", "Inicio de sesion erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conexion con = new Conexion();
            string query = "SELECT pass, cantIntentosFallidos, habilitado " +
                           "FROM lpb.Usuarios WHERE userName = '" + text_usuario.Text + "'";

            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();

            if (!lector.Read())
            {
                con.cnn.Close();
                MessageBox.Show("Usuario Inválido", "Inicio de sesion erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_usuario.Text = "";
                text_password.Text = "";
                text_usuario.Focus();
                return;
            }

            pass = lector.GetString(0);
            intFallidos = lector.GetInt32(1);
            userHabilitado = lector.GetBoolean(2);
            con.cnn.Close();

            ///////////////////////////////////////////////////////////////////////////
            if (userHabilitado == false)
            {
                MessageBox.Show("Su cuenta de usuario esta inhabilitada", "Inicio de sesion erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(pass == text_password.Text.Sha256()))
            {
                intFallidos++;
                if (intFallidos == 3)
                {
                    string query2;
                    query2 = "UPDATE lpb.Usuarios SET habilitado = 0 WHERE username = '" + text_usuario.Text + "'";
                    MessageBox.Show("Su cuenta a sido inhabilitada por demasiados intentos de inicio de sesion", "Inicio de sesion erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.cnn.Open();
                    SqlCommand command1 = new SqlCommand(query2, con.cnn);
                    command1.ExecuteNonQuery();
                    string query3;
                    query3 = "UPDATE lpb.usuarios SET cantIntentosFallidos = " + intFallidos + " WHERE username = '" + text_usuario.Text + "'";
                    SqlCommand command2 = new SqlCommand(query3, con.cnn);
                    command2.ExecuteNonQuery();
                    con.cnn.Close();

                }
                else
                {
                    string query2;
                    query2 = "UPDATE lpb.usuarios SET cantIntentosFallidos = " + intFallidos + " WHERE userName = '" + text_usuario.Text + "'";
                    con.cnn.Open();
                    SqlCommand command1 = new SqlCommand(query2, con.cnn);
                    command1.ExecuteNonQuery();
                    con.cnn.Close();
                    MessageBox.Show("Contraseña Inválida", "Inicio de sesion erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                text_password.Text = "";
                text_password.Focus();

                return;
            }
            else
            {
                /*LIMPIA LOS INTENTOS FALLIDOS*/

                string query3 = "UPDATE lpb.usuarios SET cantIntentosFallidos = 0 " +
                                "WHERE username = '" + text_usuario.Text + "'";
                con.cnn.Open();
                SqlCommand command2 = new SqlCommand(query3, con.cnn);
                command2.ExecuteNonQuery();
                con.cnn.Close();
            }
            
            text_usuario.Focus();
            //this.Hide();
            //Cargar el menu que aun no hice
            //mp.Show();
            //mp.cargarUsuario(text_usuario.Text, this);
            text_usuario.Text = "";
            text_password.Text = "";
            MessageBox.Show("Ingreso Correcto, te debo el menu", "Inicio de sesion exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void text_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_ingresar.PerformClick();
            }
        }
      
    }
}
