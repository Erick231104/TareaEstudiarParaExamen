using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResumen.Text = string.Empty;
        }

        private void Confirmar(object sender, EventArgs e)
        {
            if(cmbDepartamento.SelectedItem == null)
            {
                MessageBox.Show("Deve selecionar un departamento principal:", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmacion = MessageBox.Show("Desea gurdar esta configuracion?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes)
            return;

            string resumen = GeneraResumenConfiguracion();
            MessageBox.Show(resumen, "Resumen realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GeneraResumenConfiguracion()
        {
            string email = ckbEmail.Checked ? "Si" : "No";

            string SMS = ckbSMS.Checked ? "Si" : "No";

            string rolUsuario = rbAdministracion.Checked ? "Administrador" :
                (rbUsuarioRegular.Checked ? "Usuario Regular" :  "No Selecionado");

            string departamento = cmbDepartamento.SelectedItem != null ?
                cmbDepartamento.SelectedItem.ToString() : "No selecionado";

            string departamentoSeleccionado = lstPreferenciasNotificacion.SelectedItems.Count > 0 ?
                string.Join(",", lstPreferenciasNotificacion.SelectedItems.Cast<string>()) : "Ninguna";

            var opcionesAvanzadas = ckLOpcionesAvanzadas.CheckedItems.Cast<string>();
            string opcionesAvanzadasAdicionales = opcionesAvanzadas.Any() ?
                string.Join(",", opcionesAvanzadas) : "Ninguna";

            return $"Email : {email}\n" +
             $"SMS : {SMS}\n" +
             $"Rol de usuario : {rolUsuario}\n" +
             $"Departamento : {departamento}\n" +
             $"Departamento Selecionado : {departamentoSeleccionado}\n" +
             $"Opciones Avanzadas : {opcionesAvanzadas}\n";
      
        }

        private void Guardar(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =  "Text Files(*.txt)|*.txt | All Files (*.*) | *.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string resumen = GeneraResumenConfiguracion();
                File.WriteAllText(saveFileDialog.FileName, resumen);
                MessageBox.Show("Configuracion guardada exitosamente.", 
                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarConfiguracion(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files(*.txt)|*.txt | All Files (*.*) | *.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] configuracion = File.ReadAllLines(openFileDialog.FileName);
                AplicarConfiguracionUsuario(configuracion);
                MessageBox.Show("Configuracion de usuario cargada exitosamente", "Informacion del usuario"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AplicarConfiguracionUsuario(string[] configuracion)
        {
            // Corrección: Validación de los valores al cargar configuraciones
            ckbEmail.Checked = configuracion.Any(line => line.Contains("Email: Sí"));
            ckbSMS.Checked = configuracion.Any(line => line.Contains("SMS: Sí"));
            rbAdministracion.Checked = configuracion.Any(line => line.Contains("Rol de usuario: Administrador"));
            rbUsuarioRegular.Checked = configuracion.Any(line => line.Contains("Rol de usuario: Usuario Regular"));

            // Mejora: Manejo de selección en ComboBox
            string departamento = configuracion.FirstOrDefault(line =>
                line.StartsWith("Departamento: "))?.Split(':')[1].Trim();
            if (!string.IsNullOrEmpty(departamento) && cmbDepartamento.Items.Contains(departamento))
            {
                cmbDepartamento.SelectedItem = departamento;
            }

            // Mejora: Manejo de selección múltiple en listas
            string preferencias = configuracion.FirstOrDefault(line =>
                line.StartsWith("Preferencias de notificación: "))?.Split(':')[1].Trim();
            if (!string.IsNullOrEmpty(preferencias))
            {
                foreach (string pref in preferencias.Split(',').Select(p => p.Trim()))
                {
                    int index = lstPreferenciasNotificacion.Items.IndexOf(pref);
                    if (index >= 0)
                    {
                        lstPreferenciasNotificacion.SetSelected(index, true);
                    }
                }
            }

            // Manejo de opciones avanzadas
            string opcionesAvanzadas = configuracion.FirstOrDefault(line =>
                line.StartsWith("Opciones avanzadas: "))?.Split(':')[1].Trim();
            if (!string.IsNullOrEmpty(opcionesAvanzadas))
            {
                foreach (string opcion in opcionesAvanzadas.Split(',').Select(o => o.Trim()))
                {
                    int index = ckLOpcionesAvanzadas.Items.IndexOf(opcion);
                    if (index >= 0)
                    {
                        ckLOpcionesAvanzadas.SetItemChecked(index, true);
                    }
                }
            }

        }

        private void SelecioneFotoDePerfil(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|Todos los archivos (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Usar FileStream para cargar la imagen en el PictureBox
                    using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                       ptbSelecionFoto.Image = Image.FromStream(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
