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


namespace visibilidad
{
    public partial class Modificar_pass : Form
    {
        private int idUsuario;

        public Modificar_pass(int userId)
        {
            InitializeComponent();
            idUsuario = userId;
        }

        private void Modificar_pass_Load(object sender, EventArgs e)
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
            //SI no completo los campos aviso y salgo
            if (textBoxViejaPass.Text.Equals("") | textBoxNuevaPass.Text.Equals("") | textBoxConfirmarPass.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //cargo los datos del usuario
            Conexion cnnUsuario = new Conexion();
            string queryUs = "select pass from lpb.Usuarios where id='"+idUsuario+"'";
            cnnUsuario.cnn.Open();
            SqlCommand commandUs = new SqlCommand(queryUs, cnnUsuario.cnn);
            SqlDataReader lector = commandUs.ExecuteReader();
            lector.Read();
            string viejaPass = lector.GetString(0);
            cnnUsuario.cnn.Close();

            string mensajeDeError = "Se produjeron los siguientes errores:\n";
            bool hayError = false;

            //Verifico que la vieja password sea correcta
            if(!(viejaPass.Equals(Helper.Help.Sha256(textBoxViejaPass.Text)))){
                hayError=true;
                mensajeDeError=string.Concat(mensajeDeError,"\tLa vieja password no coincide\n");
            }

            //Verifico que la nueva password coincida con el campo de confirmar password
            if(!(textBoxNuevaPass.Text.Equals(textBoxConfirmarPass.Text))){
                hayError=true;
                mensajeDeError=string.Concat(mensajeDeError,"\tLos campos nueva password y confirmar password no coinciden\n");
            }

            //Si hay errores los muestro y salgo
            if(hayError){
                MessageBox.Show(mensajeDeError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //Si no hay errores procedo con la modificación de la clave
            Conexion cambiarPass=new Conexion();
            cambiarPass.cnn.Open();

            bool resultadoModPass = cambiarPass.executeProcedure(cambiarPass.getSchema() + @".SP_Modificacion_Password",
                Helper.Help.generarListaParaProcedure("@id", "@password"), idUsuario, Helper.Help.Sha256(textBoxNuevaPass.Text));
 
            if(resultadoModPass){
                MessageBox.Show("Modificación con éxito","Mensaje..",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }else{
                MessageBox.Show("La modificación no se pudo realizar, contacte al administrador","Mensaje..",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            cambiarPass.cnn.Close();
            this.Close();
        }

        private void Modificar_pass_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}
