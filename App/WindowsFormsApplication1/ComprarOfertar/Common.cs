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
            String query = "";

            if (rubros != null && rubros.Count > 0)
            {
                query += "select p.codigo, p.Usuario_id, p.EstadoDePublicacion_id, p.descripcion, p.stock, p.fechaVencimiento, p.precio, p.aceptaEnvio, p.aceptaPreguntas, p.Visibilidad_codigo " +
                        " from  LPB.Publicaciones p, LPB.Rubros r, LPB.PublicacionesPorRubro pr, LPB.TiposDePublicacion t , LPB.Visibilidades v " +
                        " where p.codigo = pr.Publicacion_id and r.id = pr.Rubro_id and t.id = p.TipoDePublicacion_id and  v.codigo = p.Visibilidad_codigo " +
                        " and t.descripcion = '" + tipo + "' ";
           
                query += applyFilterDescr(filter_desc);
                query += " and (";
                query += applyFilterRubros(rubros);
                query += ") ";   
            }
            else
            {
                query += "select p.codigo, p.Usuario_id, p.EstadoDePublicacion_id, p.descripcion, " +
                        "p.stock, p.fechaVencimiento, p.precio, p.aceptaEnvio, p.aceptaPreguntas, p.Visibilidad_codigo " +
                        " from LPB.Publicaciones p , LPB.TiposDePublicacion t, LPB.Visibilidades v " +
                        " where  t.id = p.TipoDePublicacion_id and v.codigo = p.Visibilidad_codigo " +
                        " and t.descripcion = '" + tipo + "' ";

                  query += applyFilterDescr(filter_desc);
            }

            query += " order by v.precio desc" ;
      
           return generarTabla(query, publis);
        }

        private String applyFilterRubros(CheckedListBox.CheckedItemCollection rubros)
        {
            String query = "";
            int index = 0;
            foreach (String rubro_desc in rubros)
            {
                index++;
                query += " r.descripcion = '" + rubro_desc +"'" ;
                if(!index.Equals(rubros.Count)){
                   query += " or ";
                }
            }

            return query;
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

        private DataGridView generarTabla(String query, DataGridView publis)
        {
            Conexion con = new Conexion();
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

            crearColumnas(publis, 0, "codigo", "Código", true);
            crearColumnas(publis, 1, "Usuario_id", "Usuario_id", false);
            crearColumnas(publis, 2, "EstadoDePublicacion_id", "EstadoDePublicacion_id", false);
            crearColumnas(publis, 3, "descripcion", "Descripción", true);
            crearColumnas(publis, 4, "stock", "Stock", true);
            crearColumnas(publis, 5, "fechaVencimiento", "Fecha de Vencimiento", true);
            crearColumnas(publis, 6, "precio", "Precio", true);
            crearColumnas(publis, 7, "aceptaEnvio", "aceptaEnvio", false);
            crearColumnas(publis, 8, "aceptaPreguntas", "aceptaPreguntas", false);
            crearColumnas(publis, 9, "Visibilidad_codigo", "Visibilidad_codigo", false);

            return publis;
        }

        private void crearColumnas(DataGridView publis, int columna, String nombre, String header, Boolean visible)
        {
            publis.Columns[columna].Name = nombre;
            publis.Columns[columna].HeaderText = header;
            publis.Columns[columna].DataPropertyName = nombre;
            publis.Columns[columna].Visible = visible;
        }

        public DataGridViewRow actualizarPublicacion(DataGridView publis, int publicacionSeleccionada)
        {
            String query = "select * from LPB.Publicaciones where codigo = " + publicacionSeleccionada.ToString();
            DataGridView table =  generarTabla(query, publis);
            return table.Rows[0];
        }
    }
}