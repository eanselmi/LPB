﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conectar;
using System.Data.SqlClient;

namespace visibilidad.ABM_Visibilidad
{
    public partial class BuscarVisibilidad : Form
    {
        public BuscarVisibilidad()
        {
            InitializeComponent();
            Conexion con = new Conexion();
            String query = "SELECT descripcion FROM lpb.visibilidades";
          
            con.cnn.Open();
            SqlCommand command = new SqlCommand(query, con.cnn);
            SqlDataReader lector = command.ExecuteReader();

            while (lector.Read()){
                combo_visibilidades.Items.Add(lector.GetString(0));
            }
            con.cnn.Close();
            btn_seleccionar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combo_funciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_visibilidades.Text != "")
                btn_seleccionar.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e) {
            ABM_Visibilidad.ModificacionVisiblidad abmVisibilidad = new ABM_Visibilidad.ModificacionVisiblidad(combo_visibilidades.Text);
            abmVisibilidad.Show();
            this.Close();
        }
    }
}
