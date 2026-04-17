using ClinicadocMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;



namespace ClinicaDocMais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : Controller
    {
        public static List<PacienteModel> listaPacientes = new List<PacienteModel>();

        [HttpPost("cadastrarPaciente")]
        public async Task<ActionResult> Cadastrarpaciente([FromBody] PacienteModel pacienteCadastrado)
        {
            try
            {
                listaPacientes.Add(pacienteCadastrado);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro inexperado: "+ ex.Message);
            }
        }

        [HttpGet("pacientes")]
        public List<PacienteModel> listarPacientes()
        {
            PacienteModel novoPaciente = new PacienteModel("1019210", "Giovanni", "10/04/1999", "Vermelha");
            listaPacientes.Add(novoPaciente);
            novoPaciente = new PacienteModel("1020220", "Eduarda", "15/03/1990", "Verde");
            listaPacientes.Add(novoPaciente);
            return listaPacientes;
        }
        [HttpGet("buscaPaciente/{id}")]
        public PacienteModel? buscarPaciente(string id)
        {
            foreach (var paciente in listaPacientes)
                if (paciente.cpf == id)
                {
                    return paciente;
                }
            return null;
        }
        [HttpPut("editarPaciente/{id}")]
        public string editarPaciente([FromBody] PacienteModel pacienteEditado, string id)
        {
            foreach (var paciente in listaPacientes)
            {
                if (paciente.cpf == id)
                {
                    paciente.cpf = pacienteEditado.cpf;
                    paciente.nome = pacienteEditado.nome;
                    paciente.telefone = pacienteEditado.telefone;
                    paciente.email = pacienteEditado.email;
                    paciente.prioridade = pacienteEditado.prioridade;
                    paciente.dataNascimento = pacienteEditado.dataNascimento;
                    return $"Paciente {paciente.nome},cpf anterior: {id} editado com sucesso";
                }
            }

            return "Paciente não encontrado";
        }
        [HttpPut("deletar/{id}")]
        public string deletarPaciente(string id)
        {
            foreach (var paciente in listaPacientes)
            {
                if (paciente.cpf == id)
                {
                    listaPacientes.Remove(paciente);
                    return $"Paciente com cpf: {id} deletado com sucesso";
                }

            }
            return "paciente não encontrado";
        }
    }
}