﻿using System;
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

namespace visibilidad.Generar_Publicación
{
    public partial class FormularioPublicacion : Form
    {
        public Generar_Publicación.GenerarPublicacion generar;
        public int id_usuario;
        public int codigo_publicacion;
        public int publicacion_tipo;
        public int publicacion_estado;
        public int publicacion_acepta_envio;
        public int publicacion_acepta_preguntas;
        public string evento;
        public int codigo_nuevo;
        public bool usuario_nuevo=false;
        public bool estaba_pausada=false;
        public FormularioPublicacion(Generar_Publicación.GenerarPublicacion form, int usuario, int modo, string ev)
        {
            generar = form;
            evento = ev;
            id_usuario = usuario;
            codigo_publicacion = modo;
            
            /*if (evento == "A")
                id_usuario = modo;
            if (evento == "M")
                codigo_publicacion = modo;
            if (evento == "V")
                codigo_publicacion = modo;*/
            InitializeComponent();
        }

        private void FormularioPublicacion_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;

            if (evento == "A")
            {
                radio_compra.Checked = true;
                radio_borrador.Checked = true;
                btn_guardar.Text = "Guardar";
                date_inicio.Value = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);
                date_fin.Value = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);
                date_fin.Value = date_fin.Value.AddDays(30);
                date_fin.Enabled = false;
                date_inicio.Enabled = false;
                cmb_visibilidad.Items.Clear();
                string query_visibilidad = "select v.descripcion from lpb.visibilidades v";
                Conexion con = new Conexion();
                con.cnn.Open();
                SqlCommand command = new SqlCommand(query_visibilidad, con.cnn);
                SqlDataReader lector = command.ExecuteReader();
                while (lector.Read())
                    cmb_visibilidad.Items.Add(lector.GetString(0));
                con.cnn.Close();
                string query_rubros = "select r.descripcion from lpb.rubros r";
                con = new Conexion();
                con.cnn.Open();
                command = new SqlCommand(query_rubros, con.cnn);
                lector = command.ExecuteReader();
                while (lector.Read())
                    checklist_rubros.Items.Add(lector.GetString(0));
                con.cnn.Close();
                cmb_visibilidad.SelectedIndex = 0;
            }
            if (evento == "M")
            {
                btn_guardar.Text = "Modificar";
                btn_limpiar.Enabled = false;
                radio_compra.Enabled = false;
                radio_subasta.Enabled = false;
                radio_finalizada.Enabled = true;
                radio_pausada.Enabled = true;
                llenar_formulario(codigo_publicacion);
                if (radio_borrador.Checked == true)
                {
                    radio_compra.Enabled = true;
                    radio_subasta.Enabled = true;
                }
                if (radio_activa.Checked == true)
                {
                    radio_borrador.Enabled = false;
                    cmb_visibilidad.Enabled = false;

                }
                if (radio_pausada.Checked == true)
                {
                    deshabilitar_todo();
                    radio_pausada.Enabled = true;
                    radio_finalizada.Enabled = true;
                    radio_activa.Enabled = true;
                    btn_guardar.Enabled = true;
                }
                if (radio_finalizada.Checked == true)
                {
                    MessageBox.Show("Esta publicacion esta finalizada y no admite cambios", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    deshabilitar_todo();

                }

            }
            if (evento == "V")
            {
                llenar_formulario(codigo_publicacion);
                deshabilitar_todo();
            }
        }
        private void deshabilitar_todo()
        {
            text_descripcion.Enabled = false;
            text_precio.Enabled = false;
            text_stock.Enabled = false;
            cmb_visibilidad.Enabled = false;
            check_envio.Enabled = false;
            check_pregunta.Enabled = false;
            checklist_rubros.SelectionMode = SelectionMode.None;
            radio_activa.Enabled = false;
            radio_borrador.Enabled = false;
            radio_pausada.Enabled = false;
            radio_finalizada.Enabled = false;
            radio_compra.Enabled = false;
            radio_subasta.Enabled = false;
            btn_guardar.Enabled = false;
            btn_limpiar.Enabled = false;

        }


        private void llenar_formulario(int codigo_pub)
        {
            cmb_visibilidad.Items.Clear();
            string query_visibilidad = "select v.descripcion from lpb.visibilidades v";
            Conexion con = new Conexion();
            con.cnn.Open();
            SqlCommand command = new SqlCommand(query_visibilidad, con.cnn);
            SqlDataReader lector = command.ExecuteReader();
            while (lector.Read())
                cmb_visibilidad.Items.Add(lector.GetString(0));
            con.cnn.Close();



            string query_publicacion_guardada = "SELECT p.descripcion, p.EstadoDePublicacion_id, p.TipoDePublicacion_id, p.stock, p.fechaCreacion, p.fechaVencimiento, p.precio, p.aceptaEnvio, p.aceptaPreguntas, v.descripcion " +
            "FROM LPB.Publicaciones p, lpb.Visibilidades v where p.Visibilidad_codigo=v.codigo and p.codigo=" + codigo_pub;

            con = new Conexion();
            con.cnn.Open();
            command = new SqlCommand(query_publicacion_guardada, con.cnn);
            lector = command.ExecuteReader();

            //Cargar el formulario con los datos de la publicacion guardada
            lector.Read();
            text_descripcion.Text = lector.GetString(0);

            if (lector.GetInt32(1) == 1)
                radio_borrador.Checked = true;
            else if (lector.GetInt32(1) == 2)
                radio_activa.Checked = true;
            else if (lector.GetInt32(1) == 3)
                radio_pausada.Checked = true;
            else if (lector.GetInt32(1) == 4)
                radio_finalizada.Checked = true;

            if (lector.GetInt32(2) == 1)
                radio_compra.Checked = true;
            else if (lector.GetInt32(2) == 2)
                radio_subasta.Checked = true;

            text_stock.Text = lector.GetDecimal(3).ToString();
            date_inicio.Value = lector.GetDateTime(4);
            date_fin.Value = lector.GetDateTime(5);
            text_precio.Text = lector.GetDecimal(6).ToString();
            if (lector.GetBoolean(7) == true)
                check_envio.Checked = true;
            else check_envio.Checked = false;
            if (lector.GetBoolean(8) == true)
                check_pregunta.Checked = true;
            else check_pregunta.Checked = false;

            int i;
            for (i = 0; i < cmb_visibilidad.Items.Count; i++)
            {
                cmb_visibilidad.SelectedIndex = i;
                if (cmb_visibilidad.Text == lector.GetString(9))
                    break;
            }
            con.cnn.Close();



            string query_rubros = "SELECT descripcion,id FROM lpb.rubros";
            con.cnn.Open();
            command = new SqlCommand(query_rubros, con.cnn);
            lector = command.ExecuteReader();
            string rubro;
            int id_rubro;
            i = 0;
            while (lector.Read())
            {
                rubro = lector.GetString(0);
                checklist_rubros.Items.Add(rubro);
                id_rubro = lector.GetInt32(1);
                string query_control = "SELECT 1 FROM lpb.publicacionesporrubro " +
                             "WHERE rubro_id = " + id_rubro + " and publicacion_id=" + codigo_pub;
                Conexion con2 = new Conexion();
                con2.cnn.Open();
                SqlCommand command2 = new SqlCommand(query_control, con2.cnn);
                SqlDataReader lector2 = command2.ExecuteReader();
                if (lector2.Read())
                {
                    checklist_rubros.SetItemChecked(i, true);
                }
                con2.cnn.Close();

                i++;
            }
            con.cnn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            generar.Show();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            text_precio.Text = text_precio.Text.Replace('.', ',');
            Double value;
            if (Double.TryParse(text_precio.Text, out value))
                text_precio.Text = string.Format("{0:0.00}", value);

            else
            {
                if (text_precio.Text != "")
                {
                    text_precio.Text = String.Empty;
                    MessageBox.Show("El formato de moneda ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_precio.Focus();
                }
            }
            text_precio.Text = text_precio.Text.Replace(',', '.');
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void radio_subasta_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_subasta.Checked == true)
            {
                text_stock.Text = "1";
                text_stock.Enabled = false;
                publicacion_tipo = 2;
            }
            else text_stock.Enabled = true;

        }

        private void cmb_visibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_visibilidad.SelectedIndex != -1)
            {
                Conexion con = new Conexion();
                string query = "select v.codigo from lpb.visibilidades v where v.descripcion='" + cmb_visibilidad.Text + "'";
                con.cnn.Open();
                SqlCommand command = new SqlCommand(query, con.cnn);
                SqlDataReader lector = command.ExecuteReader();
                if (!lector.Read())
                {
                    con.cnn.Close();
                    MessageBox.Show("Error al seleccionar la Visibilidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                text_visibilidad_id.Text = lector.GetDecimal(0).ToString();
                con.cnn.Close();
            }

            if (cmb_visibilidad.Text == "Gratis") check_envio.Visible = false;
            else check_envio.Visible = true;



        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            text_descripcion.Text = "";
            text_precio.Text = "";
            text_stock.Text = "";
            text_visibilidad_id.Text = "";
            radio_activa.Checked = false;
            radio_borrador.Checked = true;
            radio_compra.Checked = true;
            radio_pausada.Checked = false;
            radio_subasta.Checked = false;
            radio_finalizada.Checked = false;
            check_envio.Checked = false;
            check_pregunta.Checked = false;
            cmb_visibilidad.SelectedIndex = 0;
            foreach (int i in checklist_rubros.CheckedIndices)
            {
                checklist_rubros.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void radio_compra_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_compra.Checked == true)
            {
                publicacion_tipo = 1;
                text_stock.Text = "";

            }
        }

        private void radio_borrador_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_borrador.Checked == true) publicacion_estado = 1;
        }

        private void radio_activa_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_activa.Checked == true) publicacion_estado = 2;

        }

        private void radio_pausada_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_pausada.Checked == true)
            {
                publicacion_estado = 3;
                estaba_pausada = true;
            }
        }

        private void radio_finalizada_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_finalizada.Checked == true) publicacion_estado = 4;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Control de Errores
            string error = "Se encontraron los siguientes errores\n";
            if (text_descripcion.Text == "")
                error = error + "El campo Descripcion no puede estar vacio\n";
            if (text_precio.Text == "")
                error = error + "El campo Precio no puede estar vacio\n";
            if (text_stock.Text == "")
                error = error + "El campo Stock no puede estar vacio\n";
            int rubros_seleccionados = 0;
            for (int i = 0; i < checklist_rubros.Items.Count; i++)
                if (checklist_rubros.GetItemChecked(i)) rubros_seleccionados++;
            if (rubros_seleccionados == 0)
                error = error + "Debe seleccionar almenos 1 Rubro para la publicacion\n";
            if (error != "Se encontraron los siguientes errores\n")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            text_precio_aux.Text = text_precio.Text;
            text_precio_aux.Text = text_precio_aux.Text.Replace('.', ',');

            if (evento == "A")
            {

                //Guardar publicacion            
                Conexion cn = new Conexion();
                using (SqlCommand cmd = new SqlCommand("lpb.SP_Guardar_Publicacion", cn.cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Seteo los parametros del SP
                    cmd.Parameters.Add("@usuarioid", SqlDbType.Int);
                    cmd.Parameters.Add("@publicacion_estado", SqlDbType.Int);
                    cmd.Parameters.Add("@publicacion_tipo", SqlDbType.Int);
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@stock", SqlDbType.Int);
                    cmd.Parameters.Add("@fecha_creacion", SqlDbType.DateTime);
                    cmd.Parameters.Add("@fecha_vencimiento", SqlDbType.DateTime);
                    cmd.Parameters.Add("@precio", SqlDbType.Decimal);
                    cmd.Parameters.Add("@acepta_envio", SqlDbType.Bit);
                    cmd.Parameters.Add("@acepta_pregunta", SqlDbType.Bit);
                    cmd.Parameters.Add("@visibilidad_codigo", SqlDbType.Int);
                    cmd.Parameters.Add("@nuevo_codigo_publicacion", SqlDbType.Int).Direction = ParameterDirection.Output;

                    // Lleno los parametros
                    cmd.Parameters["@usuarioid"].Value = id_usuario;
                    cmd.Parameters["@publicacion_estado"].Value = publicacion_estado;
                    cmd.Parameters["@publicacion_tipo"].Value = publicacion_tipo;
                    cmd.Parameters["@descripcion"].Value = text_descripcion.Text;
                    cmd.Parameters["@stock"].Value = Convert.ToInt32(text_stock.Text);
                    cmd.Parameters["@fecha_creacion"].Value = date_inicio.Value;
                    cmd.Parameters["@fecha_vencimiento"].Value = date_fin.Value;
                    cmd.Parameters["@precio"].Value = decimal.Parse(text_precio_aux.Text);
                    cmd.Parameters["@acepta_envio"].Value = publicacion_acepta_envio;
                    cmd.Parameters["@acepta_pregunta"].Value = publicacion_acepta_preguntas;
                    cmd.Parameters["@visibilidad_codigo"].Value = Convert.ToInt32(text_visibilidad_id.Text);
                    cn.cnn.Open();
                    cmd.ExecuteNonQuery();

                    // Leer la devolucion del SP
                    codigo_nuevo = Convert.ToInt32(cmd.Parameters["@nuevo_codigo_publicacion"].Value);
                    cn.cnn.Close();

                    foreach (object itemsCheck in checklist_rubros.CheckedItems)
                    {
                        string insert_rubros = "INSERT INTO lpb.PublicacionesPorRubro (publicacion_id, rubro_id) VALUES (" + codigo_nuevo + ",(SELECT r.id FROM lpb.rubros r WHERE r.descripcion = '" + itemsCheck.ToString() + "'))";
                        cn.cnn.Open();
                        SqlCommand insertar_publicacionPorRubro = new SqlCommand(insert_rubros, cn.cnn);
                        insertar_publicacionPorRubro.ExecuteNonQuery();
                        cn.cnn.Close();
                    }
                    MessageBox.Show("Publicacion creada exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                if (radio_activa.Checked == true)
                {
                    Generar_Publicación.Factura factura = new Generar_Publicación.Factura();
                    string query_tipo_usuario;
                    query_tipo_usuario = "select TipoUsuario, nuevo from lpb.usuarios where id=" + id_usuario;
                    Conexion con = new Conexion();
                    con.cnn.Open();
                    SqlCommand command = new SqlCommand(query_tipo_usuario, con.cnn);
                    SqlDataReader lector1 = command.ExecuteReader();
                    lector1.Read();
                    string tipo_usuario = lector1.GetString(0);
                    usuario_nuevo = lector1.GetBoolean(1);
                    con.cnn.Close();
                    factura.dateTimePicker1.Value = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);
                    decimal visibilidad;
                    if (usuario_nuevo)
                    {
                        visibilidad = -1;
                        string query_update_usuario_nuevo;

                        query_update_usuario_nuevo = "update lpb.usuarios set nuevo=0 where id=" + id_usuario;
                        con = new Conexion();
                        con.cnn.Open();
                        command = new SqlCommand(query_update_usuario_nuevo, con.cnn);
                        command.ExecuteNonQuery();
                    }
                    else
                        visibilidad = Convert.ToDecimal(text_visibilidad_id.Text);
                    cn = new Conexion();
                    using (SqlCommand comando = new SqlCommand("lpb.SP_Generar_Facturacion_Publicacion", cn.cnn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        // Seteo los parametros del SP                           

                        comando.Parameters.Add("@fecha_factura", SqlDbType.DateTime);
                        comando.Parameters.Add("@visibilidad_codigo", SqlDbType.Decimal);
                        comando.Parameters.Add("@usuario_id", SqlDbType.Int);
                        comando.Parameters.Add("@publicacion_cod", SqlDbType.Decimal);
                        comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 100);
                        comando.Parameters.Add("@nuevo_codigo_factura", SqlDbType.Decimal).Direction = ParameterDirection.Output;


                        // Lleno los parametros

                        comando.Parameters["@fecha_factura"].Value = factura.dateTimePicker1.Value;
                        comando.Parameters["@visibilidad_codigo"].Value = visibilidad; //Convert.ToDecimal(text_visibilidad_id.Text);
                        comando.Parameters["@usuario_id"].Value = id_usuario;
                        if (evento == "A") //Si es un alta no tengo el codigo de la publicacion por parametro
                            comando.Parameters["@publicacion_cod"].Value = codigo_nuevo;
                        else
                            comando.Parameters["@publicacion_cod"].Value = codigo_publicacion;
                        comando.Parameters["@descripcion"].Value = "Cargos por publicacion " + cmb_visibilidad.Text;

                        cn.cnn.Open();
                        comando.ExecuteNonQuery();

                        // Leer la devolucion del SP
                        Decimal codigo_factura = Convert.ToDecimal(comando.Parameters["@nuevo_codigo_factura"].Value);
                        factura.lbl_numero.Text = codigo_factura.ToString();
                        cn.cnn.Close();

                    }

                    if (tipo_usuario == "Empresa")
                    {
                        factura.lbl_cliente.Text = id_usuario.ToString();
                        factura.lbl_nombre_titulo.Visible = false;
                        factura.lbl_nombre.Visible = false;
                        factura.lbl_apellido_titulo.Visible = false;
                        factura.lbl_apellido.Visible = false;
                        factura.lbl_documento_titulo.Visible = false;
                        factura.lbl_documento.Visible = false;
                        factura.textBox1.Text = "Cargos por publicacion " + cmb_visibilidad.Text;
                        factura.textBox2.Text = "1";

                        if (usuario_nuevo)
                        {
                            factura.textBox3.Text = "0";
                            factura.textBox4.Text = "0";
                        }
                        else
                        {
                            string query_costo_publicacion;
                            query_costo_publicacion = "select precio from lpb.visibilidades where codigo=" + text_visibilidad_id.Text;
                            con = new Conexion();
                            con.cnn.Open();
                            command = new SqlCommand(query_costo_publicacion, con.cnn);
                            lector1 = command.ExecuteReader();
                            lector1.Read();
                            factura.textBox3.Text = lector1.GetDecimal(0).ToString();
                            factura.textBox4.Text = lector1.GetDecimal(0).ToString();
                            con.cnn.Close();
                        }
                        //Traigo los datos de la empresa
                        string query_datos_empresa;
                        query_datos_empresa = "select e.id, e.razonSocial, e.cuit " +
                                              "from lpb.Usuarios u, lpb.Empresas e where e.Usuario_id=u.id and u.id=" + id_usuario;
                        con = new Conexion();
                        con.cnn.Open();
                        command = new SqlCommand(query_datos_empresa, con.cnn);
                        lector1 = command.ExecuteReader();
                        lector1.Read();

                        factura.lbl_cliente.Text = lector1.GetInt32(0).ToString();
                        factura.lbl_razon_social.Text = lector1.GetString(1);
                        factura.lbl_cuit.Text = lector1.GetString(2);

                        con.cnn.Close();


                    }
                    else
                    {
                        factura.lbl_cliente.Text = id_usuario.ToString();

                        factura.lbl_razon_social_titulo.Visible = false;
                        factura.lbl_razon_social.Visible = false;


                        factura.lbl_cuit_titulo.Visible = false;
                        factura.lbl_cuit.Visible = false;

                        
                        factura.textBox1.Text = "Cargos por publicacion " + cmb_visibilidad.Text;
                        factura.textBox2.Text = "1";

                        if (usuario_nuevo)
                        {
                            factura.textBox3.Text = "0";
                            factura.textBox4.Text = "0";
                        }
                        else
                        {
                            string query_costo_publicacion;
                            query_costo_publicacion = "select precio from lpb.visibilidades where codigo=" + text_visibilidad_id.Text;
                            con = new Conexion();
                            con.cnn.Open();
                            command = new SqlCommand(query_costo_publicacion, con.cnn);
                            lector1 = command.ExecuteReader();
                            lector1.Read();
                            factura.textBox3.Text = lector1.GetDecimal(0).ToString();
                            factura.textBox4.Text = lector1.GetDecimal(0).ToString();
                            con.cnn.Close();
                        }
                        //Traigo los datos del cliente
                        string query_datos_empresa;
                        query_datos_empresa = "select c.id,c.documento_tipo,c.documento_numero,c.nombre,c.apellido " +
                                              "from lpb.Usuarios u, lpb.Clientes c where c.Usuario_id=u.id and u.id=" + id_usuario;
                        con = new Conexion();
                        con.cnn.Open();
                        command = new SqlCommand(query_datos_empresa, con.cnn);
                        lector1 = command.ExecuteReader();
                        lector1.Read();

                        factura.lbl_cliente.Text = lector1.GetInt32(0).ToString();
                        factura.lbl_documento_titulo.Text = lector1.GetString(1);
                        factura.lbl_documento.Text = lector1.GetDecimal(2).ToString();
                        factura.lbl_nombre.Text = lector1.GetString(3);
                        factura.lbl_apellido.Text = lector1.GetString(4);
                        con.cnn.Close();
                    }
                    factura.Show();
                }
                this.Close();
                generar.Show();
                generar.reset_publicaciones();

            }
            if (evento == "M")
            {
                //Actualizar Publicacion

                Conexion cn = new Conexion();
                using (SqlCommand cmd = new SqlCommand("lpb.SP_Actualizar_Publicacion", cn.cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Seteo los parametros del SP
                    cmd.Parameters.Add("@codigo_publicacion", SqlDbType.Int);
                    cmd.Parameters.Add("@publicacion_estado", SqlDbType.Int);
                    cmd.Parameters.Add("@publicacion_tipo", SqlDbType.Int);
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@stock", SqlDbType.Int);
                    cmd.Parameters.Add("@fecha_creacion", SqlDbType.DateTime);
                    cmd.Parameters.Add("@fecha_vencimiento", SqlDbType.DateTime);
                    cmd.Parameters.Add("@precio", SqlDbType.Decimal);
                    cmd.Parameters.Add("@acepta_envio", SqlDbType.Bit);
                    cmd.Parameters.Add("@acepta_pregunta", SqlDbType.Bit);
                    cmd.Parameters.Add("@visibilidad_codigo", SqlDbType.Int);


                    // Lleno los parametros
                    cmd.Parameters["@codigo_publicacion"].Value = codigo_publicacion;
                    cmd.Parameters["@publicacion_estado"].Value = publicacion_estado;
                    cmd.Parameters["@publicacion_tipo"].Value = publicacion_tipo;
                    cmd.Parameters["@descripcion"].Value = text_descripcion.Text;
                    cmd.Parameters["@stock"].Value = Convert.ToInt32(text_stock.Text);
                    cmd.Parameters["@fecha_creacion"].Value = date_inicio.Value;
                    cmd.Parameters["@fecha_vencimiento"].Value = date_fin.Value;
                    cmd.Parameters["@precio"].Value = decimal.Parse(text_precio_aux.Text);
                    cmd.Parameters["@acepta_envio"].Value = publicacion_acepta_envio;
                    cmd.Parameters["@acepta_pregunta"].Value = publicacion_acepta_preguntas;
                    cmd.Parameters["@visibilidad_codigo"].Value = Convert.ToInt32(text_visibilidad_id.Text);
                    cn.cnn.Open();
                    cmd.ExecuteNonQuery();
                    cn.cnn.Close();

                    string delete_rubros = "DELETE lpb.PublicacionesPorRubro where publicacion_id=" + codigo_publicacion;
                    cn.cnn.Open();
                    SqlCommand borrar_publicacionPorRubro = new SqlCommand(delete_rubros, cn.cnn);
                    borrar_publicacionPorRubro.ExecuteNonQuery();
                    cn.cnn.Close();
                    foreach (object itemsCheck in checklist_rubros.CheckedItems)
                    {
                        string insert_rubros = "INSERT INTO lpb.PublicacionesPorRubro (publicacion_id, rubro_id) VALUES (" + codigo_publicacion + ",(SELECT r.id FROM lpb.rubros r WHERE r.descripcion = '" + itemsCheck.ToString() + "'))";
                        cn.cnn.Open();
                        SqlCommand insertar_publicacionPorRubro = new SqlCommand(insert_rubros, cn.cnn);
                        insertar_publicacionPorRubro.ExecuteNonQuery();
                        cn.cnn.Close();
                    }


                    MessageBox.Show("Publicacion actualizada exitosamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }

                //ACA VA LO DE CHECKED ACTIVA
                if (radio_activa.Checked == true && !estaba_pausada)
                {

                    Generar_Publicación.Factura factura = new Generar_Publicación.Factura();
                    string query_tipo_usuario;
                    query_tipo_usuario = "select TipoUsuario,nuevo from lpb.usuarios where id=" + id_usuario;
                    Conexion con = new Conexion();
                    con.cnn.Open();
                    SqlCommand command = new SqlCommand(query_tipo_usuario, con.cnn);
                    SqlDataReader lector1 = command.ExecuteReader();
                    lector1.Read();
                    string tipo_usuario = lector1.GetString(0);
                    usuario_nuevo = lector1.GetBoolean(1);
                    con.cnn.Close();
                    factura.dateTimePicker1.Value = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);

                    decimal visibilidad;
                    if (usuario_nuevo)
                    {
                        visibilidad = -1;
                        string query_update_usuario_nuevo;
                        query_update_usuario_nuevo = "update lpb.usuarios set nuevo=0 where id=" + id_usuario;
                        con = new Conexion();
                        con.cnn.Open();
                        command = new SqlCommand(query_update_usuario_nuevo, con.cnn);
                        command.ExecuteNonQuery();
                    }
                    else
                        visibilidad = Convert.ToDecimal(text_visibilidad_id.Text);




                    cn = new Conexion();
                    using (SqlCommand comando = new SqlCommand("lpb.SP_Generar_Facturacion_Publicacion", cn.cnn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        // Seteo los parametros del SP                           

                        comando.Parameters.Add("@fecha_factura", SqlDbType.DateTime);
                        comando.Parameters.Add("@visibilidad_codigo", SqlDbType.Decimal);
                        comando.Parameters.Add("@usuario_id", SqlDbType.Int);
                        comando.Parameters.Add("@publicacion_cod", SqlDbType.Decimal);
                        comando.Parameters.Add("@descripcion", SqlDbType.VarChar, 100);
                        comando.Parameters.Add("@nuevo_codigo_factura", SqlDbType.Decimal).Direction = ParameterDirection.Output;


                        // Lleno los parametros

                        comando.Parameters["@fecha_factura"].Value = factura.dateTimePicker1.Value;
                        comando.Parameters["@visibilidad_codigo"].Value = visibilidad;//Convert.ToDecimal(text_visibilidad_id.Text);
                        comando.Parameters["@usuario_id"].Value = id_usuario;
                        if (evento == "A") //Si es un alta no tengo el codigo de la publicacion por parametro
                            comando.Parameters["@publicacion_cod"].Value = codigo_nuevo;
                        else
                            comando.Parameters["@publicacion_cod"].Value = codigo_publicacion;
                        comando.Parameters["@descripcion"].Value = "Cargos por publicacion " + cmb_visibilidad.Text;

                        cn.cnn.Open();
                        comando.ExecuteNonQuery();

                        // Leer la devolucion del SP
                        Decimal codigo_factura = Convert.ToDecimal(comando.Parameters["@nuevo_codigo_factura"].Value);
                        factura.lbl_numero.Text = codigo_factura.ToString();
                        cn.cnn.Close();

                    }

                    if (tipo_usuario == "Empresa")
                    {
                        factura.lbl_cliente.Text = id_usuario.ToString();
                        factura.lbl_nombre_titulo.Visible = false;
                        factura.lbl_nombre.Visible = false;
                        factura.lbl_apellido_titulo.Visible = false;
                        factura.lbl_apellido.Visible = false;
                        factura.lbl_documento_titulo.Visible = false;
                        factura.lbl_documento.Visible = false;
                        factura.textBox1.Text = "Cargos por publicacion " + cmb_visibilidad.Text;
                        factura.textBox2.Text = "1";

                        if (usuario_nuevo)
                        {
                            factura.textBox3.Text = "0";
                            factura.textBox4.Text = "0";
                        }
                        else
                        {

                            string query_costo_publicacion;
                            query_costo_publicacion = "select precio from lpb.visibilidades where codigo=" + text_visibilidad_id.Text;
                            con = new Conexion();
                            con.cnn.Open();
                            command = new SqlCommand(query_costo_publicacion, con.cnn);
                            lector1 = command.ExecuteReader();
                            lector1.Read();
                            factura.textBox3.Text = lector1.GetDecimal(0).ToString();
                            factura.textBox4.Text = lector1.GetDecimal(0).ToString();
                            con.cnn.Close();
                        }
                        //Traigo los datos de la empresa
                        string query_datos_empresa;
                        query_datos_empresa = "select e.id, e.razonSocial, e.cuit " +
                                              "from lpb.Usuarios u, lpb.Empresas e where e.Usuario_id=u.id and u.id=" + id_usuario;
                        con = new Conexion();
                        con.cnn.Open();
                        command = new SqlCommand(query_datos_empresa, con.cnn);
                        lector1 = command.ExecuteReader();
                        lector1.Read();

                        factura.lbl_cliente.Text = lector1.GetInt32(0).ToString();
                        factura.lbl_razon_social.Text = lector1.GetString(1);
                        factura.lbl_cuit.Text = lector1.GetString(2);

                        con.cnn.Close();


                    }
                    else
                    {
                        factura.lbl_cliente.Text = id_usuario.ToString();

                        factura.lbl_razon_social_titulo.Visible = false;
                        factura.lbl_razon_social.Visible = false;


                        factura.lbl_cuit_titulo.Visible = false;
                        factura.lbl_cuit.Visible = false;


                        factura.textBox1.Text = "Cargos por publicacion " + cmb_visibilidad.Text;
                        factura.textBox2.Text = "1";

                        if (usuario_nuevo)
                        {
                            factura.textBox3.Text = "0";
                            factura.textBox4.Text = "0";
                        }
                        else
                        {

                            string query_costo_publicacion;
                            query_costo_publicacion = "select precio from lpb.visibilidades where codigo=" + text_visibilidad_id.Text;
                            con = new Conexion();
                            con.cnn.Open();
                            command = new SqlCommand(query_costo_publicacion, con.cnn);
                            lector1 = command.ExecuteReader();
                            lector1.Read();
                            factura.textBox3.Text = lector1.GetDecimal(0).ToString();
                            factura.textBox4.Text = lector1.GetDecimal(0).ToString();
                            con.cnn.Close();
                        }
                        //Traigo los datos del cliente
                        string query_datos_empresa;
                        query_datos_empresa = "select c.id,c.documento_tipo,c.documento_numero,c.nombre,c.apellido " +
                                              "from lpb.Usuarios u, lpb.Clientes c where c.Usuario_id=u.id and u.id=" + id_usuario;
                        con = new Conexion();
                        con.cnn.Open();
                        command = new SqlCommand(query_datos_empresa, con.cnn);
                        lector1 = command.ExecuteReader();
                        lector1.Read();

                        factura.lbl_cliente.Text = lector1.GetInt32(0).ToString();
                        factura.lbl_documento_titulo.Text = lector1.GetString(1);
                        factura.lbl_documento.Text = lector1.GetDecimal(2).ToString();
                        factura.lbl_nombre.Text = lector1.GetString(3);
                        factura.lbl_apellido.Text = lector1.GetString(4);
                        con.cnn.Close();
                    }
                    factura.Show();
                }
                this.Close();
                generar.Show();
                generar.reset_publicaciones();


            }
            if (radio_finalizada.Checked == true && radio_subasta.Checked == true)
            {
                DateTime fecha_actual = DateTime.ParseExact(readConfiguracion.Configuracion.fechaSystem(), "yyyy-dd-MM", System.Globalization.CultureInfo.InvariantCulture);       
                Conexion cn = new Conexion();
                cn.cnn.Open();
                bool resultado = cn.executeProcedure(cn.getSchema() + @".SP_Facturar_Subasta_Finalizada", Helper.Help.generarListaParaProcedure("@codigo","@fecha_actual"),codigo_publicacion,fecha_actual);                
                cn.cnn.Close();
            }

        }

        private void check_envio_CheckedChanged(object sender, EventArgs e)
        {
            if (check_envio.Checked == true)
                publicacion_acepta_envio = 1;
            else
                publicacion_acepta_envio = 0;
        }

        private void check_pregunta_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pregunta.Checked == true)
                publicacion_acepta_preguntas = 1;
            else
                publicacion_acepta_preguntas = 0;
        }

        private void check_pregunta_CheckedChanged_1(object sender, EventArgs e)
        {
            if (check_pregunta.Checked == true)
                publicacion_acepta_preguntas = 1;
            else
                publicacion_acepta_preguntas = 0;
        }
    }
}
