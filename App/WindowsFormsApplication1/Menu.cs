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

namespace visibilidad
{
    public partial class Menu : Form
    {

        public int id_usuario;
        public Login log;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {            
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public void cargarRoles(int usuario_id, string rol, Login form)
        {
            log = form;
            id_usuario = usuario_id;
            aBMToolStripMenuItem.Visible = false;
            rolToolStripMenuItem.Visible = false;                    
            usuariosToolStripMenuItem.Visible = false;
            visibilidadToolStripMenuItem.Visible = false;
            
            generarPublicacionToolStripMenuItem.Visible = false;
            comprarToolStripMenuItem.Visible = false;
            ofertarToolStripMenuItem.Visible = false;
            historialToolStripMenuItem.Visible = false;
            calificarToolStripMenuItem.Visible = false;
            consultaFacturacionToolStripMenuItem.Visible = false;
            listadoEstadisticoToolStripMenuItem.Visible = false;

            Conexion con = new Conexion();
            string query;
            query = "select f.descripcion from lpb.roles r, lpb.FuncionalidadesPorRol fpr, lpb.Funcionalidades f " +
                     "where r.id=fpr.Rol_id and fpr.Funcionalidad_id=f.id and r.nombre= '" + rol + "'";

            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector1 = command.ExecuteReader();
            aBMToolStripMenuItem.Visible = true;
            int i = 0;
            while (lector1.Read())
            {
                if (lector1.GetString(0) == "abmRol")
                {
                    rolToolStripMenuItem.Visible = true; i++;                    
                }
                else if (lector1.GetString(0) == "abmUsuario")
                {
                    usuariosToolStripMenuItem.Visible = true; i++;
                }
                else if (lector1.GetString(0) == "abmVisibilidad")
                {
                    visibilidadToolStripMenuItem.Visible = true; i++;
                }
                else if (lector1.GetString(0) == "generarPublicacion")
                {
                    generarPublicacionToolStripMenuItem.Visible = true;
                }
                else if (lector1.GetString(0) == "comprar/ofertar")
                {
                    comprarToolStripMenuItem.Visible = true;
                    ofertarToolStripMenuItem.Visible = true;
                }
                else if (lector1.GetString(0) == "historialCliente")
                {
                    historialToolStripMenuItem.Visible = true;
                }
                else if (lector1.GetString(0) == "calificarVendedor")
                {
                    calificarToolStripMenuItem.Visible = true;
                }
                else if (lector1.GetString(0) == "consultaFacturas")
                {
                    consultaFacturacionToolStripMenuItem.Visible = true;
                }
                else if (lector1.GetString(0) == "listadoEstadistico")
                {
                    listadoEstadisticoToolStripMenuItem.Visible = true;
                }
            }
            con.cnn.Close();    
            string query_tipo_usuario;
            query_tipo_usuario = "select TipoUsuario from lpb.usuarios where id=" + usuario_id;

            con.cnn.Open();
            command = new SqlCommand(query_tipo_usuario, con.cnn);
            lector1 = command.ExecuteReader();
            lector1.Read();
            string tipo_usuario = lector1.GetString(0);
            con.cnn.Close();
            if (tipo_usuario == "Empresa")
            {
                comprarToolStripMenuItem.Visible = false;
                ofertarToolStripMenuItem.Visible = false;
                historialToolStripMenuItem.Visible = false;
            }

            if (i==0) aBMToolStripMenuItem.Visible = false;
            


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            log.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            log.Show();
            log.Refresh();
            log.text_usuario.Focus();

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Abm_Rol.ABMRol abmrol = new Abm_Rol.ABMRol("A");
            abmrol.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Rol.BuscarRol buscarRol = new Abm_Rol.BuscarRol("B");
            buscarRol.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abm_Rol.BuscarRol buscarRolMod = new Abm_Rol.BuscarRol("M");
            buscarRolMod.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ABM_Usuario.ABM_Usuario_A abmUsuariosAlta = new ABM_Usuario.ABM_Usuario_A("Alta","NADIE");
            abmUsuariosAlta.Show();
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            ABM_Visibilidad.AltaVisibilidad abmVisibilidadAlta = new ABM_Visibilidad.AltaVisibilidad();
            abmVisibilidadAlta.Show();

        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ABM_Visibilidad.BuscarVisibilidad busquedaVisibilidad = new ABM_Visibilidad.BuscarVisibilidad("M");
            busquedaVisibilidad.Show();
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ABM_Visibilidad.BuscarVisibilidad busquedaVisibilidad = new ABM_Visibilidad.BuscarVisibilidad("B");
            busquedaVisibilidad.Show();
        }

        private void generarPublicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generar_Publicación.GenerarPublicacion generarPublicacion = new Generar_Publicación.GenerarPublicacion(id_usuario);
            generarPublicacion.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();
            ayuda.Show();
        }

        private void listadoEstadisticoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Listado_Estadistico.ListadoEstadistico listadosEstadisticos = new Listado_Estadistico.ListadoEstadistico();
            listadosEstadisticos.Show();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarOfertar.BusquedaPublicacion busquedaPublicacion = new ComprarOfertar.BusquedaPublicacion("Compra Inmediata");
            busquedaPublicacion.Show();
        }


        private void ofertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarOfertar.BusquedaPublicacion busquedaPublicacion = new ComprarOfertar.BusquedaPublicacion("Subasta");
            busquedaPublicacion.Show();
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ABM_Usuario.ABM_Usuario_B abmUsuariosBaja = new ABM_Usuario.ABM_Usuario_B("Baja");
            abmUsuariosBaja.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ABM_Usuario.ABM_Usuario_B abmUsuariosMod = new ABM_Usuario.ABM_Usuario_B("Modificacion");
            abmUsuariosMod.Show();
        }

        private void cambiarPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_pass modificarPass = new Modificar_pass(id_usuario);
            modificarPass.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_Cliente.HistorialCliente historialCli = new Historial_Cliente.HistorialCliente(id_usuario);
            historialCli.Show();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            visibilidadToolStripMenuItem.Visible = false;
        }

    }
}
