using ClinicadocMais.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicadocMais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        public static List<AgendamentoModel> listaDeAgendamentos = new List<AgendamentoModel>();

        [HttpPost("agendarconsulta")]
        public async Task<IActionResult> AgendarConsulta(
            [FromBody] PacienteModel pacienteAgendado,
            MedicoModel medicoAgendado,
            DateTime dataHoraAgendada)
        {
            try
            {
                AgendamentoModel agendamentoAtual = new AgendamentoModel();

                agendamentoAtual.nomePaciente = pacienteAgendado.nome;
                agendamentoAtual.telefonePaciente = pacienteAgendado.telefone;
                agendamentoAtual.cpfPaciente = pacienteAgendado.cpf;

                agendamentoAtual.nomeMedico = medicoAgendado.nome;
                agendamentoAtual.crmMedico = medicoAgendado.crm;
                agendamentoAtual.especialidadeMedico = medicoAgendado.especialidade;

                agendamentoAtual.datahoraAgendamento = dataHoraAgendada;

                listaDeAgendamentos.Add(agendamentoAtual);

                return Created("", agendamentoAtual);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro inesperado: " + ex.Message);
            }
        }
    }
}
