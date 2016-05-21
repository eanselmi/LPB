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

namespace MercadoEnvio
{
    public partial class Menu : Form
    {

        public Login log;       
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
        }

        public void cargarRoles(string rol, Login form)
        {
            log = form;            
            aBMToolStripMenuItem.Visible = false;
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
            while (lector1.Read())
            {
                if (lector1.GetString(0) == "abmRol" || lector1.GetString(0) == "abmUsuario" || lector1.GetString(0) == "abmRubro" || lector1.GetString(0) == "abmVisibilidad")
                {
                    aBMToolStripMenuItem.Visible = true;                
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
            ABM_Usuario.ABM_Usuario_A abmUsuariosAlta = new ABM_Usuario.ABM_Usuario_A();
            abmUsuariosAlta.Show();
        }
    }
}
