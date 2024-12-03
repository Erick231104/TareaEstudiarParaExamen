using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TiendaMisteriosaApp
{
    public partial class Form1 : Form
    {
        private List<Categoria> _categorias;
        public Form1()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            // Inicialización de categorías y productos
            _categorias = new List<Categoria>
            {
                new Categoria("Electrónica")
                {
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            Nombre = "Teléfono",
                            Precio = 250,
                            Cantidad = 20,
                            Descripcion = "Teléfono inteligente de última generación",
                            Proveedor = "Proveedor A",
                            UltimoReabastecimiento = DateTime.Today.AddDays(-10)
                        },
                        new Producto
                        {
                            Nombre = "Accesorios",
                            Precio = 20,
                            Cantidad = 50,
                            Descripcion = "Accesorios para teléfonos móviles",
                            Proveedor = "Proveedor B",
                            UltimoReabastecimiento = DateTime.Today.AddDays(-5)
                        }
                    }
                },
                new Categoria("Hogar")
                {
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            Nombre = "Muebles",
                            Precio = 500,
                            Cantidad = 10,
                            Descripcion = "Muebles para el hogar",
                            Proveedor = "Proveedor C",
                            UltimoReabastecimiento = DateTime.Today.AddDays(-20)
                        },
                        new Producto
                        {
                            Nombre = "Decoración",
                            Precio = 30,
                            Cantidad = 15,
                            Descripcion = "Artículos de decoración",
                            Proveedor = "Proveedor D",
                            UltimoReabastecimiento = DateTime.Today.AddDays(-8)
                        }
                    }
                }
            };

            // Cargar las categorías en el TreeView (Debes tener un TreeView en tu formulario)
            foreach (var categoria in _categorias)
            {
                // Crear un nodo de categoría
                var nodoCategoria = new TreeNode(categoria.Nombre) { Tag = categoria };

                // Agregar el nodo de categoría al TreeView
                treeView1.Nodes.Add(nodoCategoria); // Asegúrate de usar el nombre correcto del TreeView
            }


        }




        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var producto = (Producto)listView1.SelectedItems[0].Tag;
                producto.Cantidad = hScrollBar1.Value;
                listView1.SelectedItems[0].SubItems[2].Text = producto.Cantidad.ToString();
                progressBar1.Value = Math.Min(100, producto.Cantidad);
            }
        }

      
    
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var producto = (Producto)listView1.SelectedItems[0].Tag;
                producto.Precio = trackBar1.Value;
                listView1.SelectedItems[0].SubItems[1].Text = producto.Precio.ToString("C2");
            }
        }

       

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Categoria categoriaSeleccionada)
            {
                listView1.Items.Clear();
                foreach (var producto in categoriaSeleccionada.Productos)
                {
                    var item = new ListViewItem(producto.Nombre)
                    {
                        Tag = producto
                    };
                    item.SubItems.Add(producto.Precio.ToString("C2"));
                    item.SubItems.Add(producto.Cantidad.ToString());
                    item.SubItems.Add(producto.Cantidad > 0 ? "En stock" : "Agotado");
                    listView1.Items.Add(item);
                }
            }
        }
        private void MostrarProductos(Categoria categoria)
        {
            listView1.Items.Clear();
            foreach (var producto in categoria.Productos)
            {
                var item = new ListViewItem(producto.Nombre)
                {
                    Tag = producto
                };
                item.SubItems.Add(producto.Precio.ToString("C2"));
                item.SubItems.Add(producto.Cantidad.ToString());
                item.SubItems.Add(producto.Cantidad > 0 ? "En stock" : "Agotado");
                listView1.Items.Add(item);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var producto = (Producto)listView1.SelectedItems[0].Tag;

                // Mostrar detalles del producto en el DataGridView
                MostrarDetallesProducto(producto);
            }
        }

        private void MostrarDetallesProducto(Producto producto)
        {
            
            // Llenar DataGridView con los detalles del producto seleccionado
            DataTable dt = new DataTable();
            dt.Columns.Add("Propiedad");
            dt.Columns.Add("Valor");

            dt.Rows.Add("Nombre", producto.Nombre);
            dt.Rows.Add("Precio", producto.Precio.ToString("C2"));
            dt.Rows.Add("Cantidad", producto.Cantidad);
            dt.Rows.Add("Descripción", producto.Descripcion);
            dt.Rows.Add("Proveedor", producto.Proveedor);
            dt.Rows.Add("Último Reabastecimiento", producto.UltimoReabastecimiento.ToShortDateString());

            dataGridView1.DataSource = dt;

            // Ajustar TrackBar y ProgressBar
            trackBar1.Value = (int)producto.Precio;
            progressBar1.Value = Math.Min(100, producto.Cantidad); //
        }
    }
}
