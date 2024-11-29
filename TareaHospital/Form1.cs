using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaHospital
{
  
    public partial class Form1 : Form
    {
        private RegistrarPacientesForm registrarPacientesForm = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void RegsitroPaciente(object sender, EventArgs e)
        {
            if (registrarPacientesForm == null)
            {
                registrarPacientesForm = new RegistrarPacientesForm();
            }
            MostrarFormularioEnTabPage(registrarPacientesForm, tabPage1);

        }

        private void VerPacientees(object sender, EventArgs e)
        {
            if (registrarPacientesForm == null || !registrarPacientesForm.HayPacientes())
            {
                MessageBox.Show("No hay pacientes registrados aún.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var listaPacientes = registrarPacientesForm.ObtenerListaPacientes();
            var formVerPacientes = new FormVerPacientes(listaPacientes);
            MostrarFormularioEnTabPage(formVerPacientes, tabPage2);
        }

        private void MostrarFormularioEnTabPage(Form formulario, TabPage tabPage)
        {
            tabPage.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            tabPage.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
