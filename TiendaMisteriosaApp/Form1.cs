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
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ProductosValor(hScrollBar1.Value);
        }

        private void ProductosValor(int value)
        {
            // Sincroniza los valores entre los controles
            hScrollBar1.Value = value;
            progressBar1.Value = value;


            // Actualiza el Label
            lblProducto.Text = $"Valor actual: {value}";
            lblProductoExistenmte.Text = $"Producto existente : {value}";

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PrecioProducto(trackBar1.Value);
        }

        private void PrecioProducto(int value)
        {
            trackBar1.Value = value;
            progressBar1.Value = value;

            // Actualiza el Label
            lblPrecioProducto.Text = $"Valor actual: {value}";
            lblProductoExistenmte.Text = $"Producto existente : {value}";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProductosValor(progressBar1.Value);
            PrecioProducto(progressBar1.Value);
        }

    }
}
