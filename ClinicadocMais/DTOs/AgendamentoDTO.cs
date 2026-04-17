using ClinicadocMais.Models;

namespace ClinicadocMais.DTOs
{
    public class AgendamentoDTO
    {
        public PacienteModel? paciente { get; set; }
        public MedicoModel? medico { get; set; }
        public DateTime? dataHoraAgendada { get; set; }
    }
}
