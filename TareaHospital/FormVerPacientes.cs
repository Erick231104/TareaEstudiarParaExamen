using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TareaHospital
{
    public partial class FormVerPacientes : Form
    {
        private List<Paciente> _pacientes;

        // Constructor parametrizado
        public FormVerPacientes(List<Paciente> pacientes)
        {
            InitializeComponent();
            _pacientes = pacientes ?? new List<Paciente>(); // Inicializa la lista si es null
            ConfigurarTabla(_pacientes); // Llama al método con la lista
        }

        // Constructor vacío (si es necesario, aunque se recomienda usar solo el parametrizado)
        public FormVerPacientes()
        {
            InitializeComponent();
            _pacientes = new List<Paciente>(); // Inicializar con lista vacía
        }

        private void ConfigurarTabla(List<Paciente> pacientes)
        {
            if (pacientes == null || !pacientes.Any())
            {
                MessageBox.Show("No hay pacientes para mostrar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int fila = 1;
            foreach (var paciente in pacientes)
            {
                // Asegúrate de que tableLayoutPanel1 está en el formulario antes de este código
                tableLayoutPanel1.Controls.Add(new Label { Text = paciente.Nombre }, 0, fila);
                tableLayoutPanel1.Controls.Add(new Label { Text = paciente.FechaNacimiento.ToShortDateString() }, 1, fila);
                tableLayoutPanel1.Controls.Add(new Label { Text = paciente.Diagnostico }, 2, fila);
                tableLayoutPanel1.Controls.Add(new Label { Text = paciente.Tipo.ToString() }, 3, fila);
                fila++;
            }
        }
    }
   
}
