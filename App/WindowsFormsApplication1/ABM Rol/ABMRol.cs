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

namespace visibilidad.Abm_Rol
{
    public partial class ABMRol : Form
    {
        public string evento;

        public ABMRol(string ev)
        {
            InitializeComponent();
            evento = ev;
            string funcionalidad;
            if (evento != "A")
            {

                text_rol.Text = evento;
                checkBox_habilitado.Visible = true;
            }
            else
            {
                checkBox_habilitado.Visible = false;
                text_rol.Enabled = true;
                checkedList_funciones.Enabled = false;
            }


            Conexion con = new Conexion();
            Conexion con2 = new Conexion();


            /*CARGO LAS FUNCIONALIDADES EN UN CHECKLIST*/
            string query = "SELECT descripcion FROM lpb.funcionalidades";

            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();
            int i = 0;
            while (lector.Read())
            {
                funcionalidad = lector.GetString(0);
                checkedList_funciones.Items.Add(funcionalidad);

                if (evento != "A")
                {
                    int id_rol_abm = getIdRol(evento);
                    //VERIFICA SI EL ROL CONTIENE LA FUNCIONALIDAD
                    query = "SELECT 1 FROM lpb.funcionalidadesporrol F, lpb.funcionalidades D " +
                                 "WHERE D.id = F.funcionalidad_id " +
                                 "AND D.descripcion = '" + funcionalidad + "' " +
                                 "AND F.rol_id = '" + id_rol_abm + "'";

                    con2.cnn.Open();
                    SqlCommand command2 = new SqlCommand(query, con2.cnn);
                    SqlDataReader lector2 = command2.ExecuteReader();
                    if (lector2.Read())
                    {
                        checkedList_funciones.SetItemChecked(i, true);
                    }
                    con2.cnn.Close();
                }
                i++;
            }
            con.cnn.Close();
            if (evento != "A")
            {
                con.cnn.Open();
                try
                {
                    string queryM = "SELECT habilitado FROM lpb.roles WHERE nombre = '" + evento + "' ";
                    SqlCommand commando = new SqlCommand(queryM, con.cnn);
                    SqlDataReader lectorcito = commando.ExecuteReader();
                    lectorcito.Read();
                    checkBox_habilitado.Checked = lectorcito.GetBoolean(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de lectura del campo Habilitado" + ex);
                }
                con.cnn.Close();
                btn_seleccionar_todo.Enabled = true;
                btn_limpiar.Enabled = true;
                if (checkBox_habilitado.Checked == true)
                {
                    checkBox_habilitado.Visible = false;
                }
            }
            else
            {
                btn_seleccionar_todo.Enabled = false;
                btn_limpiar.Enabled = false;
            }
            btn_grabar.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Int32 getIdRol(string rol)
        {
            Conexion con = new Conexion();

            //CONSIGO ID_ROL
            string query3 = "SELECT id FROM lpb.roles WHERE nombre = '" + rol + "'";
            con.cnn.Open();
            SqlCommand command3 = new SqlCommand(query3, con.cnn);
            Int32 id_rol = Convert.ToInt32(command3.ExecuteScalar());
            con.cnn.Close();
            return id_rol;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (text_rol.Text != "")
            {
                btn_grabar.Enabled = true;
                btn_seleccionar_todo.Enabled = true;
                btn_limpiar.Enabled = true;
                checkedList_funciones.Enabled = true;
            }
            else
            {
                btn_grabar.Enabled = false;
                btn_seleccionar_todo.Enabled = false;
                btn_limpiar.Enabled = false;
                checkedList_funciones.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            if (evento != "A")
            {
                string query = "UPDATE lpb.roles SET habilitado = '" + checkBox_habilitado.Checked + "' WHERE nombre = '" + evento + "'";
                con.cnn.Open();
                SqlCommand command = new SqlCommand(query, con.cnn);
                command.ExecuteNonQuery();
                con.cnn.Close();
                Int32 id_rol_nuevo = getIdRol(evento);

                string query5 = "DELETE lpb.funcionalidadesPorRol WHERE rol_id = " + id_rol_nuevo + "";
                con.cnn.Open();
                SqlCommand command5 = new SqlCommand(query5, con.cnn);
                command5.ExecuteNonQuery();
                con.cnn.Close();

                foreach (object itemsCheck in checkedList_funciones.CheckedItems)
                {
                    string query2 = "INSERT INTO lpb.funcionalidadesPorRol (rol_id, funcionalidad_id) VALUES ('" + id_rol_nuevo + "',(SELECT F.id FROM lpb.funcionalidades F WHERE F.descripcion = '" + itemsCheck.ToString() + "'))";
                    con.cnn.Open();
                    SqlCommand command2 = new SqlCommand(query2, con.cnn);
                    command2.ExecuteNonQuery();
                    con.cnn.Close();
                }

                string query3 = "UPDATE lpb.roles SET nombre = '" + text_rol.Text + "' WHERE id = " + id_rol_nuevo + "";
                con.cnn.Open();
                SqlCommand command3 = new SqlCommand(query3, con.cnn);
                command3.ExecuteNonQuery();
                con.cnn.Close();


                MessageBox.Show("Rol Modificado Correctamente", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                string query1 = "SELECT 1 FROM lpb.roles WHERE nombre = '" + text_rol.Text + "'";

                con.cnn.Open();
                SqlCommand command1 = new SqlCommand(query1, con.cnn);
                SqlDataReader lector1 = command1.ExecuteReader();

                if (lector1.Read())
                {
                    MessageBox.Show("El nombre seleccionado para el rol ya existe, por favor escriba uno diferente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.cnn.Close();
                    return;
                }
                con.cnn.Close();

                string query2 = "INSERT INTO lpb.roles (nombre,habilitado) VALUES ('" + text_rol.Text + "',1)";
                con.cnn.Open();
                SqlCommand command = new SqlCommand(query2, con.cnn);
                command.ExecuteNonQuery();
                con.cnn.Close();

                Int32 id_rol_nuevo = getIdRol(text_rol.Text);
                foreach (object itemsCheck in checkedList_funciones.CheckedItems)
                {
                    string query = "INSERT INTO lpb.funcionalidadesPorRol (rol_id, funcionalidad_id) VALUES ('" + id_rol_nuevo + "',(SELECT F.id FROM lpb.funcionalidades F WHERE F.descripcion = '" + itemsCheck.ToString() + "'))";
                    con.cnn.Open();
                    SqlCommand command2 = new SqlCommand(query, con.cnn);
                    command2.ExecuteNonQuery();
                    con.cnn.Close();
                }
                MessageBox.Show("Rol Creado Correctamente", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }

        }

        private void ABMRol_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.TopMost = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btn_grabar.Enabled = true;
            btn_seleccionar_todo.Enabled = true;
            btn_limpiar.Enabled = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_grabar.Enabled = true;
            btn_seleccionar_todo.Enabled = true;
            btn_limpiar.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_grabar.Enabled = true;
            for (int i = 0; i < checkedList_funciones.Items.Count; i++)
                checkedList_funciones.SetItemChecked(i, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_grabar.Enabled = true;
            foreach (int i in checkedList_funciones.CheckedIndices)
            {
                checkedList_funciones.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
