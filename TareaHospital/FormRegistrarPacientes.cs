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
    public partial class RegistrarPacientesForm : Form
    {
        private List<Paciente> listaPacientes = new List<Paciente>();

        public RegistrarPacientesForm()
        {
            InitializeComponent();
            ConfigurarComboBoxTipoPaciente();
        }

        private void ConfigurarComboBoxTipoPaciente()
        {
            cmbTipoPaciente.DataSource = Enum.GetValues(typeof(TipoPaciente));
            cmbTipoPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void GaurdarPaciente(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string diagnostico = txtDiagnostico.Text;
            TipoPaciente tipo = (TipoPaciente)cmbTipoPaciente.SelectedItem;
            string telefono = mtbTelefono.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(diagnostico))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!mtbTelefono.MaskCompleted)
            {
                MessageBox.Show("El teléfono no está completo.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoPaciente = new Paciente
            {
                Nombre = nombre,
                FechaNacimiento = fechaNacimiento,
                Diagnostico = diagnostico,
                Tipo = tipo,
                Telefono = telefono
            };

            listaPacientes.Add(nuevoPaciente);

            MessageBox.Show("Paciente registrado con éxito.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDiagnostico.Clear();
            cmbTipoPaciente.SelectedIndex = 0;
            mtbTelefono.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        public List<Paciente> ObtenerListaPacientes()
        {
            return new List<Paciente>(listaPacientes);
        }

        public bool HayPacientes()
        {
            return listaPacientes.Count > 0;
        }
    }
}
    

