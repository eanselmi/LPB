﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conectar;
using System.Data.SqlClient;
using System.Data;

namespace common
{
    class Common
    {
        public CheckedListBox cargarRubros(CheckedListBox rubros)
        {
            Conexion con = new Conexion();
            String query = "SELECT descripcion FROM lpb.Rubros";

            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();

            while (lector.Read())
            {
                rubros.Items.Add(lector.GetString(0));
            }
            con.cnn.Close();

            return rubros;
        }

        public DataGridView cargarPublicaciones(DataGridView publis, String tipo, String filter_desc, CheckedListBox.CheckedItemCollection rubros)
        {
            Conexion con = new Conexion();
            String query = "select p.codigo, p.Usuario_id, p.EstadoDePublicacion_id, p.descripcion, " +
            "p.stock, p.fechaVencimiento, p.precio, p.aceptaEnvio, p.aceptaPreguntas, p.Visibilidad_codigo " +
            " from LPB.Publicaciones p inner join LPB.TiposDePublicacion t on t.id = p.TipoDePublicacion_id " +
            " inner join LPB.Visibilidades v on v.codigo = p.Visibilidad_codigo " +
            " where t.descripcion = '" + tipo + "' ";
            if (rubros != null)
            {
                foreach (string rubro in rubros)
                {
                    MessageBox.Show(rubro, "Rubro seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            query += applyFilterDescr(filter_desc);
           // query += applyFilterRubros(rubros);

            query += " order by v.precio desc" ;

            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();
            DataTable publis_table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con.cnn);
            con.cnn.Close();

            publis.AutoGenerateColumns = false;
            dataAdapter.Fill(publis_table);
            publis.ReadOnly = true;
            publis.DataSource = publis_table;
         
           crearColumnas(publis, 0,"codigo", "Código", true);
           crearColumnas(publis, 1, "Usuario_id", "Usuario_id", false);
           crearColumnas(publis, 2, "EstadoDePublicacion_id", "EstadoDePublicacion_id", false);
           crearColumnas(publis, 3, "descripcion", "Descripción",true);
           crearColumnas(publis, 4, "stock", "Stock", true);
           crearColumnas(publis, 5, "fechaVencimiento", "Fecha de Vencimiento", true);
           crearColumnas(publis, 6, "precio", "Precio", true);
           crearColumnas(publis, 7, "aceptaEnvio", "aceptaEnvio", false);
           crearColumnas(publis, 8, "aceptaPreguntas", "aceptaPreguntas", false);
           crearColumnas(publis, 9, "Visibilidad_codigo", "Visibilidad_codigo", false);
      
           return publis;
        }

        private String applyFilterDescr(String desc)
        {
            if (desc != null && !desc.Equals(""))
            {
                return " and p.descripcion like '%" + desc + "%'";
            }
            else
            {
                return "";
            }
        }

        private String applyFilterRubros(List<String> rubros)
        {
            return "";
        }

        private void crearColumnas(DataGridView publis, int columna, String nombre, String header, Boolean visible)
        {
            publis.Columns[columna].Name = nombre;
            publis.Columns[columna].HeaderText = header;
            publis.Columns[columna].DataPropertyName = nombre;
            publis.Columns[columna].Visible = visible;

        }
    }
}