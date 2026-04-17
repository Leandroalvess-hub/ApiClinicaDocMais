using ClinicadocMais.DTOs;
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
        public async Task<IActionResult> AgendarConsulta([FromBody] AgendamentoDTO dadosAgendamento)
        {
            try
            {
                AgendamentoModel agendamento = new AgendamentoModel();
                agendamento.nomePaciente = dadosAgendamento.paciente?.nome;
                agendamento.nomeMedico = dadosAgendamento.medico?.nome;
                agendamento.cpfPaciente = dadosAgendamento.paciente?.cpf;
                agendamento.telefonePaciente = dadosAgendamento.paciente?.telefone;
                agendamento.crmMedico = dadosAgendamento.medico?.crm;
                agendamento.especialidadeMedico = dadosAgendamento.medico?.especialidade;
                agendamento.dataHoraAgendamento = dadosAgendamento.dataHoraAgendada;

                listaDeAgendamentos.Add(agendamento);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro inesperado: " + ex.Message);
            }
        }
    }
}
