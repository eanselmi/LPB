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

        public void cargarPublicaciones(DataTable publis, String tipo, String filter_desc, CheckedListBox.CheckedItemCollection rubros)
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

            Conexion con = new Conexion();
            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con.cnn);
            SqlCommandBuilder sqlCommandSub = new SqlCommandBuilder(dataAdapter);
            con.cnn.Close();

            dataAdapter.Fill(publis);
    
            
           return;
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

        public void crearColumnas(DataGridView publis, int columna, String nombre, String header, Boolean visible)
        {
            publis.Columns[columna].Name = nombre;
            publis.Columns[columna].HeaderText = header;
            publis.Columns[columna].DataPropertyName = nombre;
            publis.Columns[columna].Visible = visible;

        }
    }
}