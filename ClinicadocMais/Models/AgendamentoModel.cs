namespace ClinicadocMais.Models
{
    public class AgendamentoModel
    {
        public class Agendamento
        {
          public string? nomePaciente { get; set; }
            public string? telefonePaciente { get; set;}
            public string? cpfPaciente { get; set;}
            public string? nomeMedico { get; set; }
            public string? crmMedico { get; set; }
            public string? especialidadeMedico {  get; set; }
            public DateTime dataHoraAgendamneto { get; set; }
            public bool pacientePresente { get; set; }
            public bool medicoPresente { get; set; }

        }
    }
}
