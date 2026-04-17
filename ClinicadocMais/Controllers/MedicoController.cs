using ClinicadocMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ClinicadocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        public static List<MedicoModel> listaMedicos = new List<MedicoModel>();

        [HttpPost("cadastroMedico")]
            public string cadastrarMedico([FromBody] MedicoModel medicoCadastro)
        {
            listaMedicos.Add(medicoCadastro);
            return $"Dr. {medicoCadastro.nome} cadatrado com sucesso";
         
        }

        [HttpGet("listarMedicos")]
        public List<MedicoModel> listarMedicos()
        {
            return (listaMedicos);
        }

    
        [HttpGet("buscarMedico/{crm}")]
        public MedicoModel? buscarMedico(string crm)
        {
            return listaMedicos.FirstOrDefault(m => m.crm == crm);
        }


        [HttpPut("editarMedico/{crm}")]
        public string editarMedico(string crm, [FromBody] MedicoModel medicoEditado)
        {
            MedicoModel? medico = listaMedicos.FirstOrDefault(m => m.crm == crm);

            if (medico == null)
            {
                return "Médico não encontrado.";
            }

            medico.nome = medicoEditado.nome;
            medico.especialidade = medicoEditado.especialidade;
            medico.Telefone = medicoEditado.Telefone;

            return "Médico atualizado com sucesso.";
        }

    }
}



