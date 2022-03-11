using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploProductos
{
    public partial class Form2 : Form
    {
        public ListaProducto listaProducto2 = new ListaProducto();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvProducto.DataSource = listaProducto2.Productos;
        }
    }
}
