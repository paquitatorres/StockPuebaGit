﻿using Dominio;
using Negocio;
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

namespace Solucion_de_inventario_de_stock
{
    public partial class Form1 : Form
    {
        private List<Articulos> listaArticulos; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           ArticulosNegocio negocio = new ArticulosNegocio();
            listaArticulos = negocio.Listar();
            dgvArticulos.DataSource = listaArticulos;

        }
    }
}
