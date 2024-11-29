
using System.Collections.Generic;
using System;

namespace TareaHospital
{
    public enum TipoPaciente
    {
        Ambulatorio,
        Hospitalizado,
        Urgencias
    }

    public  class Paciente
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Diagnostico { get; set; }
        public TipoPaciente Tipo { get; set; }
        public string Telefono { get; set; }
    }
}
